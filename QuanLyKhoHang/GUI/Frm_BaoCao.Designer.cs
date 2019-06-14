namespace GUI
{
    partial class Frm_BaoCao
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
            this.rptverNX = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbxGiaTri = new System.Windows.Forms.ComboBox();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.btnTrangChinh = new System.Windows.Forms.Button();
            this.cbxLuaChon2 = new System.Windows.Forms.ComboBox();
            this.lblLuaChon2 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.cbxLuaChon = new System.Windows.Forms.ComboBox();
            this.lblLuaChon = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblTG = new System.Windows.Forms.Label();
            this.rabtnThang = new System.Windows.Forms.RadioButton();
            this.rabtnQuy = new System.Windows.Forms.RadioButton();
            this.rabtnNgay = new System.Windows.Forms.RadioButton();
            this.rabtnKhong = new System.Windows.Forms.RadioButton();
            this.dtpkerNgay = new System.Windows.Forms.DateTimePicker();
            this.txtThangQuy = new System.Windows.Forms.TextBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rptverNX
            // 
            this.rptverNX.Location = new System.Drawing.Point(18, 228);
            this.rptverNX.Name = "rptverNX";
            this.rptverNX.ServerReport.BearerToken = null;
            this.rptverNX.Size = new System.Drawing.Size(760, 248);
            this.rptverNX.TabIndex = 103;
            // 
            // cbxGiaTri
            // 
            this.cbxGiaTri.FormattingEnabled = true;
            this.cbxGiaTri.Location = new System.Drawing.Point(158, 134);
            this.cbxGiaTri.Name = "cbxGiaTri";
            this.cbxGiaTri.Size = new System.Drawing.Size(206, 21);
            this.cbxGiaTri.TabIndex = 102;
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.AutoSize = true;
            this.lblGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTri.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGiaTri.Location = new System.Drawing.Point(14, 129);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(104, 24);
            this.lblGiaTri.TabIndex = 101;
            this.lblGiaTri.Text = "Giá trị lọc:";
            // 
            // btnTrangChinh
            // 
            this.btnTrangChinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTrangChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChinh.Location = new System.Drawing.Point(135, 180);
            this.btnTrangChinh.Name = "btnTrangChinh";
            this.btnTrangChinh.Size = new System.Drawing.Size(105, 34);
            this.btnTrangChinh.TabIndex = 100;
            this.btnTrangChinh.Text = "Trang chính";
            this.btnTrangChinh.UseVisualStyleBackColor = false;
            this.btnTrangChinh.Click += new System.EventHandler(this.btnTrangChinh_Click);
            // 
            // cbxLuaChon2
            // 
            this.cbxLuaChon2.FormattingEnabled = true;
            this.cbxLuaChon2.Location = new System.Drawing.Point(158, 99);
            this.cbxLuaChon2.Name = "cbxLuaChon2";
            this.cbxLuaChon2.Size = new System.Drawing.Size(206, 21);
            this.cbxLuaChon2.TabIndex = 99;
            this.cbxLuaChon2.SelectedIndexChanged += new System.EventHandler(this.cbxLuaChon2_SelectedIndexChanged);
            // 
            // lblLuaChon2
            // 
            this.lblLuaChon2.AutoSize = true;
            this.lblLuaChon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuaChon2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLuaChon2.Location = new System.Drawing.Point(14, 94);
            this.lblLuaChon2.Name = "lblLuaChon2";
            this.lblLuaChon2.Size = new System.Drawing.Size(138, 24);
            this.lblLuaChon2.TabIndex = 98;
            this.lblLuaChon2.Text = "Điều kiện lọc:";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(18, 180);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(93, 34);
            this.btnReport.TabIndex = 97;
            this.btnReport.Text = "Thống kê";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cbxLuaChon
            // 
            this.cbxLuaChon.FormattingEnabled = true;
            this.cbxLuaChon.Location = new System.Drawing.Point(288, 65);
            this.cbxLuaChon.Name = "cbxLuaChon";
            this.cbxLuaChon.Size = new System.Drawing.Size(206, 21);
            this.cbxLuaChon.TabIndex = 96;
            this.cbxLuaChon.SelectedIndexChanged += new System.EventHandler(this.cbxLuaChon_SelectedIndexChanged);
            // 
            // lblLuaChon
            // 
            this.lblLuaChon.AutoSize = true;
            this.lblLuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuaChon.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLuaChon.Location = new System.Drawing.Point(14, 60);
            this.lblLuaChon.Name = "lblLuaChon";
            this.lblLuaChon.Size = new System.Drawing.Size(268, 24);
            this.lblLuaChon.TabIndex = 95;
            this.lblLuaChon.Text = "Chọn thống kê thông tin về:";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(96, 9);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(608, 29);
            this.lblThongTin.TabIndex = 94;
            this.lblThongTin.Text = "Thống kê thông tin trong hệ thống quản lý kho hàng";
            // 
            // lblTG
            // 
            this.lblTG.AutoSize = true;
            this.lblTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTG.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTG.Location = new System.Drawing.Point(514, 65);
            this.lblTG.Name = "lblTG";
            this.lblTG.Size = new System.Drawing.Size(214, 24);
            this.lblTG.TabIndex = 104;
            this.lblTG.Text = "Thời gian nhập / xuất:";
            // 
            // rabtnThang
            // 
            this.rabtnThang.AutoSize = true;
            this.rabtnThang.Location = new System.Drawing.Point(518, 146);
            this.rabtnThang.Name = "rabtnThang";
            this.rabtnThang.Size = new System.Drawing.Size(56, 17);
            this.rabtnThang.TabIndex = 105;
            this.rabtnThang.TabStop = true;
            this.rabtnThang.Text = "Tháng";
            this.rabtnThang.UseVisualStyleBackColor = true;
            // 
            // rabtnQuy
            // 
            this.rabtnQuy.AutoSize = true;
            this.rabtnQuy.Location = new System.Drawing.Point(518, 169);
            this.rabtnQuy.Name = "rabtnQuy";
            this.rabtnQuy.Size = new System.Drawing.Size(44, 17);
            this.rabtnQuy.TabIndex = 106;
            this.rabtnQuy.TabStop = true;
            this.rabtnQuy.Text = "Quý";
            this.rabtnQuy.UseVisualStyleBackColor = true;
            // 
            // rabtnNgay
            // 
            this.rabtnNgay.AutoSize = true;
            this.rabtnNgay.Location = new System.Drawing.Point(518, 123);
            this.rabtnNgay.Name = "rabtnNgay";
            this.rabtnNgay.Size = new System.Drawing.Size(50, 17);
            this.rabtnNgay.TabIndex = 107;
            this.rabtnNgay.TabStop = true;
            this.rabtnNgay.Text = "Ngày";
            this.rabtnNgay.UseVisualStyleBackColor = true;
            // 
            // rabtnKhong
            // 
            this.rabtnKhong.AutoSize = true;
            this.rabtnKhong.Location = new System.Drawing.Point(518, 100);
            this.rabtnKhong.Name = "rabtnKhong";
            this.rabtnKhong.Size = new System.Drawing.Size(116, 17);
            this.rabtnKhong.TabIndex = 108;
            this.rabtnKhong.TabStop = true;
            this.rabtnKhong.Text = "Không lọc thời gian";
            this.rabtnKhong.UseVisualStyleBackColor = true;
            // 
            // dtpkerNgay
            // 
            this.dtpkerNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkerNgay.Location = new System.Drawing.Point(578, 120);
            this.dtpkerNgay.Name = "dtpkerNgay";
            this.dtpkerNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpkerNgay.TabIndex = 109;
            // 
            // txtThangQuy
            // 
            this.txtThangQuy.Location = new System.Drawing.Point(578, 148);
            this.txtThangQuy.Multiline = true;
            this.txtThangQuy.Name = "txtThangQuy";
            this.txtThangQuy.Size = new System.Drawing.Size(77, 38);
            this.txtThangQuy.TabIndex = 110;
            this.txtThangQuy.TextChanged += new System.EventHandler(this.txtThangQuy_TextChanged);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(661, 148);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(37, 16);
            this.lblNam.TabIndex = 111;
            this.lblNam.Text = "Năm";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(704, 147);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(74, 20);
            this.txtNam.TabIndex = 112;
            // 
            // Frm_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.txtThangQuy);
            this.Controls.Add(this.dtpkerNgay);
            this.Controls.Add(this.rabtnKhong);
            this.Controls.Add(this.rabtnNgay);
            this.Controls.Add(this.rabtnQuy);
            this.Controls.Add(this.rabtnThang);
            this.Controls.Add(this.lblTG);
            this.Controls.Add(this.rptverNX);
            this.Controls.Add(this.cbxGiaTri);
            this.Controls.Add(this.lblGiaTri);
            this.Controls.Add(this.btnTrangChinh);
            this.Controls.Add(this.cbxLuaChon2);
            this.Controls.Add(this.lblLuaChon2);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.cbxLuaChon);
            this.Controls.Add(this.lblLuaChon);
            this.Controls.Add(this.lblThongTin);
            this.Name = "Frm_BaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê trong hệ thống";
            this.Load += new System.EventHandler(this.Frm_BaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptverNX;
        private System.Windows.Forms.ComboBox cbxGiaTri;
        private System.Windows.Forms.Label lblGiaTri;
        private System.Windows.Forms.Button btnTrangChinh;
        private System.Windows.Forms.ComboBox cbxLuaChon2;
        private System.Windows.Forms.Label lblLuaChon2;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ComboBox cbxLuaChon;
        private System.Windows.Forms.Label lblLuaChon;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblTG;
        private System.Windows.Forms.RadioButton rabtnThang;
        private System.Windows.Forms.RadioButton rabtnQuy;
        private System.Windows.Forms.RadioButton rabtnNgay;
        private System.Windows.Forms.RadioButton rabtnKhong;
        private System.Windows.Forms.DateTimePicker dtpkerNgay;
        private System.Windows.Forms.TextBox txtThangQuy;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.TextBox txtNam;
    }
}