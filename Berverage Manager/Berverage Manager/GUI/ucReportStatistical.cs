using Berverage_Manager.BUS;
using Berverage_Manager.DataContext;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
    public partial class ucReportStatistical : UserControl
    {
        SanPham_BUS sanPham_BUS;
        KhachHang_BUS khachHang_BUS;
        DonHang_BUS donHang_BUS;

        public ucReportStatistical()
        {
            InitializeComponent();
            sanPham_BUS = new SanPham_BUS();
            khachHang_BUS = new KhachHang_BUS();
            donHang_BUS = new DonHang_BUS();
        }

        public double TinhDoanhThuTheoThangNam(List<DONHANG> listDonHang)
        {
            double doanhThu = 0;
            foreach(var item in listDonHang)
            {
                doanhThu += item.TONGTIEN.Value;
            }
            return doanhThu;
        }

        public double TinhSoLuongDonHangTheoThangNam(List<DONHANG> listDonHang)
        {
            return listDonHang.Count;
        }

        private void ucReportStatistical_Load(object sender, EventArgs e)
        {
            RS_Date.Value = DateTime.Now;
            LoadChart();
        }

        public void LoadChart()
        {
            ChartDoanhThuBanHang.Series.Clear();
            ChartValues<ObservablePoint> listValueDoanhThu = new ChartValues<ObservablePoint>();
            for (int i = 1; i <= 12; i++)
            {
                List<DONHANG> listDHTheoThang = donHang_BUS.LayDanhSachDonHangTheoThangNam(i, RS_Date.Value.Year);
                listValueDoanhThu.Add(new ObservablePoint(i, TinhDoanhThuTheoThangNam(listDHTheoThang)));
            }

            ChartDoanhThuBanHang.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = listValueDoanhThu
                }
            };
        }

        public void LoadCard()
        {
            List<DONHANG> listDH = donHang_BUS.LayDanhSachDonHangTheoThangNam(RS_Date.Value.Month, RS_Date.Value.Year);
            RS_LB_DoanhThu.Text = TinhDoanhThuTheoThangNam(listDH).ToString();
            RS_LB_SLDonHang.Text = TinhSoLuongDonHangTheoThangNam(listDH).ToString();
            int maSPBanNhieuNhat = sanPham_BUS.SanPhamBanChayNhatTheoThangNam(RS_Date.Value.Month, RS_Date.Value.Year);
            int maKHMuaNhieuNhat = khachHang_BUS.KhachHangMuaNhieuNhatNhatTheoThangNam(RS_Date.Value.Month, RS_Date.Value.Year);
            if (maSPBanNhieuNhat != 0)
            {
                RS_LB_SanPhamBanChayNhat.Text = sanPham_BUS.LaySanPhamBangMSP(maSPBanNhieuNhat).TENSP;
            }
            else
            {
                RS_LB_SanPhamBanChayNhat.Text = "Không có sản phẩm nào";
            }

            if (maKHMuaNhieuNhat != 0)
            {
                RS_LB_KhachMuaNhieuNhat.Text = khachHang_BUS.LayKhachHangBangMKH(maKHMuaNhieuNhat).TENKH;
            }
            else
            {
                RS_LB_KhachMuaNhieuNhat.Text = "Không có khách hàng nào";
            }
        }

        private void RS_Date_ValueChanged(object sender, EventArgs e)
        {
            LoadChart();
            LoadCard();
        }

        private void RS_BTN_XuatBaoCao_Click(object sender, EventArgs e)
        {
            frmReprotStatistical frmReprotStatistical = new frmReprotStatistical(); 
            frmReprotStatistical.ShowDialog();
        }
    }
}
