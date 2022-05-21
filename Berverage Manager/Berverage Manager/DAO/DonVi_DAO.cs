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
        public List<DONVI> LayTatCaDonVi()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.DONVIs.ToList();
            }
        }

        public List<DONVI> LayTatCaDonViChinh()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.DONVIs.Where(p => p.DVTC == true).ToList();
            }  
        }

        public List<DONVI> LayTatCaDonViPhu()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.DONVIs.Where(p => p.DVTC == false).ToList();
            }
        }

        public string LayMaDVTBangTenDVT(String tenDVT)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.DONVIs.SingleOrDefault(p => p.TENDV == tenDVT).MADV;
            }
        }

        public string LayTenDVTBangMaDVT(String maDVT)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.DONVIs.SingleOrDefault(p => p.MADV == maDVT).TENDV;
            }
        }

        public List<DONVI> LayDonViTinhCuaSanPham(SANPHAM sp)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.DONVIs.Include("SANPHAMs").Where(p => p.MADV == sp.DVTCHINH || p.MADV == sp.DVTPHU).ToList();
            }
        }
    }
}
