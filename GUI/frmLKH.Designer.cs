namespace GUI
{
    partial class frmLKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLKH));
            this.panelTool = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHopCapNhat = new System.Windows.Forms.Button();
            this.txtGiaBac4 = new System.Windows.Forms.TextBox();
            this.txtGiaBac3 = new System.Windows.Forms.TextBox();
            this.txtGiaBac2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHopTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaBac1 = new System.Windows.Forms.TextBox();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.dgvLKH = new System.Windows.Forms.DataGridView();
            this.timerLKH = new System.Windows.Forms.Timer(this.components);
            this.panelDgvLKH = new System.Windows.Forms.Panel();
            this.panelTool.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLKH)).BeginInit();
            this.panelDgvLKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.btnTimKiem);
            this.panelTool.Controls.Add(this.btnCapNhat);
            this.panelTool.Controls.Add(this.btnXoa);
            this.panelTool.Controls.Add(this.btnAdd);
            this.panelTool.Controls.Add(this.groupBox1);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.MaximumSize = new System.Drawing.Size(800, 168);
            this.panelTool.MinimumSize = new System.Drawing.Size(800, 34);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(800, 168);
            this.panelTool.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(382, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(84, 28);
            this.btnTimKiem.TabIndex = 41;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(252, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(84, 28);
            this.btnCapNhat.TabIndex = 40;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(137, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 28);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(22, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 28);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHopCapNhat);
            this.groupBox1.Controls.Add(this.txtGiaBac4);
            this.groupBox1.Controls.Add(this.txtGiaBac3);
            this.groupBox1.Controls.Add(this.txtGiaBac2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnHopTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGiaBac1);
            this.groupBox1.Controls.Add(this.txtLoai);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 129);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hộp tìm kiếm";
            // 
            // btnHopCapNhat
            // 
            this.btnHopCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHopCapNhat.FlatAppearance.BorderSize = 0;
            this.btnHopCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopCapNhat.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopCapNhat.Location = new System.Drawing.Point(571, 73);
            this.btnHopCapNhat.Name = "btnHopCapNhat";
            this.btnHopCapNhat.Size = new System.Drawing.Size(112, 39);
            this.btnHopCapNhat.TabIndex = 40;
            this.btnHopCapNhat.Text = "CẬP NHẬT";
            this.btnHopCapNhat.UseVisualStyleBackColor = true;
            this.btnHopCapNhat.Click += new System.EventHandler(this.btnHopCapNhat_Click);
            // 
            // txtGiaBac4
            // 
            this.txtGiaBac4.Location = new System.Drawing.Point(394, 85);
            this.txtGiaBac4.Name = "txtGiaBac4";
            this.txtGiaBac4.Size = new System.Drawing.Size(152, 23);
            this.txtGiaBac4.TabIndex = 39;
            // 
            // txtGiaBac3
            // 
            this.txtGiaBac3.Location = new System.Drawing.Point(394, 59);
            this.txtGiaBac3.Name = "txtGiaBac3";
            this.txtGiaBac3.Size = new System.Drawing.Size(152, 23);
            this.txtGiaBac3.TabIndex = 38;
            // 
            // txtGiaBac2
            // 
            this.txtGiaBac2.Location = new System.Drawing.Point(394, 33);
            this.txtGiaBac2.Name = "txtGiaBac2";
            this.txtGiaBac2.Size = new System.Drawing.Size(152, 23);
            this.txtGiaBac2.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Giá bậc 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Giá bậc 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Giá bậc 4";
            // 
            // btnHopTimKiem
            // 
            this.btnHopTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHopTimKiem.FlatAppearance.BorderSize = 0;
            this.btnHopTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopTimKiem.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopTimKiem.Location = new System.Drawing.Point(571, 28);
            this.btnHopTimKiem.Name = "btnHopTimKiem";
            this.btnHopTimKiem.Size = new System.Drawing.Size(112, 39);
            this.btnHopTimKiem.TabIndex = 33;
            this.btnHopTimKiem.Text = "TÌM";
            this.btnHopTimKiem.UseVisualStyleBackColor = true;
            this.btnHopTimKiem.Click += new System.EventHandler(this.btnHopTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(115, 32);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(152, 23);
            this.txtMa.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Giá bậc 1";
            // 
            // txtGiaBac1
            // 
            this.txtGiaBac1.Location = new System.Drawing.Point(115, 86);
            this.txtGiaBac1.Name = "txtGiaBac1";
            this.txtGiaBac1.Size = new System.Drawing.Size(152, 23);
            this.txtGiaBac1.TabIndex = 30;
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(115, 59);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(152, 23);
            this.txtLoai.TabIndex = 29;
            // 
            // dgvLKH
            // 
            this.dgvLKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLKH.Location = new System.Drawing.Point(0, 0);
            this.dgvLKH.Name = "dgvLKH";
            this.dgvLKH.ReadOnly = true;
            this.dgvLKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLKH.Size = new System.Drawing.Size(800, 282);
            this.dgvLKH.TabIndex = 1;
            this.dgvLKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLKH_CellClick);
            // 
            // timerLKH
            // 
            this.timerLKH.Interval = 15;
            this.timerLKH.Tick += new System.EventHandler(this.timerLKH_Tick);
            // 
            // panelDgvLKH
            // 
            this.panelDgvLKH.Controls.Add(this.dgvLKH);
            this.panelDgvLKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDgvLKH.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDgvLKH.Location = new System.Drawing.Point(0, 168);
            this.panelDgvLKH.Name = "panelDgvLKH";
            this.panelDgvLKH.Size = new System.Drawing.Size(800, 282);
            this.panelDgvLKH.TabIndex = 1;
            // 
            // frmLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDgvLKH);
            this.Controls.Add(this.panelTool);
            this.Name = "frmLKH";
            this.Text = "Quản lý loại khách hàng";
            this.Load += new System.EventHandler(this.frmLKH_Load);
            this.panelTool.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLKH)).EndInit();
            this.panelDgvLKH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.DataGridView dgvLKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHopTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaBac1;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.Timer timerLKH;
        private System.Windows.Forms.TextBox txtGiaBac4;
        private System.Windows.Forms.TextBox txtGiaBac3;
        private System.Windows.Forms.TextBox txtGiaBac2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelDgvLKH;
        private System.Windows.Forms.Button btnHopCapNhat;
    }
}