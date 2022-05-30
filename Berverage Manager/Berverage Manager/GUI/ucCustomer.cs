using Berverage_Manager.GUI.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Berverage_Manager.DataContext;
using Berverage_Manager.BUS;
using Guna.UI2.WinForms;

namespace Berverage_Manager.GUI
{
    public partial class ucCustomer : UserControl
    {
        public static ucCustomer uc_KhachHang;
        public Guna2DataGridView dgv_KhachHang;
        public int indexRowSelected;
        private KhachHang_BUS khachHang_BUS;
        private DonHang_BUS donHang_BUS;

        public ucCustomer()
        {
            InitializeComponent();
            uc_KhachHang = this;
            dgv_KhachHang = dgvKhachHang;
            khachHang_BUS = new KhachHang_BUS();
            donHang_BUS = new DonHang_BUS();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomer = new frmAddCustomer();
            addCustomer.ShowDialog();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            frmUpdateCustomer editCustomer = new frmUpdateCustomer();
            editCustomer.ShowDialog();
        }

        public void FillDataDGV(List<KHACHHANG> listKhachHang)
        {
            dgvKhachHang.Rows.Clear();
            foreach (var item in listKhachHang)
            {
                int RowNew = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[RowNew].Cells[0].Value = item.MAKH;
                dgvKhachHang.Rows[RowNew].Cells[1].Value = item.TENKH;
                if (item.GIOITINH != null)
                {
                    if (item.GIOITINH == true)
                    {
                        dgvKhachHang.Rows[RowNew].Cells[2].Value = "Nam";
                    }
                    else
                    {
                        dgvKhachHang.Rows[RowNew].Cells[2].Value = "Nữ";
                    } 
                }
                dgvKhachHang.Rows[RowNew].Cells[3].Value = item.SDTKH;
                dgvKhachHang.Rows[RowNew].Cells[4].Value = item.DIACHIKH;
                dgvKhachHang.Rows[RowNew].Cells[5].Value = item.EMAILKH;
            }
        }

        private void ucCustomer_Load(object sender, EventArgs e)
        {
            FillDataDGV(khachHang_BUS.LayTatCaKhachHang());
        }

        private void dgvKhachHang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvKhachHang.Rows[e.RowIndex].Height = 40;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowSelected = e.RowIndex;
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                DataGridViewRow row = dgvKhachHang.Rows[indexRowSelected];
                int maKH = int.Parse(row.Cells[0].Value.ToString());

                khachHang_BUS.XoaKhachHang(maKH);

                FillDataDGV(khachHang_BUS.LayTatCaKhachHang());
                ucSell.uc_BanHang.LoadCBKhachHang();
                ucBill.uc_DonHang.FillDataDGV(donHang_BUS.LayTatCaDonHang());
            }
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            String tenKH = txtTimKH.Text;
            List<KHACHHANG> listKH = khachHang_BUS.LayTatCaKhachHang();
            List<KHACHHANG> listTimKH = khachHang_BUS.TimKiemKhachHang(listKH, tenKH);

            if (listTimKH.Count > 0)
            {
                FillDataDGV(listTimKH);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Khách Hàng Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
