using DAL;
using DTO;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
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
    public partial class frmHoaDonMH : Form
    {
        private int index = -1;
        public frmHoaDonMH()
        {
            InitializeComponent();
        }

        private void reload()
        {
            dgvHDMH.RowTemplate.Height = 26;
            try
            {
                string sql = "select maHD_NH, maMH, maNV,\n"+
                             "CASE\n"+
                             "WHEN tinhTrang = 0 THEN N'chưa thanh toán'\n" +
                             "WHEN tinhTrang = 1 THEN N'đã thanh toán'\n" +
                             "END AS tinhTrang\n"+
                             "from hoaDonNhanHang";
                dgvHDMH.DataSource = AccessData.getData(sql);
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmHoaDonMH_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string tinhTrang1 = dgvHDMH.Rows[index].Cells[3].Value.ToString();
                if(tinhTrang1 == "chưa thanh toán")
                {
                    DialogResult result = MessageBox.Show("Kiểm tra thông tin" + "\nMã hóa đơn: " + txtMaHD.Text + "\nMã mua hàng: " + txtMaMH.Text + "\nBạn có chắc chắn muốn thanh toán hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string sql = "update hoaDonNhanHang set tinhTrang = 1, maNV = " + user.id + " where maHD_NH = @maHD_NH\n" +
                                     "declare @Inserted_maPhieu INT\n" +
                                     "insert into phieuNhapKho (maHD_NH) values (@maHD_NH)\n" +
                                     "set @Inserted_maPhieu = SCOPE_IDENTITY()\n" +
                                     "select @Inserted_maPhieu";
                        string sql4 = "select maMH, tinhTrang from hoaDonNhanHang where maHD_NH = @maHD_NH\n";

                        using (SqlConnection conn = SqlConnectionData.connect())
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@maHD_NH", txtMaHD.Text);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string maPhieu = reader[0].ToString();
                                    PhieuNhapKho.maPhieu = int.Parse(maPhieu);
                                }
                            }
                            try
                            {
                                SqlCommand cmd3 = new SqlCommand(sql4, conn);
                                cmd3.Parameters.AddWithValue("@maHD_NH", txtMaHD.Text);
                                using (SqlDataReader reader = cmd3.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        string maMH = reader["maMH"].ToString();
                                        hoaDonNhanHang.maMH = int.Parse(maMH);

                                        string tinhTrang = reader["tinhTrang"].ToString();
                                        hoaDonNhanHang.tinhTrang = int.Parse(tinhTrang);
                                    }
                                }

                                int soLuong = 0;
                                string sql2 = "select soLuong from chiTietMuaHang ct join hoaDonNhanHang hd on hd.maMH = ct.maMH join phieuNhapKho pn on pn.maHD_NH = hd.maHD_NH where pn.maPhieu = " + PhieuNhapKho.maPhieu;

                                SqlCommand cmd1 = new SqlCommand(sql2, conn);
                                try
                                {
                                    using (SqlDataReader reader = cmd1.ExecuteReader())
                                    {
                                        if (reader.Read())
                                            soLuong = int.Parse(reader["soLuong"].ToString());
                                    }
                                    string sql3 = "insert into DongHoNuoc (maPhieu) values(" + PhieuNhapKho.maPhieu + ")";

                                    SqlCommand cmd2 = new SqlCommand(sql3, conn);

                                    for (int i = 0; i < soLuong; i++)
                                        cmd2.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                reload();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi: " + ex.Message + "\nStack Trace:\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else if(tinhTrang1 == "đã thanh toán")
                {
                    MessageBox.Show("Hóa đơn này đã được thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void dgvHDMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMaHD.Text = dgvHDMH.Rows[index].Cells[0].Value.ToString();
            txtMaMH.Text = dgvHDMH.Rows[index].Cells[1].Value.ToString();
            txtmaNV.Text = dgvHDMH.Rows[index].Cells[2].Value.ToString();
            txtTinhTrang.Text = dgvHDMH.Rows[index].Cells[3].Value.ToString();
        }
    }
}
