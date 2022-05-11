using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berverage_Manager.DAO;
using Berverage_Manager.DataContext;

namespace Berverage_Manager.BUS
{
    public class TaiKhoan_BUS
    {
        TaiKhoan_DAO tk_DAO;
        
        public TaiKhoan_BUS()
        {
            tk_DAO = new TaiKhoan_DAO();
        }

        public void ThemTaiKhoan(TAIKHOAN tk)
        {
            tk_DAO.ThemTaiKhoan(tk);
        }

        public void SuaTaiKhoan(TAIKHOAN tk)
        {
            tk_DAO.SuaTaiKhoan(tk);
        }

        public void XoaTaiKhoan(String maTK)
        {
            tk_DAO.XoaTaiKhoan(maTK);
        }

        public TAIKHOAN LayTaiKhoanBangMTK(String maTaiKhoan)
        {
            return tk_DAO.LayTaiKhoanBangMTK(maTaiKhoan);
        }
    }
}
