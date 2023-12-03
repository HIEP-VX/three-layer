using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class showDetailTieuThu : Form
    {
        public int maTT { get; set; }
        public int maNV { get; set; }
        public int maKH { get; set; }
        public int chiSoCu { get; set; }
        public int chiSoMoi { get; set; }
        public int luongNuoc { get; set; }
        public DateTime thoiGianDau { get; set; }
        public DateTime thoiGianCuoi { get; set; }
        public string hoTenKH { get; set; }
        public string diaChi { get; set; }
        public string phuong { get; set; }
        public string hoTenNV { get; set; }


        public showDetailTieuThu()
        {
            InitializeComponent();
        }

        private void showDetailTieuThu_Load(object sender, EventArgs e)
        {
            txtMaTT.Text = maTT.ToString();
            txtMaNV.Text = maNV.ToString();
            txtMaKH.Text = maKH.ToString();
            txtChiSoCu.Text = chiSoCu.ToString();
            txtChiSoMoi.Text = chiSoMoi.ToString();
            txtLuongNuoc.Text = luongNuoc.ToString();
            dateThoiGianDau.Text = thoiGianDau.ToString();
            dateThoiGianCuoi.Text = thoiGianCuoi.ToString();
            txtHoTenKH.Text = hoTenKH.ToString();
            txtDC.Text = diaChi.ToString();
            txtPhuong.Text = phuong.ToString();
            txtTenNV.Text = hoTenNV.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
