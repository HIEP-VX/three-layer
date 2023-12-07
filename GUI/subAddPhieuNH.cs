using DAL;
using DevExpress.Xpo.DB.Helpers;
using DTO;
using System;
using System.Collections;
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
    public partial class subAddPhieuNH : Form
    {
        public event Action DataAdded;
        public subAddPhieuNH()
        {
            InitializeComponent();
            SetLinearGradient(btnThem, "#56d8e4", "#9f01ea");
        }

        private void subAddPhieuNH_Load(object sender, EventArgs e)
        {
            txtMANV.Text = user.id.ToString();
            txtTenNV.Text = user.user_name.ToString();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNHACC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNHACC.Focus();
                return;
            }

            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                try
                {
                    string query = "DECLARE @Inserted_maMH INT\n" +
                           "INSERT INTO phieuNhanHang (nhaCC, ngayMua, maNV) values (@nhaCC, @ngayMua, @maNV)\n" +
                           "SET @Inserted_maMH = SCOPE_IDENTITY();\n" +
                           "SELECT @Inserted_maMH AS 'maMH'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nhaCC", txtNHACC.Text);
                        cmd.Parameters.AddWithValue("@ngayMua", dateNgay.Value);
                        cmd.Parameters.AddWithValue("@maNV", txtMANV.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string maMH = reader["maMH"].ToString();
                                phieuNhanHang.maMH = int.Parse(maMH);
                            }
                        }
                    }
                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DataAdded?.Invoke();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
