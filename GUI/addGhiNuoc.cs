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
    public partial class addGhiNuoc : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public event Action DataAdded;
        public addGhiNuoc()
        {
            InitializeComponent();
            SetLinearGradient(btnThem, "#56d8e4", "#9f01ea");
        }
        static string[] DataTableColumnToStringArray(DataTable dataTable, string columnName)
        {
            int rows = dataTable.Rows.Count;
            string[] dataArray = new string[rows];

            for (int i = 0; i < rows; i++)
                dataArray[i] = dataTable.Rows[i][columnName].ToString();
            
            return dataArray;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "select makh from khachhang ";
            DataTable dataTable = AccessData.getData(query);
            
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                string query1 = "INSERT INTO tieuThu (maKH, ThoiGianDau, ThoiGianCuoi, maNV) values (@maKH, @ThoiGianDau, @ThoiGianCuoi, @maNV)";
                string[] maKHArray = DataTableColumnToStringArray(dataTable, "MaKH");
                for (int i = 0; i < maKHArray.Length; i++)
                {

                    using (SqlCommand cmd = new SqlCommand(query1, conn))
                    {
                        // Xóa parameters cũ nếu có
                        cmd.Parameters.Clear();

                        // Thêm parameters mới
                        cmd.Parameters.AddWithValue("@maKH", dataTable.Rows[i]["MaKH"].ToString());
                        cmd.Parameters.AddWithValue("@ThoiGianDau", dateThoiGianDau.Value);
                        cmd.Parameters.AddWithValue("@ThoiGianCuoi", dateThoiGianCuoi.Value);
                        cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);

                        // Thực thi câu lệnh SQL
                        cmd.ExecuteNonQuery();

                        string query2 = "UPDATE TIEUTHU SET CHISOCU = (SELECT CHISODAU FROM DONGHONUOC dhn, KHACHHANG kh where dhn.MADHN = kh.MADHN and kh.MAKH = @maKH) where maKH = @maKH";

                        using (SqlCommand cmd1 = new SqlCommand(query2, conn))
                        {
                            cmd1.Parameters.AddWithValue("@maKH", dataTable.Rows[i]["MaKH"].ToString());
                            cmd1.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                DataAdded?.Invoke();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
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
