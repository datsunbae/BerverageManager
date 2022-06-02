using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berverage_Manager.DAO;
using Berverage_Manager.DataContext;

namespace Berverage_Manager.BUS
{
    public class ChietKhau_BUS
    {
        ChietKhau_DAO chietKhau_DAO;
        public ChietKhau_BUS()
        {
            chietKhau_DAO = new ChietKhau_DAO();
        }

        public List<CHIETKHAU> LayTatChietKhau()
        {
            return chietKhau_DAO.LayTatChietKhau();
        }
        public CHIETKHAU LayChietKhauBangMCK(String maCK)
        {
            return chietKhau_DAO.LayChietKhauBangMCK(maCK);
        }

        public string LayMaChietKhauBangTenCK(String tenCK)
        {
            return chietKhau_DAO.LayMaChietKhauBangTenCK(tenCK);
        }
    }
}
