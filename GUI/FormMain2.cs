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
        bool homeExpand = true;
        bool hopDongExpand = true;


        public FormMain2()
        {
            InitializeComponent();
        }

        #region Event



        #endregion

        private void FormMain2_Load(object sender, EventArgs e)
        {
            panelDanhMuc.Size = panelDanhMuc.MinimumSize;
            panelHeThong.Size = panelHeThong.MinimumSize;
        }

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

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            isCollapsed2= false;

            timer1.Start();
            timer2.Start();
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            isCollapsed = false;

            timer1.Start();
            timer2.Start();
        }

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeTimer.Start();
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

        private void OpenFormChild(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild= childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            timerHopDong.Start();
        }

        private void btnThemHopDong_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmThemHopDong());
        }

        private void btnDanhSachHopDong_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmHopDong());
        }

        private void btnLoaiKhachHang_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmLKH());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmKhachHang());
        }

        private void btnDongHo_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmDongHo());
        }

        private void btnTieuThu_Click(object sender, EventArgs e)
        {

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
        }

        private void timerHopDong_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelHopDong.Height += 10;
                if (panelHopDong.Size == panelHopDong.MaximumSize)
                {
                    timerHopDong.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelHopDong.Height -= 10;
                if (panelHopDong.Size == panelHopDong.MinimumSize)
                {
                    timerHopDong.Stop();
                    isCollapsed = true;
                }
            }
        }

    }
}
