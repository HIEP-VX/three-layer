using DAL;
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
    public partial class frmHopDong : Form
    {
        private int index = -1; // Biến toàn cục để theo dõi dòng được chọn

        public frmHopDong()
        {
            InitializeComponent();
        }
        private void reload()
        {
            try
            {
                string query = "select maHD, ngayLamHD, noiLamHD, FORMAT(CAST(tienLamHD AS DECIMAL(18, 0)), 'N0') AS tienLamHD, lyDoThuTien, maNV from HopDong";
                dgvHopDong.DataSource = AccessData.getData(query);
                
                dgvHopDong.Columns[0].HeaderText = "Mã";
                dgvHopDong.Columns[1].HeaderText = "Ngày lập";
                dgvHopDong.Columns[2].HeaderText = "Nơi lập";
                dgvHopDong.Columns[3].HeaderText = "Tiền làm hợp đồng";
                dgvHopDong.Columns[4].HeaderText = "Lý do thu";
                dgvHopDong.Columns[5].HeaderText = "Mã nhân viên";


                foreach (DataGridViewColumn column in dgvHopDong.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            this.Refresh();
            // Khi load form , item này sẽ hiển thị kích thước theo kích thước nhỏ nhất đã được cài đặt
            panelTool.Size = panelTool.MinimumSize;
            reload();
        }

        private void btnHopTimKiem_Click(object sender, EventArgs e)
        {
            string query = "";
            if (txtMa.Text != "")
            {
                query = @"SELECT DISTINCT * FROM HopDong WHERE mahd = " + txtMa.Text;
            }
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Đã tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvHopDong.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy hợp đồng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timerHopD.Start();
        }

        bool isCollapsed = true;
        private void timerHopD_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timerHopD.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timerHopD.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn một hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hợp đồng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sql = "Delete from HopDong where maHD = '" + txtMa.Text + "'";
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
            }
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            subUpdateHopD sb = new subUpdateHopD();

            sb.maHD = int.Parse(dgvHopDong.Rows[index].Cells[0].Value.ToString());
            sb.ngayLamHD = Convert.ToDateTime(dgvHopDong.Rows[index].Cells[1].Value);
            sb.noiLamHD = dgvHopDong.Rows[index].Cells[2].Value.ToString();
            sb.tienLamHD = dgvHopDong.Rows[index].Cells[3].Value.ToString();
            sb.lyDoThu = dgvHopDong.Rows[index].Cells[4].Value.ToString();
            sb.maNV = int.Parse(dgvHopDong.Rows[index].Cells[5].Value.ToString());

            sb.ShowDialog();
        }

        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMa.Text = dgvHopDong.Rows[index].Cells[0].Value.ToString();
            dateTimeNL.Value = Convert.ToDateTime(dgvHopDong.Rows[index].Cells[1].Value);
            txtNL.Text = dgvHopDong.Rows[index].Cells[2].Value.ToString();
            txtTienLamHD.Text = dgvHopDong.Rows[index].Cells[3].Value.ToString();
            txtLyDoThuTien.Text = dgvHopDong.Rows[index].Cells[4].Value.ToString();
            txtMaNV.Text = dgvHopDong.Rows[index].Cells[5].Value.ToString();
        }
    }
}
