using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using static GUI.frmXuPhat;

namespace GUI
{
    public partial class frmInHoaDonXuPhat : Form
    {
        private readonly InvoiceData invoiceData;
        public frmInHoaDonXuPhat(InvoiceData invoiceData)
        {
            InitializeComponent();
            this.invoiceData = invoiceData;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInHoaDonXuPhat_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.reportBillXuPhat.rdlc";
            ReportParameter[] parameters = new ReportParameter[15];
            parameters[0] = new ReportParameter("maXP", invoiceData.maXP);
            parameters[1] = new ReportParameter("maTT", invoiceData.maTT);
            parameters[2] = new ReportParameter("thoiGian", invoiceData.ngayNop);
            parameters[3] = new ReportParameter("maKH", invoiceData.maKH);
            parameters[4] = new ReportParameter("tenKH", invoiceData.tenKH);
            parameters[5] = new ReportParameter("soDT", invoiceData.soDT);
            parameters[6] = new ReportParameter("Duong", invoiceData.Duong);
            parameters[7] = new ReportParameter("Phuong", invoiceData.Phuong);
            parameters[8] = new ReportParameter("maDH", invoiceData.maDHN);
            parameters[9] = new ReportParameter("soNgay", invoiceData.soNgay);
            parameters[10] = new ReportParameter("maHD1", invoiceData.maHD1);
            parameters[11] = new ReportParameter("maHD2", invoiceData.maHD2);
            parameters[12] = new ReportParameter("tongTienHD1", invoiceData.tongTienHD1);
            parameters[13] = new ReportParameter("tongTienHD2", invoiceData.tongTienHD2);
            parameters[14] = new ReportParameter("tienPhat", invoiceData.tienPhat);

            reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
