using Berverage_Manager.DAO;
using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.BUS
{
    public class CT_DonHang_BUS
    {
        CT_DonHang_DAO ct_DonHang_DAO;

        public CT_DonHang_BUS()
        {
            ct_DonHang_DAO = new CT_DonHang_DAO();
        }

        public void ThemCTDonHang(CT_DONHANG ct_DH)
        {
            ct_DonHang_DAO.ThemCTDonHang(ct_DH);
        }

        public List<CT_DONHANG> LayDanhSachCTDHBangMaDH(int maDH)
        {
            return ct_DonHang_DAO.LayDanhSachCTDHBangMaDH(maDH);
        }
    }
}
