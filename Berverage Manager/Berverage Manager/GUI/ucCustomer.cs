using Berverage_Manager.GUI.Customer;
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
    public partial class ucCustomer : UserControl
    {
        public ucCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomer = new frmAddCustomer();
            addCustomer.ShowDialog();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            frmUpdateCustomer editCustomer = new frmUpdateCustomer();
            editCustomer.ShowDialog();
        }
    }
}
