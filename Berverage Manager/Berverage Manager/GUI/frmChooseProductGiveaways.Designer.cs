namespace Berverage_Manager.GUI
{
    partial class frmChooseProductGiveaways
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
            this.CSPT_DGV_DSSPT = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSLTang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CSPT_BTN_ApDung = new Guna.UI2.WinForms.Guna2Button();
            this.CSPT_BTN_QuayLai = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.CSPT_DGV_DSSPT)).BeginInit();
            this.SuspendLayout();
            // 
            // CSPT_DGV_DSSPT
            // 
            this.CSPT_DGV_DSSPT.AllowUserToAddRows = false;
            this.CSPT_DGV_DSSPT.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CSPT_DGV_DSSPT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CSPT_DGV_DSSPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CSPT_DGV_DSSPT.BackgroundColor = System.Drawing.Color.White;
            this.CSPT_DGV_DSSPT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CSPT_DGV_DSSPT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CSPT_DGV_DSSPT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CSPT_DGV_DSSPT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CSPT_DGV_DSSPT.ColumnHeadersHeight = 35;
            this.CSPT_DGV_DSSPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMSP,
            this.clTenSP,
            this.clSLTang,
            this.clDVT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CSPT_DGV_DSSPT.DefaultCellStyle = dataGridViewCellStyle3;
            this.CSPT_DGV_DSSPT.EnableHeadersVisualStyles = false;
            this.CSPT_DGV_DSSPT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CSPT_DGV_DSSPT.Location = new System.Drawing.Point(30, 82);
            this.CSPT_DGV_DSSPT.Name = "CSPT_DGV_DSSPT";
            this.CSPT_DGV_DSSPT.ReadOnly = true;
            this.CSPT_DGV_DSSPT.RowHeadersVisible = false;
            this.CSPT_DGV_DSSPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CSPT_DGV_DSSPT.Size = new System.Drawing.Size(606, 238);
            this.CSPT_DGV_DSSPT.TabIndex = 275;
            this.CSPT_DGV_DSSPT.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CSPT_DGV_DSSPT.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CSPT_DGV_DSSPT.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CSPT_DGV_DSSPT.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CSPT_DGV_DSSPT.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CSPT_DGV_DSSPT.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CSPT_DGV_DSSPT.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CSPT_DGV_DSSPT.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CSPT_DGV_DSSPT.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CSPT_DGV_DSSPT.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CSPT_DGV_DSSPT.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CSPT_DGV_DSSPT.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CSPT_DGV_DSSPT.ThemeStyle.HeaderStyle.Height = 35;
            this.CSPT_DGV_DSSPT.ThemeStyle.ReadOnly = true;
            this.CSPT_DGV_DSSPT.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CSPT_DGV_DSSPT.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CSPT_DGV_DSSPT.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CSPT_DGV_DSSPT.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CSPT_DGV_DSSPT.ThemeStyle.RowsStyle.Height = 22;
            this.CSPT_DGV_DSSPT.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CSPT_DGV_DSSPT.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CSPT_DGV_DSSPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CSPT_DGV_DSSPT_CellClick);
            this.CSPT_DGV_DSSPT.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.CSPT_DGV_DSSPT_RowsAdded);
            // 
            // clMSP
            // 
            this.clMSP.HeaderText = "Mã sản phẩm";
            this.clMSP.Name = "clMSP";
            this.clMSP.ReadOnly = true;
            // 
            // clTenSP
            // 
            this.clTenSP.HeaderText = "Tên sản phẩm";
            this.clTenSP.Name = "clTenSP";
            this.clTenSP.ReadOnly = true;
            // 
            // clSLTang
            // 
            this.clSLTang.HeaderText = "Số lượng tặng";
            this.clSLTang.Name = "clSLTang";
            this.clSLTang.ReadOnly = true;
            // 
            // clDVT
            // 
            this.clDVT.HeaderText = "Đơn vị tính";
            this.clDVT.Name = "clDVT";
            this.clDVT.ReadOnly = true;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(198, 22);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(250, 32);
            this.guna2HtmlLabel9.TabIndex = 276;
            this.guna2HtmlLabel9.TabStop = false;
            this.guna2HtmlLabel9.Text = "CHỌN SẢN PHẨM TẶNG";
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
            // CSPT_BTN_ApDung
            // 
            this.CSPT_BTN_ApDung.BorderRadius = 5;
            this.CSPT_BTN_ApDung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CSPT_BTN_ApDung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CSPT_BTN_ApDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CSPT_BTN_ApDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CSPT_BTN_ApDung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.CSPT_BTN_ApDung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSPT_BTN_ApDung.ForeColor = System.Drawing.Color.White;
            this.CSPT_BTN_ApDung.Location = new System.Drawing.Point(469, 335);
            this.CSPT_BTN_ApDung.Name = "CSPT_BTN_ApDung";
            this.CSPT_BTN_ApDung.Size = new System.Drawing.Size(167, 45);
            this.CSPT_BTN_ApDung.TabIndex = 277;
            this.CSPT_BTN_ApDung.TabStop = false;
            this.CSPT_BTN_ApDung.Text = "Áp dụng";
            this.CSPT_BTN_ApDung.Click += new System.EventHandler(this.CSPT_BTN_ApDung_Click);
            // 
            // CSPT_BTN_QuayLai
            // 
            this.CSPT_BTN_QuayLai.BorderRadius = 5;
            this.CSPT_BTN_QuayLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CSPT_BTN_QuayLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CSPT_BTN_QuayLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CSPT_BTN_QuayLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CSPT_BTN_QuayLai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.CSPT_BTN_QuayLai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSPT_BTN_QuayLai.ForeColor = System.Drawing.Color.White;
            this.CSPT_BTN_QuayLai.Location = new System.Drawing.Point(296, 335);
            this.CSPT_BTN_QuayLai.Name = "CSPT_BTN_QuayLai";
            this.CSPT_BTN_QuayLai.Size = new System.Drawing.Size(167, 45);
            this.CSPT_BTN_QuayLai.TabIndex = 278;
            this.CSPT_BTN_QuayLai.TabStop = false;
            this.CSPT_BTN_QuayLai.Text = "Quay lại";
            this.CSPT_BTN_QuayLai.Click += new System.EventHandler(this.CSPT_BTN_QuayLai_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(629, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 279;
            this.guna2ControlBox1.TabStop = false;
            // 
            // frmChooseProductGiveaways
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 398);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.CSPT_BTN_QuayLai);
            this.Controls.Add(this.CSPT_BTN_ApDung);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.CSPT_DGV_DSSPT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChooseProductGiveaways";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChooseProductGiveaways";
            this.Load += new System.EventHandler(this.frmChooseProductGiveaways_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CSPT_DGV_DSSPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView CSPT_DGV_DSSPT;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button CSPT_BTN_QuayLai;
        private Guna.UI2.WinForms.Guna2Button CSPT_BTN_ApDung;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSLTang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDVT;
    }
}