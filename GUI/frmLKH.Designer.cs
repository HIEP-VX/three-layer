namespace GUI
{
    partial class frmLKH
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quanLyCungCapNuocSachDataSet3 = new GUI.QuanLyCungCapNuocSachDataSet3();
            this.loaiKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiKhachHangTableAdapter = new GUI.QuanLyCungCapNuocSachDataSet3TableAdapters.loaiKhachHangTableAdapter();
            this.maLKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBac1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBac2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBac3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBac4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiKhachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(800, 168);
            this.panel1.MinimumSize = new System.Drawing.Size(800, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(247, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(167, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(86, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLKHDataGridViewTextBoxColumn,
            this.tenLoaiDataGridViewTextBoxColumn,
            this.giaBac1DataGridViewTextBoxColumn,
            this.giaBac2DataGridViewTextBoxColumn,
            this.giaBac3DataGridViewTextBoxColumn,
            this.giaBac4DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loaiKhachHangBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 421);
            this.dataGridView1.TabIndex = 1;
            // 
            // quanLyCungCapNuocSachDataSet3
            // 
            this.quanLyCungCapNuocSachDataSet3.DataSetName = "QuanLyCungCapNuocSachDataSet3";
            this.quanLyCungCapNuocSachDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiKhachHangBindingSource
            // 
            this.loaiKhachHangBindingSource.DataMember = "loaiKhachHang";
            this.loaiKhachHangBindingSource.DataSource = this.quanLyCungCapNuocSachDataSet3;
            // 
            // loaiKhachHangTableAdapter
            // 
            this.loaiKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // maLKHDataGridViewTextBoxColumn
            // 
            this.maLKHDataGridViewTextBoxColumn.DataPropertyName = "maLKH";
            this.maLKHDataGridViewTextBoxColumn.HeaderText = "maLKH";
            this.maLKHDataGridViewTextBoxColumn.Name = "maLKHDataGridViewTextBoxColumn";
            this.maLKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLoaiDataGridViewTextBoxColumn
            // 
            this.tenLoaiDataGridViewTextBoxColumn.DataPropertyName = "tenLoai";
            this.tenLoaiDataGridViewTextBoxColumn.HeaderText = "tenLoai";
            this.tenLoaiDataGridViewTextBoxColumn.Name = "tenLoaiDataGridViewTextBoxColumn";
            // 
            // giaBac1DataGridViewTextBoxColumn
            // 
            this.giaBac1DataGridViewTextBoxColumn.DataPropertyName = "giaBac1";
            this.giaBac1DataGridViewTextBoxColumn.HeaderText = "giaBac1";
            this.giaBac1DataGridViewTextBoxColumn.Name = "giaBac1DataGridViewTextBoxColumn";
            // 
            // giaBac2DataGridViewTextBoxColumn
            // 
            this.giaBac2DataGridViewTextBoxColumn.DataPropertyName = "giaBac2";
            this.giaBac2DataGridViewTextBoxColumn.HeaderText = "giaBac2";
            this.giaBac2DataGridViewTextBoxColumn.Name = "giaBac2DataGridViewTextBoxColumn";
            // 
            // giaBac3DataGridViewTextBoxColumn
            // 
            this.giaBac3DataGridViewTextBoxColumn.DataPropertyName = "giaBac3";
            this.giaBac3DataGridViewTextBoxColumn.HeaderText = "giaBac3";
            this.giaBac3DataGridViewTextBoxColumn.Name = "giaBac3DataGridViewTextBoxColumn";
            // 
            // giaBac4DataGridViewTextBoxColumn
            // 
            this.giaBac4DataGridViewTextBoxColumn.DataPropertyName = "giaBac4";
            this.giaBac4DataGridViewTextBoxColumn.HeaderText = "giaBac4";
            this.giaBac4DataGridViewTextBoxColumn.Name = "giaBac4DataGridViewTextBoxColumn";
            // 
            // frmLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmLKH";
            this.Text = "frmLKH";
            this.Load += new System.EventHandler(this.frmLKH_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiKhachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyCungCapNuocSachDataSet3 quanLyCungCapNuocSachDataSet3;
        private System.Windows.Forms.BindingSource loaiKhachHangBindingSource;
        private QuanLyCungCapNuocSachDataSet3TableAdapters.loaiKhachHangTableAdapter loaiKhachHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBac1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBac2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBac3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBac4DataGridViewTextBoxColumn;
    }
}