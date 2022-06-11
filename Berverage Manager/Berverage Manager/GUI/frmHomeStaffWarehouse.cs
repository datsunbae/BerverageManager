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
    public partial class frmHomeStaffWarehouse : Form
    {
        public static frmHomeStaffWarehouse frm_HomeStaffWarehouse;
        ucProduct product;
        ucOder order;
        ucWarehouse warehouse;
        ucSupplier supplier;
        NhanVien_BUS nhanVien_BUS;
        VaiTro_BUS vaiTro_BUS;
        TAIKHOAN taiKhoan;
        public NHANVIEN nhanVien;
        public frmHomeStaffWarehouse(TAIKHOAN user)
        {
            InitializeComponent();
            frm_HomeStaffWarehouse = this;
            taiKhoan = user;
            product = new ucProduct();
            order = new ucOder();
            warehouse = new ucWarehouse();
            supplier = new ucSupplier();
            nhanVien_BUS = new NhanVien_BUS();
            vaiTro_BUS = new VaiTro_BUS();
            nhanVien = nhanVien_BUS.LayNhanVienBangMaTaiKhoan(user.MADANGNHAP);
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
        }

        public void LoadThongTinNhanVien()
        {
            if(nhanVien.HINHANHNV != null)
            {
                MemoryStream memoryStream = new MemoryStream(nhanVien.HINHANHNV.ToArray());
                Image img = Image.FromStream(memoryStream);
                PB_ImgStaff.Image = img;
            }
            LB_Ten.Text = "Chào, " + nhanVien.TENNV.ToUpper();
            LB_VaiTro.Text = vaiTro_BUS.LayTenVaiTroBangMVT(taiKhoan.MVAITRO).TENVAITRO;
        }

        private void frmHomeStaffWarehouse_Load(object sender, EventArgs e)
        {
            Panel.Controls.Add(product);
            Panel.Controls.Add(order);
            Panel.Controls.Add(warehouse);
            Panel.Controls.Add(supplier);
            LoadThongTinNhanVien();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            supplier.BringToFront();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            warehouse.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            order.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            product.BringToFront();
        }

        private void LB_CaiDat_Click(object sender, EventArgs e)
        {
            new frmChooseChangePwOrChangeInfo().Show();
        }

        private void BTN_CaiDat_Click(object sender, EventArgs e)
        {
            new frmChooseChangePwOrChangeInfo().Show();
        }
    }
}
