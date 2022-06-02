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
        public List<DONHANG> LayTatCaDonHang()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.DONHANGs.ToList();
            } 
        }

        public List<DONHANG> LayDSDonHangBangMaKhuyenMai(int maKM)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.DONHANGs.Where(p => p.MAKHUYENMAI == maKM).ToList();
            }
        }

        public void ThemDonHang(DONHANG dh)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.DONHANGs.Add(dh);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public List<DONHANG> TimKiemDonHang(String timKiemDH)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.DONHANGs.Where(p => p.KHACHHANG.TENKH.ToLower().Contains(timKiemDH.ToLower())
                   || p.NHANVIEN.TENNV.ToLower().Contains(timKiemDH.ToLower())).ToList();
            } 
        }

        public List<DONHANG> TimKiemDonHangTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.DONHANGs.Where(p => p.NGAYLAP.Value >= tuNgay && p.NGAYLAP <= denNgay).ToList();
            }  
        }
    }
}
