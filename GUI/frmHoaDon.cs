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
                string sql = "Select * from hoadon";
                dgvHoaDon.DataSource = AccessData.getData(sql);
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
