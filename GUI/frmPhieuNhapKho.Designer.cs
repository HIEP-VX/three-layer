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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPhieuNhapKho = new System.Windows.Forms.Panel();
            this.dgvPhieuNhapKho = new System.Windows.Forms.DataGridView();
            this.panelPhieuNhapKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(744, 168);
            this.panel1.MinimumSize = new System.Drawing.Size(744, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 32);
            this.panel1.TabIndex = 0;
            // 
            // panelPhieuNhapKho
            // 
            this.panelPhieuNhapKho.Controls.Add(this.dgvPhieuNhapKho);
            this.panelPhieuNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhieuNhapKho.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPhieuNhapKho.Location = new System.Drawing.Point(0, 32);
            this.panelPhieuNhapKho.Name = "panelPhieuNhapKho";
            this.panelPhieuNhapKho.Size = new System.Drawing.Size(744, 406);
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
            this.dgvPhieuNhapKho.Size = new System.Drawing.Size(744, 406);
            this.dgvPhieuNhapKho.TabIndex = 0;
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
            this.panelPhieuNhapKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPhieuNhapKho;
        private System.Windows.Forms.DataGridView dgvPhieuNhapKho;
    }
}