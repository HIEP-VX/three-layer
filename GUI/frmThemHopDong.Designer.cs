﻿namespace GUI
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
            this.label8 = new System.Windows.Forms.Label();
            this.cbPhuong = new System.Windows.Forms.ComboBox();
            this.diaChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtNL = new System.Windows.Forms.TextBox();
            this.datetimeNL = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpTTDH = new System.Windows.Forms.GroupBox();
            this.dgvDH_HD = new System.Windows.Forms.DataGridView();
            this.selectColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.grpTTKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiBindingSource)).BeginInit();
            this.grpTTHD.SuspendLayout();
            this.grpTTDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH_HD)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTTKH
            // 
            this.grpTTKH.Controls.Add(this.label8);
            this.grpTTKH.Controls.Add(this.cbPhuong);
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
            this.grpTTKH.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTKH.Location = new System.Drawing.Point(0, 0);
            this.grpTTKH.Name = "grpTTKH";
            this.grpTTKH.Size = new System.Drawing.Size(1040, 121);
            this.grpTTKH.TabIndex = 0;
            this.grpTTKH.TabStop = false;
            this.grpTTKH.Text = "Thông tin khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Phường";
            // 
            // cbPhuong
            // 
            this.cbPhuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhuong.FormattingEnabled = true;
            this.cbPhuong.Items.AddRange(new object[] {
            "Bà Triệu",
            "Cửa Bắc",
            "Cửa Nam",
            "Hạ Long",
            "Lộc Hạ",
            "Lộc Vượng",
            "Năng Tĩnh",
            "Ngô Quyền",
            "Nguyễn Du",
            "Trần Quang Khải",
            "Trần Tế Xương",
            "Trường Thi",
            "Văn Miếu",
            "Vị Hoàng",
            "Vị Xuyên",
            "Phan Đình Phùng",
            "Quang Trung",
            "Thống Nhất",
            "Trần Đăng Ninh",
            "Trần Hưng Đạo",
            "Lộc Hòa",
            "Mỹ Xá"});
            this.cbPhuong.Location = new System.Drawing.Point(519, 76);
            this.cbPhuong.Name = "cbPhuong";
            this.cbPhuong.Size = new System.Drawing.Size(155, 27);
            this.cbPhuong.TabIndex = 10;
            // 
            // diaChiBindingSource
            // 
            this.diaChiBindingSource.DataMember = "diaChi";
            // 
            // quanLyCungCapNuocSachDataSet4
            // 
            // 
            // txtLKH
            // 
            this.txtLKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLKH.FormattingEnabled = true;
            this.txtLKH.Items.AddRange(new object[] {
            "1-Hộ gia đình bình thường",
            "2-Hộ gia đình chính sách",
            "3-Cơ quan hành chính",
            "4-Hoạt động sản xuất",
            "5-Kinh doanh dịch vụ"});
            this.txtLKH.Location = new System.Drawing.Point(832, 76);
            this.txtLKH.Name = "txtLKH";
            this.txtLKH.Size = new System.Drawing.Size(196, 27);
            this.txtLKH.TabIndex = 9;
            this.txtLKH.SelectedValueChanged += new System.EventHandler(this.txtLKH_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(733, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phân loại";
            // 
            // txtSODT
            // 
            this.txtSODT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSODT.Location = new System.Drawing.Point(832, 31);
            this.txtSODT.Name = "txtSODT";
            this.txtSODT.Size = new System.Drawing.Size(196, 27);
            this.txtSODT.TabIndex = 7;
            this.txtSODT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSODT_KeyPress);
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(105, 76);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(214, 27);
            this.txtDC.TabIndex = 6;
            this.txtDC.TextChanged += new System.EventHandler(this.txtDC_TextChanged);
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(105, 32);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(214, 27);
            this.txtHT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(733, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đường";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh";
            // 
            // datetimeNS
            // 
            this.datetimeNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeNS.Location = new System.Drawing.Point(519, 31);
            this.datetimeNS.Name = "datetimeNS";
            this.datetimeNS.Size = new System.Drawing.Size(155, 27);
            this.datetimeNS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // grpTTHD
            // 
            this.grpTTHD.Controls.Add(this.label11);
            this.grpTTHD.Controls.Add(this.label10);
            this.grpTTHD.Controls.Add(this.label9);
            this.grpTTHD.Controls.Add(this.txtMaNV);
            this.grpTTHD.Controls.Add(this.txtLyDo);
            this.grpTTHD.Controls.Add(this.txtTien);
            this.grpTTHD.Controls.Add(this.txtNL);
            this.grpTTHD.Controls.Add(this.datetimeNL);
            this.grpTTHD.Controls.Add(this.label6);
            this.grpTTHD.Controls.Add(this.label5);
            this.grpTTHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTTHD.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTHD.Location = new System.Drawing.Point(0, 121);
            this.grpTTHD.Name = "grpTTHD";
            this.grpTTHD.Size = new System.Drawing.Size(1040, 103);
            this.grpTTHD.TabIndex = 1;
            this.grpTTHD.TabStop = false;
            this.grpTTHD.Text = "Thông tin hợp đồng";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(733, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Mã nhân viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(373, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Lý do";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tiền thu";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNV.Location = new System.Drawing.Point(832, 27);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(128, 27);
            this.txtMaNV.TabIndex = 9;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(433, 59);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(277, 27);
            this.txtLyDo.TabIndex = 7;
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(105, 59);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(188, 27);
            this.txtTien.TabIndex = 5;
            this.txtTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTien_KeyPress);
            // 
            // txtNL
            // 
            this.txtNL.Location = new System.Drawing.Point(433, 24);
            this.txtNL.Name = "txtNL";
            this.txtNL.Size = new System.Drawing.Size(277, 27);
            this.txtNL.TabIndex = 3;
            // 
            // datetimeNL
            // 
            this.datetimeNL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeNL.Location = new System.Drawing.Point(105, 24);
            this.datetimeNL.Name = "datetimeNL";
            this.datetimeNL.Size = new System.Drawing.Size(188, 27);
            this.datetimeNL.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 29);
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
            this.grpTTDH.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTDH.Location = new System.Drawing.Point(0, 230);
            this.grpTTDH.Name = "grpTTDH";
            this.grpTTDH.Size = new System.Drawing.Size(1040, 426);
            this.grpTTDH.TabIndex = 2;
            this.grpTTDH.TabStop = false;
            this.grpTTDH.Text = "Thông tin đồng hồ";
            // 
            // dgvDH_HD
            // 
            this.dgvDH_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDH_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDH_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn});
            this.dgvDH_HD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDH_HD.Location = new System.Drawing.Point(3, 23);
            this.dgvDH_HD.Name = "dgvDH_HD";
            this.dgvDH_HD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDH_HD.Size = new System.Drawing.Size(1034, 400);
            this.dgvDH_HD.TabIndex = 0;
            // 
            // selectColumn
            // 
            this.selectColumn.HeaderText = "Chọn đồng hồ";
            this.selectColumn.Name = "selectColumn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 653);
            this.button1.MaximumSize = new System.Drawing.Size(1200, 48);
            this.button1.MinimumSize = new System.Drawing.Size(1040, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1040, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "THÊM HỢP ĐỒNG";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // diaChiTableAdapter
            // 
            // 
            // frmThemHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 701);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpTTDH);
            this.Controls.Add(this.grpTTHD);
            this.Controls.Add(this.grpTTKH);
            this.Name = "frmThemHopDong";
            this.Text = "frmThemHopDong";
            this.Load += new System.EventHandler(this.frmThemHopDong_Load);
            this.grpTTKH.ResumeLayout(false);
            this.grpTTKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiBindingSource)).EndInit();
            this.grpTTHD.ResumeLayout(false);
            this.grpTTHD.PerformLayout();
            this.grpTTDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH_HD)).EndInit();
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
        private System.Windows.Forms.Label label7;
        //private QuanLyCungCapNuocSachDataSet quanLyCungCapNuocSachDataSet;
        private System.Windows.Forms.ComboBox txtLKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPhuong;
        private System.Windows.Forms.BindingSource diaChiBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectColumn;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label9;
    }
}