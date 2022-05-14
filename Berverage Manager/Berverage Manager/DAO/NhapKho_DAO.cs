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

        public List<NHAPKHO> TimKiemPhieuNhapKho(List<NHAPKHO> listPNK, String timKiemPNK)
        {
            List<NHAPKHO> listTimPNK = listPNK.Where(p => p.NHACUNGCAP.TENNCC.ToLower().Contains(timKiemPNK.ToLower())
                                       || p.NHACUNGCAP.TENNCC.ToLower().Contains(timKiemPNK.ToLower())).ToList();
            return listTimPNK;
        }
    }
}
