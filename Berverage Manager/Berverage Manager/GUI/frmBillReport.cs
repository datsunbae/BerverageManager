using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Berverage_Manager.DataContext;
using Berverage_Manager.DTO;
using Microsoft.Reporting.WinForms;

namespace Berverage_Manager.GUI
{
    public partial class frmBillReport : Form
    {
        public frmBillReport()
        {
            InitializeComponent();
        }

        private void frmBillReport_Load(object sender, EventArgs e)
        {
            List<HOADON_REPORT> listReport = ucSell.uc_BanHang.ListCTHD_XuatReport();
            ReportParameter[] parms = new ReportParameter[9];
            int tongDongDGVHD = ucBill.uc_DonHang.dgv_DonHang.Rows.Count;
            int maDonHang = 1;
            if (tongDongDGVHD > 0)
            {
                maDonHang = int.Parse(ucBill.uc_DonHang.dgv_DonHang.Rows[tongDongDGVHD - 1].Cells[0].Value.ToString());
                Console.WriteLine(tongDongDGVHD);
                maDonHang++;
            }
            parms[0] = new ReportParameter("TenNhanVien", ucSell.uc_BanHang.cb_NhanVien.Text);
            parms[1] = new ReportParameter("MaHoaDon", maDonHang.ToString());
            parms[2] = new ReportParameter("NgayTaoHD", ucSell.uc_BanHang.date_NgayTao.Text);
            parms[3] = new ReportParameter("TenKhachHang", ucSell.uc_BanHang.cb_KhachHang.Text);
            parms[4] = new ReportParameter("TongTien", ucSell.uc_BanHang.txt_TongTien.Text);
            parms[5] = new ReportParameter("ChietKhau", ucSell.uc_BanHang.textBox_ChietKhau.Text);
            parms[6] = new ReportParameter("TienKhachDua", ucSell.uc_BanHang.txt_TienKhachDua.Text);
            parms[7] = new ReportParameter("TienThua", ucSell.uc_BanHang.txt_TienThua.Text);
            parms[8] = new ReportParameter("TienCanThanhToan", ucSell.uc_BanHang.textBox_CanThanhToan.Text);
            this.reportViewer1.LocalReport.ReportPath = "./Report/ReportBill.rdlc";
            this.reportViewer1.LocalReport.SetParameters(parms);
            var reportDataSource = new ReportDataSource("DataSetHoaDon", listReport);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
