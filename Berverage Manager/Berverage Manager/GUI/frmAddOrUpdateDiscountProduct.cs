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
    public partial class frmAddOrUpdateDiscountProduct : Form
    {
        DoiTuongKhuyenMai_BUS doiTuongKhuyenMai_BUS;
        SanPham_BUS sanPham_BUS;
        DonVi_BUS donVi_BUS;
        TonKho_BUS tonKho_BUS;
        private bool checkLoadCBSP = false;
        public frmAddOrUpdateDiscountProduct()
        {
            InitializeComponent();
            doiTuongKhuyenMai_BUS = new DoiTuongKhuyenMai_BUS();
            sanPham_BUS = new SanPham_BUS();
            donVi_BUS = new DonVi_BUS();
            tonKho_BUS = new TonKho_BUS();
        }

        private void LoadCBDoiTuongKhuyenMai()
        {
            cb_DoiTuongKH.DataSource = doiTuongKhuyenMai_BUS.LayTatCaDoiTuongKhuyenMai();
            cb_DoiTuongKH.DisplayMember = "TENDTKM";
            cb_DoiTuongKH.ValueMember = "MADTKM";
        }

        private void LoadCBSanPham()
        {
            cb_SanPham.DataSource = sanPham_BUS.LayTatCaSanPhamConTonKho(tonKho_BUS.LayTatCaTonKho());
            cb_SanPham.DisplayMember = "TENSP";
            cb_SanPham.ValueMember = "MASP";
        }

        public void LoadCBDonViTinh(List<DONVI> listDVT)
        {
            cb_DonViTinh.DataSource = listDVT;
            cb_DonViTinh.DisplayMember = "TENDV";
            cb_DonViTinh.ValueMember = "MADV";
        }

        private void LoadCBDonViTinhTheoMSP()
        {
            int maSP = int.Parse(cb_SanPham.SelectedValue.ToString());
            SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(maSP);
            LoadCBDonViTinh(donVi_BUS.LayDonViTinhCuaSanPham(sp));
        }

        private void frmAddOrUpdateDiscountProduct_Load(object sender, EventArgs e)
        {
            LoadCBDoiTuongKhuyenMai();
            LoadCBSanPham();
            checkLoadCBSP = true;
            LoadCBDonViTinhTheoMSP();
        }

        private void cb_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkLoadCBSP)
            {
                LoadCBDonViTinhTheoMSP();
            }
        }

        private int LayDongTonTaiSP()
        {
            int tongDong = KMTSP_DGV_CTKMTSP.Rows.Count;
            string maSP_CB = cb_SanPham.SelectedValue.ToString();
            for (int i = 0; i < tongDong; i++)
            {
                string giaTu_DGV = KMTSP_DGV_CTKMTSP.Rows[i].Cells[0].Value.ToString();
                string denGia_DGV = KMTSP_DGV_CTKMTSP.Rows[i].Cells[1].Value.ToString();
                string msp_DGV = KMTSP_DGV_CTKMTSP.Rows[i].Cells[2].Value.ToString();
                string dvt_DGV = KMTSP_DGV_CTKMTSP.Rows[i].Cells[4].Value.ToString();
                if (maSP_CB == msp_DGV && giaTu_DGV == txt_GiaTu.Text && denGia_DGV == txt_DenGia.Text && dvt_DGV == cb_DonViTinh.Text)
                {
                    return i;
                }
            }

            return -1;
        }

        private void ThemCTKhuyenMaiTangSP_DGV()
        {
            int row = KMTSP_DGV_CTKMTSP.Rows.Add();
            KMTSP_DGV_CTKMTSP.Rows[row].Cells[0].Value = txt_GiaTu.Text;
            KMTSP_DGV_CTKMTSP.Rows[row].Cells[1].Value = txt_DenGia.Text;
            string maSP = cb_SanPham.SelectedValue.ToString();
            KMTSP_DGV_CTKMTSP.Rows[row].Cells[2].Value = maSP;
            KMTSP_DGV_CTKMTSP.Rows[row].Cells[3].Value = cb_SanPham.Text;
            KMTSP_DGV_CTKMTSP.Rows[row].Cells[4].Value = cb_DonViTinh.Text;
            KMTSP_DGV_CTKMTSP.Rows[row].Cells[5].Value = txt_SlTang.Text;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(txt_SlTang.Text != "")
            {
                if (LayDongTonTaiSP() != -1) //San pham da ton tai trong DGV
                {
                    //Cap nhat lai so luong tang
                    int slMoi = int.Parse(txt_SlTang.Text);
                    int slHienTai = int.Parse(KMTSP_DGV_CTKMTSP.Rows[LayDongTonTaiSP()].Cells[5].Value.ToString());
                    slMoi += slHienTai;
                    KMTSP_DGV_CTKMTSP.Rows[LayDongTonTaiSP()].Cells[5].Value = slMoi.ToString();
                }
                else //San pham chua duoc them trong DGV
                {
                    ThemCTKhuyenMaiTangSP_DGV();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập số lượng!", "Thông báo");
            }
        }

        private void KMTSP_DGV_CTKMTSP_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            KMTSP_DGV_CTKMTSP.Rows[e.RowIndex].Height = 40;
        }
    }
}
