namespace GUI
{
    partial class frmXuPhat
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
            this.quanLyCungCapNuocSachDataSet8 = new GUI.QuanLyCungCapNuocSachDataSet8();
            this.xuPhatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xuPhatTableAdapter = new GUI.QuanLyCungCapNuocSachDataSet8TableAdapters.XuPhatTableAdapter();
            this.maXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienPhatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoCuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuPhatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maXPDataGridViewTextBoxColumn,
            this.thoiGianDataGridViewTextBoxColumn,
            this.maTTDataGridViewTextBoxColumn,
            this.tienPhatDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn,
            this.chiSoCuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.xuPhatBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 421);
            this.dataGridView1.TabIndex = 5;
            // 
            // quanLyCungCapNuocSachDataSet8
            // 
            this.quanLyCungCapNuocSachDataSet8.DataSetName = "QuanLyCungCapNuocSachDataSet8";
            this.quanLyCungCapNuocSachDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xuPhatBindingSource
            // 
            this.xuPhatBindingSource.DataMember = "XuPhat";
            this.xuPhatBindingSource.DataSource = this.quanLyCungCapNuocSachDataSet8;
            // 
            // xuPhatTableAdapter
            // 
            this.xuPhatTableAdapter.ClearBeforeFill = true;
            // 
            // maXPDataGridViewTextBoxColumn
            // 
            this.maXPDataGridViewTextBoxColumn.DataPropertyName = "maXP";
            this.maXPDataGridViewTextBoxColumn.HeaderText = "maXP";
            this.maXPDataGridViewTextBoxColumn.Name = "maXPDataGridViewTextBoxColumn";
            this.maXPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thoiGianDataGridViewTextBoxColumn
            // 
            this.thoiGianDataGridViewTextBoxColumn.DataPropertyName = "thoiGian";
            this.thoiGianDataGridViewTextBoxColumn.HeaderText = "thoiGian";
            this.thoiGianDataGridViewTextBoxColumn.Name = "thoiGianDataGridViewTextBoxColumn";
            // 
            // maTTDataGridViewTextBoxColumn
            // 
            this.maTTDataGridViewTextBoxColumn.DataPropertyName = "maTT";
            this.maTTDataGridViewTextBoxColumn.HeaderText = "maTT";
            this.maTTDataGridViewTextBoxColumn.Name = "maTTDataGridViewTextBoxColumn";
            // 
            // tienPhatDataGridViewTextBoxColumn
            // 
            this.tienPhatDataGridViewTextBoxColumn.DataPropertyName = "TienPhat";
            this.tienPhatDataGridViewTextBoxColumn.HeaderText = "TienPhat";
            this.tienPhatDataGridViewTextBoxColumn.Name = "tienPhatDataGridViewTextBoxColumn";
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "trangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "trangThai";
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            // 
            // chiSoCuDataGridViewTextBoxColumn
            // 
            this.chiSoCuDataGridViewTextBoxColumn.DataPropertyName = "chiSoCu";
            this.chiSoCuDataGridViewTextBoxColumn.HeaderText = "chiSoCu";
            this.chiSoCuDataGridViewTextBoxColumn.Name = "chiSoCuDataGridViewTextBoxColumn";
            // 
            // frmXuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmXuPhat";
            this.Text = "frmXuPhat";
            this.Load += new System.EventHandler(this.frmXuPhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuPhatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyCungCapNuocSachDataSet8 quanLyCungCapNuocSachDataSet8;
        private System.Windows.Forms.BindingSource xuPhatBindingSource;
        private QuanLyCungCapNuocSachDataSet8TableAdapters.XuPhatTableAdapter xuPhatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maXPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienPhatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoCuDataGridViewTextBoxColumn;
    }
}