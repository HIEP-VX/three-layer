using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuanLyKH : Form
    {
        public frmQuanLyKH()
        {
            InitializeComponent();
        }

        private void frmQuanLyKH_Load(object sender, EventArgs e)
        {

        }


        private Form currentFormChild;

        // mở form con
        private void OpenFormChild(Form childForm)
        {
            if (currentFormChild != null)
                currentFormChild.Close();

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBodyQuanLyKH.Controls.Add(childForm);
            panelBodyQuanLyKH.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmKhachHang());
        }

        private void loạiKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmLKH());
        }

        private void phườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmQuanLyPhuong());
        }
    }
}
