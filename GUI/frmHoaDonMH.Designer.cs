namespace GUI
{
    partial class frmHoaDonMH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonMH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpCapNhat = new System.Windows.Forms.GroupBox();
            this.txtTinhTrang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvHDMH = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grpCapNhat.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDMH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpCapNhat);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(800, 168);
            this.panel1.MinimumSize = new System.Drawing.Size(800, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 168);
            this.panel1.TabIndex = 0;
            // 
            // grpCapNhat
            // 
            this.grpCapNhat.Controls.Add(this.txtTinhTrang);
            this.grpCapNhat.Controls.Add(this.label2);
            this.grpCapNhat.Controls.Add(this.txtMaMH);
            this.grpCapNhat.Controls.Add(this.label5);
            this.grpCapNhat.Controls.Add(this.txtmaNV);
            this.grpCapNhat.Controls.Add(this.label4);
            this.grpCapNhat.Controls.Add(this.btnCN);
            this.grpCapNhat.Controls.Add(this.label1);
            this.grpCapNhat.Controls.Add(this.txtMaHD);
            this.grpCapNhat.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCapNhat.Location = new System.Drawing.Point(81, 34);
            this.grpCapNhat.Name = "grpCapNhat";
            this.grpCapNhat.Size = new System.Drawing.Size(616, 131);
            this.grpCapNhat.TabIndex = 44;
            this.grpCapNhat.TabStop = false;
            this.grpCapNhat.Text = "Hộp tìm kiếm";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.FormattingEnabled = true;
            this.txtTinhTrang.Items.AddRange(new object[] {
            "0 - chưa thanh toán",
            "1 - đã thanh toán"});
            this.txtTinhTrang.Location = new System.Drawing.Point(349, 58);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(156, 24);
            this.txtTinhTrang.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã mua hàng";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(118, 55);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(82, 23);
            this.txtMaMH.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mã nhân viên";
            // 
            // txtmaNV
            // 
            this.txtmaNV.Location = new System.Drawing.Point(349, 27);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(82, 23);
            this.txtmaNV.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tình trạng";
            // 
            // btnCN
            // 
            this.btnCN.FlatAppearance.BorderSize = 0;
            this.btnCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCN.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN.Location = new System.Drawing.Point(180, 88);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(172, 35);
            this.btnCN.TabIndex = 40;
            this.btnCN.Text = "THỰC HIỆN";
            this.btnCN.UseVisualStyleBackColor = true;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(118, 27);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(82, 23);
            this.txtMaHD.TabIndex = 32;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(9, 7);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(100, 28);
            this.btnThanhToan.TabIndex = 43;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvHDMH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 282);
            this.panel2.TabIndex = 1;
            // 
            // dgvHDMH
            // 
            this.dgvHDMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDMH.Location = new System.Drawing.Point(0, 0);
            this.dgvHDMH.Name = "dgvHDMH";
            this.dgvHDMH.ReadOnly = true;
            this.dgvHDMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDMH.Size = new System.Drawing.Size(801, 282);
            this.dgvHDMH.TabIndex = 0;
            this.dgvHDMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDMH_CellClick);
            // 
            // frmHoaDonMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDonMH";
            this.Text = "frmHoaDonMH";
            this.Load += new System.EventHandler(this.frmHoaDonMH_Load);
            this.panel1.ResumeLayout(false);
            this.grpCapNhat.ResumeLayout(false);
            this.grpCapNhat.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDMH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvHDMH;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.GroupBox grpCapNhat;
        private System.Windows.Forms.ComboBox txtTinhTrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
    }
}