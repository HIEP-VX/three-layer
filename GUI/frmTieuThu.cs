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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet.TieuThu' table. You can move, or remove it, as needed.
            this.tieuThuTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet.TieuThu);
            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i);
            }

        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMonth = Convert.ToInt32(cbThang.SelectedItem);
            dataGridView1.DataSource = LoadDataByMonth(selectedMonth);
        }

        private DataTable LoadDataByMonth(int selectedMonth)
        {
            // Thực hiện truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu dựa trên tháng
            // Ví dụ:
            string query = $"SELECT * FROM TieuThu WHERE MONTH(ThoiGian) = {selectedMonth} AND YEAR(ThoiGian) = YEAR(GETDATE())";
            // Thực hiện truy vấn và trả về dữ liệu dưới dạng DataTable
            DataTable dataTable = AccessData.getData(query);
            return dataTable;
        }

    }
}
