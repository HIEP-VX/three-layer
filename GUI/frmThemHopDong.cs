using DAL;
using DevExpress.Xpo.DB.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmThemHopDong : Form
    {
        public frmThemHopDong()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            txtHT.Text = "";
            txtSODT.Text = "";
            txtDC.Text = "";
            txtLKH.Text = "";
            txtNL.Text = "";
            datetimeNS.Value = DateTime.Now;
            datetimeNL.Value = DateTime.Now;
        }

        private void frmThemHopDong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDHN1.DongHoNuoc' table. You can move, or remove it, as needed.
            this.dongHoNuocTableAdapter.Fill(this.dataDHN1.DongHoNuoc);
            this.refresh();
            try
            {
                string query = "SELECT maDHN, hangDHN, chiSoDau, soCongTo,\n" +
                               "CASE\n"+
                               "WHEN tinhTrang = 0 THEN N'chưa sử dụng'\n"+
                               "WHEN tinhTrang = 1 THEN N'đã sử dụng'\n"+
                               "END AS tinhTrang\n"+
                               "FROM DongHoNuoc\n"+
                               "WHERE tinhTrang = 0;";
                dgvDH_HD.DataSource = AccessData.getData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grpTTDH_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy mục được chọn
            string selectedItem = txtLKH.SelectedItem as string;
            string selectedValue = "";

            // Tách giá trị (trong trường hợp này, "1")
            string[] parts = selectedItem.Split('-');
            if (parts.Length == 2)
                // Sử dụng giá trị (trong trường hợp này, "1")
                selectedValue = parts[0].Trim();
            
            foreach (DataGridViewRow row in dgvDH_HD.Rows)
            {
                bool select1 = Convert.ToBoolean(row.Cells["selectColumn"].Value);
                if (row.Cells[5].Value != null && select1)
                {
                    string query = "insert into HopDong (ngayLamHD, noiLamHD) values ('" + datetimeNL.Value + "',N'" + txtNL.Text + "')\n" +

                                     "DECLARE @hopDongID INT\nSET @hopDongID = SCOPE_IDENTITY();\n" +

                                     "insert into KhachHang(tenKH, ngaySinh, diaChi, soDT, maHD, maLKH, maDHN) values (N'" + txtHT.Text + "','" + datetimeNS.Value + "',N'" + txtDC.Text + "','" + txtSODT.Text + "', @hopDongID," + selectedValue + "," + row.Cells[0].Value + ")"
                                    + "update DongHoNuoc set tinhTrang = 1 where maDHN =  " + row.Cells[0].Value;
             
                    string query2 = "select * from DongHoNuoc where tinhTrang = 0";
                    try
                    {
                        AccessData.execQuery(query);
                        dgvDH_HD.DataSource = AccessData.getData(query2);
                        MessageBox.Show("Thêm hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void grpTTKH_Enter(object sender, EventArgs e)
        {

        }
    }
}
