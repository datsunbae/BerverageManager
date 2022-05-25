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
    public partial class frmSellDiscount : Form
    {
        public frmSellDiscount()
        {
            InitializeComponent();
        }

        private void ADKM_BTN_ApDung_Click(object sender, EventArgs e)
        {
            //xu ly o day
            new frmChooseProductGiveaways().Show();
            this.Hide();

        }
    }
}
