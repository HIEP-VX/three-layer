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
            this.btnImport = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tieuThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCungCapNuocSachDataSet = new GUI.QuanLyCungCapNuocSachDataSet();
            this.tieuThuTableAdapter = new GUI.QuanLyCungCapNuocSachDataSetTableAdapters.TieuThuTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelDataTieuThu = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tieuThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelDataTieuThu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbThang);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnAdd);
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
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(447, 1);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 28);
            this.btnImport.TabIndex = 42;
            this.btnImport.Text = "Thêm file";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(336, 1);
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
            this.btnCapNhat.Location = new System.Drawing.Point(215, 1);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(84, 28);
            this.btnCapNhat.TabIndex = 40;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(118, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 28);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(19, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 28);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.tieuThuBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 421);
            this.dataGridView1.TabIndex = 3;
            // 
            // panelDataTieuThu
            // 
            this.panelDataTieuThu.Controls.Add(this.dataGridView1);
            this.panelDataTieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataTieuThu.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDataTieuThu.Location = new System.Drawing.Point(0, 29);
            this.panelDataTieuThu.Name = "panelDataTieuThu";
            this.panelDataTieuThu.Size = new System.Drawing.Size(800, 421);
            this.panelDataTieuThu.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelDataTieuThu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Button btnImport;
        private QuanLyCungCapNuocSachDataSet quanLyCungCapNuocSachDataSet;
        private System.Windows.Forms.BindingSource tieuThuBindingSource;
        private QuanLyCungCapNuocSachDataSetTableAdapters.TieuThuTableAdapter tieuThuTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
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