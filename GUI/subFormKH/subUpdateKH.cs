﻿using DAL;
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
    public partial class subUpdateKH : Form
    {
        public bool isExit = true;
        public event Action DataAdded;
        public subUpdateKH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            if (txtHT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHT.Focus();
                return;
            }

            if (txtDC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDC.Focus();
                return;
            }

            if (txtSoDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            DialogResult result = MessageBox.Show("Bạn đã chắc chắn thông tin vừa nhập chưa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sql = "update KhachHang set tenKH = @tenKH, ngaySinh = @ngaySinh, diaChi = @diaChi,phuong = @phuong, soDT = @soDT where maKH = @maKH";
                using (SqlConnection conn = SqlConnectionData.connect())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maKH", txtMa.Text);
                    cmd.Parameters.AddWithValue("@tenKH", txtHT.Text);
                    cmd.Parameters.AddWithValue("@ngaySinh", dateNS.Value);
                    cmd.Parameters.AddWithValue("@diaChi", txtDC.Text);
                    cmd.Parameters.AddWithValue("@soDT", txtSoDT.Text);
                    cmd.Parameters.AddWithValue("@phuong", cbPhuong.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                    DataAdded?.Invoke();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subUpdateKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet4.diaChi' table. You can move, or remove it, as needed.
            txtMa.Text = khachHang.maKH.ToString();
            txtHT.Text = khachHang.tenKH.ToString();
            dateNS.Value = khachHang.ngaySinh;
            cbPhuong.Text = khachHang.phuong.ToString();
            txtDC.Text = khachHang.diaChi.ToString();
            txtSoDT.Text = khachHang.soDT.ToString();
            txtTinhTrang.Text = khachHang.tinhTrang.ToString();
            txtTinhTrang.ReadOnly = true;
        }

        private void txtTinhTrang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mục này không được phép chỉnh sửa");
        }
    }
}
