using DAL;
using DevExpress.Xpo.DB.Helpers;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            cbPhuong.Text = "";
            txtLKH.Text = "";
            txtNL.Text = "";
            datetimeNS.Value = DateTime.Now;
            datetimeNL.Value = DateTime.Now;
        }

        private void frmThemHopDong_Load(object sender, EventArgs e)
        {
            this.diaChiTableAdapter.Fill(this.quanLyCungCapNuocSachDataSet4.diaChi);
            this.refresh();
            txtMaNV.Text = user.id.ToString();
            try
            {
                string query = "SELECT maDHN, chiSoDau,\n" +
                               "CASE\n"+
                               "WHEN tinhTrang = 0 THEN N'chưa sử dụng'\n"+
                               "WHEN tinhTrang = 1 THEN N'đã sử dụng'\n"+
                               "END AS tinhTrang\n"+
                               "FROM DongHoNuoc\n"+
                               "WHERE tinhTrang = 0;";
                dgvDH_HD.DataSource = AccessData.getData(query);

                dgvDH_HD.Columns[1].HeaderText = "Mã";
                dgvDH_HD.Columns[2].HeaderText = "Chỉ số đầu";
                dgvDH_HD.Columns[3].HeaderText = "Tình trạng";

                dgvDH_HD.Columns[1].ReadOnly = true;
                dgvDH_HD.Columns[2].ReadOnly = true;
                dgvDH_HD.Columns[3].ReadOnly = true;

                foreach (DataGridViewColumn column in dgvDH_HD.Columns)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string query;

            if(txtHT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập họ tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHT.Focus();
                return;
            }

            if (txtLKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLKH.Focus();
                return;
            }

            if (cbPhuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập phường của khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbPhuong.Focus();
                return;
            }

            if (txtDC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDC.Focus();
                return;
            }

            if (txtNL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nơi lập hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNL.Focus();
                return;
            }

            if (txtTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải cần nhập tiền làm hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTien.Focus();
                return;
            }

            if (txtLyDo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập lý do!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLyDo.Focus();
                return;
            }

            if (txtSODT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại của khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSODT.Focus();
                return;
            }

            bool atLeastOneChecked = false;


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
                if (row.Cells[0].Value != null && select1)
                {
                    query = "insert into HopDong (ngayLamHD, noiLamHD, tienLamHD, lyDoThuTien, maNV) values ('" + datetimeNL.Value + "',N'" + txtNL.Text + "'," + txtTien.Text + ",N'" + txtLyDo.Text + "'," + txtMaNV.Text + ")\n" +

                                     "DECLARE @hopDongID INT\nSET @hopDongID = SCOPE_IDENTITY();\n" +

                                     "insert into KhachHang(tenKH, ngaySinh,phuong, diaChi, soDT, maHD, maLKH, maDHN) values (N'" + txtHT.Text + "','" + datetimeNS.Value + "',N'" + cbPhuong.Text + "',N'" + txtDC.Text + "','" +  txtSODT.Text + "', @hopDongID," + selectedValue + "," + row.Cells[1].Value + ")"
                                    + "update DongHoNuoc set tinhTrang = 1 where maDHN =  " + row.Cells[1].Value;
             
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
                        MessageBox.Show("Lỗi: " + ex.Message + "\nStack Trace:\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    atLeastOneChecked= true;
                    break;
                }
            }

            if (atLeastOneChecked)
                MessageBox.Show("Thêm hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Hãy chọn một đồng hồ cho khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
