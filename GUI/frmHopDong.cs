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
        private void reload()
        {
            try
            {
                string query = "select * from HopDong";
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
            subDelHopD sb = new subDelHopD();
            sb.ShowDialog();

            sb.DataAdded += () =>
            {
                reload();
            };
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            subUpdateHopD sb = new subUpdateHopD();
            sb.ShowDialog();

            sb.DataAdded += () =>
            {
                reload();
            };
        }

    }
}
