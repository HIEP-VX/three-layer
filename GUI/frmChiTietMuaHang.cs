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
    public partial class frmChiTietMuaHang : Form
    {
        public frmChiTietMuaHang()
        {
            InitializeComponent();
        }

        private void reload()
        {
            try
            {
                string query = "select maChiTiet, maSP, maMH, soLuong, FORMAT(CAST(tien AS DECIMAL(18, 0)), 'N0') AS tienFormatted from chiTietMuaHang";
                dgvChiTietMuaHang.DataSource = AccessData.getData(query);

                dgvChiTietMuaHang.Columns[0].HeaderText = "Mã chi tiết";
                dgvChiTietMuaHang.Columns[1].HeaderText = "Mã sản phẩm";
                dgvChiTietMuaHang.Columns[2].HeaderText = "Mã mua hàng";
                dgvChiTietMuaHang.Columns[3].HeaderText = "Số lượng";
                dgvChiTietMuaHang.Columns[4].HeaderText = "Tiền";

                foreach (DataGridViewColumn column in dgvChiTietMuaHang.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmChiTietMuaHang_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
