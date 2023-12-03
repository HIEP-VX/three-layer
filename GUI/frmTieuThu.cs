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

            btnSave.Enabled = false;
            btnThemExcel.Enabled = false;
            grpChiSoNuoc.Enabled = false;
        }

        private void reload()
        {
            try
            {
                /*DateTime currentDate = DateTime.Now;
                int currentMonth = currentDate.Month;
                int currentYear = currentDate.Year;*/
                string query = $"Select maTT, tt.maNV, tt.maKH, chiSoCu, chiSoMoi , luongNuoc ,  ThoiGianDau, ThoiGianCuoi,kh.tenKH, kh.diaChi, kh.phuong, nv.tenNV from tieuthu tt join khachhang kh on kh.maKH = tt.maKH join nhanvien nv on nv.maNV = tt.maNV";
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
                string query = $"Select maTT, tt.maNV, tt.maKH, chiSoCu, chiSoMoi , luongNuoc ,  ThoiGianDau, ThoiGianCuoi,kh.tenKH, kh.diaChi, kh.phuong, nv.tenNV from tieuthu tt join khachhang kh on kh.maKH = tt.maKH join nhanvien nv on nv.maNV = tt.maNV where thoiGianCuoi = '" + thoiGianGhiNuoc.thoiGianCuoi +"'";
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
            for (int i = 1; i <= 12; i++)
                cbThang.Items.Add(i);
            reload();

            btnChiaPhuong.Enabled = false;
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
            index = e.RowIndex;
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
            string query = $"Select maTT, tt.maNV, tt.maKH, chiSoCu, chiSoMoi , luongNuoc ,  ThoiGianDau, CONVERT(VARCHAR, GETDATE(), 103) AS ThoiGianCuoi,kh.tenKH, kh.phuong, kh.diaChi, nv.tenNV from tieuthu tt join khachhang kh on kh.maKH = tt.maKH join nhanvien nv on nv.maNV = tt.maNV WHERE MONTH(ThoiGianCuoi) = {selectedMonth} AND YEAR(ThoiGianCuoi) = YEAR(GETDATE())";
            DataTable dataTable = AccessData.getData(query);
            return dataTable;
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
    }
}