namespace GUI
{
    partial class Frm_MatHang
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
            this.dtgvMatHang = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbxMaLH = new System.Windows.Forms.ComboBox();
            this.lblMaLH = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.lblDVT = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMatHang
            // 
            this.dtgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMatHang.Location = new System.Drawing.Point(12, 195);
            this.dtgvMatHang.MultiSelect = false;
            this.dtgvMatHang.Name = "dtgvMatHang";
            this.dtgvMatHang.ReadOnly = true;
            this.dtgvMatHang.Size = new System.Drawing.Size(776, 245);
            this.dtgvMatHang.TabIndex = 61;
            this.dtgvMatHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMatHang_RowEnter);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(422, 142);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(83, 34);
            this.btnReturn.TabIndex = 60;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(291, 142);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 34);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(168, 142);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 34);
            this.btnSua.TabIndex = 58;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(42, 142);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 34);
            this.btnThem.TabIndex = 57;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbxMaLH
            // 
            this.cbxMaLH.FormattingEnabled = true;
            this.cbxMaLH.Location = new System.Drawing.Point(542, 98);
            this.cbxMaLH.Name = "cbxMaLH";
            this.cbxMaLH.Size = new System.Drawing.Size(206, 21);
            this.cbxMaLH.TabIndex = 56;
            // 
            // lblMaLH
            // 
            this.lblMaLH.AutoSize = true;
            this.lblMaLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLH.Location = new System.Drawing.Point(420, 96);
            this.lblMaLH.Name = "lblMaLH";
            this.lblMaLH.Size = new System.Drawing.Size(88, 20);
            this.lblMaLH.TabIndex = 55;
            this.lblMaLH.Text = "Loại hàng";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(542, 65);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(206, 20);
            this.txtDVT.TabIndex = 54;
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVT.Location = new System.Drawing.Point(420, 63);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(94, 20);
            this.lblDVT.TabIndex = 53;
            this.lblDVT.Text = "Đơn vị tính";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(168, 98);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(206, 20);
            this.txtTenMH.TabIndex = 52;
            // 
            // lblTenMH
            // 
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMH.Location = new System.Drawing.Point(38, 96);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(119, 20);
            this.lblTenMH.TabIndex = 51;
            this.lblTenMH.Text = "Tên mặt hàng";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(168, 65);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(206, 20);
            this.txtMaMH.TabIndex = 50;
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMH.Location = new System.Drawing.Point(38, 63);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(113, 20);
            this.lblMaMH.TabIndex = 49;
            this.lblMaMH.Text = "Mã mặt hàng";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(271, 11);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(264, 31);
            this.lblThongTin.TabIndex = 48;
            this.lblThongTin.Text = "Thông tin mặt hàng";
            // 
            // Frm_MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvMatHang);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbxMaLH);
            this.Controls.Add(this.lblMaLH);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.lblDVT);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.lblTenMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.lblMaMH);
            this.Controls.Add(this.lblThongTin);
            this.Name = "Frm_MatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MatHang";
            this.Load += new System.EventHandler(this.Frm_MatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMatHang;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbxMaLH;
        private System.Windows.Forms.Label lblMaLH;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblThongTin;
    }
}