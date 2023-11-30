using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.MetadataServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class subUpdateHopD : Form
    {

        public bool isExit = true;
        public event Action DataAdded;

        public subUpdateHopD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hợp đồng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            string query = "update HopDong set ngayLamHD = @ngayLamHD, noiLamHD = @noiLamHD where maHD = @maHD";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maHD", txtMa.Text);
                cmd.Parameters.AddWithValue("@ngayLamHD", SqlDbType.DateTime).Value = dateTimeNL.Value;
                cmd.Parameters.AddWithValue("@noiLamHD", SqlDbType.NVarChar).Value = txtNL.Text;

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
            this.Close();
        }
    }
}
