﻿namespace GUI
{
    partial class subAddDongHo
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHang = new System.Windows.Forms.Label();
            this.lblChiSo = new System.Windows.Forms.Label();
            this.lblSoCongTo = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.txtChiSoDau = new System.Windows.Forms.TextBox();
            this.txtSoCongTo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTT = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(106, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM ĐỒNG HỒ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHang
            // 
            this.lblHang.AutoSize = true;
            this.lblHang.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHang.Location = new System.Drawing.Point(17, 59);
            this.lblHang.Name = "lblHang";
            this.lblHang.Size = new System.Drawing.Size(42, 18);
            this.lblHang.TabIndex = 1;
            this.lblHang.Text = "Hãng";
            // 
            // lblChiSo
            // 
            this.lblChiSo.AutoSize = true;
            this.lblChiSo.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiSo.Location = new System.Drawing.Point(17, 100);
            this.lblChiSo.Name = "lblChiSo";
            this.lblChiSo.Size = new System.Drawing.Size(77, 18);
            this.lblChiSo.TabIndex = 2;
            this.lblChiSo.Text = "Chỉ số đầu";
            // 
            // lblSoCongTo
            // 
            this.lblSoCongTo.AutoSize = true;
            this.lblSoCongTo.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoCongTo.Location = new System.Drawing.Point(17, 142);
            this.lblSoCongTo.Name = "lblSoCongTo";
            this.lblSoCongTo.Size = new System.Drawing.Size(77, 18);
            this.lblSoCongTo.TabIndex = 3;
            this.lblSoCongTo.Text = "Số công tơ";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.Location = new System.Drawing.Point(17, 186);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(74, 18);
            this.lblTinhTrang.TabIndex = 4;
            this.lblTinhTrang.Text = "Tình trạng";
            // 
            // txtHang
            // 
            this.txtHang.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHang.Location = new System.Drawing.Point(118, 59);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(225, 23);
            this.txtHang.TabIndex = 5;
            // 
            // txtChiSoDau
            // 
            this.txtChiSoDau.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiSoDau.Location = new System.Drawing.Point(118, 100);
            this.txtChiSoDau.Name = "txtChiSoDau";
            this.txtChiSoDau.Size = new System.Drawing.Size(225, 23);
            this.txtChiSoDau.TabIndex = 6;
            // 
            // txtSoCongTo
            // 
            this.txtSoCongTo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCongTo.Location = new System.Drawing.Point(118, 141);
            this.txtSoCongTo.Name = "txtSoCongTo";
            this.txtSoCongTo.Size = new System.Drawing.Size(225, 23);
            this.txtSoCongTo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(203, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTT
            // 
            this.txtTT.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTT.FormattingEnabled = true;
            this.txtTT.Items.AddRange(new object[] {
            "0-Chưa sử dụng",
            "1-Đã sử dụng"});
            this.txtTT.Location = new System.Drawing.Point(118, 185);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(225, 24);
            this.txtTT.TabIndex = 11;
            // 
            // subAddDongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 297);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSoCongTo);
            this.Controls.Add(this.txtChiSoDau);
            this.Controls.Add(this.txtHang);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.lblSoCongTo);
            this.Controls.Add(this.lblChiSo);
            this.Controls.Add(this.lblHang);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "subAddDongHo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "subAddDongHo";
            this.Load += new System.EventHandler(this.subAddDongHo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHang;
        private System.Windows.Forms.Label lblChiSo;
        private System.Windows.Forms.Label lblSoCongTo;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.TextBox txtChiSoDau;
        private System.Windows.Forms.TextBox txtSoCongTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox txtTT;
    }
}