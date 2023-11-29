using DAL;
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
    public partial class frmLoaiDongHo : Form
    {
        public frmLoaiDongHo()
        {
            InitializeComponent();
        }

        private void reload()
        {
            try
            {
                string query = "select * from loaiDongHo";
                dgvLoaiDongHo.DataSource = AccessData.getData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmLoaiDongHo_Load(object sender, EventArgs e)
        {
            reload();
        }
    }
}
