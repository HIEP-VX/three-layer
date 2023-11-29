namespace GUI
{
    partial class frmMuaHang
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
            this.phieuNhanHangToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtMuaHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoaDonNhanHangToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhapKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đồngHồToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiĐồngHồToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBodyMuaHang = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phieuNhanHangToolStrip,
            this.chiTiếtMuaHàngToolStripMenuItem,
            this.hoaDonNhanHangToolStrip,
            this.phiếuNhapKhoToolStripMenuItem,
            this.đồngHồToolStripMenuItem,
            this.loạiĐồngHồToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phieuNhanHangToolStrip
            // 
            this.phieuNhanHangToolStrip.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phieuNhanHangToolStrip.Name = "phieuNhanHangToolStrip";
            this.phieuNhanHangToolStrip.Size = new System.Drawing.Size(113, 20);
            this.phieuNhanHangToolStrip.Text = "Phiếu nhận hàng";
            this.phieuNhanHangToolStrip.Click += new System.EventHandler(this.phieuNhanHangToolStrip_Click);
            // 
            // chiTiếtMuaHàngToolStripMenuItem
            // 
            this.chiTiếtMuaHàngToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiTiếtMuaHàngToolStripMenuItem.Name = "chiTiếtMuaHàngToolStripMenuItem";
            this.chiTiếtMuaHàngToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.chiTiếtMuaHàngToolStripMenuItem.Text = "Chi tiết mua hàng";
            this.chiTiếtMuaHàngToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtMuaHàngToolStripMenuItem_Click);
            // 
            // hoaDonNhanHangToolStrip
            // 
            this.hoaDonNhanHangToolStrip.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoaDonNhanHangToolStrip.Name = "hoaDonNhanHangToolStrip";
            this.hoaDonNhanHangToolStrip.Size = new System.Drawing.Size(128, 20);
            this.hoaDonNhanHangToolStrip.Text = "Hóa đơn nhận hàng";
            this.hoaDonNhanHangToolStrip.Click += new System.EventHandler(this.hoaDonNhanHangToolStrip_Click);
            // 
            // phiếuNhapKhoToolStripMenuItem
            // 
            this.phiếuNhapKhoToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phiếuNhapKhoToolStripMenuItem.Name = "phiếuNhapKhoToolStripMenuItem";
            this.phiếuNhapKhoToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.phiếuNhapKhoToolStripMenuItem.Text = "Phiếu nhập kho";
            this.phiếuNhapKhoToolStripMenuItem.Click += new System.EventHandler(this.phiếuNhapKhoToolStripMenuItem_Click);
            // 
            // đồngHồToolStripMenuItem
            // 
            this.đồngHồToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đồngHồToolStripMenuItem.Name = "đồngHồToolStripMenuItem";
            this.đồngHồToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.đồngHồToolStripMenuItem.Text = "Đồng hồ";
            this.đồngHồToolStripMenuItem.Click += new System.EventHandler(this.đồngHồToolStripMenuItem_Click);
            // 
            // loạiĐồngHồToolStripMenuItem
            // 
            this.loạiĐồngHồToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loạiĐồngHồToolStripMenuItem.Name = "loạiĐồngHồToolStripMenuItem";
            this.loạiĐồngHồToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.loạiĐồngHồToolStripMenuItem.Text = "Loại đồng hồ";
            this.loạiĐồngHồToolStripMenuItem.Click += new System.EventHandler(this.loạiĐồngHồToolStripMenuItem_Click);
            // 
            // panelBodyMuaHang
            // 
            this.panelBodyMuaHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBodyMuaHang.Location = new System.Drawing.Point(0, 24);
            this.panelBodyMuaHang.Name = "panelBodyMuaHang";
            this.panelBodyMuaHang.Size = new System.Drawing.Size(818, 426);
            this.panelBodyMuaHang.TabIndex = 1;
            // 
            // frmMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.panelBodyMuaHang);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMuaHang";
            this.Text = "frmMuaHang";
            this.Load += new System.EventHandler(this.frmMuaHang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtMuaHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhapKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đồngHồToolStripMenuItem;
        private System.Windows.Forms.Panel panelBodyMuaHang;
        private System.Windows.Forms.ToolStripMenuItem loạiĐồngHồToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phieuNhanHangToolStrip;
        private System.Windows.Forms.ToolStripMenuItem hoaDonNhanHangToolStrip;
    }
}