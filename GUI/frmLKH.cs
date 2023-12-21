using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLKH : Form
    {
        bool isCollapsed = true;
        private int index = -1;
        public frmLKH()
        {
            InitializeComponent();
            setLinear.SetLinearGradient(btnHopTimKiem, "#56d8e4", "#9f01ea");
            setLinear.SetLinearGradient(btnHopCapNhat, "#56d8e4", "#9f01ea");
        }

        private void reload()
        {
            dgvLKH.RowTemplate.Height = 26;
            try
            {
                string query = "select maLKH, tenLoai, FORMAT(CAST(giaBac1 AS DECIMAL(18, 0)), 'N0') AS gb1 , FORMAT(CAST(giaBac2 AS DECIMAL(18, 0)), 'N0') AS gb2, FORMAT(CAST(giaBac3 AS DECIMAL(18, 0)), 'N0') AS gb3, FORMAT(CAST(giaBac4 AS DECIMAL(18, 0)), 'N0') AS gb4 from loaiKhachHang";
                dgvLKH.DataSource = AccessData.getData(query);

                dgvLKH.Columns[0].HeaderText = "Mã";
                dgvLKH.Columns[1].HeaderText = "Loại";
                dgvLKH.Columns[2].HeaderText = "Giá bậc 1";
                dgvLKH.Columns[3].HeaderText = "Giá bậc 2";
                dgvLKH.Columns[4].HeaderText = "Giá bậc 3";
                dgvLKH.Columns[5].HeaderText = "Giá bậc 4";


                foreach (DataGridViewColumn column in dgvLKH.Columns)
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

        private void frmLKH_Load(object sender, EventArgs e)
        {
            this.Refresh();
            panelTool.Size = panelTool.MinimumSize;
            btnHopTimKiem.Visible = false;
            btnHopCapNhat.Visible = false;
            reload();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            subAddLKH sb = new subAddLKH();
            sb.ShowDialog();

            sb.DataAdded += () =>
            {
                reload();
            };
            reload();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sql = "Delete from loaiKhachHang where maLKH = '" + txtMa.Text + "'";
                    try
                    {
                        AccessData.execQuery(sql);
                        MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            timerLKH.Start();
            btnHopCapNhat.Visible = true;
            btnHopTimKiem.Visible = false;
        }
        
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            timerLKH.Start();
            btnHopTimKiem.Visible = true;
            btnHopCapNhat.Visible = false;
        }

        private void btnHopTimKiem_Click(object sender, EventArgs e)
        {
            string query = $"select maLKH, tenLoai, FORMAT(CAST(giaBac1 AS DECIMAL(18, 0)), 'N0') AS gb1 , FORMAT(CAST(giaBac2 AS DECIMAL(18, 0)), 'N0') AS gb2, FORMAT(CAST(giaBac3 AS DECIMAL(18, 0)), 'N0') AS gb3, FORMAT(CAST(giaBac4 AS DECIMAL(18, 0)), 'N0') AS gb4 from loaiKhachHang WHERE 1=1 ";

            if (!string.IsNullOrEmpty(txtMa.Text))
                query += $" AND maLKH =" + txtMa.Text;

            if (!string.IsNullOrEmpty(txtLoai.Text))
                query += $" AND tenLoai like N'%" + txtLoai.Text + "%'";

            if (!string.IsNullOrEmpty(txtGiaBac1.Text))
                query += $" AND giaBac1 = " + txtGiaBac1.Text;

            if (!string.IsNullOrEmpty(txtGiaBac2.Text))
                query += $" AND giaBac2 =" + txtGiaBac2.Text;

            if (!string.IsNullOrEmpty(txtGiaBac3.Text))
                query += $" AND giaBac3 = " + txtGiaBac3.Text;

            if (!string.IsNullOrEmpty(txtGiaBac4.Text))
                query += $" AND giaBac4 =" + txtGiaBac4.Text;

            dgvLKH.DataSource = AccessData.getData(query);
        }
       
        private void timerLKH_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timerLKH.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timerLKH.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void dgvLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMa.Text = dgvLKH.Rows[index].Cells[0].Value.ToString();
            txtLoai.Text = dgvLKH.Rows[index].Cells[1].Value.ToString();
            txtGiaBac1.Text = dgvLKH.Rows[index].Cells[2].Value.ToString();
            txtGiaBac2.Text = dgvLKH.Rows[index].Cells[3].Value.ToString();
            txtGiaBac3.Text = dgvLKH.Rows[index].Cells[4].Value.ToString();
            txtGiaBac4.Text = dgvLKH.Rows[index].Cells[5].Value.ToString();
        }

        private void btnHopCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            if (txtLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoai.Focus();
                return;
            }

            if (txtGiaBac1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bậc 1.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaBac1.Focus();
                return;
            }

            if (txtGiaBac2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bậc 2.\nNếu không có giá bậc 2, hãy nhập 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaBac2.Focus();
                return;
            }

            if (txtGiaBac3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bậc 3.\nNếu không có giá bậc 3, hãy nhập 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaBac3.Focus();
                return;
            }

            if (txtGiaBac4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập giá bậc 4.\nNếu không có giá bậc 4, hãy nhập '0'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaBac4.Focus();
                return;
            }

            DialogResult result = MessageBox.Show("Bạn đã chắc chắn thông tin vừa nhập chưa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = "update loaiKhachHang set tenLoai = @tenLoai, giaBac1 = @giaBac1, giaBac2 = @giaBac2, giaBac3 = @giaBac3, giaBac4 = @giaBac4 where maLKH = @maLKH";
                using (SqlConnection conn = SqlConnectionData.connect())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maLKH", txtMa.Text);
                    cmd.Parameters.AddWithValue("@tenLoai", txtLoai.Text);
                    cmd.Parameters.AddWithValue("@giaBac1", txtGiaBac1.Text);
                    cmd.Parameters.AddWithValue("@giaBac2", txtGiaBac2.Text);
                    cmd.Parameters.AddWithValue("@giaBac3", txtGiaBac3.Text);
                    cmd.Parameters.AddWithValue("@giaBac4", txtGiaBac4.Text);

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
}
