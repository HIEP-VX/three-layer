namespace GUI
{
    partial class frmGhiNuoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.panelGhiNuoc = new System.Windows.Forms.Panel();
            this.dgvGhiNuoc = new System.Windows.Forms.DataGridView();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoMoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongNuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tieuThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCungCapNuocSachDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCungCapNuocSachDataSet = new GUI.QuanLyCungCapNuocSachDataSet();
            this.tieuThuTableAdapter = new GUI.QuanLyCungCapNuocSachDataSetTableAdapters.TieuThuTableAdapter();
            this.btnThemExcel = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelGhiNuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tieuThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnThemExcel);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(800, 168);
            this.panel1.MinimumSize = new System.Drawing.Size(800, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(363, 0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 28);
            this.btnImport.TabIndex = 43;
            this.btnImport.Text = "Thêm file";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panelGhiNuoc
            // 
            this.panelGhiNuoc.Controls.Add(this.dgvGhiNuoc);
            this.panelGhiNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGhiNuoc.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelGhiNuoc.Location = new System.Drawing.Point(0, 29);
            this.panelGhiNuoc.Name = "panelGhiNuoc";
            this.panelGhiNuoc.Size = new System.Drawing.Size(800, 421);
            this.panelGhiNuoc.TabIndex = 2;
            // 
            // dgvGhiNuoc
            // 
            this.dgvGhiNuoc.AutoGenerateColumns = false;
            this.dgvGhiNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGhiNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGhiNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKHDataGridViewTextBoxColumn,
            this.thoiGianDataGridViewTextBoxColumn,
            this.chiSoMoiDataGridViewTextBoxColumn,
            this.luongNuocDataGridViewTextBoxColumn,
            this.tenKH,
            this.phuong,
            this.diaChi});
            this.dgvGhiNuoc.DataSource = this.tieuThuBindingSource;
            this.dgvGhiNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGhiNuoc.Location = new System.Drawing.Point(0, 0);
            this.dgvGhiNuoc.Name = "dgvGhiNuoc";
            this.dgvGhiNuoc.ReadOnly = true;
            this.dgvGhiNuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGhiNuoc.Size = new System.Drawing.Size(800, 421);
            this.dgvGhiNuoc.TabIndex = 0;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "maKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "maKH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            this.maKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thoiGianDataGridViewTextBoxColumn
            // 
            this.thoiGianDataGridViewTextBoxColumn.DataPropertyName = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.HeaderText = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.Name = "thoiGianDataGridViewTextBoxColumn";
            this.thoiGianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chiSoMoiDataGridViewTextBoxColumn
            // 
            this.chiSoMoiDataGridViewTextBoxColumn.DataPropertyName = "chiSoMoi";
            this.chiSoMoiDataGridViewTextBoxColumn.HeaderText = "chiSoMoi";
            this.chiSoMoiDataGridViewTextBoxColumn.Name = "chiSoMoiDataGridViewTextBoxColumn";
            this.chiSoMoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // luongNuocDataGridViewTextBoxColumn
            // 
            this.luongNuocDataGridViewTextBoxColumn.DataPropertyName = "luongNuoc";
            this.luongNuocDataGridViewTextBoxColumn.HeaderText = "luongNuoc";
            this.luongNuocDataGridViewTextBoxColumn.Name = "luongNuocDataGridViewTextBoxColumn";
            this.luongNuocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKH
            // 
            this.tenKH.HeaderText = "tenKH";
            this.tenKH.Name = "tenKH";
            this.tenKH.ReadOnly = true;
            // 
            // phuong
            // 
            this.phuong.HeaderText = "Phường";
            this.phuong.Name = "phuong";
            this.phuong.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // tieuThuBindingSource
            // 
            this.tieuThuBindingSource.DataMember = "TieuThu";
            this.tieuThuBindingSource.DataSource = this.quanLyCungCapNuocSachDataSetBindingSource;
            // 
            // quanLyCungCapNuocSachDataSetBindingSource
            // 
            this.quanLyCungCapNuocSachDataSetBindingSource.DataSource = this.quanLyCungCapNuocSachDataSet;
            this.quanLyCungCapNuocSachDataSetBindingSource.Position = 0;
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
            // btnThemExcel
            // 
            this.btnThemExcel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemExcel.Location = new System.Drawing.Point(464, 1);
            this.btnThemExcel.Name = "btnThemExcel";
            this.btnThemExcel.Size = new System.Drawing.Size(75, 28);
            this.btnThemExcel.TabIndex = 44;
            this.btnThemExcel.Text = "import";
            this.btnThemExcel.UseVisualStyleBackColor = true;
            this.btnThemExcel.Click += new System.EventHandler(this.btnThemExcel_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(545, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmGhiNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGhiNuoc);
            this.Controls.Add(this.panel1);
            this.Name = "frmGhiNuoc";
            this.Text = "frmGhiNuoc";
            this.Load += new System.EventHandler(this.frmGhiNuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panelGhiNuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tieuThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelGhiNuoc;
        private System.Windows.Forms.DataGridView dgvGhiNuoc;
        private System.Windows.Forms.BindingSource quanLyCungCapNuocSachDataSetBindingSource;
        private QuanLyCungCapNuocSachDataSet quanLyCungCapNuocSachDataSet;
        private System.Windows.Forms.BindingSource tieuThuBindingSource;
        private QuanLyCungCapNuocSachDataSetTableAdapters.TieuThuTableAdapter tieuThuTableAdapter;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoMoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongNuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.Button btnThemExcel;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button btnSave;
    }
}