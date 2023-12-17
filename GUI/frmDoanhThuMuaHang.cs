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
    public partial class frmDoanhThuMuaHang : Form
    {
        public frmDoanhThuMuaHang()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            if (txtNam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập năm cho mục thống kê.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNam.Focus();
                return;
            }
            // select FORMAT(CAST(sum(tongTien) AS DECIMAL(18, 0)), 'N0') AS 'Doanh thu', month(thoiGian) from hoadon where day(thoiGian) = 12 group by month(thoiGian)
            string query = "select FORMAT(CAST(sum(tongTien) AS DECIMAL(18, 0)), 'N0') AS 'Tổng chi', month(ngayMua) as 'Tháng' from phieuNhanHang WHERE 1 = 1 ";
            string query2 = "select maMH, nhaCC, ngayMua, FORMAT(CAST(tongTien AS DECIMAL(18, 0)), 'N0') AS tongTien, nv.tenNV from phieuNhanHang join nhanvien nv on nv.maNV = phieuNhanHang.maNV where 1 = 1 ";
            bool hasData = false;

            // Thêm điều kiện theo tháng nếu cbThang.Text không rỗng
            if (!string.IsNullOrEmpty(cbThang.Text))
            {
                query += $" AND MONTH(ngayMua) = {cbThang.Text}";
                query2 += $" AND MONTH(ngayMua) = {cbThang.Text}";
            }

            // Thêm điều kiện theo năm nếu txtNam.Text không rỗng
            if (!string.IsNullOrEmpty(txtNam.Text))
            {
                query += $" AND YEAR(ngayMua) = {txtNam.Text}";
                query2 += $" AND YEAR(ngayMua) = {txtNam.Text}";
            }

            query += " group by month(ngayMua)";

            // Lấy dữ liệu cho biểu đồ
            DataTable dt = AccessData.getData(query);

            // Kiểm tra và hiển thị dữ liệu trên DataGridView
            if (dt != null && dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                dataGridView1.DataSource = dt;
                hasData = true;
            }

            // Hiển thị thông báo nếu không có dữ liệu thỏa mãn điều kiện
            if (!hasData)
            {
                MessageBox.Show("Không có dữ liệu nào thỏa mãn điều kiện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Lấy và hiển thị dữ liệu cho query2
            DataTable dt2 = AccessData.getData(query2);
            dataGridView2.RowTemplate.Height = 26;

            dataGridView2.DataSource = dt2;
            dataGridView2.Columns[0].HeaderText = "Mã mua hàng";
            dataGridView2.Columns[1].HeaderText = "Nhà cung cấp";
            dataGridView2.Columns[2].HeaderText = "Ngày mua";
            dataGridView2.Columns[3].HeaderText = "Tổng tiền";
            dataGridView2.Columns[4].HeaderText = "Nhân viên mua hàng";


            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void frmDoanhThuMuaHang_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
                cbThang.Items.Add(i);
        }
    }
}
