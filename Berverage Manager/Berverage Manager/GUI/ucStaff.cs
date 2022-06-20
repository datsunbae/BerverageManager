using Berverage_Manager.GUI.Staff;
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
using Guna.UI2.WinForms;

namespace Berverage_Manager.GUI
{
    public partial class ucStaff : UserControl
    {
        public static ucStaff uc_NhanVien;
        public Guna2DataGridView dgv_NhanVien;
        public int indexRowSelected;
        private NhanVien_BUS nhanVien_BUS;
        private TaiKhoan_BUS taiKhoan_BUS;
        private NhapKho_BUS nhapKho_BUS;
        private DonHang_BUS donHang_BUS;

        public ucStaff()
        {
            InitializeComponent();
            uc_NhanVien = this;
            dgv_NhanVien = dgvNhanVien;
            nhanVien_BUS = new NhanVien_BUS();
            taiKhoan_BUS = new TaiKhoan_BUS();
            nhapKho_BUS = new NhapKho_BUS();
            donHang_BUS = new DonHang_BUS();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmAddStaff addStaff = new frmAddStaff();
            addStaff.ShowDialog();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            frmUpdateStaff editStaff = new frmUpdateStaff();
            editStaff.ShowDialog();
        }

        private void ucStaff_Load(object sender, EventArgs e)
        {
            FillDataDGV(nhanVien_BUS.LayTatCaNhanVien());
        }

        public void FillDataDGV(List<NHANVIEN> listNhanVien)
        {
            dgvNhanVien.Rows.Clear();
            foreach (var item in listNhanVien)
            {
                int RowNew = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[RowNew].Cells[0].Value = item.MANV;
                dgvNhanVien.Rows[RowNew].Cells[1].Value = item.TENNV;
                dgvNhanVien.Rows[RowNew].Cells[2].Value = item.SDTNV;
                dgvNhanVien.Rows[RowNew].Cells[3].Value = item.DIACHINV;
                dgvNhanVien.Rows[RowNew].Cells[4].Value = taiKhoan_BUS.LayTaiKhoanBangMTK(item.MATK).EMAIL;
                dgvNhanVien.Rows[RowNew].Cells[5].Value = item.MATK;
            }
        }

        private void dgvNhanVien_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Height = 40;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowSelected = e.RowIndex;
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                DataGridViewRow row = dgvNhanVien.Rows[indexRowSelected];
                int maNV = int.Parse(row.Cells[0].Value.ToString());
                string maTK = row.Cells[5].Value.ToString();

                nhanVien_BUS.XoaNhanVien(maNV);
                taiKhoan_BUS.XoaTaiKhoan(maTK);

                FillDataDGV(nhanVien_BUS.LayTatCaNhanVien());
                ucSell.uc_BanHang.LoadCBNhanVien();
                ucOder.uc_PhieuNhapKho.FillDataDGV(nhapKho_BUS.LayTatCaPhieuNhapKho());
                ucBill.uc_DonHang.FillDataDGV(donHang_BUS.LayTatCaDonHang());
            }
            
        }

        private void txtTimNV_TextChanged(object sender, EventArgs e)
        {
            String tenNV = txtTimNV.Text;
            List<NHANVIEN> listNV = nhanVien_BUS.LayTatCaNhanVien();
            List<NHANVIEN> listTimNV = nhanVien_BUS.TimKiemNhanVien(listNV, tenNV);

            FillDataDGV(listTimNV);
        }
    }
}
