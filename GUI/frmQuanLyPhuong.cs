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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmQuanLyPhuong : Form
    {
        private int index = -1;
        string maNhanVien = "";
        string tenNhanVien = "";
        public frmQuanLyPhuong()
        {
            InitializeComponent();
        }

        private void reload()
        {
            dgvPhuong.RowTemplate.Height = 26;
            try
            {
                string query = $"select phuong, diaChi.maNV, tenNV from diaChi join nhanvien nv on nv.maNV = diaChi.maNV";
                dgvPhuong.DataSource = AccessData.getData(query);
                using (SqlConnection conn = SqlConnectionData.connect())
                {
                    conn.Open();
                    string query2 = "select maNV, tenNV from NhanVien where chucVu like N'%Nhân viên ghi nước%'";
                    SqlCommand cmd = new SqlCommand(query2, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    // Xóa tất cả các mục hiện có trong ComboBox
                    txtMaNV.Items.Clear();

                    // Thêm dữ liệu vào ComboBox
                    while (reader.Read())
                    {
                        maNhanVien = reader["MaNV"].ToString();
                        tenNhanVien = reader["tenNV"].ToString();

                        // Kết hợp Mã nhân viên và Tên nhân viên
                        string item = $"{maNhanVien}-{tenNhanVien}";

                        txtMaNV.Items.Add(item);
                    }
                }

                dgvPhuong.Columns[0].HeaderText = "Tên phường";
                dgvPhuong.Columns[1].HeaderText = "Mã nhân viên ghi nước";
                dgvPhuong.Columns[2].HeaderText = "Họ tên nhân viên";

                foreach (DataGridViewColumn column in dgvPhuong.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmQuanLyPhuong_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void dgvPhuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtTenPhuong.Text = dgvPhuong.Rows[index].Cells[0].Value.ToString();
            txtMaNV.Text = dgvPhuong.Rows[index].Cells[1].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                // Tách giá trị của ô trạng thái
                string selectedItem = txtMaNV.SelectedItem as string;
                string selectedValue = "";

                // Tách giá trị (trong trường hợp này, "1")
                string[] parts = selectedItem.Split('-');
                if (parts.Length == 2)
                    // Sử dụng giá trị (trong trường hợp này, "1")
                    selectedValue = parts[0].Trim();
                string sql = "update diaChi set maNV = @maNV where phuong like N'%' + @phuong + '%'";

                using (SqlConnection conn = SqlConnectionData.connect())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maNV", int.Parse(selectedValue));
                    MessageBox.Show(txtTenPhuong.Text);
                    MessageBox.Show(selectedValue);
                    cmd.Parameters.AddWithValue("@phuong", txtTenPhuong.Text);
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