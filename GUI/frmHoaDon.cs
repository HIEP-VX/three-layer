using DAL;
using DevExpress.Xpo.DB.Helpers;
using DTO;
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
using static DevExpress.Xpo.Helpers.CommandChannelHelper;


namespace GUI
{
    public partial class frmHoaDon : Form
    {
        bool isCollapsed = true;
        bool isCollapsed1 = true;

        private int index = -1;

        public frmHoaDon()
        {
            InitializeComponent();
            setLinear.SetLinearGradient(btnCN, "#56d8e4", "#9f01ea");
        }

        private void reload()
        {
            dgvHoaDon.RowTemplate.Height = 26;
            try
            {
                string sql = "Select maHD, maTT, maNV, luongNuoc, FORMAT(CAST(tienNuoc AS DECIMAL(18, 0)), 'N0') AS tienNuoc, FORMAT(CAST(thue AS DECIMAL(18, 0)), 'N0') AS tienThue, FORMAT(CAST(tongTien AS DECIMAL(18, 0)), 'N0') AS tongTien, thoiGian, \n"+
                             "CASE\n"+
                             "WHEN tinhTrang = 0 THEN N'chưa thanh toán'\n" +
                             "WHEN tinhTrang = 1 THEN N'đã thanh toán'\n" +
                             "END AS tinhTrang\n" +
                             "from hoadon";
                dgvHoaDon.DataSource = AccessData.getData(sql);

                dgvHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
                dgvHoaDon.Columns[1].HeaderText = "Mã tiêu thụ";
                dgvHoaDon.Columns[2].HeaderText = "Mã nhân viên";
                dgvHoaDon.Columns[3].HeaderText = "Lượng nước";
                dgvHoaDon.Columns[4].HeaderText = "Tiền nước";
                dgvHoaDon.Columns[5].HeaderText = "Tiền thuế";
                dgvHoaDon.Columns[6].HeaderText = "Tổng tiền";
                dgvHoaDon.Columns[7].HeaderText = "Thời gian";
                dgvHoaDon.Columns[8].HeaderText = "Tình trạng";

                foreach (DataGridViewColumn column in dgvHoaDon.Columns)
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

        static string[] DataTableColumnToStringArray(DataTable dataTable, string columnName)
        {
            int rows = dataTable.Rows.Count;
            string[] dataArray = new string[rows];

            for (int i = 0; i < rows; i++)
                dataArray[i] = dataTable.Rows[i][columnName].ToString();

            return dataArray;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            txtTinhTrang.SelectedIndex = 0;
            for (int i = 1; i <= 12; i++)
                cbThang.Items.Add(i);
            reload();

            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                DataGridViewRow row = dgvHoaDon.Rows[i];

                if (row.IsNewRow)
                    continue;

                string tinhTrang = row.Cells["tinhTrang"].Value.ToString();
                if (tinhTrang == "chưa thanh toán")
                {
                    string maHoaDon = row.Cells["MaHD"].Value.ToString();
                    string selectQuery = "SELECT COUNT(*) FROM xuPhat WHERE MaHD1 = @MaHoaDon";   // Tạo chuỗi truy vấn SELECT để kiểm tra sự tồn tại

                    using (SqlConnection connection = SqlConnectionData.connect())
                    {
                        using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                        {
                            connection.Open();
                            selectCommand.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                            selectCommand.ExecuteNonQuery();
                            
                            int count = (int)selectCommand.ExecuteScalar(); // Kiểm tra số lượng record có trong bảng xuPhat

                            if (count == 0)
                            {
                                string query = "select makh from khachhang where tinhTrang = 1";
                                DataTable dataTable = AccessData.getData(query);

                                string query1 = "SELECT maHD\r\nFROM hoadon \r\nJOIN tieuthu tt ON tt.maTT = hoadon.maTT \r\nWHERE hoadon.tinhTrang = 0 \r\n      AND tt.maKH = ";
                                string[] maKHArray = DataTableColumnToStringArray(dataTable, "makh");
                                for (int j = 0; j < maKHArray.Length; j++)
                                {
                                    DataTable dt = new DataTable();
                                    string query5 = query1 + maKHArray[j];
                                    dt = AccessData.getData(query5);
                                    if (dt.Rows.Count == 2)
                                    {
                                        string query2 = "INSERT INTO xuPhat (MaHD1, MaHD2) VALUES (@MaHoaDon1, @MaHoaDon2)";
                                        using (SqlCommand cmd1 = new SqlCommand(query2, connection))
                                        {
                                            cmd1.Parameters.AddWithValue("@MaHoaDon1", dt.Rows[0]["MaHD"].ToString());
                                            cmd1.Parameters.AddWithValue("@MaHoaDon2", dt.Rows[1]["MaHD"].ToString());

                                            cmd1.ExecuteNonQuery();

                                            string sql3 = "update khachhang set tinhTrang = 2 where maKH = (select tt.maKH from tieuthu tt join hoadon hd on hd.maTT = tt.maTT where hd.maHD = " + dt.Rows[0]["MaHD"].ToString() + ")";
                                            AccessData.execQuery(sql3);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            reload();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string tinhTrang = dgvHoaDon.Rows[index].Cells[8].Value.ToString();
                if (tinhTrang == "chưa thanh toán")
                {
                    string query = "UPDATE hoadon SET maNV = @maNV, tinhTrang = 1 WHERE maHD = @maHD";
                    using (SqlConnection conn = SqlConnectionData.connect())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);
                        cmd.Parameters.AddWithValue("@maNV", user.id);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reload();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Lỗi: " + ex.Message + "\nStack Trace:\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (tinhTrang == "đã thanh toán")
                {
                    MessageBox.Show("Khách hàng này đã thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void timerCapNhat_Tick(object sender, EventArgs e)
        {
            if (isCollapsed1)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timerCapNhat.Stop();
                    isCollapsed1 = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timerCapNhat.Stop();
                    isCollapsed1 = true;
                }
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMaHD.Text = dgvHoaDon.Rows[index].Cells[0].Value.ToString();
            txtMaTT.Text = dgvHoaDon.Rows[index].Cells[1].Value.ToString();
            txtmaNV.Text = dgvHoaDon.Rows[index].Cells[2].Value.ToString();
            txtLuongNuoc.Text = dgvHoaDon.Rows[index].Cells[3].Value.ToString();
            txtTienNuoc.Text = dgvHoaDon.Rows[index].Cells[4].Value.ToString();
            txtTongthue.Text = dgvHoaDon.Rows[index].Cells[5].Value.ToString();
            txtTongtien.Text = dgvHoaDon.Rows[index].Cells[6].Value.ToString();
            DateTime thoiGian = Convert.ToDateTime(dgvHoaDon.Rows[index].Cells[7].Value);

            int ngay = thoiGian.Day;
            int thang = thoiGian.Month;
            int nam = thoiGian.Year;

            txtNgay.Text = ngay.ToString();
            cbThang.Text = thang.ToString();
            txtNam.Text = nam.ToString();
            txtTinhTrang.Text = dgvHoaDon.Rows[index].Cells[8].Value.ToString();
        }

        public class InvoiceData
        {
            public string maHD { get; set; }
            public string maTT { get; set; }
            public string maKH { get; set; }
            public string thoiGianDau { get; set; }
            public string thoiGianCuoi { get; set; }
            public string thangHD { get; set; }
            public string namHD { get; set; }
            public string tenKH { get; set; }
            public string soDT { get; set; }
            public string Duong { get; set; }
            public string Phuong { get; set; }
            public string chiSoCu { get; set; }
            public string chiSoMoi { get; set; }
            public string luongTieuThu { get; set; }
            public string tienNuoc { get; set; }
            public string tongTien { get; set; }
            public string thue { get; set; }
            public string maDHN { get; set; }
            public string tenLoai { get; set; }
            public string ngaySinh { get; set; }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(index < 0)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string checkTT = dgvHoaDon.Rows[index].Cells[8].Value.ToString();

            if (checkTT == "chưa thanh toán")
            {
                foreach (DataGridViewRow selectedRow in dgvHoaDon.SelectedRows)
                {
                    string maTT_TEMP = selectedRow.Cells["maTT"].Value.ToString();

                    string sql = "select tt.maNV, tt.thoiGianDau, CAST(tt.thoiGianCuoi as DATE) as thoiGianCuoi, kh.maKH, kh.tenKH, month(tt.thoiGianCuoi) as thangHD, year(tt.thoiGianCuoi) as namHD,kh.soDT, kh.diaChi, kh.phuong, tt.chiSoCu, tt.chiSoMoi, tt.luongNuoc, FORMAT(CAST(hd.tienNuoc AS DECIMAL(18, 0)), 'N0') AS tienNuoc, FORMAT(CAST(hd.tongTien AS DECIMAL(18, 0)), 'N0') AS tongTien, FORMAT(CAST(hd.thue AS DECIMAL(18, 0)), 'N0') AS thue, kh.maDHN, lkh.tenLoai, kh.ngaySinh\n" +
                                 "from tieuThu tt join khachhang kh on kh.maKH = tt.maKH join hoadon hd on hd.maTT = tt.maTT join loaikhachhang lkh on lkh.maLKH = kh.maLKH where tt.maTT = " + maTT_TEMP;
                    string maNV = "",thoiGianDau = "", thoiGianCuoi = "", maKH = "", tenKH = "", thangHD = "", namHD = "", soDT = "", duong = "", phuong = "", chiSoCu = "", chiSoMoi = "", luongTieuThu = "";
                    DateTime thoiGianDau1;
                    DateTime thoiGianCuoi1;
                    DateTime ngaySinh1;
                    string tongTien = "", tienNuoc = "", thue = "", maDHN = "", tenLoai = "", ngaySinh = "";
                    using (SqlConnection connection = SqlConnectionData.connect())
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                thoiGianDau1 = Convert.ToDateTime(reader["thoiGianDau"].ToString());
                                thoiGianDau = thoiGianDau1.ToShortDateString();
                                thoiGianCuoi1 = Convert.ToDateTime(reader["thoiGianCuoi"].ToString());
                                thoiGianCuoi = thoiGianCuoi1.ToShortDateString();
                                maKH = reader["maKH"].ToString();
                                tenKH = reader["tenKH"].ToString();
                                thangHD = reader["thangHD"].ToString();
                                namHD = reader["namHD"].ToString();
                                soDT = reader["soDT"].ToString();
                                duong = reader["diaChi"].ToString();
                                phuong = reader["phuong"].ToString();
                                chiSoCu = reader["chiSoCu"].ToString();
                                chiSoMoi = reader["chiSoMoi"].ToString();
                                luongTieuThu = reader["luongNuoc"].ToString();
                                tienNuoc = reader["tienNuoc"].ToString();
                                tongTien = reader["tongTien"].ToString();
                                thue = reader["thue"].ToString();
                                maDHN = reader["maDHN"].ToString();
                                tenLoai = reader["tenLoai"].ToString();
                                ngaySinh1 = Convert.ToDateTime(reader["ngaySinh"].ToString());
                                ngaySinh = ngaySinh1.ToShortDateString();
                                maNV = reader["maNV"].ToString();
                            }
                        }
                    }

                    // Kiểm tra xem có ô dữ liệu nào bị null không
                    if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(luongTieuThu) || string.IsNullOrEmpty(tienNuoc) || string.IsNullOrEmpty(thue) || string.IsNullOrEmpty(tongTien))
                    {
                        MessageBox.Show("Không thể tạo hóa đơn do bị thiếu dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    InvoiceData invoiceData = new InvoiceData
                    {
                        maHD = selectedRow.Cells["maHD"].Value.ToString(),
                        maTT = maTT_TEMP,
                        thoiGianDau = thoiGianDau,
                        thoiGianCuoi = thoiGianCuoi,
                        maKH = maKH,
                        tenKH = tenKH,
                        thangHD = thangHD,
                        namHD = namHD,
                        soDT = soDT,
                        Duong = duong,
                        Phuong = phuong,
                        chiSoCu = chiSoCu,
                        chiSoMoi = chiSoMoi,
                        luongTieuThu = luongTieuThu,
                        tienNuoc = tienNuoc,
                        tongTien = tongTien,
                        thue = thue,
                        maDHN = maDHN,
                        tenLoai = tenLoai,
                        ngaySinh = ngaySinh,
                    };

                    frmInHoaDon inHoaDonForm = new frmInHoaDon(invoiceData);
                    inHoaDonForm.ShowDialog();
                }
            }
            else if(checkTT == "đã thanh toán")
            {
                foreach (DataGridViewRow selectedRow in dgvHoaDon.SelectedRows)
                {
                    string maTT_TEMP = selectedRow.Cells["maTT"].Value.ToString();

                    string sql = "select tt.maNV, tt.thoiGianDau, tt.thoiGianCuoi, kh.maKH, kh.tenKH, month(tt.thoiGianCuoi) as thangHD, year(tt.thoiGianCuoi) as namHD,kh.soDT, kh.diaChi, kh.phuong, tt.chiSoCu, tt.chiSoMoi, tt.luongNuoc, FORMAT(CAST(hd.tienNuoc AS DECIMAL(18, 0)), 'N0') AS tienNuoc, FORMAT(CAST(hd.tongTien AS DECIMAL(18, 0)), 'N0') AS tongTien, FORMAT(CAST(hd.thue AS DECIMAL(18, 0)), 'N0') AS thue, kh.maDHN, lkh.tenLoai, kh.ngaySinh\n" +
                                 "from tieuThu tt join khachhang kh on kh.maKH = tt.maKH join hoadon hd on hd.maTT = tt.maTT join loaikhachhang lkh on lkh.maLKH = kh.maLKH where tt.maTT = " + maTT_TEMP;
                    string thoiGianDau = "", thoiGianCuoi = "", maKH = "", tenKH = "", thangHD = "", namHD = "", duong = "", phuong = "", luongTieuThu = "";
                    DateTime thoiGianDau1;
                    DateTime thoiGianCuoi1;
                    string tongTien = "", tienNuoc = "", thue = "", maDHN = "";
                    using (SqlConnection connection = SqlConnectionData.connect())
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                thoiGianDau1 = Convert.ToDateTime(reader["thoiGianDau"].ToString());
                                thoiGianDau = thoiGianDau1.ToShortDateString();
                                thoiGianCuoi1 = Convert.ToDateTime(reader["thoiGianCuoi"].ToString());
                                thoiGianCuoi = thoiGianCuoi1.ToShortDateString();
                                maKH = reader["maKH"].ToString();
                                tenKH = reader["tenKH"].ToString();
                                thangHD = reader["thangHD"].ToString();
                                namHD = reader["namHD"].ToString();
                                duong = reader["diaChi"].ToString();
                                phuong = reader["phuong"].ToString();
                                luongTieuThu = reader["luongNuoc"].ToString();
                                tienNuoc = reader["tienNuoc"].ToString();
                                tongTien = reader["tongTien"].ToString();
                                thue = reader["thue"].ToString();
                                maDHN = reader["maDHN"].ToString();
                            }
                        }
                    }

                    // Kiểm tra xem có ô dữ liệu nào bị null không
                    if ( string.IsNullOrEmpty(luongTieuThu) || string.IsNullOrEmpty(tienNuoc) || string.IsNullOrEmpty(thue) || string.IsNullOrEmpty(tongTien))
                    {
                        MessageBox.Show("Không thể tạo hóa đơn do bị thiếu dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    InvoiceData invoiceData = new InvoiceData
                    {
                        maHD = selectedRow.Cells["maHD"].Value.ToString(),
                        maTT = maTT_TEMP,
                        thoiGianDau = thoiGianDau,
                        thoiGianCuoi = thoiGianCuoi,
                        maKH = maKH,
                        tenKH = tenKH,
                        thangHD = thangHD,
                        namHD = namHD,
                        Duong = duong,
                        Phuong = phuong,
                        luongTieuThu = luongTieuThu,
                        tienNuoc = tienNuoc,
                        tongTien = tongTien,
                        thue = thue,
                        maDHN = maDHN,
                    };

                    frmInHoaDonLienLuu inHoaDonFormLienLuu = new frmInHoaDonLienLuu(invoiceData);
                    inHoaDonFormLienLuu.ShowDialog();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timerCapNhat.Start();
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = txtTinhTrang.SelectedItem as string;
                string selectedValue = "";

                string[] parts = selectedItem.Split('-');
                if (parts.Length == 2)
                    selectedValue = parts[0].Trim();

                string query = $"Select maHD, maTT, maNV, luongNuoc, FORMAT(CAST(tienNuoc AS DECIMAL(18, 0)), 'N0') AS tienNuoc, FORMAT(CAST(thue AS DECIMAL(18, 0)), 'N0') AS tienThue, FORMAT(CAST(tongTien AS DECIMAL(18, 0)), 'N0') AS tongTien, thoiGian, \n" +
                                 "CASE\n" +
                                 "WHEN tinhTrang = 0 THEN N'chưa thanh toán'\n" +
                                 "WHEN tinhTrang = 1 THEN N'đã thanh toán'\n" +
                                 "END AS tinhTrang\n" +
                                 "from hoadon where 1 = 1 ";

                if (!string.IsNullOrEmpty(txtMaHD.Text))
                    query += $" AND maHD =" + txtMaHD.Text;

                if (!string.IsNullOrEmpty(txtMaTT.Text))
                    query += $" AND maTT =" + txtMaTT.Text;

                if (!string.IsNullOrEmpty(txtmaNV.Text))
                    query += $" AND maNV = " + txtmaNV.Text;

                if (!string.IsNullOrEmpty(txtTienNuoc.Text))
                    query += $" AND tienNuoc = " + txtTienNuoc.Text;

                if (!string.IsNullOrEmpty(txtTongthue.Text))
                    query += $" AND thue = " + txtTongthue.Text;

                if (!string.IsNullOrEmpty(txtTongtien.Text))
                    query += $" AND tongTien =" + txtTongtien.Text;

                if (!string.IsNullOrEmpty(txtNgay.Text))
                    query += $" AND day(thoiGian) = " + txtNgay.Text;

                if (!string.IsNullOrEmpty(cbThang.Text))
                    query += $" AND month(thoiGian) =" + cbThang.Text;

                if (!string.IsNullOrEmpty(txtNam.Text))
                    query += $" AND year(thoiGian) =" + txtNam.Text;
                
                if (!string.IsNullOrEmpty(txtTinhTrang.Text))
                    query += $" AND tinhTrang = " + int.Parse(selectedValue);

                dgvHoaDon.DataSource = AccessData.getData(query);
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\nStack Trace:\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            cl2.Value2 = "Mã tiêu thụ";

            cl2.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Mã nhân viên";
            cl3.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Lượng nước";

            cl4.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Tiền nước";

            cl5.ColumnWidth = 16;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Tiền thuế";

            cl6.ColumnWidth = 16;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Tổng tiền";

            cl7.ColumnWidth = 16.5;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Ngày lập hóa đơn";

            cl8.ColumnWidth = 16.5;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

            cl9.Value2 = "Tình trạng";

            cl9.ColumnWidth = 14.5;

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
            DataColumn col7 = new DataColumn("newIndex");
            DataColumn col8 = new DataColumn("maLKH");
            DataColumn col9 = new DataColumn("maDHN");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);
            dataTable.Columns.Add(col9);

            foreach (DataGridViewRow dtgvRow in dgvHoaDon.Rows)
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

                dataTable.Rows.Add(dtrow);
            }

            ExportFile(dataTable, "Danh sach", "Danh sách hóa đơn");
        }
    }
}
