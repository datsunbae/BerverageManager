using Berverage_Manager.BUS;
using Berverage_Manager.DataContext;
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
    
    public partial class frmNewPassword : Form
    {
        private string eMailNhanVien;
        private TaiKhoan_BUS taiKhoan_BUS;
        public frmNewPassword(string emailNV)
        {
            eMailNhanVien = emailNV;
            InitializeComponent();
            taiKhoan_BUS = new TaiKhoan_BUS();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string matKhauMoi = txtMatKhauMoi.Text;
            string matKhauNhapLai = txtNhapLaiMauKhau.Text;
            if (matKhauMoi == matKhauNhapLai)
            {
                TAIKHOAN tk = taiKhoan_BUS.LayTaiKhoanBangEmail(eMailNhanVien);
                tk.MATKHAU = matKhauMoi;
                taiKhoan_BUS.SuaTaiKhoan(tk);
                MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mật khẩu mới không giống nhau!", "Thông báo");
            }
        }
    }
}
