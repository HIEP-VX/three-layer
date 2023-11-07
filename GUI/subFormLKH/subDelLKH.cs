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
    public partial class subDelLKH : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public event Action DataAdded;
        public subDelLKH()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sql = "Delete from loaiKhachHang where maLKH = '" + txtMa.Text + "'";
                try
                {
                    AccessData.execQuery(sql);
                    MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
                DataAdded?.Invoke();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }
    }
}
