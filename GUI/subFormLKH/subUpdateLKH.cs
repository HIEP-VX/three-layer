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
    public partial class subUpdateLKH : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public event Action DataAdded;
        public subUpdateLKH()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sql = "update loaiKhachHang set tenLoai = N'" + txtTenLoai.Text + "'," + txtgiaBac1.Text + "'," + txtGiaBac2.Text + "'," + txtGiaBac3.Text + "'," + txtGiaBac4.Text + "' where maLKH = " + txtMa.Text;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }
    }
}
