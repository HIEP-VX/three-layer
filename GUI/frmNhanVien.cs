using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmNhanVien : Form
    {

        bool isCollapsed = true;
        bool isCollapsed1 = true;

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

                dgvNhanVien.Columns[0].HeaderText = "Mã";
                dgvNhanVien.Columns[1].HeaderText = "Họ và tên";
                dgvNhanVien.Columns[2].HeaderText = "Số điện thoại";
                dgvNhanVien.Columns[3].HeaderText = "Chức vụ";
                dgvNhanVien.Columns[4].HeaderText = "Tài khoản";
                dgvNhanVien.Columns[5].HeaderText = "Mật khẩu";
                dgvNhanVien.Columns[6].HeaderText = "Quyền hạn";

                foreach (DataGridViewColumn column in dgvNhanVien.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                dgvNhanVien.Columns[0].Width = 50;
                dgvNhanVien.Columns[2].Width = 120;

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
            SetLinearGradient(btnHopTimKiem, "#56d8e4", "#9f01ea");
            SetLinearGradient(btnHopCapNhat, "#56d8e4", "#9f01ea");
            btnHopTimKiem.Visible = false;
            btnHopCapNhat.Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            subAddForm sb = new subAddForm();
            sb.ShowDialog();

            sb.DataAdded += () =>
            {
                reload();
            };
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            subDelForm sb = new subDelForm();
            sb.ShowDialog();

            sb.DataAdded += () =>
            {
                reload();
            };
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            timerCapNhat.Start();
            btnHopCapNhat.Visible = true;
            btnHopTimKiem.Visible = false;
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            timKiemTimer.Start();
            btnHopTimKiem.Visible = true;
            btnHopCapNhat.Visible = false;
        }

        private void btnHopCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            if (txttenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenNV.Focus();
                return;
            }

            if (txtsoDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoDT.Focus();
                return;
            }

            if (txtChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chức vụ của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChucVu.Focus();
                return;
            }
            if (txtQuyenHan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập quyền hạn của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuyenHan.Focus();
                return;
            }
            if (txtTaiKhoan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tài khoản cho nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cho nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }

            string sql = "update NhanVien set TENNV = N'" + txttenNV.Text + "',soDT = '" + txtsoDT.Text + "' where maNV = " + txtMa.Text;
            try
            {
                AccessData.execQuery(sql);
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void timerCapNhat_Tick(object sender, EventArgs e)
        {
            if (isCollapsed1)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timerCapNhat.Stop();
                    isCollapsed1 = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timerCapNhat.Stop();
                    isCollapsed1 = true;
                }
            }
        }

        private void SetLinearGradient(Button btn, string hexColor1, string hexColor2)
        {
            // Chuyển đổi mã màu hex thành đối tượng Color
            Color color1 = ColorTranslator.FromHtml(hexColor1);
            Color color2 = ColorTranslator.FromHtml(hexColor2);

            // Tạo đối tượng LinearGradientBrush
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
                btn.ClientRectangle,
                color1,
                color2,
                LinearGradientMode.Horizontal); // Có thể thay đổi hướng dải màu tại đây

            // Thiết lập màu nền của Panel là dải màu linear
            btn.BackColor = Color.Transparent; // Đặt màu nền trong suốt để thấy rõ dải màu
            btn.BackgroundImage = new Bitmap(btn.Width, btn.Height);
            using (Graphics g = Graphics.FromImage(btn.BackgroundImage))
            {
                g.FillRectangle(linearGradientBrush, btn.ClientRectangle);
            }
        }
    }
}
