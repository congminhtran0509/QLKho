namespace GUI
{
    partial class Frm_NhanVien
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.da_tiNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.lblDT = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.radioBtnNam = new System.Windows.Forms.RadioButton();
            this.radioBtnNu = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblThongTin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(166, 96);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(206, 20);
            this.txtHoTen.TabIndex = 7;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(36, 94);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(63, 20);
            this.lblHoTen.TabIndex = 6;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(166, 63);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(206, 20);
            this.txtMaNV.TabIndex = 5;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(36, 61);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(115, 20);
            this.lblMaNV.TabIndex = 4;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(166, 163);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(206, 20);
            this.txtCMND.TabIndex = 11;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(36, 161);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(60, 20);
            this.lblCMND.TabIndex = 10;
            this.lblCMND.Text = "CMND";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(36, 128);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(87, 20);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // da_tiNgaySinh
            // 
            this.da_tiNgaySinh.CustomFormat = "";
            this.da_tiNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.da_tiNgaySinh.Location = new System.Drawing.Point(166, 128);
            this.da_tiNgaySinh.Name = "da_tiNgaySinh";
            this.da_tiNgaySinh.Size = new System.Drawing.Size(206, 20);
            this.da_tiNgaySinh.TabIndex = 12;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(538, 96);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(206, 20);
            this.txtDT.TabIndex = 16;
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.Location = new System.Drawing.Point(416, 94);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(91, 20);
            this.lblDT.TabIndex = 15;
            this.lblDT.Text = "Điện thoại";
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(538, 65);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(206, 20);
            this.txtDC.TabIndex = 14;
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDC.Location = new System.Drawing.Point(416, 63);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(64, 20);
            this.lblDC.TabIndex = 13;
            this.lblDC.Text = "Địa chỉ";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGT.Location = new System.Drawing.Point(36, 194);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(76, 20);
            this.lblGT.TabIndex = 17;
            this.lblGT.Text = "Giới tính";
            // 
            // radioBtnNam
            // 
            this.radioBtnNam.AutoSize = true;
            this.radioBtnNam.Location = new System.Drawing.Point(166, 197);
            this.radioBtnNam.Name = "radioBtnNam";
            this.radioBtnNam.Size = new System.Drawing.Size(47, 17);
            this.radioBtnNam.TabIndex = 18;
            this.radioBtnNam.TabStop = true;
            this.radioBtnNam.Text = "Nam";
            this.radioBtnNam.UseVisualStyleBackColor = true;
            // 
            // radioBtnNu
            // 
            this.radioBtnNu.AutoSize = true;
            this.radioBtnNu.Location = new System.Drawing.Point(235, 197);
            this.radioBtnNu.Name = "radioBtnNu";
            this.radioBtnNu.Size = new System.Drawing.Size(39, 17);
            this.radioBtnNu.TabIndex = 19;
            this.radioBtnNu.TabStop = true;
            this.radioBtnNu.Text = "Nữ";
            this.radioBtnNu.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(538, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 20);
            this.txtEmail.TabIndex = 25;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(416, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email";
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Location = new System.Drawing.Point(14, 277);
            this.dtgvNhanVien.MultiSelect = false;
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.ReadOnly = true;
            this.dtgvNhanVien.Size = new System.Drawing.Size(776, 229);
            this.dtgvNhanVien.TabIndex = 28;
            this.dtgvNhanVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNhanVien_RowEnter);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(40, 228);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 34);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(166, 228);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 34);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(289, 228);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 34);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(420, 228);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(83, 34);
            this.btnReturn.TabIndex = 32;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(283, 18);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(270, 31);
            this.lblThongTin.TabIndex = 33;
            this.lblThongTin.Text = "Thông tin nhân viên";
            // 
            // Frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgvNhanVien);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.radioBtnNu);
            this.Controls.Add(this.radioBtnNam);
            this.Controls.Add(this.lblGT);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.da_tiNgaySinh);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblMaNV);
            this.Name = "Frm_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin  nhân viên";
            this.Load += new System.EventHandler(this.Frm_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker da_tiNgaySinh;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.RadioButton radioBtnNam;
        private System.Windows.Forms.RadioButton radioBtnNu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblThongTin;
    }
}