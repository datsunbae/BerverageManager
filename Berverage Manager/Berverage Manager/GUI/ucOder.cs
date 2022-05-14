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
        public Guna2DataGridView dgv_PhieuNhapKho;
        NhapKho_BUS nhapKho_BUS;

        public int maPhieuNhapKho;
        public ucOder()
        {
            InitializeComponent();
            uc_PhieuNhapKho = this;
            dgv_PhieuNhapKho = dgvNHAPKHO;
            nhapKho_BUS = new NhapKho_BUS();
        }

        private void btnOder_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder();
            frmOrder.ShowDialog();
        }

        private void btnVỉewOrder_Click(object sender, EventArgs e)
        {
            frmOrderDetails frmOrderDetails = new frmOrderDetails();
            frmOrderDetails.ShowDialog();
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
                    dgvNHAPKHO.Rows[RowNew].Cells[2].Value = item.NHACUNGCAP.TENNCC;
                }
                else
                {
                    dgvNHAPKHO.Rows[RowNew].Cells[2].Value = "Null";
                }

                if (item.IDNV != null)
                {
                    dgvNHAPKHO.Rows[RowNew].Cells[3].Value = item.NHANVIEN.TENNV;
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
    }
}
