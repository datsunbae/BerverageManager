using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berverage_Manager.DAO;
using Berverage_Manager.DataContext;

namespace Berverage_Manager.BUS
{
    public class NhaCungCap_BUS
    {
        NhaCungCap_DAO nhaCungCap_DAO;

        public NhaCungCap_BUS()
        {
            nhaCungCap_DAO = new NhaCungCap_DAO();
        }

        public List<NHACUNGCAP> LayTatCaNhaCungCap()
        {
            return nhaCungCap_DAO.LayTatCaNhaCungCap();
        }

        public NHACUNGCAP LayNhaCungCapBangMNCC(int maNCC)
        {
            return nhaCungCap_DAO.LayNhaCungCapBangMNCC(maNCC);
        }

        public void ThemNhaCungCap(NHACUNGCAP ncc)
        {
            nhaCungCap_DAO.ThemNhaCungCap(ncc);
        }

        public void SuaNhaCungCap(NHACUNGCAP ncc)
        {
            nhaCungCap_DAO.SuaNhaCungCap(ncc);
        }

        public void XoaNhaCungCap(int maNCC)
        {
            nhaCungCap_DAO.XoaNhaCungCap(maNCC);
        }

        public List<NHACUNGCAP> TimKiemNhaCungCap(List<NHACUNGCAP> listNCC, String timKiemNCC)
        {
            return nhaCungCap_DAO.TimKiemNhaCungCap(listNCC, timKiemNCC);
        }
    }
}
