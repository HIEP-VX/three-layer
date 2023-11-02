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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quanLyCungCapNuocSachDataSet6 = new GUI.QuanLyCungCapNuocSachDataSet6();
            this.tieuThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tieuThuTableAdapter = new GUI.QuanLyCungCapNuocSachDataSet6TableAdapters.TieuThuTableAdapter();
            this.maTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDHNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoMoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thueGTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thueBVMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongNuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienNuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tieuThuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTTDataGridViewTextBoxColumn,
            this.maDHNDataGridViewTextBoxColumn,
            this.thoiGianDataGridViewTextBoxColumn,
            this.chiSoMoiDataGridViewTextBoxColumn,
            this.thueGTDataGridViewTextBoxColumn,
            this.thueBVMTDataGridViewTextBoxColumn,
            this.luongNuocDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn,
            this.tienNuocDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tieuThuBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 421);
            this.dataGridView1.TabIndex = 3;
            // 
            // quanLyCungCapNuocSachDataSet6
            // 
            this.quanLyCungCapNuocSachDataSet6.DataSetName = "QuanLyCungCapNuocSachDataSet6";
            this.quanLyCungCapNuocSachDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tieuThuBindingSource
            // 
            this.tieuThuBindingSource.DataMember = "TieuThu";
            this.tieuThuBindingSource.DataSource = this.quanLyCungCapNuocSachDataSet6;
            // 
            // tieuThuTableAdapter
            // 
            this.tieuThuTableAdapter.ClearBeforeFill = true;
            // 
            // maTTDataGridViewTextBoxColumn
            // 
            this.maTTDataGridViewTextBoxColumn.DataPropertyName = "maTT";
            this.maTTDataGridViewTextBoxColumn.HeaderText = "maTT";
            this.maTTDataGridViewTextBoxColumn.Name = "maTTDataGridViewTextBoxColumn";
            this.maTTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maDHNDataGridViewTextBoxColumn
            // 
            this.maDHNDataGridViewTextBoxColumn.DataPropertyName = "maDHN";
            this.maDHNDataGridViewTextBoxColumn.HeaderText = "maDHN";
            this.maDHNDataGridViewTextBoxColumn.Name = "maDHNDataGridViewTextBoxColumn";
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
            // luongNuocDataGridViewTextBoxColumn
            // 
            this.luongNuocDataGridViewTextBoxColumn.DataPropertyName = "luongNuoc";
            this.luongNuocDataGridViewTextBoxColumn.HeaderText = "luongNuoc";
            this.luongNuocDataGridViewTextBoxColumn.Name = "luongNuocDataGridViewTextBoxColumn";
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "tinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "tinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            // 
            // tienNuocDataGridViewTextBoxColumn
            // 
            this.tienNuocDataGridViewTextBoxColumn.DataPropertyName = "tienNuoc";
            this.tienNuocDataGridViewTextBoxColumn.HeaderText = "tienNuoc";
            this.tienNuocDataGridViewTextBoxColumn.Name = "tienNuocDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "tongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "tongTien";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // frmTieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmTieuThu";
            this.Text = "frmTieuThu";
            this.Load += new System.EventHandler(this.frmTieuThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tieuThuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyCungCapNuocSachDataSet6 quanLyCungCapNuocSachDataSet6;
        private System.Windows.Forms.BindingSource tieuThuBindingSource;
        private QuanLyCungCapNuocSachDataSet6TableAdapters.TieuThuTableAdapter tieuThuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDHNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoMoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thueGTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thueBVMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongNuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienNuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
    }
}