namespace Berverage_Manager.GUI
{
    partial class frmReprotStatistical
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.frmRS_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(738, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 151;
            this.guna2ControlBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Berverage_Manager.Report.ReportDoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 91);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(758, 485);
            this.reportViewer1.TabIndex = 152;
            // 
            // frmRS_Date
            // 
            this.frmRS_Date.BorderRadius = 5;
            this.frmRS_Date.Checked = true;
            this.frmRS_Date.CustomFormat = "MM/yyyy";
            this.frmRS_Date.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.frmRS_Date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmRS_Date.ForeColor = System.Drawing.Color.White;
            this.frmRS_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.frmRS_Date.Location = new System.Drawing.Point(12, 30);
            this.frmRS_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.frmRS_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.frmRS_Date.Name = "frmRS_Date";
            this.frmRS_Date.Size = new System.Drawing.Size(142, 42);
            this.frmRS_Date.TabIndex = 153;
            this.frmRS_Date.Value = new System.DateTime(2021, 10, 18, 14, 12, 15, 442);
            this.frmRS_Date.ValueChanged += new System.EventHandler(this.frmRS_Date_ValueChanged);
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
            // frmReprotStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 588);
            this.Controls.Add(this.frmRS_Date);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReprotStatistical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReprotStatistical";
            this.Load += new System.EventHandler(this.frmReprotStatistical_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2DateTimePicker frmRS_Date;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}