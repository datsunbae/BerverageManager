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
    public partial class frmAddProduct : Form
    {
        SanPham_BUS sanPham_BUS;
        DonVi_BUS donVi_BUS;
        public frmAddProduct()
        {
            InitializeComponent();
            sanPham_BUS = new SanPham_BUS();
            donVi_BUS = new DonVi_BUS();
        }

        private void LoadCB()
        {
            cbDVTChinh.DataSource = donVi_BUS.LayTatCaDonViChinh();
            cbDVTChinh.DisplayMember = "TENDV";
            cbDVTChinh.ValueMember = "MADV";

            cbDVTPhu.DataSource = donVi_BUS.LayTatCaDonViPhu();
            cbDVTPhu.DisplayMember = "TENDV";
            cbDVTPhu.ValueMember = "MADV";
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            LoadCB();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != "")
            {
                SANPHAM sp = new SANPHAM();
                sp.TENSP = txtTenSP.Text;
                sp.DVTCHINH = cbDVTChinh.SelectedValue.ToString();
                sp.GIANHAP_DVTC = Double.Parse(txtGiaNhap_DVTC.Text);
                sp.GIABANSI_DVTC = Double.Parse(txtGiaBanSi_DVTC.Text);
                sp.GIABANLE_DVTC = Double.Parse(txtGiaBanLe_DVTC.Text);
                sp.DVTPHU = cbDVTPhu.SelectedValue.ToString();
                sp.GIABANSI_DVTP = Double.Parse(txtGiaBanSi_DVTP.Text);
                sp.GIABANLE_DVTP = Double.Parse(txtGiaBanLe_DVTP.Text);
                sp.QUIDOI = int.Parse(txtQuyDoi.Text);

                sanPham_BUS.ThemSanPham(sp);
                ucProduct.uc_Product.FillDataDGV(sanPham_BUS.LayTatCaSanPham());
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
        }

    }
}
