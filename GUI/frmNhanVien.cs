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
    public partial class frmNhanVien : Form
    {
       public frmNhanVien()
        {
            InitializeComponent();
        }
        private void reload()
        {
            try
            {
                string query = "select * from NhanVien";
                dgvNhanVien.DataSource = AccessData.getData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            reload();
            this.Refresh();
            panelTool.Size = panelTool.MinimumSize;
        }

        private void addForm_Logout(object sender, EventArgs e)
        {
            (sender as subAddForm).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as subAddForm).Close();
            this.Show();
        }

        private void delForm_Logout(object sender, EventArgs e)
        {
            (sender as subDelForm).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as subDelForm).Close();
            this.Show();
        }

        private void updateForm_Logout(object sender, EventArgs e)
        {
            (sender as subbUpdateForm).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as subbUpdateForm).Close();
            this.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            subAddForm sb = new subAddForm();
            sb.Show();

            sb.Logout += addForm_Logout;

            sb.DataAdded += () =>
            {
                reload();
            };
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            subDelForm sb = new subDelForm();
            sb.Show();

            sb.Logout += delForm_Logout;

            sb.DataAdded += () =>
            {
                reload();
            };
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            subbUpdateForm sb = new subbUpdateForm();
            sb.Show();

            sb.Logout += updateForm_Logout;

            sb.DataAdded += () =>
            {
                reload();
            };
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            timKiemTimer.Start();
        }

        private void btnHopTimKiem_Click(object sender, EventArgs e)
        {
            string query = "";
            if (txtMa.Text != "")
            {
                query = @"SELECT DISTINCT * FROM NhanVien WHERE maNV = " + txtMa.Text;
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
                dgvNhanVien.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        bool isCollapsed = true;

        private void timKiemTimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timKiemTimer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timKiemTimer.Stop();
                    isCollapsed = true;
                }
            }
        }
    }
}
