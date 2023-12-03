using DAL;
using DevExpress.Xpo.DB.Helpers;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class subAddPhieuNH : Form
    {
        public event Action DataAdded;
        public subAddPhieuNH()
        {
            InitializeComponent();
            //SetLinearGradient(btnThem, "#56d8e4", "#9f01ea");
        }

        private void subAddPhieuNH_Load(object sender, EventArgs e)
        {
            txtMANV.Text = user.id.ToString();
            txtTenNV.Text = user.user_name.ToString();
        }

        private void SetLinearGradient(Button btn, string hexColor1, string hexColor2)
        {
            // Chuyển đổi mã màu hex thành đối tượng Color
            Color color1 = ColorTranslator.FromHtml(hexColor1);
            Color color2 = ColorTranslator.FromHtml(hexColor2);

            // Tạo đối tượng LinearGradientBrush
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
                btn.ClientRectangle,
                color1,
                color2,
                LinearGradientMode.Horizontal); // Có thể thay đổi hướng dải màu tại đây

            // Thiết lập màu nền của Panel là dải màu linear
            btn.BackColor = Color.Transparent; // Đặt màu nền trong suốt để thấy rõ dải màu
            btn.BackgroundImage = new Bitmap(btn.Width, btn.Height);
            using (Graphics g = Graphics.FromImage(btn.BackgroundImage))
            {
                g.FillRectangle(linearGradientBrush, btn.ClientRectangle);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                try
                {
                    string query = "DECLARE @Inserted_maMH INT\n" +
                           "INSERT INTO phieuNhanHang (nhaCC, ngayMua, maNV) values (@nhaCC, @ngayMua, @maNV)\n" +
                           "SET @Inserted_maMH = SCOPE_IDENTITY();\n" +
                           "SELECT @Inserted_maMH AS 'maMH'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nhaCC", txtNHACC.Text);
                        cmd.Parameters.AddWithValue("@ngayMua", dateNgay.Value);
                        cmd.Parameters.AddWithValue("@maNV", txtMANV.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string maMH = reader["maMH"].ToString();
                                phieuNhanHang.maMH = int.Parse(maMH);
                            }
                        }
                    }
                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DataAdded?.Invoke();
            }
        }

        private void btnChiTietMH_Click(object sender, EventArgs e)
        {
            if (txtNHACC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNHACC.Focus();
                return;
            }else
            {
                timerExpandForm.Start();
                using (SqlConnection conn = SqlConnectionData.connect())
                {
                    conn.Open();
                        try
                        {
                        string query = "DECLARE @Inserted_maMH INT\n" +
                               "INSERT INTO phieuNhanHang (nhaCC, ngayMua, maNV) values (@nhaCC, @ngayMua, @maNV)\n" +
                               "SET @Inserted_maMH = SCOPE_IDENTITY();\n" +
                               "SELECT @Inserted_maMH AS 'maMH'";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                                cmd.Parameters.AddWithValue("@nhaCC", txtNHACC.Text);
                                cmd.Parameters.AddWithValue("@ngayMua", dateNgay.Value);
                                cmd.Parameters.AddWithValue("@maNV", txtMANV.Text);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string maMH = reader["maMH"].ToString();
                                    phieuNhanHang.maMH = int.Parse(maMH);
                                }
                            }
                        }
                            MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    DataAdded?.Invoke();
                }
            }
        }

        bool isCollapsed = true;

        private void timerExpandForm_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                this.Width += 10;
                this.Height += 10;
                if (this.Size == this.MaximumSize)
                {
                    timerExpandForm.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                this.Width -= 10;
                this.Height -= 10;
                if (this.Size == this.MinimumSize)
                {
                    timerExpandForm.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            DataTable dt = new DataTable();
            string query5 = "SELECT maSP FROM loaiDongHo WHERE tenSP = N'" + txtTenSP.Text + "' AND chiSoCongTo = " + txtChiSoCongTo.Text + " AND tenHangSX = N'" + txtHangSX.Text + "'";
            dt = AccessData.getData(query5);

            if (dt.Rows.Count > 0)
            {
                int ma = Convert.ToInt32(dt.Rows[0]["maSP"]);
                txtChiSoCongTo.Text = ma.ToString();
           
                string query1 = "DECLARE @Inserted_maCTMH INT,@Inserted_maSP INT,@Inserted_soLuong INT, @Inserted_tien MONEY;\n" +
                                "INSERT INTO chiTietMuaHang (soLuong, tien) values (@soLuong, @tien)\n" +
                                "SELECT @Inserted_maCTMH = SCOPE_IDENTITY(),@Inserted_soLuong = soLuong,@Inserted_tien = tien FROM chiTietMuaHang WHERE maChiTiet = SCOPE_IDENTITY();\n" +

                                "update chiTietMuaHang set maMH = " + phieuNhanHang.maMH + " where maChiTiet = @Inserted_maCTMH\n"+
                                "update chiTietMuaHang set maSP = "+ ma +" where maChiTiet = @Inserted_maCTMH";

                
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
                            // Nếu có lỗi, rollback giao dịch
                            transaction.Rollback();
                            MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    DataAdded?.Invoke();
                    try
                    {
                        string query3 = "Select ldh.maSP, ldh.tenSP, ldh.chiSoCongTo, ldh.tenHangSX, ct.soLuong, ct.tien from loaiDongHo ldh\n" +
                                    "join chiTietMuaHang ct on ct.maSP = ldh.maSP\n" +
                                    "where ct.maMH = " + phieuNhanHang.maMH;
                        dgvSP.DataSource = AccessData.getData(query3);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                }else
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
                            // Nếu có lỗi, rollback giao dịch
                            transaction.Rollback();
                            MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    DataAdded?.Invoke();
                    try
                    {
                        string query3 = "Select ldh.maSP, ldh.tenSP, ldh.chiSoCongTo, ldh.tenHangSX, ct.soLuong, ct.tien from loaiDongHo ldh\n" +
                                    "join chiTietMuaHang ct on ct.maSP = ldh.maSP\n"+
                                    "where ct.maMH = " + phieuNhanHang.maMH;
                        dgvSP.DataSource = AccessData.getData(query3);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }*/
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
