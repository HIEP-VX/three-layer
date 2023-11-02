namespace GUI
{
    partial class frmHoaDon
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
            this.quanLyCungCapNuocSachDataSet7 = new GUI.QuanLyCungCapNuocSachDataSet7();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new GUI.QuanLyCungCapNuocSachDataSet7TableAdapters.HoaDonTableAdapter();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoCuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.maTTDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.chiSoCuDataGridViewTextBoxColumn,
            this.thoiGianDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hoaDonBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 421);
            this.dataGridView1.TabIndex = 4;
            // 
            // quanLyCungCapNuocSachDataSet7
            // 
            this.quanLyCungCapNuocSachDataSet7.DataSetName = "QuanLyCungCapNuocSachDataSet7";
            this.quanLyCungCapNuocSachDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.quanLyCungCapNuocSachDataSet7;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "maHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "maHD";
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maTTDataGridViewTextBoxColumn
            // 
            this.maTTDataGridViewTextBoxColumn.DataPropertyName = "maTT";
            this.maTTDataGridViewTextBoxColumn.HeaderText = "maTT";
            this.maTTDataGridViewTextBoxColumn.Name = "maTTDataGridViewTextBoxColumn";
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "maNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "maNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // chiSoCuDataGridViewTextBoxColumn
            // 
            this.chiSoCuDataGridViewTextBoxColumn.DataPropertyName = "chiSoCu";
            this.chiSoCuDataGridViewTextBoxColumn.HeaderText = "chiSoCu";
            this.chiSoCuDataGridViewTextBoxColumn.Name = "chiSoCuDataGridViewTextBoxColumn";
            // 
            // thoiGianDataGridViewTextBoxColumn
            // 
            this.thoiGianDataGridViewTextBoxColumn.DataPropertyName = "thoiGian";
            this.thoiGianDataGridViewTextBoxColumn.HeaderText = "thoiGian";
            this.thoiGianDataGridViewTextBoxColumn.Name = "thoiGianDataGridViewTextBoxColumn";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyCungCapNuocSachDataSet7 quanLyCungCapNuocSachDataSet7;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QuanLyCungCapNuocSachDataSet7TableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoCuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
    }
}