namespace GUI
{
    partial class frmHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.panelTool = new System.Windows.Forms.Panel();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpCapNhat = new System.Windows.Forms.GroupBox();
            this.txtTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongthue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienNuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLuongNuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.timerCapNhat = new System.Windows.Forms.Timer(this.components);
            this.panelHoaDonThuTien = new System.Windows.Forms.Panel();
            this.panelTool.SuspendLayout();
            this.grpCapNhat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panelHoaDonThuTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.btnXuatFile);
            this.panelTool.Controls.Add(this.btnTimKiem);
            this.panelTool.Controls.Add(this.grpCapNhat);
            this.panelTool.Controls.Add(this.button1);
            this.panelTool.Controls.Add(this.btnCapNhat);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.MaximumSize = new System.Drawing.Size(800, 168);
            this.panelTool.MinimumSize = new System.Drawing.Size(800, 32);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(800, 32);
            this.panelTool.TabIndex = 3;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.Image")));
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(493, 2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(77, 28);
            this.btnXuatFile.TabIndex = 55;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(197, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(84, 28);
            this.btnTimKiem.TabIndex = 43;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // grpCapNhat
            // 
            this.grpCapNhat.Controls.Add(this.txtTinhTrang);
            this.grpCapNhat.Controls.Add(this.cbThang);
            this.grpCapNhat.Controls.Add(this.txtNgay);
            this.grpCapNhat.Controls.Add(this.txtNam);
            this.grpCapNhat.Controls.Add(this.label9);
            this.grpCapNhat.Controls.Add(this.label8);
            this.grpCapNhat.Controls.Add(this.txtTongtien);
            this.grpCapNhat.Controls.Add(this.label7);
            this.grpCapNhat.Controls.Add(this.txtTongthue);
            this.grpCapNhat.Controls.Add(this.label6);
            this.grpCapNhat.Controls.Add(this.txtTienNuoc);
            this.grpCapNhat.Controls.Add(this.label3);
            this.grpCapNhat.Controls.Add(this.txtLuongNuoc);
            this.grpCapNhat.Controls.Add(this.label2);
            this.grpCapNhat.Controls.Add(this.txtMaTT);
            this.grpCapNhat.Controls.Add(this.label5);
            this.grpCapNhat.Controls.Add(this.txtmaNV);
            this.grpCapNhat.Controls.Add(this.label4);
            this.grpCapNhat.Controls.Add(this.btnCN);
            this.grpCapNhat.Controls.Add(this.label1);
            this.grpCapNhat.Controls.Add(this.txtMaHD);
            this.grpCapNhat.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCapNhat.Location = new System.Drawing.Point(6, 34);
            this.grpCapNhat.Name = "grpCapNhat";
            this.grpCapNhat.Size = new System.Drawing.Size(782, 131);
            this.grpCapNhat.TabIndex = 42;
            this.grpCapNhat.TabStop = false;
            this.grpCapNhat.Text = "Hộp tìm kiếm";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.FormattingEnabled = true;
            this.txtTinhTrang.Items.AddRange(new object[] {
            "0 - chưa thanh toán",
            "1 - đã thanh toán"});
            this.txtTinhTrang.Location = new System.Drawing.Point(519, 86);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(156, 24);
            this.txtTinhTrang.TabIndex = 79;
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(552, 58);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(57, 24);
            this.cbThang.TabIndex = 78;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(519, 59);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(30, 23);
            this.txtNgay.TabIndex = 77;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(612, 59);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(63, 23);
            this.txtNam.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(437, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 55;
            this.label9.Text = "Thời gian";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(437, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Tổng tiền";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(519, 31);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(156, 23);
            this.txtTongtien.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(202, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Tổng thuế";
            // 
            // txtTongthue
            // 
            this.txtTongthue.Location = new System.Drawing.Point(282, 87);
            this.txtTongthue.Name = "txtTongthue";
            this.txtTongthue.Size = new System.Drawing.Size(136, 23);
            this.txtTongthue.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tiền nước";
            // 
            // txtTienNuoc
            // 
            this.txtTienNuoc.Location = new System.Drawing.Point(282, 59);
            this.txtTienNuoc.Name = "txtTienNuoc";
            this.txtTienNuoc.Size = new System.Drawing.Size(136, 23);
            this.txtTienNuoc.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Lượng nước";
            // 
            // txtLuongNuoc
            // 
            this.txtLuongNuoc.Location = new System.Drawing.Point(282, 31);
            this.txtLuongNuoc.Name = "txtLuongNuoc";
            this.txtLuongNuoc.Size = new System.Drawing.Size(136, 23);
            this.txtLuongNuoc.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã tiêu thụ";
            // 
            // txtMaTT
            // 
            this.txtMaTT.Location = new System.Drawing.Point(100, 59);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(82, 23);
            this.txtMaTT.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mã nhân viên";
            // 
            // txtmaNV
            // 
            this.txtmaNV.Location = new System.Drawing.Point(100, 87);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(82, 23);
            this.txtmaNV.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tình trạng";
            // 
            // btnCN
            // 
            this.btnCN.FlatAppearance.BorderSize = 0;
            this.btnCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCN.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN.Location = new System.Drawing.Point(694, 31);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(82, 79);
            this.btnCN.TabIndex = 40;
            this.btnCN.Text = "THỰC\r\nHIỆN";
            this.btnCN.UseVisualStyleBackColor = true;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(100, 31);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(82, 23);
            this.txtMaHD.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(387, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 28);
            this.button1.TabIndex = 40;
            this.button1.Text = "In hóa đơn";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(292, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(84, 28);
            this.btnCapNhat.TabIndex = 39;
            this.btnCapNhat.Text = "Nộp tiền";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(800, 418);
            this.dgvHoaDon.TabIndex = 4;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // timerCapNhat
            // 
            this.timerCapNhat.Interval = 20;
            this.timerCapNhat.Tick += new System.EventHandler(this.timerCapNhat_Tick);
            // 
            // panelHoaDonThuTien
            // 
            this.panelHoaDonThuTien.Controls.Add(this.dgvHoaDon);
            this.panelHoaDonThuTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHoaDonThuTien.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHoaDonThuTien.Location = new System.Drawing.Point(0, 32);
            this.panelHoaDonThuTien.Name = "panelHoaDonThuTien";
            this.panelHoaDonThuTien.Size = new System.Drawing.Size(800, 418);
            this.panelHoaDonThuTien.TabIndex = 4;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelHoaDonThuTien);
            this.Controls.Add(this.panelTool);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.panelTool.ResumeLayout(false);
            this.grpCapNhat.ResumeLayout(false);
            this.grpCapNhat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panelHoaDonThuTien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpCapNhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.Timer timerCapNhat;
        private System.Windows.Forms.Panel panelHoaDonThuTien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongthue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTienNuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLuongNuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.ComboBox txtTinhTrang;
        private System.Windows.Forms.Button btnXuatFile;
    }
}