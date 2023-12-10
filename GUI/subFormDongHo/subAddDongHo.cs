using DAL;
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
    public partial class subAddDongHo : Form
    {
        public bool isExit = true;
        public event Action DataAdded;

        public subAddDongHo()
        {
            InitializeComponent();
            setLinear.SetLinearGradient(button1, "#56d8e4", "#9f01ea");
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            string query = "INSERT INTO DongHoNuoc (chiSoDau, soCongTo, tinhTrang) values ( @chiSoDau, @soCongTo, @tinhTrang)";
            
            
            if(txtSoLuong.Text.Trim().Length == 0)
            {
                using  (SqlConnection conn = SqlConnectionData.connect())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
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
            }else
            {
                int amount = int.Parse(txtSoLuong.Text);
                using (SqlConnection conn = SqlConnectionData.connect())
                {
                    conn.Open();
                    for(int i = 0; i < amount; i++)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@chiSoDau", txtChiSoDau.Text);
                            cmd.Parameters.AddWithValue("@soCongTo", txtSoCongTo.Text);
                            cmd.Parameters.AddWithValue("@tinhTrang", selectedValue);
                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    DataAdded?.Invoke();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, không cho phép nhập
                e.Handled = true;
                MessageBox.Show("Nhập thông tin sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (e.KeyChar == '0' && ((TextBox)sender).Text.Length == 0)
            {
                // Không cho phép nhập số 0 ở đầu tiên
                e.Handled = true;
                MessageBox.Show("Số lượng phải là số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void subAddDongHo_Load(object sender, EventArgs e)
        {

        }
    }
}
