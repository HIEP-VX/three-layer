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
    public partial class subUpdateDongHo : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public event Action DataAdded;

        public subUpdateDongHo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đồng hồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            if (txtHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập hãng đồng hồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHang.Focus();
                return;
            }

            if (txtChiSoDau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chỉ số đầu của đồng hồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChiSoDau.Focus();
                return;
            }

            if (txtSoCongTo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số công tơ của đồng hồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoCongTo.Focus();
                return;
            }

            if (txtTinhTrang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập trạng thái cho đồng hồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTinhTrang.Focus();
                return;
            }

            string sql = "update DongHoNuoc set hangDHN = N'" + txtHang.Text + "',chiSoDau = " + txtChiSoDau.Text + ", soCongto = " + txtSoCongTo + ",tinhTrang = " + txtTinhTrang + " where maDHN = " + txtMa.Text;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }
    }
}
