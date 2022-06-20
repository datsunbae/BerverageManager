namespace Berverage_Manager.GUI
{
    partial class frmOrderDetails
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
            this.CTNK_DGV_CTNK = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ctbClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CTNK_TXT_MPhieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CTNK_DGV_CTNK)).BeginInit();
            this.SuspendLayout();
            // 
            // CTNK_DGV_CTNK
            // 
            this.CTNK_DGV_CTNK.AllowUserToAddRows = false;
            this.CTNK_DGV_CTNK.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CTNK_DGV_CTNK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CTNK_DGV_CTNK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CTNK_DGV_CTNK.BackgroundColor = System.Drawing.Color.White;
            this.CTNK_DGV_CTNK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CTNK_DGV_CTNK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CTNK_DGV_CTNK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CTNK_DGV_CTNK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CTNK_DGV_CTNK.ColumnHeadersHeight = 40;
            this.CTNK_DGV_CTNK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.CTNK_DGV_CTNK.DefaultCellStyle = dataGridViewCellStyle3;
            this.CTNK_DGV_CTNK.EnableHeadersVisualStyles = false;
            this.CTNK_DGV_CTNK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CTNK_DGV_CTNK.Location = new System.Drawing.Point(14, 128);
            this.CTNK_DGV_CTNK.Name = "CTNK_DGV_CTNK";
            this.CTNK_DGV_CTNK.ReadOnly = true;
            this.CTNK_DGV_CTNK.RowHeadersVisible = false;
            this.CTNK_DGV_CTNK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CTNK_DGV_CTNK.Size = new System.Drawing.Size(600, 282);
            this.CTNK_DGV_CTNK.TabIndex = 154;
            this.CTNK_DGV_CTNK.TabStop = false;
            this.CTNK_DGV_CTNK.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CTNK_DGV_CTNK.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CTNK_DGV_CTNK.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CTNK_DGV_CTNK.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CTNK_DGV_CTNK.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CTNK_DGV_CTNK.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CTNK_DGV_CTNK.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CTNK_DGV_CTNK.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CTNK_DGV_CTNK.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CTNK_DGV_CTNK.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CTNK_DGV_CTNK.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CTNK_DGV_CTNK.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CTNK_DGV_CTNK.ThemeStyle.HeaderStyle.Height = 40;
            this.CTNK_DGV_CTNK.ThemeStyle.ReadOnly = true;
            this.CTNK_DGV_CTNK.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CTNK_DGV_CTNK.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CTNK_DGV_CTNK.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CTNK_DGV_CTNK.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CTNK_DGV_CTNK.ThemeStyle.RowsStyle.Height = 22;
            this.CTNK_DGV_CTNK.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CTNK_DGV_CTNK.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CTNK_DGV_CTNK.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.CTNK_DGV_CTNK_RowsAdded);
            // 
            // colMSP
            // 
            this.colMSP.HeaderText = "Mã sản phẩm";
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
            this.clDVT.HeaderText = "ĐVT";
            this.clDVT.Name = "clDVT";
            this.clDVT.ReadOnly = true;
            // 
            // clGia
            // 
            this.clGia.HeaderText = "Thành tiền";
            this.clGia.Name = "clGia";
            this.clGia.ReadOnly = true;
            // 
            // Elipse
            // 
            this.Elipse.TargetControl = this;
            // 
            // ctbClose
            // 
            this.ctbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbClose.BackColor = System.Drawing.Color.Transparent;
            this.ctbClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.ctbClose.FillColor = System.Drawing.Color.Transparent;
            this.ctbClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.ctbClose.Location = new System.Drawing.Point(582, 0);
            this.ctbClose.Name = "ctbClose";
            this.ctbClose.Size = new System.Drawing.Size(45, 29);
            this.ctbClose.TabIndex = 158;
            this.ctbClose.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(179, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(274, 32);
            this.guna2HtmlLabel1.TabIndex = 157;
            this.guna2HtmlLabel1.TabStop = false;
            this.guna2HtmlLabel1.Text = "CHI TIẾT PHIẾU NHẬP KHO";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(14, 85);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(53, 17);
            this.guna2HtmlLabel6.TabIndex = 156;
            this.guna2HtmlLabel6.TabStop = false;
            this.guna2HtmlLabel6.Text = "Mã phiếu";
            // 
            // CTNK_TXT_MPhieu
            // 
            this.CTNK_TXT_MPhieu.AutoRoundedCorners = true;
            this.CTNK_TXT_MPhieu.BorderRadius = 17;
            this.CTNK_TXT_MPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CTNK_TXT_MPhieu.DefaultText = "";
            this.CTNK_TXT_MPhieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CTNK_TXT_MPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CTNK_TXT_MPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CTNK_TXT_MPhieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CTNK_TXT_MPhieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CTNK_TXT_MPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CTNK_TXT_MPhieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CTNK_TXT_MPhieu.Location = new System.Drawing.Point(78, 75);
            this.CTNK_TXT_MPhieu.Name = "CTNK_TXT_MPhieu";
            this.CTNK_TXT_MPhieu.PasswordChar = '\0';
            this.CTNK_TXT_MPhieu.PlaceholderText = "";
            this.CTNK_TXT_MPhieu.SelectedText = "";
            this.CTNK_TXT_MPhieu.Size = new System.Drawing.Size(112, 36);
            this.CTNK_TXT_MPhieu.TabIndex = 155;
            this.CTNK_TXT_MPhieu.TabStop = false;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this;
            this.DragControl.UseTransparentDrag = true;
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(626, 422);
            this.Controls.Add(this.CTNK_DGV_CTNK);
            this.Controls.Add(this.ctbClose);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.CTNK_TXT_MPhieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrderDetails";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CTNK_DGV_CTNK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView CTNK_DGV_CTNK;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2ControlBox ctbClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox CTNK_TXT_MPhieu;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGia;
    }
}