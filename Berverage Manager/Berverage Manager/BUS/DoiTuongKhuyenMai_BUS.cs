using Berverage_Manager.DAO;
using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.BUS
{
    public class DoiTuongKhuyenMai_BUS
    {
        DoiTuongKhuyenMai_DAO doiTuongKhachHang_DAO;

        public DoiTuongKhuyenMai_BUS()
        {
            doiTuongKhachHang_DAO = new DoiTuongKhuyenMai_DAO();
        }
        public List<DOITUONGKHUYENMAI> LayTatCaDoiTuongKhuyenMai()
        {
            return doiTuongKhachHang_DAO.LayTatCaDoiTuongKhuyenMai();
        }

        public String LayTenDoiTuongKhuyenMaiBangMaDTKM(int maDTKM)
        {
            return doiTuongKhachHang_DAO.LayTenDoiTuongKhuyenMaiBangMaDTKM(maDTKM);
        }
    }
}
