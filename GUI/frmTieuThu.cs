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
using DTO;

namespace GUI
{
    public partial class frmTieuThu : Form
    {
        SqlConnection conn = SqlConnectionData.connect();
        private BindingSource bindingSource;
        bool isCollapsed = true;
        private int index = -1;
        bool nutDaDuocNhan = false;

        public frmTieuThu()
        {
            InitializeComponent();
            SetLinearGradient(btnLuuChiSo, "#56d8e4", "#9f01ea");
            SetLinearGradient(btnTimKiem, "#56d8e4", "#9f01ea");
            LoadRecords();
        }

        public void LoadRecords()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select maTT, tt.maNV, tt.maKH, chiSoCu, chiSoMoi , luongNuoc ,  ThoiGianDau, ThoiGianCuoi,kh.tenKH, kh.diaChi, kh.phuong, nv.tenNV from tieuthu tt join khachhang kh on kh.maKH = tt.maKH join nhanvien nv on nv.maNV = tt.maNV", conn);
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

            grpChiSoNuoc.Enabled = false;
        }

        private void reload()
        {
            try
            {
                /*DateTime currentDate = DateTime.Now;
                int currentMonth = currentDate.Month;
                int currentYear = currentDate.Year;*/
                //where month(tt.thoiGianCuoi) = month(getdate()) - 1"
                string query = $"Select maTT, tt.maNV, tt.maKH, chiSoCu, chiSoMoi , luongNuoc ,  ThoiGianDau, ThoiGianCuoi,kh.tenKH, kh.diaChi, kh.phuong, nv.tenNV from tieuthu tt join khachhang kh on kh.maKH = tt.maKH join nhanvien nv on nv.maNV = tt.maNV ";
                dgvGhiNuoc.DataSource = AccessData.getData(query);

                dgvGhiNuoc.Columns[0].HeaderText = "Mã tiêu thụ";
                dgvGhiNuoc.Columns[1].HeaderText = "Mã nhân viên";
                dgvGhiNuoc.Columns[2].HeaderText = "Mã khách hàng";
                dgvGhiNuoc.Columns[3].HeaderText = "Chỉ số cũ";
                dgvGhiNuoc.Columns[4].HeaderText = "Chỉ số mới";
                dgvGhiNuoc.Columns[5].HeaderText = "Lượng nước";
                dgvGhiNuoc.Columns[6].HeaderText = "Thời gian đầu";
                dgvGhiNuoc.Columns[7].HeaderText = "Thời gian cuối";
                dgvGhiNuoc.Columns[8].HeaderText = "Tên khách hàng";
                dgvGhiNuoc.Columns[9].HeaderText = "Đường";
                dgvGhiNuoc.Columns[10].HeaderText = "Phường";
                dgvGhiNuoc.Columns[11].HeaderText = "Tên nhân viên";

                foreach (DataGridViewColumn column in dgvGhiNuoc.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void reload2()
        {
            try
            {
                /*DateTime currentDate = DateTime.Now;
                int currentMonth = currentDate.Month;
                int currentYear = currentDate.Year;*/

                // if (thoiGianGhiNuoc.thoiGianCuoi == null)
                //   return;

                DateTime thoiGianCuoi = thoiGianGhiNuoc.thoiGianCuoi;
                string formattedDateTime = thoiGianCuoi.ToString("yyyy-MM-dd HH:mm:ss");

                string query = $"Select maTT, tt.maNV, tt.maKH, chiSoCu, chiSoMoi , luongNuoc ,  ThoiGianDau, ThoiGianCuoi,kh.tenKH, kh.diaChi, kh.phuong, nv.tenNV from tieuthu tt join khachhang kh on kh.maKH = tt.maKH join nhanvien nv on nv.maNV = tt.maNV WHERE CONVERT(DATE, tt.ThoiGianCuoi) = CONVERT(DATE, '{formattedDateTime}')";
                dgvGhiNuoc.DataSource = AccessData.getData(query);

                dgvGhiNuoc.Columns[0].HeaderText = "Mã tiêu thụ";
                dgvGhiNuoc.Columns[1].HeaderText = "Mã nhân viên";
                dgvGhiNuoc.Columns[2].HeaderText = "Mã khách hàng";
                dgvGhiNuoc.Columns[3].HeaderText = "Chỉ số cũ";
                dgvGhiNuoc.Columns[4].HeaderText = "Chỉ số mới";
                dgvGhiNuoc.Columns[5].HeaderText = "Lượng nước";
                dgvGhiNuoc.Columns[6].HeaderText = "Thời gian đầu";
                dgvGhiNuoc.Columns[7].HeaderText = "Thời gian cuối";
                dgvGhiNuoc.Columns[8].HeaderText = "Tên khách hàng";
                dgvGhiNuoc.Columns[9].HeaderText = "Đường";
                dgvGhiNuoc.Columns[10].HeaderText = "Phường";
                dgvGhiNuoc.Columns[11].HeaderText = "Tên nhân viên";

                foreach (DataGridViewColumn column in dgvGhiNuoc.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmGhiNuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet4.diaChi' table. You can move, or remove it, as needed.
            this.diaChiTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet4.diaChi);
            for (int i = 1; i <= 12; i++)
                cbThangTGD.Items.Add(i);
            for (int i = 1; i <= 12; i++)
                cbThangTGC.Items.Add(i);
            reload();

            btnChiaPhuong.Enabled = false;
            comboBoxPhuong.Text = "";
            btnSave.Enabled = false;
        }

        private void btnGhiNuoc_Click(object sender, EventArgs e)
        {
            nutDaDuocNhan = true;
            btnChiaPhuong.Enabled = true;
            addGhiNuoc sb = new addGhiNuoc(this);
            sb.ShowDialog();
            sb.DataAdded += () =>
            {
                reload2();
            };
            reload2();
        }

        public void HandleAddButton()
        {
            grpChiSoNuoc.Enabled = true;
        }

        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã tiêu thụ";

            cl1.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Mã khách hàng";

            cl2.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Họ tên";
            cl3.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Đường";

            cl4.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Phường";

            cl5.ColumnWidth = 18;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Chỉ số cũ";

            cl6.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Chỉ số mới";

            cl7.ColumnWidth = 13.5;
            /*
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Trình độ học vấn";

            cl8.ColumnWidth = 14.5;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

            cl9.Value2 = "Mã bộ phận";

            cl9.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range c20 = oSheet.get_Range("J3", "J3");

            c20.Value2 = "Mã chức vụ";

            c20.ColumnWidth = 12.5;
            */
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void ImportFromExcel(string filePath)
        {
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets["Danh sach"];

                    if(worksheet != null)
                    {
                        // Duyệt từng dòng trong file Excel
                        for (int row = 4; row <= worksheet.Dimension.End.Row; row++)
                        {
                            // Lấy giá trị cột đầu tiên trong file Excel
                            string conditionValueExcel = worksheet.Cells[row, 1].Text;

                            // Tìm dòng tương ứng trong DataGridView
                            DataGridViewRow existingRow = dgvGhiNuoc.Rows
                                .Cast<DataGridViewRow>()
                                .FirstOrDefault(r => r.Cells[0].Value?.ToString() == conditionValueExcel);

                            // Nếu tìm thấy dòng tương ứng, thêm dữ liệu vào 2 cột trống
                            if (existingRow != null)
                            {
                                // Lấy giá trị từ cột 7 trong file Excel
                                object valueToAdd = worksheet.Cells[row, 7].Value;

                                // Kiểm tra nếu giá trị không rỗng
                                if (valueToAdd != null)
                                {
                                    // Thêm giá trị vào cột 4 trong DataGridView
                                    existingRow.Cells[4].Value = valueToAdd;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("worksheet");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nhập dữ liệu từ Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Lỗi: " + ex.Message + "\nStack Trace:\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportFromExcel(filePath);
            }
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvGhiNuoc.Rows)
                {
                    // Kiểm tra xem dòng có thay đổi không
                    if (row.Cells[4].Value != null && !string.IsNullOrEmpty(row.Cells[4].Value.ToString()))
                    {
                        int maTT = Convert.ToInt32(row.Cells[0].Value);
                        int chiSoCu = int.Parse(row.Cells[3].Value.ToString());
                        int chiSoMoi = int.Parse(row.Cells[4].Value.ToString());

                        UpdateDataInDatabase(maTT, chiSoCu, chiSoMoi);
                    }
                }
                MessageBox.Show("Dữ liệu đã được cập nhật vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateDataInDatabase(int maTT, int chiSoCu, int chiSoMoi)
        {
            string sql = "update tieuthu set chiSoMoi = @chiSoMoi where maTT = @maTT\n" +
                         "Update tieuthu set luongNuoc = @chisomoi - @chiSoCu where maTT = @maTT";

            using (SqlConnection connection = SqlConnectionData.connect())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@chiSoCu", chiSoCu);
                    command.Parameters.AddWithValue("@chiSoMoi", chiSoMoi);
                    command.Parameters.AddWithValue("@maTT", maTT);
                    command.ExecuteNonQuery();
                }
            }
            reload();
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
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMATT.Text = dgvGhiNuoc.Rows[index].Cells[0].Value.ToString();
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

        private void btnChiaPhuong_Click(object sender, EventArgs e)
        {
            if (nutDaDuocNhan)
            {
                string query = $"Select maTT, tt.maNV, tt.maKH, chiSoCu, chiSoMoi , luongNuoc ,  ThoiGianDau, ThoiGianCuoi,kh.tenKH, kh.diaChi, kh.phuong, nv.tenNV from tieuthu tt join khachhang kh on kh.maKH = tt.maKH join nhanvien nv on nv.maNV = tt.maNV where thoiGianCuoi = '" + thoiGianGhiNuoc.thoiGianCuoi + "' \norder by kh.phuong";
                dgvGhiNuoc.DataSource = AccessData.getData(query);
                grpChiSoNuoc.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bạn cần ghi nước trước.");
            }
            
        }

        private void dgvGhiNuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            showDetailTieuThu sw = new showDetailTieuThu();

            sw.maTT = int.Parse(dgvGhiNuoc.Rows[index].Cells[0].Value.ToString());
            sw.maNV = int.Parse(dgvGhiNuoc.Rows[index].Cells[1].Value.ToString());
            sw.maKH = int.Parse(dgvGhiNuoc.Rows[index].Cells[2].Value.ToString());
            sw.chiSoCu = int.Parse(dgvGhiNuoc.Rows[index].Cells[3].Value.ToString());
            sw.chiSoMoi = int.Parse(dgvGhiNuoc.Rows[index].Cells[4].Value.ToString());
            sw.luongNuoc = int.Parse(dgvGhiNuoc.Rows[index].Cells[5].Value.ToString());
            sw.thoiGianDau = Convert.ToDateTime(dgvGhiNuoc.Rows[index].Cells[6].Value);
            sw.thoiGianCuoi = Convert.ToDateTime(dgvGhiNuoc.Rows[index].Cells[7].Value);
            sw.hoTenKH = dgvGhiNuoc.Rows[index].Cells[8].Value.ToString();
            sw.diaChi = dgvGhiNuoc.Rows[index].Cells[9].Value.ToString();
            sw.phuong = dgvGhiNuoc.Rows[index].Cells[10].Value.ToString();
            sw.hoTenNV = dgvGhiNuoc.Rows[index].Cells[11].Value.ToString();

            sw.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                grpChiSoNuoc.Enabled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = $"Select maTT, tt.maNV, tt.maKH, chiSoCu, chiSoMoi , luongNuoc ,  ThoiGianDau, ThoiGianCuoi,kh.tenKH, kh.diaChi, kh.phuong, nv.tenNV from tieuthu tt join khachhang kh on kh.maKH = tt.maKH join nhanvien nv on nv.maNV = tt.maNV where 1=1";

            if (!string.IsNullOrEmpty(textMAtt.Text))
            {
                query += $" AND maTT =" + textMAtt.Text;
            }

            if (!string.IsNullOrEmpty(txtMaKH.Text))
            {
                query += $" AND tt.maKH =" + txtMaKH.Text;
            }

            if (!string.IsNullOrEmpty(txtCSCu.Text))
            {
                query += $" AND chiSoCu =" + txtCSCu.Text;
            }

            if (!string.IsNullOrEmpty(txtCSMoi.Text))
            {
                query += $" AND chiSoMoi =" + txtCSMoi.Text;
            }

            if (!string.IsNullOrEmpty(txtLuongNuoc.Text))
            {
                query += $" AND luongNuoc =" + txtLuongNuoc.Text;
            }

            if (!string.IsNullOrEmpty(txtNgayTGD.Text))
            {
                query += $" AND day(thoiGianDau) =" + txtNgayTGD.Text;
            }

            if (!string.IsNullOrEmpty(cbThangTGD.Text))
            {
                query += $" AND month(thoiGianDau) =" + cbThangTGD.Text;
            }

            if (!string.IsNullOrEmpty(txtNamTGD.Text))
            {
                query += $" AND year(thoiGianDau) =" + txtNamTGD.Text;
            }

            if (!string.IsNullOrEmpty(txtNgayTGC.Text))
            {
                query += $" AND day(ThoiGianCuoi) = " + txtNgayTGC.Text;
            }

            if (!string.IsNullOrEmpty(cbThangTGC.Text))
            {
                query += $" AND month(ThoiGianCuoi) = " + cbThangTGC.Text;
            }

            if (!string.IsNullOrEmpty(txtNamTGC.Text))
            {
                query += $" AND month(ThoiGianCuoi) = " + txtNamTGC.Text;
            }

            if (!string.IsNullOrEmpty(txtDuong.Text))
            {
                query += $" AND kh.diaChi like N'%" + txtDuong.Text + "%'";
            }

            if (!string.IsNullOrEmpty(comboBoxPhuong.Text))
            {
                query += $" AND kh.Phuong like N'%" + comboBoxPhuong.Text + "%'";
            }

            if (!string.IsNullOrEmpty(txtTenKH.Text))
            {
                query += $" AND kh.tenKH like N'%" + txtTenKH.Text + "%'";
            }

            dgvGhiNuoc.DataSource = AccessData.getData(query);
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("ID_TT");
            DataColumn col2 = new DataColumn("ID_KH");
            DataColumn col3 = new DataColumn("Name");
            DataColumn col4 = new DataColumn("Round");
            DataColumn col5 = new DataColumn("Ward");
            DataColumn col6 = new DataColumn("oldIndex");
            DataColumn col7 = new DataColumn("newIndex");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);

            foreach (DataGridViewRow dtgvRow in dgvGhiNuoc.Rows)
            {
                DataRow dtrow = dataTable.NewRow();

                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[2].Value;
                dtrow[2] = dtgvRow.Cells[8].Value;
                dtrow[3] = dtgvRow.Cells[9].Value;
                dtrow[4] = dtgvRow.Cells[10].Value;
                dtrow[5] = dtgvRow.Cells[3].Value;
                dtrow[6] = dtgvRow.Cells[4].Value;

                dataTable.Rows.Add(dtrow);
            }

            ExportFile(dataTable, "Danh sach", "Danh sách ghi nước");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tiêu thụ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sql = "Delete from tieuThu where maTT = '" + txtMATT.Text + "'";
                    try
                    {
                        AccessData.execQuery(sql);
                        MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}