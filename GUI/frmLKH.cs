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
    public partial class frmLKH : Form
    {
        bool isCollapsed = true;
        public frmLKH()
        {
            InitializeComponent();
        }

        private void reload()
        {
            try
            {
                string query = "select maLKH, tenLoai, FORMAT(CAST(giaBac1 AS DECIMAL(18, 0)), 'N0') AS gb1 , FORMAT(CAST(giaBac2 AS DECIMAL(18, 0)), 'N0') AS gb2, FORMAT(CAST(giaBac3 AS DECIMAL(18, 0)), 'N0') AS gb3, FORMAT(CAST(giaBac4 AS DECIMAL(18, 0)), 'N0') AS gb4 from loaiKhachHang";
                dgvLKH.DataSource = AccessData.getData(query);

                dgvLKH.Columns[0].HeaderText = "Mã";
                dgvLKH.Columns[1].HeaderText = "Loại";
                dgvLKH.Columns[2].HeaderText = "Giá bậc 1";
                dgvLKH.Columns[3].HeaderText = "Giá bậc 2";
                dgvLKH.Columns[4].HeaderText = "Giá bậc 3";
                dgvLKH.Columns[5].HeaderText = "Giá bậc 4";


                foreach (DataGridViewColumn column in dgvLKH.Columns)
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

        private void frmLKH_Load(object sender, EventArgs e)
        {
            this.Refresh();
            panelTool.Size = panelTool.MinimumSize;
            reload();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            subAddLKH sb = new subAddLKH();
            sb.ShowDialog();

            sb.DataAdded += () =>
            {
                reload();
            };
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            subDelLKH sb = new subDelLKH();
            sb.ShowDialog();

            sb.DataAdded += () =>
            {
                reload();
            };
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            subUpdateLKH sb = new subUpdateLKH();
            sb.ShowDialog();

            sb.DataAdded += () =>
            {
                reload();
            };
        }
        
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            timerLKH.Start();
        }

        private void btnHopTimKiem_Click(object sender, EventArgs e)
        {
            string query = "";
            if (txtMa.Text != "")
            {
                query = @"SELECT DISTINCT * FROM loaiKhachHang WHERE maLKH = " + txtMa.Text;
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
                dgvLKH.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        private void timerLKH_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timerLKH.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timerLKH.Stop();
                    isCollapsed = true;
                }
            }
        }
    }
}
