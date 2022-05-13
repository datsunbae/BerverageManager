﻿using Berverage_Manager.DAO;
using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.BUS
{
    public class DonVi_BUS
    {
        DonVi_DAO donVi_DAO;

        public DonVi_BUS()
        {
            donVi_DAO = new DonVi_DAO();
        }

        public List<DONVI> LayTatCaDonVi()
        {
            return donVi_DAO.LayTatCaDonVi();
        }

        public List<DONVI> LayTatCaDonViChinh()
        {
            return donVi_DAO.LayTatCaDonViChinh();
        }

        public List<DONVI> LayTatCaDonViPhu()
        {
            return donVi_DAO.LayTatCaDonViPhu();
        }

 
    }
}
