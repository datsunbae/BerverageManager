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
using System.Globalization;

namespace Berverage_Manager.GUI
{
    public partial class frmDetailDiscount : Form
    {
        public static int maKhuyenMai;
        NhanVien_BUS nhanVien_BUS;
        KhachHang_BUS khachHang_BUS;
        KhuyenMai_BUS khuyenMai_BUS;
        DoiTuongKhuyenMai_BUS doiTuongKhuyenMai_BUS;
        DonHang_BUS donHang_BUS;
        public frmDetailDiscount(int maKM)
        {
            InitializeComponent();
            maKhuyenMai = maKM;
            nhanVien_BUS = new NhanVien_BUS();
            khachHang_BUS = new KhachHang_BUS();
            khuyenMai_BUS = new KhuyenMai_BUS();
            donHang_BUS = new DonHang_BUS();
            doiTuongKhuyenMai_BUS = new DoiTuongKhuyenMai_BUS();
        }

        public void FillDataDGV(List<DONHANG> listDonHang)
        {
            CTKM_DGV_DonHangKM.Rows.Clear();
            foreach (var item in listDonHang)
            {
                int RowNew = CTKM_DGV_DonHangKM.Rows.Add();
                CTKM_DGV_DonHangKM.Rows[RowNew].Cells[0].Value = item.MADH;
                CTKM_DGV_DonHangKM.Rows[RowNew].Cells[1].Value = item.NGAYLAP.Value.ToString("dd/MM/yyyy");
                if (item.IDNV != null)
                {
                    CTKM_DGV_DonHangKM.Rows[RowNew].Cells[2].Value = nhanVien_BUS.LayNhanVienBangMNV(item.IDNV.Value).TENNV;
                }
                else
                {
                    CTKM_DGV_DonHangKM.Rows[RowNew].Cells[2].Value = "Null";
                }

                if (item.IDKH != null)
                {
                    CTKM_DGV_DonHangKM.Rows[RowNew].Cells[3].Value = khachHang_BUS.LayKhachHangBangMKH(item.IDKH.Value).TENKH;
                }
                else
                {
                    CTKM_DGV_DonHangKM.Rows[RowNew].Cells[3].Value = "Null";
                }
                CTKM_DGV_DonHangKM.Rows[RowNew].Cells[4].Value = item.GIATRIKHUYENMAI;
            }
        }

        private double TinhTongTienKhuyenMai()
        {
            int tongDong = CTKM_DGV_DonHangKM.RowCount;
            double tongTien = 0;
            for(int i = 0; i < tongDong; i++)
            {
                tongTien += double.Parse(CTKM_DGV_DonHangKM.Rows[i].Cells[4].Value.ToString());
            }

            return tongTien;
        }

        private void LoadThongTinKhuyenMai()
        {
            KHUYENMAI km = khuyenMai_BUS.LayKhuyenMaiBangMKM(maKhuyenMai);
            if (km.TRANGTHAI.Value)
            {
                CTKM_LB_Tinhtrang.Text += " Đang chạy";
                CTKM_LB_KichHoat.Enabled = false;
            }
            else
            {
                CTKM_LB_Tinhtrang.Text += " Tạm dừng";
                CTKM_BTN_TamDungKM.Enabled = false;
            }
            
            if(km.MAHTKM == 1) //chiet khau
            {
                CTKM_LB_LoaiKM.Text += " Chiết khấu theo tổng tiền";
            }
            else
            {
                CTKM_LB_LoaiKM.Text += " Tặng sản phẩm theo tổng tiền";
            }

            CTKM_LB_TenKM.Text += $" {km.TENKM}";
            CTKM_LB_TuNgay.Text += $" {km.TUNGAY.Value.ToString("dd/MM/yyyy")}";
            CTKM_LB_DoiTuongKM.Text += $" {doiTuongKhuyenMai_BUS.LayTenDoiTuongKhuyenMaiBangMaDTKM(km.MADTKM.Value)}";
            if(km.DENNGAY == null)
            {
                CTKM_LB_DenNgay.Text += "Không giới hạn";
                CTKM_LB_ThoiGianConLai.Text += " Không giới hạn";
            }
            else
            {
                CTKM_LB_DenNgay.Text += $" {km.DENNGAY.Value.ToString("dd/MM/yyyy")}";
                CTKM_LB_ThoiGianConLai.Text += $" {km.DENNGAY.Value.Subtract(km.TUNGAY.Value).Days} ngày";
            }
            if (km.SLAPDUNGCONLAI == null)
            {
                CTKM_LB_SLConLai.Text += " Không giới hạn";
            }
            else
            {
                CTKM_LB_SLConLai.Text += $" {km.SLAPDUNGCONLAI}";
            }

            CTKM_LB_TongGiaTriKM.Text += $" {TinhTongTienKhuyenMai()}";

        }

        private void frmDetailDiscount_Load(object sender, EventArgs e)
        {
            FillDataDGV(donHang_BUS.LayDSDonHangBangMaKhuyenMai(maKhuyenMai));
            LoadThongTinKhuyenMai();
        }

        private void CTKM_BTN_TamDungKM_Click(object sender, EventArgs e)
        {
            KHUYENMAI km = khuyenMai_BUS.LayKhuyenMaiBangMKM(maKhuyenMai);
            km.TRANGTHAI = false;
            khuyenMai_BUS.SuaKhuyenMai(km);
            CTKM_LB_Tinhtrang.Text = "Tình trạng: Tạm dừng";
            CTKM_LB_KichHoat.Enabled = true;
            CTKM_BTN_TamDungKM.Enabled = false;
            ucDiscount.uc_KhuyenMai.FillDataDGV(khuyenMai_BUS.LayTatCaKhuyenMai());
        }

        private void CTKM_LB_KichHoat_Click(object sender, EventArgs e)
        {
            KHUYENMAI km = khuyenMai_BUS.LayKhuyenMaiBangMKM(maKhuyenMai);
            km.TRANGTHAI = true;
            khuyenMai_BUS.SuaKhuyenMai(km);
            CTKM_LB_Tinhtrang.Text = "Tình trạng: Đang chạy";
            CTKM_LB_KichHoat.Enabled = false;
            CTKM_BTN_TamDungKM.Enabled = true;
            ucDiscount.uc_KhuyenMai.FillDataDGV(khuyenMai_BUS.LayTatCaKhuyenMai());
        }

        private void CTKM_DGV_DonHangKM_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CTKM_DGV_DonHangKM.Rows[e.RowIndex].Height = 40;
        }
    }
}
