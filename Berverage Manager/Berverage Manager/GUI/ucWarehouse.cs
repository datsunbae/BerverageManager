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
    public partial class ucWarehouse : UserControl
    {
        public static ucWarehouse uc_TonKho;
        TonKho_BUS tonKho_BUS;
        SanPham_BUS sanPham_BUS;
        public ucWarehouse()
        {
            InitializeComponent();
            uc_TonKho = this;
            tonKho_BUS = new TonKho_BUS();
            sanPham_BUS = new SanPham_BUS();
        }

        public void FillDataDGV(List<TONKHO> listTonKho)
        {
            dgv_TK.Rows.Clear();
            foreach (var item in listTonKho)
            {
                int RowNew = dgv_TK.Rows.Add();
                dgv_TK.Rows[RowNew].Cells[0].Value = item.IDSP;
                dgv_TK.Rows[RowNew].Cells[1].Value = sanPham_BUS.LaySanPhamBangMSP(item.IDSP.Value).TENSP;
                dgv_TK.Rows[RowNew].Cells[2].Value = item.SLTON;
                dgv_TK.Rows[RowNew].Cells[3].Value = item.SLTONQUIDOI;
            }
        }

        private void dgv_TK_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgv_TK.Rows[e.RowIndex].Height = 40;
        }

        private void ucWarehouse_Load(object sender, EventArgs e)
        {
            FillDataDGV(tonKho_BUS.LayTatCaTonKho());
        }

        private void btnTimTK_Click(object sender, EventArgs e)
        {
            String tenSP = txtTimTK.Text;
            List<TONKHO> lisTK = tonKho_BUS.LayTatCaTonKho();
            List<TONKHO> listTimTK = tonKho_BUS.TimKiemSanPhamTonKho(lisTK, tenSP);

            if (listTimTK.Count > 0)
            {
                FillDataDGV(listTimTK);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Sản Phẩm Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
