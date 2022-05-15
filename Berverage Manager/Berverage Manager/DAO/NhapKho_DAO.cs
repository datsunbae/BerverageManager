using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class NhapKho_DAO
    {
        DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK;
        public NhapKho_DAO()
        {
            dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        }

        public List<NHAPKHO> LayTatCaPhieuNhapKho()
        {
            return dbQuanLyBanNGK.NHAPKHOes.ToList();
        }

        public void ThemPhieuNhapKho(NHAPKHO pnk)
        {
            dbQuanLyBanNGK.NHAPKHOes.Add(pnk);
            dbQuanLyBanNGK.SaveChanges();
        }

        public List<NHAPKHO> TimKiemPhieuNhapKho(String timKiemPNK)
        {
            return dbQuanLyBanNGK.NHAPKHOes.Where(p => p.NHACUNGCAP.TENNCC.ToLower().Contains(timKiemPNK.ToLower())
                   || p.NHANVIEN.TENNV.ToLower().Contains(timKiemPNK.ToLower())).ToList();
        }

        public List<NHAPKHO> TimKiemPhieuNhapKhoTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
           return dbQuanLyBanNGK.NHAPKHOes.Where(p => p.NGAYNHAP.Value >= tuNgay && p.NGAYNHAP <= denNgay).ToList();
        }
    }
}
