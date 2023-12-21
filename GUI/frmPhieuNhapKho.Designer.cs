namespace GUI
{
    partial class frmPhieuNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhapKho));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.panelPhieuNhapKho = new System.Windows.Forms.Panel();
            this.dgvPhieuNhapKho = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelPhieuNhapKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(744, 168);
            this.panel1.MinimumSize = new System.Drawing.Size(744, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnRefesh
            // 
            this.btnRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefesh.FlatAppearance.BorderSize = 0;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefesh.Image")));
            this.btnRefesh.Location = new System.Drawing.Point(501, 9);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(34, 26);
            this.btnRefesh.TabIndex = 44;
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 24);
            this.comboBox1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nhân viên nhập kho";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(401, 8);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(84, 28);
            this.btnCapNhat.TabIndex = 41;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // panelPhieuNhapKho
            // 
            this.panelPhieuNhapKho.Controls.Add(this.dgvPhieuNhapKho);
            this.panelPhieuNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhieuNhapKho.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPhieuNhapKho.Location = new System.Drawing.Point(0, 46);
            this.panelPhieuNhapKho.Name = "panelPhieuNhapKho";
            this.panelPhieuNhapKho.Size = new System.Drawing.Size(744, 392);
            this.panelPhieuNhapKho.TabIndex = 1;
            // 
            // dgvPhieuNhapKho
            // 
            this.dgvPhieuNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhapKho.Location = new System.Drawing.Point(0, 0);
            this.dgvPhieuNhapKho.Name = "dgvPhieuNhapKho";
            this.dgvPhieuNhapKho.ReadOnly = true;
            this.dgvPhieuNhapKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhapKho.Size = new System.Drawing.Size(744, 392);
            this.dgvPhieuNhapKho.TabIndex = 0;
            this.dgvPhieuNhapKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhapKho_CellClick);
            // 
            // frmPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 438);
            this.Controls.Add(this.panelPhieuNhapKho);
            this.Controls.Add(this.panel1);
            this.Name = "frmPhieuNhapKho";
            this.Text = "frmPhieuNhapKho";
            this.Load += new System.EventHandler(this.frmPhieuNhapKho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPhieuNhapKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPhieuNhapKho;
        private System.Windows.Forms.DataGridView dgvPhieuNhapKho;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefesh;
    }
}