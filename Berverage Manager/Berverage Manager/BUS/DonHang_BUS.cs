using Berverage_Manager.DAO;
using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.BUS
{
    public class DonHang_BUS
    {
        DonHang_DAO donHang_DAO;

        public DonHang_BUS()
        {
            donHang_DAO = new DonHang_DAO();
        }

        public List<DONHANG> LayTatCaDonHang()
        {
            return donHang_DAO.LayTatCaDonHang();
        }

        public List<DONHANG> LayDSDonHangBangMaKhuyenMai(int maKM)
        {
            return donHang_DAO.LayDSDonHangBangMaKhuyenMai(maKM);
        }

        public void ThemDonHang(DONHANG dh)
        {
            donHang_DAO.ThemDonHang(dh);
        }

        public List<DONHANG> TimKiemDonHang(String timKiemDH)
        {
            return donHang_DAO.TimKiemDonHang(timKiemDH);
        }

        public List<DONHANG> TimKiemDonHangTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            return donHang_DAO.TimKiemDonHangTheoNgay(tuNgay, denNgay);
        }

        public List<DONHANG> LayDanhSachDonHangTheoThangNam(int thang, int nam)
        {
            return donHang_DAO.LayDanhSachDonHangTheoThangNam(thang, nam);
        }

    }
}
