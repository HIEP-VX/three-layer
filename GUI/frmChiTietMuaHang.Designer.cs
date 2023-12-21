namespace GUI
{
    partial class frmChiTietMuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietMuaHang));
            this.panelTool = new System.Windows.Forms.Panel();
            this.grpCapNhat = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.panelChiTietMuaHang = new System.Windows.Forms.Panel();
            this.dgvChiTietMuaHang = new System.Windows.Forms.DataGridView();
            this.panelTool.SuspendLayout();
            this.grpCapNhat.SuspendLayout();
            this.panelChiTietMuaHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietMuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.grpCapNhat);
            this.panelTool.Controls.Add(this.btnXuatFile);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.MaximumSize = new System.Drawing.Size(800, 168);
            this.panelTool.MinimumSize = new System.Drawing.Size(800, 32);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(800, 168);
            this.panelTool.TabIndex = 0;
            // 
            // grpCapNhat
            // 
            this.grpCapNhat.Controls.Add(this.btnTimKiem);
            this.grpCapNhat.Controls.Add(this.label6);
            this.grpCapNhat.Controls.Add(this.txtTien);
            this.grpCapNhat.Controls.Add(this.label3);
            this.grpCapNhat.Controls.Add(this.txtSL);
            this.grpCapNhat.Controls.Add(this.label2);
            this.grpCapNhat.Controls.Add(this.txtMaSP);
            this.grpCapNhat.Controls.Add(this.label5);
            this.grpCapNhat.Controls.Add(this.txtmaMH);
            this.grpCapNhat.Controls.Add(this.label1);
            this.grpCapNhat.Controls.Add(this.txtMaCT);
            this.grpCapNhat.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCapNhat.Location = new System.Drawing.Point(168, 31);
            this.grpCapNhat.Name = "grpCapNhat";
            this.grpCapNhat.Size = new System.Drawing.Size(544, 131);
            this.grpCapNhat.TabIndex = 43;
            this.grpCapNhat.TabStop = false;
            this.grpCapNhat.Text = "Hộp tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(438, 50);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem.TabIndex = 41;
            this.btnTimKiem.Text = "THỰC HIỆN";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tiền";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(282, 59);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(136, 23);
            this.txtTien.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Số lượng";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(282, 31);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(136, 23);
            this.txtSL.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(100, 59);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(82, 23);
            this.txtMaSP.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mã mua hàng";
            // 
            // txtmaMH
            // 
            this.txtmaMH.Location = new System.Drawing.Point(100, 87);
            this.txtmaMH.Name = "txtmaMH";
            this.txtmaMH.Size = new System.Drawing.Size(82, 23);
            this.txtmaMH.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã chi tiết";
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(100, 31);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(82, 23);
            this.txtMaCT.TabIndex = 32;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.Image")));
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(12, 3);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(82, 28);
            this.btnXuatFile.TabIndex = 42;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // panelChiTietMuaHang
            // 
            this.panelChiTietMuaHang.Controls.Add(this.dgvChiTietMuaHang);
            this.panelChiTietMuaHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChiTietMuaHang.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelChiTietMuaHang.Location = new System.Drawing.Point(0, 168);
            this.panelChiTietMuaHang.Name = "panelChiTietMuaHang";
            this.panelChiTietMuaHang.Size = new System.Drawing.Size(800, 282);
            this.panelChiTietMuaHang.TabIndex = 1;
            // 
            // dgvChiTietMuaHang
            // 
            this.dgvChiTietMuaHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietMuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietMuaHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietMuaHang.Location = new System.Drawing.Point(0, 0);
            this.dgvChiTietMuaHang.Name = "dgvChiTietMuaHang";
            this.dgvChiTietMuaHang.ReadOnly = true;
            this.dgvChiTietMuaHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietMuaHang.Size = new System.Drawing.Size(800, 282);
            this.dgvChiTietMuaHang.TabIndex = 0;
            this.dgvChiTietMuaHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietMuaHang_CellClick);
            // 
            // frmChiTietMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChiTietMuaHang);
            this.Controls.Add(this.panelTool);
            this.Name = "frmChiTietMuaHang";
            this.Text = "frmChiTietMuaHang";
            this.Load += new System.EventHandler(this.frmChiTietMuaHang_Load);
            this.panelTool.ResumeLayout(false);
            this.grpCapNhat.ResumeLayout(false);
            this.grpCapNhat.PerformLayout();
            this.panelChiTietMuaHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietMuaHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panelChiTietMuaHang;
        private System.Windows.Forms.DataGridView dgvChiTietMuaHang;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.GroupBox grpCapNhat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCT;
    }
}