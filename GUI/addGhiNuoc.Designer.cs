namespace GUI
{
    partial class addGhiNuoc
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtChiSoMoi = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblSoCongTo = new System.Windows.Forms.Label();
            this.lblChiSo = new System.Windows.Forms.Label();
            this.lblHang = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dateTimeGhiNuoc = new System.Windows.Forms.DateTimePicker();
            this.txtLuongNuoc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(210, 222);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 36);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(81, 222);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 36);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtChiSoMoi
            // 
            this.txtChiSoMoi.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiSoMoi.Location = new System.Drawing.Point(125, 136);
            this.txtChiSoMoi.Name = "txtChiSoMoi";
            this.txtChiSoMoi.Size = new System.Drawing.Size(225, 23);
            this.txtChiSoMoi.TabIndex = 19;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(125, 54);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(225, 23);
            this.txtMaKH.TabIndex = 17;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.Location = new System.Drawing.Point(24, 181);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(86, 18);
            this.lblTinhTrang.TabIndex = 16;
            this.lblTinhTrang.Text = "Lượng nước";
            // 
            // lblSoCongTo
            // 
            this.lblSoCongTo.AutoSize = true;
            this.lblSoCongTo.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoCongTo.Location = new System.Drawing.Point(24, 137);
            this.lblSoCongTo.Name = "lblSoCongTo";
            this.lblSoCongTo.Size = new System.Drawing.Size(78, 18);
            this.lblSoCongTo.TabIndex = 15;
            this.lblSoCongTo.Text = "Chỉ số mới";
            // 
            // lblChiSo
            // 
            this.lblChiSo.AutoSize = true;
            this.lblChiSo.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiSo.Location = new System.Drawing.Point(24, 95);
            this.lblChiSo.Name = "lblChiSo";
            this.lblChiSo.Size = new System.Drawing.Size(67, 18);
            this.lblChiSo.TabIndex = 14;
            this.lblChiSo.Text = "Thời gian";
            // 
            // lblHang
            // 
            this.lblHang.AutoSize = true;
            this.lblHang.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHang.Location = new System.Drawing.Point(24, 54);
            this.lblHang.Name = "lblHang";
            this.lblHang.Size = new System.Drawing.Size(52, 18);
            this.lblHang.TabIndex = 13;
            this.lblHang.Text = "Mã KH";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(121, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 23);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "GHI SỐ NƯỚC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimeGhiNuoc
            // 
            this.dateTimeGhiNuoc.CalendarFont = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeGhiNuoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeGhiNuoc.Location = new System.Drawing.Point(125, 95);
            this.dateTimeGhiNuoc.Name = "dateTimeGhiNuoc";
            this.dateTimeGhiNuoc.Size = new System.Drawing.Size(225, 20);
            this.dateTimeGhiNuoc.TabIndex = 23;
            // 
            // txtLuongNuoc
            // 
            this.txtLuongNuoc.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongNuoc.Location = new System.Drawing.Point(124, 179);
            this.txtLuongNuoc.Multiline = true;
            this.txtLuongNuoc.Name = "txtLuongNuoc";
            this.txtLuongNuoc.Size = new System.Drawing.Size(225, 23);
            this.txtLuongNuoc.TabIndex = 24;
            // 
            // addGhiNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 271);
            this.Controls.Add(this.txtLuongNuoc);
            this.Controls.Add(this.dateTimeGhiNuoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtChiSoMoi);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.lblSoCongTo);
            this.Controls.Add(this.lblChiSo);
            this.Controls.Add(this.lblHang);
            this.Controls.Add(this.lblTitle);
            this.Name = "addGhiNuoc";
            this.Text = "addGhiNuoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtChiSoMoi;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblSoCongTo;
        private System.Windows.Forms.Label lblChiSo;
        private System.Windows.Forms.Label lblHang;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dateTimeGhiNuoc;
        private System.Windows.Forms.TextBox txtLuongNuoc;
    }
}