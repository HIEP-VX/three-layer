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
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class frmTieuThu : Form
    {
        SqlConnection conn = SqlConnectionData.connect();
        private BindingSource bindingSource;
        bool isCollapsed = true;

        public frmTieuThu()
        {
            InitializeComponent();
            SetLinearGradient(btnLuuChiSo, "#56d8e4", "#9f01ea");
            LoadRecords();
        }

        public void LoadRecords()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select maTT, tt.maNV, tt.maKH, chiSoCu, chiSoMoi , luongNuoc ,  ThoiGianDau, CONVERT(VARCHAR, GETDATE(), 103) AS ThoiGianCuoi,kh.tenKH, kh.phuong, kh.diaChi, nv.tenNV from tieuthu tt join khachhang kh on kh.maKH = tt.maKH join nhanvien nv on nv.maNV = tt.maNV", conn);
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

            btnSave.Enabled = false;
            btnThemExcel.Enabled = false;
            grpChiSoNuoc.Visible = false;
        }

        private void reload()
        {
            try
            {
                /*DateTime currentDate = DateTime.Now;
                int currentMonth = currentDate.Month;
                int currentYear = currentDate.Year;*/
                // CONVERT(VARCHAR, GETDATE(), 103) AS
                string query = $"Select maTT, tt.maNV, tt.maKH, chiSoCu, chiSoMoi , luongNuoc ,  ThoiGianDau, ThoiGianCuoi,kh.tenKH, kh.phuong, kh.diaChi, nv.tenNV from tieuthu tt join khachhang kh on kh.maKH = tt.maKH join nhanvien nv on nv.maNV = tt.maNV";
                dgvGhiNuoc.DataSource = AccessData.getData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmGhiNuoc_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
                cbThang.Items.Add(i);
            reload();
        }

        private void btnGhiNuoc_Click(object sender, EventArgs e)
        {
            addGhiNuoc sb = new addGhiNuoc(this);
            sb.ShowDialog();
            sb.DataAdded += () =>
            {
                try
                {
                    string query = "Select maTT, tt.maNV, tt.maKH, chiSoCu, chiSoMoi , luongNuoc ,  ThoiGianDau, CONVERT(VARCHAR, GETDATE(), 103) AS ThoiGianCuoi,kh.tenKH, kh.phuong, kh.diaChi, nv.tenNV from tieuthu tt join khachhang kh on kh.maKH = tt.maKH join nhanvien nv on nv.maNV = tt.maNV";
                    dgvGhiNuoc.DataSource = AccessData.getData(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }

        public void HandleAddButton()
        {
            timerGhiNuoc.Start();
            grpChiSoNuoc.Visible = true;
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
                        dgvGhiNuoc.Rows[i].Cells[3].Value != null && !string.IsNullOrWhiteSpace(dgvGhiNuoc.Rows[i].Cells[3].Value.ToString()) &&
                        dgvGhiNuoc.Rows[i].Cells[4].Value != null && !string.IsNullOrWhiteSpace(dgvGhiNuoc.Rows[i].Cells[4].Value.ToString()) &&
                        dgvGhiNuoc.Rows[i].Cells[5].Value != null && dgvGhiNuoc.Rows[i].Cells[6].Value != null)
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO TieuThu (maNV, maKH, chiSoCu, chiSoMoi, luongNuoc, ThoiGianDau, ThoiGianCuoi) values (@maNV, @maKH, @chiSoCu, @chiSoMoi, @luongNuoc, @ThoiGianDau, @ThoiGianCuoi)", conn))
                        {
                            cmd.Parameters.AddWithValue("@maNV", dgvGhiNuoc.Rows[i].Cells[0].Value.ToString());
                            cmd.Parameters.AddWithValue("@maKH", dgvGhiNuoc.Rows[i].Cells[1].Value.ToString());
                            cmd.Parameters.AddWithValue("@chiSoCu", dgvGhiNuoc.Rows[i].Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@chiSoMoi", dgvGhiNuoc.Rows[i].Cells[3].Value.ToString());
                            cmd.Parameters.AddWithValue("@luongNuoc", dgvGhiNuoc.Rows[i].Cells[4].Value.ToString());
                            cmd.Parameters.AddWithValue("@ThoiGianDau", dgvGhiNuoc.Rows[i].Cells[5].Value);
                            cmd.Parameters.AddWithValue("@ThoiGianCuoi", dgvGhiNuoc.Rows[i].Cells[6].Value);

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

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "update tieuthu set chiSoMoi = " + txtChiSoNuoc.Text +"where maTT = " + txtMATT.Text;
            AccessData.execQuery(query);

            string query2 = "update donghonuoc set chiSoDau = " + txtChiSoNuoc.Text + "where maDHN = (select madhn from khachhang kh , tieuthu tt where maTT = " + txtMATT.Text +"and tt.maKH = kh.maKH)";
            AccessData.execQuery(query2);

            string query3 = "Update tieuthu set luongNuoc = chisomoi - chiSoCu where maTT = " + txtMATT.Text;
            AccessData.execQuery(query3);

            reload();
        }

        private void dgvGhiNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMATT.Text = dgvGhiNuoc.Rows[index].Cells[0].Value.ToString();
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMonth = Convert.ToInt32(cbThang.SelectedItem);
            dgvGhiNuoc.DataSource = LoadDataByMonth(selectedMonth);
        }

        private DataTable LoadDataByMonth(int selectedMonth)
        {
            // Thực hiện truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu dựa trên tháng
            string query = $"Select maTT, tt.maNV, tt.maKH, chiSoCu, chiSoMoi , luongNuoc ,  ThoiGianDau, CONVERT(VARCHAR, GETDATE(), 103) AS ThoiGianCuoi,kh.tenKH, kh.phuong, kh.diaChi, nv.tenNV from tieuthu tt join khachhang kh on kh.maKH = tt.maKH join nhanvien nv on nv.maNV = tt.maNV WHERE MONTH(ThoiGianCuoi) = {selectedMonth} AND YEAR(ThoiGianCuoi) = YEAR(GETDATE())";
            
            // Thực hiện truy vấn và trả về dữ liệu dưới dạng DataTable
            DataTable dataTable = AccessData.getData(query);
            return dataTable;
        }

        private void timerGhiNuoc_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timerGhiNuoc.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timerGhiNuoc.Stop();
                    isCollapsed = true;
                }
            }
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