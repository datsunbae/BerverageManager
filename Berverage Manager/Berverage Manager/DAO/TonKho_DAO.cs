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
        DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK;
        public TonKho_DAO()
        {
            dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        }

        public List<TONKHO> LayTatCaTonKho()
        {
            return dbQuanLyBanNGK.TONKHOes.ToList();
        }

        public void ThemSanPhamVaoTonKho(TONKHO tk)
        {
            dbQuanLyBanNGK.TONKHOes.Add(tk);
            dbQuanLyBanNGK.SaveChanges();
        }

        public void CapNhatSanPhamTonKho(TONKHO tk)
        {
            dbQuanLyBanNGK.TONKHOes.AddOrUpdate(tk);
            dbQuanLyBanNGK.SaveChanges();
        }

        public TONKHO LayTonKhoBangMSP(int maSP)
        {
            return dbQuanLyBanNGK.TONKHOes.SingleOrDefault(p => p.IDSP == maSP);
        }
    }
}
