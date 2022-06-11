using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berverage_Manager.DataContext;
using Berverage_Manager.DAO;
using Berverage_Manager.DTO;

namespace Berverage_Manager.BUS
{
    public class TonKho_BUS
    {
        TonKho_DAO tonKho_DAO;

        public TonKho_BUS()
        {
            tonKho_DAO = new TonKho_DAO();
        }

        public List<TonKho_DTO> LayTatCaTonKho()
        {
            return tonKho_DAO.LayTatCaTonKho();
        }

        public List<TonKho_DTO> LayTatCaSanPhamConTonKho()
        {
            return tonKho_DAO.LayTatCaSanPhamConTonKho();
        }

        public void ThemSanPhamVaoTonKho(TONKHO tk)
        {
            tonKho_DAO.ThemSanPhamVaoTonKho(tk);
        }

        public void CapNhatSanPhamTonKho(TONKHO tk)
        {
            tonKho_DAO.CapNhatSanPhamTonKho(tk);
        }

        public TONKHO LayTonKhoBangMSP(int maSP)
        {
            return tonKho_DAO.LayTonKhoBangMSP(maSP);
        }

        public List<TonKho_DTO> TimKiemSanPhamTonKho(String timKiemSPTK)
        {
            return tonKho_DAO.TimKiemSanPhamTonKho(timKiemSPTK);
        }
    }
}
