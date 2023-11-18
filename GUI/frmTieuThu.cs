using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using xls =  Microsoft.Office.Interop.Excel;
using System.IO;
using OfficeOpenXml;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmTieuThu : Form
    {
        public frmTieuThu()
        {
            InitializeComponent();
        }

        private void frmTieuThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet11.TieuThu' table. You can move, or remove it, as needed.
            this.tieuThuTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet11.TieuThu);
            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i);
            }

            // hiển thị thông tin những khách hàng tiêu thụ trong tháng hiện tại
            DateTime currentDate = DateTime.Now;
            int currentMonth = currentDate.Month;
            int currentYear = currentDate.Year;

            string query = $"SELECT maTT, maKH, chiSoMoi, luongNuoc,ThoiGianDau, CONVERT(VARCHAR, GETDATE(), 103) AS ThoiGianCuoi, maNV FROM TieuThu WHERE MONTH(ThoiGianCuoi) = {currentMonth} AND YEAR(ThoiGianCuoi) = {currentYear}";
            dgvTieuThu.DataSource = AccessData.getData(query);
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMonth = Convert.ToInt32(cbThang.SelectedItem);
            dgvTieuThu.DataSource = LoadDataByMonth(selectedMonth);
        }

        private DataTable LoadDataByMonth(int selectedMonth)
        {
            // Thực hiện truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu dựa trên tháng
            string query = $"SELECT * FROM TieuThu WHERE MONTH(ThoiGianCuoi) = {selectedMonth} AND YEAR(ThoiGianCuoi) = YEAR(GETDATE())";
            // Thực hiện truy vấn và trả về dữ liệu dưới dạng DataTable
            DataTable dataTable = AccessData.getData(query);
            return dataTable;
        }
    }
}
