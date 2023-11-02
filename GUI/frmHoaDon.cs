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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet7.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet7.HoaDon);

        }
    }
}
