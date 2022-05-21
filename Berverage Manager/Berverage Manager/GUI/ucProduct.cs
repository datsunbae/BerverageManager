using Berverage_Manager.BUS;
using Berverage_Manager.DataContext;
using Guna.UI2.WinForms;
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
    public partial class ucProduct : UserControl
    {
        public static ucProduct uc_Product;
        public Guna2DataGridView dgv_SanPham;
        public int indexRowSelected;
        SanPham_BUS sanPham_BUS;
        DonVi_BUS donVi_BUS;
        TonKho_BUS tonKho_BUS;
        List<DONVI> list_DonVi;
        public ucProduct()
        {
            InitializeComponent();
            dgvSanPham.Columns[0].Width = 50;
            dgvSanPham.Columns[9].Width = 150;

            uc_Product = this;
            dgv_SanPham = dgvSanPham;
            sanPham_BUS = new SanPham_BUS();
            donVi_BUS = new DonVi_BUS();
            tonKho_BUS = new TonKho_BUS();  
            list_DonVi = donVi_BUS.LayTatCaDonVi();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct addProduct = new frmAddProduct();
            addProduct.ShowDialog();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            frmUpdateProduct updateProduct = new frmUpdateProduct();
            updateProduct.ShowDialog();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowSelected = e.RowIndex;
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {
            FillDataDGV(sanPham_BUS.LayTatCaSanPham());
        }

        private void dgvSanPham_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvSanPham.Rows[e.RowIndex].Height = 40;
        }

        public void FillDataDGV(List<SANPHAM> listSanPham)
        {
            dgvSanPham.Rows.Clear();
            foreach (var item in listSanPham)
            {
                int RowNew = dgvSanPham.Rows.Add();
                dgvSanPham.Rows[RowNew].Cells[0].Value = item.MASP;
                dgvSanPham.Rows[RowNew].Cells[1].Value = item.TENSP;
                dgvSanPham.Rows[RowNew].Cells[2].Value = layTenDVTBangMDVT(item.DVTCHINH);
                dgvSanPham.Rows[RowNew].Cells[3].Value = item.GIANHAP_DVTC;
                dgvSanPham.Rows[RowNew].Cells[4].Value = item.GIABANSI_DVTC;
                dgvSanPham.Rows[RowNew].Cells[5].Value = item.GIABANLE_DVTC;
                dgvSanPham.Rows[RowNew].Cells[6].Value = layTenDVTBangMDVT(item.DVTPHU); 
                dgvSanPham.Rows[RowNew].Cells[7].Value = item.GIABANSI_DVTP;
                dgvSanPham.Rows[RowNew].Cells[8].Value = item.GIABANLE_DVTP;
                dgvSanPham.Rows[RowNew].Cells[9].Value = $"1 {layTenDVTBangMDVT(item.DVTCHINH)} = {item.QUIDOI} {layTenDVTBangMDVT(item.DVTPHU)}";
            }
        }

        private String layTenDVTBangMDVT(String maDVT)
        {
            foreach(var item in list_DonVi)
            {
                if(item.MADV == maDVT)
                {
                    return item.TENDV;
                }
            }
            return null;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                DataGridViewRow row = dgvSanPham.Rows[indexRowSelected];
                int maSP = int.Parse(row.Cells[0].Value.ToString());
                sanPham_BUS.XoaSanPham(maSP);
                FillDataDGV(sanPham_BUS.LayTatCaSanPham());
                ucSell.uc_BanHang.FillDataDGV(tonKho_BUS.LayTatCaSanPhamConTonKho());
                ucWarehouse.uc_TonKho.FillDataDGV(tonKho_BUS.LayTatCaTonKho());
            }
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            String tenSP = txtTimSP.Text;
            List<SANPHAM> listSP = sanPham_BUS.LayTatCaSanPham();
            List<SANPHAM> listTimSP = sanPham_BUS.TimKiemSanPham(listSP, tenSP);

            if (listTimSP.Count > 0)
            {
                FillDataDGV(listTimSP);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Sản Phẩm Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
