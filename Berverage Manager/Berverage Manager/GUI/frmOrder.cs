using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Berverage_Manager.DataContext;
using Berverage_Manager.BUS;

namespace Berverage_Manager.GUI
{
    public partial class frmOrder : Form
    {
        NhaCungCap_BUS nhaCungCap_BUS;
        NhanVien_BUS nhanVien_BUS;
        SanPham_BUS sanPham_BUS;
        DonVi_BUS donVi_BUS;
        NhapKho_BUS nhapKho_BUS;
        CT_NhapKho_BUS ct_NhapKho_BUS;
        TonKho_BUS tonKho_BUS;
        bool checkEventCBSP = false;

        public frmOrder()
        {
            InitializeComponent();
            sanPham_BUS = new SanPham_BUS();
            nhaCungCap_BUS = new NhaCungCap_BUS();
            nhanVien_BUS = new NhanVien_BUS();
            donVi_BUS = new DonVi_BUS();
            nhapKho_BUS = new NhapKho_BUS();
            ct_NhapKho_BUS = new CT_NhapKho_BUS();
            tonKho_BUS = new TonKho_BUS();
        }

        public void LoadCBNhaCungCap()
        {
            NK_CB_NCC.DataSource = nhaCungCap_BUS.LayTatCaNhaCungCap();
            NK_CB_NCC.DisplayMember = "TENNCC";
            NK_CB_NCC.ValueMember = "MANCC";
        }
        public void LoadCBNhanVien()
        {
            NK_CB_NV.DataSource = nhanVien_BUS.LayTatCaNhanVien();
            NK_CB_NV.DisplayMember = "TENNV";
            NK_CB_NV.ValueMember = "MANV";
        }
        public void LoadCBSanPham()
        {
            NK_CB_SP.DataSource = sanPham_BUS.LayTatCaSanPham();
            NK_CB_SP.ValueMember = "MASP";
            checkEventCBSP = true;
            NK_CB_SP.DisplayMember = "TENSP";
        }

        public void LoadCBDonViTinh()
        {
            NK_CB_DVTinh.DataSource = donVi_BUS.LayTatCaDonViChinh();
            NK_CB_DVTinh.DisplayMember = "TENDV";
            NK_CB_DVTinh.ValueMember = "MADV";
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            NK_DATENK.Value = DateTime.Now;
            LoadCBNhaCungCap();
            LoadCBNhanVien();
            LoadCBDonViTinh();
            LoadCBSanPham();
        }

        private void NK_DGV_CTNK_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            NK_DGV_CTNK.Rows[e.RowIndex].Height = 40;
        }

