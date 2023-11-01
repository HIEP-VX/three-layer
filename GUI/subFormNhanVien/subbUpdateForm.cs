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
    public partial class subbUpdateForm : Form
    {

        public bool isExit = true;
        public event EventHandler Logout;
        public event Action DataAdded;

        public subbUpdateForm()
        {
            InitializeComponent();
        }

        private void subbUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sql = "update NhanVien set TENNV = N'" + txttenNV.Text + "',soDT = '" + txtsoDT.Text + "' where maNV = " + txtMa.Text ;
            try
            {
                AccessData.execQuery(sql);
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
            DataAdded?.Invoke();
        }
    }
}
