namespace GUI
{
    partial class frmTieuThu
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
            this.panelTool = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnChiaPhuong = new System.Windows.Forms.Button();
            this.grpChiSoNuoc = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMATT = new System.Windows.Forms.TextBox();
            this.txtChiSoNuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuuChiSo = new System.Windows.Forms.Button();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnThemExcel = new System.Windows.Forms.Button();
            this.btnGhiNuoc = new System.Windows.Forms.Button();
            this.panelGhiNuoc = new System.Windows.Forms.Panel();
            this.dgvGhiNuoc = new System.Windows.Forms.DataGridView();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelTool.SuspendLayout();
            this.grpChiSoNuoc.SuspendLayout();
            this.panelGhiNuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiNuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.comboBox1);
            this.panelTool.Controls.Add(this.btnCapNhat);
            this.panelTool.Controls.Add(this.btnChiaPhuong);
            this.panelTool.Controls.Add(this.grpChiSoNuoc);
            this.panelTool.Controls.Add(this.cbThang);
            this.panelTool.Controls.Add(this.btnSave);
            this.panelTool.Controls.Add(this.btnThemExcel);
            this.panelTool.Controls.Add(this.btnGhiNuoc);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.MaximumSize = new System.Drawing.Size(800, 168);
            this.panelTool.MinimumSize = new System.Drawing.Size(800, 32);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(800, 168);
            this.panelTool.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(388, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 28);
            this.btnCapNhat.TabIndex = 53;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnChiaPhuong
            // 
            this.btnChiaPhuong.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiaPhuong.Location = new System.Drawing.Point(294, 3);
            this.btnChiaPhuong.Name = "btnChiaPhuong";
            this.btnChiaPhuong.Size = new System.Drawing.Size(88, 28);
            this.btnChiaPhuong.TabIndex = 52;
            this.btnChiaPhuong.Text = "Theo phường";
            this.btnChiaPhuong.UseVisualStyleBackColor = true;
            this.btnChiaPhuong.Click += new System.EventHandler(this.btnChiaPhuong_Click);
            // 
            // grpChiSoNuoc
            // 
            this.grpChiSoNuoc.Controls.Add(this.label2);
            this.grpChiSoNuoc.Controls.Add(this.txtMATT);
            this.grpChiSoNuoc.Controls.Add(this.txtChiSoNuoc);
            this.grpChiSoNuoc.Controls.Add(this.label1);
            this.grpChiSoNuoc.Controls.Add(this.btnLuuChiSo);
            this.grpChiSoNuoc.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChiSoNuoc.Location = new System.Drawing.Point(10, 36);
            this.grpChiSoNuoc.Name = "grpChiSoNuoc";
            this.grpChiSoNuoc.Size = new System.Drawing.Size(193, 126);
            this.grpChiSoNuoc.TabIndex = 51;
            this.grpChiSoNuoc.TabStop = false;
            this.grpChiSoNuoc.Text = "Cập nhật chỉ số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Chỉ số mới";
            // 
            // txtMATT
            // 
            this.txtMATT.Location = new System.Drawing.Point(79, 25);
            this.txtMATT.Name = "txtMATT";
            this.txtMATT.Size = new System.Drawing.Size(100, 23);
            this.txtMATT.TabIndex = 50;
            // 
            // txtChiSoNuoc
            // 
            this.txtChiSoNuoc.Location = new System.Drawing.Point(79, 63);
            this.txtChiSoNuoc.Name = "txtChiSoNuoc";
            this.txtChiSoNuoc.Size = new System.Drawing.Size(100, 23);
            this.txtChiSoNuoc.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mã";
            // 
            // btnLuuChiSo
            // 
            this.btnLuuChiSo.FlatAppearance.BorderSize = 0;
            this.btnLuuChiSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuChiSo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuChiSo.Location = new System.Drawing.Point(11, 92);
            this.btnLuuChiSo.Name = "btnLuuChiSo";
            this.btnLuuChiSo.Size = new System.Drawing.Size(168, 28);
            this.btnLuuChiSo.TabIndex = 49;
            this.btnLuuChiSo.Text = "Lưu";
            this.btnLuuChiSo.UseVisualStyleBackColor = true;
            this.btnLuuChiSo.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbThang
            // 
            this.cbThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(20, 5);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(69, 21);
            this.cbThang.TabIndex = 50;
            this.cbThang.Text = "Tháng";
            this.cbThang.SelectedIndexChanged += new System.EventHandler(this.cbThang_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(625, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnThemExcel
            // 
            this.btnThemExcel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemExcel.Location = new System.Drawing.Point(513, 5);
            this.btnThemExcel.Name = "btnThemExcel";
            this.btnThemExcel.Size = new System.Drawing.Size(106, 28);
            this.btnThemExcel.TabIndex = 44;
            this.btnThemExcel.Text = "Thêm tệp excel";
            this.btnThemExcel.UseVisualStyleBackColor = true;
            this.btnThemExcel.Click += new System.EventHandler(this.btnThemExcel_Click);
            // 
            // btnGhiNuoc
            // 
            this.btnGhiNuoc.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiNuoc.Location = new System.Drawing.Point(213, 3);
            this.btnGhiNuoc.Name = "btnGhiNuoc";
            this.btnGhiNuoc.Size = new System.Drawing.Size(75, 28);
            this.btnGhiNuoc.TabIndex = 43;
            this.btnGhiNuoc.Text = "Ghi nước";
            this.btnGhiNuoc.UseVisualStyleBackColor = true;
            this.btnGhiNuoc.Click += new System.EventHandler(this.btnGhiNuoc_Click);
            // 
            // panelGhiNuoc
            // 
            this.panelGhiNuoc.Controls.Add(this.dgvGhiNuoc);
            this.panelGhiNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGhiNuoc.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelGhiNuoc.Location = new System.Drawing.Point(0, 168);
            this.panelGhiNuoc.Name = "panelGhiNuoc";
            this.panelGhiNuoc.Size = new System.Drawing.Size(800, 282);
            this.panelGhiNuoc.TabIndex = 2;
            // 
            // dgvGhiNuoc
            // 
            this.dgvGhiNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGhiNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGhiNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGhiNuoc.Location = new System.Drawing.Point(0, 0);
            this.dgvGhiNuoc.Name = "dgvGhiNuoc";
            this.dgvGhiNuoc.ReadOnly = true;
            this.dgvGhiNuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGhiNuoc.Size = new System.Drawing.Size(800, 282);
            this.dgvGhiNuoc.TabIndex = 0;
            this.dgvGhiNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGhiNuoc_CellClick);
            this.dgvGhiNuoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGhiNuoc_CellDoubleClick);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 54;
            // 
            // frmTieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGhiNuoc);
            this.Controls.Add(this.panelTool);
            this.Name = "frmTieuThu";
            this.Text = "frmTieuThu";
            this.Load += new System.EventHandler(this.frmGhiNuoc_Load);
            this.panelTool.ResumeLayout(false);
            this.grpChiSoNuoc.ResumeLayout(false);
            this.grpChiSoNuoc.PerformLayout();
            this.panelGhiNuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiNuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Panel panelGhiNuoc;
        private System.Windows.Forms.Button btnGhiNuoc;
        private System.Windows.Forms.Button btnThemExcel;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvGhiNuoc;
        private System.Windows.Forms.Button btnLuuChiSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChiSoNuoc;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.GroupBox grpChiSoNuoc;
        private System.Windows.Forms.TextBox txtMATT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnChiaPhuong;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}