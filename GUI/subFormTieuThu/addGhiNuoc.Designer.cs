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
            this.btnThem = new System.Windows.Forms.Button();
            this.lblChiSo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dateThoiGianDau = new System.Windows.Forms.DateTimePicker();
            this.dateThoiGianCuoi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(60, 114);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(245, 36);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblChiSo
            // 
            this.lblChiSo.AutoSize = true;
            this.lblChiSo.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiSo.Location = new System.Drawing.Point(15, 43);
            this.lblChiSo.Name = "lblChiSo";
            this.lblChiSo.Size = new System.Drawing.Size(95, 18);
            this.lblChiSo.TabIndex = 14;
            this.lblChiSo.Text = "Thời gian đầu";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(123, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 23);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "GHI SỐ NƯỚC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateThoiGianDau
            // 
            this.dateThoiGianDau.CalendarFont = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateThoiGianDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateThoiGianDau.Location = new System.Drawing.Point(116, 42);
            this.dateThoiGianDau.Name = "dateThoiGianDau";
            this.dateThoiGianDau.Size = new System.Drawing.Size(225, 20);
            this.dateThoiGianDau.TabIndex = 23;
            // 
            // dateThoiGianCuoi
            // 
            this.dateThoiGianCuoi.CalendarFont = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateThoiGianCuoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateThoiGianCuoi.Location = new System.Drawing.Point(115, 81);
            this.dateThoiGianCuoi.Name = "dateThoiGianCuoi";
            this.dateThoiGianCuoi.Size = new System.Drawing.Size(225, 20);
            this.dateThoiGianCuoi.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Thời gian cuối";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Firebrick;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(330, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(39, 26);
            this.btnThoat.TabIndex = 83;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // addGhiNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 162);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dateThoiGianCuoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateThoiGianDau);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblChiSo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addGhiNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addGhiNuoc";
            this.Load += new System.EventHandler(this.addGhiNuoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblChiSo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dateThoiGianDau;
        private System.Windows.Forms.DateTimePicker dateThoiGianCuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}