        private void NK_CB_SP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkEventCBSP == true)
            {
                SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(int.Parse(NK_CB_SP.SelectedValue.ToString()));
                NK_CB_DVTinh.SelectedValue = sp.DVTCHINH;
            }
        }

        private void NK_CB_DVTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            NK_LB_DVT.Text = NK_CB_DVTinh.Text.ToUpper();
        }

        private int LayDongTonTaiSP()
        {
            int tongDong = NK_DGV_CTNK.Rows.Count;
            string mspNhapKho = NK_CB_SP.SelectedValue.ToString();
            for (int i = 0; i < tongDong; i++)
            {
                string msp_DGV = NK_DGV_CTNK.Rows[i].Cells[0].Value.ToString();
                if (mspNhapKho == msp_DGV)
                {
                    return i;
                }
            }

            return -1;
        }

        private void ThemCTNhapKho_DGV()
        {
            int row = NK_DGV_CTNK.Rows.Add();
            string maSP = NK_CB_SP.SelectedValue.ToString();
            int soLuong = int.Parse(NK_TXT_SL.Text);
            NK_DGV_CTNK.Rows[row].Cells[0].Value = maSP;
            NK_DGV_CTNK.Rows[row].Cells[1].Value = NK_CB_SP.Text;
            NK_DGV_CTNK.Rows[row].Cells[2].Value = soLuong;
            NK_DGV_CTNK.Rows[row].Cells[3].Value = NK_CB_DVTinh.Text;
            SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(int.Parse(maSP));
            double thanhTien = double.Parse(sp.GIANHAP_DVTC.Value.ToString()) * soLuong;
            NK_DGV_CTNK.Rows[row].Cells[4].Value = thanhTien.ToString();
        }

        private void XuLyThemCTNhapKho_DGV()
        {
            if (NK_TXT_SL.Text != "")
            {
                if (LayDongTonTaiSP() != -1) //San pham da ton tai trong DGV_NhapKho
                {
                    //Cap nhat lai so luong
                    int slMoi = int.Parse(NK_TXT_SL.Text);
                    int slHienTai = int.Parse(NK_DGV_CTNK.Rows[LayDongTonTaiSP()].Cells[2].Value.ToString());
                    slMoi += slHienTai;
                    NK_DGV_CTNK.Rows[LayDongTonTaiSP()].Cells[2].Value = slMoi.ToString();

                    //Cap nhat lai thanh tien khi tang so luong san pham
                    double thanhTienHienTai = double.Parse(NK_DGV_CTNK.Rows[LayDongTonTaiSP()].Cells[4].Value.ToString());
                    string maSP_DGV = NK_DGV_CTNK.Rows[LayDongTonTaiSP()].Cells[0].Value.ToString();
                    SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(int.Parse(maSP_DGV));
                    double giaNhap = double.Parse(sp.GIANHAP_DVTC.ToString());
                    NK_DGV_CTNK.Rows[LayDongTonTaiSP()].Cells[4].Value = thanhTienHienTai + giaNhap * slMoi;
                }
                else //San pham chua duoc them trong DGV_NhapKho
                {
                    ThemCTNhapKho_DGV();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập số lượng!", "Thông báo");
            }
        }

        private void NK_BTN_THEM_CTNK_Click(object sender, EventArgs e)
        {
            XuLyThemCTNhapKho_DGV();
        }

        

        private double TinhTongTien()
        {
            double tongTien = 0;
            int sodong = NK_DGV_CTNK.Rows.Count;

            for (int i = 0; i < sodong; i++)
            {
                tongTien += double.Parse(NK_DGV_CTNK.Rows[i].Cells[4].Value.ToString());
            }
            return tongTien;
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

        private void ThemSPVaoTonKho_CSDL(int maSP, int slDVTChinh)
        {
            TONKHO tk = tonKho_BUS.LayTonKhoBangMSP(maSP);
            SANPHAM sp = sanPham_BUS.LaySanPhamBangMSP(maSP);
            String tenDVTChinh = donVi_BUS.LayTenDVTBangMaDVT(sp.DVTCHINH);
            String tenDVTPhu = donVi_BUS.LayTenDVTBangMaDVT(sp.DVTPHU);
            int slNhapKho = slDVTChinh * sp.QUIDOI.Value;

            if (tk != null)
            {
                tk.IDSP = maSP;
                int slHienTai = int.Parse(tk.SLTON.ToString());
                slNhapKho += slHienTai;
                tk.SLTON = slNhapKho;
                tk.SLTONQUIDOI = tinhTonKhoQuyDoi(tenDVTChinh, tenDVTPhu, slNhapKho, sp.QUIDOI.Value);
                tonKho_BUS.CapNhatSanPhamTonKho(tk);
            }
            else
            {
                TONKHO tonkho = new TONKHO();
                tonkho.IDSP = maSP;
                tonkho.SLTON = slNhapKho;
                tonkho.SLTONQUIDOI = tinhTonKhoQuyDoi(tenDVTChinh, tenDVTPhu, slNhapKho, sp.QUIDOI.Value);
                tonKho_BUS.ThemSanPhamVaoTonKho(tonkho);

            }
        }

        private void NK_BTN_XACNHAN_Click(object sender, EventArgs e)
        {
            if (NK_DGV_CTNK.Rows.Count > 0)
            {
                //Them phieu nhap kho vao CSDL
                NHAPKHO nk = new NHAPKHO();
                nk.NGAYNHAP = NK_DATENK.Value.Date;
                nk.TONGTIEN = TinhTongTien();
                nk.IDNV = int.Parse(NK_CB_NV.SelectedValue.ToString());
                nk.IDNCC = int.Parse(NK_CB_NCC.SelectedValue.ToString());
                nhapKho_BUS.ThemPhieuNhapKho(nk);

                int tongDong = NK_DGV_CTNK.Rows.Count;
                //Them CT Phieu nhap kho vao CSDL
                CT_PNHAPKHO ct_PNK = new CT_PNHAPKHO();
                for (int i = 0; i < tongDong; i++)
                {
                    ct_PNK.IDPNK = nk.MAPNK;
                    ct_PNK.IDSP = int.Parse(NK_DGV_CTNK.Rows[i].Cells[0].Value.ToString());
                    ct_PNK.SL = int.Parse(NK_DGV_CTNK.Rows[i].Cells[2].Value.ToString());
                    ct_PNK.DVT = donVi_BUS.LayMaDVTBangTenDVT(NK_DGV_CTNK.Rows[i].Cells[3].Value.ToString());
                    ct_PNK.THANHTIEN = double.Parse(NK_DGV_CTNK.Rows[i].Cells[4].Value.ToString());
                    ct_NhapKho_BUS.ThemCTPhieuNhapKho(ct_PNK);

                    //Them san pham vao ton kho
                    int maSP = int.Parse(NK_DGV_CTNK.Rows[i].Cells[0].Value.ToString());
                    int slDVTChinh = int.Parse(NK_DGV_CTNK.Rows[i].Cells[2].Value.ToString());
                    ThemSPVaoTonKho_CSDL(maSP, slDVTChinh);

                    /*Load DGV Ton Kho*/
                    ucWarehouse.uc_TonKho.FillDataDGV(tonKho_BUS.LayTatCaTonKho());

                    //Load lai DGV DANH SACH SAN PHAM
                    /*List<TONKHO> listSP = dBQuanLyBanNGK.TONKHOes.Where(p => p.SLTON > 0).ToList();
                    ucBanHang.bh.FillDataDGV(listSP);*/
                }

                ucOder.uc_PhieuNhapKho.FillDataDGV(nhapKho_BUS.LayTatCaPhieuNhapKho());
                this.Close();
                MessageBox.Show("Sản phẩm đã được thêm vào kho!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn chưa thêm sản phẩm!", "Thông báo");
            }
        }
    }
}
