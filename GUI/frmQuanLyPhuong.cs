using DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmQuanLyPhuong : Form
    {
        private int index = -1;
        string maNhanVien = "";
        string tenNhanVien = "";
        public frmQuanLyPhuong()
        {
            InitializeComponent();
        }

        private void reload()
        {
            dgvPhuong.RowTemplate.Height = 26;
            try
            {
                string query = $"select phuong from diaChi ";
                dgvPhuong.DataSource = AccessData.getData(query);

                dgvPhuong.Columns[0].HeaderText = "Tên phường";

                foreach (DataGridViewColumn column in dgvPhuong.Columns)
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

        private void frmQuanLyPhuong_Load(object sender, EventArgs e)
        {
            reload();
        }
    } 
}