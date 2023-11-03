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
    public partial class subAddLKH : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public event Action DataAdded;
        public subAddLKH()
        {
            InitializeComponent();
        }

        private void subAddLKH_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO loaiKhachHang (tenLoai, giaBac1, giaBac2, giaBac3, giaBac4) values (N'" + txtTenLoai.Text + "', " + txtgiaBac1.Text + ", " + txtGiaBac2.Text + ", " + txtGiaBac3.Text + ", " + txtGiaBac4.Text + ")";
            try
            {
                AccessData.execQuery(query);
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
