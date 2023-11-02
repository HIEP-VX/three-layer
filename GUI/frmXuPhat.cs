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
    public partial class frmXuPhat : Form
    {
        public frmXuPhat()
        {
            InitializeComponent();
        }

        private void frmXuPhat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet8.XuPhat' table. You can move, or remove it, as needed.
            this.xuPhatTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet8.XuPhat);

        }
    }
}
