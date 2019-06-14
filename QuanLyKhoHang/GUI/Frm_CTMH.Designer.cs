namespace GUI
{
    partial class Frm_CTMH
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
            this.cbxMaKho = new System.Windows.Forms.ComboBox();
            this.cbxMaMH = new System.Windows.Forms.ComboBox();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblMaKho = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgvCTMH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTMH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(118, 20);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(540, 29);
            this.lblThongTin.TabIndex = 57;
            this.lblThongTin.Text = "Thông tin chi tiết các mặt hàng trong từng kho";
            // 
            // cbxMaKho
            // 
            this.cbxMaKho.FormattingEnabled = true;
            this.cbxMaKho.Location = new System.Drawing.Point(159, 74);
            this.cbxMaKho.Name = "cbxMaKho";
            this.cbxMaKho.Size = new System.Drawing.Size(206, 21);
            this.cbxMaKho.TabIndex = 71;
            // 
            // cbxMaMH
            // 
            this.cbxMaMH.FormattingEnabled = true;
            this.cbxMaMH.Location = new System.Drawing.Point(159, 110);
            this.cbxMaMH.Name = "cbxMaMH";
            this.cbxMaMH.Size = new System.Drawing.Size(206, 21);
            this.cbxMaMH.TabIndex = 70;
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMH.Location = new System.Drawing.Point(36, 111);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(84, 20);
            this.lblMaMH.TabIndex = 69;
            this.lblMaMH.Text = "Mặt hàng";
            // 
            // lblMaKho
            // 
            this.lblMaKho.AutoSize = true;
            this.lblMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKho.Location = new System.Drawing.Point(36, 75);
            this.lblMaKho.Name = "lblMaKho";
            this.lblMaKho.Size = new System.Drawing.Size(67, 20);
            this.lblMaKho.TabIndex = 68;
            this.lblMaKho.Text = "Mã kho";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(540, 74);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(206, 20);
            this.txtSL.TabIndex = 76;
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL.Location = new System.Drawing.Point(424, 74);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(80, 20);
            this.lblSL.TabIndex = 75;
            this.lblSL.Text = "Số lượng";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(420, 161);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(83, 34);
            this.btnReturn.TabIndex = 80;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(289, 161);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 34);
            this.btnXoa.TabIndex = 79;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(166, 161);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 34);
            this.btnSua.TabIndex = 78;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(40, 161);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 34);
            this.btnThem.TabIndex = 77;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgvCTMH
            // 
            this.dtgvCTMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTMH.Location = new System.Drawing.Point(12, 213);
            this.dtgvCTMH.MultiSelect = false;
            this.dtgvCTMH.Name = "dtgvCTMH";
            this.dtgvCTMH.ReadOnly = true;
            this.dtgvCTMH.Size = new System.Drawing.Size(776, 248);
            this.dtgvCTMH.TabIndex = 81;
            this.dtgvCTMH.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCTMH_RowEnter);
            // 
            // Frm_CTMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.dtgvCTMH);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.cbxMaKho);
            this.Controls.Add(this.cbxMaMH);
            this.Controls.Add(this.lblMaMH);
            this.Controls.Add(this.lblMaKho);
            this.Controls.Add(this.lblThongTin);
            this.Name = "Frm_CTMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CTMH";
            this.Load += new System.EventHandler(this.Frm_CTMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.ComboBox cbxMaKho;
        private System.Windows.Forms.ComboBox cbxMaMH;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblMaKho;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgvCTMH;
    }
}