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
    public partial class ucProductReport : UserControl
    {
        DonHang_BUS donHang_BUS;
        CT_DonHang_BUS CT_DonHang_BUS;
        SanPham_BUS sanPham_BUS;
        DonVi_BUS donVi_BUS;
        List<DONVI> list_DVT;
        public ucProductReport()
        {
            InitializeComponent();
            donHang_BUS = new DonHang_BUS();
            CT_DonHang_BUS = new CT_DonHang_BUS();
            sanPham_BUS = new SanPham_BUS();
            donVi_BUS = new DonVi_BUS();
            list_DVT = donVi_BUS.LayTatCaDonVi();
        }

        public void FillDataDGV(List<BaoCaoBanHang_SanPham> listBCBH_SP)
        {
            BHSP_dgvBaoCaoSP.Rows.Clear();
            foreach (var item in listBCBH_SP)
            {
                int RowNew = BHSP_dgvBaoCaoSP.Rows.Add();
                BHSP_dgvBaoCaoSP.Rows[RowNew].Cells[0].Value = item.MaSP;
                BHSP_dgvBaoCaoSP.Rows[RowNew].Cells[1].Value = item.TenSP;
                BHSP_dgvBaoCaoSP.Rows[RowNew].Cells[2].Value = item.DoanhThu;
                BHSP_dgvBaoCaoSP.Rows[RowNew].Cells[3].Value = item.LoiNhuan;
            }
        }

        private bool KiemTraLoaiDonViTinh(string maDV)
        {
            foreach (var item in list_DVT)
            {
                if (item.MADV == maDV && item.DVTC == true)
                {
                    return true; // true : La don vi tinh chinh
                }
            }

            return false; // false : La don vi tinh phu
        }

        public double TinhDoanhThuSanPham(List<CT_DONHANG> listCTDH, int maSP)
        {
            double doanhThu = 0;
            foreach(var item in listCTDH)
            {
                if(item.MASP == maSP)
                {
                    doanhThu += item.THANHTIEN.Value;
                }
            }
            return doanhThu;
        }

        public double TinhLoiNhuanSanPham(List<CT_DONHANG> listCTDH, int maSP, double doanhThu)
        {
            double giaVon = 0;
            double giaNhap_DVTC = sanPham_BUS.LaySanPhamBangMSP(maSP).GIANHAP_DVTC.Value;
            int quyDoi = sanPham_BUS.LaySanPhamBangMSP(maSP).QUIDOI.Value;
            double giaNhap_DVTP = giaNhap_DVTC / quyDoi;
            if(giaNhap_DVTP != (int)giaNhap_DVTP) //gia nhap khong phai so nguyen
            {
                giaNhap_DVTP /= 1000;
                giaNhap_DVTP = Math.Round(giaNhap_DVTP);
                giaNhap_DVTP *= 1000;
                Console.WriteLine(giaNhap_DVTP);
            }
            foreach (var item in listCTDH)
            {
                if(item.MASP == maSP)
                {
                    if (KiemTraLoaiDonViTinh(item.DVT))
                    {
                        giaVon += item.SL.Value * giaNhap_DVTC;
                    }
                    else
                    {
                        giaVon += item.SL.Value * giaNhap_DVTP;
                    }
                }
            }

            return doanhThu - giaVon;
        }


        public List<BaoCaoBanHang_SanPham> LayDanhSachBaoCao(DateTime tuNgay, DateTime denNgay)
        {
            List<BaoCaoBanHang_SanPham> listBCBH_SanPham = new List<BaoCaoBanHang_SanPham>();
            List<int> listMaSP = new List<int>();
            List<CT_DONHANG> listCTDonHang = CT_DonHang_BUS.LayDanhSachCTDHTheoNgay(tuNgay, denNgay);
            foreach(var item in listCTDonHang)
            {
                listMaSP.Add(item.MASP.Value);
            }
             var newListMaSP = listMaSP.Distinct();

            foreach (var item in newListMaSP)
            {
                BaoCaoBanHang_SanPham baoCaoBanHang_SanPham = new BaoCaoBanHang_SanPham();
                baoCaoBanHang_SanPham.MaSP = item;
                baoCaoBanHang_SanPham.TenSP = sanPham_BUS.LaySanPhamBangMSP(item).TENSP;
                double doanhThu = TinhDoanhThuSanPham(listCTDonHang, item);
                baoCaoBanHang_SanPham.DoanhThu = doanhThu;
                baoCaoBanHang_SanPham.LoiNhuan = TinhLoiNhuanSanPham(listCTDonHang, item, doanhThu);
                listBCBH_SanPham.Add(baoCaoBanHang_SanPham);
            }
            return listBCBH_SanPham;
        }

        private void BHSP_CB_TuyChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dateTimeNow = DateTime.Now.Date;
            switch (BHSP_CB_TuyChon.SelectedIndex)
            {
                case 0:
                    FillDataDGV(LayDanhSachBaoCao(dateTimeNow, dateTimeNow));
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
        }

        private void BHSP_btnXemDHTheoNgay_Click(object sender, EventArgs e)
        {
            /*DateTime tungay = new DateTime(2022, 06, 03);
            DateTime dateTimeNow = new DateTime(2022, 06, 05);

            List<CT_DONHANG> result = CT_DonHang_BUS.LayDanhSachCTDHTheoNgay(tungay, dateTimeNow);   */
            DateTime dateTimeNow = DateTime.Now.Date;
            
        }

        private void BHSP_dgvBaoCaoSP_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            BHSP_dgvBaoCaoSP.Rows[e.RowIndex].Height = 40;
        }
    }
}
