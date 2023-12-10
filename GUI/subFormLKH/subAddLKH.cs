using DAL;
using DevExpress.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class subAddLKH : Form
    {
        public bool isExit = true;
        public event Action DataAdded;
        public subAddLKH()
        {
            InitializeComponent();
            setLinear.SetLinearGradient(btnSubmit, "#56d8e4", "#9f01ea");
        }

        private void subAddLKH_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtTenLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoai.Focus();
                return;
            }

            if (txtgiaBac1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bậc 1.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgiaBac1.Focus();
                return;
            }

            if (txtGiaBac2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bậc 2.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaBac2.Focus();
                return;
            }

            if (txtGiaBac3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bậc 3.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaBac3.Focus();
                return;
            }

            if (txtGiaBac4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bậc 4.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaBac4.Focus();
                return;
            }

            string query = "INSERT INTO loaiKhachHang (tenLoai, giaBac1, giaBac2, giaBac3, giaBac4) values (@tenLoai, @giaBac1, @giaBac2, @giaBac3, @giaBac4)";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
