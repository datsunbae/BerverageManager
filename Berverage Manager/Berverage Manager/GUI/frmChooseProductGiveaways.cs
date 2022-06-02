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
using Berverage_Manager.BUS;

namespace Berverage_Manager.GUI
{
    public partial class frmChooseProductGiveaways : Form
    {
        public static frmChooseProductGiveaways frmChonSanPhamTang;
        private static int maKhuyenMai;
        CT_KhuyenMaiTangSP_BUS cT_KhuyenMaiTangSP_BUS;
        SanPham_BUS sanPham_BUS;
        DonVi_BUS donVi_BUS;
        int indexRowSelected;
        public double gia;
        public string donViTinh;
        public int soLuongTang;
        public frmChooseProductGiveaways(int maKM)
        {
            InitializeComponent();
            maKhuyenMai = maKM;
            frmChonSanPhamTang = this;
            cT_KhuyenMaiTangSP_BUS = new CT_KhuyenMaiTangSP_BUS();
            sanPham_BUS = new SanPham_BUS();
            donVi_BUS = new DonVi_BUS();
        }

        private void CSPT_BTN_QuayLai_Click(object sender, EventArgs e)
        {
            frmSellDiscount.frm_KhuyenMaiBanHang.Visible = true;
            this.Hide();
        }

        public void FillDataDGV(List<CTKHUYENMAI_TANGSP> listCTKMTSP)
        {
            CSPT_DGV_DSSPT.Rows.Clear();
            foreach (var item in listCTKMTSP)
            {
                int RowNew = CSPT_DGV_DSSPT.Rows.Add();
                CSPT_DGV_DSSPT.Rows[RowNew].Cells[0].Value = item.MASP;
                CSPT_DGV_DSSPT.Rows[RowNew].Cells[1].Value = sanPham_BUS.LaySanPhamBangMSP(item.MASP.Value).TENSP;
                CSPT_DGV_DSSPT.Rows[RowNew].Cells[2].Value = item.SLTANG;
                CSPT_DGV_DSSPT.Rows[RowNew].Cells[3].Value = donVi_BUS.LayTenDVTBangMaDVT(item.MADV);
            }
        }

        private void CSPT_DGV_DSSPT_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CSPT_DGV_DSSPT.Rows[e.RowIndex].Height = 40;
        }

        private void frmChooseProductGiveaways_Load(object sender, EventArgs e)
        {
            FillDataDGV(cT_KhuyenMaiTangSP_BUS.LayDanhSachCTKhuyenMaiTangSPThoaDK(maKhuyenMai, ucSell.uc_BanHang.tongTien));
        }

        private bool KiemTraLoaiDonViTinh(String tenDVT)
        {
            List<DONVI> list_DVT  = donVi_BUS.LayTatCaDonVi();
            foreach (var item in list_DVT)
            {
                if (item.TENDV == tenDVT && item.DVTC == true)
                {
                    return true; // true : La don vi tinh chinh
                }
            }

            return false; // false : La don vi tinh phu
        }

        private double LayDonGiaThoaDK(SANPHAM sp, String dvt)
        {
            if (ucSell.uc_BanHang.cb_HinhThucBanValue == 0) //ban le
            {
                if (KiemTraLoaiDonViTinh(dvt))
                {
                    return sp.GIABANLE_DVTC.Value;
                }
                else
                {
                    return sp.GIABANLE_DVTP.Value;
                }
            }
            else //ban si
            {
                if (KiemTraLoaiDonViTinh(dvt))
                {
                    return sp.GIABANSI_DVTC.Value;
                }
                else
                {
                    return sp.GIABANSI_DVTP.Value;
                }
            }
        }

        private void CSPT_BTN_ApDung_Click(object sender, EventArgs e)
        {
            if(indexRowSelected >= 0)
            {
                SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(int.Parse(CSPT_DGV_DSSPT.Rows[indexRowSelected].Cells[0].Value.ToString()));
                int row = ucSell.uc_BanHang.dgv_CTHD.Rows.Add();
                ucSell.uc_BanHang.dgv_CTHD.Rows[row].Cells[0].Value = CSPT_DGV_DSSPT.Rows[indexRowSelected].Cells[0].Value;
                ucSell.uc_BanHang.dgv_CTHD.Rows[row].Cells[1].Value = CSPT_DGV_DSSPT.Rows[indexRowSelected].Cells[1].Value;
                String tenDVT = CSPT_DGV_DSSPT.Rows[indexRowSelected].Cells[3].Value.ToString();
                ucSell.uc_BanHang.dgv_CTHD.Rows[row].Cells[2].Value = LayDonGiaThoaDK(sp, tenDVT);
                gia = LayDonGiaThoaDK(sp, tenDVT);
                ucSell.uc_BanHang.dgv_CTHD.Rows[row].Cells[3].Value = tenDVT;
                donViTinh = tenDVT;
                ucSell.uc_BanHang.dgv_CTHD.Rows[row].Cells[4].Value = CSPT_DGV_DSSPT.Rows[indexRowSelected].Cells[2].Value;
                soLuongTang = int.Parse(CSPT_DGV_DSSPT.Rows[indexRowSelected].Cells[2].Value.ToString());
                ucSell.uc_BanHang.dgv_CTHD.Rows[row].Cells[5].Value = 0;
                MessageBox.Show("Đã thêm sản phẩm tặng vào đơn hàng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            
        }

        private void CSPT_DGV_DSSPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowSelected = e.RowIndex;
        }
    }
}
