using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class TaiKhoan_DAO
    {
        DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK;

        public TaiKhoan_DAO()
        {
            dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        }

        public void ThemTaiKhoan(TAIKHOAN tk)
        {
            dbQuanLyBanNGK.TAIKHOANs.Add(tk);
            dbQuanLyBanNGK.SaveChanges();
        }

        public void SuaTaiKhoan(TAIKHOAN tk)
        {
            dbQuanLyBanNGK.TAIKHOANs.AddOrUpdate(tk);
            dbQuanLyBanNGK.SaveChanges();
        }

        public void XoaTaiKhoan(TAIKHOAN tk)
        {
            dbQuanLyBanNGK.TAIKHOANs.Remove(tk);
            dbQuanLyBanNGK.SaveChanges();
        }
    }
}
