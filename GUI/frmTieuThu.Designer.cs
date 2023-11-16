namespace GUI
{
    partial class frmTieuThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTieuThu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.tieuThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCungCapNuocSachDataSet = new GUI.QuanLyCungCapNuocSachDataSet();
            this.tieuThuTableAdapter = new GUI.QuanLyCungCapNuocSachDataSetTableAdapters.TieuThuTableAdapter();
            this.dgvTieuThu = new System.Windows.Forms.DataGridView();
            this.maTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoMoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongNuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienNuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thueGTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thueBVMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDataTieuThu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tieuThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieuThu)).BeginInit();
            this.panelDataTieuThu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbThang);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 2;
            // 
            // cbThang
            // 
            this.cbThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(719, 5);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(69, 21);
            this.cbThang.TabIndex = 43;
            this.cbThang.Text = "Tháng";
            this.cbThang.SelectedIndexChanged += new System.EventHandler(this.cbThang_SelectedIndexChanged);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(329, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 28);
            this.btnExport.TabIndex = 42;
            this.btnExport.Text = "Xuất file";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(226, 1);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 28);
            this.btnTimKiem.TabIndex = 41;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(114, 1);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(84, 28);
            this.btnCapNhat.TabIndex = 40;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // tieuThuBindingSource
            // 
            this.tieuThuBindingSource.DataMember = "TieuThu";
            this.tieuThuBindingSource.DataSource = this.quanLyCungCapNuocSachDataSet;
            // 
            // quanLyCungCapNuocSachDataSet
            // 
            this.quanLyCungCapNuocSachDataSet.DataSetName = "QuanLyCungCapNuocSachDataSet";
            this.quanLyCungCapNuocSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tieuThuTableAdapter
            // 
            this.tieuThuTableAdapter.ClearBeforeFill = true;
            // 
            // dgvTieuThu
            // 
            this.dgvTieuThu.AutoGenerateColumns = false;
            this.dgvTieuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTieuThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTTDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.thoiGianDataGridViewTextBoxColumn,
            this.chiSoMoiDataGridViewTextBoxColumn,
            this.luongNuocDataGridViewTextBoxColumn,
            this.tienNuocDataGridViewTextBoxColumn,
            this.thueGTDataGridViewTextBoxColumn,
            this.thueBVMTDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn});
            this.dgvTieuThu.DataSource = this.tieuThuBindingSource;
            this.dgvTieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTieuThu.Location = new System.Drawing.Point(0, 0);
            this.dgvTieuThu.Name = "dgvTieuThu";
            this.dgvTieuThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTieuThu.Size = new System.Drawing.Size(800, 421);
            this.dgvTieuThu.TabIndex = 3;
            // 
            // maTTDataGridViewTextBoxColumn
            // 
            this.maTTDataGridViewTextBoxColumn.DataPropertyName = "maTT";
            this.maTTDataGridViewTextBoxColumn.HeaderText = "maTT";
            this.maTTDataGridViewTextBoxColumn.Name = "maTTDataGridViewTextBoxColumn";
            this.maTTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "maKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "maKH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // thoiGianDataGridViewTextBoxColumn
            // 
            this.thoiGianDataGridViewTextBoxColumn.DataPropertyName = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.HeaderText = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.Name = "thoiGianDataGridViewTextBoxColumn";
            // 
            // chiSoMoiDataGridViewTextBoxColumn
            // 
            this.chiSoMoiDataGridViewTextBoxColumn.DataPropertyName = "chiSoMoi";
            this.chiSoMoiDataGridViewTextBoxColumn.HeaderText = "chiSoMoi";
            this.chiSoMoiDataGridViewTextBoxColumn.Name = "chiSoMoiDataGridViewTextBoxColumn";
            // 
            // luongNuocDataGridViewTextBoxColumn
            // 
            this.luongNuocDataGridViewTextBoxColumn.DataPropertyName = "luongNuoc";
            this.luongNuocDataGridViewTextBoxColumn.HeaderText = "luongNuoc";
            this.luongNuocDataGridViewTextBoxColumn.Name = "luongNuocDataGridViewTextBoxColumn";
            // 
            // tienNuocDataGridViewTextBoxColumn
            // 
            this.tienNuocDataGridViewTextBoxColumn.DataPropertyName = "tienNuoc";
            this.tienNuocDataGridViewTextBoxColumn.HeaderText = "tienNuoc";
            this.tienNuocDataGridViewTextBoxColumn.Name = "tienNuocDataGridViewTextBoxColumn";
            // 
            // thueGTDataGridViewTextBoxColumn
            // 
            this.thueGTDataGridViewTextBoxColumn.DataPropertyName = "thueGT";
            this.thueGTDataGridViewTextBoxColumn.HeaderText = "thueGT";
            this.thueGTDataGridViewTextBoxColumn.Name = "thueGTDataGridViewTextBoxColumn";
            // 
            // thueBVMTDataGridViewTextBoxColumn
            // 
            this.thueBVMTDataGridViewTextBoxColumn.DataPropertyName = "thueBVMT";
            this.thueBVMTDataGridViewTextBoxColumn.HeaderText = "thueBVMT";
            this.thueBVMTDataGridViewTextBoxColumn.Name = "thueBVMTDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "tongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "tongTien";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "tinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "tinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            // 
            // panelDataTieuThu
            // 
            this.panelDataTieuThu.Controls.Add(this.dgvTieuThu);
            this.panelDataTieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataTieuThu.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDataTieuThu.Location = new System.Drawing.Point(0, 29);
            this.panelDataTieuThu.Name = "panelDataTieuThu";
            this.panelDataTieuThu.Size = new System.Drawing.Size(800, 421);
            this.panelDataTieuThu.TabIndex = 4;
            // 
            // frmTieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDataTieuThu);
            this.Controls.Add(this.panel1);
            this.Name = "frmTieuThu";
            this.Text = "frmTieuThu";
            this.Load += new System.EventHandler(this.frmTieuThu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tieuThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieuThu)).EndInit();
            this.panelDataTieuThu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Button btnExport;
        private QuanLyCungCapNuocSachDataSet quanLyCungCapNuocSachDataSet;
        private System.Windows.Forms.BindingSource tieuThuBindingSource;
        private QuanLyCungCapNuocSachDataSetTableAdapters.TieuThuTableAdapter tieuThuTableAdapter;
        private System.Windows.Forms.DataGridView dgvTieuThu;
        private System.Windows.Forms.Panel panelDataTieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoMoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongNuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienNuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thueGTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thueBVMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
    }
}