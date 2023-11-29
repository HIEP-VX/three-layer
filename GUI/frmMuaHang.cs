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
    public partial class frmMuaHang : Form
    {
        public frmMuaHang()
        {
            InitializeComponent();
        }

        private void frmMuaHang_Load(object sender, EventArgs e)
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
            panelBodyMuaHang.Controls.Add(childForm);
            panelBodyMuaHang.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void chiTiếtMuaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmChiTietMuaHang());
        }

        private void đồngHồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmDongHo());
        }

        private void phieuNhanHangToolStrip_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmPhieuNhanHang());
        }

        private void hoaDonNhanHangToolStrip_Click(object sender, EventArgs e)
        {

        }

        private void phiếuNhapKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loạiĐồngHồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmLoaiDongHo());
        }
    }
}
