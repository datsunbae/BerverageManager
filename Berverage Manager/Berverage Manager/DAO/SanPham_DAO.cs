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
        public List<SANPHAM> LayTatCaSanPham()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.SANPHAMs.ToList();
            }
        }

        public List<SANPHAM> LayTatCaSanPhamConTonKho(List<TONKHO> listTK)
        {
            List <SANPHAM> listSP = new List<SANPHAM> ();
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                foreach(var item in listTK)
                {
                    listSP.Add(dbQuanLyBanNGK.SANPHAMs.Include("TONKHOes").FirstOrDefault(p => p.MASP == item.IDSP && item.SLTON > 0));
                }

                return listSP;
            }
        }

        public void ThemSanPham(SANPHAM sp)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.SANPHAMs.Add(sp);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public SANPHAM LaySanPhamBangMSP(int maSP)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.SANPHAMs.FirstOrDefault(p => p.MASP == maSP);
            }
        }

        public void SuaSanPham(SANPHAM sp)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.SANPHAMs.AddOrUpdate(sp);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public void XoaSanPham(int maSP)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                SANPHAM sp = dbQuanLyBanNGK.SANPHAMs.FirstOrDefault(p => p.MASP == maSP);
                dbQuanLyBanNGK.SANPHAMs.Remove(sp);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public List<SANPHAM> TimKiemSanPham(List<SANPHAM> listSP, String timKiemSP)
        {
            List<SANPHAM> listTimSP = listSP.Where(p => p.TENSP.ToLower().Contains(timKiemSP.ToLower())).ToList();
            return listTimSP;
        }

        
    }
}
