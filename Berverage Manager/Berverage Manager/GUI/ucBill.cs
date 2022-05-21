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
    public partial class ucBill : UserControl
    {
        public static ucBill uc_DonHang;
        private KhachHang_BUS khachHang_BUS;
        private NhanVien_BUS nhanVien_BUS;
        private DonHang_BUS donHang_BUS;
        public int maDonHang;

        public ucBill()
        {
            InitializeComponent();
            uc_DonHang = this;
            khachHang_BUS = new KhachHang_BUS();
            nhanVien_BUS = new NhanVien_BUS();
            donHang_BUS = new DonHang_BUS();
        }

        private void btn_BillDetails_Click(object sender, EventArgs e)
        {
            
            if (dgvDonHang.SelectedRows.Count > 0)
            {
                frmBillDetails billDetails = new frmBillDetails(maDonHang);
                billDetails.ShowDialog();
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            frmHomeAdmin.home.sell.BringToFront();
        }

        public void FillDataDGV(List<DONHANG> listDonHang)
        {
            dgvDonHang.Rows.Clear();
            foreach (var item in listDonHang)
            {
                int RowNew = dgvDonHang.Rows.Add();
                dgvDonHang.Rows[RowNew].Cells[0].Value = item.MADH;

                dgvDonHang.Rows[RowNew].Cells[1].Value = item.NGAYLAP.Value.ToString("dd/MM/yyyy");

                if (item.IDKH != null)
                {
                    dgvDonHang.Rows[RowNew].Cells[2].Value = khachHang_BUS.LayKhachHangBangMKH(item.IDKH.Value).TENKH;
                }
                else
                {
                    dgvDonHang.Rows[RowNew].Cells[2].Value = "Null";
                }

                if (item.IDNV != null)
                {

                    dgvDonHang.Rows[RowNew].Cells[3].Value = nhanVien_BUS.LayNhanVienBangMNV(item.IDNV.Value).TENNV;
                }
                else
                {
                    dgvDonHang.Rows[RowNew].Cells[3].Value = "Null";
                }

                dgvDonHang.Rows[RowNew].Cells[4].Value = item.TONGTIEN;
            }
        }

        private void ucBill_Load(object sender, EventArgs e)
        {
            FillDataDGV(donHang_BUS.LayTatCaDonHang());
        }

        private void dgvDonHang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvDonHang.Rows[e.RowIndex].Height = 40;
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            maDonHang = int.Parse(dgvDonHang.Rows[rowIndex].Cells[0].Value.ToString());
        }

        private void btnTimDH_Click(object sender, EventArgs e)
        {
            List<DONHANG> listTimKiemDH = donHang_BUS.TimKiemDonHang(txtTimDH.Text);

            if (txtTimDH.Text != "")
            {
                if (listTimKiemDH.Count > 0)
                {
                    FillDataDGV(listTimKiemDH);
                }
                else
                {
                    MessageBox.Show("Không Tìm Thấy Đơn Hàng Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                FillDataDGV(donHang_BUS.LayTatCaDonHang());
            }
        }

        private void btnXemDHTheoNgay_Click(object sender, EventArgs e)
        {
            List<DONHANG> listTimKiemDH = donHang_BUS.TimKiemDonHangTheoNgay(DTP_DH_TUNGAY.Value.Date, DTP_DH_DENNGAY.Value.Date);

            if (listTimKiemDH.Count > 0)
            {
                FillDataDGV(listTimKiemDH);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Đơn Hàng Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
