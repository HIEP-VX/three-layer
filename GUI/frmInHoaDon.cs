using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using OfficeOpenXml.FormulaParsing.Utilities;
using static GUI.frmHoaDon;

namespace GUI
{
    public partial class frmInHoaDon : Form
    {
        private readonly InvoiceData invoiceData;
        public frmInHoaDon(InvoiceData invoiceData)
        {
            InitializeComponent();
            this.invoiceData = invoiceData;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.reportBill.rdlc";
            ReportParameter[] parameters = new ReportParameter[20];
            parameters[0] = new ReportParameter("maHD", invoiceData.maHD);
            parameters[1] = new ReportParameter("maTT", invoiceData.maTT);
            parameters[2] = new ReportParameter("thoiGianDau", invoiceData.thoiGianDau);
            parameters[3] = new ReportParameter("thoiGianCuoi", invoiceData.thoiGianCuoi);
            parameters[4] = new ReportParameter("maKH", invoiceData.maKH);
            parameters[5] = new ReportParameter("tenKH", invoiceData.tenKH);
            parameters[6] = new ReportParameter("thangHD", invoiceData.thangHD);
            parameters[7] = new ReportParameter("namHD", invoiceData.namHD);
            parameters[8] = new ReportParameter("soDT", invoiceData.soDT);
            parameters[9] = new ReportParameter("Duong", invoiceData.Duong);
            parameters[10] = new ReportParameter("Phuong", invoiceData.Phuong);
            parameters[11] = new ReportParameter("chiSoCu", invoiceData.chiSoCu);
            parameters[12] = new ReportParameter("chiSoMoi", invoiceData.chiSoMoi);
            parameters[13] = new ReportParameter("luongTieuThu", invoiceData.luongTieuThu);
            parameters[14] = new ReportParameter("tienNuoc", invoiceData.tienNuoc);
            parameters[15] = new ReportParameter("tongTien", invoiceData.tongTien);
            parameters[16] = new ReportParameter("tongThue", invoiceData.thue);
            parameters[17] = new ReportParameter("maDH", invoiceData.maDHN);
            parameters[18] = new ReportParameter("tenLoai", invoiceData.tenLoai);
            parameters[19] = new ReportParameter("ngaySinh", invoiceData.ngaySinh);

            reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
