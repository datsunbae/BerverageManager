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
    public partial class ucOder : UserControl
    {
        public ucOder()
        {
            InitializeComponent();
        }

        private void btnOder_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder();
            frmOrder.ShowDialog();
        }

        private void btnVỉewOrder_Click(object sender, EventArgs e)
        {
            frmOrderDetails frmOrderDetails = new frmOrderDetails();
            frmOrderDetails.ShowDialog();
        }
    }
}
