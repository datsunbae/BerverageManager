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
    public partial class ucSell : UserControl
    {
        private TonKho_BUS tonKho_BUS;
        private SanPham_BUS sanPham_BUS;
        private KhachHang_BUS khachHang_BUS;
        private DonVi_BUS donVi_BUS;
        private List<DONVI> list_DVT;
        private int indexRowSelected = -1;
        public ucSell()
        {
            InitializeComponent();
            tonKho_BUS = new TonKho_BUS();
            sanPham_BUS = new SanPham_BUS();
            khachHang_BUS = new KhachHang_BUS();
            donVi_BUS = new DonVi_BUS();
            list_DVT = donVi_BUS.LayTatCaDonVi();
        }

        public void FillDataDGV(List<TONKHO> listSanPham)
        {

            BH_DGV_DSSP.Rows.Clear();
            foreach (var item in listSanPham)
            {
                int RowNew = BH_DGV_DSSP.Rows.Add();
                BH_DGV_DSSP.Rows[RowNew].Cells[0].Value = item.IDSP;
                BH_DGV_DSSP.Rows[RowNew].Cells[1].Value = item.SANPHAM.TENSP;
                BH_DGV_DSSP.Rows[RowNew].Cells[2].Value = item.SLTON;
                BH_DGV_DSSP.Rows[RowNew].Cells[3].Value = item.SLTONQUIDOI;
            }
        }

        public void LoadCBKhachHang()
        {
            if (BH_CB_HTBan.SelectedIndex == 0) // Khach si
            {
                BH_CB_KH.DataSource = khachHang_BUS.LayTatCaKhachSi();
                BH_CB_KH.DisplayMember = "TENKH";
                BH_CB_KH.ValueMember = "MAKH";
            }
            else // Khach le
            {
                BH_CB_KH.DataSource = khachHang_BUS.LayKhachLe();
                BH_CB_KH.DisplayMember = "TENKH";
                BH_CB_KH.ValueMember = "MAKH";
            }
        }

        public void LoadCBDonViTinh(List<DONVI> listDVT)
        {
            BH_CB_DVTinh.DataSource = listDVT;
            BH_CB_DVTinh.DisplayMember = "TENDV";
            BH_CB_DVTinh.ValueMember = "MADV";
        }

        private void ucSell_Load(object sender, EventArgs e)
        {
            BH_CB_HTBan.SelectedIndex = 0; //set Hinh thuc ban: Khach si
            LoadCBKhachHang();
            FillDataDGV(tonKho_BUS.LayTatCaTonKho());
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
                BH_TXT_TENSP.Text = BH_DGV_DSSP.Rows[indexRowSelected].Cells[2].Value.ToString();
                if (BH_CB_HTBan.SelectedIndex == 0)
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
                else
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
    }
}
