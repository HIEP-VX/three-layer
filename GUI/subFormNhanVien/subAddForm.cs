using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class subAddForm : Form
    {

        public bool isExit = true;
        public event Action DataAdded;

        public subAddForm()
        {
            InitializeComponent();
            setLinear.SetLinearGradient(btnSubmit, "#56d8e4", "#9f01ea");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txttenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenNV.Focus();
                return;
            }

            if (txtsoDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoDT.Focus();
                return;
            }

            if (txtChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chức vụ cho nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChucVu.Focus();
                return;
            }

            if (txtQuyenHan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập quyền hạn cho nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuyenHan.Focus();
                return;
            }

            string query = @"INSERT INTO NhanVien (tenNV, soDT, chucVu, quyenHan) values (@tenNV, @soDT, @chucVu, @quyenHan)";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenNV", txttenNV.Text);
                cmd.Parameters.AddWithValue("@soDT", txtsoDT.Text);
                cmd.Parameters.AddWithValue("@chucVu", txtChucVu.Text);
                cmd.Parameters.AddWithValue("@quyenHan", txtQuyenHan.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DataAdded?.Invoke();
                this.Close();
            }
        }

        private void subAddForm_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuyenHan_Validating(object sender, CancelEventArgs e)
        {
            if (!txtQuyenHan.Items.Contains(txtQuyenHan.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Vui lòng chọn đúng quyền hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
