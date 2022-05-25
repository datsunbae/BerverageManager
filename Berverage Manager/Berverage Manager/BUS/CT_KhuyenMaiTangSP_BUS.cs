using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berverage_Manager.DAO;
using Berverage_Manager.DataContext;

namespace Berverage_Manager.BUS
{
    public class CT_KhuyenMaiTangSP_BUS
    {
        CT_KhuyenMaiTangSP_DAO ct_KhuyenMaiTangSP_DAO;
        public CT_KhuyenMaiTangSP_BUS()
        {
            ct_KhuyenMaiTangSP_DAO = new CT_KhuyenMaiTangSP_DAO();
        }
        public void ThemCT_KhuyenMaiTangSP(CTKHUYENMAI_TANGSP ctKhuyenMaiTangSP)
        {
            ct_KhuyenMaiTangSP_DAO.ThemCT_KhuyenMaiTangSP(ctKhuyenMaiTangSP);
        }

        public List<CTKHUYENMAI_TANGSP> LayDanhSachCTKhuyenMaiBangMKM(int maKM)
        {
            return ct_KhuyenMaiTangSP_DAO.LayDanhSachCTKhuyenMaiBangMKM(maKM);
        }
    }
}
