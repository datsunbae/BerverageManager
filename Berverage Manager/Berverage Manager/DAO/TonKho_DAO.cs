using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class TonKho_DAO
    {
        public List<TONKHO> LayTatCaTonKho()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.TONKHOes.ToList();
            }
        }

        public List<TONKHO> LayTatCaSanPhamConTonKho()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.TONKHOes.Where(p => p.SLTON > 0).ToList();
            }
        }

        public void ThemSanPhamVaoTonKho(TONKHO tk)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.TONKHOes.Add(tk);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public void CapNhatSanPhamTonKho(TONKHO tk)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.TONKHOes.AddOrUpdate(tk);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public TONKHO LayTonKhoBangMSP(int maSP)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.TONKHOes.SingleOrDefault(p => p.IDSP == maSP);
            }
        }

        public List<TONKHO> TimKiemSanPhamTonKho(List<TONKHO> listSPTK, String timKiemSPTK)
        {
            List<TONKHO> listTimSPTK = listSPTK.Where(p => p.SANPHAM.TENSP.ToLower().Contains(timKiemSPTK.ToLower())).ToList();
            return listTimSPTK;
        }
    }
}
