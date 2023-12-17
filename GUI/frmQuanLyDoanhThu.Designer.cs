namespace GUI
{
    partial class frmQuanLyDoanhThu
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
            this.hợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiềnNướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiềnMuaHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBody = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hợpĐồngToolStripMenuItem,
            this.tiềnNướcToolStripMenuItem,
            this.tiềnMuaHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hợpĐồngToolStripMenuItem
            // 
            this.hợpĐồngToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hợpĐồngToolStripMenuItem.Name = "hợpĐồngToolStripMenuItem";
            this.hợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hợpĐồngToolStripMenuItem.Text = "Hợp đồng";
            this.hợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.hợpĐồngToolStripMenuItem_Click);
            // 
            // tiềnNướcToolStripMenuItem
            // 
            this.tiềnNướcToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiềnNướcToolStripMenuItem.Name = "tiềnNướcToolStripMenuItem";
            this.tiềnNướcToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.tiềnNướcToolStripMenuItem.Text = "Tiền nước";
            this.tiềnNướcToolStripMenuItem.Click += new System.EventHandler(this.tiềnNướcToolStripMenuItem_Click);
            // 
            // tiềnMuaHàngToolStripMenuItem
            // 
            this.tiềnMuaHàngToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiềnMuaHàngToolStripMenuItem.Name = "tiềnMuaHàngToolStripMenuItem";
            this.tiềnMuaHàngToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.tiềnMuaHàngToolStripMenuItem.Text = "Tiền mua hàng";
            this.tiềnMuaHàngToolStripMenuItem.Click += new System.EventHandler(this.tiềnMuaHàngToolStripMenuItem_Click);
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 24);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(800, 426);
            this.panelBody.TabIndex = 1;
            // 
            // frmQuanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQuanLyDoanhThu";
            this.Text = "frmQuanLyDoanhThu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiềnNướcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiềnMuaHàngToolStripMenuItem;
        private System.Windows.Forms.Panel panelBody;
    }
}