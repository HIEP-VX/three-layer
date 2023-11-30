using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class subAddForm : Form
    {

        public bool isExit = true;
        public event Action DataAdded;

        public subAddForm()
        {
            InitializeComponent();
            SetLinearGradient(btnSubmit, "#56d8e4", "#9f01ea");
        }

        #region Event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txttenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenNV.Focus();
                return;
            }

            if (txtsoDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoDT.Focus();
                return;
            }

            string query = @"INSERT INTO NhanVien (tenNV, soDT) values (@tenNV, @soDT)";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenNV", SqlDbType.NVarChar).Value = txttenNV.Text;
                cmd.Parameters.AddWithValue("@soDT", SqlDbType.Char).Value = txtsoDT.Text;

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

        private void subAddForm_Load(object sender, EventArgs e)
        {

        }

        private void SetLinearGradient(Button btn, string hexColor1, string hexColor2)
        {
            // Chuyển đổi mã màu hex thành đối tượng Color
            Color color1 = ColorTranslator.FromHtml(hexColor1);
            Color color2 = ColorTranslator.FromHtml(hexColor2);

            // Tạo đối tượng LinearGradientBrush
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
                btn.ClientRectangle,
                color1,
                color2,
                LinearGradientMode.Horizontal); // Có thể thay đổi hướng dải màu tại đây

            // Thiết lập màu nền của Panel là dải màu linear
            btn.BackColor = Color.Transparent; // Đặt màu nền trong suốt để thấy rõ dải màu
            btn.BackgroundImage = new Bitmap(btn.Width, btn.Height);
            using (Graphics g = Graphics.FromImage(btn.BackgroundImage))
            {
                g.FillRectangle(linearGradientBrush, btn.ClientRectangle);
            }
        }
    }
}
