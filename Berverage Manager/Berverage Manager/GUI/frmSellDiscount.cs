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
    public partial class frmSellDiscount : Form
    {
        public static frmSellDiscount frm_KhuyenMaiBanHang;
        public int maKhuyenMai;
        public static List<KHUYENMAI> listKM_ThoaiDK;
        HinhThucKhuyenMai_BUS hinhThucKhuyenMai_BUS;
        CT_KhuyenMaiChietKhau_BUS cT_KhuyenMaiChietKhau_BUS;
        KhuyenMai_BUS khuyenMai_BUS;
        ChietKhau_BUS chietKhau_BUS;
        private int indexRowSelected = -1;
        public frmSellDiscount(List<KHUYENMAI> listKM)
        {
            InitializeComponent();
            ADKM_DGV_DSKM.Columns[2].Width = 220;
            frm_KhuyenMaiBanHang = this;
            listKM_ThoaiDK = listKM;
            hinhThucKhuyenMai_BUS = new HinhThucKhuyenMai_BUS();
            khuyenMai_BUS = new KhuyenMai_BUS();
            cT_KhuyenMaiChietKhau_BUS = new CT_KhuyenMaiChietKhau_BUS();
            chietKhau_BUS = new ChietKhau_BUS();

        }

        private void ADKM_BTN_ApDung_Click(object sender, EventArgs e)
        {
            if (indexRowSelected != -1)
            {
                KHUYENMAI km = khuyenMai_BUS.LayKhuyenMaiBangMKM(int.Parse(ADKM_DGV_DSKM.Rows[indexRowSelected].Cells[0].Value.ToString()));
                maKhuyenMai = int.Parse(ADKM_DGV_DSKM.Rows[indexRowSelected].Cells[0].Value.ToString());
                if (km.MAHTKM == 2) // khuyen mai tang san pham
                {
                    new frmChooseProductGiveaways(maKhuyenMai).Show();
                }
                else // khuyen mai theo chiet khau
                {
                    string tenLoaiCK = ADKM_DGV_DSKM.Rows[indexRowSelected].Cells[4].Value.ToString();
                    if (chietKhau_BUS.LayMaChietKhauBangTenCK(tenLoaiCK) == "CK1") // CK1: Phần trăm
                    {
                        double tongTien = ucSell.uc_BanHang.tongTien;
                        double chietKhau = double.Parse(ADKM_DGV_DSKM.Rows[indexRowSelected].Cells[3].Value.ToString());
                        double valueChietKhau = (tongTien * chietKhau) / 100;
                        ucSell.uc_BanHang.textBox_ChietKhau.Text = valueChietKhau.ToString();
                        //ucSell.uc_BanHang.textBox_CanThanhToan.Text =
                    }
                    else // CK2: Giá trị
                    {
                        ucSell.uc_BanHang.textBox_ChietKhau.Text = ADKM_DGV_DSKM.Rows[indexRowSelected].Cells[3].Value.ToString();
                    }
                }
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi muốn áp dụng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void FillDataDGV(List<KHUYENMAI> listKM)
        {
            ADKM_DGV_DSKM.Rows.Clear();
            foreach (var item in listKM)
            {
                int RowNew = ADKM_DGV_DSKM.Rows.Add();
                ADKM_DGV_DSKM.Rows[RowNew].Cells[0].Value = item.MAKM;
                ADKM_DGV_DSKM.Rows[RowNew].Cells[1].Value = item.TENKM;
                ADKM_DGV_DSKM.Rows[RowNew].Cells[2].Value = hinhThucKhuyenMai_BUS.LayTenHinhThucKhuyenMaiBangMaHTKM(item.MAHTKM.Value);
                if (item.MAHTKM == 1)//khuyen mai theo chiet khau
                {
                    List<CTKHUYENMAI_CHIETKHAU> listCTKHUYENMAI_CHIETKHAU = cT_KhuyenMaiChietKhau_BUS.LayDanhSachCTKhuyenMaiBangMKM(item.MAKM);
                    double tongTien = ucSell.uc_BanHang.tongTien;
                    foreach(var ctkmck in listCTKHUYENMAI_CHIETKHAU)
                    {
                        if (ctkmck.GIATU <= tongTien && (ctkmck.DENGIA >= tongTien || ctkmck.DENGIA == null))
                        {
                            ADKM_DGV_DSKM.Rows[RowNew].Cells[3].Value = ctkmck.CK;
                            ADKM_DGV_DSKM.Rows[RowNew].Cells[4].Value = chietKhau_BUS.LayChietKhauBangMCK(ctkmck.LOAICK).TENCK;
                        }
                           
                    }
                }
                else
                {
                    ADKM_DGV_DSKM.Rows[RowNew].Cells[3].Value = "-";
                    ADKM_DGV_DSKM.Rows[RowNew].Cells[4].Value = "-";
                }
            }
        }

        private void frmSellDiscount_Load(object sender, EventArgs e)
        {
            FillDataDGV(listKM_ThoaiDK);
        }

        private void ADKM_DGV_DSKM_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ADKM_DGV_DSKM.Rows[e.RowIndex].Height = 40;
        }

        private void ADKM_DGV_DSKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowSelected = e.RowIndex;
        }
    }
}
