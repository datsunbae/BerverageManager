using Berverage_Manager.BUS;
using Berverage_Manager.DataContext;
using Berverage_Manager.GUI.Supplier;
using Guna.UI2.WinForms;
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
    public partial class ucSupplier : UserControl
    {
        public static ucSupplier uc_NhaCungCap;
        public Guna2DataGridView dgv_NhaCungCap;
        public int indexRowSelected;
        public NhaCungCap_BUS nhaCungCap_BUS;
        private NhapKho_BUS nhapKho_BUS;

        public ucSupplier()
        {
            InitializeComponent();
            uc_NhaCungCap = this;
            dgv_NhaCungCap = dgvNhaCungCap;
            nhaCungCap_BUS = new NhaCungCap_BUS();
            nhapKho_BUS = new NhapKho_BUS();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmAddSupplier addSupplier = new frmAddSupplier();
            addSupplier.ShowDialog();
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            frmUpdateSupplier editSupplier = new frmUpdateSupplier();
            editSupplier.ShowDialog();
        }

        public void FillDataDGV(List<NHACUNGCAP> listNhaCungCap)
        {
            dgvNhaCungCap.Rows.Clear();
            foreach (var item in listNhaCungCap)
            {
                int RowNew = dgvNhaCungCap.Rows.Add();
                dgvNhaCungCap.Rows[RowNew].Cells[0].Value = item.MANCC;
                dgvNhaCungCap.Rows[RowNew].Cells[1].Value = item.TENNCC;
                dgvNhaCungCap.Rows[RowNew].Cells[2].Value = item.SDTNCC;
                dgvNhaCungCap.Rows[RowNew].Cells[3].Value = item.DIACHINCC;
                dgvNhaCungCap.Rows[RowNew].Cells[4].Value = item.EMAILNCC;
            }
        }

        private void ucSupplier_Load(object sender, EventArgs e)
        {
            FillDataDGV(nhaCungCap_BUS.LayTatCaNhaCungCap());
        }

        private void dgvNhaCungCap_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvNhaCungCap.Rows[e.RowIndex].Height = 40;
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowSelected = e.RowIndex;
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                DataGridViewRow row = dgvNhaCungCap.Rows[indexRowSelected];
                int maNCC = int.Parse(row.Cells[0].Value.ToString());

                nhaCungCap_BUS.XoaNhaCungCap(maNCC);

                FillDataDGV(nhaCungCap_BUS.LayTatCaNhaCungCap());
                ucOder.uc_PhieuNhapKho.FillDataDGV(nhapKho_BUS.LayTatCaPhieuNhapKho());
            }
        }

        private void btnTimNCC_Click(object sender, EventArgs e)
        {
            String tenNCC = txtTimNCC.Text;
            List<NHACUNGCAP> listNCC = nhaCungCap_BUS.LayTatCaNhaCungCap();
            List<NHACUNGCAP> listTimNCC = nhaCungCap_BUS.TimKiemNhaCungCap(listNCC, tenNCC);

            if (listTimNCC.Count > 0)
            {
                FillDataDGV(listTimNCC);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Nhà Cung Cấp Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
