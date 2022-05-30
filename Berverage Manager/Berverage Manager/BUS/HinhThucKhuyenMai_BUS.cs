using Berverage_Manager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.BUS
{
    internal class HinhThucKhuyenMai_BUS
    {
        HinhThucKhuyenMai_DAO hinhThucKhuyenMai_DAO;
        public HinhThucKhuyenMai_BUS()
        {
            hinhThucKhuyenMai_DAO = new HinhThucKhuyenMai_DAO();
        }

        public String LayTenHinhThucKhuyenMaiBangMaHTKM(int maHTKM)
        {
            return hinhThucKhuyenMai_DAO.LayTenHinhThucKhuyenMaiBangMaHTKM(maHTKM);
        }
    }
}
