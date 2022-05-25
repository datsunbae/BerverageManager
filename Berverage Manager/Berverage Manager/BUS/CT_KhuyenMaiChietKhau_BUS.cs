using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berverage_Manager.DAO;
using Berverage_Manager.DataContext;

namespace Berverage_Manager.BUS
{
    public class CT_KhuyenMaiChietKhau_BUS
    {
        CT_KhuyenMaiChietKhau_DAO cT_KhuyenMaiChietKhau_DAO;
        public CT_KhuyenMaiChietKhau_BUS()
        {
            cT_KhuyenMaiChietKhau_DAO = new CT_KhuyenMaiChietKhau_DAO();
        }

        public void ThemCT_KhuyenMaiChietKhau(CTKHUYENMAI_CHIETKHAU ctKhuyenMaiCK)
        {
            cT_KhuyenMaiChietKhau_DAO.ThemCT_KhuyenMaiChietKhau(ctKhuyenMaiCK);
        }

        public List<CTKHUYENMAI_CHIETKHAU> LayDanhSachCTKhuyenMaiBangMKM(int maKM)
        {
             return cT_KhuyenMaiChietKhau_DAO.LayDanhSachCTKhuyenMaiBangMKM(maKM);
        }
    }
}
