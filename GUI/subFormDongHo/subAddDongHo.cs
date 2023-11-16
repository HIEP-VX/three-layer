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
    public partial class subAddDongHo : Form
    {

        public bool isExit = true;
        public event EventHandler Logout;
        public event Action DataAdded;

        public subAddDongHo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            if (txtTT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập trạng thái cho đồng hồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTT.Focus();
                return;
            }

            // Tách giá trị của ô trạng thái
            string selectedItem = txtTT.SelectedItem as string;
            string selectedValue = "";

            // Tách giá trị (trong trường hợp này, "1")
            string[] parts = selectedItem.Split('-');
            if (parts.Length == 2)
                // Sử dụng giá trị (trong trường hợp này, "1")
                selectedValue = parts[0].Trim();


            //string query = "INSERT INTO DongHoNuoc (hangDHN, chiSoDau, soCongTo, tinhTrang) values (N'" + txtHang.Text + "'," + txtChiSoDau.Text + "," + txtSoCongTo.Text + "," + selectedValue + ")";
            string query = "INSERT INTO DongHoNuoc (hangDHN, chiSoDau, soCongTo, tinhTrang) values (@hangDHN, @chiSoDau, @soCongTo, @tinhTrang)";
            using  (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@hangDHN", SqlDbType.NVarChar).Value = txtHang.Text;
                cmd.Parameters.AddWithValue("@chiSoDau", txtChiSoDau.Text);
                cmd.Parameters.AddWithValue("@soCongTo", txtSoCongTo.Text);
                cmd.Parameters.AddWithValue("@tinhTrang", selectedValue);

                try
                {
                   cmd.ExecuteNonQuery();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void subAddDongHo_Load(object sender, EventArgs e)
        {

        }
    }
}
