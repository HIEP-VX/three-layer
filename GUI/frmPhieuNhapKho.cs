using DAL;
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
using static DevExpress.Xpo.Helpers.CommandChannelHelper;

namespace GUI
{
    public partial class frmPhieuNhapKho : Form
    {
        public frmPhieuNhapKho()
        {
            InitializeComponent();
        }

        private int index = -1;
        string maNhanVien = "";
        string tenNhanVien = "";

        private void reload()
        {
            dgvPhieuNhapKho.RowTemplate.Height = 26;
            try
            {
                // select maPhieu, maHD_NH, phieuNhapKho.maNV, nv.tenNV from phieuNhapKho join nhanVien nv on nv.maNV = phieuNhapKho.maNV
                string sql = "select * from phieuNhapKho";
                dgvPhieuNhapKho.DataSource = AccessData.getData(sql);

                dgvPhieuNhapKho.Columns[0].HeaderText = "Mã phiếu";
                dgvPhieuNhapKho.Columns[1].HeaderText = "Mã hóa đơn nhận hàng";
                dgvPhieuNhapKho.Columns[2].HeaderText = "Mã nhân viên";

                foreach (DataGridViewColumn column in dgvPhieuNhapKho.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                using (SqlConnection conn = SqlConnectionData.connect())
                {
                    conn.Open();
                    string query = "select maNV, tenNV from NhanVien where chucVu like N'%Nhân viên kho%'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    // Xóa tất cả các mục hiện có trong ComboBox
                    comboBox1.Items.Clear();

                    // Thêm dữ liệu vào ComboBox
                    while (reader.Read())
                    {
                        maNhanVien = reader["MaNV"].ToString();
                        tenNhanVien = reader["tenNV"].ToString();

                        // Kết hợp Mã nhân viên và Tên nhân viên
                        string item = $"{maNhanVien} - {tenNhanVien}";

                        comboBox1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reload2()
        {
            dgvPhieuNhapKho.RowTemplate.Height = 26;
            try
            {
                string sql = "select maPhieu, maHD_NH, phieuNhapKho.maNV, nv.tenNV from phieuNhapKho join nhanVien nv on nv.maNV = phieuNhapKho.maNV";
                dgvPhieuNhapKho.DataSource = AccessData.getData(sql);
                dgvPhieuNhapKho.Columns[0].HeaderText = "Mã phiếu";
                dgvPhieuNhapKho.Columns[1].HeaderText = "Mã hóa đơn nhận hàng";
                dgvPhieuNhapKho.Columns[2].HeaderText = "Mã nhân viên";
                dgvPhieuNhapKho.Columns[3].HeaderText = "Tên nhân viên";

                foreach (DataGridViewColumn column in dgvPhieuNhapKho.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                using (SqlConnection conn = SqlConnectionData.connect())
                {
                    conn.Open();
                    string query = "select maNV, tenNV from NhanVien where chucVu like N'%Nhân viên kho%'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    // Xóa tất cả các mục hiện có trong ComboBox
                    comboBox1.Items.Clear();

                    // Thêm dữ liệu vào ComboBox
                    while (reader.Read())
                    {
                        maNhanVien = reader["MaNV"].ToString();
                        tenNhanVien = reader["tenNV"].ToString();

                        // Kết hợp Mã nhân viên và Tên nhân viên
                        string item = $"{maNhanVien} - {tenNhanVien}";

                        comboBox1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPhieuNhapKho_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (comboBox1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox1.Focus();
                    return;
                }

                // Tách giá trị của ô trạng thái
                string selectedItem = comboBox1.SelectedItem as string;
                string selectedValue = "";

                // Tách giá trị (trong trường hợp này, "1")
                string[] parts = selectedItem.Split('-');
                if (parts.Length == 2)
                    // Sử dụng giá trị (trong trường hợp này, "1")
                    selectedValue = parts[0].Trim();

                string query = "UPDATE PhieuNhapKho SET maNV = @maNV WHERE maPhieu = @maPhieu";
                using (SqlConnection conn = SqlConnectionData.connect())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maNV", selectedValue);
                    cmd.Parameters.AddWithValue("@maPhieu", dgvPhieuNhapKho.Rows[index].Cells[0].Value.ToString());

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload2();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvPhieuNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}
