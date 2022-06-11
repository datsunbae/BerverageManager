using Berverage_Manager.BUS;
using Berverage_Manager.DataContext;
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
    public partial class ucOder : UserControl
    {
        public static ucOder uc_PhieuNhapKho;
        NhapKho_BUS nhapKho_BUS;
        NhaCungCap_BUS nhaCungCap_BUS;
        NhanVien_BUS nhanVien_BUS;

        public int maPhieuNhapKho;
        public ucOder()
        {
            InitializeComponent();
            uc_PhieuNhapKho = this;
            nhapKho_BUS = new NhapKho_BUS();
            nhaCungCap_BUS = new NhaCungCap_BUS();
            nhanVien_BUS = new NhanVien_BUS();
        }

        private void btnOder_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder();
            frmOrder.ShowDialog();
        }

        public void FillDataDGV(List<NHAPKHO> listPhieuNhapKho)
        {
            dgvNHAPKHO.Rows.Clear();
            foreach (var item in listPhieuNhapKho)
            {
                int RowNew = dgvNHAPKHO.Rows.Add();
                dgvNHAPKHO.Rows[RowNew].Cells[0].Value = item.MAPNK;

                dgvNHAPKHO.Rows[RowNew].Cells[1].Value = item.NGAYNHAP.Value.ToString("dd/MM/yyyy");

                if (item.IDNCC != null)
                {
                    dgvNHAPKHO.Rows[RowNew].Cells[2].Value = nhaCungCap_BUS.LayNhaCungCapBangMNCC(item.IDNCC.Value).TENNCC;
                }
                else
                {
                    dgvNHAPKHO.Rows[RowNew].Cells[2].Value = "Null";
                }

                if (item.IDNV != null)
                {
                    dgvNHAPKHO.Rows[RowNew].Cells[3].Value = nhanVien_BUS.LayNhanVienBangMNV(item.IDNV.Value).TENNV;
                }
                else
                {
                    dgvNHAPKHO.Rows[RowNew].Cells[3].Value = "Null";
                }

                dgvNHAPKHO.Rows[RowNew].Cells[4].Value = item.TONGTIEN;
            }
        }

        private void dgvNHAPKHO_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvNHAPKHO.Rows[e.RowIndex].Height = 40;
        }

        private void dgvNHAPKHO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            maPhieuNhapKho = int.Parse(dgvNHAPKHO.Rows[rowIndex].Cells[0].Value.ToString());
        }

        private void ucOder_Load(object sender, EventArgs e)
        {
            FillDataDGV(nhapKho_BUS.LayTatCaPhieuNhapKho());
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            if (dgvNHAPKHO.SelectedRows.Count > 0)
            {
                frmOrderDetails nhapKho = new frmOrderDetails(maPhieuNhapKho);
                nhapKho.ShowDialog();
            }
        }

        private void btnXemDHTheoNgay_Click(object sender, EventArgs e)
        {
            List<NHAPKHO> listTimKiemPNK = nhapKho_BUS.TimKiemPhieuNhapKhoTheoNgay(DTP_DH_TUNGAY.Value.Date, DTP_DH_DENNGAY.Value.Date);

            if (listTimKiemPNK.Count > 0)
            {
                FillDataDGV(listTimKiemPNK);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Phiếu Nhập Kho Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTimNK_TextChanged(object sender, EventArgs e)
        {
            List<NHAPKHO> listTimKiemPNK = nhapKho_BUS.TimKiemPhieuNhapKho(txtTimNK.Text);

            if (txtTimNK.Text != "")
            {
                FillDataDGV(listTimKiemPNK);
            }
            else
            {
                FillDataDGV(nhapKho_BUS.LayTatCaPhieuNhapKho());
            }
        }
    }
}
