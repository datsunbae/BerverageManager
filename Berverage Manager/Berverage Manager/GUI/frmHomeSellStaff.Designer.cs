namespace Berverage_Manager.GUI
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
            this.btnSell.Location = new System.Drawing.Point(16, 166);
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
            this.SidePanel.Location = new System.Drawing.Point(16, 260);
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
            this.btnBill.Location = new System.Drawing.Point(16, 292);
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
            this.btnCustomer.Location = new System.Drawing.Point(16, 395);
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
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(54, 86);
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
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(93, 4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(60, 19);
            this.guna2HtmlLabel5.TabIndex = 8;
            this.guna2HtmlLabel5.Text = "QUẢN LÝ";
            // 
            // SidePanel1
            // 
            this.SidePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.SidePanel1.Controls.Add(this.guna2HtmlLabel5);
            this.SidePanel1.ForeColor = System.Drawing.Color.White;
            this.SidePanel1.Location = new System.Drawing.Point(16, 363);
            this.SidePanel1.Name = "SidePanel1";
            this.SidePanel1.Size = new System.Drawing.Size(248, 26);
            this.SidePanel1.TabIndex = 10;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(78, 46);
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
            this.lbLogout.Location = new System.Drawing.Point(42, 759);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(47, 19);
            this.lbLogout.TabIndex = 1;
            this.lbLogout.Text = "Logout";
            this.lbLogout.Click += new System.EventHandler(this.pcbLogout_Click);
            // 
            // pcbLogout
            // 
            this.pcbLogout.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogout.Image")));
            this.pcbLogout.ImageRotate = 0F;
            this.pcbLogout.Location = new System.Drawing.Point(12, 757);
            this.pcbLogout.Name = "pcbLogout";
            this.pcbLogout.Size = new System.Drawing.Size(24, 28);
            this.pcbLogout.TabIndex = 0;
            this.pcbLogout.TabStop = false;
            this.pcbLogout.Click += new System.EventHandler(this.pcbLogout_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
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
            this.btnProduct.Location = new System.Drawing.Point(143, 292);
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
    }
}