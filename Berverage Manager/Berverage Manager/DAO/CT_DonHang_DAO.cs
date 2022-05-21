using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class CT_DonHang_DAO
    {
        DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK;
        public CT_DonHang_DAO()
        {
            dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        }

        public void ThemCTDonHang(CT_DONHANG ct_DH)
        {
            dbQuanLyBanNGK.CT_DONHANG.Add(ct_DH);
            dbQuanLyBanNGK.SaveChanges();
        }

        public List<CT_DONHANG> LayDanhSachCTDHBangMaDH(int maDH)
        {
            return dbQuanLyBanNGK.CT_DONHANG.Where(p => p.MADH == maDH).ToList();
        }
    }
}
