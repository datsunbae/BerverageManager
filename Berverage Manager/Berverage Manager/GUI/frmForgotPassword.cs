using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Berverage_Manager.BUS;

namespace Berverage_Manager.GUI
{
    public partial class frmForgotPassword : Form
    {
        TaiKhoan_BUS taiKhoan_BUS;
        public frmForgotPassword()
        {
            InitializeComponent();
            taiKhoan_BUS = new TaiKhoan_BUS();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            var account = taiKhoan_BUS.LayTaiKhoanBangEmail(txtTaiKhoan_Email.Text);

            if(account != null)
            {
                string emailShop = "nhom3.dacs.hutech@gmail.com";
                string passWordShop = "ruasbfuaoacvrejn";
                string emailNhanVien = txtTaiKhoan_Email.Text;
                MailMessage mailMessage = new MailMessage(emailShop, emailNhanVien);
                Random r = new Random();
                int maXacNhan = r.Next(10000, 99999);
                mailMessage.Subject = "[NHOM3_DACS_DOUBLED] Mã xác minh tài khoản của bạn";
                mailMessage.Body = "Mã xác minh của bạn là: " + maXacNhan;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    System.Net.NetworkCredential nc = new NetworkCredential(emailShop, passWordShop);
                    smtp.Credentials = nc;
                    smtp.EnableSsl = true;
                    smtp.Send(mailMessage);
                }
                this.Hide();
                frmConfirmCode frmConfirmCode = new frmConfirmCode(emailNhanVien, maXacNhan);
                frmConfirmCode.Show();
            }
            else
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo");
            }

            
        }
    }
}
