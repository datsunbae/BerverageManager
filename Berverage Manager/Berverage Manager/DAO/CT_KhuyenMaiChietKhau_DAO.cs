using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class CT_KhuyenMaiChietKhau_DAO
    {
        public void ThemCT_KhuyenMaiChietKhau(CTKHUYENMAI_CHIETKHAU ctKhuyenMaiCK)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.CTKHUYENMAI_CHIETKHAU.Add(ctKhuyenMaiCK);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public List<CTKHUYENMAI_CHIETKHAU> LayDanhSachCTKhuyenMaiBangMKM(int maKM)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.CTKHUYENMAI_CHIETKHAU.Where(p => p.MAKM == maKM).ToList();

            }
        }
    }
}
