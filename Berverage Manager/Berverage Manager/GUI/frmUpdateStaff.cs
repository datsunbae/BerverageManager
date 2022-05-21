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

namespace Berverage_Manager.GUI.Staff
{
    public partial class frmUpdateStaff : Form
    {
        TaiKhoan_BUS taiKhoan_BUS;
        VaiTro_BUS vaiTro_BUS;
        NhanVien_BUS nhanVien_BUS;
        NhapKho_BUS nhapKho_BUS;
        DonHang_BUS donHang_BUS;
        DataGridViewRow row;
        public frmUpdateStaff()
        {
            InitializeComponent();
            taiKhoan_BUS = new TaiKhoan_BUS();
            vaiTro_BUS = new VaiTro_BUS();
            nhanVien_BUS = new NhanVien_BUS();
            nhapKho_BUS = new NhapKho_BUS();
            donHang_BUS = new DonHang_BUS();
        }
        public void LoadCB()
        {
            SNV_CB_VaiTro.DataSource = vaiTro_BUS.LayTatCaVaiTro();
            SNV_CB_VaiTro.DisplayMember = "TENVAITRO";
            SNV_CB_VaiTro.ValueMember = "MAVAITRO";
        }

        private void LoadThongTinNV()
        {
            int rowSelectedUpdate = ucStaff.uc_NhanVien.indexRowSelected;
            row = ucStaff.uc_NhanVien.dgv_NhanVien.Rows[rowSelectedUpdate];
            txtTenNV.Text = row.Cells[1].Value.ToString();
            txtDienThoaiNV.Text = row.Cells[2].Value.ToString();
            txtDiaChiNV.Text = row.Cells[3].Value.ToString();
            txtEmailNV.Text = row.Cells[4].Value.ToString();
            txtMaTaiKhoanNV.Text = row.Cells[5].Value.ToString();
            TAIKHOAN tk = taiKhoan_BUS.LayTaiKhoanBangMTK(txtMaTaiKhoanNV.Text);
            txtMatKhauNV.Text = tk.MATKHAU;
            SNV_CB_VaiTro.SelectedValue = tk.MVAITRO;
        }

        private void frmUpdateStaff_Load(object sender, EventArgs e)
        {
            LoadCB();
            LoadThongTinNV();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(row.Cells[0].Value.ToString());
            String maTK = row.Cells[5].Value.ToString();
            NHANVIEN nv = nhanVien_BUS.LayNhanVienBangMNV(maNV);
            TAIKHOAN tk = taiKhoan_BUS.LayTaiKhoanBangMTK(maTK);
            if (nv != null)
            {
                nv.TENNV = txtTenNV.Text;
                nv.SDTNV = txtDienThoaiNV.Text;
                nv.DIACHINV = txtDiaChiNV.Text;
                nv.EMAILNV = txtEmailNV.Text;
                nv.MATK = txtMaTaiKhoanNV.Text;

                tk.MATKHAU = txtMatKhauNV.Text;
                tk.MVAITRO = SNV_CB_VaiTro.SelectedValue.ToString();

                taiKhoan_BUS.SuaTaiKhoan(tk);
                nhanVien_BUS.SuaNhanVien(nv);

                ucStaff.uc_NhanVien.FillDataDGV(nhanVien_BUS.LayTatCaNhanVien());
                ucSell.uc_BanHang.LoadCBNhanVien();
                ucOder.uc_PhieuNhapKho.FillDataDGV(nhapKho_BUS.LayTatCaPhieuNhapKho());
                ucBill.uc_DonHang.FillDataDGV(donHang_BUS.LayTatCaDonHang());
                this.Close();
            }
        }
    }
}
