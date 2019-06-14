namespace GUI
{
    partial class Frm_Kho
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
            this.lblThongTin = new System.Windows.Forms.Label();
            this.txtTenKho = new System.Windows.Forms.TextBox();
            this.lblTenKho = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.lblMaKho = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblNVQL = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgvKho = new System.Windows.Forms.DataGridView();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.lblDT = new System.Windows.Forms.Label();
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(271, 9);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(263, 31);
            this.lblThongTin.TabIndex = 34;
            this.lblThongTin.Text = "Thông tin kho hàng";
            // 
            // txtTenKho
            // 
            this.txtTenKho.Location = new System.Drawing.Point(168, 96);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(206, 20);
            this.txtTenKho.TabIndex = 38;
            // 
            // lblTenKho
            // 
            this.lblTenKho.AutoSize = true;
            this.lblTenKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKho.Location = new System.Drawing.Point(38, 94);
            this.lblTenKho.Name = "lblTenKho";
            this.lblTenKho.Size = new System.Drawing.Size(73, 20);
            this.lblTenKho.TabIndex = 37;
            this.lblTenKho.Text = "Tên kho";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(168, 63);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(206, 20);
            this.txtMaKho.TabIndex = 36;
            // 
            // lblMaKho
            // 
            this.lblMaKho.AutoSize = true;
            this.lblMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKho.Location = new System.Drawing.Point(38, 61);
            this.lblMaKho.Name = "lblMaKho";
            this.lblMaKho.Size = new System.Drawing.Size(67, 20);
            this.lblMaKho.TabIndex = 35;
            this.lblMaKho.Text = "Mã kho";
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(542, 63);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(206, 20);
            this.txtDC.TabIndex = 40;
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDC.Location = new System.Drawing.Point(420, 61);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(64, 20);
            this.lblDC.TabIndex = 39;
            this.lblDC.Text = "Địa chỉ";
            // 
            // lblNVQL
            // 
            this.lblNVQL.AutoSize = true;
            this.lblNVQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNVQL.Location = new System.Drawing.Point(420, 94);
            this.lblNVQL.Name = "lblNVQL";
            this.lblNVQL.Size = new System.Drawing.Size(56, 20);
            this.lblNVQL.TabIndex = 41;
            this.lblNVQL.Text = "NVQL";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(424, 164);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(83, 34);
            this.btnReturn.TabIndex = 46;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(293, 164);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 34);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(170, 164);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 34);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(44, 164);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 34);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgvKho
            // 
            this.dtgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKho.Location = new System.Drawing.Point(12, 215);
            this.dtgvKho.MultiSelect = false;
            this.dtgvKho.Name = "dtgvKho";
            this.dtgvKho.ReadOnly = true;
            this.dtgvKho.Size = new System.Drawing.Size(776, 223);
            this.dtgvKho.TabIndex = 47;
            this.dtgvKho.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKho_RowEnter);
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(542, 131);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(206, 20);
            this.txtDT.TabIndex = 49;
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.Location = new System.Drawing.Point(420, 129);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(91, 20);
            this.lblDT.TabIndex = 48;
            this.lblDT.Text = "Điện thoại";
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(542, 96);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(206, 21);
            this.cbxMaNV.TabIndex = 50;
            // 
            // Frm_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxMaNV);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.dtgvKho);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblNVQL);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.txtTenKho);
            this.Controls.Add(this.lblTenKho);
            this.Controls.Add(this.txtMaKho);
            this.Controls.Add(this.lblMaKho);
            this.Controls.Add(this.lblThongTin);
            this.Name = "Frm_Kho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin về kho";
            this.Load += new System.EventHandler(this.Frm_Kho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.TextBox txtTenKho;
        private System.Windows.Forms.Label lblTenKho;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Label lblMaKho;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblNVQL;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgvKho;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.ComboBox cbxMaNV;
    }
}