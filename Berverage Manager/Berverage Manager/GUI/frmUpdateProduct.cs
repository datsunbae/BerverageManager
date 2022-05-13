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
    public partial class frmUpdateProduct : Form
    {
        DataGridViewRow row;
        SanPham_BUS sanPham_BUS;
        DonVi_BUS donVi_BUS;
        public frmUpdateProduct()
        {
            InitializeComponent();
            sanPham_BUS = new SanPham_BUS(); 
            donVi_BUS = new DonVi_BUS();
        }
        public void LoadCB()
        {
            cbDVTChinh.DataSource = donVi_BUS.LayTatCaDonViChinh();
            cbDVTChinh.DisplayMember = "TENDV";
            cbDVTChinh.ValueMember = "MADV";

            cbDVTPhu.DataSource = donVi_BUS.LayTatCaDonViPhu();
            cbDVTPhu.DisplayMember = "TENDV";
            cbDVTPhu.ValueMember = "MADV";
        }

        private void LoadThongTinSP()
        {
            int rowSelectedUpdate = ucProduct.uc_Product.indexRowSelected;
            row = ucProduct.uc_Product.dgv_SanPham.Rows[rowSelectedUpdate];
            txtTenSP.Text = row.Cells[1].Value.ToString();
            int indexDVTC = cbDVTChinh.FindString(row.Cells[2].Value.ToString());
            cbDVTChinh.SelectedIndex = indexDVTC;
            txtGiaNhap_DVTC.Text = row.Cells[3].Value.ToString();
            txtGiaBanSi_DVTC.Text = row.Cells[4].Value.ToString();
            txtGiaBanLe_DVTC.Text = row.Cells[5].Value.ToString();
            int indexDVTP = cbDVTPhu.FindString(row.Cells[6].Value.ToString());
            cbDVTPhu.SelectedIndex = indexDVTP;
            txtGiaBanSi_DVTP.Text = row.Cells[7].Value.ToString();
            txtGiaBanLe_DVTP.Text = row.Cells[8].Value.ToString();
            SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(int.Parse(row.Cells[0].Value.ToString()));
            txtQuyDoi.Text = sp.QUIDOI.ToString();
            lb_QuyDoi.Text = 1 + " " + row.Cells[2].Value.ToString().ToUpper() + " =";
        }

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            LoadCB();
            LoadThongTinSP();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(row.Cells[0].Value.ToString());
            SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(maSP);
            if (sp != null)
            {
                sp.TENSP = txtTenSP.Text;
                sp.DVTCHINH = cbDVTChinh.SelectedValue.ToString();
                sp.GIANHAP_DVTC = double.Parse(txtGiaNhap_DVTC.Text);
                sp.GIABANSI_DVTC = double.Parse(txtGiaBanSi_DVTC.Text);
                sp.GIABANLE_DVTC = double.Parse(txtGiaBanLe_DVTC.Text);
                sp.DVTPHU = cbDVTPhu.SelectedValue.ToString();
                sp.GIABANSI_DVTP = double.Parse(txtGiaBanSi_DVTP.Text);
                sp.GIABANLE_DVTP = double.Parse(txtGiaBanLe_DVTP.Text);
                sp.QUIDOI = int.Parse(txtQuyDoi.Text);
                sanPham_BUS.SuaSanPham(sp);

                ucProduct.uc_Product.FillDataDGV(sanPham_BUS.LayTatCaSanPham());

                //ucBanHang.bh.LoadNV();

                //List<NHAPKHO> listnk = dBQuanLyBanNGK.NHAPKHOes.ToList();
                //ucNhapKho.nk.FillDataDGV(listnk);

                //List<DONHANG> listdh = dBQuanLyBanNGK.DONHANGs.ToList();
                //ucDonHang.dh.FillDataDGV(listdh);

                this.Close();
            }
        }

        private void cbDVTChinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_QuyDoi.Text = 1 + " " + cbDVTChinh.Text.ToUpper() + " =";
            
        }
    }
}
