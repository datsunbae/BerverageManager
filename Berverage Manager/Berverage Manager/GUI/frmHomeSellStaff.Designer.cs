﻿namespace Berverage_Manager.GUI
{
    partial class frmHomeSellStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomeSellStaff));
            this.Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnSell = new Guna.UI2.WinForms.Guna2Button();
            this.SidePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pcbClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SidePanel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbLogout = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pcbLogout = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.LB_CaiDat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BTN_CaiDat = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnStatistical = new Guna.UI2.WinForms.Guna2Button();
            this.LB_VaiTro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LB_Ten = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PB_ImgStaff = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseSidePanel = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseSidePanel1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseSidePanel2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClose)).BeginInit();
            this.SidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogout)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CaiDat)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ImgStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel.Location = new System.Drawing.Point(290, 38);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1110, 762);
            this.Panel.TabIndex = 21;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this;
            this.DragControl.UseTransparentDrag = true;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Transparent;
            this.btnSell.BorderRadius = 6;
            this.btnSell.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSell.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSell.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSell.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSell.FillColor = System.Drawing.Color.White;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.btnSell.Image = ((System.Drawing.Image)(resources.GetObject("btnSell.Image")));
            this.btnSell.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSell.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSell.Location = new System.Drawing.Point(21, 313);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(248, 63);
            this.btnSell.TabIndex = 11;
            this.btnSell.Text = "BÁN HÀNG";
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.SidePanel.Controls.Add(this.guna2HtmlLabel4);
            this.SidePanel.ForeColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(21, 397);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(248, 26);
            this.SidePanel.TabIndex = 9;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(56, 3);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(133, 19);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "QUẢN LÝ BÁN HÀNG";
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.Transparent;
            this.btnBill.BorderRadius = 5;
            this.btnBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBill.FillColor = System.Drawing.Color.White;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(174)))), ((int)(((byte)(235)))));
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBill.Location = new System.Drawing.Point(21, 429);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(121, 42);
            this.btnBill.TabIndex = 6;
            this.btnBill.Text = "Đơn hàng";
            this.btnBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BorderRadius = 5;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.White;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(174)))), ((int)(((byte)(235)))));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.Location = new System.Drawing.Point(21, 521);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(248, 42);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(54, 71);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(172, 30);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Bán Nước Giải Khát";
            // 
            // pcbClose
            // 
            this.pcbClose.Image = ((System.Drawing.Image)(resources.GetObject("pcbClose.Image")));
            this.pcbClose.ImageRotate = 0F;
            this.pcbClose.Location = new System.Drawing.Point(1364, 6);
            this.pcbClose.Name = "pcbClose";
            this.pcbClose.Size = new System.Drawing.Size(25, 26);
            this.pcbClose.TabIndex = 20;
            this.pcbClose.TabStop = false;
            this.pcbClose.Click += new System.EventHandler(this.pcbClose_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(54, 4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(151, 19);
            this.guna2HtmlLabel5.TabIndex = 8;
            this.guna2HtmlLabel5.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // SidePanel1
            // 
            this.SidePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.SidePanel1.Controls.Add(this.guna2HtmlLabel5);
            this.SidePanel1.ForeColor = System.Drawing.Color.White;
            this.SidePanel1.Location = new System.Drawing.Point(21, 489);
            this.SidePanel1.Name = "SidePanel1";
            this.SidePanel1.Size = new System.Drawing.Size(248, 26);
            this.SidePanel1.TabIndex = 10;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(78, 31);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(120, 39);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "QUẢN LÝ";
            // 
            // lbLogout
            // 
            this.lbLogout.BackColor = System.Drawing.Color.Transparent;
            this.lbLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.ForeColor = System.Drawing.Color.White;
            this.lbLogout.Location = new System.Drawing.Point(143, 761);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(67, 19);
            this.lbLogout.TabIndex = 1;
            this.lbLogout.Text = "Đăng xuất";
            this.lbLogout.Click += new System.EventHandler(this.pcbLogout_Click);
            // 
            // pcbLogout
            // 
            this.pcbLogout.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogout.Image")));
            this.pcbLogout.ImageRotate = 0F;
            this.pcbLogout.Location = new System.Drawing.Point(113, 758);
            this.pcbLogout.Name = "pcbLogout";
            this.pcbLogout.Size = new System.Drawing.Size(24, 28);
            this.pcbLogout.TabIndex = 0;
            this.pcbLogout.TabStop = false;
            this.pcbLogout.Click += new System.EventHandler(this.pcbLogout_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2Panel1.Controls.Add(this.LB_CaiDat);
            this.guna2Panel1.Controls.Add(this.BTN_CaiDat);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.btnStatistical);
            this.guna2Panel1.Controls.Add(this.LB_VaiTro);
            this.guna2Panel1.Controls.Add(this.LB_Ten);
            this.guna2Panel1.Controls.Add(this.PB_ImgStaff);
            this.guna2Panel1.Controls.Add(this.btnProduct);
            this.guna2Panel1.Controls.Add(this.btnSell);
            this.guna2Panel1.Controls.Add(this.SidePanel1);
            this.guna2Panel1.Controls.Add(this.SidePanel);
            this.guna2Panel1.Controls.Add(this.btnBill);
            this.guna2Panel1.Controls.Add(this.btnCustomer);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.lbLogout);
            this.guna2Panel1.Controls.Add(this.pcbLogout);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(290, 800);
            this.guna2Panel1.TabIndex = 19;
            // 
            // LB_CaiDat
            // 
            this.LB_CaiDat.BackColor = System.Drawing.Color.Transparent;
            this.LB_CaiDat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CaiDat.ForeColor = System.Drawing.Color.White;
            this.LB_CaiDat.Location = new System.Drawing.Point(52, 762);
            this.LB_CaiDat.Name = "LB_CaiDat";
            this.LB_CaiDat.Size = new System.Drawing.Size(46, 19);
            this.LB_CaiDat.TabIndex = 24;
            this.LB_CaiDat.Text = "Cài đặt";
            this.LB_CaiDat.Click += new System.EventHandler(this.LB_CaiDat_Click);
            // 
            // BTN_CaiDat
            // 
            this.BTN_CaiDat.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CaiDat.Image")));
            this.BTN_CaiDat.ImageRotate = 0F;
            this.BTN_CaiDat.Location = new System.Drawing.Point(22, 758);
            this.BTN_CaiDat.Name = "BTN_CaiDat";
            this.BTN_CaiDat.Size = new System.Drawing.Size(24, 28);
            this.BTN_CaiDat.TabIndex = 23;
            this.BTN_CaiDat.TabStop = false;
            this.BTN_CaiDat.Click += new System.EventHandler(this.BTN_CaiDat_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.ForeColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(21, 579);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(248, 26);
            this.guna2Panel2.TabIndex = 21;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(87, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(69, 19);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "THỐNG KÊ";
            // 
            // btnStatistical
            // 
            this.btnStatistical.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistical.BorderRadius = 5;
            this.btnStatistical.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistical.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistical.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatistical.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatistical.FillColor = System.Drawing.Color.White;
            this.btnStatistical.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(174)))), ((int)(((byte)(235)))));
            this.btnStatistical.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistical.Image")));
            this.btnStatistical.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistical.Location = new System.Drawing.Point(21, 611);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(248, 42);
            this.btnStatistical.TabIndex = 20;
            this.btnStatistical.Text = "Thống kê";
            this.btnStatistical.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // LB_VaiTro
            // 
            this.LB_VaiTro.AutoSize = false;
            this.LB_VaiTro.BackColor = System.Drawing.Color.Transparent;
            this.LB_VaiTro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_VaiTro.ForeColor = System.Drawing.Color.White;
            this.LB_VaiTro.Location = new System.Drawing.Point(21, 238);
            this.LB_VaiTro.Name = "LB_VaiTro";
            this.LB_VaiTro.Size = new System.Drawing.Size(248, 31);
            this.LB_VaiTro.TabIndex = 18;
            this.LB_VaiTro.Text = "VAI TRÒ";
            this.LB_VaiTro.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Ten
            // 
            this.LB_Ten.AutoSize = false;
            this.LB_Ten.BackColor = System.Drawing.Color.Transparent;
            this.LB_Ten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Ten.ForeColor = System.Drawing.Color.White;
            this.LB_Ten.Location = new System.Drawing.Point(8, 209);
            this.LB_Ten.Name = "LB_Ten";
            this.LB_Ten.Size = new System.Drawing.Size(272, 31);
            this.LB_Ten.TabIndex = 17;
            this.LB_Ten.Text = "HỌ VÀ TÊN";
            this.LB_Ten.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_ImgStaff
            // 
            this.PB_ImgStaff.ImageRotate = 0F;
            this.PB_ImgStaff.Location = new System.Drawing.Point(92, 121);
            this.PB_ImgStaff.Name = "PB_ImgStaff";
            this.PB_ImgStaff.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PB_ImgStaff.Size = new System.Drawing.Size(88, 79);
            this.PB_ImgStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_ImgStaff.TabIndex = 16;
            this.PB_ImgStaff.TabStop = false;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.BorderRadius = 5;
            this.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduct.FillColor = System.Drawing.Color.White;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(174)))), ((int)(((byte)(235)))));
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.Location = new System.Drawing.Point(148, 429);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(121, 42);
            this.btnProduct.TabIndex = 12;
            this.btnProduct.Text = "Sản phẩm";
            this.btnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 10;
            this.Elipse.TargetControl = this;
            // 
            // ElipseSidePanel
            // 
            this.ElipseSidePanel.TargetControl = this.SidePanel;
            // 
            // ElipseSidePanel1
            // 
            this.ElipseSidePanel1.TargetControl = this.SidePanel1;
            // 
            // frmHomeSellStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.pcbClose);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomeSellStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHomeStaffSell";
            this.Load += new System.EventHandler(this.frmHomeSellStaff_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClose)).EndInit();
            this.SidePanel1.ResumeLayout(false);
            this.SidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogout)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CaiDat)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ImgStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private Guna.UI2.WinForms.Guna2Panel Panel;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Button btnSell;
        private Guna.UI2.WinForms.Guna2Panel SidePanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button btnBill;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2PictureBox pcbClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Panel SidePanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbLogout;
        private Guna.UI2.WinForms.Guna2PictureBox pcbLogout;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2Elipse ElipseSidePanel;
        private Guna.UI2.WinForms.Guna2Elipse ElipseSidePanel1;
        private Guna.UI2.WinForms.Guna2Elipse ElipseSidePanel2;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel LB_VaiTro;
        private Guna.UI2.WinForms.Guna2HtmlLabel LB_Ten;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PB_ImgStaff;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnStatistical;
        private Guna.UI2.WinForms.Guna2HtmlLabel LB_CaiDat;
        private Guna.UI2.WinForms.Guna2PictureBox BTN_CaiDat;
    }
}