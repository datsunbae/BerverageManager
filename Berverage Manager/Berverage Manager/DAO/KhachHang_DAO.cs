﻿using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class KhachHang_DAO
    {
        public List<KHACHHANG> LayTatCaKhachHang()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.KHACHHANGs.ToList();
            }
        }

        public List<KHACHHANG> LayKhachLe()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.KHACHHANGs.Where(p => p.LOAIKH == false).ToList();
            }
        }

        public List<KHACHHANG> LayTatCaKhachSi()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.KHACHHANGs.Where(p => p.LOAIKH == true).ToList();
            }
        }

        public KHACHHANG LayKhachHangBangMKH(int maKH)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.KHACHHANGs.FirstOrDefault(p => p.MAKH == maKH);
            }
        }

        public void ThemKhachHang(KHACHHANG kh)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.KHACHHANGs.Add(kh);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public void SuaKhachHang(KHACHHANG kh)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.KHACHHANGs.AddOrUpdate(kh);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public void XoaKhachHang(int maKH)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                KHACHHANG kh = dbQuanLyBanNGK.KHACHHANGs.FirstOrDefault(p => p.MAKH == maKH);
                dbQuanLyBanNGK.KHACHHANGs.Remove(kh);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public List<KHACHHANG> TimKiemKhachHang(List<KHACHHANG> listKH, String timKiemKH)
        {
            List<KHACHHANG> listTimKH = listKH.Where(p => p.TENKH.ToLower().Contains(timKiemKH.ToLower())).ToList();
            return listTimKH;
        }

    }
}
