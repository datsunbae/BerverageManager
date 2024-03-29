﻿using Berverage_Manager.BUS;
using Berverage_Manager.DataContext;
using Berverage_Manager.DTO;
using Berverage_Manager.GUI.Customer;
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
    public partial class ucSell : UserControl
    {
        public static ucSell uc_BanHang;
        public Guna2DataGridView dgv_CTHD;
        public Guna2TextBox textBox_ChietKhau;
        public Guna2TextBox textBox_CanThanhToan;
        public Guna2ComboBox comboBox_HinhThucBan;
        public Guna2ComboBox comboBox_KhachHang;
        public Guna2ComboBox comboBox_NhanVien;

        private TonKho_BUS tonKho_BUS;
        private SanPham_BUS sanPham_BUS;
        private KhachHang_BUS khachHang_BUS;
        private NhanVien_BUS nhanVien_BUS;
        private DonVi_BUS donVi_BUS;
        private DonHang_BUS donHang_BUS;
        private CT_DonHang_BUS ct_DonHang_BUS;
        private KhuyenMai_BUS khuyenMai_BUS;
        private List<DONVI> list_DVT;
        private int indexRowSelected = -1;
        private int indexSelected_DGVCTHD = -1;
        public double tongTien;
        public int cb_HinhThucBanValue;
        int vaiTro;
        NHANVIEN nhanVien;

        //REPORT
        public Guna2ComboBox cb_NhanVien;
        public Guna2ComboBox cb_KhachHang;
        public Guna2DateTimePicker date_NgayTao;
        public Guna2TextBox txt_TongTien;
        public Guna2TextBox txt_TienKhachDua;
        public Guna2TextBox txt_TienThua;

        public List<HOADON_REPORT> ListCTHD_XuatReport()
        {
            int tongDong = BH_DGV_CTHD.Rows.Count;

            List<HOADON_REPORT> listCTHD_Report = new List<HOADON_REPORT>();
            HOADON_REPORT reportHD;

            for (int i = 0; i < tongDong; i++)
            {
                reportHD = new HOADON_REPORT();
                reportHD.TenSP = BH_DGV_CTHD.Rows[i].Cells[1].Value.ToString();
                reportHD.DonGia = double.Parse(BH_DGV_CTHD.Rows[i].Cells[2].Value.ToString());
                reportHD.TenDVT = BH_DGV_CTHD.Rows[i].Cells[3].Value.ToString();
                reportHD.SL = int.Parse(BH_DGV_CTHD.Rows[i].Cells[4].Value.ToString());
                reportHD.ThanhTien = double.Parse(BH_DGV_CTHD.Rows[i].Cells[5].Value.ToString());
                listCTHD_Report.Add(reportHD);
            }

            return listCTHD_Report;
        }

        //END REPORT

        public ucSell()
        {
            InitializeComponent();
            BH_DGV_CTHD.Columns[2].Width = 100;
            BH_DGV_CTHD.Columns[3].Width = 80;
            BH_DGV_CTHD.Columns[4].Width = 40;
            BH_DGV_CTHD.Columns[5].Width = 150;

            uc_BanHang = this;
            dgv_CTHD = BH_DGV_CTHD;
            textBox_ChietKhau = BH_TXT_ChietKhau;
            textBox_CanThanhToan = BH_TXT_TTCanThanhToan;
            comboBox_HinhThucBan = BH_CB_HTBan;
            comboBox_KhachHang = BH_CB_KH;
            comboBox_NhanVien = BH_CB_NV;
            cb_HinhThucBanValue = BH_CB_HTBan.SelectedIndex;
            tonKho_BUS = new TonKho_BUS();
            sanPham_BUS = new SanPham_BUS();
            khachHang_BUS = new KhachHang_BUS();
            nhanVien_BUS = new NhanVien_BUS();
            donVi_BUS = new DonVi_BUS();
            donHang_BUS = new DonHang_BUS();
            ct_DonHang_BUS = new CT_DonHang_BUS();
            khuyenMai_BUS = new KhuyenMai_BUS();
            list_DVT = donVi_BUS.LayTatCaDonVi();
            
        }

        public void FillDataDGV(List<TonKho_DTO> listTonKho)
        {

            BH_DGV_DSSP.Rows.Clear();
            foreach (var item in listTonKho)
            {
                int RowNew = BH_DGV_DSSP.Rows.Add();
                BH_DGV_DSSP.Rows[RowNew].Cells[0].Value = item.IDSP;
                BH_DGV_DSSP.Rows[RowNew].Cells[1].Value = sanPham_BUS.LaySanPhamBangMSP(item.IDSP).TENSP;
                BH_DGV_DSSP.Rows[RowNew].Cells[2].Value = item.SLTON;
                BH_DGV_DSSP.Rows[RowNew].Cells[3].Value = item.SLTONQUIDOI;
            }
        }

        public void LoadCBKhachHang()
        {
            if (BH_CB_HTBan.SelectedIndex == 0) // Khach le
            {
                BH_CB_KH.DataSource = khachHang_BUS.LayKhachLe();
                BH_CB_KH.DisplayMember = "TENKH";
                BH_CB_KH.ValueMember = "MAKH";
            }
            else // Khach si
            {
                BH_CB_KH.DataSource = khachHang_BUS.LayTatCaKhachSi();
                BH_CB_KH.DisplayMember = "TENKH";
                BH_CB_KH.ValueMember = "MAKH";
            }
        }

        public void LoadCBNhanVien()
        {
            BH_CB_NV.DataSource = nhanVien_BUS.LayTatCaNhanVien();
            BH_CB_NV.ValueMember = "MANV";
            BH_CB_NV.DisplayMember = "TENNV";
            
        }

        public void LoadCBDonViTinh(List<DONVI> listDVT)
        {
            BH_CB_DVTinh.DataSource = listDVT;
            BH_CB_DVTinh.DisplayMember = "TENDV";
            BH_CB_DVTinh.ValueMember = "MADV";
        }

        private void RefreshForm()
        {
            FillDataDGV(tonKho_BUS.LayTatCaSanPhamConTonKho());
            BH_DGV_CTHD.Rows.Clear();
            BH_TXT_TENSP.Text = "";
            BH_TXT_GIATIEN.Text = "";
            BH_TXT_SL.Text = "";
            BH_TXT_TTCanThanhToan.Text = "";
            BH_TXT_KhachDua.Text = "";
            BH_TXT_TienThua.Text = "";
            BH_TXT_ChietKhau.Text = "0";
            BH_TXT_TongTien.Text = "0";
            BH_CB_HTBan.Enabled = true;
            BH_BTN_XOASPCT.Enabled = true;
        }

        private void getNhanVienTheoVaiTro()
        {
            switch (vaiTro)
            {
                case 1:
                    nhanVien = frmHomeAdmin.frm_HomeAdmin.nhanVien;
                    break;
                case 2:
                    nhanVien = frmHomeSellStaff.frm_HomeSellStaff.nhanVien;
                    break;
                case 3:
                    nhanVien = frmHomeStaffWarehouse.frm_HomeStaffWarehouse.nhanVien;
                    break;
            }
        }

        private void ucSell_Load(object sender, EventArgs e)
        {
            BH_CB_HTBan.SelectedIndex = 0; //set Hinh thuc ban: Khach le
            LoadCBKhachHang();
            LoadCBNhanVien();
            FillDataDGV(tonKho_BUS.LayTatCaSanPhamConTonKho());
            BH_DATE_TTOAN.Value = DateTime.Now;
            vaiTro = frmLogin.frm_Login.vaiTro;
            getNhanVienTheoVaiTro();

            int indexCBNhanVien = BH_CB_NV.FindString(nhanVien.TENNV);
            BH_CB_NV.SelectedIndex = indexCBNhanVien;
        }

        private void BH_DGV_DSSP_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            BH_DGV_DSSP.Rows[e.RowIndex].Height = 40;
        }

        private void BH_DGV_CTHD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            BH_DGV_CTHD.Rows[e.RowIndex].Height = 40;
        }

        private void BH_CB_HTBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCBKhachHang();
            if (indexRowSelected != -1)
            {
                int maSP = int.Parse(BH_DGV_DSSP.Rows[indexRowSelected].Cells[0].Value.ToString());
                SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(maSP);
                EventDGV_DSSanPham(sp);
            }
            cb_HinhThucBanValue = BH_CB_HTBan.SelectedIndex;
        }

        private void BH_DGV_DSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowSelected = e.RowIndex;
            if(indexRowSelected != -1)
            {
                int maSP = int.Parse(BH_DGV_DSSP.Rows[indexRowSelected].Cells[0].Value.ToString());
                SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(maSP);
                LoadCBDonViTinh(donVi_BUS.LayDonViTinhCuaSanPham(sp));
                EventDGV_DSSanPham(sp);
            }

        }

        private void BH_DGV_CTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexSelected_DGVCTHD = e.RowIndex;
        }

        private void BH_CB_DVTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (indexRowSelected != -1)
            {
                int maSP = int.Parse(BH_DGV_DSSP.Rows[indexRowSelected].Cells[0].Value.ToString());
                SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(maSP);
                EventDGV_DSSanPham(sp);
            }
        }

        private void EventDGV_DSSanPham(SANPHAM sp)
        {
            if (indexRowSelected != -1)
            {
                BH_TXT_TENSP.Text = BH_DGV_DSSP.Rows[indexRowSelected].Cells[1].Value.ToString();
                if (BH_CB_HTBan.SelectedIndex == 0)
                {
                    if (KiemTraLoaiDonViTinh(BH_CB_DVTinh.Text))
                    {
                        BH_TXT_GIATIEN.Text = sp.GIABANLE_DVTC.ToString();
                    }
                    else
                    {
                        BH_TXT_GIATIEN.Text = sp.GIABANLE_DVTP.ToString();
                    }
                }
                else
                {
                    if (KiemTraLoaiDonViTinh(BH_CB_DVTinh.Text))
                    {
                        BH_TXT_GIATIEN.Text = sp.GIABANSI_DVTC.ToString();
                    }
                    else
                    {
                        BH_TXT_GIATIEN.Text = sp.GIABANSI_DVTP.ToString();
                    }
                }
            }
        }

        private bool KiemTraLoaiDonViTinh(String tenDVT)
        {
            foreach(var item in list_DVT)
            {
                if(item.TENDV == tenDVT && item.DVTC == true)
                {
                    return true; // true : La don vi tinh chinh
                }
            }

            return false; // false : La don vi tinh phu
        }

        private int kiemTraDongTonTaiSPTrongHD(int maSP, String tenDVT)
        {
            int idSP;
            String dvt;
            int tongDong = BH_DGV_CTHD.RowCount;
            for (int i = 0; i < tongDong; i++)
            {
                idSP = int.Parse(BH_DGV_CTHD.Rows[i].Cells[0].Value.ToString());
                dvt = BH_DGV_CTHD.Rows[i].Cells[3].Value.ToString();
                if (idSP == maSP && dvt == tenDVT)
                {
                    return i;
                }
            }
            return -1;
        }

        private String tinhTonKhoQuyDoi(String tenDVTChinh, String tenDVTPhu, int slTonKho, int slDVTPhuQuyDoi)
        {
            int sl_dvtc = slTonKho / slDVTPhuQuyDoi;
            int sl_dvtp = 0;
            if (slTonKho % slDVTPhuQuyDoi != 0)
            {
                sl_dvtp = slTonKho - sl_dvtc * slDVTPhuQuyDoi;
            }
            return sl_dvtc + " " + tenDVTChinh + " " + sl_dvtp + " " + tenDVTPhu;
        }

        private void ThemSPVaoDGV_CTHD(int maSP)
        {
            
            int slDVT = int.Parse(BH_TXT_SL.Text);
            double giaTien = double.Parse(BH_TXT_GIATIEN.Text);
            String tenDVT = BH_CB_DVTinh.Text;

            if (kiemTraDongTonTaiSPTrongHD(maSP, tenDVT) != -1) // Trung
            {
                int soDongTonTai = kiemTraDongTonTaiSPTrongHD(maSP, tenDVT);
                int sl = int.Parse(BH_DGV_CTHD.Rows[soDongTonTai].Cells[4].Value.ToString());
                double giaTienCapNhat = giaTien * (sl + slDVT);
                BH_DGV_CTHD.Rows[soDongTonTai].Cells[4].Value = sl + slDVT;
                BH_DGV_CTHD.Rows[soDongTonTai].Cells[5].Value = giaTienCapNhat;
            }
            else // Khong trung
            {
                int row = BH_DGV_CTHD.Rows.Add();
                BH_DGV_CTHD.Rows[row].Cells[0].Value = maSP;
                BH_DGV_CTHD.Rows[row].Cells[1].Value = BH_TXT_TENSP.Text;
                BH_DGV_CTHD.Rows[row].Cells[2].Value = giaTien;
                BH_DGV_CTHD.Rows[row].Cells[3].Value = tenDVT;
                BH_DGV_CTHD.Rows[row].Cells[4].Value = slDVT;
                BH_DGV_CTHD.Rows[row].Cells[5].Value = giaTien * slDVT;
            }

        }

        private void BH_BTN_THEMVAOHD_Click(object sender, EventArgs e)
        {
            if(indexRowSelected != -1 && BH_TXT_SL.Text != "")
            {
                BH_CB_HTBan.Enabled = false;
                int maSP = int.Parse(BH_DGV_DSSP.Rows[indexRowSelected].Cells[0].Value.ToString());
                SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(maSP);
                String tenDVTChinh = donVi_BUS.LayTenDVTBangMaDVT(sp.DVTCHINH);
                String tenDVTPhu = donVi_BUS.LayTenDVTBangMaDVT(sp.DVTPHU);
                int slTonKho_DGVSP = int.Parse(BH_DGV_DSSP.Rows[indexRowSelected].Cells[2].Value.ToString());
                int slTonKho_TXT_CBSP = int.Parse(BH_TXT_SL.Text);
                

                if (KiemTraLoaiDonViTinh(BH_CB_DVTinh.Text))
                {
                    int slQuyDoi = sp.QUIDOI.Value;
                    slTonKho_TXT_CBSP *= slQuyDoi;
                }

                if(slTonKho_TXT_CBSP <= slTonKho_DGVSP)
                {
                    int slDVT_DGVSanPham_CapNhat = slTonKho_DGVSP - slTonKho_TXT_CBSP;
                    String slQuyDoi_DGVSanPham_CapNhat = tinhTonKhoQuyDoi(tenDVTChinh, tenDVTPhu, slDVT_DGVSanPham_CapNhat, sp.QUIDOI.Value);
                    BH_DGV_DSSP.Rows[indexRowSelected].Cells[2].Value = slDVT_DGVSanPham_CapNhat;
                    BH_DGV_DSSP.Rows[indexRowSelected].Cells[3].Value = slQuyDoi_DGVSanPham_CapNhat;
                    ThemSPVaoDGV_CTHD(maSP);
                    BH_TXT_TongTien.Text = TinhTongTien().ToString();
                    tongTien = double.Parse(BH_TXT_TongTien.Text);
                }
                else
                {
                    MessageBox.Show("Số lượng tồn kho không đủ!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm hoặc chưa nhập số lượng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int LayDongDGVSanPham_CapNhatSLTon(int maSP)
        {
            int idSP;
            int tongDong = BH_DGV_DSSP.RowCount;
            for (int i = 0; i < tongDong; i++)
            {
                idSP = int.Parse(BH_DGV_DSSP.Rows[i].Cells[0].Value.ToString());
                if (idSP == maSP)
                {
                    return i;
                }
            }
            return -1;
        }

        private void BH_BTN_XOASPCT_Click(object sender, EventArgs e)
        {
            
            if (indexSelected_DGVCTHD != -1 && BH_DGV_CTHD.Rows.Count > 0)
            {
                int thanhTien = int.Parse(BH_DGV_CTHD.Rows[indexSelected_DGVCTHD].Cells[5].Value.ToString());
                if(thanhTien != 0)
                {
                    int maSP = int.Parse(BH_DGV_DSSP.Rows[indexRowSelected].Cells[0].Value.ToString());
                    SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(maSP);
                    String tenDVTChinh = donVi_BUS.LayTenDVTBangMaDVT(sp.DVTCHINH);
                    String tenDVTPhu = donVi_BUS.LayTenDVTBangMaDVT(sp.DVTPHU);
                    String dvt_DGVCTHD = BH_DGV_CTHD.Rows[indexSelected_DGVCTHD].Cells[3].Value.ToString();
                    int slBan_DGVCTHD = int.Parse(BH_DGV_CTHD.Rows[indexSelected_DGVCTHD].Cells[4].Value.ToString());
                    int soDong_DGVSP = LayDongDGVSanPham_CapNhatSLTon(maSP);
                    int slTK_DGVSP = int.Parse(BH_DGV_DSSP.Rows[soDong_DGVSP].Cells[2].Value.ToString());

                    if (KiemTraLoaiDonViTinh(dvt_DGVCTHD))
                    {
                        slBan_DGVCTHD *= sp.QUIDOI.Value;
                    }

                    slTK_DGVSP += slBan_DGVCTHD;
                    String slQuyDoi_DGVSanPham_CapNhat = tinhTonKhoQuyDoi(tenDVTChinh, tenDVTPhu, slTK_DGVSP, sp.QUIDOI.Value);
                    BH_DGV_DSSP.Rows[soDong_DGVSP].Cells[2].Value = slTK_DGVSP;
                    BH_DGV_DSSP.Rows[soDong_DGVSP].Cells[3].Value = slQuyDoi_DGVSanPham_CapNhat;
                }

                BH_DGV_CTHD.Rows.RemoveAt(indexSelected_DGVCTHD);
                BH_TXT_TTCanThanhToan.Text = TinhTongTien().ToString();
                if (BH_DGV_CTHD.RowCount == 0)
                {
                    RefreshForm();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm cần xóa!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private double TinhTongTien()
        {
            int tongTien = 0;
            int tongDong = BH_DGV_CTHD.RowCount;
            for(int i = 0; i < tongDong; i++)
            {
                tongTien += int.Parse(BH_DGV_CTHD.Rows[i].Cells[5].Value.ToString());
            }
            return tongTien;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
        }

        private void BH_TXT_KhachDua_TextChanged(object sender, EventArgs e)
        {
            if (BH_TXT_KhachDua.Text != "")
            {
                double tienKhachDua = double.Parse(BH_TXT_KhachDua.Text);
                double tongTien = double.Parse(BH_TXT_TTCanThanhToan.Text);
                double tienThua = tienKhachDua - tongTien;
                BH_TXT_TienThua.Text = tienThua.ToString();
            }
            else
            {
                BH_TXT_TienThua.Text = "0";
            }
        }

        private bool KiemTraCoKhuyenMai()
        {
            int tongDong = BH_DGV_CTHD.Rows.Count;
            for (int i = 0; i < tongDong; i++)
            {
                int thanhTien = int.Parse(BH_DGV_CTHD.Rows[i].Cells[5].Value.ToString());
                if (thanhTien == 0 || int.Parse(BH_TXT_ChietKhau.Text) > 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void BH_BTN_THANHTOAN_Click(object sender, EventArgs e)
        {
            int maSP;
            String tenDVTChinh;
            String tenDVTPhu;
            String tenDVT;
            if (BH_DGV_CTHD.Rows.Count > 0)
            {
                //Them don hang vao CSDL
                DONHANG dh = new DONHANG();
                dh.NGAYLAP = BH_DATE_TTOAN.Value.Date;
                dh.TONGTIEN = double.Parse(BH_TXT_TTCanThanhToan.Text);
                dh.IDNV = int.Parse(BH_CB_NV.SelectedValue.ToString());
                dh.IDKH = int.Parse(BH_CB_KH.SelectedValue.ToString());
                if (KiemTraCoKhuyenMai())
                {
                    int maKhuyenMai = frmSellDiscount.frm_KhuyenMaiBanHang.maKhuyenMai;
                    dh.MAKHUYENMAI = maKhuyenMai;
                    if(khuyenMai_BUS.LayKhuyenMaiBangMKM(maKhuyenMai).MAHTKM == 1) //Khuyen mai theo chiet khau
                    {
                        dh.GIATRIKHUYENMAI = double.Parse(BH_TXT_ChietKhau.Text);
                    }
                    else // Khuyen mai tang san pham
                    {
                        int soLuongTang = frmChooseProductGiveaways.frmChonSanPhamTang.soLuongTang;
                        double donGia = frmChooseProductGiveaways.frmChonSanPhamTang.gia;
                        dh.GIATRIKHUYENMAI = soLuongTang * donGia;
                    }

                    //Cap nhat lai so luong phieu khuyen mai
                    KHUYENMAI km = khuyenMai_BUS.LayKhuyenMaiBangMKM(maKhuyenMai);
                    if (km.SLAPDUNG != null)
                    {
                        km.SLAPDUNGCONLAI -= 1;
                        khuyenMai_BUS.SuaKhuyenMai(km);
                    }
                }
                donHang_BUS.ThemDonHang(dh);

                int tongDong = BH_DGV_CTHD.Rows.Count;
                //Them CT Don hang vao CSDL
                CT_DONHANG ct_DH = new CT_DONHANG();
                for (int i = 0; i < tongDong; i++)
                {
                    if (BH_DGV_CTHD.Rows[i].Cells[5].Value.ToString() == "0")
                    {
                        continue;
                    }
                    maSP = int.Parse(BH_DGV_CTHD.Rows[i].Cells[0].Value.ToString());
                    ct_DH.MADH = dh.MADH;
                    ct_DH.MASP = maSP;
                    ct_DH.DVT = donVi_BUS.LayMaDVTBangTenDVT(BH_DGV_CTHD.Rows[i].Cells[3].Value.ToString());
                    int slBan = int.Parse(BH_DGV_CTHD.Rows[i].Cells[4].Value.ToString());
                    ct_DH.SL = slBan;
                    ct_DH.THANHTIEN = double.Parse(BH_DGV_CTHD.Rows[i].Cells[5].Value.ToString());
                    ct_DonHang_BUS.ThemCTDonHang(ct_DH);

                    //Cap nhat ton kho
                    TONKHO tk = tonKho_BUS.LayTonKhoBangMSP(maSP);
                    SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(maSP);
                    tenDVTChinh = donVi_BUS.LayTenDVTBangMaDVT(sp.DVTCHINH);
                    tenDVTPhu = donVi_BUS.LayTenDVTBangMaDVT(sp.DVTPHU);
                    tenDVT = BH_DGV_CTHD.Rows[i].Cells[3].Value.ToString();

                    if (KiemTraLoaiDonViTinh(tenDVT))// Don vi tinh chinh
                    {
                        slBan *= sp.QUIDOI.Value;
                    }

                    tk.IDSP = maSP;
                    int slHienTai = int.Parse(tk.SLTON.ToString());
                    slHienTai -= slBan;
                    tk.SLTON = slHienTai;
                    tk.SLTONQUIDOI = tinhTonKhoQuyDoi(tenDVTChinh, tenDVTPhu, slHienTai, sp.QUIDOI.Value);
                    tonKho_BUS.CapNhatSanPhamTonKho(tk);

                    /*Load DGV Ton Kho*/
                    ucWarehouse.uc_TonKho.FillDataDGV(tonKho_BUS.LayTatCaTonKho());
                }

                ucBill.uc_DonHang.FillDataDGV(donHang_BUS.LayTatCaDonHang());
                MessageBox.Show("Đã thanh toán!", "Thông báo");
                RefreshForm();
            }
            else
            {
                MessageBox.Show("Bạn chưa thêm sản phẩm vào đơn hàng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BH_BTN_HUY_Click(object sender, EventArgs e)
        {
            BH_TXT_TTCanThanhToan.Text = "";
            BH_TXT_KhachDua.Text = "";
            BH_TXT_TienThua.Text = "";
            BH_BTN_XOASPCT.Enabled = true;
        }

        private void BH_BTN_TaoDonMoi_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private List<KHUYENMAI> listKMThoaiDK(DateTime thoiGioiHienTai, List<int> listDoiTuongKhachHang, double tongTien)
        {
            List<KHUYENMAI> listKM_ThoaiDK = new List<KHUYENMAI>();
            KhuyenMai_BUS khuyenMai_BUS = new KhuyenMai_BUS();
            CT_KhuyenMaiTangSP_BUS cT_KhuyenMaiTangSP_BUS = new CT_KhuyenMaiTangSP_BUS();
            CT_KhuyenMaiChietKhau_BUS cT_KhuyenMaiTheoCK_BUS = new CT_KhuyenMaiChietKhau_BUS();
            List<KHUYENMAI> listKM = khuyenMai_BUS.LayTatCaKhuyenMai();
            foreach (var km in listKM)
            {
                if (km.TUNGAY <= thoiGioiHienTai && (km.DENNGAY >= thoiGioiHienTai || km.DENNGAY == null)
                && (km.SLAPDUNGCONLAI > 0 || km.SLAPDUNGCONLAI == null) && km.TRANGTHAI == true)
                {
                    foreach (var dtkh in listDoiTuongKhachHang)
                    {
                        if(km.MADTKM == dtkh)
                        {
                            if(km.MAHTKM == 1)
                            {
                                List<CTKHUYENMAI_CHIETKHAU> listCTKMTCK = cT_KhuyenMaiTheoCK_BUS.LayDanhSachCTKhuyenMaiBangMKM(km.MAKM);

                                foreach (var item in listCTKMTCK)
                                {
                                    if (item.GIATU <= tongTien && (item.DENGIA >= tongTien || item.DENGIA == null))
                                    {
                                        listKM_ThoaiDK.Add(km);
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                List<CTKHUYENMAI_TANGSP> listCTKMTSP = cT_KhuyenMaiTangSP_BUS.LayDanhSachCTKhuyenMaiBangMKM(km.MAKM);

                                foreach (var item in listCTKMTSP)
                                {
                                    if (item.GIATU <= tongTien && (item.DENGIA >= tongTien || item.DENGIA == null))
                                    {
                                        listKM_ThoaiDK.Add(km);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return listKM_ThoaiDK;
        }

        private List<int> LayDSDoiTuongKhuyenMai()
        {
            List<int> doiTuongKhachHang = new List<int>();
            doiTuongKhachHang.Add(5);

            if (BH_CB_HTBan.SelectedIndex == 0) //khach le
            {
                doiTuongKhachHang.Add(4);
            }
            else
            {
                doiTuongKhachHang.Add(3);
                bool gioiTinhKH = khachHang_BUS.LayKhachHangBangMKH(int.Parse(BH_CB_KH.SelectedValue.ToString())).GIOITINH.Value;
                if (gioiTinhKH) //gioi tinh nam
                {
                    doiTuongKhachHang.Add(1);
                }
                else //gioi tinh nu
                {
                    doiTuongKhachHang.Add(2);
                }
            }
            return doiTuongKhachHang;
        }

        private void BH_BTN_KHUYENMAI_Click(object sender, EventArgs e)
        {
            if(BH_TXT_TongTien.Text != "")
            {
                DateTime thoiGianHienTai = BH_DATE_TTOAN.Value.Date;
                double tongTien = int.Parse(BH_TXT_TongTien.Text);
                new frmSellDiscount(listKMThoaiDK(thoiGianHienTai, LayDSDoiTuongKhuyenMai(), tongTien)).Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa thêm sản phẩm vào đơn hàng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BH_BTN_ThemKH_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomer = new frmAddCustomer();
            addCustomer.ShowDialog();
        }

        private void BH_TXT_TongTien_TextChanged(object sender, EventArgs e)
        {
            if(BH_TXT_TongTien.Text != "" && BH_TXT_ChietKhau.Text != "")
            {
                double valueChange = double.Parse(BH_TXT_TongTien.Text) - double.Parse(BH_TXT_ChietKhau.Text);
                BH_TXT_TTCanThanhToan.Text = valueChange.ToString();
            }  
        }

        private void BH_TXT_ChietKhau_TextChanged(object sender, EventArgs e)
        {
            if (BH_TXT_TongTien.Text != "" && BH_TXT_ChietKhau.Text != "")
            {
                double valueChange = double.Parse(BH_TXT_TongTien.Text) - double.Parse(BH_TXT_ChietKhau.Text);
                BH_TXT_TTCanThanhToan.Text = valueChange.ToString();
            }
        }

        private void BH_BTN_INHD_Click(object sender, EventArgs e)
        {
            cb_NhanVien = BH_CB_NV;
            cb_KhachHang = BH_CB_KH;
            date_NgayTao = BH_DATE_TTOAN;
            //txt_ChietKhau = BH_TXT_ChietKhau;
            txt_TongTien = BH_TXT_TongTien;
            //txt_TienCanThanhToan = BH_TXT_TTCanThanhToan;
            txt_TienKhachDua = BH_TXT_KhachDua;
            txt_TienThua = BH_TXT_TienThua;
            

            if (BH_DGV_CTHD.RowCount < 0)
            {
                MessageBox.Show("Chưa có sản phẩm trong đơn hàng! Vui lòng thử lại", "Thông báo");
            }
            else if (BH_TXT_KhachDua.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tiền khách đưa! Vui lòng thử lại", "Thông báo");
            }
            else
            {
                frmBillReport frmBillReport = new frmBillReport();
                frmBillReport.ShowDialog();
            }

        }

        private void txtTimSP_BH_TextChanged(object sender, EventArgs e)
        {
            String tenSP = txtTimSP_BH.Text;
            if(tenSP.Length > 0)
            {
                List<TonKho_DTO> listTimSPTK = tonKho_BUS.TimKiemSanPhamTonKho(tenSP);
                FillDataDGV(listTimSPTK);
            }
            else
            {
                FillDataDGV(tonKho_BUS.LayTatCaSanPhamConTonKho());
            }
            
        }

    }
}
