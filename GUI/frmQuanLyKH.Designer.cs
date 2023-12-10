namespace GUI
{
    partial class frmQuanLyKH
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBodyQuanLyKH = new System.Windows.Forms.Panel();
            this.phườngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKháchHàngToolStripMenuItem,
            this.loạiKháchHàngToolStripMenuItem,
            this.phườngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            this.thôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.thôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng";
            this.thôngTinKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchHàngToolStripMenuItem_Click);
            // 
            // loạiKháchHàngToolStripMenuItem
            // 
            this.loạiKháchHàngToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loạiKháchHàngToolStripMenuItem.Name = "loạiKháchHàngToolStripMenuItem";
            this.loạiKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.loạiKháchHàngToolStripMenuItem.Text = "Loại khách hàng";
            this.loạiKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.loạiKháchHàngToolStripMenuItem_Click);
            // 
            // panelBodyQuanLyKH
            // 
            this.panelBodyQuanLyKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBodyQuanLyKH.Location = new System.Drawing.Point(0, 24);
            this.panelBodyQuanLyKH.Name = "panelBodyQuanLyKH";
            this.panelBodyQuanLyKH.Size = new System.Drawing.Size(800, 426);
            this.panelBodyQuanLyKH.TabIndex = 1;
            // 
            // phườngToolStripMenuItem
            // 
            this.phườngToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phườngToolStripMenuItem.Name = "phườngToolStripMenuItem";
            this.phườngToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.phườngToolStripMenuItem.Text = "Phường";
            this.phườngToolStripMenuItem.Click += new System.EventHandler(this.phườngToolStripMenuItem_Click);
            // 
            // frmQuanLyKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBodyQuanLyKH);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQuanLyKH";
            this.Text = "frmQuanLyKH";
            this.Load += new System.EventHandler(this.frmQuanLyKH_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiKháchHàngToolStripMenuItem;
        private System.Windows.Forms.Panel panelBodyQuanLyKH;
        private System.Windows.Forms.ToolStripMenuItem phườngToolStripMenuItem;
    }
}