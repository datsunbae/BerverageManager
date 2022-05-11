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
    public partial class frmHomeStaff1 : Form
    {
        public frmHomeStaff1()
        {
            InitializeComponent();
        }
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Supplier.BringToFront();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            Warehouse.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Oder.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product.BringToFront();
        }
    }
}
