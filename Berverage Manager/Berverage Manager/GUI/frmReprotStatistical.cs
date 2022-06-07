using Berverage_Manager.BUS;
using Berverage_Manager.DataContext;
using Berverage_Manager.DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berverage_Manager.GUI
{
    public partial class frmReprotStatistical : Form
    {
        DonHang_BUS donHang_BUS;
        KhachHang_BUS khachHang_BUS;
        NhanVien_BUS nhanVien_BUS;
        public frmReprotStatistical()
        {
            InitializeComponent();
            donHang_BUS = new DonHang_BUS();
            khachHang_BUS = new KhachHang_BUS();
            nhanVien_BUS = new NhanVien_BUS();
        }

        private void frmReprotStatistical_Load(object sender, EventArgs e)
        {
            frmRS_Date.Value = DateTime.Now;
            this.reportViewer1.RefreshReport();
        }

        public double TinhDoanhThuTheoThangNam(List<DONHANG> listDonHang)
        {
            double doanhThu = 0;
            foreach (var item in listDonHang)
            {
                doanhThu += item.TONGTIEN.Value;
            }
            return doanhThu;
        }

        private void frmRS_Date_ValueChanged(object sender, EventArgs e)
        {
            ReportParameter[] parms = new ReportParameter[3];
            List<DonHangDoanhThuReport_DTO> listDH_Report = new List<DonHangDoanhThuReport_DTO>();
            DonHangDoanhThuReport_DTO dh;
            List<DONHANG> listDH = donHang_BUS.LayDanhSachDonHangTheoThangNam(frmRS_Date.Value.Month, frmRS_Date.Value.Year);
            foreach(var item in listDH)
            {
                dh = new DonHangDoanhThuReport_DTO();
                dh.MAHD = item.MADH;
                dh.NgayLap = item.NGAYLAP.Value;
                dh.TenKhachHang = khachHang_BUS.LayKhachHangBangMKH(item.IDKH.Value).TENKH;
                dh.TenNhanVien = nhanVien_BUS.LayNhanVienBangMNV(item.IDNV.Value).TENNV;
                dh.TongTien = item.TONGTIEN.Value;
                listDH_Report.Add(dh);
            }
            parms[0] = new ReportParameter("Thang", frmRS_Date.Value.Month.ToString());
            parms[1] = new ReportParameter("Nam", frmRS_Date.Value.Year.ToString());
            parms[2] = new ReportParameter("TongDoanhThu", TinhDoanhThuTheoThangNam(listDH).ToString());
            this.reportViewer1.LocalReport.ReportPath = "./Report/ReportDoanhThu.rdlc";
            this.reportViewer1.LocalReport.SetParameters(parms);
            var reportDataSource = new ReportDataSource("DataSet_DonHang", listDH_Report);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
