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
    public partial class frmPhieuNhanHang : Form
    {
        public frmPhieuNhanHang()
        {
            InitializeComponent();
        }

        private void reload()
        {
            try
            {
                string query = "select maMH, nhaCC, ngayMua, FORMAT(CAST(tongTien AS DECIMAL(18, 0)), 'N0') AS tongTien, maNV from phieuNhanHang";
                dgvPhieuNhanHang.DataSource = AccessData.getData(query);

                dgvPhieuNhanHang.Columns[0].HeaderText = "Mã mua hàng";
                dgvPhieuNhanHang.Columns[1].HeaderText = "Nhà cung cấp";
                dgvPhieuNhanHang.Columns[2].HeaderText = "Ngày mua";
                dgvPhieuNhanHang.Columns[3].HeaderText = "Tổng tiền";
                dgvPhieuNhanHang.Columns[4].HeaderText = "Mã nhân viên";

                foreach (DataGridViewColumn column in dgvPhieuNhanHang.Columns)
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

        private void frmPhieuNhanHang_Load(object sender, EventArgs e)
        {
            this.Refresh();
            this.reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            subAddPhieuNH sb = new subAddPhieuNH();
            sb.ShowDialog();
            sb.DataAdded += () =>
            {
                reload();
            };
        }
    }
}
