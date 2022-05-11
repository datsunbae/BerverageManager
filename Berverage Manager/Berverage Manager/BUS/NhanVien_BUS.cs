using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berverage_Manager.DAO;
using Berverage_Manager.DataContext;

namespace Berverage_Manager.BUS
{
    public class NhanVien_BUS
    {
        NhanVien_DAO nv_DA0;
        public NhanVien_BUS()
        {
            nv_DA0 = new NhanVien_DAO();
        }

        public List<NHANVIEN> LayTatCaNhanVien()
        {
            return nv_DA0.LayTatCaNhanVien();
        }

        public void ThemNhanVien(NHANVIEN nv)
        {
            nv_DA0.ThemNhanVien(nv);
        }

        public void SuaNhanVien(NHANVIEN nv)
        {
            nv_DA0.SuaNhanVien(nv);
        }

        public void XoaNhanVien(NHANVIEN nv)
        {
            nv_DA0.XoaNhanVien(nv);
        }


    }
}
