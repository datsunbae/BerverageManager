using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Berverage_Manager.DataContext;
using Berverage_Manager.BUS;
using System.IO;

namespace Berverage_Manager.GUI
{
    public partial class frmHomeAdmin : Form
    {
        ucSell sell;
        ucBill bill;
        ucProduct product;
        ucOder order;
        ucWarehouse warehouse;
        ucStaff staff;
        ucCustomer customer;
        ucSupplier supplier;
        NhanVien_BUS nhanVien_BUS;
        VaiTro_BUS vaiTro_BUS;
        TAIKHOAN taiKhoan;

        public frmHomeAdmin(TAIKHOAN user)
        {
            InitializeComponent();
            taiKhoan = user;
            sell = new ucSell();
            bill = new ucBill();
            product = new ucProduct();
            order = new ucOder();
            warehouse = new ucWarehouse();
            staff = new ucStaff();
            customer = new ucCustomer();
            supplier = new ucSupplier();
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

        private void frmHomeAdmin_Load(object sender, EventArgs e)
        {
            Panel.Controls.Add(sell);
            Panel.Controls.Add(bill);
            Panel.Controls.Add(product);
            Panel.Controls.Add(order);
            Panel.Controls.Add(warehouse);
            Panel.Controls.Add(staff);
            Panel.Controls.Add(customer);
            Panel.Controls.Add(supplier);

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

        private void btnProduct_Click(object sender, EventArgs e)
        {
            product.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            order.BringToFront();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            warehouse.BringToFront();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            staff.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            customer.BringToFront();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            supplier.BringToFront();
        }
    }
}
