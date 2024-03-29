﻿using System;
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

namespace Berverage_Manager.GUI.Customer
{
    public partial class frmUpdateCustomer : Form
    {
        DataGridViewRow row;
        KhachHang_BUS khachHang_BUS;
        DonHang_BUS donHang_BUS;
        public frmUpdateCustomer()
        {
            InitializeComponent();
            khachHang_BUS = new KhachHang_BUS();
            donHang_BUS = new DonHang_BUS();
        }

        private void LoadThongTinKH()
        {
            int rowSelectedUpdate = ucCustomer.uc_KhachHang.indexRowSelected;
            row = ucCustomer.uc_KhachHang.dgv_KhachHang.Rows[rowSelectedUpdate];
            txtTenKH.Text = row.Cells[1].Value.ToString();
            if(row.Cells[2].Value != null)
            {
                int indexGT = NV_CB_GioiTinh.FindString(row.Cells[2].Value.ToString());
                NV_CB_GioiTinh.SelectedIndex = indexGT;
                txtDienThoaiKH.Text = row.Cells[3].Value.ToString();
                txtDiaChiKH.Text = row.Cells[4].Value.ToString();
                txtEmailKH.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            int maKH = int.Parse(row.Cells[0].Value.ToString());
            KHACHHANG kh = khachHang_BUS.LayKhachHangBangMKH(maKH);
            if (kh != null)
            {
                kh.TENKH = txtTenKH.Text;
                if (NV_CB_GioiTinh.SelectedIndex == 0)
                {
                    kh.GIOITINH = true;
                }
                else
                {
                    kh.GIOITINH = false;
                }
                kh.SDTKH = txtDienThoaiKH.Text;
                kh.DIACHIKH = txtDiaChiKH.Text;
                kh.EMAILKH = txtEmailKH.Text;

                khachHang_BUS.SuaKhachHang(kh);

                ucCustomer.uc_KhachHang.FillDataDGV(khachHang_BUS.LayTatCaKhachHang());
                ucSell.uc_BanHang.LoadCBKhachHang();
                ucBill.uc_DonHang.FillDataDGV(donHang_BUS.LayTatCaDonHang());

                this.Close();
            }
        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            LoadThongTinKH();
        }
    }
}
