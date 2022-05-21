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
        public List<NHAPKHO> LayTatCaPhieuNhapKho()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.NHAPKHOes.ToList();
            }
        }

        public void ThemPhieuNhapKho(NHAPKHO pnk)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.NHAPKHOes.Add(pnk);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public List<NHAPKHO> TimKiemPhieuNhapKho(String timKiemPNK)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.NHAPKHOes.Where(p => p.NHACUNGCAP.TENNCC.ToLower().Contains(timKiemPNK.ToLower())
                   || p.NHANVIEN.TENNV.ToLower().Contains(timKiemPNK.ToLower())).ToList();
            }
        }

        public List<NHAPKHO> TimKiemPhieuNhapKhoTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.NHAPKHOes.Where(p => p.NGAYNHAP.Value >= tuNgay && p.NGAYNHAP <= denNgay).ToList();
            }
            
        }
    }
}
