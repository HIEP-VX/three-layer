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
    public partial class frmQuanLyDoanhThu : Form
    {
        public frmQuanLyDoanhThu()
        {
            InitializeComponent();
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
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmDoanhThuHD());
        }

        private void tiềnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmDoanhThuTienNuoc());
        }

        private void tiềnMuaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmDoanhThuMuaHang());

        }
    }
}
