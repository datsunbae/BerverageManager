using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class DonHang_DAO
    {
        DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK;
        public DonHang_DAO()
        {
            dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        }

        public List<DONHANG> LayTatCaDonHang()
        {
            return dbQuanLyBanNGK.DONHANGs.ToList();
        }

        public void ThemDonHang(DONHANG dh)
        {
            dbQuanLyBanNGK.DONHANGs.Add(dh);
            dbQuanLyBanNGK.SaveChanges();
        }

        public List<DONHANG> TimKiemDonHang(String timKiemDH)
        {
            return dbQuanLyBanNGK.DONHANGs.Where(p => p.KHACHHANG.TENKH.ToLower().Contains(timKiemDH.ToLower())
                   || p.NHANVIEN.TENNV.ToLower().Contains(timKiemDH.ToLower())).ToList();
        }

        public List<DONHANG> TimKiemDonHangTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            return dbQuanLyBanNGK.DONHANGs.Where(p => p.NGAYLAP.Value >= tuNgay && p.NGAYLAP <= denNgay).ToList();
        }
    }
}
