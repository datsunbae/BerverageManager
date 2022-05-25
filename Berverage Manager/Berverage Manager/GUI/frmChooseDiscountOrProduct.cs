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
    public partial class frmChooseDiscountOrProduct : Form
    {
        public frmChooseDiscountOrProduct()
        {
            InitializeComponent();
        }

        private void CLKM_BTN_ChietKhau_Click(object sender, EventArgs e)
        {
            new frmAddOrUpdateDiscount().Show();
            this.Hide();
        }

        private void CLKM_BTN_TangSP_Click(object sender, EventArgs e)
        {
            new frmAddOrUpdateDiscountProduct().Show();
            this.Hide();
        }
    }
}
