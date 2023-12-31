﻿using DAL;
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
    public partial class frmXuPhat : Form
    {
        private int index = -1;
        public frmXuPhat()
        {
            InitializeComponent();
        }

        private void reload()
        {
            dgvXuPhat.RowTemplate.Height = 26;
            txtMaNV.Text = user.id.ToString();
            string query = "select maXP, thoiGian, FORMAT(CAST(TienPhat AS DECIMAL(18, 0)), 'N0') AS TienPhat, maHD1, maHD2, maNV,\n" +
                "CASE\n" +
                "WHEN trangThai = 1 THEN N'Cắt nước'\n" +
                "WHEN trangThai = 2 THEN N'Đang hoạt động'\n" +
                "END AS trangThai\n" +
                "from xuphat";
            dgvXuPhat.DataSource = AccessData.getData(query);
        }

        private void frmXuPhat_Load(object sender, EventArgs e)
        {
            //btnInHoaDon.Enabled = false;
            reload();
            int rowCount = dgvXuPhat.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                DataGridViewRow row = dgvXuPhat.Rows[i];

                if (row.IsNewRow)
                   continue;

                int maXP = int.Parse(row.Cells["maXP"].Value.ToString());
                string trangThai = row.Cells["trangThai"].Value.ToString();

                if(trangThai == "Cắt nước")
                {
                    string updateQuery = "DECLARE @TienPhat MONEY, @tongTienHD1 MONEY, @tongTienHD2 MONEY, @tongTien2HD MONEY;\n" +

                                     // --Lấy tổng tiền từ hóa đơn thứ nhất

                                     "SELECT TOP 1 @tongTienHD1 = hoadon.tongTien FROM xuphat\n" +
                                     "INNER JOIN hoadon ON hoadon.maHD = xuphat.maHD1 WHERE maXP = @maXP;\n" +

                                     // -- Lấy tổng tiền từ hóa đơn thứ hai

                                     "SELECT TOP 1 @tongTienHD2 = hoadon.tongTien FROM xuphat\n" +
                                     "INNER JOIN hoadon ON hoadon.maHD = xuphat.maHD2 WHERE maXP = @maXP;\n" +

                                     // --Tổng tiền của cả hai hóa đơn

                                     "SET @tongTien2HD = @tongTienHD1 + @tongTienHD2;\n" +

                                     // -- Tính tiền phạt và gán vào biến @TienPhat
                                     "SELECT @TienPhat = ABS(DATEDIFF(day, subquery.thoiGianCuoi, GETDATE())) * 0.5 * @tongTien2HD + @tongTien2HD\n" +
                                     "FROM ( SELECT tt.thoiGianCuoi FROM HoaDon hd\n" +
                                     "JOIN xuphat xp ON xp.maHD2 = hd.maHD\n" +
                                     "JOIN tieuthu tt ON tt.maTT = hd.maTT\n" +
                                     "WHERE xp.maXP = @maXP) AS subquery;\n" +

                                     "UPDATE XuPhat SET TienPhat = @TienPhat WHERE maXP = @maXP";

                    using (SqlConnection connection = SqlConnectionData.connect())
                    using (SqlCommand cmd1 = new SqlCommand(updateQuery, connection))
                    {
                        connection.Open();

                        cmd1.Parameters.AddWithValue("@MaXP", maXP);

                        cmd1.ExecuteNonQuery();
                    }
                }
            }
            reload();
        }

        private void dgvXuPhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            index = e.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMaXP.Text = dgvXuPhat.Rows[index].Cells[0].Value.ToString();
           //dateTimePicker1.Value = Convert.ToDateTime(dgvXuPhat.Rows[index].Cells[1].Value);
           txtTienPhat.Text = dgvXuPhat.Rows[index].Cells[2].Value.ToString();
            txtMaHD1.Text = dgvXuPhat.Rows[index].Cells[3].Value.ToString();
            txtMaHD2.Text = dgvXuPhat.Rows[index].Cells[4].Value.ToString();
            lblTrangThai.Text = dgvXuPhat.Rows[index].Cells[6].Value.ToString();
        }

        public class InvoiceData
        {
            public string maXP { get; set; }
            public string maHD1 { get; set; }
            public string maHD2 { get; set; }
            public string maTT { get; set; }
            public string maKH { get; set; }
            public string tenKH { get; set; }
            public string soDT { get; set; }
            public string Duong { get; set; }
            public string Phuong { get; set; }
            public string maDHN { get; set; }
            public string ngayNop { get; set; }
            public string tongTienHD1 { get; set; }
            public string tongTienHD2 { get; set; }
            public string tienPhat { get; set; }
            public string soNgay { get; set; }

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string tinhTrang = dgvXuPhat.Rows[index].Cells[6].Value.ToString();
                if (tinhTrang == "Cắt nước")
                {
                    string query = "UPDATE xuPhat SET maNV = @maNV, trangThai = 2 WHERE maXP = @maXP\n" +
                                   "IF ((select trangThai from xuphat where maXP = @maXP) = 2)\n" +
                                   "BEGIN\n" +
                                        "update xuphat set thoiGian = getdate() where maXP = @maXP\n" +
                                        "update hoadon set tinhTrang = 1 where maHD = @maHD1\n" +
                                        "update hoadon set tinhTrang = 1 where maHD = @maHD2\n" +
                                        "update khachHang set tinhTrang = 1 where maKH = (select tt.maKH from tieuthu tt join hoadon hd on hd.maTT = tt.maTT where hd.maHD = @maHD1)" +
                                   "END";

                    using (SqlConnection conn = SqlConnectionData.connect())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@maXP", txtMaXP.Text);
                        cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("@maHD1", txtMaHD1.Text);
                        cmd.Parameters.AddWithValue("@maHD2", txtMaHD2.Text);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reload();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    foreach (DataGridViewRow selectedRow in dgvXuPhat.SelectedRows)
                    {
                        string maXP_TEMP = selectedRow.Cells["maXP"].Value.ToString();

                        string sql = "DECLARE @TienPhat MONEY, @tongTienHD1 MONEY, @tongTienHD2 MONEY, @tongTien2HD MONEY, @soNgay INT;\n" +
                                     "SELECT TOP 1 @tongTienHD1 = hoadon.tongTien FROM xuphat INNER JOIN hoadon ON hoadon.maHD = xuphat.maHD1 WHERE maXP = " + maXP_TEMP +
                                     "SELECT TOP 1 @tongTienHD2 = hoadon.tongTien FROM xuphat INNER JOIN hoadon ON hoadon.maHD = xuphat.maHD2 WHERE maXP = " + maXP_TEMP +
                                     "SELECT @soNgay = ABS(DATEDIFF(day, subquery.thoiGianCuoi, GETDATE())) FROM ( SELECT tt.thoiGianCuoi FROM HoaDon hd\n" +
                                     "JOIN xuphat xp ON xp.maHD2 = hd.maHD\n" +
                                     "JOIN tieuthu tt ON tt.maTT = hd.maTT\n" +
                                     "WHERE xp.maXP = " + maXP_TEMP + ") AS subquery;\n" +
                                     "select maXP, hd.maTT, tt.maKH, kh.maDHN ,kh.tenKH, FORMAT(CAST(@tongTienHD1 AS DECIMAL(18, 0)), 'N0') AS 'tongTienHD1',@soNgay as 'soNgay', FORMAT(CAST(@tongTienHD2 AS DECIMAL(18, 0)), 'N0') AS 'tongTienHD2',kh.soDT, kh.diaChi, kh.phuong, xuPhat.thoiGian, FORMAT(CAST(TienPhat AS DECIMAL(18, 0)), 'N0') AS 'tienPhat' , maHD1, maHD2 from XuPhat\n" +
                                     "join hoaDon hd on hd.maHD = XuPhat.maHD1\n" +
                                     "join tieuthu tt on hd.maTT = tt.maTT\n" +
                                     "join KhachHang kh on kh.maKH = tt.maKH\n" +
                                     "where XuPhat.trangThai = 2 and maXP = " + maXP_TEMP;

                        string maHD1 = "", maHD2 = "", maKH = "", tenKH = "", soDT = "", duong = "", phuong = "", maDHN = "", maTT = "", tongTienHD1 = "", tongTienHD2 = "", tienPhat = "", soNgay = "", thoiGianNop = "";
                        DateTime thoiGianN;
                        using (SqlConnection connection = SqlConnectionData.connect())
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(sql, connection);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    thoiGianN = Convert.ToDateTime(reader["thoiGian"].ToString());
                                    thoiGianNop = thoiGianN.ToShortDateString();
                                    maKH = reader["maKH"].ToString();
                                    tenKH = reader["tenKH"].ToString();
                                    soDT = reader["soDT"].ToString();
                                    duong = reader["diaChi"].ToString();
                                    phuong = reader["phuong"].ToString();
                                    maDHN = reader["maDHN"].ToString();
                                    maHD1 = reader["maHD1"].ToString();
                                    maHD2 = reader["maHD2"].ToString();
                                    maTT = reader["maTT"].ToString();
                                    tongTienHD1 = reader["tongTienHD1"].ToString();
                                    tongTienHD2 = reader["tongTienHD2"].ToString();
                                    tienPhat = reader["tienPhat"].ToString();
                                    soNgay = reader["soNgay"].ToString();
                                }
                            }
                        }

                        InvoiceData invoiceData = new InvoiceData
                        {
                            maXP = maXP_TEMP,
                            ngayNop = thoiGianNop, 
                            maKH = maKH,
                            tenKH = tenKH,
                            soDT = soDT,
                            Duong = duong,
                            Phuong = phuong,
                            maDHN = maDHN,
                            soNgay = soNgay,
                            tienPhat= tienPhat,
                            tongTienHD1= tongTienHD1,
                            tongTienHD2= tongTienHD2,
                            maTT = maTT,
                            maHD1 = maHD1,
                            maHD2 = maHD2,
                        };

                        frmInHoaDonXuPhat inHoaDonForm = new frmInHoaDonXuPhat(invoiceData);
                        inHoaDonForm.ShowDialog();
                    }
                }
                else if (tinhTrang == "Đang hoạt động")
                {
                    MessageBox.Show("Khách hàng này không trong tình trạng xử phạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string tinhTrang = dgvXuPhat.Rows[index].Cells[6].Value.ToString();
            if (tinhTrang == "Đang hoạt động")
            {
                foreach (DataGridViewRow selectedRow in dgvXuPhat.SelectedRows)
                {
                    string maXP_TEMP = selectedRow.Cells["maXP"].Value.ToString();

                    string sql = "DECLARE @TienPhat MONEY, @tongTienHD1 MONEY, @tongTienHD2 MONEY, @tongTien2HD MONEY, @soNgay INT;\n" +
                                 "SELECT TOP 1 @tongTienHD1 = hoadon.tongTien FROM xuphat INNER JOIN hoadon ON hoadon.maHD = xuphat.maHD1 WHERE maXP = " + maXP_TEMP +
                                 "SELECT TOP 1 @tongTienHD2 = hoadon.tongTien FROM xuphat INNER JOIN hoadon ON hoadon.maHD = xuphat.maHD2 WHERE maXP = " + maXP_TEMP +
                                 "SELECT @soNgay = ABS(DATEDIFF(day, subquery.thoiGian1,subquery.thoiGian2)) FROM ( SELECT hd.thoiGian as thoiGian1, xp.thoiGian as thoiGian2 FROM HoaDon hd\n" +
                                 "JOIN xuphat xp ON xp.maHD2 = hd.maHD\n" +
                                 "JOIN tieuthu tt ON tt.maTT = hd.maTT\n" +
                                 "WHERE xp.maXP = " + maXP_TEMP + ") AS subquery;\n" +
                                 "select maXP, hd.maTT, tt.maKH, kh.maDHN ,kh.tenKH, FORMAT(CAST(@tongTienHD1 AS DECIMAL(18, 0)), 'N0') AS 'tongTienHD1',@soNgay as 'soNgay', FORMAT(CAST(@tongTienHD2 AS DECIMAL(18, 0)), 'N0') AS 'tongTienHD2',kh.soDT, kh.diaChi, kh.phuong, xuPhat.thoiGian, FORMAT(CAST(TienPhat AS DECIMAL(18, 0)), 'N0') AS 'tienPhat' , maHD1, maHD2 from XuPhat\n" +
                                 "join hoaDon hd on hd.maHD = XuPhat.maHD1\n" +
                                 "join tieuthu tt on hd.maTT = tt.maTT\n" +
                                 "join KhachHang kh on kh.maKH = tt.maKH\n" +
                                 "where XuPhat.trangThai = 2 and maXP = " + maXP_TEMP;

                    string maHD1 = "", maHD2 = "", maKH = "", tenKH = "", soDT = "", duong = "", phuong = "", maDHN = "", maTT = "", tongTienHD1 = "", tongTienHD2 = "", tienPhat = "", soNgay = "", thoiGianNop = "";
                    DateTime thoiGianN;
                    using (SqlConnection connection = SqlConnectionData.connect())
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                thoiGianN = Convert.ToDateTime(reader["thoiGian"].ToString());
                                thoiGianNop = thoiGianN.ToShortDateString();
                                maKH = reader["maKH"].ToString();
                                tenKH = reader["tenKH"].ToString();
                                soDT = reader["soDT"].ToString();
                                duong = reader["diaChi"].ToString();
                                phuong = reader["phuong"].ToString();
                                maDHN = reader["maDHN"].ToString();
                                maHD1 = reader["maHD1"].ToString();
                                maHD2 = reader["maHD2"].ToString();
                                maTT = reader["maTT"].ToString();
                                tongTienHD1 = reader["tongTienHD1"].ToString();
                                tongTienHD2 = reader["tongTienHD2"].ToString();
                                tienPhat = reader["tienPhat"].ToString();
                                soNgay = reader["soNgay"].ToString();
                            }
                        }
                    }

                    InvoiceData invoiceData = new InvoiceData
                    {
                        maXP = maXP_TEMP,
                        ngayNop = thoiGianNop,
                        maKH = maKH,
                        tenKH = tenKH,
                        soDT = soDT,
                        Duong = duong,
                        Phuong = phuong,
                        maDHN = maDHN,
                        soNgay = soNgay,
                        tienPhat = tienPhat,
                        tongTienHD1 = tongTienHD1,
                        tongTienHD2 = tongTienHD2,
                        maTT = maTT,
                        maHD1 = maHD1,
                        maHD2 = maHD2,
                    };

                    frmInHoaDonXuPhat inHoaDonForm = new frmInHoaDonXuPhat(invoiceData);
                    inHoaDonForm.ShowDialog();
                }
            }
            else if (tinhTrang == "Cắt nước")
            {
                MessageBox.Show("Khách hàng chưa thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
