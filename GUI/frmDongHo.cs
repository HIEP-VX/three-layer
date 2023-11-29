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
            try
            {
                string query = "SELECT maDHN as 'Mã',maPhieu as 'Mã phiếu', chiSoDau as 'Chỉ số đầu',\n" +
                               "CASE\n" +
                               "WHEN tinhTrang = 0 THEN N'chưa sử dụng'\n" +
                               "WHEN tinhTrang = 1 THEN N'đã sử dụng'\n" +
                               "END AS 'Tình trạng'\n" +
                               "FROM DongHoNuoc\n";
                dgvDongho.DataSource = AccessData.getData(query);
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
            sb.Show();

            sb.Logout += addForm_Logout;

            sb.DataAdded += () =>
            {
                reload();
            };
        }

        private void addForm_Logout(object sender, EventArgs e)
        {
            (sender as subAddDongHo).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as subAddDongHo).Close();
            this.Show();
        }
        private void delForm_Logout(object sender, EventArgs e)
        {
            (sender as subDelDongHo).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as subDelDongHo).Close();
            this.Show();
        }
        private void updForm_Logout(object sender, EventArgs e)
        {
            (sender as subUpdateDongHo).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as subUpdateDongHo).Close();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            subDelDongHo sb = new subDelDongHo();
            sb.Show();

            sb.Logout += delForm_Logout;

            sb.DataAdded += () =>
            {
                reload();
            };
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            subUpdateDongHo sb = new subUpdateDongHo();
            sb.Show();

            sb.Logout += updForm_Logout;

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
