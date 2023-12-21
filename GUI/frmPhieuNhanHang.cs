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
    public partial class frmPhieuNhanHang : Form
    {
        private int index = -1;
        bool isCollapsed = true;
        public frmPhieuNhanHang()
        {
            InitializeComponent();
        }

        private void reload()
        {
            for (int i = 1; i <= 12; i++)
                txtThang.Items.Add(i);
            dgvPhieuNhanHang.RowTemplate.Height = 26;
            try
            {
                string query = "select maMH, nhaCC, ngayMua, FORMAT(CAST(tongTien AS DECIMAL(18, 0)), 'N0') AS tongTien, nv.tenNV, phieuNhanHang.maNV from phieuNhanHang join nhanvien nv on nv.maNV = phieuNhanHang.maNV";
                dgvPhieuNhanHang.DataSource = AccessData.getData(query);

                dgvPhieuNhanHang.Columns[0].HeaderText = "Mã mua hàng";
                dgvPhieuNhanHang.Columns[1].HeaderText = "Nhà cung cấp";
                dgvPhieuNhanHang.Columns[2].HeaderText = "Ngày mua";
                dgvPhieuNhanHang.Columns[3].HeaderText = "Tổng tiền";
                dgvPhieuNhanHang.Columns[4].HeaderText = "Nhân viên mua hàng";
                dgvPhieuNhanHang.Columns[5].HeaderText = "Mã nhân viên";

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
            setLinear.SetLinearGradient(btnHopTimKiem, "#56d8e4", "#9f01ea");
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
            reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn một phiếu mua hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                subUpdateChiTietMuaHang sb = new subUpdateChiTietMuaHang();
                sb.ShowDialog();
                reload();
            }
        }

        private void dgvPhieuNhanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một phiếu mua hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object cellValue = dgvPhieuNhanHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                string ma;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    ma = dgvPhieuNhanHang.Rows[index].Cells[0].Value.ToString();
                    phieuNhanHang.maMH = int.Parse(ma);

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn một phiếu mua hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu mua hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sql = "delete phieuNhanHang where maMH = @maMH";

                    using (SqlConnection conn = SqlConnectionData.connect())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@maMH", phieuNhanHang.maMH);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reload();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnHopTimKiem_Click(object sender, EventArgs e)
        {
            string query = "select maMH, nhaCC, ngayMua, FORMAT(CAST(tongTien AS DECIMAL(18, 0)), 'N0') AS tongTien, phieuNhanHang.maNV from phieuNhanHang where 1 = 1 ";

            if (!string.IsNullOrEmpty(txtMaMH.Text))
                query += $" AND maMH =" + txtMaMH.Text;

            if (!string.IsNullOrEmpty(txtMaNV.Text))
                query += $" AND maNV =" + txtMaNV.Text;

            if (!string.IsNullOrEmpty(txtNgay.Text))
                query += $" AND day(ngayMua) =" + txtNgay.Text;

            if (!string.IsNullOrEmpty(txtThang.Text))
                query += $" AND month(ngayMua) =" + txtThang.Text;

            if (!string.IsNullOrEmpty(txtNam.Text))
                query += $" AND year(ngayMua) =" + txtNam.Text;

            if (!string.IsNullOrEmpty(txtNCC.Text))
                query += $" AND nhaCC like N'%" + txtNCC.Text + "%'";

            dgvPhieuNhanHang.DataSource = AccessData.getData(query);
        }
    }
}
