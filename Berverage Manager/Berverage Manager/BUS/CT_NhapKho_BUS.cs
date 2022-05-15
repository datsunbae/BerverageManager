using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berverage_Manager.DataContext;
using Berverage_Manager.DAO;

namespace Berverage_Manager.BUS
{
    public class CT_NhapKho_BUS
    {
        CT_NhapKho_DAO ct_NhapKho_DAO;

        public CT_NhapKho_BUS()
        {
            ct_NhapKho_DAO = new CT_NhapKho_DAO();
        }

        public void ThemCTPhieuNhapKho(CT_PNHAPKHO ct_PNK)
        {
            ct_NhapKho_DAO.ThemCTPhieuNhapKho(ct_PNK);
        }

        public List<CT_PNHAPKHO> LayDanhSachCTPNKBangMaPNK(int maPNK)
        {
            return ct_NhapKho_DAO.LayDanhSachCTPNKBangMaPNK(maPNK);
        }

    }
}
