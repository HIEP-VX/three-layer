using DAL;
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
    public partial class frmChiTietMuaHang : Form
    {
        private int index = -1;
        public frmChiTietMuaHang()
        {
            InitializeComponent();
        }

        private void reload()
        {
            dgvChiTietMuaHang.RowTemplate.Height = 26;
            try
            {
                string query = "select maChiTiet, maSP, maMH, soLuong, FORMAT(CAST(tien AS DECIMAL(18, 0)), 'N0') AS tienFormatted from chiTietMuaHang";
                dgvChiTietMuaHang.DataSource = AccessData.getData(query);

                dgvChiTietMuaHang.Columns[0].HeaderText = "Mã chi tiết";
                dgvChiTietMuaHang.Columns[1].HeaderText = "Mã sản phẩm";
                dgvChiTietMuaHang.Columns[2].HeaderText = "Mã mua hàng";
                dgvChiTietMuaHang.Columns[3].HeaderText = "Số lượng";
                dgvChiTietMuaHang.Columns[4].HeaderText = "Tiền";

                foreach (DataGridViewColumn column in dgvChiTietMuaHang.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmChiTietMuaHang_Load(object sender, EventArgs e)
        {
            reload();
            setLinear.SetLinearGradient(btnTimKiem, "#56d8e4", "#9f01ea");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = $"select maChiTiet, maSP, maMH, soLuong, FORMAT(CAST(tien AS DECIMAL(18, 0)), 'N0') AS tienFormatted from chiTietMuaHang where 1=1 ";

            if (!string.IsNullOrEmpty(txtMaCT.Text))
                query += $" AND maChiTiet =" + txtMaCT.Text;

            if (!string.IsNullOrEmpty(txtMaSP.Text))
                query += $" AND maSP =" + txtMaSP.Text;

            if (!string.IsNullOrEmpty(txtmaMH.Text))
                query += $" AND maMH =" + txtmaMH.Text;

            if (!string.IsNullOrEmpty(txtSL.Text))
                query += $" AND soLuong =" + txtSL.Text;

            if (!string.IsNullOrEmpty(txtTien.Text))
                query += $" AND tien =" + txtTien.Text;

            dgvChiTietMuaHang.DataSource = AccessData.getData(query);
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã chi tiết";

            cl1.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Mã sản phẩm";

            cl2.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Mã mua hàng";
            cl3.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Số lượng";

            cl4.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Đơn giá";

            cl5.ColumnWidth = 18;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");

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
            DataColumn col5 = new DataColumn("Ward");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);

            foreach (DataGridViewRow dtgvRow in dgvChiTietMuaHang.Rows)
            {
                DataRow dtrow = dataTable.NewRow();

                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;

                dataTable.Rows.Add(dtrow);
            }

            ExportFile(dataTable, "Danh sach", "Danh sách chi tiết mua hàng");
        }

        private void dgvChiTietMuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index < 0)
            {
                MessageBox.Show("Vui lòng chọn một chi tiết mua hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaCT.Text = dgvChiTietMuaHang.Rows[index].Cells[0].Value.ToString();
            txtMaSP.Text = dgvChiTietMuaHang.Rows[index].Cells[1].Value.ToString();
            txtmaMH.Text = dgvChiTietMuaHang.Rows[index].Cells[2].Value.ToString();
            txtSL.Text = dgvChiTietMuaHang.Rows[index].Cells[3].Value.ToString();
            txtTien.Text = dgvChiTietMuaHang.Rows[index].Cells[4].Value.ToString();
        }
    }
}
