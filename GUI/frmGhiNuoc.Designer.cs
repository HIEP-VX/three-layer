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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnThemExcel = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.panelGhiNuoc = new System.Windows.Forms.Panel();
            this.dgvGhiNuoc = new System.Windows.Forms.DataGridView();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.quanLyCungCapNuocSachDataSet10 = new GUI.QuanLyCungCapNuocSachDataSet10();
            this.tieuThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tieuThuTableAdapter = new GUI.QuanLyCungCapNuocSachDataSet10TableAdapters.TieuThuTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.quanLyCungCapNuocSachDataSet12 = new GUI.QuanLyCungCapNuocSachDataSet12();
            this.diaChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diaChiTableAdapter = new GUI.QuanLyCungCapNuocSachDataSet12TableAdapters.diaChiTableAdapter();
            this.panel1.SuspendLayout();
            this.panelGhiNuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tieuThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
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
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(446, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnThemExcel
            // 
            this.btnThemExcel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemExcel.Location = new System.Drawing.Point(360, 1);
            this.btnThemExcel.Name = "btnThemExcel";
            this.btnThemExcel.Size = new System.Drawing.Size(75, 28);
            this.btnThemExcel.TabIndex = 44;
            this.btnThemExcel.Text = "import";
            this.btnThemExcel.UseVisualStyleBackColor = true;
            this.btnThemExcel.Click += new System.EventHandler(this.btnThemExcel_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(264, 0);
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
            this.dgvGhiNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGhiNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGhiNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGhiNuoc.Location = new System.Drawing.Point(0, 0);
            this.dgvGhiNuoc.Name = "dgvGhiNuoc";
            this.dgvGhiNuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGhiNuoc.Size = new System.Drawing.Size(800, 421);
            this.dgvGhiNuoc.TabIndex = 0;
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // quanLyCungCapNuocSachDataSet10
            // 
            this.quanLyCungCapNuocSachDataSet10.DataSetName = "QuanLyCungCapNuocSachDataSet10";
            this.quanLyCungCapNuocSachDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tieuThuBindingSource
            // 
            this.tieuThuBindingSource.DataMember = "TieuThu";
            this.tieuThuBindingSource.DataSource = this.quanLyCungCapNuocSachDataSet10;
            // 
            // tieuThuTableAdapter
            // 
            this.tieuThuTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.diaChiBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.ValueMember = "phuong";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // quanLyCungCapNuocSachDataSet12
            // 
            this.quanLyCungCapNuocSachDataSet12.DataSetName = "QuanLyCungCapNuocSachDataSet12";
            this.quanLyCungCapNuocSachDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diaChiBindingSource
            // 
            this.diaChiBindingSource.DataMember = "diaChi";
            this.diaChiBindingSource.DataSource = this.quanLyCungCapNuocSachDataSet12;
            // 
            // diaChiTableAdapter
            // 
            this.diaChiTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tieuThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelGhiNuoc;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnThemExcel;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvGhiNuoc;
        private QuanLyCungCapNuocSachDataSet10 quanLyCungCapNuocSachDataSet10;
        private System.Windows.Forms.BindingSource tieuThuBindingSource;
        private QuanLyCungCapNuocSachDataSet10TableAdapters.TieuThuTableAdapter tieuThuTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private QuanLyCungCapNuocSachDataSet12 quanLyCungCapNuocSachDataSet12;
        private System.Windows.Forms.BindingSource diaChiBindingSource;
        private QuanLyCungCapNuocSachDataSet12TableAdapters.diaChiTableAdapter diaChiTableAdapter;
    }
}