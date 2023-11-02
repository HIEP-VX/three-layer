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
    public partial class frmTieuThu : Form
    {
        public frmTieuThu()
        {
            InitializeComponent();
        }

        private void frmTieuThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet6.TieuThu' table. You can move, or remove it, as needed.
            this.tieuThuTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet6.TieuThu);

        }
    }
}
