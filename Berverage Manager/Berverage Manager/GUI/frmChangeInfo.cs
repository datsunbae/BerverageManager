﻿using Berverage_Manager.BUS;
using Berverage_Manager.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berverage_Manager.GUI
{
    public partial class frmChangeInfo : Form
    {
        NHANVIEN nhanVien;
        NhanVien_BUS nhanVien_BUS;
        DonHang_BUS donHang_BUS;
        NhapKho_BUS nhapKho_BUS;
        int vaiTro;
        public frmChangeInfo()
        {
            InitializeComponent();
            nhanVien_BUS = new NhanVien_BUS();
            donHang_BUS = new DonHang_BUS();
            nhapKho_BUS = new NhapKho_BUS();
            vaiTro = frmLogin.frm_Login.vaiTro;
            getNhanVienTheoVaiTro();
        }

        private void getNhanVienTheoVaiTro()
        {
            switch (vaiTro)
            {
                case 1:
                    nhanVien = frmHomeAdmin.frm_HomeAdmin.nhanVien;
                    break;
                case 2:
                    nhanVien = frmHomeSellStaff.frm_HomeSellStaff.nhanVien;
                    break;
                case 3:
                    nhanVien = frmHomeStaffWarehouse.frm_HomeStaffWarehouse.nhanVien;
                    break;
            }
        }

        private void LoadThongTin()
        {
            TXT_Ten.Text = nhanVien.TENNV;
            TXT_SoDienThoai.Text = nhanVien.SDTNV;
            TXT_Email.Text = nhanVien.EMAILNV;
            TXT_DiaChi.Text = nhanVien.DIACHINV;
            if(nhanVien.HINHANHNV != null)
            {
                MemoryStream memoryStream = new MemoryStream(nhanVien.HINHANHNV.ToArray());
                Image img = Image.FromStream(memoryStream);
                IMG_NhanVien.Image = img;
            }
        }

        private void frmChangeInfo_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void BTN_ChonHinhAnh_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fileName = OpenFileDialog.FileName;
                Image image = Image.FromFile(fileName);
                IMG_NhanVien.Image = image;
            }
        }

        private void BTN_Luu_Click(object sender, EventArgs e)
        {
            if (nhanVien != null)
            {
                nhanVien.TENNV = TXT_Ten.Text;
                nhanVien.SDTNV = TXT_SoDienThoai.Text;
                nhanVien.DIACHINV = TXT_DiaChi.Text;
                nhanVien.EMAILNV = TXT_Email.Text;
                MemoryStream memoryStream = new MemoryStream();
                IMG_NhanVien.Image.Save(memoryStream, ImageFormat.Jpeg);
                nhanVien.HINHANHNV = memoryStream.ToArray();
                nhanVien_BUS.SuaNhanVien(nhanVien);

                switch (vaiTro)
                {
                    case 1:
                        ucStaff.uc_NhanVien.FillDataDGV(nhanVien_BUS.LayTatCaNhanVien());
                        ucSell.uc_BanHang.LoadCBNhanVien();
                        ucOder.uc_PhieuNhapKho.FillDataDGV(nhapKho_BUS.LayTatCaPhieuNhapKho());
                        ucBill.uc_DonHang.FillDataDGV(donHang_BUS.LayTatCaDonHang());
                        frmHomeAdmin.frm_HomeAdmin.LoadThongTinNhanVien();
                        break;
                    case 2:
                        ucSell.uc_BanHang.LoadCBNhanVien();
                        ucBill.uc_DonHang.FillDataDGV(donHang_BUS.LayTatCaDonHang());
                        frmHomeSellStaff.frm_HomeSellStaff.LoadThongTinNhanVien();
                        break;
                    case 3:
                        ucOder.uc_PhieuNhapKho.FillDataDGV(nhapKho_BUS.LayTatCaPhieuNhapKho());
                        frmHomeStaffWarehouse.frm_HomeStaffWarehouse.LoadThongTinNhanVien();
                        break;

                }
                this.Close();
            }
        }
    }
}
