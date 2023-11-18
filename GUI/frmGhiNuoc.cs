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
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;

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
            SqlCommand cmd = new SqlCommand("Select tt.maKH, chiSoMoi ,luongNuoc , ThoiGianDau, ThoiGianCuoi, maNV, kh.tenKH, kh.diaChi from TieuThu tt join khachhang kh on kh.maKH = tt.maKH", conn);
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

            //btnSave.Enabled = false;
            //btnThemExcel.Enabled = false;
        }

        private void frmGhiNuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet12.diaChi' table. You can move, or remove it, as needed.
            this.diaChiTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet12.diaChi);
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet10.TieuThu' table. You can move, or remove it, as needed.
            this.tieuThuTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet10.TieuThu);

            DateTime currentDate = DateTime.Now;
            int currentMonth = currentDate.Month;
            int currentYear = currentDate.Year;

            /*
            DataSet dataSet = new DataSet();
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TieuThu", conn);
                adapter.Fill(dataSet, "TieuThu");

                adapter = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
                adapter.Fill(dataSet, "KhachHang");
            

            // Kết hợp dữ liệu từ hai DataTable trong DataSet
            DataRelation relation = new DataRelation("TieuThu_KhachHang_Relation", dataSet.Tables["KhachHang"].Columns["maKH"], dataSet.Tables["TieuThu"].Columns["maKH"]);
            dataSet.Relations.Add(relation);*/

             
            string query = $"Select tt.maKH, chiSoMoi , luongNuoc , ThoiGianDau, CONVERT(VARCHAR, GETDATE(), 103) AS ThoiGianCuoi, maNV, kh.tenKH, kh.diaChi from tieuthu tt join khachhang kh on kh.maKH = tt.maKH WHERE MONTH(ThoiGianCuoi) = {currentMonth} AND YEAR(ThoiGianCuoi) = {currentYear}";
            dgvGhiNuoc.DataSource = AccessData.getData(query);
            
            /*
            DataSet dataSet = new DataSet();

            
                conn.Open();

                // Lấy dữ liệu từ bảng TieuThu
                SqlDataAdapter adapterTieuThu = new SqlDataAdapter("SELECT * FROM TieuThu", conn);
                adapterTieuThu.Fill(dataSet, "TieuThu");

                // Lấy dữ liệu từ bảng KhachHang
                SqlDataAdapter adapterKhachHang = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
                adapterKhachHang.Fill(dataSet, "KhachHang");
            

            // Kết hợp dữ liệu từ hai DataTable trong DataSet
            DataRelation relation = new DataRelation("TieuThu_KhachHang_Relation", dataSet.Tables["KhachHang"].Columns["maKH"], dataSet.Tables["TieuThu"].Columns["maKH"]);
            dataSet.Relations.Add(relation);

            // Lấy dữ liệu từ bảng TieuThu và thêm cột mới là "ThoiGianCuoi" vào bảng
            string query = $"SELECT T.maKH, chiSoMoi, luongNuoc, ThoiGianDau, CONVERT(VARCHAR, GETDATE(), 103) AS ThoiGianCuoi, maNV, K.tenKH, K.diaChi FROM TieuThu T JOIN KhachHang K ON K.maKH = T.maKH WHERE MONTH(ThoiGianCuoi) = {currentMonth} AND YEAR(ThoiGianCuoi) = { currentYear}";
            DataTable dataTable = AccessData.getData(query);

            // Đặt DataSource của DataGridView là DataTable mới
            dgvGhiNuoc.DataSource = dataTable;*/
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
                    string query = "Select tt.maKH, tt.chiSoMoi ,  tt.luongNuoc , tt.ThoiGianDau,  CONVERT(VARCHAR, GETDATE(), 103) AS ThoiGianCuoi, tt.maNV, kh.tenKH, kh.diaChi from TieuThu tt join khachhang kh on kh.maKH = tt.maKH";
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
                        //worksheet.Dimension.End.Column
                        for (int col = 1; col <= 6; col++)
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
                        dgvGhiNuoc.Rows[i].Cells[1].Value != null && !string.IsNullOrWhiteSpace(dgvGhiNuoc.Rows[i].Cells[1].Value.ToString()) &&
                        dgvGhiNuoc.Rows[i].Cells[2].Value != null && !string.IsNullOrWhiteSpace(dgvGhiNuoc.Rows[i].Cells[2].Value.ToString()) &&
                        dgvGhiNuoc.Rows[i].Cells[3].Value != null && dgvGhiNuoc.Rows[i].Cells[4].Value != null &&
                        dgvGhiNuoc.Rows[i].Cells[5].Value != null && !string.IsNullOrWhiteSpace(dgvGhiNuoc.Rows[i].Cells[5].Value.ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO TieuThu (maKH, chiSoMoi, luongNuoc, ThoiGianDau, ThoiGianCuoi, maNV) values (@maKH, @chiSoMoi, @luongNuoc, @ThoiGianDau, @ThoiGianCuoi, @maNV)", conn))
                        {
                            cmd.Parameters.AddWithValue("@maKH", dgvGhiNuoc.Rows[i].Cells[0].Value.ToString());
                            cmd.Parameters.AddWithValue("@chiSoMoi", dgvGhiNuoc.Rows[i].Cells[1].Value.ToString());
                            cmd.Parameters.AddWithValue("@luongNuoc", dgvGhiNuoc.Rows[i].Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@ThoiGianDau", dgvGhiNuoc.Rows[i].Cells[3].Value);
                            cmd.Parameters.AddWithValue("@ThoiGianCuoi", dgvGhiNuoc.Rows[i].Cells[4].Value);
                            cmd.Parameters.AddWithValue("@maNV", dgvGhiNuoc.Rows[i].Cells[5].Value.ToString());

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;
            string x=comboBox1.SelectedItem.ToString();
            string query = "select * form ";
            
        }
    }
}