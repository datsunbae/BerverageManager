using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berverage_Manager.GUI
{
    public partial class ucBill : UserControl
    {
        public ucBill()
        {
            InitializeComponent();
        }

        private void btn_BillDetails_Click(object sender, EventArgs e)
        {
            frmBillDetails billDetails = new frmBillDetails();
            billDetails.ShowDialog();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            frmHomeAdmin.home.sell.BringToFront();
        }
    }
}
