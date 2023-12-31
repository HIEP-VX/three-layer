﻿using DAL;
using DTO;
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
    public partial class frmKhachHang : Form
    {
        bool isCollapsed = true;
        bool isSelected = false;
        private int index = -1; // Biến toàn cục để theo dõi dòng được chọn
        public frmKhachHang()
        {
            InitializeComponent();
            setLinear.SetLinearGradient(btnHopTimKiem, "#56d8e4", "#9f01ea");
        }

        private void reload()
        {
            dgvKH.RowTemplate.Height = 26;
            try
            {
                string query = "select maKH, tenKH, ngaySinh, diaChi, phuong, soDT, maHD, maLKH, maDHN,\n"+
                               "CASE\n"+
                               "WHEN tinhTrang = 1 THEN N'đang hoạt động'\n" +
                               "WHEN tinhTrang = 2 THEN N'cắt nước'\n" +
                               "WHEN tinhTrang = 3 THEN N'dừng hoạt động'\n" +
                               "END AS 'Tình trạng'\n" +
                               "from KhachHang";
                dgvKH.DataSource = AccessData.getData(query);

                dgvKH.Columns[0].HeaderText = "Mã";
                dgvKH.Columns[1].HeaderText = "Họ và tên";
                dgvKH.Columns[2].HeaderText = "Ngày sinh";
                dgvKH.Columns[3].HeaderText = "Đường";
                dgvKH.Columns[4].HeaderText = "Phường";
                dgvKH.Columns[5].HeaderText = "Số điện thoại";
                dgvKH.Columns[6].HeaderText = "Mã hợp đồng";
                dgvKH.Columns[7].HeaderText = "Mã LKH";
                dgvKH.Columns[8].HeaderText = "Mã đồng hồ";
                dgvKH.Columns[9].HeaderText = "Tình trạng";

                foreach (DataGridViewColumn column in dgvKH.Columns)
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

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            this.Refresh();
            panelTool.Size = panelTool.MinimumSize;
            dateTimePicker1.Visible = false;
            for (int i = 1; i <= 12; i++)
                cbThang.Items.Add(i);
            reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(index == -1)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                subUpdateKH sb = new subUpdateKH();
                sb.ShowDialog();

                sb.DataAdded += () =>
                {
                    reload();
                };
                reload();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timerTimKiem.Start();
        }

        private void btnHopTimKiem_Click(object sender, EventArgs e)
        {
            string selectedValue = "";
            if (isSelected == true)
            {
                string selectedItem = txtTinhTrang.SelectedItem as string;

                string[] parts = selectedItem.Split('-');
                if (parts.Length == 2)
                    selectedValue = parts[0].Trim();
            }
            string query = "select maKH, tenKH, ngaySinh, diaChi, phuong, soDT, maHD, maLKH, maDHN,\n" +
                               "CASE\n" +
                               "WHEN tinhTrang = 1 THEN N'đang hoạt động'\n" +
                               "WHEN tinhTrang = 2 THEN N'cắt nước'\n" +
                               "WHEN tinhTrang = 3 THEN N'dừng hoạt động'\n" +
                               "END AS tinhTrang\n" +
                               "from KhachHang where 1 = 1 ";

            if (!string.IsNullOrEmpty(txtMa.Text))
                query += $" AND maKH =" + txtMa.Text;

            if (!string.IsNullOrEmpty(txttenKH.Text))
                query += $" AND tenKH like N'%" + txttenKH.Text + "%'";

            if (!string.IsNullOrEmpty(txtNgay.Text))
                query += $" AND day(ngaySinh) =" + txtNgay.Text;

            if (!string.IsNullOrEmpty(cbThang.Text))
                query += $" AND month(ngaySinh) =" + cbThang.Text;

            if (!string.IsNullOrEmpty(txtNam.Text))
                query += $" AND year(ngaySinh) =" + txtNam.Text;

            if (!string.IsNullOrEmpty(cbPhuong.Text))
                query += $" AND phuong like N'%" + cbPhuong.Text + "%'";

            if (!string.IsNullOrEmpty(txtDC.Text))
                query += $" AND diaChi like N'%" + txtDC.Text + "%'";

            if (!string.IsNullOrEmpty(txtSDT.Text))
                query += $" AND soDT = '" + txtSDT.Text + "'";

            if (!string.IsNullOrEmpty(txtmaHD.Text))
                query += $" AND maHD =" + txtmaHD.Text;

            if (!string.IsNullOrEmpty(txtLKH.Text))
                query += $" AND maLKH =" + txtLKH.Text;

            if (!string.IsNullOrEmpty(txtDH.Text))
                query += $" AND maDHN =" + txtDH.Text;

            if (!string.IsNullOrEmpty(txtTinhTrang.Text))
                query += $" AND tinhTrang = " + int.Parse(selectedValue);

            dgvKH.DataSource = AccessData.getData(query);
        }

        private void timerTimKiem_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timerTimKiem.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timerTimKiem.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object cellValue = dgvKH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    txtMa.Text = dgvKH.Rows[index].Cells[0].Value.ToString();
                    khachHang.maKH = int.Parse(txtMa.Text);

                    txttenKH.Text = dgvKH.Rows[index].Cells[1].Value.ToString();
                    khachHang.tenKH = txttenKH.Text;

                    DateTime ngaySinh = Convert.ToDateTime(dgvKH.Rows[index].Cells[2].Value);

                    int ngay = ngaySinh.Day;
                    int thang = ngaySinh.Month;
                    int nam = ngaySinh.Year;

                    txtNgay.Text = ngay.ToString();
                    cbThang.Text = thang.ToString();
                    txtNam.Text = nam.ToString();

                    dateTimePicker1.Value = Convert.ToDateTime(dgvKH.Rows[index].Cells[2].Value);
                    khachHang.ngaySinh = dateTimePicker1.Value;

                    txtDC.Text = dgvKH.Rows[index].Cells[3].Value.ToString();
                    khachHang.diaChi = txtDC.Text;

                    cbPhuong.Text = dgvKH.Rows[index].Cells[4].Value.ToString();
                    khachHang.phuong = cbPhuong.Text;

                    txtSDT.Text = dgvKH.Rows[index].Cells[5].Value.ToString();
                    khachHang.soDT = txtSDT.Text;

                    txtmaHD.Text = dgvKH.Rows[index].Cells[6].Value.ToString();
                    khachHang.maHD = int.Parse(txtmaHD.Text);

                    txtLKH.Text = dgvKH.Rows[index].Cells[7].Value.ToString();
                    khachHang.maLKH = int.Parse(txtLKH.Text);

                    txtDH.Text = dgvKH.Rows[index].Cells[8].Value.ToString();
                    khachHang.maDHN = int.Parse(txtDH.Text);

                    txtTinhTrang.Text = dgvKH.Rows[index].Cells[9].Value.ToString();
                    khachHang.tinhTrang = txtTinhTrang.Text;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "J1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã khách hàng";

            cl1.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Họ tên";

            cl2.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Ngày sinh";
            cl3.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Phường";

            cl4.ColumnWidth = 18;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Đường";

            cl5.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Số điện thoại";

            cl6.ColumnWidth = 13;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Mã hợp đồng";

            cl7.ColumnWidth = 13.5;
            
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Mã loại khách hàng";

            cl8.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

            cl9.Value2 = "Mã đồng hồ";

            cl9.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range c20 = oSheet.get_Range("J3", "J3");

            c20.Value2 = "Tình trạng";

            c20.ColumnWidth = 14.5;
            
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "J3");

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
            DataColumn col6 = new DataColumn("oldIndex");
            DataColumn col7 = new DataColumn("newIndex");
            DataColumn col8 = new DataColumn("maLKH");
            DataColumn col9 = new DataColumn("maDHN");
            DataColumn col10 = new DataColumn("tinhTrang");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);
            dataTable.Columns.Add(col9);
            dataTable.Columns.Add(col10);

            foreach (DataGridViewRow dtgvRow in dgvKH.Rows)
            {
                DataRow dtrow = dataTable.NewRow();

                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
                dtrow[5] = dtgvRow.Cells[5].Value;
                dtrow[6] = dtgvRow.Cells[6].Value;
                dtrow[7] = dtgvRow.Cells[7].Value;
                dtrow[8] = dtgvRow.Cells[8].Value;
                dtrow[9] = dtgvRow.Cells[9].Value;

                dataTable.Rows.Add(dtrow);
            }

            ExportFile(dataTable, "Danh sach", "Danh sách khách hàng");
        }

        private void txtTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            isSelected = true;
        }
    }
}