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

        public void ThemCTDonHang(CT_DONHANG ct_DH)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.CT_DONHANG.Add(ct_DH);
                dbQuanLyBanNGK.SaveChanges();
            } 
        }

        public List<CT_DONHANG> LayDanhSachCTDHBangMaDH(int maDH)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.CT_DONHANG.Where(p => p.MADH == maDH).ToList();
            }
        }
    }
}
