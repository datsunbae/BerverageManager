using Berverage_Manager.BUS;
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
    public partial class frmLogin : Form
    {
        TaiKhoan_BUS taiKhoan_BUS;
        public frmLogin()
        {
            InitializeComponent();
            taiKhoan_BUS = new TaiKhoan_BUS(); 
        }

        private void pcbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckLogin(string userName, string passWord)
        {
            var user = taiKhoan_BUS.LayTaiKhoanBangMTK(userName);
            if (user != null)
            {
                if (user.MATKHAU.Equals(passWord))
                {
                    switch (user.MVAITRO) 
                    {
                        case "VT1":
                            new frmHomeAdmin(user).Show();
                            this.Hide();
                            break;
                        case "VT2":
                            new frmHomeSellStaff().Show();
                            this.Hide();
                            break;
                        case "VT3":
                            new frmHomeStaffWarehouse().Show();
                            this.Hide();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckLogin(txtUserName.Text, txtPassword.Text);
        }
    }
}
