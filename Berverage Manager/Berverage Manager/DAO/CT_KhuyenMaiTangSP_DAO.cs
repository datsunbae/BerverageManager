using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berverage_Manager.DataContext;
using Berverage_Manager.DTO;
using System.Data.Entity;

namespace Berverage_Manager.DAO
{
    internal class CT_KhuyenMaiTangSP_DAO
    {
        public void ThemCT_KhuyenMaiTangSP(CTKHUYENMAI_TANGSP ctKhuyenMaiTangSP)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.CTKHUYENMAI_TANGSP.Add(ctKhuyenMaiTangSP);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public List<CTKHUYENMAI_TANGSP> LayDanhSachCTKhuyenMaiBangMKM(int maKM)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.CTKHUYENMAI_TANGSP.Where(p => p.MAKM == maKM).ToList();
            }
        }

        public List<CTKHUYENMAI_TANGSP> LayDanhSachCTKhuyenMaiTangSPThoaDK(int maKM, double tongTien)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.CTKHUYENMAI_TANGSP.Where(p => p.MAKM == maKM && p.GIATU <= tongTien && (p.DENGIA >= tongTien || p.DENGIA == null)).ToList();
            }

        }
    }
}
