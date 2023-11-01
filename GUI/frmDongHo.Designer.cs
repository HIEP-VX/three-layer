namespace GUI
{
    partial class frmDongHo
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
            this.panelTool = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvDongho = new System.Windows.Forms.DataGridView();
            this.quanLyCungCapNuocSachDataSet1 = new GUI.QuanLyCungCapNuocSachDataSet1();
            this.dongHoNuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dongHoNuocTableAdapter = new GUI.QuanLyCungCapNuocSachDataSet1TableAdapters.DongHoNuocTableAdapter();
            this.maDHNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangDHNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCongToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongHoNuocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.btnTimKiem);
            this.panelTool.Controls.Add(this.btnCapNhat);
            this.panelTool.Controls.Add(this.btnXoa);
            this.panelTool.Controls.Add(this.btnAdd);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.MaximumSize = new System.Drawing.Size(800, 168);
            this.panelTool.MinimumSize = new System.Drawing.Size(800, 29);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(800, 29);
            this.panelTool.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(250, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 37;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(170, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 36;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(89, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDongho
            // 
            this.dgvDongho.AutoGenerateColumns = false;
            this.dgvDongho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDongho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDongho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDHNDataGridViewTextBoxColumn,
            this.hangDHNDataGridViewTextBoxColumn,
            this.chiSoDauDataGridViewTextBoxColumn,
            this.soCongToDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn});
            this.dgvDongho.DataSource = this.dongHoNuocBindingSource;
            this.dgvDongho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDongho.Location = new System.Drawing.Point(0, 29);
            this.dgvDongho.Name = "dgvDongho";
            this.dgvDongho.Size = new System.Drawing.Size(800, 421);
            this.dgvDongho.TabIndex = 1;
            // 
            // quanLyCungCapNuocSachDataSet1
            // 
            this.quanLyCungCapNuocSachDataSet1.DataSetName = "QuanLyCungCapNuocSachDataSet1";
            this.quanLyCungCapNuocSachDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dongHoNuocBindingSource
            // 
            this.dongHoNuocBindingSource.DataMember = "DongHoNuoc";
            this.dongHoNuocBindingSource.DataSource = this.quanLyCungCapNuocSachDataSet1;
            // 
            // dongHoNuocTableAdapter
            // 
            this.dongHoNuocTableAdapter.ClearBeforeFill = true;
            // 
            // maDHNDataGridViewTextBoxColumn
            // 
            this.maDHNDataGridViewTextBoxColumn.DataPropertyName = "maDHN";
            this.maDHNDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.maDHNDataGridViewTextBoxColumn.Name = "maDHNDataGridViewTextBoxColumn";
            this.maDHNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hangDHNDataGridViewTextBoxColumn
            // 
            this.hangDHNDataGridViewTextBoxColumn.DataPropertyName = "hangDHN";
            this.hangDHNDataGridViewTextBoxColumn.HeaderText = "Hãng";
            this.hangDHNDataGridViewTextBoxColumn.Name = "hangDHNDataGridViewTextBoxColumn";
            // 
            // chiSoDauDataGridViewTextBoxColumn
            // 
            this.chiSoDauDataGridViewTextBoxColumn.DataPropertyName = "chiSoDau";
            this.chiSoDauDataGridViewTextBoxColumn.HeaderText = "Chỉ số đầu";
            this.chiSoDauDataGridViewTextBoxColumn.Name = "chiSoDauDataGridViewTextBoxColumn";
            // 
            // soCongToDataGridViewTextBoxColumn
            // 
            this.soCongToDataGridViewTextBoxColumn.DataPropertyName = "soCongTo";
            this.soCongToDataGridViewTextBoxColumn.HeaderText = "Số công tơ";
            this.soCongToDataGridViewTextBoxColumn.Name = "soCongToDataGridViewTextBoxColumn";
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "tinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "Tình trạng";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            // 
            // frmDongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDongho);
            this.Controls.Add(this.panelTool);
            this.Name = "frmDongHo";
            this.Text = "frmDongHo";
            this.Load += new System.EventHandler(this.frmDongHo_Load);
            this.panelTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongHoNuocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvDongho;
        private QuanLyCungCapNuocSachDataSet1 quanLyCungCapNuocSachDataSet1;
        private System.Windows.Forms.BindingSource dongHoNuocBindingSource;
        private QuanLyCungCapNuocSachDataSet1TableAdapters.DongHoNuocTableAdapter dongHoNuocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDHNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangDHNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCongToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
    }
}