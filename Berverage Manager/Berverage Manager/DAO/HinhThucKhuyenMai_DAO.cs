using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class HinhThucKhuyenMai_DAO
    {
        public String LayTenHinhThucKhuyenMaiBangMaHTKM(int maHTKM)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.HINHTHUCKHUYENMAIs.SingleOrDefault(p => p.MAHTKM == maHTKM).TENHTKM;
            }
        }
    }
}
