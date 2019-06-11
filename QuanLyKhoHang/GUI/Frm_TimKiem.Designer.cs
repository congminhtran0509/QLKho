namespace GUI
{
    partial class Frm_TimKiem
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
            this.lblLuaChon = new System.Windows.Forms.Label();
            this.cbxLuaChon = new System.Windows.Forms.ComboBox();
            this.dtgvKQ = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxLuaChon2 = new System.Windows.Forms.ComboBox();
            this.lblLuaChon2 = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKQ)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(107, 9);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(586, 29);
            this.lblThongTin.TabIndex = 57;
            this.lblThongTin.Text = "Tra cứu thông tin trong hệ thống quản lý kho hàng";
            // 
            // lblLuaChon
            // 
            this.lblLuaChon.AutoSize = true;
            this.lblLuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuaChon.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLuaChon.Location = new System.Drawing.Point(25, 49);
            this.lblLuaChon.Name = "lblLuaChon";
            this.lblLuaChon.Size = new System.Drawing.Size(251, 24);
            this.lblLuaChon.TabIndex = 58;
            this.lblLuaChon.Text = "Chọn tra cứu thông tin về:";
            // 
            // cbxLuaChon
            // 
            this.cbxLuaChon.FormattingEnabled = true;
            this.cbxLuaChon.Location = new System.Drawing.Point(282, 54);
            this.cbxLuaChon.Name = "cbxLuaChon";
            this.cbxLuaChon.Size = new System.Drawing.Size(206, 21);
            this.cbxLuaChon.TabIndex = 68;
            this.cbxLuaChon.SelectedIndexChanged += new System.EventHandler(this.cbxLuaChon_SelectedIndexChanged);
            // 
            // dtgvKQ
            // 
            this.dtgvKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKQ.Location = new System.Drawing.Point(12, 177);
            this.dtgvKQ.MultiSelect = false;
            this.dtgvKQ.Name = "dtgvKQ";
            this.dtgvKQ.ReadOnly = true;
            this.dtgvKQ.Size = new System.Drawing.Size(776, 261);
            this.dtgvKQ.TabIndex = 74;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(695, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 34);
            this.btnSearch.TabIndex = 75;
            this.btnSearch.Text = "Tra cứu";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxLuaChon2
            // 
            this.cbxLuaChon2.FormattingEnabled = true;
            this.cbxLuaChon2.Location = new System.Drawing.Point(282, 88);
            this.cbxLuaChon2.Name = "cbxLuaChon2";
            this.cbxLuaChon2.Size = new System.Drawing.Size(206, 21);
            this.cbxLuaChon2.TabIndex = 77;
            // 
            // lblLuaChon2
            // 
            this.lblLuaChon2.AutoSize = true;
            this.lblLuaChon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuaChon2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLuaChon2.Location = new System.Drawing.Point(25, 83);
            this.lblLuaChon2.Name = "lblLuaChon2";
            this.lblLuaChon2.Size = new System.Drawing.Size(215, 24);
            this.lblLuaChon2.TabIndex = 76;
            this.lblLuaChon2.Text = "Thông tin cần tra cứu:";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNoiDung.Location = new System.Drawing.Point(25, 123);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(212, 24);
            this.lblNoiDung.TabIndex = 78;
            this.lblNoiDung.Text = "Nội dung cần tra cứu:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(282, 128);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(206, 20);
            this.txtNoiDung.TabIndex = 79;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.ForeColor = System.Drawing.Color.DarkRed;
            this.lblKQ.Location = new System.Drawing.Point(526, 124);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(163, 24);
            this.lblKQ.TabIndex = 80;
            this.lblKQ.Text = "Số KQ tìm được:";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(695, 127);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(93, 20);
            this.txtKQ.TabIndex = 81;
            // 
            // Frm_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.cbxLuaChon2);
            this.Controls.Add(this.lblLuaChon2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtgvKQ);
            this.Controls.Add(this.cbxLuaChon);
            this.Controls.Add(this.lblLuaChon);
            this.Controls.Add(this.lblThongTin);
            this.Name = "Frm_TimKiem";
            this.Text = "Tra cứu thông tin";
            this.Load += new System.EventHandler(this.Frm_TimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblLuaChon;
        private System.Windows.Forms.ComboBox cbxLuaChon;
        private System.Windows.Forms.DataGridView dtgvKQ;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxLuaChon2;
        private System.Windows.Forms.Label lblLuaChon2;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtKQ;
    }
}