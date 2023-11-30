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
                string sql = "Select maHD, maTT, maNV, luongNuoc, FORMAT(CAST(tienNuoc AS DECIMAL(18, 0)), 'N0') AS tienNuoc, FORMAT(CAST(thue AS DECIMAL(18, 0)), 'N0') AS tienThue, FORMAT(CAST(tongTien AS DECIMAL(18, 0)), 'N0') AS tongTien, thoiGian, \n"+
                             "CASE\n"+
                             "WHEN tinhTrang = 0 THEN N'chưa thanh toán'\n" +
                             "WHEN tinhTrang = 1 THEN N'đã thanh toán'\n" +
                             "END AS tinhTrang\n" +
                             "from hoadon";
                dgvHoaDon.DataSource = AccessData.getData(sql);

                /*dgvHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
                dgvHoaDon.Columns[1].HeaderText = "Mã tiêu thụ";
                dgvHoaDon.Columns[2].HeaderText = "Mã nhân viên";
                dgvHoaDon.Columns[3].HeaderText = "Lượng nước";
                dgvHoaDon.Columns[4].HeaderText = "Tiền nước";
                dgvHoaDon.Columns[5].HeaderText = "Tiền thuế";
                dgvHoaDon.Columns[6].HeaderText = "Tổng tiền";
                dgvHoaDon.Columns[7].HeaderText = "Thời gian";
                dgvHoaDon.Columns[8].HeaderText = "Tình trạng";*/

                dgvHoaDon.Columns[0].Width = 30;
                dgvHoaDon.Columns[1].Width = 30;
                dgvHoaDon.Columns[2].Width = 30;
                dgvHoaDon.Columns[3].Width = 30;
                dgvHoaDon.Columns[4].Width = 60;
                dgvHoaDon.Columns[5].Width = 60;
                dgvHoaDon.Columns[6].Width = 60;
                dgvHoaDon.Columns[7].Width = 60;
                dgvHoaDon.Columns[8].Width = 80;

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

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            reload();
            grpXoa.Visible = false;
            grpCapNhat.Visible = false;

            DateTime firstDayOfCurrentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime firstDayOfPreviousMonth = firstDayOfCurrentMonth.AddMonths(-1);
            /*
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                try
                {
                    
                }catch(Exception ex)
                {

                }
                if (row.Cells["tinhTrang"].Value != null && row.Cells["thoiGian"].Value != null && row.Cells["maTT"].Value != null)
                {
                    // Kiểm tra nếu tình trạng là "Chưa thanh toán" và thời gian là trước tháng hiện tại 1 tháng
                    if (int.TryParse(row.Cells["tinhTrang"].Value.ToString(), out int tinhTrang) &&
                        DateTime.TryParse(row.Cells["thoiGian"].Value.ToString(), out DateTime thoiGian) &&
                        row.Cells["maTT"].Value != null)
                    {
                        string maTT1 = row.Cells["maTT"].Value.ToString();

                        if (tinhTrang == 0 && thoiGian < firstDayOfCurrentMonth && thoiGian >= firstDayOfPreviousMonth)
                        {
                            // Thêm lệnh chèn vào bảng xử phạt ở đây
                            string maHoaDon = row.Cells["MaHD"].Value.ToString();
                            //string maTT2 = row.Cells["MaTT"].Value.ToString();

                            // Tạo chuỗi truy vấn INSERT với tham số
                            string insertQuery = "INSERT INTO xuPhat (MaHD1) VALUES (@MaHoaDon)\n";

                            // Thực hiện kết nối đến cơ sở dữ liệu và thực hiện truy vấn INSERT
                            using (SqlConnection connection = SqlConnectionData.connect())
                            using (SqlCommand command = new SqlCommand(insertQuery, connection))
                            {
                                connection.Open();
                                try
                                {
                                    // Thêm tham số vào truy vấn
                                    //command.Parameters.AddWithValue("@maTT", maTT2);
                                    command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi rồi");
                    }
                }
            }*/
            /* foreach (DataGridViewRow row in dgvHoaDon.Rows)
             {
                 string tinhTrang = row.Cells["tinhTrang"].Value.ToString();
                 MessageBox.Show(tinhTrang.ToString());
                 break;
             }*/
            /*
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                // Lấy giá trị từ cột "Tình trạng" và "Thời gian"
                string tinhTrang = row.Cells["tinhTrang"].Value.ToString();
                DateTime thoiGian = Convert.ToDateTime(row.Cells["thoiGian"].Value);
                string maTT1 = row.Cells["maTT"].Value.ToString();

                // Kiểm tra nếu tình trạng là "Chưa thanh toán" và thời gian là trước tháng hiện tại 1 tháng
                if (tinhTrang == "chưa thanh toán" && thoiGian < firstDayOfCurrentMonth && thoiGian >= firstDayOfPreviousMonth)
                {
                    // Thêm lệnh chèn vào bảng xử phạt ở đây
                    string maHoaDon = row.Cells["MaHD"].Value.ToString();
                    string maTT2 = row.Cells["MaTT"].Value.ToString();

                    // Tạo chuỗi truy vấn INSERT với tham số
                    string insertQuery = "INSERT INTO xuPhat (MaHD1) VALUES (@MaHoaDon)\n";
                                         //"select maHD from hoaDon where maTT = " + maTT1;

                    // Thực hiện kết nối đến cơ sở dữ liệu và thực hiện truy vấn INSERT
                    using (SqlConnection connection = SqlConnectionData.connect())
                        
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        connection.Open();
                        try
                        {
                            // Thêm tham số vào truy vấn
                            //command.Parameters.AddWithValue("@maTT", maTT2);
                            command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                            command.ExecuteNonQuery();
                            //string query = "UPDATE xuphat SET maHD2 = hd.maHD\n"+
                                     //      "FROM xuphat JOIN hoadon hd ON xuphat.maTT = hd.maTT WHERE MONTH(hd.thoiGian) = MONTH(GETDATE()) AND DAY(hd.thoiGian) = DAY(GETDATE()) AND YEAR(hd.thoiGian) = YEAR(GETDATE());";
                           // AccessData.execQuery(query);
                            MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }*/


            // chỉnh lại trigger trong sql , cập nhật tháng

            /*foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                // bỏ qua dòng mới
                if (row.IsNewRow)
                    continue;

                string tinhTrang = row.Cells["tinhTrang"].Value.ToString();
                DateTime thoiGian = Convert.ToDateTime(row.Cells["thoiGian"].Value);
                //string maTT1 = row.Cells["maTT"].Value.ToString();
                string maHoaDon1 = row.Cells["MaHD"].Value.ToString();
                // Kiểm tra nếu tình trạng là "Chưa thanh toán" và thời gian là trước tháng hiện tại 1 tháng
                if (tinhTrang == "chưa thanh toán" && thoiGian < firstDayOfCurrentMonth && thoiGian >= firstDayOfPreviousMonth)
                {
                    // Thêm lệnh kiểm tra trước khi chèn vào bảng xử phạt ở đây
                    string maHoaDon = row.Cells["MaHD"].Value.ToString();
                    MessageBox.Show(maHoaDon);
                    //string maTT2 = row.Cells["MaTT"].Value.ToString();

                    // Tạo chuỗi truy vấn SELECT để kiểm tra sự tồn tại
                    string selectQuery = "SELECT COUNT(*) FROM xuPhat WHERE MaHD1 = @MaHoaDon";

                    // Thực hiện kết nối đến cơ sở dữ liệu và thực hiện truy vấn SELECT
                    using (SqlConnection connection = SqlConnectionData.connect())
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        connection.Open();

                        selectCommand.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                        // Kiểm tra số lượng record có trong bảng xuPhat
                        int count = (int)selectCommand.ExecuteScalar();

                        // Nếu có ít nhất một record
                        if (count > 0)
                        {
                            MessageBox.Show("Đã có record với mã hóa đơn này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Nếu không có record, thực hiện lệnh INSERT
                            string insertQuery = "INSERT INTO xuPhat (MaHD1) VALUES (@MaHoaDon)\n"+
                                                 "UPDATE xuPhat SET MaHD2 = @MaHoaDon1 from xuphat\n"+
                                                 "join hoadon hd on hd.maHD = xuphat.maHD1\n"+
                                                 "WHERE MONTH(hd.thoiGian) = MONTH(GETDATE()) AND DAY(hd.thoiGian) = DAY(GETDATE()) AND YEAR(hd.thoiGian) = YEAR(GETDATE());";


                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                try
                                {
                                    // Thêm tham số vào truy vấn INSERT
                                    insertCommand.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                                    insertCommand.Parameters.AddWithValue("@MaHoaDon", maHoaDon1);
                                    insertCommand.ExecuteNonQuery();

                                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lỗi: " + ex.Message + "\nStack Trace:\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }*/

            int rowCount = dgvHoaDon.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                DataGridViewRow row = dgvHoaDon.Rows[i];

                if (row.IsNewRow)
                    continue;

                string tinhTrang = row.Cells["tinhTrang"].Value.ToString();
                DateTime thoiGian = Convert.ToDateTime(row.Cells["thoiGian"].Value);
                string maHoaDon1 = row.Cells["MaHD"].Value.ToString();
                MessageBox.Show(maHoaDon1.ToString());

                if (tinhTrang == "chưa thanh toán" && thoiGian < firstDayOfCurrentMonth && thoiGian >= firstDayOfPreviousMonth)
                {
                    // Thêm lệnh kiểm tra trước khi chèn vào bảng xử phạt ở đây
                    string maHoaDon = row.Cells["MaHD"].Value.ToString();
                    MessageBox.Show(maHoaDon);

                    // Tạo chuỗi truy vấn SELECT để kiểm tra sự tồn tại
                    string selectQuery = "SELECT COUNT(*) FROM xuPhat WHERE MaHD1 = @MaHoaDon";

                    // Thực hiện kết nối đến cơ sở dữ liệu và thực hiện truy vấn SELECT
                    using (SqlConnection connection = SqlConnectionData.connect())
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        connection.Open();

                        selectCommand.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                        // Kiểm tra số lượng record có trong bảng xuPhat
                        int count = (int)selectCommand.ExecuteScalar();

                        // Nếu có ít nhất một record
                        if (count > 0)
                        {
                            MessageBox.Show("Đã có record với mã hóa đơn này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Nếu không có record, thực hiện lệnh INSERT
                            string insertQuery = "INSERT INTO xuPhat (MaHD1) VALUES (@MaHoaDon)\n" +
                                                 "UPDATE xuPhat SET MaHD2 = @MaHoaDon1 from xuphat\n" +
                                                 "join hoadon hd on hd.maHD = xuphat.maHD1\n" +
                                                 "WHERE MONTH(hd.thoiGian) = MONTH(GETDATE()) AND DAY(hd.thoiGian) = DAY(GETDATE()) AND YEAR(hd.thoiGian) = YEAR(GETDATE());";

                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                try
                                {
                                    // Thêm tham số vào truy vấn INSERT
                                    insertCommand.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                                    insertCommand.Parameters.AddWithValue("@MaHoaDon1", maHoaDon1);
                                    insertCommand.ExecuteNonQuery();

                                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
