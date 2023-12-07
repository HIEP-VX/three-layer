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
        }

        private void reload()
        {
            try
            {
                txtmaNV.Text = user.id.ToString();
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
            reload();
            grpXoa.Visible = false;
            grpCapNhat.Visible = false;

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            timerXoa.Start();
            timerCapNhat.Stop();
            grpXoa.Visible = true;
            grpCapNhat.Visible = false;
        }

        private void timerXoa_Tick(object sender, EventArgs e)
        {
           
            if (isCollapsed)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timerXoa.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timerXoa.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnHopTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sql = "Delete from hoadon where maHD = '" + txtMa.Text + "'";
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
            reload();
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            if (txtmaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaNV.Focus();
                return;
            }
            if (txtMaHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHD.Focus();
                return;
            }

            if (txtTinhtrang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tình trạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTinhtrang.Focus();
                return;
            }

            string selectedItem = txtTinhtrang.SelectedItem as string;   // Tách giá trị của ô trạng thái
            string selectedValue = "";
            string[] parts = selectedItem.Split('-');                    // Tách giá trị (trong trường hợp này, "1")
            if (parts.Length == 2)
                selectedValue = parts[0].Trim();                         // Sử dụng giá trị (trong trường hợp này, "1")

            string query = "UPDATE hoadon SET maNV = @maNV, tinhTrang = @tinhTrang WHERE maHD = @maHD";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);
                cmd.Parameters.AddWithValue("@maNV", txtmaNV.Text);
                cmd.Parameters.AddWithValue("@tinhTrang", selectedValue);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            reload();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            grpCapNhat.Visible = true;
            if (panelTool.Height == 168)
            {
                grpXoa.Visible = false;
            }

            if(panelTool.Height == 31)
            {
                grpXoa.Visible = false;
                timerCapNhat.Start();
            }
            timerCapNhat.Start();
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
            txtMa.Text = dgvHoaDon.Rows[index].Cells[0].Value.ToString();
            txtMaHD.Text = dgvHoaDon.Rows[index].Cells[0].Value.ToString();
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
            foreach (DataGridViewRow selectedRow in dgvHoaDon.SelectedRows)
            {
                string maTT_TEMP = selectedRow.Cells["maTT"].Value.ToString();

                string sql = "select tt.thoiGianDau, tt.thoiGianCuoi, kh.maKH, kh.tenKH, month(tt.thoiGianCuoi) as thangHD, year(tt.thoiGianCuoi) as namHD,kh.soDT, kh.diaChi, kh.phuong, tt.chiSoCu, tt.chiSoMoi, tt.luongNuoc, FORMAT(CAST(hd.tienNuoc AS DECIMAL(18, 0)), 'N0') AS tienNuoc, FORMAT(CAST(hd.tongTien AS DECIMAL(18, 0)), 'N0') AS tongTien, FORMAT(CAST(hd.thue AS DECIMAL(18, 0)), 'N0') AS thue, kh.maDHN, lkh.tenLoai, kh.ngaySinh\n" +
                             "from tieuThu tt join khachhang kh on kh.maKH = tt.maKH join hoadon hd on hd.maTT = tt.maTT join loaikhachhang lkh on lkh.maLKH = kh.maLKH where tt.maTT = " + maTT_TEMP;
                string thoiGianDau = "",thoiGianCuoi = "", maKH = "", tenKH = "", thangHD = "", namHD = "", soDT = "", duong = "", phuong = "", chiSoCu = "", chiSoMoi = "", luongTieuThu = "";
                
                string tongTien = "", tienNuoc = "", thue = "", maDHN = "", tenLoai = "", ngaySinh = "";
                using (SqlConnection connection = SqlConnectionData.connect())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            thoiGianDau = reader["thoiGianDau"].ToString();
                            thoiGianCuoi = reader["thoiGianCuoi"].ToString();
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
                            ngaySinh = reader["ngaySinh"].ToString();
                        }
                    }
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
                inHoaDonForm.Show();
            }
        }
    }
}
