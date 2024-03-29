﻿using Berverage_Manager.DataContext;
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
using System.IO;
using System.Drawing.Imaging;

namespace Berverage_Manager.GUI.Staff
{
    public partial class frmAddStaff : Form
    {
        VaiTro_BUS vaiTro_BUS;
        TaiKhoan_BUS taiKhoan_BUS;
        NhanVien_BUS nhanVien_BUS;
        public frmAddStaff()
        {
            InitializeComponent();
            vaiTro_BUS = new VaiTro_BUS();
            taiKhoan_BUS = new TaiKhoan_BUS();
            nhanVien_BUS = new NhanVien_BUS();
        }

        private void LoadCB()
        {
            TNV_CB_VaiTro.DataSource = vaiTro_BUS.LayTatCaVaiTro();
            TNV_CB_VaiTro.DisplayMember = "TENVAITRO";
            TNV_CB_VaiTro.ValueMember = "MAVAITRO";
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text != "" && txtMaTaiKhoanNV.Text != "" && txtMatKhauNV.Text != "")
            {
                if (!(taiKhoan_BUS.KiemTRaMaTaiKhoanTonTai(txtMaTaiKhoanNV.Text)))
                {
                    TAIKHOAN tk = new TAIKHOAN();
                    tk.MADANGNHAP = txtMaTaiKhoanNV.Text;
                    tk.MATKHAU = txtMatKhauNV.Text;
                    tk.EMAIL = txtEmailNV.Text;
                    tk.MVAITRO = TNV_CB_VaiTro.SelectedValue.ToString();

                    NHANVIEN nv = new NHANVIEN();
                    nv.TENNV = txtTenNV.Text;
                    nv.SDTNV = txtDienThoaiNV.Text;
                    nv.DIACHINV = txtDiaChiNV.Text;
                    nv.MATK = txtMaTaiKhoanNV.Text;
                    if(PB_ImgStaff.Image != null)
                    {
                        MemoryStream memoryStream = new MemoryStream();
                        PB_ImgStaff.Image.Save(memoryStream, ImageFormat.Jpeg);
                        nv.HINHANHNV = memoryStream.ToArray();
                    }
                    taiKhoan_BUS.ThemTaiKhoan(tk);
                    nhanVien_BUS.ThemNhanVien(nv);
                    ucStaff.uc_NhanVien.FillDataDGV(nhanVien_BUS.LayTatCaNhanVien());
                    ucSell.uc_BanHang.LoadCBNhanVien();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                }

                
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
        }

        private void frmAddStaff_Load(object sender, EventArgs e)
        {
            LoadCB();
        }

        private void BTN_ChonHinhAnh_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fileName = OpenFileDialog.FileName;
                Image image = Image.FromFile(fileName);
                PB_ImgStaff.Image = image;
            }
        }
    }
}
