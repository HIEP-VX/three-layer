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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDgvPhuong = new System.Windows.Forms.Panel();
            this.dgvPhuong = new System.Windows.Forms.DataGridView();
            this.panelDgvPhuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(879, 168);
            this.panel1.MinimumSize = new System.Drawing.Size(879, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 51);
            this.panel1.TabIndex = 0;
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
            this.panelDgvPhuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDgvPhuong;
        private System.Windows.Forms.DataGridView dgvPhuong;
    }
}