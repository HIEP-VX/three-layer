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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet.NhanVien);
            this.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            subAddForm sb = new subAddForm();
            sb.Show();
            
            sb.Logout += Sb_Logout;

            sb.DataAdded += () =>
            {
                try
                {
                    string query = "select * from NhanVien";
                    dgvNhanVien.DataSource = AccessData.getData(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }

        private void Sb_Logout(object sender, EventArgs e)
        {
            (sender as subAddForm).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as subAddForm).Close();
            this.Show();
        }
    }
}
