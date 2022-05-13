using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class SanPham_DAO
    {
        DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK;
        public SanPham_DAO()
        {
            dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        }

        public List<SANPHAM> LayTatCaSanPham()
        {
            return dbQuanLyBanNGK.SANPHAMs.ToList();
        }

        public void ThemSanPham(SANPHAM sp)
        {
            dbQuanLyBanNGK.SANPHAMs.Add(sp);
            dbQuanLyBanNGK.SaveChanges();
        }

        public SANPHAM LaySanPhamBangMSP(int maSP)
        {
            return dbQuanLyBanNGK.SANPHAMs.FirstOrDefault(p => p.MASP == maSP);
        }

        public void SuaSanPham(SANPHAM sp)
        {
            dbQuanLyBanNGK.SANPHAMs.AddOrUpdate(sp);
            dbQuanLyBanNGK.SaveChanges();
        }

        public void XoaSanPham(int maSP)
        {
            SANPHAM sp = dbQuanLyBanNGK.SANPHAMs.FirstOrDefault(p => p.MASP == maSP);
            dbQuanLyBanNGK.SANPHAMs.Remove(sp);
            dbQuanLyBanNGK.SaveChanges();
        }

        public List<SANPHAM> TimKiemSanPham(List<SANPHAM> listSP, String timKiemSP)
        {
            List<SANPHAM> listTimSP = listSP.Where(p => p.TENSP.ToLower().Contains(timKiemSP.ToLower())).ToList();
            return listTimSP;
        }
    }
}
