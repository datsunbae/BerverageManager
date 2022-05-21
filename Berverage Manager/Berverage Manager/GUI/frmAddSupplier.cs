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
    public partial class frmAddSupplier : Form
    {
        NhaCungCap_BUS nhaCungCap_BUS;
        public frmAddSupplier()
        {
            InitializeComponent();
            nhaCungCap_BUS = new NhaCungCap_BUS();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text != "")
            {
                NHACUNGCAP ncc = new NHACUNGCAP();
                ncc.TENNCC = txtTenNCC.Text;
                ncc.SDTNCC = txtDienThoaiNCC.Text;
                ncc.DIACHINCC = txtDiaChiNCC.Text;
                ncc.EMAILNCC = txtEmailNCC.Text;

                nhaCungCap_BUS.ThemNhaCungCap(ncc);

                ucSupplier.uc_NhaCungCap.FillDataDGV(nhaCungCap_BUS.LayTatCaNhaCungCap());

                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
        }
    }
}
