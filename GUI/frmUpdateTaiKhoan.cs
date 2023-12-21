using DAL;
using DTO;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
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
    public partial class frmUpdateTaiKhoan : Form
    {
        public frmUpdateTaiKhoan()
        {
            InitializeComponent();
            setLinear.SetLinearGradient(btnHopCapNhat, "#56d8e4", "#9f01ea");
        }

        private void frmUpdateTaiKhoan_Load(object sender, EventArgs e)
        {
            this.Refresh();
            string query = "SELECT maNV, tenNV, soDT, chucVu, taiKhoan, matKhau from nhanvien where taiKhoan = N'" + user.account + "' and matKhau = N'" + user.password + "'";

            try
            {
                dgvCapNhat.DataSource = AccessData.getData(query);
                dgvCapNhat.Columns[0].HeaderText = "Mã";
                dgvCapNhat.Columns[1].HeaderText = "Họ và tên";
                dgvCapNhat.Columns[2].HeaderText = "Số điện thoại";
                dgvCapNhat.Columns[3].HeaderText = "Chức vụ";
                dgvCapNhat.Columns[4].HeaderText = "Tài khoản";
                dgvCapNhat.Columns[5].HeaderText = "Mật khẩu";

                foreach (DataGridViewColumn column in dgvCapNhat.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }
        bool isCollapsed = true;

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            timerCapNhat.Start();
        }

        private void timerCapNhat_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelTool.Height += 10;
                if (panelTool.Size == panelTool.MaximumSize)
                {
                    timerCapNhat.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelTool.Height -= 10;
                if (panelTool.Size == panelTool.MinimumSize)
                {
                    timerCapNhat.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void dgvCapNhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtTen.Text = dgvCapNhat.Rows[index].Cells[1].Value.ToString();
            txtSDT.Text = dgvCapNhat.Rows[index].Cells[2].Value.ToString();
            txtTaiKhoan.Text = dgvCapNhat.Rows[index].Cells[4].Value.ToString();
            txtMatKhau.Text = dgvCapNhat.Rows[index].Cells[5].Value.ToString();
        }

        private void btnHopCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập họ tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }

            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }

            if (txtTaiKhoan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
                return;
            }

            if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }

            string query = "update NhanVien set tenNV = @tenNV, soDT = @soDT, taiKhoan = @taiKhoan, matKhau = @matKhau where maNV = " + user.id;
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenNV", txtTen.Text);
                cmd.Parameters.AddWithValue("@soDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@taiKhoan", txtTaiKhoan.Text);
                cmd.Parameters.AddWithValue("@matKhau", txtMatKhau.Text);

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
        }
    }
}
