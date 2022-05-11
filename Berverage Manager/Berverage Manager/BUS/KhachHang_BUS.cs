using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berverage_Manager.DAO;
using Berverage_Manager.DataContext;

namespace Berverage_Manager.BUS
{
    public class KhachHang_BUS
    {
        KhachHang_DAO khachHang_DAO;

        public KhachHang_BUS()
        {
            khachHang_DAO = new KhachHang_DAO(); 
        }

        public List<KHACHHANG> LayTatCaKhachHang()
        {
            return khachHang_DAO.LayTatCaKhachHang();
        }

        public KHACHHANG LayKhachHangBangMKH(int maKH)
        {
            return khachHang_DAO.LayKhachHangBangMKH(maKH);
        }

        public void ThemKhachHang(KHACHHANG kh)
        {
            khachHang_DAO.ThemKhachHang(kh);
        }

        public void SuaKhachHang(KHACHHANG kh)
        {
            khachHang_DAO.SuaKhachHang(kh);
        }

        public void XoaKhachHang(int maKH)
        {
            khachHang_DAO.XoaKhachHang(maKH);
        }

        public List<KHACHHANG> TimKiemKhachHang(List<KHACHHANG> listKH, String timKiemKH)
        {
            return khachHang_DAO.TimKiemKhachHang(listKH, timKiemKH);
        }
    }
}
