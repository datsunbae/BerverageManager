
using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class NhanVien_DAO
    {   
        DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK;
        public NhanVien_DAO()
        {
            dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        }
        
        public List<NHANVIEN> LayTatCaNhanVien()
        {
            return dbQuanLyBanNGK.NHANVIENs.ToList();
        }

        public void ThemNhanVien(NHANVIEN nv)
        {
            dbQuanLyBanNGK.NHANVIENs.Add(nv);
            dbQuanLyBanNGK.SaveChanges();
        }

        public void SuaNhanVien(NHANVIEN nv)
        {
            dbQuanLyBanNGK.NHANVIENs.AddOrUpdate(nv);
            dbQuanLyBanNGK.SaveChanges();
        }

        public void XoaNhanVien(NHANVIEN nv)
        {
            dbQuanLyBanNGK.NHANVIENs.Remove(nv);
            dbQuanLyBanNGK.SaveChanges();
        }
    }
}
