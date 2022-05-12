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
using Berverage_Manager.DataContext;

namespace Berverage_Manager.GUI.Supplier
{
    public partial class frmUpdateSupplier : Form
    {
        DataGridViewRow row;
        NhaCungCap_BUS nhaCungCap_BUS;
        public frmUpdateSupplier()
        {
            InitializeComponent();
            nhaCungCap_BUS = new NhaCungCap_BUS();
        }

        private void LoadThongTinNCC()
        {
            int rowSelectedUpdate = ucSupplier.uc_NhaCungCap.indexRowSelected;
            row = ucSupplier.uc_NhaCungCap.dgv_NhaCungCap.Rows[rowSelectedUpdate];
            txtTenNCC.Text = row.Cells[1].Value.ToString();
            txtDienThoaiNCC.Text = row.Cells[2].Value.ToString();
            txtDiaChiNCC.Text = row.Cells[3].Value.ToString();
            txtEmailNCC.Text = row.Cells[4].Value.ToString();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            int maNCC = int.Parse(row.Cells[0].Value.ToString());
            NHACUNGCAP ncc = nhaCungCap_BUS.LayNhaCungCapBangMNCC(maNCC);
            if (ncc != null)
            {
                ncc.TENNCC = txtTenNCC.Text;
                ncc.SDTNCC = txtDienThoaiNCC.Text;
                ncc.DIACHINCC = txtDiaChiNCC.Text;
                ncc.EMAILNCC = txtEmailNCC.Text;

                nhaCungCap_BUS.SuaNhaCungCap(ncc);

                ucSupplier.uc_NhaCungCap.FillDataDGV(nhaCungCap_BUS.LayTatCaNhaCungCap());

                //ucBanHang.bh.LoadNV();

                //List<NHAPKHO> listnk = dBQuanLyBanNGK.NHAPKHOes.ToList();
                //ucNhapKho.nk.FillDataDGV(listnk);

                //List<DONHANG> listdh = dBQuanLyBanNGK.DONHANGs.ToList();
                //ucDonHang.dh.FillDataDGV(listdh);

                this.Close();
            }
        }

        private void frmUpdateSupplier_Load(object sender, EventArgs e)
        {
            LoadThongTinNCC();
        }
    }
}
