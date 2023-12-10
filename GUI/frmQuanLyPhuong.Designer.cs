namespace GUI
{
    partial class frmQuanLyPhuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyPhuong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaNV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenPhuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.panelDgvPhuong = new System.Windows.Forms.Panel();
            this.dgvPhuong = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelDgvPhuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTenPhuong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(879, 168);
            this.panel1.MinimumSize = new System.Drawing.Size(879, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 51);
            this.panel1.TabIndex = 0;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.FormattingEnabled = true;
            this.txtMaNV.Location = new System.Drawing.Point(350, 12);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(229, 24);
            this.txtMaNV.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 69;
            this.label7.Text = "Mã nhân viên ghi nước";
            // 
            // txtTenPhuong
            // 
            this.txtTenPhuong.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhuong.Location = new System.Drawing.Point(72, 12);
            this.txtTenPhuong.Name = "txtTenPhuong";
            this.txtTenPhuong.Size = new System.Drawing.Size(124, 23);
            this.txtTenPhuong.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Phường";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(610, 9);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(84, 28);
            this.btnCapNhat.TabIndex = 40;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // panelDgvPhuong
            // 
            this.panelDgvPhuong.Controls.Add(this.dgvPhuong);
            this.panelDgvPhuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDgvPhuong.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDgvPhuong.Location = new System.Drawing.Point(0, 51);
            this.panelDgvPhuong.Name = "panelDgvPhuong";
            this.panelDgvPhuong.Size = new System.Drawing.Size(879, 373);
            this.panelDgvPhuong.TabIndex = 1;
            // 
            // dgvPhuong
            // 
            this.dgvPhuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhuong.Location = new System.Drawing.Point(0, 0);
            this.dgvPhuong.Name = "dgvPhuong";
            this.dgvPhuong.ReadOnly = true;
            this.dgvPhuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhuong.Size = new System.Drawing.Size(879, 373);
            this.dgvPhuong.TabIndex = 0;
            this.dgvPhuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuong_CellClick);
            // 
            // frmQuanLyPhuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 424);
            this.Controls.Add(this.panelDgvPhuong);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyPhuong";
            this.Text = "frmQuanLyPhuong";
            this.Load += new System.EventHandler(this.frmQuanLyPhuong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDgvPhuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDgvPhuong;
        private System.Windows.Forms.DataGridView dgvPhuong;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenPhuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtMaNV;
    }
}