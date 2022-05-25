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
    public partial class ucDiscount : UserControl
    {
        public ucDiscount()
        {
            InitializeComponent();
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            new frmChooseDiscountOrProduct().Show();
        }

        private void btnEditDiscount_Click(object sender, EventArgs e)
        {

        }
    }
}
