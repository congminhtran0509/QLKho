namespace GUI
{
    partial class Frm_CTPN_CTPX
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbxMaPNX = new System.Windows.Forms.ComboBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.cbxMaMH = new System.Windows.Forms.ComboBox();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.radioBtnCTPX = new System.Windows.Forms.RadioButton();
            this.radioBtnCTPN = new System.Windows.Forms.RadioButton();
            this.lblLuaChon = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.dtgvCTPNX = new System.Windows.Forms.DataGridView();
            this.dtgvPhieuNX = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTPNX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(47, 178);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(83, 34);
            this.btnLoad.TabIndex = 72;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(553, 178);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(83, 34);
            this.btnReturn.TabIndex = 71;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(422, 178);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 34);
            this.btnXoa.TabIndex = 70;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(299, 178);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 34);
            this.btnSua.TabIndex = 69;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(173, 178);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 34);
            this.btnThem.TabIndex = 68;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbxMaPNX
            // 
            this.cbxMaPNX.FormattingEnabled = true;
            this.cbxMaPNX.Location = new System.Drawing.Point(162, 104);
            this.cbxMaPNX.Name = "cbxMaPNX";
            this.cbxMaPNX.Size = new System.Drawing.Size(206, 21);
            this.cbxMaPNX.TabIndex = 67;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(412, 141);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(71, 20);
            this.lblDonGia.TabIndex = 66;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL.Location = new System.Drawing.Point(412, 107);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(80, 20);
            this.lblSL.TabIndex = 64;
            this.lblSL.Text = "Số lượng";
            // 
            // cbxMaMH
            // 
            this.cbxMaMH.FormattingEnabled = true;
            this.cbxMaMH.Location = new System.Drawing.Point(162, 140);
            this.cbxMaMH.Name = "cbxMaMH";
            this.cbxMaMH.Size = new System.Drawing.Size(206, 21);
            this.cbxMaMH.TabIndex = 63;
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMH.Location = new System.Drawing.Point(39, 141);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(84, 20);
            this.lblMaMH.TabIndex = 62;
            this.lblMaMH.Text = "Mặt hàng";
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(553, 140);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(206, 20);
            this.txtDG.TabIndex = 61;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(39, 105);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(82, 20);
            this.lblMa.TabIndex = 60;
            this.lblMa.Text = "Mã phiếu";
            // 
            // radioBtnCTPX
            // 
            this.radioBtnCTPX.AutoSize = true;
            this.radioBtnCTPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnCTPX.Location = new System.Drawing.Point(593, 59);
            this.radioBtnCTPX.Name = "radioBtnCTPX";
            this.radioBtnCTPX.Size = new System.Drawing.Size(83, 28);
            this.radioBtnCTPX.TabIndex = 59;
            this.radioBtnCTPX.TabStop = true;
            this.radioBtnCTPX.Text = "CTPX";
            this.radioBtnCTPX.UseVisualStyleBackColor = true;
            this.radioBtnCTPX.CheckedChanged += new System.EventHandler(this.radioBtnCTPX_CheckedChanged);
            // 
            // radioBtnCTPN
            // 
            this.radioBtnCTPN.AutoSize = true;
            this.radioBtnCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnCTPN.Location = new System.Drawing.Point(394, 59);
            this.radioBtnCTPN.Name = "radioBtnCTPN";
            this.radioBtnCTPN.Size = new System.Drawing.Size(83, 28);
            this.radioBtnCTPN.TabIndex = 58;
            this.radioBtnCTPN.TabStop = true;
            this.radioBtnCTPN.Text = "CTPN";
            this.radioBtnCTPN.UseVisualStyleBackColor = true;
            this.radioBtnCTPN.CheckedChanged += new System.EventHandler(this.radioBtnCTPN_CheckedChanged);
            // 
            // lblLuaChon
            // 
            this.lblLuaChon.AutoSize = true;
            this.lblLuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuaChon.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLuaChon.Location = new System.Drawing.Point(51, 63);
            this.lblLuaChon.Name = "lblLuaChon";
            this.lblLuaChon.Size = new System.Drawing.Size(267, 24);
            this.lblLuaChon.TabIndex = 57;
            this.lblLuaChon.Text = "Chọn cập nhật thông tin về:";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(82, 9);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(620, 29);
            this.lblThongTin.TabIndex = 56;
            this.lblThongTin.Text = "Chi tiết phiếu nhập và xuất hàng hóa (CTPN / CTPX)";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(553, 107);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(206, 20);
            this.txtSL.TabIndex = 74;
            // 
            // dtgvCTPNX
            // 
            this.dtgvCTPNX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTPNX.Location = new System.Drawing.Point(12, 489);
            this.dtgvCTPNX.MultiSelect = false;
            this.dtgvCTPNX.Name = "dtgvCTPNX";
            this.dtgvCTPNX.ReadOnly = true;
            this.dtgvCTPNX.Size = new System.Drawing.Size(776, 248);
            this.dtgvCTPNX.TabIndex = 75;
            this.dtgvCTPNX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCTPNX_CellContentClick);
            this.dtgvCTPNX.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCTPNX_RowEnter);
            this.dtgvCTPNX.Click += new System.EventHandler(this.dtgvCTPNX_Click);
            // 
            // dtgvPhieuNX
            // 
            this.dtgvPhieuNX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuNX.Location = new System.Drawing.Point(12, 227);
            this.dtgvPhieuNX.MultiSelect = false;
            this.dtgvPhieuNX.Name = "dtgvPhieuNX";
            this.dtgvPhieuNX.ReadOnly = true;
            this.dtgvPhieuNX.Size = new System.Drawing.Size(776, 248);
            this.dtgvPhieuNX.TabIndex = 73;
            this.dtgvPhieuNX.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPhieuNX_RowEnter);
            // 
            // Frm_CTPN_CTPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.dtgvCTPNX);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.dtgvPhieuNX);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbxMaPNX);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.cbxMaMH);
            this.Controls.Add(this.lblMaMH);
            this.Controls.Add(this.txtDG);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.radioBtnCTPX);
            this.Controls.Add(this.radioBtnCTPN);
            this.Controls.Add(this.lblLuaChon);
            this.Controls.Add(this.lblThongTin);
            this.Name = "Frm_CTPN_CTPX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin về chi tiết nhập / xuất";
            this.Load += new System.EventHandler(this.Frm_CTPN_CTPX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTPNX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbxMaPNX;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.ComboBox cbxMaMH;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.RadioButton radioBtnCTPX;
        private System.Windows.Forms.RadioButton radioBtnCTPN;
        private System.Windows.Forms.Label lblLuaChon;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.DataGridView dtgvCTPNX;
        private System.Windows.Forms.DataGridView dtgvPhieuNX;
    }
}