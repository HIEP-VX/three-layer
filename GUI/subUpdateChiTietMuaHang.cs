using DAL;
using DTO;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class subUpdateChiTietMuaHang : Form
    {
        public event Action DataAdded;
        private int index = -1;

        public subUpdateChiTietMuaHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            string sql = "select * FROM hoaDonNhanHang where maMH = " + phieuNhanHang.maMH + "and tinhTrang = 1";
            dt1 = AccessData.getData(sql);
            if (dt1.Rows.Count > 0)
            {
                MessageBox.Show("Phiếu mua hàng này đã được thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (txtTenSP.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn cần nhập chi tiết mua hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenSP.Focus();
                    return;
                }

                if (txtChiSoCongTo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn cần nhập chỉ số công tơ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtChiSoCongTo.Focus();
                    return;
                }

                if (txtHangSX.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn cần nhập hãng sản xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHangSX.Focus();
                    return;
                }

                if (txtSL.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn cần nhập số lượng sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSL.Focus();
                    return;
                }

                if (txtTien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn cần nhập đơn giá cho sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTien.Focus();
                    return;
                }

                DataTable dt = new DataTable();
                string query5 = "SELECT maSP FROM loaiDongHo WHERE tenSP = N'" + txtTenSP.Text + "' AND chiSoCongTo = " + txtChiSoCongTo.Text + " AND tenHangSX = N'" + txtHangSX.Text + "'";
                dt = AccessData.getData(query5);

                if (dt.Rows.Count > 0)
                {
                    int ma = Convert.ToInt32(dt.Rows[0]["maSP"]);

                    string query1 = "UPDATE chiTietMuaHang set soLuong = soLuong + @soLuong where maSP = " + ma +
                                    "UPDATE phieuNhanHang set tongTien = tongTien + (CONVERT(MONEY, @tien) * @soLuong) from phieuNhanHang join chiTietMuaHang ct on ct.maMH = phieuNhanHang.maMH where phieuNhanHang.maMH = phieuNhanHang.maMH";
                    using (SqlConnection conn = SqlConnectionData.connect())
                    {
                        conn.Open();

                        // Bắt đầu giao dịch
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                using (SqlCommand cmd = new SqlCommand(query1, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@soLuong", int.Parse(txtSL.Text));
                                    cmd.Parameters.AddWithValue("@tien", txtTien.Text);

                                    cmd.ExecuteNonQuery();
                                }
                                transaction.Commit();
                                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Lỗi: " + ex.Message + "\nStack Trace:\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        DataAdded?.Invoke();
                        reload();
                    }
                }
                else
                {
                    string query = "DECLARE @Inserted_maCTMH INT,@Inserted_maSP INT,@Inserted_soLuong INT, @Inserted_tien MONEY, @Inserted_tenSP NVARCHAR(MAX), @Inserted_chiSoCongTo INT, @Inserted_tenHangSX NVARCHAR(MAX)\n" +
                                "INSERT INTO chiTietMuaHang (soLuong, tien) values (@soLuong, @tien)\n" +

                                "SELECT @Inserted_maCTMH = SCOPE_IDENTITY(),@Inserted_soLuong = soLuong,@Inserted_tien = tien FROM chiTietMuaHang WHERE maChiTiet = SCOPE_IDENTITY();\n" +

                                "update chiTietMuaHang set maMH = " + phieuNhanHang.maMH + " where maChiTiet = @Inserted_maCTMH\n" +

                                "INSERT INTO loaiDongHo (tenSP, chiSoCongTo, tenHangSX) values (@tenSP, @chiSoCongTo, @tenHangSX)\n" +
                                "SET @Inserted_maSP = SCOPE_IDENTITY();" +
                                "update chiTietMuaHang set maSP = @Inserted_maSP where maChiTiet = @Inserted_maCTMH\n" +

                                "update phieuNhanHang set tongTien = tongTien + (@Inserted_soLuong * @Inserted_tien) where maMH = " + phieuNhanHang.maMH;

                    using (SqlConnection conn = SqlConnectionData.connect())
                    {

                        conn.Open();

                        // Bắt đầu giao dịch
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                                {
                                    // Thêm các tham số cho query
                                    cmd.Parameters.AddWithValue("@soLuong", txtSL.Text);
                                    cmd.Parameters.AddWithValue("@tien", txtTien.Text);
                                    cmd.Parameters.AddWithValue("@tenSP", txtTenSP.Text);
                                    cmd.Parameters.AddWithValue("@chiSoCongTo", txtChiSoCongTo.Text);
                                    cmd.Parameters.AddWithValue("@tenHangSX", txtHangSX.Text);

                                    // Thực hiện lệnh query
                                    cmd.ExecuteNonQuery();
                                }

                                // Commit giao dịch nếu mọi thứ thành công
                                transaction.Commit();
                                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        DataAdded?.Invoke();
                        reload();
                    }
                }
            }
            
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "select * FROM hoaDonNhanHang where maMH = " + phieuNhanHang.maMH + "and tinhTrang = 1";
            dt = AccessData.getData(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Phiếu mua hàng này đã được thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (index == -1)
                {
                    MessageBox.Show("Vui lòng chọn bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sql1 = "update loaiDongHo SET tenSP = @tenSP, chiSoCongTo = @chiSoCongTo, tenHangSX = @tenHangSX where maSP = @maSP\n" +
                             "update chiTietMuaHang set soLuong = @soLuong, tien = @tien where maChiTiet = @maChiTiet and maSP = @maSP\n" +
                             "UPDATE phieuNhanHang SET tongTien = (SELECT SUM(soLuong * tien) FROM ChiTietMuaHang WHERE maMH = " + phieuNhanHang.maMH + ") WHERE maMH = " + phieuNhanHang.maMH;

                    using (SqlConnection conn = SqlConnectionData.connect())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql1, conn);
                        cmd.Parameters.AddWithValue("@maSP", txtMaSP.Text);
                        cmd.Parameters.AddWithValue("@tenSP", txtTenSP.Text);
                        cmd.Parameters.AddWithValue("@tenHangSX", txtHangSX.Text);
                        cmd.Parameters.AddWithValue("@maChiTiet", txtMaCT.Text);
                        cmd.Parameters.AddWithValue("@chiSoCongTo", txtChiSoCongTo.Text);
                        cmd.Parameters.AddWithValue("@soLuong", txtSL.Text);
                        cmd.Parameters.AddWithValue("@tien", txtTien.Text);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reload();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void reload()
        {
            dgvSP.RowTemplate.Height = 26;
            lblMaMH.Text = "Mã mua hàng: " + phieuNhanHang.maMH.ToString();
            try
            {
                string query3 = "Select ct.maChiTiet, ldh.maSP, ldh.tenSP, ldh.tenHangSX, ldh.chiSoCongTo, ct.soLuong, FORMAT(CAST(ct.tien AS DECIMAL(18, 0)), 'N0') AS tien from loaiDongHo ldh\n" +
                            "join chiTietMuaHang ct on ct.maSP = ldh.maSP\n" +
                            "where ct.maMH = " + phieuNhanHang.maMH;
                dgvSP.DataSource = AccessData.getData(query3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void subUpdateChiTietMuaHang_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMaCT.Text = dgvSP.Rows[index].Cells[0].Value.ToString();
            txtMaSP.Text = dgvSP.Rows[index].Cells[1].Value.ToString();
            txtTenSP.Text = dgvSP.Rows[index].Cells[2].Value.ToString();
            txtChiSoCongTo.Text = dgvSP.Rows[index].Cells[4].Value.ToString();
            txtHangSX.Text = dgvSP.Rows[index].Cells[3].Value.ToString();
            txtSL.Text = dgvSP.Rows[index].Cells[5].Value.ToString();
            txtTien.Text = dgvSP.Rows[index].Cells[6].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "select * FROM hoaDonNhanHang where maMH = " + phieuNhanHang.maMH + "and tinhTrang = 1";
            dt = AccessData.getData(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Phiếu mua hàng này đã được thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (index == -1)
                {
                    MessageBox.Show("Vui lòng chọn bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string sql1 = "delete loaiDongHo where maSP = @maSP\n" +
                             "UPDATE phieuNhanHang SET tongTien = (SELECT SUM(soLuong * tien) FROM ChiTietMuaHang WHERE maMH = " + phieuNhanHang.maMH + ") WHERE maMH = " + phieuNhanHang.maMH;

                        using (SqlConnection conn = SqlConnectionData.connect())
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(sql1, conn);
                            cmd.Parameters.AddWithValue("@maSP", txtMaSP.Text);

                            try
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                reload();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}
