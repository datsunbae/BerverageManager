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
        public static List<KHUYENMAI> listKM_ThoaiDK;
        HinhThucKhuyenMai_BUS hinhThucKhuyenMai_BUS;
        private int indexRowSelected = -1;
        //listKMTSP, thoiGianHienTai, doiTuongKhachHang, soLuongPhieuConLai, tongTien
        public frmSellDiscount(List<KHUYENMAI> listKM)
        {
            InitializeComponent();
            frm_KhuyenMaiBanHang = this;
            listKM_ThoaiDK = listKM;
            hinhThucKhuyenMai_BUS = new HinhThucKhuyenMai_BUS();
        }

        private void ADKM_BTN_ApDung_Click(object sender, EventArgs e)
        {
            //xu ly o day
            if(indexRowSelected != -1)
            {
                int maKhuyenMai = int.Parse(ADKM_DGV_DSKM.Rows[indexRowSelected].Cells[0].Value.ToString());
                new frmChooseProductGiveaways(maKhuyenMai).Show();
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
                if (item.MAHTKM == 1)
                {
                    //ADKM_DGV_DSKM.Rows[RowNew].Cells[2].Value = item.MAHTKM;
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
