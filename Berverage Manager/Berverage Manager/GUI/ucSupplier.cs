using Berverage_Manager.GUI.Supplier;
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
    public partial class ucSupplier : UserControl
    {
        public ucSupplier()
        {
            InitializeComponent();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmAddSupplier addSupplier = new frmAddSupplier();
            addSupplier.ShowDialog();
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            frmUpdateSupplier editSupplier = new frmUpdateSupplier();
            editSupplier.ShowDialog();
        }
    }
}
