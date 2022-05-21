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
    public partial class frmBillDetails : Form
    {
        int ma_DH;
        CT_DonHang_BUS ct_DonHang_BUS;
        SanPham_BUS sanPham_BUS;
        DonVi_BUS donVi_BUS;
        public frmBillDetails(int maDH)
        {
            InitializeComponent();
            ma_DH = maDH;
            ct_DonHang_BUS =new CT_DonHang_BUS();
            sanPham_BUS = new SanPham_BUS();
            donVi_BUS = new DonVi_BUS();
        }

        private void FillDataDGV(List<CT_DONHANG> list_DH)
        {
            DH_DGV_CTHD.Rows.Clear();

            foreach (var item in list_DH)
            {
                int RowNew = DH_DGV_CTHD.Rows.Add();
                DH_DGV_CTHD.Rows[RowNew].Cells[0].Value = item.MASP;
                if (item.MASP != null)
                {
                    DH_DGV_CTHD.Rows[RowNew].Cells[1].Value = sanPham_BUS.LaySanPhamBangMSP(item.MASP.Value).TENSP;
                }
                else
                {
                    DH_DGV_CTHD.Rows[RowNew].Cells[1].Value = "Null";
                }
                DH_DGV_CTHD.Rows[RowNew].Cells[2].Value = item.SL;
                DH_DGV_CTHD.Rows[RowNew].Cells[3].Value = donVi_BUS.LayTenDVTBangMaDVT(item.DVT);
                DH_DGV_CTHD.Rows[RowNew].Cells[4].Value = item.THANHTIEN;

            }
        }

        private void frmBillDetails_Load(object sender, EventArgs e)
        {
            CTHD_TXT_MHDON.Text = ma_DH.ToString();
            FillDataDGV(ct_DonHang_BUS.LayDanhSachCTDHBangMaDH(ma_DH));
        }

        private void DH_DGV_CTHD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DH_DGV_CTHD.Rows[e.RowIndex].Height = 40;
        }
    }
}
