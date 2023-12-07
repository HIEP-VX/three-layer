using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using System.Data.SqlClient;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnAccept;
        }
        private void btnAccept_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnAccept.PerformClick();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = AccessData.getData("select * from nhanvien where taiKhoan = '" + txtusername.Text + "'and  matkhau = '" + txtpassword.Text + "'");
            if (dt.Rows.Count > 0)
            {
                using (SqlConnection connection = SqlConnectionData.connect())
                {
                    connection.Open();
                    string sqlQuery = "SELECT nv.maNV, nv.tenNV, nv.chucVu, nv.taiKhoan, nv.matKhau, nv.quyenHan FROM nhanvien nv WHERE nv.taiKhoan = @TaiKhoan AND nv.matKhau = @MatKhau";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@TaiKhoan", txtusername.Text);
                        command.Parameters.AddWithValue("@MatKhau", txtpassword.Text);

                        // Thực thi câu lệnh SQL và đọc giá trị
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Đọc giá trị tên nhân viên từ cột đầu tiên
                                string maNhanVien = reader["maNV"].ToString();
                                user.id = int.Parse(maNhanVien);

                                // Đọc giá trị tên nhân viên từ cột đầu tiên
                                string tenNhanVien = reader["tenNV"].ToString();
                                user.user_name = tenNhanVien;

                                // Đọc giá trị quyền hạn từ cột thứ hai
                                string chucVu = reader["chucVu"].ToString();
                                user.position = chucVu;

                                // Đọc giá trị quyền hạn từ cột thứ ba
                                string taiKhoan = reader["taiKhoan"].ToString();
                                user.account = taiKhoan;

                                // Đọc giá trị quyền hạn từ cột thứ bon
                                string matKhau = reader["matKhau"].ToString();
                                user.password = matKhau;

                                // Đọc giá trị quyền hạn từ cột thứ nam
                                string quyenHan = reader["quyenHan"].ToString();
                                user.permission = quyenHan;
                            }
                        }
                    }
                }
                FormMain2 fm = new FormMain2();
                fm.Show();
                this.Hide();
                fm.Logout += F_Logout;
            }
            else
                MessageBox.Show("Username or password is incorrect.");
        }

        private void F_Logout(object sender, EventArgs e)
        {
            (sender as FormMain2).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as FormMain2).Close();
            this.Show();
            txtusername.Text = "";
            txtpassword.Text = "";
            checkShowPassword.Checked = false;
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked)
                txtpassword.PasswordChar = '\0';
            else
                txtpassword.PasswordChar = '*';
        }
    }
}
