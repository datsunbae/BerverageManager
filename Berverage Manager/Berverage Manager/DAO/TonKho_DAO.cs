using Berverage_Manager.DataContext;
using Berverage_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class TonKho_DAO
    {
        public List<TonKho_DTO> LayTatCaTonKho()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                List <TonKho_DTO> listTK_DTO = new List<TonKho_DTO>();
                List<TONKHO> listTK = new List<TONKHO>();
                listTK = dbQuanLyBanNGK.TONKHOes.ToList();
                TonKho_DTO tonKho_DTO;
                foreach(var item in listTK)
                {
                    tonKho_DTO = new TonKho_DTO();
                    tonKho_DTO.ID = item.ID;
                    tonKho_DTO.IDSP = item.IDSP.Value;
                    tonKho_DTO.SLTON = item.SLTON.Value;
                    tonKho_DTO.SLTONQUIDOI = item.SLTONQUIDOI;
                    listTK_DTO.Add(tonKho_DTO);
                }

                return listTK_DTO;
            }
        }

        public List<TonKho_DTO> LayTatCaSanPhamConTonKho()
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                List<TonKho_DTO> listTK_DTO = new List<TonKho_DTO>();
                List<TONKHO> listTK = new List<TONKHO>();
                listTK = dbQuanLyBanNGK.TONKHOes.Where(p => p.SLTON > 0).ToList();
                TonKho_DTO tonKho_DTO;
                foreach (var item in listTK)
                {
                    tonKho_DTO = new TonKho_DTO();
                    tonKho_DTO.ID = item.ID;
                    tonKho_DTO.IDSP = item.IDSP.Value;
                    tonKho_DTO.SLTON = item.SLTON.Value;
                    tonKho_DTO.SLTONQUIDOI = item.SLTONQUIDOI;
                    listTK_DTO.Add(tonKho_DTO);
                }

                return listTK_DTO;
            }
        }

        public void ThemSanPhamVaoTonKho(TONKHO tk)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.TONKHOes.Add(tk);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public void CapNhatSanPhamTonKho(TONKHO tk)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                dbQuanLyBanNGK.TONKHOes.AddOrUpdate(tk);
                dbQuanLyBanNGK.SaveChanges();
            }
        }

        public TONKHO LayTonKhoBangMSP(int maSP)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                return dbQuanLyBanNGK.TONKHOes.SingleOrDefault(p => p.IDSP == maSP);
            }
        }

        public List<TonKho_DTO> TimKiemSanPhamTonKho(String timKiemSPTK)
        {
            using (DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat())
            {
                List<TonKho_DTO> listTK = new List<TonKho_DTO>();
                listTK = (from sp in dbQuanLyBanNGK.SANPHAMs
                           from tk in dbQuanLyBanNGK.TONKHOes
                           where sp.MASP == tk.IDSP
                                 && sp.TENSP.ToLower().Contains(timKiemSPTK.ToLower())
                          select new TonKho_DTO
                           {
                               ID = tk.ID,
                               IDSP = tk.IDSP.Value,
                               SLTON = tk.SLTON.Value,
                               SLTONQUIDOI = tk.SLTONQUIDOI,
                           }).ToList();
                return listTK;
            }
        }
    }
}
