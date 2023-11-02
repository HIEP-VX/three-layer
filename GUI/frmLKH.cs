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
    public partial class frmLKH : Form
    {
        public frmLKH()
        {
            InitializeComponent();
        }

        private void frmLKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet3.loaiKhachHang' table. You can move, or remove it, as needed.
            this.loaiKhachHangTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet3.loaiKhachHang);

        }
    }
}
