using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class ChietKhau_DAO
    {
        public List<CHIETKHAU> LayTatChietKhau()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.CHIETKHAUs.ToList();
            }
        }
        public CHIETKHAU LayChietKhauBangMCK(String maCK)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.CHIETKHAUs.SingleOrDefault(p => p.MACK == maCK);
            }
        }

        public string LayMaChietKhauBangTenCK(String tenCK)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.CHIETKHAUs.SingleOrDefault(p => p.TENCK == tenCK).MACK;
            }
        }
    }
}
