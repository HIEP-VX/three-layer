using DAL;
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
    public partial class frmHopDong : Form
    {
        private int index = -1; // Biến toàn cục để theo dõi dòng được chọn

        public frmHopDong()
        {
            InitializeComponent();
        }
        private void reload()
        {
            try
            {
                string query = "select maHD, ngayLamHD, noiLamHD, FORMAT(CAST(tienLamHD AS DECIMAL(18, 0)), 'N0') AS tienLamHD, lyDoThuTien, maNV from HopDong";
                dgvHopDong.DataSource = AccessData.getData(query);
                
                dgvHopDong.Columns[0].HeaderText = "Mã";
                dgvHopDong.Columns[1].HeaderText = "Ngày lập";
                dgvHopDong.Columns[2].HeaderText = "Nơi lập";
                dgvHopDong.Columns[3].HeaderText = "Tiền làm hợp đồng";
                dgvHopDong.Columns[4].HeaderText = "Lý do thu";
                dgvHopDong.Columns[5].HeaderText = "Mã nhân viên";


                foreach (DataGridViewColumn column in dgvHopDong.Columns)
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

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            this.Refresh();
            // Khi load form , item này sẽ hiển thị kích thước theo kích thước nhỏ nhất đã được cài đặt
            panelTool.Size = panelTool.MinimumSize;
            for (int i = 1; i <= 12; i++)
                cbThang.Items.Add(i);
            reload();
        }

        private void btnHopTimKiem_Click(object sender, EventArgs e)
        {
            string query = $"SELECT maHD, ngayLamHD, noiLamHD, FORMAT(CAST(tienLamHD AS DECIMAL(18, 0)), 'N0') AS tienLamHD, lyDoThuTien, maNV FROM HopDong WHERE 1=1 ";

            if (!string.IsNullOrEmpty(txtMa.Text))
                query += $" AND maHD =" + txtMa.Text;

            if (!string.IsNullOrEmpty(txtNgay.Text))
                query += $" AND day(ngayLamHD) =" + txtNgay.Text;

            if (!string.IsNullOrEmpty(cbThang.Text))
                query += $" AND month(ngayLamHD) =" + cbThang.Text;

            if (!string.IsNullOrEmpty(txtNam.Text))
                query += $" AND year(ngayLamHD) =" + txtNam.Text;

            if (!string.IsNullOrEmpty(txtNL.Text))
                query += $" AND noiLamHD like N'%" + txtNL.Text + "%'";
            
            if (!string.IsNullOrEmpty(txtTienLamHD.Text))
                query += $" AND tienLamHD =" + txtTienLamHD.Text;

            if (!string.IsNullOrEmpty(txtLyDoThuTien.Text))
                query += $" AND lyDoThuTien like N'%" + txtTienLamHD.Text + "%'";

            if (!string.IsNullOrEmpty(txtMaNV.Text))
                query += $" AND maNV =" + txtMaNV.Text;

            dgvHopDong.DataSource = AccessData.getData(query);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timerHopD.Start();
        }

        bool isCollapsed = true;
        private void timerHopD_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timerHopD.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timerHopD.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn một hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hợp đồng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sql = "Delete from HopDong where maHD = '" + txtMa.Text + "'";
                    try
                    {
                        AccessData.execQuery(sql);
                        MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            subUpdateHopD sb = new subUpdateHopD();

            sb.maHD = int.Parse(dgvHopDong.Rows[index].Cells[0].Value.ToString());
            sb.ngayLamHD = Convert.ToDateTime(dgvHopDong.Rows[index].Cells[1].Value);
            sb.noiLamHD = dgvHopDong.Rows[index].Cells[2].Value.ToString();
            sb.tienLamHD = dgvHopDong.Rows[index].Cells[3].Value.ToString();
            sb.lyDoThu = dgvHopDong.Rows[index].Cells[4].Value.ToString();
            sb.maNV = int.Parse(dgvHopDong.Rows[index].Cells[5].Value.ToString());

            sb.ShowDialog();
            reload();
        }

        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMa.Text = dgvHopDong.Rows[index].Cells[0].Value.ToString();
            DateTime ngayHopDong = Convert.ToDateTime(dgvHopDong.Rows[index].Cells[1].Value);

            int ngay = ngayHopDong.Day;
            int thang = ngayHopDong.Month;
            int nam = ngayHopDong.Year;

            txtNgay.Text = ngay.ToString();
            cbThang.Text = thang.ToString();
            txtNam.Text = nam.ToString();

            txtNL.Text = dgvHopDong.Rows[index].Cells[2].Value.ToString();
            txtTienLamHD.Text = dgvHopDong.Rows[index].Cells[3].Value.ToString();
            txtLyDoThuTien.Text = dgvHopDong.Rows[index].Cells[4].Value.ToString();
            txtMaNV.Text = dgvHopDong.Rows[index].Cells[5].Value.ToString();
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã hợp đồng";

            cl1.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Ngày làm hợp đồng";

            cl2.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Nơi làm";
            cl3.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Tiềm làm hợp đồng";

            cl4.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Lý do thu tiền";

            cl5.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Mã nhân viên";

            cl6.ColumnWidth = 13;
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
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");

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

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("ID_TT");
            DataColumn col2 = new DataColumn("ID_KH");
            DataColumn col3 = new DataColumn("Name");
            DataColumn col4 = new DataColumn("Round");
            DataColumn col5 = new DataColumn("Ward");
            DataColumn col6 = new DataColumn("oldIndex");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);

            foreach (DataGridViewRow dtgvRow in dgvHopDong.Rows)
            {
                DataRow dtrow = dataTable.NewRow();

                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
                dtrow[5] = dtgvRow.Cells[5].Value;

                dataTable.Rows.Add(dtrow);
            }

            ExportFile(dataTable, "Danh sach", "Danh sách hợp đồng");
        }
    }
}
