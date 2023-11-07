using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class subUpdateKH : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public event Action DataAdded;
        public subUpdateKH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            if (txtHT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHT.Focus();
                return;
            }

            if (txtDC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDC.Focus();
                return;
            }

            if (txtSoDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            string sql = "update KhachHang set tenKH = @tenKH, ngaySinh = @ngaySinh, diaChi = @diaChi, soDT = @soDT where maKH = @maKH";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tenKH", SqlDbType.NVarChar).Value = txtHT.Text;
                cmd.Parameters.AddWithValue("@ngaySinh", SqlDbType.DateTime).Value = dateNS.Value;
                cmd.Parameters.AddWithValue("@diaChi", SqlDbType.NVarChar).Value = txtDC.Text;
                cmd.Parameters.AddWithValue("@soDT", SqlDbType.Char).Value = txtSoDT.Text;

                try
                {
                    cmd.ExecuteNonQuery();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

    }
}
