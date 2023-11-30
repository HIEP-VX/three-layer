using DAL;
using DevExpress.Xpo.DB.Helpers;
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
    public partial class subUpdateLKH : Form
    {
        public bool isExit = true;
        public event Action DataAdded;
        public subUpdateLKH()
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

            if (txtgiaBac1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bậc 1.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgiaBac1.Focus();
                return;
            }

            string query = "update loaiKhachHang set tenLoai = @tenLoai, giaBac1 = @giaBac1, giaBac2 = @giaBac2, giaBac3 = @giaBac3, giaBac4 = @giaBac4 where maLKH = @maLKH";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maLKH", txtMa.Text);
                cmd.Parameters.AddWithValue("@tenLoai", SqlDbType.NVarChar).Value = txtTenLoai.Text;
                cmd.Parameters.AddWithValue("@giaBac1", txtgiaBac1.Text);
                cmd.Parameters.AddWithValue("@giaBac2", txtGiaBac2.Text);
                cmd.Parameters.AddWithValue("@giaBac3", txtGiaBac3.Text);
                cmd.Parameters.AddWithValue("@giaBac4", txtGiaBac4.Text);

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
