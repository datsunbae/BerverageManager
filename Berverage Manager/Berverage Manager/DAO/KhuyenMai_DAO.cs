using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class KhuyenMai_DAO
    {
        public List<KHUYENMAI> LayTatCaKhuyenMai()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.KHUYENMAIs.ToList();
            }
        }
        public void ThemKhuyenMai(KHUYENMAI km)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.KHUYENMAIs.Add(km);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public void SuaKhuyenMai(KHUYENMAI km)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.KHUYENMAIs.AddOrUpdate(km);
                dbQuanLyBanNGK.SaveChanges();
            }
        }
        public void XoaKhuyenMai(int maKM)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                KHUYENMAI km = dbQuanLyBanNGK.KHUYENMAIs.FirstOrDefault(p => p.MAKM == maKM);
                dbQuanLyBanNGK.KHUYENMAIs.Remove(km);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public List<KHUYENMAI> TimKiemKhuyenMai(List<KHUYENMAI> listKM, String timKiemKM)
        {
            List<KHUYENMAI> listTimKM = listKM.Where(p => p.TENKM.ToLower().Contains(timKiemKM.ToLower())).ToList();
            return listTimKM;
        }
    }
}
