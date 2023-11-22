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
    public partial class frmUpdateTaiKhoan : Form
    {
        public frmUpdateTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmUpdateTaiKhoan_Load(object sender, EventArgs e)
        {
            this.Refresh();
            string query = "SELECT maNV, tenNV, soDT, chucVu, taiKhoan, matKhau from nhanvien where taiKhoan = N'" + user.account + "' and matKhau = N'" + user.password + "'";
            
            try
            {
                dgvCapNhat.DataSource = AccessData.getData(query);
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }
        bool isCollapsed = true;

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            timerCapNhat.Start();
        }

        private void timerCapNhat_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timerCapNhat.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timerCapNhat.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void dgvCapNhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtTen.Text = dgvCapNhat.Rows[index].Cells[1].Value.ToString();
            txtSDT.Text = dgvCapNhat.Rows[index].Cells[2].Value.ToString();
            txtTaiKhoan.Text = dgvCapNhat.Rows[index].Cells[4].Value.ToString();
            txtMatKhau.Text = dgvCapNhat.Rows[index].Cells[5].Value.ToString();
        }

        private void btnHopCapNhat_Click(object sender, EventArgs e)
        {
            string query = "update NhanVien set tenNV = @tenNV, soDT = @soDT, taiKhoan = @taiKhoan, matKhau = @matKhau where maNV = " + user.id;
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenNV", txtTen.Text);
                cmd.Parameters.AddWithValue("@soDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@taiKhoan", txtTaiKhoan.Text);
                cmd.Parameters.AddWithValue("@matKhau", txtMatKhau.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /*string sqlQuery = "SELECT nv.maNV, nv.tenNV, nv.chucVu, nv.taiKhoan, nv.matKhau, nv.quyenHan FROM nhanvien nv WHERE nv.taiKhoan = @TaiKhoan AND nv.matKhau = @MatKhau";

                    using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text);
                        command.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);

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

                    frmMain.welcomeText = "Chào mừng " + user.user_name;

                    string query2 = "SELECT maNV, tenNV, soDT, chucVu, taiKhoan, matKhau from nhanvien where taiKhoan = N'" + user.account + "' and matKhau = N'" + user.password + "'";

                    try
                    {
                        dgvCapNhat.DataSource = AccessData.getData(query2);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
