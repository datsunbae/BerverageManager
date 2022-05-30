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
    public partial class ucDiscount : UserControl
    {
        public int indexRowSelected;
        public static ucDiscount uc_KhuyenMai;
        public Guna2DataGridView dgv_KhuyenMai;
        KhuyenMai_BUS khuyenMai_BUS;
        DoiTuongKhuyenMai_BUS doiTuongKhuyenMai_BUS;
        public ucDiscount()
        {
            InitializeComponent();
            uc_KhuyenMai = this;
            dgv_KhuyenMai = dgvKhuyenMai;
            khuyenMai_BUS = new KhuyenMai_BUS();
            doiTuongKhuyenMai_BUS = new DoiTuongKhuyenMai_BUS();
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            new frmChooseDiscountOrProduct().Show();
        }

        private void btnEditDiscount_Click(object sender, EventArgs e)
        {
            new frmAddOrUpdateDiscountProduct("Update").Show();
        }

        public void FillDataDGV(List<KHUYENMAI> listKM)
        {
            dgvKhuyenMai.Rows.Clear();
            foreach (var item in listKM)
            {
                int RowNew = dgvKhuyenMai.Rows.Add();
                dgvKhuyenMai.Rows[RowNew].Cells[0].Value = item.MAKM;
                dgvKhuyenMai.Rows[RowNew].Cells[1].Value = item.TENKM;
                if (item.SLAPDUNG != null)
                {
                    dgvKhuyenMai.Rows[RowNew].Cells[2].Value = item.SLAPDUNG;
                }
                else
                {
                    dgvKhuyenMai.Rows[RowNew].Cells[2].Value = "Không giới hạn";
                }
                dgvKhuyenMai.Rows[RowNew].Cells[3].Value = item.TUNGAY.Value.ToString("dd/MM/yyyy");
                if(item.DENNGAY != null)
                {
                    dgvKhuyenMai.Rows[RowNew].Cells[4].Value = item.DENNGAY.Value.ToString("dd/MM/yyyy");
                }
                else
                {
                    dgvKhuyenMai.Rows[RowNew].Cells[4].Value = "Không giới hạn";
                }
                dgvKhuyenMai.Rows[RowNew].Cells[5].Value = doiTuongKhuyenMai_BUS.LayTenDoiTuongKhuyenMaiBangMaDTKM(item.MADTKM.Value);
                if (item.TRANGTHAI == true)
                {
                    dgvKhuyenMai.Rows[RowNew].Cells[6].Value = "Đang chạy";
                }
                else
                {
                    dgvKhuyenMai.Rows[RowNew].Cells[6].Value = "Đã dừng";
                }
            }
        }

        private void ucDiscount_Load(object sender, EventArgs e)
        {
            FillDataDGV(khuyenMai_BUS.LayTatCaKhuyenMai());
        }

        private void dgvKhuyenMai_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvKhuyenMai.Rows[e.RowIndex].Height = 40;
        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowSelected = e.RowIndex;
    }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                DataGridViewRow row = dgvKhuyenMai.Rows[indexRowSelected];
                int maKM = int.Parse(row.Cells[0].Value.ToString());
                khuyenMai_BUS.XoaKhuyenMai(maKM);
                FillDataDGV(khuyenMai_BUS.LayTatCaKhuyenMai());
            }
        }
    }
}
