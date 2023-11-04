namespace GUI
{
    partial class frmThemHopDong
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
            this.grpTTKH = new System.Windows.Forms.GroupBox();
            this.txtLKH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSODT = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimeNS = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTTHD = new System.Windows.Forms.GroupBox();
            this.txtNL = new System.Windows.Forms.TextBox();
            this.datetimeNL = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpTTDH = new System.Windows.Forms.GroupBox();
            this.dgvDH_HD = new System.Windows.Forms.DataGridView();
            this.maDHNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangDHNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCongToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dongHoNuocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataDHN1 = new GUI.dataDHN1();
            this.dongHoNuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDongHoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDongHo = new GUI.dataDongHo();
            this.button1 = new System.Windows.Forms.Button();
            this.dongHoNuocTableAdapter = new GUI.dataDHN1TableAdapters.DongHoNuocTableAdapter();
            this.grpTTKH.SuspendLayout();
            this.grpTTHD.SuspendLayout();
            this.grpTTDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongHoNuocBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDHN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongHoNuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDongHoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDongHo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTTKH
            // 
            this.grpTTKH.Controls.Add(this.txtLKH);
            this.grpTTKH.Controls.Add(this.label7);
            this.grpTTKH.Controls.Add(this.txtSODT);
            this.grpTTKH.Controls.Add(this.txtDC);
            this.grpTTKH.Controls.Add(this.txtHT);
            this.grpTTKH.Controls.Add(this.label4);
            this.grpTTKH.Controls.Add(this.label3);
            this.grpTTKH.Controls.Add(this.label2);
            this.grpTTKH.Controls.Add(this.datetimeNS);
            this.grpTTKH.Controls.Add(this.label1);
            this.grpTTKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTTKH.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTKH.Location = new System.Drawing.Point(0, 0);
            this.grpTTKH.Name = "grpTTKH";
            this.grpTTKH.Size = new System.Drawing.Size(999, 150);
            this.grpTTKH.TabIndex = 0;
            this.grpTTKH.TabStop = false;
            this.grpTTKH.Text = "Thông tin khách hàng";
            this.grpTTKH.Enter += new System.EventHandler(this.grpTTKH_Enter);
            // 
            // txtLKH
            // 
            this.txtLKH.FormattingEnabled = true;
            this.txtLKH.Items.AddRange(new object[] {
            "1-Hộ gia đình bình thường",
            "2-Hộ gia đình chính sách",
            "3-Cơ quan hành chính",
            "4-Hoạt động sản xuất",
            "5-Kinh doanh dịch vụ"});
            this.txtLKH.Location = new System.Drawing.Point(169, 110);
            this.txtLKH.Name = "txtLKH";
            this.txtLKH.Size = new System.Drawing.Size(186, 23);
            this.txtLKH.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Loại khách hàng";
            // 
            // txtSODT
            // 
            this.txtSODT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSODT.Location = new System.Drawing.Point(706, 32);
            this.txtSODT.Name = "txtSODT";
            this.txtSODT.Size = new System.Drawing.Size(140, 23);
            this.txtSODT.TabIndex = 7;
            // 
            // txtDC
            // 
            this.txtDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDC.Location = new System.Drawing.Point(706, 70);
            this.txtDC.Multiline = true;
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(245, 64);
            this.txtDC.TabIndex = 6;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(167, 33);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(188, 23);
            this.txtHT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh";
            // 
            // datetimeNS
            // 
            this.datetimeNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeNS.Location = new System.Drawing.Point(169, 70);
            this.datetimeNS.Name = "datetimeNS";
            this.datetimeNS.Size = new System.Drawing.Size(186, 23);
            this.datetimeNS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // grpTTHD
            // 
            this.grpTTHD.Controls.Add(this.txtNL);
            this.grpTTHD.Controls.Add(this.datetimeNL);
            this.grpTTHD.Controls.Add(this.label6);
            this.grpTTHD.Controls.Add(this.label5);
            this.grpTTHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTTHD.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTHD.Location = new System.Drawing.Point(0, 150);
            this.grpTTHD.Name = "grpTTHD";
            this.grpTTHD.Size = new System.Drawing.Size(999, 83);
            this.grpTTHD.TabIndex = 1;
            this.grpTTHD.TabStop = false;
            this.grpTTHD.Text = "Thông tin hợp đồng";
            // 
            // txtNL
            // 
            this.txtNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNL.Location = new System.Drawing.Point(712, 31);
            this.txtNL.Name = "txtNL";
            this.txtNL.Size = new System.Drawing.Size(245, 23);
            this.txtNL.TabIndex = 3;
            // 
            // datetimeNL
            // 
            this.datetimeNL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeNL.Location = new System.Drawing.Point(167, 33);
            this.datetimeNL.Name = "datetimeNL";
            this.datetimeNL.Size = new System.Drawing.Size(188, 23);
            this.datetimeNL.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thời gian lập";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nơi lập";
            // 
            // grpTTDH
            // 
            this.grpTTDH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTTDH.Controls.Add(this.dgvDH_HD);
            this.grpTTDH.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTDH.Location = new System.Drawing.Point(0, 233);
            this.grpTTDH.Name = "grpTTDH";
            this.grpTTDH.Size = new System.Drawing.Size(999, 423);
            this.grpTTDH.TabIndex = 2;
            this.grpTTDH.TabStop = false;
            this.grpTTDH.Text = "Thông tin đồng hồ";
            this.grpTTDH.Enter += new System.EventHandler(this.grpTTDH_Enter);
            // 
            // dgvDH_HD
            // 
            this.dgvDH_HD.AutoGenerateColumns = false;
            this.dgvDH_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDH_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDH_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDHNDataGridViewTextBoxColumn,
            this.hangDHNDataGridViewTextBoxColumn,
            this.chiSoDauDataGridViewTextBoxColumn,
            this.soCongToDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn,
            this.selectColumn});
            this.dgvDH_HD.DataSource = this.dongHoNuocBindingSource1;
            this.dgvDH_HD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDH_HD.Location = new System.Drawing.Point(3, 18);
            this.dgvDH_HD.Name = "dgvDH_HD";
            this.dgvDH_HD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDH_HD.Size = new System.Drawing.Size(993, 402);
            this.dgvDH_HD.TabIndex = 0;
            // 
            // maDHNDataGridViewTextBoxColumn
            // 
            this.maDHNDataGridViewTextBoxColumn.DataPropertyName = "maDHN";
            this.maDHNDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.maDHNDataGridViewTextBoxColumn.Name = "maDHNDataGridViewTextBoxColumn";
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
            // selectColumn
            // 
            this.selectColumn.HeaderText = "Chọn đồng hồ";
            this.selectColumn.Name = "selectColumn";
            // 
            // dongHoNuocBindingSource1
            // 
            this.dongHoNuocBindingSource1.DataMember = "DongHoNuoc";
            this.dongHoNuocBindingSource1.DataSource = this.dataDHN1;
            // 
            // dataDHN1
            // 
            this.dataDHN1.DataSetName = "dataDHN1";
            this.dataDHN1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dongHoNuocBindingSource
            // 
            this.dongHoNuocBindingSource.DataMember = "DongHoNuoc";
            this.dongHoNuocBindingSource.DataSource = this.dataDongHoBindingSource;
            // 
            // dataDongHoBindingSource
            // 
            this.dataDongHoBindingSource.DataSource = this.dataDongHo;
            this.dataDongHoBindingSource.Position = 0;
            // 
            // dataDongHo
            // 
            this.dataDongHo.DataSetName = "QuanLyCungCapNuocSachDataSet1";
            this.dataDongHo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(999, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "THÊM HỢP ĐỒNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dongHoNuocTableAdapter
            // 
            this.dongHoNuocTableAdapter.ClearBeforeFill = true;
            // 
            // frmThemHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 701);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpTTDH);
            this.Controls.Add(this.grpTTHD);
            this.Controls.Add(this.grpTTKH);
            this.Name = "frmThemHopDong";
            this.Text = "frmThemHopDong";
            this.Load += new System.EventHandler(this.frmThemHopDong_Load);
            this.grpTTKH.ResumeLayout(false);
            this.grpTTKH.PerformLayout();
            this.grpTTHD.ResumeLayout(false);
            this.grpTTHD.PerformLayout();
            this.grpTTDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongHoNuocBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDHN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongHoNuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDongHoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDongHo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTTKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimeNS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTTHD;
        private System.Windows.Forms.GroupBox grpTTDH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSODT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.TextBox txtNL;
        private System.Windows.Forms.DateTimePicker datetimeNL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDH_HD;
        private System.Windows.Forms.BindingSource dongHoNuocBindingSource;
        private System.Windows.Forms.BindingSource dataDongHoBindingSource;
        private dataDongHo dataDongHo;
        private dataDHN1 dataDHN1;
        private System.Windows.Forms.BindingSource dongHoNuocBindingSource1;
        private dataDHN1TableAdapters.DongHoNuocTableAdapter dongHoNuocTableAdapter;
        private System.Windows.Forms.Label label7;
        //private QuanLyCungCapNuocSachDataSet quanLyCungCapNuocSachDataSet;
        private System.Windows.Forms.ComboBox txtLKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDHNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangDHNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCongToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectColumn;
    }
}