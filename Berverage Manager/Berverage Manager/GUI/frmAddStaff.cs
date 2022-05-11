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

namespace Berverage_Manager.GUI.Staff
{
    public partial class frmAddStaff : Form
    {
        public frmAddStaff()
        {
            InitializeComponent();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text != "")
            {
                NHANVIEN nv = new NHANVIEN();
                nv.TENNV = txtTenNV.Text;
                nv.SDTNV = txtDienThoaiNV.Text;
                nv.DIACHINV = txtDiaChiNV.Text;
                nv.EMAILNV = txtEmailNV.Text;
                nv.MATK = txtMaTaiKhoanNV.Text;

                /*List<NHANVIEN> listNhanVien = dBQuanLyBanNGK.NHANVIENs.ToList();
                ucNhanVien.nv.FillDataDGV(listNhanVien);

                ucBanHang.bh.LoadNV();

                this.Close();*/
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
        }
    }
}
