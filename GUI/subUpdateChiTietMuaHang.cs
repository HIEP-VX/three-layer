using DAL;
using DTO;
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

        public subUpdateChiTietMuaHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("1");
                int ma = Convert.ToInt32(dt.Rows[0]["maSP"]);

                string query1 = "UPDATE chiTietMuaHang set soLuong = soLuong + @soLuong where maSP = " + ma +
                              //  "UPDATE chiTietMuaHang set tien = tien + @tien where maSP = " + ma + "\n"+
                                "UPDATE phieuNhanHang set tongTien = tongTien + (@tien * @soLuong) from phieuNhanHang join chiTietMuaHang ct on ct.maMH = phieuNhanHang.maMH where phieuNhanHang.maMH = phieuNhanHang.maMH";
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
                    try
                    {
                        string query3 = "Select ldh.maSP, ldh.tenSP, ldh.chiSoCongTo, ldh.tenHangSX, ct.soLuong, ct.tien from loaiDongHo ldh\n" +
                                    "join chiTietMuaHang ct on ct.maSP = ldh.maSP where ct.maMH = " + phieuNhanHang.maMH;
                        dgvSP.DataSource = AccessData.getData(query3);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("2");

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
                    try
                    {
                        string query3 = "Select ldh.maSP, ldh.tenSP, ldh.tenHangSX, ldh.chiSoCongTo, ct.soLuong, ct.tien from loaiDongHo ldh\n" +
                                    "join chiTietMuaHang ct on ct.maSP = ldh.maSP\n" +
                                    "where ct.maMH = " + phieuNhanHang.maMH;
                        dgvSP.DataSource = AccessData.getData(query3);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            /*
             * 
            // Tách giá trị của ô trạng thái
            string selectedItem = txtTinhTrang.SelectedItem as string;
            string selectedValue = "";

            // Tách giá trị (trong trường hợp này, "1")
            string[] parts = selectedItem.Split('-');
            if (parts.Length == 2)
                // Sử dụng giá trị (trong trường hợp này, "1")
                selectedValue = parts[0].Trim();

            string query = "UPDATE chiTietMuaHang SET maSP = @maSP, soLuong = @soLuong, tien = @tien, tinhTrang = @tinhTrang WHERE maChiTiet = @maChiTiet";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maSP", cbMASP.Text);
                cmd.Parameters.AddWithValue("@soLuong", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@tien", txtTien.Text);
                cmd.Parameters.AddWithValue("@tinhTrang", selectedValue);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
                DataAdded?.Invoke();
            }
             * */

        }

        private void subUpdateChiTietMuaHang_Load(object sender, EventArgs e)
        {
            MessageBox.Show(phieuNhanHang.maMH.ToString());
            string query3 = "Select ldh.maSP, ldh.tenSP, ldh.tenHangSX, ldh.chiSoCongTo, ct.soLuong, ct.tien from loaiDongHo ldh\n" +
                                    "join chiTietMuaHang ct on ct.maSP = ldh.maSP\n" +
                                    "where ct.maMH = " + phieuNhanHang.maMH;
            dgvSP.DataSource = AccessData.getData(query3);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
