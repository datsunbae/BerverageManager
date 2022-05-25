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
    public partial class frmChooseProductGiveaways : Form
    {
        public frmChooseProductGiveaways()
        {
            InitializeComponent();
        }

        private void CSPT_BTN_QuayLai_Click(object sender, EventArgs e)
        {
            new frmSellDiscount().Show();
            this.Hide();
        }
    }
}
