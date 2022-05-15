using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berverage_Manager.DataContext;
using Berverage_Manager.DAO;

namespace Berverage_Manager.BUS
{
    public class NhapKho_BUS
    {
        NhapKho_DAO nhapKho_DAO;

        public NhapKho_BUS()
        {
            nhapKho_DAO = new NhapKho_DAO();
        }

        public List<NHAPKHO> LayTatCaPhieuNhapKho()
        {
            return nhapKho_DAO.LayTatCaPhieuNhapKho();
        }

        public void ThemPhieuNhapKho(NHAPKHO pnk)
        {
            nhapKho_DAO.ThemPhieuNhapKho(pnk);
        }

        public List<NHAPKHO> TimKiemPhieuNhapKho(String timKiemPNK)
        {
            return nhapKho_DAO.TimKiemPhieuNhapKho(timKiemPNK);
        }

        public List<NHAPKHO> TimKiemPhieuNhapKhoTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            return nhapKho_DAO.TimKiemPhieuNhapKhoTheoNgay(tuNgay, denNgay);
        }
    }
}
