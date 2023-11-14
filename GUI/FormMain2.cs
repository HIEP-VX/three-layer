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
        account ac = new account();
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
        }
        void phanQuyen()
        {
            if (user.currentUser == "admin2")
            {
                btnHopDong1.Enabled = false;

            }
        }

        #region Event



        #endregion

        private void FormMain2_Load(object sender, EventArgs e)
        {
            phanQuyen();
            panelDanhMuc.Size = panelDanhMuc.MinimumSize;
            panelHeThong.Size = panelHeThong.MinimumSize;
            labelWelcome.Text += user.currentUser;
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

        private void btnHopDong_Click(object sender, EventArgs e)
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

        private void btnLoaiKhachHang_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmLKH());
            lblTitle.Text = btnLoaiKhachHang.Text;
            hopDongExpand = false;
            timerHopDong.Start();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmKhachHang());
            lblTitle.Text = btnKhachHang.Text;
            hopDongExpand = false;
            timerHopDong.Start();
        }

        private void btnDongHo_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmDongHo());
            lblTitle.Text = btnDongHo.Text;
            hopDongExpand = false;
            timerHopDong.Start();
        }

        private void btnTieuThu_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmTieuThu());
            lblTitle.Text = btnTieuThu.Text;
            hopDongExpand = false;
            timerHopDong.Start();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnXuPhat_Click(object sender, EventArgs e)
        {

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

    }
}
