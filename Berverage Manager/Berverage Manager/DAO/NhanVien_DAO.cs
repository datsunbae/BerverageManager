
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

        public NHANVIEN LayNhanVienBangMNV(int maNV)
        {
            return dbQuanLyBanNGK.NHANVIENs.FirstOrDefault(p => p.MANV == maNV);
        }

        public void SuaNhanVien(NHANVIEN nv)
        {
            dbQuanLyBanNGK.NHANVIENs.AddOrUpdate(nv);
            dbQuanLyBanNGK.SaveChanges();
        }

        public void XoaNhanVien(int maNV)
        {
            NHANVIEN nv = dbQuanLyBanNGK.NHANVIENs.FirstOrDefault(p => p.MANV == maNV);
            dbQuanLyBanNGK.NHANVIENs.Remove(nv);
            dbQuanLyBanNGK.SaveChanges();
        }

        public List<NHANVIEN> TimKiemNhanVien(List<NHANVIEN> listNV, String timKiemKH)
        {
            List<NHANVIEN> listTimNV = listNV.Where(p => p.TENNV.ToLower().Contains(timKiemKH.ToLower())).ToList();
            return listTimNV;
        }
    }
}
