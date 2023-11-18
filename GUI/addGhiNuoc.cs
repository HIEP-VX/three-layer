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
    public partial class addGhiNuoc : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public event Action DataAdded;
        public addGhiNuoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }

            if (txtChiSoMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chỉ số mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChiSoMoi.Focus();
                return;
            }

            if (txtLuongNuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lượng nước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLuongNuoc.Focus();
                return;
            }
            string query = "INSERT INTO tieuThu (maKH, chiSoMoi, luongNuoc, ThoiGianDau, ThoiGianCuoi, maNV) values (@maKH,@chiSoMoi, @luongNuoc, @ThoiGianDau, @ThoiGianCuoi, @maNV)";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maKH", txtMaKH.Text);
                cmd.Parameters.AddWithValue("@chiSoMoi", txtChiSoMoi.Text);
                cmd.Parameters.AddWithValue("@luongNuoc", txtLuongNuoc.Text);
                cmd.Parameters.AddWithValue("@ThoiGianDau", dateThoiGianDau.Value);
                cmd.Parameters.AddWithValue("@ThoiGianCuoi", dateThoiGianCuoi.Value);
                cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
                DataAdded?.Invoke();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void addGhiNuoc_Load(object sender, EventArgs e)
        {

        }
    }
}
