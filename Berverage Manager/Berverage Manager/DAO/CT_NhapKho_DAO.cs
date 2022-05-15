using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class CT_NhapKho_DAO
    {
        DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK;
        public CT_NhapKho_DAO()
        {
            dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        }

        public void ThemCTPhieuNhapKho(CT_PNHAPKHO ct_PNK)
        {
            dbQuanLyBanNGK.CT_PNHAPKHO.Add(ct_PNK);
            dbQuanLyBanNGK.SaveChanges();
        }

        public List<CT_PNHAPKHO> LayDanhSachCTPNKBangMaPNK(int maPNK)
        {
            return dbQuanLyBanNGK.CT_PNHAPKHO.Where(p => p.IDPNK == maPNK).ToList();
        }
    }
}
