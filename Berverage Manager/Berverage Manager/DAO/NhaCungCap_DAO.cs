using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class NhaCungCap_DAO
    {
        public List<NHACUNGCAP> LayTatCaNhaCungCap()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.NHACUNGCAPs.ToList();
            }
        }

        public NHACUNGCAP LayNhaCungCapBangMNCC(int maNCC)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.NHACUNGCAPs.FirstOrDefault(p => p.MANCC == maNCC);
            }
        }

        public void ThemNhaCungCap(NHACUNGCAP ncc)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.NHACUNGCAPs.Add(ncc);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public void SuaNhaCungCap(NHACUNGCAP ncc)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.NHACUNGCAPs.AddOrUpdate(ncc);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public void XoaNhaCungCap(int maNCC)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                NHACUNGCAP ncc = dbQuanLyBanNGK.NHACUNGCAPs.FirstOrDefault(p => p.MANCC == maNCC);
                dbQuanLyBanNGK.NHACUNGCAPs.Remove(ncc);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public List<NHACUNGCAP> TimKiemNhaCungCap(List<NHACUNGCAP> listNCC, String timKiemNCC)
        {
            List<NHACUNGCAP> listTimNCC = listNCC.Where(p => p.TENNCC.ToLower().Contains(timKiemNCC.ToLower())
                                          || p.MANCC.ToString().Contains(timKiemNCC)).ToList();
            return listTimNCC;
        }
    }
}
