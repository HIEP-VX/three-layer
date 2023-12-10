using DAL;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLoaiDongHo : Form
    {
        private int index = -1;
        public frmLoaiDongHo()
        {
            InitializeComponent();
        }

        private void reload()
        {
            dgvLoaiDongHo.RowTemplate.Height = 26;
            try
            {
                string query = "select * from loaiDongHo";
                dgvLoaiDongHo.DataSource = AccessData.getData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmLoaiDongHo_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string query = $"select * from loaiDongHo where 1=1 ";

            if (!string.IsNullOrEmpty(txtMaSP.Text))
                query += $" AND maSP =" + txtMaSP.Text;

            if (!string.IsNullOrEmpty(txttenSP.Text))
                query += $" AND tenSP like N'%" + txttenSP.Text + "%'";
            
            if (!string.IsNullOrEmpty(txtchiSo.Text))
                query += $" AND chiSoCongTo =" + txtchiSo.Text;

            if (!string.IsNullOrEmpty(txtTenHang.Text))
                query += $" AND tenHangSX like N'%" + txtTenHang.Text + "%'";
            
            dgvLoaiDongHo.DataSource = AccessData.getData(query);
        }

        private void dgvLoaiDongHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMaSP.Text = dgvLoaiDongHo.Rows[index].Cells[0].Value.ToString();
            txttenSP.Text = dgvLoaiDongHo.Rows[index].Cells[1].Value.ToString();
            txtchiSo.Text = dgvLoaiDongHo.Rows[index].Cells[2].Value.ToString();
            txtTenHang.Text = dgvLoaiDongHo.Rows[index].Cells[3].Value.ToString();
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "D1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã sản phẩm";

            cl1.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Tên sản phẩm";

            cl2.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Chỉ số công tơ";
            cl3.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Tên hãng sản xuất";

            cl4.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "D3");

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

            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("ID_TT");
            DataColumn col2 = new DataColumn("ID_KH");
            DataColumn col3 = new DataColumn("Name");
            DataColumn col4 = new DataColumn("Round");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);

            foreach (DataGridViewRow dtgvRow in dgvLoaiDongHo.Rows)
            {
                DataRow dtrow = dataTable.NewRow();

                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;

                dataTable.Rows.Add(dtrow);
            }

            ExportFile(dataTable, "Danh sach", "Danh sách loại đồng hồ");
        }
    }
}
