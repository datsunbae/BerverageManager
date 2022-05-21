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
        KhachHang_BUS khachHang_BUS;
        NhanVien_BUS nhanVien_BUS;
        DonHang_BUS donHang_BUS;

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
            frmBillDetails billDetails = new frmBillDetails();
            billDetails.ShowDialog();
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
    }
}
