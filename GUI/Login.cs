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
        List<Image> images = new List<Image>();
        string[] location = new string[25];
        public Login()
        {
            InitializeComponent();
            location[0] = @"D:\New folder\resource\animation\textbox_user_1.jpg";
            location[1] = @"D:\New folder\resource\animation\textbox_user_2.jpg";
            location[2] = @"D:\New folder\resource\animation\textbox_user_4.jpg";
            location[3] = @"D:\New folder\resource\animation\textbox_user_5.jpg";
            location[4] = @"D:\New folder\resource\animation\textbox_user_6.jpg";
            location[5] = @"D:\New folder\resource\animation\textbox_user_7.jpg";
            location[6] = @"D:\New folder\resource\animation\textbox_user_8.jpg";
            location[7] = @"D:\New folder\resource\animation\textbox_user_9.jpg";
            location[8] = @"D:\New folder\resource\animation\textbox_user_10.jpg";
            location[9] = @"D:\New folder\resource\animation\textbox_user_11.jpg";
            location[10] = @"D:\New folder\resource\animation\textbox_user_12.jpg";
            location[11] = @"D:\New folder\resource\animation\textbox_user_13.jpg";
            location[12] = @"D:\New folder\resource\animation\textbox_user_14.jpg";
            location[13] = @"D:\New folder\resource\animation\textbox_user_15.jpg";
            location[14] = @"D:\New folder\resource\animation\textbox_user_16.jpg";
            location[15] = @"D:\New folder\resource\animation\textbox_user_17.jpg";
            location[16] = @"D:\New folder\resource\animation\textbox_user_18.jpg";
            location[17] = @"D:\New folder\resource\animation\textbox_user_19.jpg";
            location[18] = @"D:\New folder\resource\animation\textbox_user_20.jpg";
            location[19] = @"D:\New folder\resource\animation\textbox_user_21.jpg";
            location[20] = @"D:\New folder\resource\animation\textbox_user_22.jpg";
            location[21] = @"D:\New folder\resource\animation\textbox_user_23.jpg";
            location[22] = @"D:\New folder\resource\animation\textbox_user_24.jpg";
            tounage();
            this.AcceptButton = btnAccept;
        }

        private void tounage()
        {
            for (int i = 0; i < 23; i++)
            {
                Bitmap bitmap = new Bitmap(location[i]);
                images.Add(bitmap);
            }
            images.Add(Properties.Resources.textbox_user_24);
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

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if (txtusername.Text.Length > 0 && txtusername.Text.Length <= 15)
            {
                pictureBox4.Image = images[txtusername.Text.Length - 1];
                pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (txtusername.Text.Length <= 0)
                pictureBox4.Image = Properties.Resources.debut;
            else
                pictureBox4.Image = images[22];
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            Bitmap bmpass = new Bitmap(@"D:\New folder\resource\animation\textbox_password.png");
            pictureBox4.Image = bmpass;
        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Length > 0)
                pictureBox4.Image = images[txtusername.Text.Length - 1];
            else
                pictureBox4.Image = Properties.Resources.debut;
        }
    }
}
