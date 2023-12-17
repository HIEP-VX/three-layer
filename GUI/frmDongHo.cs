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

namespace GUI
{
    public partial class frmDongHo : Form
    {
        public frmDongHo()
        {
            InitializeComponent();
        }

        private void reload()
        {
            dgvDongho.RowTemplate.Height = 26;
            try
            {
                string query = "SELECT maDHN,dhn.maPhieu,ldh.tenSP, ldh.chiSoCongTo, chiSoDau,\n" +
                               "CASE\n" +
                               "WHEN dhn.tinhTrang = 0 THEN N'chưa sử dụng'\n" +
                               "WHEN dhn.tinhTrang = 1 THEN N'đã sử dụng'\n" +
                               "END AS tinhTrang, soNamDung\n" +
                               "FROM DongHoNuoc dhn join phieuNhapKho pnk on pnk.maPhieu = dhn.maPhieu\n" +
                               "join hoaDonNhanHang hdnh on hdnh.maHD_NH = pnk.maHD_NH\n" +
                               "join chiTietMuaHang ct on ct.maMH = hdnh.maMH\n"+
                               "join loaidongho ldh on ldh.maSP = ct.maSP";
                dgvDongho.DataSource = AccessData.getData(query);

                dgvDongho.Columns[0].HeaderText = "Mã đồng hồ";
                dgvDongho.Columns[1].HeaderText = "Mã phiếu";
                dgvDongho.Columns[2].HeaderText = "Tên sản phẩm";
                dgvDongho.Columns[3].HeaderText = "Số công tơ";
                dgvDongho.Columns[4].HeaderText = "Chỉ số đầu";
                dgvDongho.Columns[5].HeaderText = "Tình trạng";
                dgvDongho.Columns[6].HeaderText = "Số năm dùng";

                foreach (DataGridViewColumn column in dgvDongho.Columns)
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

        private void frmDongHo_Load(object sender, EventArgs e)
        {
            this.Refresh();
            panelTool.Size = panelTool.MinimumSize;
            reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            subAddDongHo sb = new subAddDongHo();

            sb.ShowDialog();

            sb.DataAdded += () =>
            {
                reload();
            };
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            subDelDongHo sb = new subDelDongHo();
            sb.ShowDialog();

            sb.DataAdded += () =>
            {
                reload();
            };
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            subUpdateDongHo sb = new subUpdateDongHo();
            sb.ShowDialog();

            sb.DataAdded += () =>
            {
                reload();
            };
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
                query = @"SELECT DISTINCT * FROM DongHoNuoc WHERE maDHN = " + txtMa.Text;
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
                dgvDongho.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy đồng hồ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        bool isCollapsed = true;

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

    }
}
