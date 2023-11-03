﻿using DAL;
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
        public frmHopDong()
        {
            InitializeComponent();
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCungCapNuocSachDataSet2.HopDong' table. You can move, or remove it, as needed.
            this.hopDongTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet2.HopDong);
            this.Refresh();
            panelTool.Size = panelTool.MinimumSize;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            subAddHopD sb = new subAddHopD();
            // thu chạy showDialog
            sb.Show();

            sb.Logout += addForm_Logout;

            sb.DataAdded += () =>
            {
                try
                {
                    string query = "select * from HopDong";
                    dgvHopDong.DataSource = AccessData.getData(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }
        private void addForm_Logout(object sender, EventArgs e)
        {
            (sender as subAddHopD).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as subAddHopD).Close();
            this.Show();
        }

        private void delForm_Logout(object sender, EventArgs e)
        {
            (sender as subDelHopD).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as subDelHopD).Close();
            this.Show();
        }
        private void updForm_Logout(object sender, EventArgs e)
        {
            (sender as subUpdateHopD).isExit = false;    // trường hợp này k tắt chương trình mà chỉ đăng xuất ra thôi
            (sender as subUpdateHopD).Close();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            subDelHopD sb = new subDelHopD();
            sb.Show();

            sb.Logout += delForm_Logout;

            sb.DataAdded += () =>
            {
                try
                {
                    string query = "select * from HopDong";
                    dgvHopDong.DataSource = AccessData.getData(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            subUpdateHopD sb = new subUpdateHopD();
            sb.Show();

            sb.Logout += updForm_Logout;

            sb.DataAdded += () =>
            {
                try
                {
                    string query = "select * from HopDong";
                    dgvHopDong.DataSource = AccessData.getData(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
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
                MessageBox.Show("Không tìm thấy nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}