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
    public partial class frmDHNuoc : Form
    {
        public frmDHNuoc()
        {
            InitializeComponent();
        }

        private void frmDHNuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet5.DongHoNuoc' table. You can move, or remove it, as needed.
            this.dongHoNuocTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet5.DongHoNuoc);

        }
    }
}
