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
    public partial class frmHomeStaffSell : Form
    {
        public frmHomeStaffSell()
        {
            InitializeComponent();
        }
        private void pcbClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
        }

        private void pcbLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                new frmLogin().Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Sell.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            Bill.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer.BringToFront();
        }
    }
}
