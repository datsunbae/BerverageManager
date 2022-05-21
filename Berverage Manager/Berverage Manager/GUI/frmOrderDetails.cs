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
    public partial class frmOrderDetails : Form
    {
        int ma_PNK;
        CT_NhapKho_BUS ct_PhieuNhapKho_BUS;
        SanPham_BUS sanPham_BUS;
        public frmOrderDetails(int maPNK)
        {
            InitializeComponent();
            ma_PNK = maPNK;
            ct_PhieuNhapKho_BUS = new CT_NhapKho_BUS();
            sanPham_BUS = new SanPham_BUS();
        }

        private void FillDataDGV(List<CT_PNHAPKHO> list_CTPNK)
        {
            CTNK_DGV_CTNK.Rows.Clear();

            foreach (var item in list_CTPNK)
            {
                int RowNew = CTNK_DGV_CTNK.Rows.Add();
                CTNK_DGV_CTNK.Rows[RowNew].Cells[0].Value = item.IDSP;
                if (item.IDSP != null)
                {
                    CTNK_DGV_CTNK.Rows[RowNew].Cells[1].Value = sanPham_BUS.LaySanPhamBangMSP(item.IDSP.Value).TENSP;
                }
                else
                {
                    CTNK_DGV_CTNK.Rows[RowNew].Cells[1].Value = "Null";
                }
                CTNK_DGV_CTNK.Rows[RowNew].Cells[2].Value = item.SL;
                CTNK_DGV_CTNK.Rows[RowNew].Cells[3].Value = item.DONVI.TENDV;
                CTNK_DGV_CTNK.Rows[RowNew].Cells[4].Value = item.THANHTIEN;
                
            }
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            CTNK_TXT_MPhieu.Text = ma_PNK.ToString();
            FillDataDGV(ct_PhieuNhapKho_BUS.LayDanhSachCTPNKBangMaPNK(ma_PNK));
        }

        private void CTNK_DGV_CTNK_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CTNK_DGV_CTNK.Rows[e.RowIndex].Height = 40;
        }
    }
}
