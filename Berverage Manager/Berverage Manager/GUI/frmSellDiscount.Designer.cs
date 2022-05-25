namespace Berverage_Manager.GUI
{
    partial class frmSellDiscount
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
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BH_DGV_DSSP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clTenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDieuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ADKM_BTN_ApDung = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BH_DGV_DSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(237, 30);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(239, 32);
            this.guna2HtmlLabel9.TabIndex = 273;
            this.guna2HtmlLabel9.TabStop = false;
            this.guna2HtmlLabel9.Text = "ÁP DỤNG KHUYẾN MÃI";
            // 
            // BH_DGV_DSSP
            // 
            this.BH_DGV_DSSP.AllowUserToAddRows = false;
            this.BH_DGV_DSSP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BH_DGV_DSSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BH_DGV_DSSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BH_DGV_DSSP.BackgroundColor = System.Drawing.Color.White;
            this.BH_DGV_DSSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BH_DGV_DSSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BH_DGV_DSSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BH_DGV_DSSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BH_DGV_DSSP.ColumnHeadersHeight = 35;
            this.BH_DGV_DSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCheckBox,
            this.clTenKM,
            this.clLoaiKhuyenMai,
            this.clDieuKien,
            this.clChietKhau});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BH_DGV_DSSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.BH_DGV_DSSP.EnableHeadersVisualStyles = false;
            this.BH_DGV_DSSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BH_DGV_DSSP.Location = new System.Drawing.Point(30, 121);
            this.BH_DGV_DSSP.Name = "BH_DGV_DSSP";
            this.BH_DGV_DSSP.ReadOnly = true;
            this.BH_DGV_DSSP.RowHeadersVisible = false;
            this.BH_DGV_DSSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BH_DGV_DSSP.Size = new System.Drawing.Size(658, 238);
            this.BH_DGV_DSSP.TabIndex = 274;
            this.BH_DGV_DSSP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BH_DGV_DSSP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BH_DGV_DSSP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BH_DGV_DSSP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BH_DGV_DSSP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BH_DGV_DSSP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BH_DGV_DSSP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BH_DGV_DSSP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BH_DGV_DSSP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BH_DGV_DSSP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BH_DGV_DSSP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BH_DGV_DSSP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BH_DGV_DSSP.ThemeStyle.HeaderStyle.Height = 35;
            this.BH_DGV_DSSP.ThemeStyle.ReadOnly = true;
            this.BH_DGV_DSSP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BH_DGV_DSSP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BH_DGV_DSSP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BH_DGV_DSSP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BH_DGV_DSSP.ThemeStyle.RowsStyle.Height = 22;
            this.BH_DGV_DSSP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BH_DGV_DSSP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clCheckBox
            // 
            this.clCheckBox.HeaderText = "";
            this.clCheckBox.Name = "clCheckBox";
            this.clCheckBox.ReadOnly = true;
            // 
            // clTenKM
            // 
            this.clTenKM.HeaderText = "Tên khuyến mãi";
            this.clTenKM.Name = "clTenKM";
            this.clTenKM.ReadOnly = true;
            // 
            // clLoaiKhuyenMai
            // 
            this.clLoaiKhuyenMai.HeaderText = "Loại khuyến mãi";
            this.clLoaiKhuyenMai.Name = "clLoaiKhuyenMai";
            this.clLoaiKhuyenMai.ReadOnly = true;
            // 
            // clDieuKien
            // 
            this.clDieuKien.HeaderText = "Điều kiện";
            this.clDieuKien.Name = "clDieuKien";
            this.clDieuKien.ReadOnly = true;
            // 
            // clChietKhau
            // 
            this.clChietKhau.HeaderText = "Chiết khấu";
            this.clChietKhau.Name = "clChietKhau";
            this.clChietKhau.ReadOnly = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(682, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 275;
            this.guna2ControlBox1.TabStop = false;
            // 
            // ADKM_BTN_ApDung
            // 
            this.ADKM_BTN_ApDung.BorderRadius = 5;
            this.ADKM_BTN_ApDung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ADKM_BTN_ApDung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ADKM_BTN_ApDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ADKM_BTN_ApDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ADKM_BTN_ApDung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.ADKM_BTN_ApDung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADKM_BTN_ApDung.ForeColor = System.Drawing.Color.White;
            this.ADKM_BTN_ApDung.Location = new System.Drawing.Point(521, 381);
            this.ADKM_BTN_ApDung.Name = "ADKM_BTN_ApDung";
            this.ADKM_BTN_ApDung.Size = new System.Drawing.Size(167, 45);
            this.ADKM_BTN_ApDung.TabIndex = 276;
            this.ADKM_BTN_ApDung.TabStop = false;
            this.ADKM_BTN_ApDung.Text = "Áp dụng";
            this.ADKM_BTN_ApDung.Click += new System.EventHandler(this.ADKM_BTN_ApDung_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // frmSellDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 447);
            this.Controls.Add(this.ADKM_BTN_ApDung);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.BH_DGV_DSSP);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSellDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSellDiscount";
            ((System.ComponentModel.ISupportInitialize)(this.BH_DGV_DSSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2DataGridView BH_DGV_DSSP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDieuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChietKhau;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button ADKM_BTN_ApDung;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}