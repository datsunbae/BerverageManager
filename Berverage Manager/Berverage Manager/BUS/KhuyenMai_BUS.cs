using Berverage_Manager.DAO;
using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.BUS
{
    public class KhuyenMai_BUS
    {
        KhuyenMai_DAO khuyenMai_DAO;
        public KhuyenMai_BUS()
        {
            khuyenMai_DAO = new KhuyenMai_DAO();
        }
        public List<KHUYENMAI> LayTatCaKhuyenMai()
        {
            return khuyenMai_DAO.LayTatCaKhuyenMai();
        }
        public void ThemKhuyenMai(KHUYENMAI km)
        {
            khuyenMai_DAO.ThemKhuyenMai(km);
        }

        public void SuaKhuyenMai(KHUYENMAI km)
        {
            khuyenMai_DAO.SuaKhuyenMai(km);
        }
        public void XoaKhuyenMai(int maKM)
        {
            khuyenMai_DAO.XoaKhuyenMai(maKM);
        }

        public KHUYENMAI LayKhuyenMaiBangMKM(int maKM)
        {
            return khuyenMai_DAO.LayKhuyenMaiBangMKM(maKM);
        }

        public List<KHUYENMAI> TimKiemKhuyenMai(List<KHUYENMAI> listKM, String timKiemKM)
        {
            return khuyenMai_DAO.TimKiemKhuyenMai(listKM, timKiemKM);
        }

/*        public List<KHUYENMAI> LayDSKhuyenMaiThoaiDK(DateTime thoiGianHienTai, int doiTuongKhachHang)
        {
            return khuyenMai_DAO.LayDSKhuyenMaiThoaiDK(thoiGianHienTai, doiTuongKhachHang);
        }*/
    }
}
