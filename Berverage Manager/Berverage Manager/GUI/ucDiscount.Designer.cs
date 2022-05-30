namespace Berverage_Manager.GUI
{
    partial class ucDiscount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDiscount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnShowDiscount = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddDiscount = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteDiscount = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditDiscount = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKhuyenMai = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtTimKhuyenMai = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvKhuyenMai = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTGBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTGKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDoiTuongKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2Panel2.Controls.Add(this.btnShowDiscount);
            this.guna2Panel2.Controls.Add(this.btnAddDiscount);
            this.guna2Panel2.Controls.Add(this.btnDeleteDiscount);
            this.guna2Panel2.Controls.Add(this.btnEditDiscount);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1110, 45);
            this.guna2Panel2.TabIndex = 92;
            // 
            // btnShowDiscount
            // 
            this.btnShowDiscount.BorderRadius = 5;
            this.btnShowDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowDiscount.FillColor = System.Drawing.Color.White;
            this.btnShowDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.btnShowDiscount.Location = new System.Drawing.Point(642, 4);
            this.btnShowDiscount.Name = "btnShowDiscount";
            this.btnShowDiscount.Size = new System.Drawing.Size(111, 36);
            this.btnShowDiscount.TabIndex = 34;
            this.btnShowDiscount.Text = "Xem khuyến mãi";
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.BorderRadius = 5;
            this.btnAddDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDiscount.FillColor = System.Drawing.Color.White;
            this.btnAddDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.btnAddDiscount.Location = new System.Drawing.Point(760, 4);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(111, 36);
            this.btnAddDiscount.TabIndex = 33;
            this.btnAddDiscount.Text = "Tạo mới";
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // btnDeleteDiscount
            // 
            this.btnDeleteDiscount.BorderRadius = 5;
            this.btnDeleteDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteDiscount.FillColor = System.Drawing.Color.White;
            this.btnDeleteDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.btnDeleteDiscount.Location = new System.Drawing.Point(877, 4);
            this.btnDeleteDiscount.Name = "btnDeleteDiscount";
            this.btnDeleteDiscount.Size = new System.Drawing.Size(111, 36);
            this.btnDeleteDiscount.TabIndex = 33;
            this.btnDeleteDiscount.Text = "Xóa";
            this.btnDeleteDiscount.Click += new System.EventHandler(this.btnDeleteDiscount_Click);
            // 
            // btnEditDiscount
            // 
            this.btnEditDiscount.BorderRadius = 5;
            this.btnEditDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditDiscount.FillColor = System.Drawing.Color.White;
            this.btnEditDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.btnEditDiscount.Location = new System.Drawing.Point(994, 4);
            this.btnEditDiscount.Name = "btnEditDiscount";
            this.btnEditDiscount.Size = new System.Drawing.Size(111, 36);
            this.btnEditDiscount.TabIndex = 32;
            this.btnEditDiscount.Text = "Sửa";
            this.btnEditDiscount.Click += new System.EventHandler(this.btnEditDiscount_Click);
            // 
            // btnTimKhuyenMai
            // 
            this.btnTimKhuyenMai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKhuyenMai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKhuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKhuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKhuyenMai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.btnTimKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btnTimKhuyenMai.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKhuyenMai.Image")));
            this.btnTimKhuyenMai.Location = new System.Drawing.Point(321, 63);
            this.btnTimKhuyenMai.Name = "btnTimKhuyenMai";
            this.btnTimKhuyenMai.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnTimKhuyenMai.Size = new System.Drawing.Size(36, 36);
            this.btnTimKhuyenMai.TabIndex = 98;
            // 
            // txtTimKhuyenMai
            // 
            this.txtTimKhuyenMai.BorderRadius = 5;
            this.txtTimKhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKhuyenMai.DefaultText = "";
            this.txtTimKhuyenMai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKhuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKhuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKhuyenMai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKhuyenMai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKhuyenMai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKhuyenMai.Location = new System.Drawing.Point(19, 63);
            this.txtTimKhuyenMai.Name = "txtTimKhuyenMai";
            this.txtTimKhuyenMai.PasswordChar = '\0';
            this.txtTimKhuyenMai.PlaceholderText = "Tìm kiếm khuyến mãi";
            this.txtTimKhuyenMai.SelectedText = "";
            this.txtTimKhuyenMai.Size = new System.Drawing.Size(296, 36);
            this.txtTimKhuyenMai.TabIndex = 97;
            // 
            // dgvKhuyenMai
            // 
            this.dgvKhuyenMai.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhuyenMai.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhuyenMai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhuyenMai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhuyenMai.ColumnHeadersHeight = 40;
            this.dgvKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMKM,
            this.clTenKM,
            this.clSL,
            this.clTGBatDau,
            this.clTGKetThuc,
            this.clDoiTuongKH,
            this.clTrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhuyenMai.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhuyenMai.EnableHeadersVisualStyles = false;
            this.dgvKhuyenMai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhuyenMai.Location = new System.Drawing.Point(0, 159);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.RowHeadersVisible = false;
            this.dgvKhuyenMai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(1110, 620);
            this.dgvKhuyenMai.TabIndex = 100;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhuyenMai.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKhuyenMai.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvKhuyenMai.ThemeStyle.ReadOnly = false;
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.Height = 22;
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhuyenMai.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhuyenMai_CellClick);
            this.dgvKhuyenMai.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvKhuyenMai_RowsAdded);
            // 
            // clMKM
            // 
            this.clMKM.HeaderText = "Mã KM";
            this.clMKM.Name = "clMKM";
            // 
            // clTenKM
            // 
            this.clTenKM.HeaderText = "Tên khuyến mãi";
            this.clTenKM.Name = "clTenKM";
            // 
            // clSL
            // 
            this.clSL.HeaderText = "Số phiếu áp dụng";
            this.clSL.Name = "clSL";
            // 
            // clTGBatDau
            // 
            this.clTGBatDau.HeaderText = "Bắt đầu";
            this.clTGBatDau.Name = "clTGBatDau";
            // 
            // clTGKetThuc
            // 
            this.clTGKetThuc.HeaderText = "Kết thúc";
            this.clTGKetThuc.Name = "clTGKetThuc";
            // 
            // clDoiTuongKH
            // 
            this.clDoiTuongKH.HeaderText = "Đối tượng";
            this.clDoiTuongKH.Name = "clDoiTuongKH";
            // 
            // clTrangThai
            // 
            this.clTrangThai.HeaderText = "Trạng thái";
            this.clTrangThai.Name = "clTrangThai";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2Panel4.Controls.Add(this.label2);
            this.guna2Panel4.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel4.Location = new System.Drawing.Point(0, 117);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1110, 42);
            this.guna2Panel4.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khuyến mãi";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(4, 4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(33, 32);
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // ucDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvKhuyenMai);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.btnTimKhuyenMai);
            this.Controls.Add(this.txtTimKhuyenMai);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "ucDiscount";
            this.Size = new System.Drawing.Size(1110, 762);
            this.Load += new System.EventHandler(this.ucDiscount_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnAddDiscount;
        private Guna.UI2.WinForms.Guna2Button btnDeleteDiscount;
        private Guna.UI2.WinForms.Guna2Button btnEditDiscount;
        private Guna.UI2.WinForms.Guna2CircleButton btnTimKhuyenMai;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKhuyenMai;
        private Guna.UI2.WinForms.Guna2Button btnShowDiscount;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhuyenMai;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTGBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTGKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDoiTuongKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangThai;
    }
}
