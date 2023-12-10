using DAL;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
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
    public partial class frmNhanVien : Form
    {
        private int index = -1;
        bool isCollapsed = true;
        bool isCollapsed1 = true;

        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void reload()
        {
            dgvNhanVien.RowTemplate.Height = 26;
            try
            {
                string query = "select * from NhanVien";
                dgvNhanVien.DataSource = AccessData.getData(query);

                dgvNhanVien.Columns[0].HeaderText = "Mã";
                dgvNhanVien.Columns[1].HeaderText = "Họ và tên";
                dgvNhanVien.Columns[2].HeaderText = "Số điện thoại";
                dgvNhanVien.Columns[3].HeaderText = "Chức vụ";
                dgvNhanVien.Columns[4].HeaderText = "Tài khoản";
                dgvNhanVien.Columns[5].HeaderText = "Mật khẩu";
                dgvNhanVien.Columns[6].HeaderText = "Quyền hạn";

                foreach (DataGridViewColumn column in dgvNhanVien.Columns)
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

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            reload();
            this.Refresh();
            panelTool.Size = panelTool.MinimumSize;
            SetLinearGradient(btnHopTimKiem, "#56d8e4", "#9f01ea");
            SetLinearGradient(btnHopCapNhat, "#56d8e4", "#9f01ea");
            btnHopTimKiem.Visible = false;
            btnHopCapNhat.Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            subAddForm sb = new subAddForm();
            sb.ShowDialog();

            sb.DataAdded += () =>
            {
                reload();
            };

            reload();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sql = "Delete from NhanVien where MANV = '" + txtMa.Text + "'";
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

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            timerCapNhat.Start();
            btnHopCapNhat.Visible = true;
            btnHopTimKiem.Visible = false;
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            timKiemTimer.Start();
            btnHopTimKiem.Visible = true;
            btnHopCapNhat.Visible = false;
        }

        private void btnHopCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            if (txttenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenNV.Focus();
                return;
            }

            if (txtsoDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoDT.Focus();
                return;
            }

            if (txtChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chức vụ của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChucVu.Focus();
                return;
            }
            if (txtQuyenHan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập quyền hạn của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuyenHan.Focus();
                return;
            }
            if (txtTaiKhoan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tài khoản cho nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cho nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }

            string sql = "update NhanVien set TENNV = N'" + txttenNV.Text + "',soDT = '" + txtsoDT.Text + "', chucVu = N'"+txtChucVu.Text + "', taiKhoan = N'"+ txtTaiKhoan.Text + "', matKhau = N'"+ txtMatKhau.Text + "', quyenHan = N'" + txtQuyenHan.Text +"' where maNV = " + txtMa.Text;
            try
            {
                AccessData.execQuery(sql);
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHopTimKiem_Click(object sender, EventArgs e)
        {
            string query = $"select * from NhanVien where 1=1 ";

            if (!string.IsNullOrEmpty(txtMa.Text))
                query += $" AND maNV =" + txtMa.Text;
            
            if (!string.IsNullOrEmpty(txttenNV.Text))
                query += $" AND tenNV like N'%" + txttenNV.Text + "%'";
            
            if (!string.IsNullOrEmpty(txtsoDT.Text))
                query += $" AND soDT ='" + txtsoDT.Text + "'";
            
            if (!string.IsNullOrEmpty(txtChucVu.Text))
                query += $" AND chucVu like N'%" + txtChucVu.Text + "%'";

            if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
                query += $" AND taiKhoan like N'%" + txtTaiKhoan.Text + "%'";

            if (!string.IsNullOrEmpty(txtMatKhau.Text))
                query += $" AND matKhau like N'%" + txtMatKhau.Text + "%'";
            
            if (!string.IsNullOrEmpty(txtQuyenHan.Text))
                query += $" AND quyenHan like N'%" + txtQuyenHan.Text + "%'";
            
            dgvNhanVien.DataSource = AccessData.getData(query);
        }

        private void timKiemTimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timKiemTimer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timKiemTimer.Stop();
                    isCollapsed = true;
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

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMa.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
            txttenNV.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
            txtsoDT.Text = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
            txtChucVu.Text = dgvNhanVien.Rows[index].Cells[3].Value.ToString();
            txtTaiKhoan.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
            txtMatKhau.Text = dgvNhanVien.Rows[index].Cells[5].Value.ToString();
            txtQuyenHan.Text = dgvNhanVien.Rows[index].Cells[6].Value.ToString();
        }

        private void txtQuyenHan_Validating(object sender, CancelEventArgs e)
        {
            if (!txtQuyenHan.Items.Contains(txtQuyenHan.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Vui lòng chọn đúng quyền hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã nhân viên";

            cl1.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Họ tên";

            cl2.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Số điện thoại";
            cl3.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Chức vụ";

            cl4.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Tài khoản";

            cl5.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Mật khẩu";

            cl6.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Quyền hạn";

            cl7.ColumnWidth = 14;
            
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

            rowHead.Font.Bold = true;

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            range.Value2 = arr;

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

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);

            foreach (DataGridViewRow dtgvRow in dgvNhanVien.Rows)
            {
                DataRow dtrow = dataTable.NewRow();

                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
                dtrow[5] = dtgvRow.Cells[5].Value;
                dtrow[6] = dtgvRow.Cells[6].Value;

                dataTable.Rows.Add(dtrow);
            }

            ExportFile(dataTable, "Danh sach", "Danh sách nhân viên");
        }
    }
}
