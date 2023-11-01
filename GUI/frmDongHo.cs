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
    public partial class frmDongHo : Form
    {
        public frmDongHo()
        {
            InitializeComponent();
        }

        private void frmDongHo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet1.DongHoNuoc' table. You can move, or remove it, as needed.
            this.dongHoNuocTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet1.DongHoNuoc);
            this.Refresh();
            panelTool.Size = panelTool.MinimumSize;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
