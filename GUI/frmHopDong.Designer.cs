namespace GUI
{
    partial class frmHopDong
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
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.quanLyCungCapNuocSachDataSet2 = new GUI.QuanLyCungCapNuocSachDataSet2();
            this.hopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hopDongTableAdapter = new GUI.QuanLyCungCapNuocSachDataSet2TableAdapters.HopDongTableAdapter();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLamHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiLamHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHopTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNL = new System.Windows.Forms.TextBox();
            this.dateTimeNL = new System.Windows.Forms.DateTimePicker();
            this.timerHopD = new System.Windows.Forms.Timer(this.components);
            this.panelTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.groupBox1);
            this.panelTool.Controls.Add(this.btnTimKiem);
            this.panelTool.Controls.Add(this.btnCapNhat);
            this.panelTool.Controls.Add(this.btnXoa);
            this.panelTool.Controls.Add(this.btnAdd);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.MaximumSize = new System.Drawing.Size(800, 168);
            this.panelTool.MinimumSize = new System.Drawing.Size(800, 29);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(800, 168);
            this.panelTool.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(249, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(169, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(88, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.AutoGenerateColumns = false;
            this.dgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.ngayLamHDDataGridViewTextBoxColumn,
            this.noiLamHDDataGridViewTextBoxColumn});
            this.dgvHopDong.DataSource = this.hopDongBindingSource;
            this.dgvHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHopDong.Location = new System.Drawing.Point(0, 168);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.Size = new System.Drawing.Size(800, 346);
            this.dgvHopDong.TabIndex = 1;
            // 
            // quanLyCungCapNuocSachDataSet2
            // 
            this.quanLyCungCapNuocSachDataSet2.DataSetName = "QuanLyCungCapNuocSachDataSet2";
            this.quanLyCungCapNuocSachDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hopDongBindingSource
            // 
            this.hopDongBindingSource.DataMember = "HopDong";
            this.hopDongBindingSource.DataSource = this.quanLyCungCapNuocSachDataSet2;
            // 
            // hopDongTableAdapter
            // 
            this.hopDongTableAdapter.ClearBeforeFill = true;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "maHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "maHD";
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayLamHDDataGridViewTextBoxColumn
            // 
            this.ngayLamHDDataGridViewTextBoxColumn.DataPropertyName = "ngayLamHD";
            this.ngayLamHDDataGridViewTextBoxColumn.HeaderText = "ngayLamHD";
            this.ngayLamHDDataGridViewTextBoxColumn.Name = "ngayLamHDDataGridViewTextBoxColumn";
            // 
            // noiLamHDDataGridViewTextBoxColumn
            // 
            this.noiLamHDDataGridViewTextBoxColumn.DataPropertyName = "noiLamHD";
            this.noiLamHDDataGridViewTextBoxColumn.HeaderText = "noiLamHD";
            this.noiLamHDDataGridViewTextBoxColumn.Name = "noiLamHDDataGridViewTextBoxColumn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeNL);
            this.groupBox1.Controls.Add(this.btnHopTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNL);
            this.groupBox1.Location = new System.Drawing.Point(131, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 129);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hộp tìm kiếm";
            // 
            // btnHopTimKiem
            // 
            this.btnHopTimKiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopTimKiem.Location = new System.Drawing.Point(320, 45);
            this.btnHopTimKiem.Name = "btnHopTimKiem";
            this.btnHopTimKiem.Size = new System.Drawing.Size(75, 42);
            this.btnHopTimKiem.TabIndex = 33;
            this.btnHopTimKiem.Text = "TÌM";
            this.btnHopTimKiem.UseVisualStyleBackColor = true;
            this.btnHopTimKiem.Click += new System.EventHandler(this.btnHopTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(88, 17);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(209, 20);
            this.txtMa.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ngày lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nơi lập";
            // 
            // txtNL
            // 
            this.txtNL.Location = new System.Drawing.Point(88, 96);
            this.txtNL.Name = "txtNL";
            this.txtNL.Size = new System.Drawing.Size(209, 20);
            this.txtNL.TabIndex = 30;
            // 
            // dateTimeNL
            // 
            this.dateTimeNL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNL.Location = new System.Drawing.Point(88, 56);
            this.dateTimeNL.Name = "dateTimeNL";
            this.dateTimeNL.Size = new System.Drawing.Size(209, 20);
            this.dateTimeNL.TabIndex = 34;
            // 
            // timerHopD
            // 
            this.timerHopD.Interval = 15;
            this.timerHopD.Tick += new System.EventHandler(this.timerHopD_Tick);
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.dgvHopDong);
            this.Controls.Add(this.panelTool);
            this.Name = "frmHopDong";
            this.Text = "frmHopDong";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            this.panelTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private QuanLyCungCapNuocSachDataSet2 quanLyCungCapNuocSachDataSet2;
        private System.Windows.Forms.BindingSource hopDongBindingSource;
        private QuanLyCungCapNuocSachDataSet2TableAdapters.HopDongTableAdapter hopDongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLamHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiLamHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHopTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNL;
        private System.Windows.Forms.DateTimePicker dateTimeNL;
        private System.Windows.Forms.Timer timerHopD;
    }
}