namespace GUI
{
    partial class frmLoaiDongHo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiDongHo));
            this.panelTool = new System.Windows.Forms.Panel();
            this.grpCapNhat = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtchiSo = new System.Windows.Forms.TextBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.panelLoaiDongHo = new System.Windows.Forms.Panel();
            this.dgvLoaiDongHo = new System.Windows.Forms.DataGridView();
            this.panelTool.SuspendLayout();
            this.grpCapNhat.SuspendLayout();
            this.panelLoaiDongHo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDongHo)).BeginInit();
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
            this.grpCapNhat.Controls.Add(this.label3);
            this.grpCapNhat.Controls.Add(this.txtTenHang);
            this.grpCapNhat.Controls.Add(this.label2);
            this.grpCapNhat.Controls.Add(this.txttenSP);
            this.grpCapNhat.Controls.Add(this.label5);
            this.grpCapNhat.Controls.Add(this.txtchiSo);
            this.grpCapNhat.Controls.Add(this.btnTK);
            this.grpCapNhat.Controls.Add(this.label1);
            this.grpCapNhat.Controls.Add(this.txtMaSP);
            this.grpCapNhat.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCapNhat.Location = new System.Drawing.Point(12, 31);
            this.grpCapNhat.Name = "grpCapNhat";
            this.grpCapNhat.Size = new System.Drawing.Size(766, 131);
            this.grpCapNhat.TabIndex = 43;
            this.grpCapNhat.TabStop = false;
            this.grpCapNhat.Text = "Hộp tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tên hãng sản xuất";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(496, 59);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(224, 23);
            this.txtTenHang.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txttenSP
            // 
            this.txttenSP.Location = new System.Drawing.Point(131, 59);
            this.txttenSP.Name = "txttenSP";
            this.txttenSP.Size = new System.Drawing.Size(198, 23);
            this.txttenSP.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Chỉ số công tơ";
            // 
            // txtchiSo
            // 
            this.txtchiSo.Location = new System.Drawing.Point(496, 31);
            this.txtchiSo.Name = "txtchiSo";
            this.txtchiSo.Size = new System.Drawing.Size(86, 23);
            this.txtchiSo.TabIndex = 44;
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTK.Image")));
            this.btnTK.Location = new System.Drawing.Point(288, 92);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(121, 33);
            this.btnTK.TabIndex = 40;
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(131, 31);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(82, 23);
            this.txtMaSP.TabIndex = 32;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(363, 2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(75, 28);
            this.btnXuatFile.TabIndex = 42;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // panelLoaiDongHo
            // 
            this.panelLoaiDongHo.Controls.Add(this.dgvLoaiDongHo);
            this.panelLoaiDongHo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoaiDongHo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLoaiDongHo.Location = new System.Drawing.Point(0, 168);
            this.panelLoaiDongHo.Name = "panelLoaiDongHo";
            this.panelLoaiDongHo.Size = new System.Drawing.Size(800, 282);
            this.panelLoaiDongHo.TabIndex = 1;
            // 
            // dgvLoaiDongHo
            // 
            this.dgvLoaiDongHo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiDongHo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiDongHo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiDongHo.Location = new System.Drawing.Point(0, 0);
            this.dgvLoaiDongHo.Name = "dgvLoaiDongHo";
            this.dgvLoaiDongHo.ReadOnly = true;
            this.dgvLoaiDongHo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiDongHo.Size = new System.Drawing.Size(800, 282);
            this.dgvLoaiDongHo.TabIndex = 0;
            this.dgvLoaiDongHo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiDongHo_CellClick);
            // 
            // frmLoaiDongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLoaiDongHo);
            this.Controls.Add(this.panelTool);
            this.Name = "frmLoaiDongHo";
            this.Text = "frmLoaiDongHo";
            this.Load += new System.EventHandler(this.frmLoaiDongHo_Load);
            this.panelTool.ResumeLayout(false);
            this.grpCapNhat.ResumeLayout(false);
            this.grpCapNhat.PerformLayout();
            this.panelLoaiDongHo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDongHo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Panel panelLoaiDongHo;
        private System.Windows.Forms.DataGridView dgvLoaiDongHo;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.GroupBox grpCapNhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtchiSo;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSP;
    }
}