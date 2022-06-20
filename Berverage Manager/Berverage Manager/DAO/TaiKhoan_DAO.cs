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
        public void ThemTaiKhoan(TAIKHOAN tk)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.TAIKHOANs.Add(tk);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public void SuaTaiKhoan(TAIKHOAN tk)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.TAIKHOANs.AddOrUpdate(tk);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public void XoaTaiKhoan(String maTK)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                TAIKHOAN tk = dbQuanLyBanNGK.TAIKHOANs.FirstOrDefault(p => p.MADANGNHAP == maTK);
                dbQuanLyBanNGK.TAIKHOANs.Remove(tk);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public TAIKHOAN LayTaiKhoanBangMTK(String maTaiKhoan)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.TAIKHOANs.FirstOrDefault(p => p.MADANGNHAP == maTaiKhoan);
            }
        }

        public TAIKHOAN LayTaiKhoanBangEmail(String email)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.TAIKHOANs.FirstOrDefault(p => p.EMAIL == email);
            }
        }

        public Boolean KiemTRaMaTaiKhoanTonTai(string maTK)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                var result = dbQuanLyBanNGK.TAIKHOANs.Find(maTK);
                if (result != null)
                {
                    return true;
                }

                return false;
            }
        }

    }
}
