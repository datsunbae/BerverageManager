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
        DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK;

        public NhaCungCap_DAO()
        {
            dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        }

        public List<NHACUNGCAP> LayTatCaNhaCungCap()
        {
            return dbQuanLyBanNGK.NHACUNGCAPs.ToList();
        }

        public NHACUNGCAP LayNhaCungCapBangMNCC(int maNCC)
        {
            return dbQuanLyBanNGK.NHACUNGCAPs.FirstOrDefault(p => p.MANCC == maNCC);
        }

        public void ThemNhaCungCap(NHACUNGCAP ncc)
        {
            dbQuanLyBanNGK.NHACUNGCAPs.Add(ncc);
            dbQuanLyBanNGK.SaveChanges();
        }

        public void SuaNhaCungCap(NHACUNGCAP ncc)
        {
            dbQuanLyBanNGK.NHACUNGCAPs.AddOrUpdate(ncc);
            dbQuanLyBanNGK.SaveChanges();
        }

        public void XoaNhaCungCap(int maNCC)
        {
            NHACUNGCAP ncc = dbQuanLyBanNGK.NHACUNGCAPs.FirstOrDefault(p => p.MANCC == maNCC);
            dbQuanLyBanNGK.NHACUNGCAPs.Remove(ncc);
            dbQuanLyBanNGK.SaveChanges();
        }

        public List<NHACUNGCAP> TimKiemNhaCungCap(List<NHACUNGCAP> listNCC, String timKiemNCC)
        {
            List<NHACUNGCAP> listTimNCC = listNCC.Where(p => p.TENNCC.ToLower().Contains(timKiemNCC.ToLower())).ToList();
            return listTimNCC;
        }
    }
}
