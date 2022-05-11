using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DAO
{
    internal class VaiTro_DAO
    {
        DBQuanLyBanNuocGiaiKhat dbQuanLyBanNGK;

        public VaiTro_DAO()
        {
            dbQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        }

        public List<VAITRO> LayTatCaVaiTro()
        {
            return dbQuanLyBanNGK.VAITROes.ToList();
        }
    }
}
