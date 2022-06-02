using Berverage_Manager.BUS;
using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berverage_Manager.GUI
{
    public partial class frmAddOrUpdateDiscountProduct : Form
    {
        private static string action_Form;
        DataGridViewRow row;
        private int indexRowSelected = -1;
        DoiTuongKhuyenMai_BUS doiTuongKhuyenMai_BUS;
        SanPham_BUS sanPham_BUS;
        DonVi_BUS donVi_BUS;
        TonKho_BUS tonKho_BUS;
        KhuyenMai_BUS khuyenMai_BUS;
        CT_KhuyenMaiTangSP_BUS CT_KhuyenMaiTangSP_BUS;
        private bool checkLoadCBSP = false;
        public frmAddOrUpdateDiscountProduct(String actionForm)
        {
            InitializeComponent();
            action_Form = actionForm;
            doiTuongKhuyenMai_BUS = new DoiTuongKhuyenMai_BUS();
            sanPham_BUS = new SanPham_BUS();
            donVi_BUS = new DonVi_BUS();
            tonKho_BUS = new TonKho_BUS();
            khuyenMai_BUS = new KhuyenMai_BUS();
            CT_KhuyenMaiTangSP_BUS = new CT_KhuyenMaiTangSP_BUS();
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
            if(cb_SanPham.Items.Count != 0)
            {
                int maSP = int.Parse(cb_SanPham.SelectedValue.ToString());
                SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(maSP);
                LoadCBDonViTinh(donVi_BUS.LayDonViTinhCuaSanPham(sp));
            }
        }

        private void LoadThongTinKM()
        {
            int rowSelectedUpdate = ucDiscount.uc_KhuyenMai.indexRowSelected;
            row = ucDiscount.uc_KhuyenMai.dgv_KhuyenMai.Rows[rowSelectedUpdate];
            KHUYENMAI km = khuyenMai_BUS.LayKhuyenMaiBangMKM(int.Parse(row.Cells[0].Value.ToString()));
            txtTenKhuyenMai.Text = km.TENKM;

            if (km.SLAPDUNG != null)
            {
                txt_Sl_Apdung.Text = km.SLAPDUNG.ToString();
            }
            else
            {
                txt_Sl_Apdung.Enabled = false;
                checkbox_SL_ApDung.Checked = true;
            }
            date_NgayBatDau.Value = km.TUNGAY.Value;
            if (km.DENNGAY != null)
            {
                date_NgayKetThuc.Value = km.DENNGAY.Value;
            }
            else
            {
                date_NgayKetThuc.Enabled = false;
                checkbox_NgayKetThuc.Checked = true;
            }
            cb_DoiTuongKH.SelectedValue = km.MADTKM;
        }

        public void FillDataDGV(List<CTKHUYENMAI_TANGSP> listCTKMTSP)
        {
            KMTSP_DGV_CTKMTSP.Rows.Clear();
            foreach (var item in listCTKMTSP)
            {
                int RowNew = KMTSP_DGV_CTKMTSP.Rows.Add();
                KMTSP_DGV_CTKMTSP.Rows[RowNew].Cells[0].Value = item.GIATU;
                if (item.DENGIA != null)
                {
                    KMTSP_DGV_CTKMTSP.Rows[RowNew].Cells[1].Value = item.DENGIA;
                }
                else
                {
                    KMTSP_DGV_CTKMTSP.Rows[RowNew].Cells[1].Value = "Không giới hạn";
                }
                KMTSP_DGV_CTKMTSP.Rows[RowNew].Cells[2].Value = item.MASP;
                KMTSP_DGV_CTKMTSP.Rows[RowNew].Cells[3].Value = sanPham_BUS.LaySanPhamBangMSP(item.MASP.Value).TENSP;
                KMTSP_DGV_CTKMTSP.Rows[RowNew].Cells[4].Value = donVi_BUS.LayTenDVTBangMaDVT(item.MADV);
                KMTSP_DGV_CTKMTSP.Rows[RowNew].Cells[5].Value = item.SLTANG;
            }
        }

        private void frmAddOrUpdateDiscountProduct_Load(object sender, EventArgs e)
        {
            LoadCBDoiTuongKhuyenMai();
            LoadCBSanPham();

            if (action_Form == "Add")
            {
                checkLoadCBSP = true;
                LoadCBDonViTinhTheoMSP();
            }
            else
            {
                panel1.Enabled = false;
                LoadThongTinKM();
                int maKM = int.Parse(row.Cells[0].Value.ToString());
                FillDataDGV(CT_KhuyenMaiTangSP_BUS.LayDanhSachCTKhuyenMaiBangMKM(maKM));
            }
            
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
            if (txt_GiaTu.Text != "" && txt_SlTang.Text != "")
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
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
            }
        }

        private void KMTSP_DGV_CTKMTSP_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            KMTSP_DGV_CTKMTSP.Rows[e.RowIndex].Height = 40;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

            if (action_Form == "Add")
            {
                if (KMTSP_DGV_CTKMTSP.Rows.Count > 0)
                {
                    //Them khuyen mai vao CSDL
                    KHUYENMAI km = new KHUYENMAI();
                    km.TENKM = txtTenKhuyenMai.Text;
                    if (checkbox_SL_ApDung.Checked != true)
                    {
                        km.SLAPDUNG = int.Parse(txt_Sl_Apdung.Text);
                        km.SLAPDUNGCONLAI = int.Parse(txt_Sl_Apdung.Text);
                    }
                    km.TUNGAY = date_NgayBatDau.Value.Date;
                    if (checkbox_NgayKetThuc.Checked != true)
                    {
                        km.DENNGAY = date_NgayKetThuc.Value.Date;
                    }
                    km.TRANGTHAI = true;
                    km.MAHTKM = 2; // ma = 2 : khuyen mai tang sp
                    km.MADTKM = int.Parse(cb_DoiTuongKH.SelectedValue.ToString());
                    khuyenMai_BUS.ThemKhuyenMai(km);

                    int tongDong = KMTSP_DGV_CTKMTSP.Rows.Count;
                    //Them CT Khuyen mai tang SP vao CSDL
                    CTKHUYENMAI_TANGSP ct_KMTSP = new CTKHUYENMAI_TANGSP();
                    for (int i = 0; i < tongDong; i++)
                    {
                        ct_KMTSP.MAKM = km.MAKM;
                        ct_KMTSP.MASP = int.Parse(KMTSP_DGV_CTKMTSP.Rows[i].Cells[2].Value.ToString());
                        ct_KMTSP.MADV = donVi_BUS.LayMaDVTBangTenDVT(KMTSP_DGV_CTKMTSP.Rows[i].Cells[4].Value.ToString());
                        ct_KMTSP.SLTANG = int.Parse(KMTSP_DGV_CTKMTSP.Rows[i].Cells[5].Value.ToString());
                        ct_KMTSP.GIATU = double.Parse(KMTSP_DGV_CTKMTSP.Rows[i].Cells[0].Value.ToString());
                        if (KMTSP_DGV_CTKMTSP.Rows[i].Cells[1].Value.ToString() != "")
                        {
                            ct_KMTSP.DENGIA = double.Parse(KMTSP_DGV_CTKMTSP.Rows[i].Cells[1].Value.ToString());
                        }
                        CT_KhuyenMaiTangSP_BUS.ThemCT_KhuyenMaiTangSP(ct_KMTSP);
                    }

                    ucDiscount.uc_KhuyenMai.FillDataDGV(khuyenMai_BUS.LayTatCaKhuyenMai());
                    this.Close();
                    MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn chưa thêm khuyến mãi!", "Thông báo");
                }
            }
            else
            {
                //Sua khuyen mai vao CSDL
                KHUYENMAI km = khuyenMai_BUS.LayKhuyenMaiBangMKM(int.Parse(row.Cells[0].Value.ToString()));
                km.TENKM = txtTenKhuyenMai.Text;
                if (checkbox_SL_ApDung.Checked != true)
                {
                    int slPhieuDaDung = km.SLAPDUNG.Value - km.SLAPDUNGCONLAI.Value;
                    km.SLAPDUNG = int.Parse(txt_Sl_Apdung.Text);
                    km.SLAPDUNGCONLAI = int.Parse(txt_Sl_Apdung.Text) - slPhieuDaDung;
                }
                km.TUNGAY = date_NgayBatDau.Value.Date;
                if (checkbox_NgayKetThuc.Checked != true)
                {
                    km.DENNGAY = date_NgayKetThuc.Value.Date;
                }
                km.MAHTKM = 2; // ma = 2 : khuyen mai tang sp
                km.MADTKM = int.Parse(cb_DoiTuongKH.SelectedValue.ToString());
                khuyenMai_BUS.SuaKhuyenMai(km);

                ucDiscount.uc_KhuyenMai.FillDataDGV(khuyenMai_BUS.LayTatCaKhuyenMai());
                ucDiscount.uc_KhuyenMai.CapNhatTrangThaiKM();
                this.Close();
                MessageBox.Show("Sửa khuyến mãi thành công!", "Thông báo");
            }
        }


        private void btn_Go_Click(object sender, EventArgs e)
        {
            if(indexRowSelected >= 0)
            {
                KMTSP_DGV_CTKMTSP.Rows.RemoveAt(indexRowSelected);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiết khuyến mãi cần xóa!", "Thông báo");
            }
        }

        private void checkbox_NgayKetThuc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_NgayKetThuc.Checked)
            {
                date_NgayKetThuc.Enabled = false;
            }
            else
            {
                date_NgayKetThuc.Enabled = true;
            }
        }

        private void checkbox_SL_ApDung_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_SL_ApDung.Checked)
            {
                txt_Sl_Apdung.Enabled = false;
            }
            else
            {
                txt_Sl_Apdung.Enabled = true;
            }
        }

        private void KMTSP_DGV_CTKMTSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowSelected = e.RowIndex;
        }
    }
}
