using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class DonVi_DAO
    {
        DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK;
        public DonVi_DAO()
        {
            dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        }

        public List<DONVI> LayTatCaDonVi()
        {
            return dbQuanLyBanNGK.DONVIs.ToList();
        }

        public List<DONVI> LayTatCaDonViChinh()
        {
            return dbQuanLyBanNGK.DONVIs.Where(p => p.DVTC == true).ToList();
        }

        public List<DONVI> LayTatCaDonViPhu()
        {
            return dbQuanLyBanNGK.DONVIs.Where(p => p.DVTC == false).ToList();
        }

        public string LayMaDVTBangTenDVT(String tenDVT)
        {
            return dbQuanLyBanNGK.DONVIs.SingleOrDefault(p => p.TENDV == tenDVT).MADV;
        }
    }
}
