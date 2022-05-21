using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Berverage_Manager.BUS;
using Berverage_Manager.DataContext;

namespace Berverage_Manager.GUI.Customer
{
    public partial class frmAddCustomer : Form
    {
        KhachHang_BUS khachHang_BUS;
        public frmAddCustomer()
        {
            InitializeComponent();
            khachHang_BUS = new KhachHang_BUS();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != "")
            {
                KHACHHANG kh = new KHACHHANG();
                kh.TENKH = txtTenKH.Text;
                kh.SDTKH = txtDienThoaiKH.Text;
                kh.DIACHIKH = txtDiaChiKH.Text;
                kh.EMAILKH = txtEmailKH.Text;

                khachHang_BUS.ThemKhachHang(kh);

                ucCustomer.uc_KhachHang.FillDataDGV(khachHang_BUS.LayTatCaKhachHang());
                ucSell.uc_BanHang.LoadCBKhachHang();

                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
        }
    }
}
