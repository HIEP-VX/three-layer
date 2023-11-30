namespace GUI
{
    partial class frmDongHo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDongHo));
            this.panelTool = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHopTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChiSoDau = new System.Windows.Forms.TextBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvDongho = new System.Windows.Forms.DataGridView();
            this.timerTimKiem = new System.Windows.Forms.Timer(this.components);
            this.panelDgvDH = new System.Windows.Forms.Panel();
            this.panelTool.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongho)).BeginInit();
            this.panelDgvDH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.groupBox1);
            this.panelTool.Controls.Add(this.btnTimKiem);
            this.panelTool.Controls.Add(this.btnCapNhat);
            this.panelTool.Controls.Add(this.btnXoa);
            this.panelTool.Controls.Add(this.btnAdd);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.MaximumSize = new System.Drawing.Size(800, 168);
            this.panelTool.MinimumSize = new System.Drawing.Size(800, 29);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(800, 168);
            this.panelTool.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTinhTrang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnHopTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtChiSoDau);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 119);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hộp tìm kiếm";
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "0-Chưa sử dụng",
            "1-Đã sử dụng"});
            this.cbTinhTrang.Location = new System.Drawing.Point(399, 59);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(152, 24);
            this.cbTinhTrang.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tình trạng";
            // 
            // btnHopTimKiem
            // 
            this.btnHopTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHopTimKiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnHopTimKiem.Image")));
            this.btnHopTimKiem.Location = new System.Drawing.Point(587, 22);
            this.btnHopTimKiem.Name = "btnHopTimKiem";
            this.btnHopTimKiem.Size = new System.Drawing.Size(56, 36);
            this.btnHopTimKiem.TabIndex = 33;
            this.btnHopTimKiem.UseVisualStyleBackColor = true;
            this.btnHopTimKiem.Click += new System.EventHandler(this.btnHopTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(115, 31);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(152, 23);
            this.txtMa.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã phiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Chỉ số đầu";
            // 
            // txtChiSoDau
            // 
            this.txtChiSoDau.Location = new System.Drawing.Point(399, 31);
            this.txtChiSoDau.Name = "txtChiSoDau";
            this.txtChiSoDau.Size = new System.Drawing.Size(152, 23);
            this.txtChiSoDau.TabIndex = 30;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(115, 59);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(152, 23);
            this.txtMaPhieu.TabIndex = 29;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(479, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 28);
            this.btnTimKiem.TabIndex = 37;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(324, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(84, 28);
            this.btnCapNhat.TabIndex = 36;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(184, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 28);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(49, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 28);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDongho
            // 
            this.dgvDongho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDongho.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDongho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDongho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDongho.Location = new System.Drawing.Point(0, 0);
            this.dgvDongho.Name = "dgvDongho";
            this.dgvDongho.ReadOnly = true;
            this.dgvDongho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDongho.Size = new System.Drawing.Size(800, 282);
            this.dgvDongho.TabIndex = 1;
            // 
            // timerTimKiem
            // 
            this.timerTimKiem.Interval = 15;
            this.timerTimKiem.Tick += new System.EventHandler(this.timerTimKiem_Tick);
            // 
            // panelDgvDH
            // 
            this.panelDgvDH.Controls.Add(this.dgvDongho);
            this.panelDgvDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDgvDH.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDgvDH.Location = new System.Drawing.Point(0, 168);
            this.panelDgvDH.Name = "panelDgvDH";
            this.panelDgvDH.Size = new System.Drawing.Size(800, 282);
            this.panelDgvDH.TabIndex = 1;
            // 
            // frmDongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDgvDH);
            this.Controls.Add(this.panelTool);
            this.Name = "frmDongHo";
            this.Text = "Quản lý đồng hồ";
            this.Load += new System.EventHandler(this.frmDongHo_Load);
            this.panelTool.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongho)).EndInit();
            this.panelDgvDH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvDongho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHopTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChiSoDau;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Timer timerTimKiem;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Panel panelDgvDH;
    }
}