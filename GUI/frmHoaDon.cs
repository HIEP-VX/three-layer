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

namespace GUI
{
    public partial class frmHoaDon : Form
    {
        bool isCollapsed = true;
        bool isCollapsed1 = true;

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

        /*
         * select tongtien from hoadon

ngày hiện tại - ngày cuối cùng hóa đơn 2 ) * 0.5 * tongtien 2 hd + tongtien 2hd

select * from hoadon

DECLARE @tongTienHD1 MONEY, @tongTienHD2 MONEY, @tongHaiHD MONEY;

-- Sử dụng TOP 1 để chỉ lấy một giá trị
SET @tongTienHD1 = (
    SELECT TOP 1 hoadon.tongTien
    FROM xuphat
    INNER JOIN hoadon ON hoadon.maHD = xuphat.maHD1 
    WHERE maXP = 7
);

SET @tongTienHD2 = (
    SELECT TOP 1 hoadon.tongTien
    FROM xuphat
    INNER JOIN hoadon ON hoadon.maHD = xuphat.maHD2 
    WHERE maXP = 7
);

SET @tongHaiHD = @tongTienHD1 + @tongTienHD2

SELECT @tongTienHD1 AS TongTienHD1;
SELECT @tongTienHD2 AS TongTienHD2;
SELECT @tongHaiHD AS TongHaiHD;



select hoadon.tongTien, hoadon.maHD from xuphat, hoadon
where hoadon.maHD = XuPhat.maHD2
and maXP = 7


select hd.thoiGianCuoi from hoadon 
join xuphat xp on xp.maHD2 = HoaDon.maHD
where maXP = 7


select * from xuphat

(ABS(DATEDIFF(day, ngayCuoiCungHoaDon2, GETDATE())) * 0.5 * tongTien2HD) + tongTien2HD AS TienPhat

declare @tienPhat INT;


        */
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

            DateTime firstDayOfCurrentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime firstDayOfPreviousMonth = firstDayOfCurrentMonth.AddMonths(-1);

            int rowCount = dgvHoaDon.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                DataGridViewRow row = dgvHoaDon.Rows[i];

                if (row.IsNewRow)
                    continue;

                string tinhTrang = row.Cells["tinhTrang"].Value.ToString();
                DateTime thoiGian = Convert.ToDateTime(row.Cells["thoiGian"].Value);
                DateTime ngayHienTaiThangTruoc = DateTime.Now.AddMonths(-1);

                if (tinhTrang == "chưa thanh toán" && thoiGian < firstDayOfCurrentMonth && thoiGian >= firstDayOfPreviousMonth && thoiGian.Day == ngayHienTaiThangTruoc.Day)
                {
                    string maHoaDon = row.Cells["MaHD"].Value.ToString();
                    string sql3 = "update khachhang set tinhTrang = 2 where maKH = select tt.maKH from tieuthu tt join hoadon hd on hd.maTT = tt.maTT where hd.maHD = " + maHoaDon;
                    AccessData.execQuery(sql3);
                    // Tạo chuỗi truy vấn SELECT để kiểm tra sự tồn tại
                    string selectQuery = "SELECT COUNT(*) FROM xuPhat WHERE MaHD1 = @MaHoaDon";

                    using (SqlConnection connection = SqlConnectionData.connect())
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        connection.Open();

                        selectCommand.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                        selectCommand.ExecuteNonQuery();

                        // Kiểm tra số lượng record có trong bảng xuPhat
                        int count = (int)selectCommand.ExecuteScalar();

                        if (count < 0)
                        {
                            string query = "select makh from khachhang where tinhTrang = 1";
                            DataTable dataTable = AccessData.getData(query);

                            using (SqlConnection conn = SqlConnectionData.connect())
                            {
                                conn.Open();
                                string query1 = "SELECT maHD\r\nFROM hoadon \r\nJOIN tieuthu tt ON tt.maTT = hoadon.maTT \r\nWHERE hoadon.tinhTrang = 0 \r\n      AND tt.maKH = ";
                                string[] maKHArray = DataTableColumnToStringArray(dataTable, "MaKH");
                                for (int j = 0; j < maKHArray.Length; j++)
                                {
                                    

                                    DataTable dt = new DataTable();
                                    string query5 = query1 + maKHArray[j];
                                    dt = AccessData.getData(query5);
                                    if (dt.Rows.Count == 2)
                                    {
                                        using (SqlCommand cmd = new SqlCommand(query5, conn))
                                        {
                                            // Xóa parameters cũ nếu có
                                            cmd.Parameters.Clear();

                                            string query2 = "INSERT INTO xuPhat (MaHD1, MaHD2) VALUES (@MaHoaDon1, @MaHoaDon2)";
                                            using (SqlCommand cmd1 = new SqlCommand(query2, conn))
                                            {
                                                cmd1.Parameters.AddWithValue("@MaHoaDon1", dt.Rows[0]["MaHD"].ToString());
                                                cmd1.Parameters.AddWithValue("@MaHoaDon2", dt.Rows[1]["MaHD"].ToString());

                                                cmd1.ExecuteNonQuery();

                                                string query3 = "select tongTien from hoadon where maHD = " + dt.Rows[0]["MaHD"].ToString();
                                                string query4 = "select tongTien from hoadon where maHD = " + dt.Rows[1]["MaHD"].ToString();
                                            }
                                        }
                                    }
                                }
                                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
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

            // Tách giá trị của ô trạng thái
            string selectedItem = txtTinhtrang.SelectedItem as string;
            string selectedValue = "";

            // Tách giá trị (trong trường hợp này, "1")
            string[] parts = selectedItem.Split('-');
            if (parts.Length == 2)
                // Sử dụng giá trị (trong trường hợp này, "1")
                selectedValue = parts[0].Trim();

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
            int index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMa.Text = dgvHoaDon.Rows[index].Cells[0].Value.ToString();
            txtMaHD.Text = dgvHoaDon.Rows[index].Cells[0].Value.ToString();

        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
