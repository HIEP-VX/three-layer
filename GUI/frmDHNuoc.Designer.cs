namespace GUI
{
    partial class frmDHNuoc
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
            this.quanLyCungCapNuocSachDataSet5 = new GUI.QuanLyCungCapNuocSachDataSet5();
            this.dongHoNuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dongHoNuocTableAdapter = new GUI.QuanLyCungCapNuocSachDataSet5TableAdapters.DongHoNuocTableAdapter();
            this.maDHNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangDHNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCongToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongHoNuocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDHNDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.hangDHNDataGridViewTextBoxColumn,
            this.chiSoDauDataGridViewTextBoxColumn,
            this.soCongToDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dongHoNuocBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 421);
            this.dataGridView1.TabIndex = 2;
            // 
            // quanLyCungCapNuocSachDataSet5
            // 
            this.quanLyCungCapNuocSachDataSet5.DataSetName = "QuanLyCungCapNuocSachDataSet5";
            this.quanLyCungCapNuocSachDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dongHoNuocBindingSource
            // 
            this.dongHoNuocBindingSource.DataMember = "DongHoNuoc";
            this.dongHoNuocBindingSource.DataSource = this.quanLyCungCapNuocSachDataSet5;
            // 
            // dongHoNuocTableAdapter
            // 
            this.dongHoNuocTableAdapter.ClearBeforeFill = true;
            // 
            // maDHNDataGridViewTextBoxColumn
            // 
            this.maDHNDataGridViewTextBoxColumn.DataPropertyName = "maDHN";
            this.maDHNDataGridViewTextBoxColumn.HeaderText = "maDHN";
            this.maDHNDataGridViewTextBoxColumn.Name = "maDHNDataGridViewTextBoxColumn";
            this.maDHNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "maKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "maKH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // hangDHNDataGridViewTextBoxColumn
            // 
            this.hangDHNDataGridViewTextBoxColumn.DataPropertyName = "hangDHN";
            this.hangDHNDataGridViewTextBoxColumn.HeaderText = "hangDHN";
            this.hangDHNDataGridViewTextBoxColumn.Name = "hangDHNDataGridViewTextBoxColumn";
            // 
            // chiSoDauDataGridViewTextBoxColumn
            // 
            this.chiSoDauDataGridViewTextBoxColumn.DataPropertyName = "chiSoDau";
            this.chiSoDauDataGridViewTextBoxColumn.HeaderText = "chiSoDau";
            this.chiSoDauDataGridViewTextBoxColumn.Name = "chiSoDauDataGridViewTextBoxColumn";
            // 
            // soCongToDataGridViewTextBoxColumn
            // 
            this.soCongToDataGridViewTextBoxColumn.DataPropertyName = "soCongTo";
            this.soCongToDataGridViewTextBoxColumn.HeaderText = "soCongTo";
            this.soCongToDataGridViewTextBoxColumn.Name = "soCongToDataGridViewTextBoxColumn";
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "tinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "tinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            // 
            // frmDHNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmDHNuoc";
            this.Text = "frmDHNuoc";
            this.Load += new System.EventHandler(this.frmDHNuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongHoNuocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyCungCapNuocSachDataSet5 quanLyCungCapNuocSachDataSet5;
        private System.Windows.Forms.BindingSource dongHoNuocBindingSource;
        private QuanLyCungCapNuocSachDataSet5TableAdapters.DongHoNuocTableAdapter dongHoNuocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDHNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangDHNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCongToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
    }
}