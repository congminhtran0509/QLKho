namespace GUI
{
    partial class Frm_PN_PX
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
            this.radioBtnPX = new System.Windows.Forms.RadioButton();
            this.radioBtnPN = new System.Windows.Forms.RadioButton();
            this.lblLuaChon = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.da_tiNgayNX = new System.Windows.Forms.DateTimePicker();
            this.lblNgayNX = new System.Windows.Forms.Label();
            this.cbxMaDoiTac = new System.Windows.Forms.ComboBox();
            this.lblDoiTac = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgvPhieuNX = new System.Windows.Forms.DataGridView();
            this.cbxMaKho = new System.Windows.Forms.ComboBox();
            this.lblMaKho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNX)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBtnPX
            // 
            this.radioBtnPX.AutoSize = true;
            this.radioBtnPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPX.Location = new System.Drawing.Point(590, 64);
            this.radioBtnPX.Name = "radioBtnPX";
            this.radioBtnPX.Size = new System.Drawing.Size(127, 28);
            this.radioBtnPX.TabIndex = 41;
            this.radioBtnPX.TabStop = true;
            this.radioBtnPX.Text = "Phiếu xuất";
            this.radioBtnPX.UseVisualStyleBackColor = true;
            this.radioBtnPX.CheckedChanged += new System.EventHandler(this.radioBtnPX_CheckedChanged);
            // 
            // radioBtnPN
            // 
            this.radioBtnPN.AutoSize = true;
            this.radioBtnPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPN.Location = new System.Drawing.Point(391, 64);
            this.radioBtnPN.Name = "radioBtnPN";
            this.radioBtnPN.Size = new System.Drawing.Size(135, 28);
            this.radioBtnPN.TabIndex = 40;
            this.radioBtnPN.TabStop = true;
            this.radioBtnPN.Text = "Phiếu nhập";
            this.radioBtnPN.UseVisualStyleBackColor = true;
            this.radioBtnPN.CheckedChanged += new System.EventHandler(this.radioBtnPN_CheckedChanged);
            // 
            // lblLuaChon
            // 
            this.lblLuaChon.AutoSize = true;
            this.lblLuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuaChon.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLuaChon.Location = new System.Drawing.Point(48, 68);
            this.lblLuaChon.Name = "lblLuaChon";
            this.lblLuaChon.Size = new System.Drawing.Size(286, 24);
            this.lblLuaChon.TabIndex = 39;
            this.lblLuaChon.Text = "Chọn hiệu chỉnh thông tin về:";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(37, 18);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(721, 29);
            this.lblThongTin.TabIndex = 38;
            this.lblThongTin.Text = "Thông tin về nhập và xuất hàng hóa (Phiếu nhập / Phiếu xuất)";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(160, 121);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(206, 20);
            this.txtMa.TabIndex = 43;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(38, 119);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(82, 20);
            this.lblMa.TabIndex = 42;
            this.lblMa.Text = "Mã phiếu";
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(161, 154);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(206, 21);
            this.cbxMaNV.TabIndex = 45;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(38, 155);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(117, 20);
            this.lblMaNV.TabIndex = 44;
            this.lblMaNV.Text = "Nhân viên lập";
            // 
            // da_tiNgayNX
            // 
            this.da_tiNgayNX.CustomFormat = "yyyy/mm/dd";
            this.da_tiNgayNX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.da_tiNgayNX.Location = new System.Drawing.Point(190, 188);
            this.da_tiNgayNX.Name = "da_tiNgayNX";
            this.da_tiNgayNX.Size = new System.Drawing.Size(176, 20);
            this.da_tiNgayNX.TabIndex = 47;
            // 
            // lblNgayNX
            // 
            this.lblNgayNX.AutoSize = true;
            this.lblNgayNX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNX.Location = new System.Drawing.Point(38, 189);
            this.lblNgayNX.Name = "lblNgayNX";
            this.lblNgayNX.Size = new System.Drawing.Size(133, 20);
            this.lblNgayNX.TabIndex = 46;
            this.lblNgayNX.Text = "Ngày nhập/xuất";
            // 
            // cbxMaDoiTac
            // 
            this.cbxMaDoiTac.FormattingEnabled = true;
            this.cbxMaDoiTac.Location = new System.Drawing.Point(520, 121);
            this.cbxMaDoiTac.Name = "cbxMaDoiTac";
            this.cbxMaDoiTac.Size = new System.Drawing.Size(206, 21);
            this.cbxMaDoiTac.TabIndex = 49;
            // 
            // lblDoiTac
            // 
            this.lblDoiTac.AutoSize = true;
            this.lblDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiTac.Location = new System.Drawing.Point(417, 121);
            this.lblDoiTac.Name = "lblDoiTac";
            this.lblDoiTac.Size = new System.Drawing.Size(66, 20);
            this.lblDoiTac.TabIndex = 48;
            this.lblDoiTac.Text = "Đối tác";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(46, 225);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(83, 34);
            this.btnLoad.TabIndex = 54;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(552, 225);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(83, 34);
            this.btnReturn.TabIndex = 53;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(421, 225);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 34);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(298, 225);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 34);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(172, 225);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 34);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgvPhieuNX
            // 
            this.dtgvPhieuNX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuNX.Location = new System.Drawing.Point(16, 276);
            this.dtgvPhieuNX.MultiSelect = false;
            this.dtgvPhieuNX.Name = "dtgvPhieuNX";
            this.dtgvPhieuNX.ReadOnly = true;
            this.dtgvPhieuNX.Size = new System.Drawing.Size(776, 248);
            this.dtgvPhieuNX.TabIndex = 55;
            this.dtgvPhieuNX.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPhieuNX_RowEnter);
            // 
            // cbxMaKho
            // 
            this.cbxMaKho.FormattingEnabled = true;
            this.cbxMaKho.Location = new System.Drawing.Point(520, 154);
            this.cbxMaKho.Name = "cbxMaKho";
            this.cbxMaKho.Size = new System.Drawing.Size(206, 21);
            this.cbxMaKho.TabIndex = 57;
            // 
            // lblMaKho
            // 
            this.lblMaKho.AutoSize = true;
            this.lblMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKho.Location = new System.Drawing.Point(417, 155);
            this.lblMaKho.Name = "lblMaKho";
            this.lblMaKho.Size = new System.Drawing.Size(40, 20);
            this.lblMaKho.TabIndex = 56;
            this.lblMaKho.Text = "Kho";
            // 
            // Frm_PN_PX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.cbxMaKho);
            this.Controls.Add(this.lblMaKho);
            this.Controls.Add(this.dtgvPhieuNX);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbxMaDoiTac);
            this.Controls.Add(this.lblDoiTac);
            this.Controls.Add(this.da_tiNgayNX);
            this.Controls.Add(this.lblNgayNX);
            this.Controls.Add(this.cbxMaNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.radioBtnPX);
            this.Controls.Add(this.radioBtnPN);
            this.Controls.Add(this.lblLuaChon);
            this.Controls.Add(this.lblThongTin);
            this.Name = "Frm_PN_PX";
            this.Text = "Frm_PN_PX";
            this.Load += new System.EventHandler(this.Frm_PN_PX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnPX;
        private System.Windows.Forms.RadioButton radioBtnPN;
        private System.Windows.Forms.Label lblLuaChon;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.ComboBox cbxMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.DateTimePicker da_tiNgayNX;
        private System.Windows.Forms.Label lblNgayNX;
        private System.Windows.Forms.ComboBox cbxMaDoiTac;
        private System.Windows.Forms.Label lblDoiTac;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgvPhieuNX;
        private System.Windows.Forms.ComboBox cbxMaKho;
        private System.Windows.Forms.Label lblMaKho;
    }
}