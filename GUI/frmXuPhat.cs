using DAL;
using DTO;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
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
    public partial class frmXuPhat : Form
    {
        private int index = -1;
        public frmXuPhat()
        {
            InitializeComponent();
        }

        private void reload()
        {
            txtMaNV.Text = user.id.ToString();
            string query = "select maXP, thoiGian, TienPhat, maHD1, maHD2, maNV,\n" +
                "CASE\n" +
                "WHEN trangThai = 1 THEN N'Cắt nước'\n" +
                "WHEN trangThai = 2 THEN N'Đang sử dụng'\n" +
                "END AS trangThai\n" +
                "from xuphat";
            dgvXuPhat.DataSource = AccessData.getData(query);
        }

        private void frmXuPhat_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Tách giá trị của ô trạng thái
                string selectedItem = cbTinhTrang.SelectedItem as string;
                string selectedValue = "";

                // Tách giá trị (trong trường hợp này, "1")
                string[] parts = selectedItem.Split('-');
                if (parts.Length == 2)
                    // Sử dụng giá trị (trong trường hợp này, "1")
                    selectedValue = parts[0].Trim();

                string query = "UPDATE xuPhat SET maNV = @maNV, trangThai = @trangThai WHERE maXP = @maXP\n" +
                               "IF ((select trangThai from xuphat where maXP = @maXP) = 2)\n" +
                               "BEGIN\n"+
                               "update xuphat set thoiGian = getdate() where maXP = @maXP\n" +
                               "END";

                

                using (SqlConnection conn = SqlConnectionData.connect())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maXP", txtMaXP.Text);
                    cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@trangThai", selectedValue);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvXuPhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMaXP.Text = dgvXuPhat.Rows[index].Cells[0].Value.ToString();
           // dateTimePicker1.Value = Convert.ToDateTime(dgvXuPhat.Rows[index].Cells[1].Value);
           // txtTienPhat.Text = dgvXuPhat.Rows[index].Cells[2].Value.ToString();
            txtMaHD1.Text = dgvXuPhat.Rows[index].Cells[3].Value.ToString();
            txtMaHD2.Text = dgvXuPhat.Rows[index].Cells[4].Value.ToString();
            cbTinhTrang.Text = dgvXuPhat.Rows[index].Cells[5].Value.ToString();
        }
    }
}
