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
        public frmLKH()
        {
            InitializeComponent();
        }

        private void frmLKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet3.loaiKhachHang' table. You can move, or remove it, as needed.
            this.loaiKhachHangTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet3.loaiKhachHang);
            this.Refresh();
            panelTool.Size = panelTool.MinimumSize;
            try
            {
                string query = "select * from loaiKhachHang";
                dgvLKH.DataSource = AccessData.getData(query);
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            subAddLKH sb = new subAddLKH();
            sb.Show();

            sb.Logout += addForm_Logout;

            sb.DataAdded += () =>
            {
                try
                {
                    string query = "select * from loaiKhachHang";
                    dgvLKH.DataSource = AccessData.getData(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }
        private void addForm_Logout(object sender, EventArgs e)
        {
            (sender as subAddLKH).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as subAddLKH).Close();
            this.Show();
        }
        private void delForm_Logout(object sender, EventArgs e)
        {
            (sender as subDelLKH).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as subDelLKH).Close();
            this.Show();
        }
        private void updForm_Logout(object sender, EventArgs e)
        {
            (sender as subUpdateLKH).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as subUpdateLKH).Close();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            subDelLKH sb = new subDelLKH();
            sb.Show();

            sb.Logout += delForm_Logout;

            sb.DataAdded += () =>
            {
                try
                {
                    string query = "select * from loaiKhachHang";
                    dgvLKH.DataSource = AccessData.getData(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            subUpdateLKH sb = new subUpdateLKH();
            sb.Show();

            sb.Logout += updForm_Logout;

            sb.DataAdded += () =>
            {
                try
                {
                    string query = "select * from NhanVien";
                    dgvLKH.DataSource = AccessData.getData(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
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
        bool isCollapsed = true;

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
