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
    public partial class frmDoanhThuHD : Form
    {
        public frmDoanhThuHD()
        {
            InitializeComponent();
        }

        private void frmDoanhThuHD_Load(object sender, EventArgs e)
        {
            chart1.Visible= false;
            btnDTTT.Visible=false;
            for (int i = 1; i <= 12; i++)
                cbThang.Items.Add(i);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string query = "SELECT FORMAT(CAST(SUM(tienLamHD) AS DECIMAL(18, 0)), 'N0') AS 'Doanh thu' FROM hopDong WHERE 1 = 1 ";
            string query2 = "SELECT maHD, ngayLamHD, noiLamHD, FORMAT(CAST(tienLamHD AS DECIMAL(18, 0)), 'N0') AS tienLamHD, lyDoThuTien, maNV FROM HopDong WHERE 1 = 1";
            bool hasData = false;

            // Thêm điều kiện theo tháng nếu cbThang.Text không rỗng
            if (!string.IsNullOrEmpty(cbThang.Text))
            {
                query += $" AND MONTH(ngayLamHD) = {cbThang.Text}";
                query2 += $" AND MONTH(ngayLamHD) = {cbThang.Text}";
            }

            // Thêm điều kiện theo năm nếu txtNam.Text không rỗng
            if (!string.IsNullOrEmpty(txtNam.Text))
            {
                query += $" AND YEAR(ngayLamHD) = {txtNam.Text}";
                query2 += $" AND YEAR(ngayLamHD) = {txtNam.Text}";
            }

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
            dataGridView2.Columns[0].HeaderText = "Mã";
            dataGridView2.Columns[1].HeaderText = "Ngày lập";
            dataGridView2.Columns[2].HeaderText = "Nơi lập";
            dataGridView2.Columns[3].HeaderText = "Tiền làm hợp đồng";
            dataGridView2.Columns[4].HeaderText = "Lý do thu";
            dataGridView2.Columns[5].HeaderText = "Mã nhân viên";


            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnDTTT_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            panel5.Visible = false;
            panel7.Visible = false;
            label4.Visible = false;
            dataGridView2.Visible = false;
            string query = "SELECT FORMAT(CAST(SUM(tienLamHD) AS DECIMAL(18, 0)), 'N0') AS 'Doanh thu', MONTH(ngayLamHD) AS 'Tháng' FROM hopDong WHERE 1 = 1 ";
            bool hasData = false;

            if (!string.IsNullOrEmpty(txtNam.Text))
                query += $" AND year(ngayLamHD) = " + txtNam.Text;

            query += " group by month(ngayLamHD)";

            DataTable dt = AccessData.getData(query);

            // Kiểm tra xem có dòng dữ liệu thỏa mãn điều kiện hay không
            if (dt != null && dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                dataGridView1.DataSource = dt;
                hasData = true;
                try
                {
                    if (chart1.Series.Count > 0)
                    {
                        chart1.Series["thống kê"].Points.Clear();
                        chart1.ChartAreas["ChartArea1"].AxisX.Title = "Doanh thu từng tháng trong năm";
                        chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 11);
                        chart1.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", 11);
                        chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                        chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                        chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;


                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            DataGridViewRow row = dataGridView1.Rows[i];
                            
                            string tenBP = row.Cells[0].Value.ToString();
                            int soLuong = Convert.ToInt32(row.Cells[1].Value);
                            MessageBox.Show(tenBP + " " + soLuong);
                            chart1.Series["thống kê"].Points.AddXY(soLuong, tenBP);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message + "\nStack Trace:\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Hiển thị thông báo nếu không có dòng dữ liệu thỏa mãn điều kiện
            if (!hasData)
                MessageBox.Show("Không có dữ liệu nào thỏa mãn điều kiện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
