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
                if(NV_CB_GioiTinh.SelectedIndex == 0)
                {
                    kh.GIOITINH = true;
                }
                else
                {
                    kh.GIOITINH = false;
                }
                kh.SDTKH = txtDienThoaiKH.Text;
                kh.DIACHIKH = txtDiaChiKH.Text;
                kh.EMAILKH = txtEmailKH.Text;
                kh.LOAIKH = true;

                khachHang_BUS.ThemKhachHang(kh);

                ucCustomer.uc_KhachHang.FillDataDGV(khachHang_BUS.LayTatCaKhachHang());
                ucSell.uc_BanHang.LoadCBKhachHang();
                ucSell.uc_BanHang.comboBox_HinhThucBan.SelectedIndex = 1;
                int indexKH = ucSell.uc_BanHang.comboBox_KhachHang.FindString(kh.TENKH);
                ucSell.uc_BanHang.comboBox_KhachHang.SelectedIndex = indexKH;

                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
        }
    }
}
