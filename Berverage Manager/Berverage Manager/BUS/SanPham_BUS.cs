using Berverage_Manager.DAO;
using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.BUS
{
    public class SanPham_BUS
    {
        SanPham_DAO sanPham_DAO;
        
        public SanPham_BUS()
        {
            sanPham_DAO = new SanPham_DAO();
        }

        public List<SANPHAM> LayTatCaSanPham()
        {
            return sanPham_DAO.LayTatCaSanPham();
        }

        public List<SANPHAM> LayTatCaSanPhamConTonKho(List<TONKHO> listTK)
        {
            return sanPham_DAO.LayTatCaSanPhamConTonKho(listTK);
        }

        public void ThemSanPham(SANPHAM sp)
        {
            sanPham_DAO.ThemSanPham(sp);
        }

        public SANPHAM LaySanPhamBangMSP(int maSP)
        {
            return sanPham_DAO.LaySanPhamBangMSP(maSP);
        }

        public void SuaSanPham(SANPHAM sp)
        {
            sanPham_DAO.SuaSanPham(sp);
        }

        public void XoaSanPham(int maSP)
        {
            sanPham_DAO.XoaSanPham(maSP);
        }

        public List<SANPHAM> TimKiemSanPham(List<SANPHAM> listSP, String timKiemSP)
        {
            return sanPham_DAO.TimKiemSanPham(listSP, timKiemSP);
        }

        public int SanPhamBanChayNhatTheoThangNam(int thang, int nam)
        {
            return sanPham_DAO.SanPhamBanChayNhatTheoThangNam(thang, nam);
        }
    }
}
