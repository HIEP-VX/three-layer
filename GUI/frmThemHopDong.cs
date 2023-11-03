using DAL;
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

namespace GUI
{
    public partial class frmThemHopDong : Form
    {
        public frmThemHopDong()
        {
            InitializeComponent();
        }

        private void frmThemHopDong_Load(object sender, EventArgs e)
        {
           // TODO: This line of code loads data into the 'dataDHN1.DongHoNuoc' table. You can move, or remove it, as needed.
            this.dongHoNuocTableAdapter.Fill(this.dataDHN1.DongHoNuoc);

        }

        private void grpTTDH_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDH_HD.Rows)
            {
                if (row.Cells[5].Value != null && (bool)row.Cells[5].Value)
                {
                    string maDHN = row.Cells["maDHN"].Value.ToString();
                    string hangDHN = row.Cells["hangDHN"].Value.ToString();
                    string chiSoDau = row.Cells["chiSoDau"].Value.ToString();
                    string soCongTo = row.Cells["soCongTo"].Value.ToString();
                    string tinhTrang = row.Cells["tinhTrang"].Value.ToString();

                    string query = @"insert into DongHoNuoc ( hangDHN, chiSoDau, soCongTo, tinhTrang) values (@hangDHN, @chiSoDau,@soCongTo , @tinhTrang)" +
                                     @"DECLARE @DongHoID int\nSET @DongHoID = SCOPE_IDENTITY();"
                                    + @"insert into HopDong (ngayLamHD, noiLamHD) values ('" + datatimeNL.Value + "',N'" + txtNL.Text + "')\n" +
                                     @"DECLARE @hopDongID INT\nSET @hopDongID = SCOPE_IDENTITY();\n" +
                                     @"insert into KhachHang(tenKH, ngaySinh, diaChi, soDT, maHD, maLKH, maDHN) values (N'" + txtHT.Text +"','" + datetimeNS.Value + "',N'" + txtDC.Text + "','" + txtSODT.Text + "', @hopDongID," + txtLKH.Text + ",@DongHoID)";
                    try
                    {
                        AccessData.execQuery(query);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
