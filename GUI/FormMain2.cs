using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class FormMain2 : Form
    {
        public bool isExit = true;

        public event EventHandler Logout;

        bool isCollapsed = true;
        bool isCollapsed2 = true;
        bool isCollapsed3 = true;
        bool homeExpand = true;
        bool hopDongExpand = true;

        public FormMain2()
        {
            InitializeComponent();
            labelWelcome.Text += user.user_name;
            this.Refresh();
        }

        void phanQuyen()
        {
            if (user.permission == "Nhân viên")
            {
                if(user.position == "Nhân viên làm hợp đồng")
                {
                    btnGhiNuoc.Enabled = false;
                    btnHoaDon.Enabled = false;
                    btnXuPhat.Enabled = false;
                    btnKho.Enabled = false;
                    btnNhanVien.Enabled = false;
                    btnSaoLuu.Enabled = false;
                    btnKhoiPhuc.Enabled = false;
                }

                if (user.position == "Nhân viên ghi nước")
                {
                    btnHopDong1.Enabled = false;
                    btnKhachHang.Enabled = false;
                    btnSaoLuu.Enabled = false;
                    btnXuPhat.Enabled = false;
                    btnNhanVien.Enabled = false;
                    btnKho.Enabled = false;
                    btnSaoLuu.Enabled = false;
                    btnKhoiPhuc.Enabled = false;
                }

                if(user.position == "Nhân viên thu ngân")
                {
                    btnHopDong1.Enabled = false;
                    btnSaoLuu.Enabled = false;
                    btnKhoiPhuc.Enabled = false;
                }
            }
        }

        #region Event



        #endregion

        private void FormMain2_Load(object sender, EventArgs e)
        {
            phanQuyen();
            panelDanhMuc.Size = panelDanhMuc.MinimumSize;
            panelHeThong.Size = panelHeThong.MinimumSize;
            this.Refresh();
        }

        // bắt đầu timer
        // bắt thời gian đóng mở panelDanhMuc
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panelDanhMuc.Height += 10;
                if(panelDanhMuc.Size == panelDanhMuc.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed= false;
                }
            }else
            {
                panelDanhMuc.Height -= 10;
                if (panelDanhMuc.Size == panelDanhMuc.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        // Bắt thời gian đóng mở panelHeThong
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                panelHeThong.Height += 10;
                if (panelHeThong.Size == panelHeThong.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                panelHeThong.Height -= 10;
                if (panelHeThong.Size == panelHeThong.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = true;
                }
            }
        }
        // bắt thời gian mở panelMain
        private void homeTimer_Tick(object sender, EventArgs e)
        {
            if (homeExpand)
            {
                panelMain.Width -= 10;
                if (panelMain.Width <= 53)
                {
                    homeExpand = false;
                    homeTimer.Stop();
                }
            }
            else
            {
                panelMain.Width += 10;
                if (panelMain.Width >= 200)
                {
                    homeExpand = true;
                    homeTimer.Stop();
                }
            }
        }
        // bắt thời gian mở panelHopDong
        private void timerHopDong_Tick(object sender, EventArgs e)
        {
            if (hopDongExpand)
            {
                panelHopDong.Height += 10;
                if (panelHopDong.Size == panelHopDong.MaximumSize)
                {
                    timerHopDong.Stop();
                    hopDongExpand = false;
                }
            }
            else
            {
                panelHopDong.Height -= 10;
                if (panelHopDong.Size == panelHopDong.MinimumSize)
                {
                    timerHopDong.Stop();
                    hopDongExpand = true;
                }
            }
        }
        // kết thúc timer

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            isCollapsed2= false;

            timer1.Start();
            timer2.Start();

            if(panelMain.Width == 53)
                homeTimer.Start();
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            isCollapsed = false;

            timer1.Start();
            timer2.Start();

            if (panelMain.Width == 53)
                homeTimer.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeTimer.Start();
           isCollapsed = false;
            isCollapsed2 = false;

            timer1.Start();
            timer2.Start();
        }

        #region Event
        private void FormMain2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void FormMain2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        #endregion

        private Form currentFormChild;

        // mở form con
        private void OpenFormChild(Form childForm)
        {
            if(currentFormChild != null)
                currentFormChild.Close();
            
            currentFormChild= childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // trở về trang chủ 
        private void CloseAllChildForms()
        {
            foreach(Control control in panel_body.Controls)
    {
                if (control is Form form)
                {
                    form.Hide();
                    form.Dispose();
                }
            }

            // Xóa các form con khỏi panel_body
            panel_body.Controls.OfType<Form>().ToList().ForEach(c => c.Dispose());
            currentFormChild = null;
        }

        private void btnHopDong1_Click(object sender, EventArgs e)
        {
            timerHopDong.Start();
        }

        private void btnThemHopDong_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmThemHopDong());
            lblTitle.Text = btnThemHopDong.Text;
        }

        private void btnDanhSachHopDong_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmHopDong());
            lblTitle.Text = btnDanhSachHopDong.Text;
        }

        private void btnKho_Click_1(object sender, EventArgs e)
        {
            OpenFormChild(new frmMuaHang());
            lblTitle.Text = btnKho.Text;
            hopDongExpand = false;
            timerHopDong.Start();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmQuanLyKH());
            lblTitle.Text = btnKhachHang.Text;
            hopDongExpand = false;
            timerHopDong.Start();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmHoaDon());
            lblTitle.Text = btnHoaDon.Text;
            hopDongExpand = false;
            timerHopDong.Start();
        }

        private void btnXuPhat_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmXuPhat());
            lblTitle.Text = btnXuPhat.Text;
            hopDongExpand = false;
            timerHopDong.Start();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmNhanVien());
            lblTitle.Text = btnNhanVien.Text;
            hopDongExpand = false;
            timerHopDong.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            lblTitle.Text = "Trang chủ";
        }

        private void pitureDanhMuc_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện Click của nút btnDanhMuc
            btnDanhMuc.PerformClick();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện Click của nút btnHeThong
            btnHeThong.PerformClick();
        }

        private void btnGhiNuoc_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmTieuThu());
            lblTitle.Text = btnGhiNuoc.Text;
            hopDongExpand = false;
            timerHopDong.Start();
        }

        private void btnCapNhatTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmUpdateTaiKhoan());
            lblTitle.Text = btnCapNhatTaiKhoan.Text;
            hopDongExpand = false;
            timerHopDong.Start();
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(isCollapsed)
                isCollapsed = false;
            if(isCollapsed2)
                isCollapsed2 = false;

            timer1.Start();
            timer2.Start();

            if (panelMain.Width == 53)
                homeTimer.Start();
            OpenFormChild(new frmQuanLyDoanhThu());
            lblTitle.Text = button6.Text;
            hopDongExpand = false;
            timerHopDong.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button6.PerformClick();
        }
    }
}