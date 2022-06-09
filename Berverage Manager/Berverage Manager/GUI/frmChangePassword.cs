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
    public partial class frmChangePassword : Form
    {
        int vaiTro;
        TaiKhoan_BUS taiKhoan_BUS;
        NHANVIEN nhanVien;
        public frmChangePassword()
        {
            InitializeComponent();
            taiKhoan_BUS = new TaiKhoan_BUS();
            vaiTro = frmLogin.frm_Login.vaiTro;
            getNhanVienTheoVaiTro();
        }

        private void getNhanVienTheoVaiTro()
        {
            switch (vaiTro)
            {
                case 1:
                    nhanVien = frmHomeAdmin.frm_HomeAdmin.nhanVien;
                    break;
                case 2:
                    nhanVien = frmHomeSellStaff.frm_HomeSellStaff.nhanVien;
                    break;
                case 3:
                    nhanVien = frmHomeStaffWarehouse.frm_HomeStaffWarehouse.nhanVien;
                    break;
            }
        }

        private void BTN_Luu_Click(object sender, EventArgs e)
        {
            TAIKHOAN taiKhoan = taiKhoan_BUS.LayTaiKhoanBangMTK(nhanVien.MATK);
            string matKhauHienTai = taiKhoan.MATKHAU;
            if(matKhauHienTai == TXT_MatKhauHienTai.Text)
            {
                if(TXT_MatKhauMoi.Text == TXT_NhapLaiMatKhauMoi.Text)
                {
                    taiKhoan.MATKHAU = TXT_MatKhauMoi.Text;
                    taiKhoan_BUS.SuaTaiKhoan(taiKhoan);
                    MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không giống nhau!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!", "Thông báo");
            }

        }
    }
}
