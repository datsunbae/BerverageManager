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
    public partial class frmChooseChangePwOrChangeInfo : Form
    {
        public frmChooseChangePwOrChangeInfo()
        {
            InitializeComponent();
        }

        private void S_BTN_ThayDoiThongTin_Click(object sender, EventArgs e)
        {
            new frmChangeInfo().Show();
            this.Hide();
        }

        private void S_BTN_DoiMatKhau_Click(object sender, EventArgs e)
        {
            new frmChangePassword().Show();
            this.Hide();
        }
    }
}
