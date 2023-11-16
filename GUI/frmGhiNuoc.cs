using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xls = Microsoft.Office.Interop.Excel;
using System.IO;
using OfficeOpenXml;
using System.Data.SqlClient;
using DAL;
using DevExpress.Xpo.DB.Helpers;

namespace GUI
{
    public partial class frmGhiNuoc : Form
    {
        SqlConnection conn = SqlConnectionData.connect();
        private BindingSource bindingSource;
        public frmGhiNuoc()
        {
            InitializeComponent();
            LoadRecords();
        }

        public void LoadRecords()
        {
            conn.Open();

            string address = "19/97 Đường Trường Chinh, Phường Bà Triệu, thành phố Nam Định, Nam Định";

            // Tìm vị trí của dấu ',' thứ nhất và thứ hai
            int firstCommaIndex = address.IndexOf(',');
            int secondCommaIndex = address.IndexOf(',', firstCommaIndex + 1);

            // Kiểm tra xem có tìm thấy dấu ',' thứ hai hay không
            if (firstCommaIndex != -1 && secondCommaIndex != -1)
            {
                // Tách chuỗi từ sau dấu ',' thứ nhất đến dấu ',' thứ hai
                string result = address.Substring(firstCommaIndex + 1, secondCommaIndex - firstCommaIndex - 1).Trim();

                // In kết quả
                Console.WriteLine(result);
            }
            else
                Console.WriteLine("Không tìm thấy dấu ',' thứ nhất hoặc thứ hai trong chuỗi.");


            SqlCommand cmd = new SqlCommand("Select maKH, thoiGian, chiSoMoi, luongNuoc from TieuThu", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            conn.Close();

            // Kiểm tra nếu BindingSource chưa được tạo, tạo mới
            if (bindingSource == null)
                bindingSource = new BindingSource();
            

            // Gán DataTable làm nguồn dữ liệu cho BindingSource
            bindingSource.DataSource = dataTable;

            // Gán BindingSource làm nguồn dữ liệu cho DataGridView
            dgvGhiNuoc.DataSource = bindingSource;
        }

        private void frmGhiNuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet.TieuThu' table. You can move, or remove it, as needed.
            this.tieuThuTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet.TieuThu);

            /*DateTime currentDate = DateTime.Now;
            int currentMonth = currentDate.Month;
            int currentYear = currentDate.Year;
            string query = $"SELECT maKH, CONVERT(VARCHAR, GETDATE(), 103) AS ThoiGian, chiSoMoi, luongNuoc FROM TieuThu WHERE MONTH(ThoiGian) = {currentMonth} AND YEAR(ThoiGian) = {currentYear}";
            dgvGhiNuoc.DataSource = AccessData.getData(query);*/
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            addGhiNuoc sb = new addGhiNuoc();
            sb.Show();
            sb.Logout += addForm_Logout;
            sb.DataAdded += () =>
            {
                try
                {
                    string query = "select maKH, ThoiGian, chiSoMoi, luongNuoc from TieuThu";
                    dgvGhiNuoc.DataSource = AccessData.getData(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }
        private void addForm_Logout(object sender, EventArgs e)
        {
            (sender as addGhiNuoc).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as addGhiNuoc).Close();
            this.Show();
        }

        private void importExcelData(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];

                    DataTable dt = new DataTable();

                    // Assume the first row contains column headers
                    for (int i = worksheet.Dimension.Start.Column; i <= worksheet.Dimension.End.Column; i++)
                    {
                        dt.Columns.Add(worksheet.Cells[1, i].Value.ToString());
                    }

                    // Populate DataTable with data starting from the second column
                    for (int row = worksheet.Dimension.Start.Row + 1; row <= worksheet.Dimension.End.Row; row++)
                    {
                        DataRow dataRow = dt.Rows.Add();
                        for (int col = 1; col <= 4; col++)
                        {
                            dataRow[col - 1] = worksheet.Cells[row, col].Value;
                        }
                    }

                    dgvGhiNuoc.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnThemExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                importExcelData(filePath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = false;
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                for (int i = 0; i < dgvGhiNuoc.Rows.Count; i++)
                {
                    if (dgvGhiNuoc.Rows[i].Cells[0].Value != null && !string.IsNullOrWhiteSpace(dgvGhiNuoc.Rows[i].Cells[0].Value.ToString()) &&
                        dgvGhiNuoc.Rows[i].Cells[1].Value != null &&
                        dgvGhiNuoc.Rows[i].Cells[2].Value != null && !string.IsNullOrWhiteSpace(dgvGhiNuoc.Rows[i].Cells[2].Value.ToString()) &&
                        dgvGhiNuoc.Rows[i].Cells[3].Value != null && !string.IsNullOrWhiteSpace(dgvGhiNuoc.Rows[i].Cells[3].Value.ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO TieuThu (maKH, ThoiGian, chiSoMoi, luongNuoc) values (@maKH, @ThoiGian, @chiSoMoi, @luongNuoc)", conn))
                        {
                            cmd.Parameters.AddWithValue("@maKH", dgvGhiNuoc.Rows[i].Cells[0].Value.ToString());
                            cmd.Parameters.AddWithValue("@ThoiGian", dgvGhiNuoc.Rows[i].Cells[1].Value);
                            cmd.Parameters.AddWithValue("@chiSoMoi", dgvGhiNuoc.Rows[i].Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@luongNuoc", dgvGhiNuoc.Rows[i].Cells[3].Value.ToString());

                            try
                            {
                                cmd.ExecuteNonQuery();
                                check = true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                        break;
                }
                if(check == true)
                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadRecords();
            conn.Close();
        }
    }
}