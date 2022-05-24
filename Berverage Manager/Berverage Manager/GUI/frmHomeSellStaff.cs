using Berverage_Manager.BUS;
using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berverage_Manager.GUI
{
    public partial class frmHomeSellStaff : Form
    {
        ucSell sell;
        ucBill bill;
        ucProduct product;
        ucCustomer customer;
        NhanVien_BUS nhanVien_BUS;
        VaiTro_BUS vaiTro_BUS;
        TAIKHOAN taiKhoan;
        public frmHomeSellStaff(TAIKHOAN user)
        {
            InitializeComponent();
            taiKhoan = user;
            sell = new ucSell();
            bill = new ucBill();
            product = new ucProduct();
            customer = new ucCustomer();
            nhanVien_BUS = new NhanVien_BUS();
            vaiTro_BUS = new VaiTro_BUS();
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
                this.Hide();
            }
        }

        private void frmHomeSellStaff_Load(object sender, EventArgs e)
        {
            Panel.Controls.Add(sell);
            Panel.Controls.Add(bill);
            Panel.Controls.Add(product);
            Panel.Controls.Add(customer);

            NHANVIEN nv = nhanVien_BUS.LayNhanVienBangMaTaiKhoan(taiKhoan.MADANGNHAP);
            MemoryStream memoryStream = new MemoryStream(nv.HINHANHNV.ToArray());
            Image img = Image.FromStream(memoryStream);
            PB_ImgStaff.Image = img;
            LB_Ten.Text = "Chào, " + nv.TENNV.ToUpper();
            LB_VaiTro.Text = vaiTro_BUS.LayTenVaiTroBangMVT(taiKhoan.MVAITRO).TENVAITRO;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            sell.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            bill.BringToFront();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            customer.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            product.BringToFront();
        }
    }
}
