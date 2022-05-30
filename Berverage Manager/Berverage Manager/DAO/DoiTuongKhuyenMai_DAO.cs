using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berverage_Manager.DataContext;

namespace Berverage_Manager.DAO
{
    internal class DoiTuongKhuyenMai_DAO
    {
        public List<DOITUONGKHUYENMAI> LayTatCaDoiTuongKhuyenMai()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.DOITUONGKHUYENMAIs.ToList();
            }
        }

        public String LayTenDoiTuongKhuyenMaiBangMaDTKM(int maDTKM)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.DOITUONGKHUYENMAIs.SingleOrDefault(p => p.MADTKM == maDTKM).TENDTKM;
            }
        }
    }
}
