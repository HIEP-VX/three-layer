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
    public partial class frmKhachHang : Form
    {
        bool isCollapsed = true;
        private int index = -1; // Biến toàn cục để theo dõi dòng được chọn
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void reload()
        {
            try
            {
                string query = "select maKH, tenKH, ngaySinh, phuong, diaChi, soDT, maHD, maLKH, maDHN,\n"+
                               "CASE\n"+
                               "WHEN tinhTrang = 1 THEN N'đang hoạt động'\n" +
                               "WHEN tinhTrang = 2 THEN N'cắt nước'\n" +
                               "WHEN tinhTrang = 3 THEN N'dừng hoạt động'\n" +
                               "END AS 'Tình trạng'\n" +
                               "from KhachHang";
                dgvKH.DataSource = AccessData.getData(query);

                dgvKH.Columns[0].HeaderText = "Mã";
                dgvKH.Columns[1].HeaderText = "Họ và tên";
                dgvKH.Columns[2].HeaderText = "Ngày sinh";
                dgvKH.Columns[3].HeaderText = "Phường";
                dgvKH.Columns[4].HeaderText = "Địa chỉ";
                dgvKH.Columns[5].HeaderText = "Số điện thoại";
                dgvKH.Columns[6].HeaderText = "Mã hợp đồng";
                dgvKH.Columns[7].HeaderText = "Mã LKH";
                dgvKH.Columns[8].HeaderText = "Mã đồng hồ";
                dgvKH.Columns[9].HeaderText = "Tình trạng";

                foreach (DataGridViewColumn column in dgvKH.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            this.diaChiTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet4.diaChi);
            this.Refresh();
            panelTool.Size = panelTool.MinimumSize;
            reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(index == -1)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                subUpdateKH sb = new subUpdateKH();
                sb.ShowDialog();

                sb.DataAdded += () =>
                {
                    reload();
                };
                reload();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timerTimKiem.Start();
        }

        private void btnHopTimKiem_Click(object sender, EventArgs e)
        {
            string query = "";
            if (txtMa.Text != "")
            {
                query = @"SELECT DISTINCT * FROM KhachHang WHERE maKH = " + txtMa.Text;
            }
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Đã tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvKH.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timerTimKiem_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timerTimKiem.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timerTimKiem.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object cellValue = dgvKH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    txtMa.Text = dgvKH.Rows[index].Cells[0].Value.ToString();
                    khachHang.maKH = int.Parse(txtMa.Text);

                    txttenKH.Text = dgvKH.Rows[index].Cells[1].Value.ToString();
                    khachHang.tenKH = txttenKH.Text;

                    dateTimePicker1.Value = Convert.ToDateTime(dgvKH.Rows[index].Cells[2].Value);
                    khachHang.ngaySinh = dateTimePicker1.Value;

                    cbPhuong.Text = dgvKH.Rows[index].Cells[3].Value.ToString();
                    khachHang.phuong = cbPhuong.Text;

                    txtDC.Text = dgvKH.Rows[index].Cells[4].Value.ToString();
                    khachHang.diaChi = txtDC.Text;

                    txtSDT.Text = dgvKH.Rows[index].Cells[5].Value.ToString();
                    khachHang.soDT = txtSDT.Text;

                    txtmaHD.Text = dgvKH.Rows[index].Cells[6].Value.ToString();
                    khachHang.maHD = int.Parse(txtmaHD.Text);

                    txtLKH.Text = dgvKH.Rows[index].Cells[7].Value.ToString();
                    khachHang.maLKH = int.Parse(txtLKH.Text);

                    txtDH.Text = dgvKH.Rows[index].Cells[8].Value.ToString();
                    khachHang.maDHN = int.Parse(txtDH.Text);

                    txtTinhTrang.Text = dgvKH.Rows[index].Cells[9].Value.ToString();
                    khachHang.tinhTrang = txtTinhTrang.Text;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}