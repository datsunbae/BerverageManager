using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berverage_Manager.DAO;
using Berverage_Manager.DataContext;

namespace Berverage_Manager.BUS
{
    public class VaiTro_BUS
    {
        VaiTro_DAO vt_DAO;

        public VaiTro_BUS()
        {
            vt_DAO = new VaiTro_DAO();
        }

        public List<VAITRO> LayTatCaVaiTro()
        {
            return vt_DAO.LayTatCaVaiTro();
        }

        public VAITRO LayTenVaiTroBangMVT(string maVaiTro)
        {
            return vt_DAO.LayTenVaiTroBangMVT(maVaiTro);
        }
    }
}
