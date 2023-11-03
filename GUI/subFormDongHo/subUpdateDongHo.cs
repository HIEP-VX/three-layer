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
