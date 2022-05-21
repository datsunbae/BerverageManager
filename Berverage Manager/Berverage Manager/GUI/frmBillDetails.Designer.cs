namespace Berverage_Manager.GUI
{
    partial class frmBillDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DH_DGV_CTHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CTHD_TXT_MHDON = new Guna.UI2.WinForms.Guna2TextBox();
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ctbClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.colMSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DH_DGV_CTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // DH_DGV_CTHD
            // 
            this.DH_DGV_CTHD.AllowUserToAddRows = false;
            this.DH_DGV_CTHD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DH_DGV_CTHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DH_DGV_CTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DH_DGV_CTHD.BackgroundColor = System.Drawing.Color.White;
            this.DH_DGV_CTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DH_DGV_CTHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DH_DGV_CTHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DH_DGV_CTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DH_DGV_CTHD.ColumnHeadersHeight = 40;
            this.DH_DGV_CTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSP,
            this.clTenSP,
            this.clSoLuong,
            this.clDVT,
            this.clGia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DH_DGV_CTHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.DH_DGV_CTHD.EnableHeadersVisualStyles = false;
            this.DH_DGV_CTHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DH_DGV_CTHD.Location = new System.Drawing.Point(14, 132);
            this.DH_DGV_CTHD.Name = "DH_DGV_CTHD";
            this.DH_DGV_CTHD.ReadOnly = true;
            this.DH_DGV_CTHD.RowHeadersVisible = false;
            this.DH_DGV_CTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DH_DGV_CTHD.Size = new System.Drawing.Size(525, 237);
            this.DH_DGV_CTHD.TabIndex = 157;
            this.DH_DGV_CTHD.TabStop = false;
            this.DH_DGV_CTHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DH_DGV_CTHD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DH_DGV_CTHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DH_DGV_CTHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DH_DGV_CTHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DH_DGV_CTHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DH_DGV_CTHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DH_DGV_CTHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DH_DGV_CTHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DH_DGV_CTHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DH_DGV_CTHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DH_DGV_CTHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DH_DGV_CTHD.ThemeStyle.HeaderStyle.Height = 40;
            this.DH_DGV_CTHD.ThemeStyle.ReadOnly = true;
            this.DH_DGV_CTHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DH_DGV_CTHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DH_DGV_CTHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DH_DGV_CTHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DH_DGV_CTHD.ThemeStyle.RowsStyle.Height = 22;
            this.DH_DGV_CTHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DH_DGV_CTHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DH_DGV_CTHD.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DH_DGV_CTHD_RowsAdded);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(191, 21);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(194, 32);
            this.guna2HtmlLabel1.TabIndex = 160;
            this.guna2HtmlLabel1.TabStop = false;
            this.guna2HtmlLabel1.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(15, 91);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(74, 17);
            this.guna2HtmlLabel6.TabIndex = 159;
            this.guna2HtmlLabel6.TabStop = false;
            this.guna2HtmlLabel6.Text = "Mã đơn hàng";
            // 
            // CTHD_TXT_MHDON
            // 
            this.CTHD_TXT_MHDON.BorderRadius = 5;
            this.CTHD_TXT_MHDON.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CTHD_TXT_MHDON.DefaultText = "";
            this.CTHD_TXT_MHDON.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CTHD_TXT_MHDON.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CTHD_TXT_MHDON.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CTHD_TXT_MHDON.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CTHD_TXT_MHDON.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CTHD_TXT_MHDON.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CTHD_TXT_MHDON.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CTHD_TXT_MHDON.Location = new System.Drawing.Point(93, 82);
            this.CTHD_TXT_MHDON.Name = "CTHD_TXT_MHDON";
            this.CTHD_TXT_MHDON.PasswordChar = '\0';
            this.CTHD_TXT_MHDON.PlaceholderText = "";
            this.CTHD_TXT_MHDON.SelectedText = "";
            this.CTHD_TXT_MHDON.Size = new System.Drawing.Size(112, 36);
            this.CTHD_TXT_MHDON.TabIndex = 158;
            this.CTHD_TXT_MHDON.TabStop = false;
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // ctbClose
            // 
            this.ctbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbClose.BackColor = System.Drawing.Color.Transparent;
            this.ctbClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.ctbClose.FillColor = System.Drawing.Color.Transparent;
            this.ctbClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.ctbClose.Location = new System.Drawing.Point(506, 0);
            this.ctbClose.Name = "ctbClose";
            this.ctbClose.Size = new System.Drawing.Size(45, 29);
            this.ctbClose.TabIndex = 161;
            this.ctbClose.TabStop = false;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this;
            this.DragControl.UseTransparentDrag = true;
            // 
            // colMSP
            // 
            this.colMSP.HeaderText = "MSP";
            this.colMSP.Name = "colMSP";
            this.colMSP.ReadOnly = true;
            // 
            // clTenSP
            // 
            this.clTenSP.HeaderText = "Tên sản phẩm";
            this.clTenSP.Name = "clTenSP";
            this.clTenSP.ReadOnly = true;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clDVT
            // 
            this.clDVT.HeaderText = "Đơn vị tính";
            this.clDVT.Name = "clDVT";
            this.clDVT.ReadOnly = true;
            // 
            // clGia
            // 
            this.clGia.HeaderText = "Thành tiền";
            this.clGia.Name = "clGia";
            this.clGia.ReadOnly = true;
            // 
            // frmBillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(551, 381);
            this.Controls.Add(this.DH_DGV_CTHD);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.CTHD_TXT_MHDON);
            this.Controls.Add(this.ctbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBillDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBillDetails";
            this.Load += new System.EventHandler(this.frmBillDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DH_DGV_CTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DH_DGV_CTHD;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox CTHD_TXT_MHDON;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2ControlBox ctbClose;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGia;
    }
}