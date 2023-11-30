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
            this.grpCapNhat = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.txtTinhtrang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.grpXoa = new System.Windows.Forms.GroupBox();
            this.btnHopTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.timerXoa = new System.Windows.Forms.Timer(this.components);
            this.timerCapNhat = new System.Windows.Forms.Timer(this.components);
            this.panelHoaDonThuTien = new System.Windows.Forms.Panel();
            this.panelTool.SuspendLayout();
            this.grpCapNhat.SuspendLayout();
            this.grpXoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panelHoaDonThuTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.grpCapNhat);
            this.panelTool.Controls.Add(this.grpXoa);
            this.panelTool.Controls.Add(this.button1);
            this.panelTool.Controls.Add(this.btnCapNhat);
            this.panelTool.Controls.Add(this.btnXoa);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.MaximumSize = new System.Drawing.Size(800, 168);
            this.panelTool.MinimumSize = new System.Drawing.Size(800, 31);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(800, 168);
            this.panelTool.TabIndex = 3;
            // 
            // grpCapNhat
            // 
            this.grpCapNhat.Controls.Add(this.label5);
            this.grpCapNhat.Controls.Add(this.txtmaNV);
            this.grpCapNhat.Controls.Add(this.txtTinhtrang);
            this.grpCapNhat.Controls.Add(this.label4);
            this.grpCapNhat.Controls.Add(this.btnCN);
            this.grpCapNhat.Controls.Add(this.label1);
            this.grpCapNhat.Controls.Add(this.txtMaHD);
            this.grpCapNhat.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCapNhat.Location = new System.Drawing.Point(6, 34);
            this.grpCapNhat.Name = "grpCapNhat";
            this.grpCapNhat.Size = new System.Drawing.Size(215, 131);
            this.grpCapNhat.TabIndex = 42;
            this.grpCapNhat.TabStop = false;
            this.grpCapNhat.Text = "Hộp cập nhật ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mã nhân viên";
            // 
            // txtmaNV
            // 
            this.txtmaNV.Location = new System.Drawing.Point(91, 46);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(114, 23);
            this.txtmaNV.TabIndex = 44;
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.FormattingEnabled = true;
            this.txtTinhtrang.Items.AddRange(new object[] {
            "0-chưa nộp",
            "1-đã nộp"});
            this.txtTinhtrang.Location = new System.Drawing.Point(91, 73);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.Size = new System.Drawing.Size(114, 24);
            this.txtTinhtrang.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tình trạng";
            // 
            // btnCN
            // 
            this.btnCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN.Image = ((System.Drawing.Image)(resources.GetObject("btnCN.Image")));
            this.btnCN.Location = new System.Drawing.Point(9, 102);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(200, 29);
            this.btnCN.TabIndex = 40;
            this.btnCN.UseVisualStyleBackColor = true;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(91, 19);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(114, 23);
            this.txtMaHD.TabIndex = 32;
            // 
            // grpXoa
            // 
            this.grpXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpXoa.Controls.Add(this.btnHopTimKiem);
            this.grpXoa.Controls.Add(this.label2);
            this.grpXoa.Controls.Add(this.txtMa);
            this.grpXoa.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpXoa.Location = new System.Drawing.Point(675, 39);
            this.grpXoa.Name = "grpXoa";
            this.grpXoa.Size = new System.Drawing.Size(113, 86);
            this.grpXoa.TabIndex = 41;
            this.grpXoa.TabStop = false;
            this.grpXoa.Text = "Hộp xóa";
            // 
            // btnHopTimKiem
            // 
            this.btnHopTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnHopTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopTimKiem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopTimKiem.Location = new System.Drawing.Point(8, 50);
            this.btnHopTimKiem.Name = "btnHopTimKiem";
            this.btnHopTimKiem.Size = new System.Drawing.Size(99, 27);
            this.btnHopTimKiem.TabIndex = 33;
            this.btnHopTimKiem.Text = "XÓA";
            this.btnHopTimKiem.UseVisualStyleBackColor = true;
            this.btnHopTimKiem.Click += new System.EventHandler(this.btnHopTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(35, 18);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(67, 23);
            this.txtMa.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(458, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 28);
            this.button1.TabIndex = 40;
            this.button1.Text = "In hóa đơn";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(358, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(84, 28);
            this.btnCapNhat.TabIndex = 39;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(261, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 28);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.dgvHoaDon.Size = new System.Drawing.Size(800, 282);
            this.dgvHoaDon.TabIndex = 4;
            // 
            // timerXoa
            // 
            this.timerXoa.Interval = 20;
            this.timerXoa.Tick += new System.EventHandler(this.timerXoa_Tick);
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
            this.panelHoaDonThuTien.Location = new System.Drawing.Point(0, 168);
            this.panelHoaDonThuTien.Name = "panelHoaDonThuTien";
            this.panelHoaDonThuTien.Size = new System.Drawing.Size(800, 282);
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
            this.grpXoa.ResumeLayout(false);
            this.grpXoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panelHoaDonThuTien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerXoa;
        private System.Windows.Forms.GroupBox grpXoa;
        private System.Windows.Forms.Button btnHopTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.GroupBox grpCapNhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.ComboBox txtTinhtrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.Timer timerCapNhat;
        private System.Windows.Forms.Panel panelHoaDonThuTien;
    }
}