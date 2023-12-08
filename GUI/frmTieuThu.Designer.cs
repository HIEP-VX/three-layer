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
            this.panelTool = new System.Windows.Forms.Panel();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbThangTGD = new System.Windows.Forms.ComboBox();
            this.cbThangTGC = new System.Windows.Forms.ComboBox();
            this.txtNgayTGC = new System.Windows.Forms.TextBox();
            this.txtNamTGC = new System.Windows.Forms.TextBox();
            this.txtNgayTGD = new System.Windows.Forms.TextBox();
            this.txtNamTGD = new System.Windows.Forms.TextBox();
            this.txtDuong = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.comboBoxPhuong = new System.Windows.Forms.ComboBox();
            this.diaChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCungCapNuocSachDataSet4 = new GUI.QuanLyCungCapNuocSachDataSet4();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLuongNuoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCSMoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCSCu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMAtt = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnChiaPhuong = new System.Windows.Forms.Button();
            this.grpChiSoNuoc = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMATT = new System.Windows.Forms.TextBox();
            this.txtChiSoNuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuuChiSo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnThemExcel = new System.Windows.Forms.Button();
            this.btnGhiNuoc = new System.Windows.Forms.Button();
            this.panelGhiNuoc = new System.Windows.Forms.Panel();
            this.dgvGhiNuoc = new System.Windows.Forms.DataGridView();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.diaChiTableAdapter = new GUI.QuanLyCungCapNuocSachDataSet4TableAdapters.diaChiTableAdapter();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panelTool.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet4)).BeginInit();
            this.grpChiSoNuoc.SuspendLayout();
            this.panelGhiNuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiNuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.btnXoa);
            this.panelTool.Controls.Add(this.btnXuatFile);
            this.panelTool.Controls.Add(this.groupBox1);
            this.panelTool.Controls.Add(this.btnCapNhat);
            this.panelTool.Controls.Add(this.btnChiaPhuong);
            this.panelTool.Controls.Add(this.grpChiSoNuoc);
            this.panelTool.Controls.Add(this.btnSave);
            this.panelTool.Controls.Add(this.btnThemExcel);
            this.panelTool.Controls.Add(this.btnGhiNuoc);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.MaximumSize = new System.Drawing.Size(1000, 168);
            this.panelTool.MinimumSize = new System.Drawing.Size(800, 32);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(984, 168);
            this.panelTool.TabIndex = 1;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(430, 3);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(77, 28);
            this.btnXuatFile.TabIndex = 54;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbThangTGD);
            this.groupBox1.Controls.Add(this.cbThangTGC);
            this.groupBox1.Controls.Add(this.txtNgayTGC);
            this.groupBox1.Controls.Add(this.txtNamTGC);
            this.groupBox1.Controls.Add(this.txtNgayTGD);
            this.groupBox1.Controls.Add(this.txtNamTGD);
            this.groupBox1.Controls.Add(this.txtDuong);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.comboBoxPhuong);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLuongNuoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCSMoi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCSCu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textMAtt);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(213, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 132);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hộp tìm kiếm";
            // 
            // cbThangTGD
            // 
            this.cbThangTGD.FormattingEnabled = true;
            this.cbThangTGD.Location = new System.Drawing.Point(329, 45);
            this.cbThangTGD.Name = "cbThangTGD";
            this.cbThangTGD.Size = new System.Drawing.Size(57, 24);
            this.cbThangTGD.TabIndex = 76;
            // 
            // cbThangTGC
            // 
            this.cbThangTGC.FormattingEnabled = true;
            this.cbThangTGC.Location = new System.Drawing.Point(329, 72);
            this.cbThangTGC.Name = "cbThangTGC";
            this.cbThangTGC.Size = new System.Drawing.Size(57, 24);
            this.cbThangTGC.TabIndex = 75;
            // 
            // txtNgayTGC
            // 
            this.txtNgayTGC.Location = new System.Drawing.Point(296, 72);
            this.txtNgayTGC.Name = "txtNgayTGC";
            this.txtNgayTGC.Size = new System.Drawing.Size(30, 23);
            this.txtNgayTGC.TabIndex = 73;
            // 
            // txtNamTGC
            // 
            this.txtNamTGC.Location = new System.Drawing.Point(389, 72);
            this.txtNamTGC.Name = "txtNamTGC";
            this.txtNamTGC.Size = new System.Drawing.Size(63, 23);
            this.txtNamTGC.TabIndex = 72;
            // 
            // txtNgayTGD
            // 
            this.txtNgayTGD.Location = new System.Drawing.Point(296, 45);
            this.txtNgayTGD.Name = "txtNgayTGD";
            this.txtNgayTGD.Size = new System.Drawing.Size(30, 23);
            this.txtNgayTGD.TabIndex = 70;
            // 
            // txtNamTGD
            // 
            this.txtNamTGD.Location = new System.Drawing.Point(389, 45);
            this.txtNamTGD.Name = "txtNamTGD";
            this.txtNamTGD.Size = new System.Drawing.Size(63, 23);
            this.txtNamTGD.TabIndex = 69;
            // 
            // txtDuong
            // 
            this.txtDuong.Location = new System.Drawing.Point(583, 45);
            this.txtDuong.Name = "txtDuong";
            this.txtDuong.Size = new System.Drawing.Size(140, 23);
            this.txtDuong.TabIndex = 66;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(583, 18);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(140, 23);
            this.txtTenKH.TabIndex = 65;
            // 
            // comboBoxPhuong
            // 
            this.comboBoxPhuong.DataSource = this.diaChiBindingSource;
            this.comboBoxPhuong.DisplayMember = "phuong";
            this.comboBoxPhuong.FormattingEnabled = true;
            this.comboBoxPhuong.Location = new System.Drawing.Point(583, 72);
            this.comboBoxPhuong.Name = "comboBoxPhuong";
            this.comboBoxPhuong.Size = new System.Drawing.Size(140, 24);
            this.comboBoxPhuong.TabIndex = 54;
            // 
            // diaChiBindingSource
            // 
            this.diaChiBindingSource.DataMember = "diaChi";
            this.diaChiBindingSource.DataSource = this.quanLyCungCapNuocSachDataSet4;
            // 
            // quanLyCungCapNuocSachDataSet4
            // 
            this.quanLyCungCapNuocSachDataSet4.DataSetName = "QuanLyCungCapNuocSachDataSet4";
            this.quanLyCungCapNuocSachDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(483, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 64;
            this.label12.Text = "Phường";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(483, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Đường";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(483, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 62;
            this.label10.Text = "Tên khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Thời gian cuối";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 58;
            this.label8.Text = "Thời gian đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Lượng nước";
            // 
            // txtLuongNuoc
            // 
            this.txtLuongNuoc.Location = new System.Drawing.Point(296, 18);
            this.txtLuongNuoc.Name = "txtLuongNuoc";
            this.txtLuongNuoc.Size = new System.Drawing.Size(156, 23);
            this.txtLuongNuoc.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "CS mới";
            // 
            // txtCSMoi
            // 
            this.txtCSMoi.Location = new System.Drawing.Point(100, 99);
            this.txtCSMoi.Name = "txtCSMoi";
            this.txtCSMoi.Size = new System.Drawing.Size(63, 23);
            this.txtCSMoi.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "CS cũ";
            // 
            // txtCSCu
            // 
            this.txtCSCu.Location = new System.Drawing.Point(100, 72);
            this.txtCSCu.Name = "txtCSCu";
            this.txtCSCu.Size = new System.Drawing.Size(63, 23);
            this.txtCSCu.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Mã khách";
            // 
            // textMAtt
            // 
            this.textMAtt.Location = new System.Drawing.Point(100, 18);
            this.textMAtt.Name = "textMAtt";
            this.textMAtt.Size = new System.Drawing.Size(63, 23);
            this.textMAtt.TabIndex = 50;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(100, 45);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(63, 23);
            this.txtMaKH.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Mã tiêu thụ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(296, 99);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(288, 28);
            this.btnTimKiem.TabIndex = 49;
            this.btnTimKiem.Text = "THỰC HIỆN";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(231, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 28);
            this.btnCapNhat.TabIndex = 53;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnChiaPhuong
            // 
            this.btnChiaPhuong.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiaPhuong.Location = new System.Drawing.Point(137, 3);
            this.btnChiaPhuong.Name = "btnChiaPhuong";
            this.btnChiaPhuong.Size = new System.Drawing.Size(88, 28);
            this.btnChiaPhuong.TabIndex = 52;
            this.btnChiaPhuong.Text = "Theo phường";
            this.btnChiaPhuong.UseVisualStyleBackColor = true;
            this.btnChiaPhuong.Click += new System.EventHandler(this.btnChiaPhuong_Click);
            // 
            // grpChiSoNuoc
            // 
            this.grpChiSoNuoc.Controls.Add(this.label2);
            this.grpChiSoNuoc.Controls.Add(this.txtMATT);
            this.grpChiSoNuoc.Controls.Add(this.txtChiSoNuoc);
            this.grpChiSoNuoc.Controls.Add(this.label1);
            this.grpChiSoNuoc.Controls.Add(this.btnLuuChiSo);
            this.grpChiSoNuoc.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChiSoNuoc.Location = new System.Drawing.Point(10, 36);
            this.grpChiSoNuoc.Name = "grpChiSoNuoc";
            this.grpChiSoNuoc.Size = new System.Drawing.Size(193, 132);
            this.grpChiSoNuoc.TabIndex = 51;
            this.grpChiSoNuoc.TabStop = false;
            this.grpChiSoNuoc.Text = "Cập nhật chỉ số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Chỉ số mới";
            // 
            // txtMATT
            // 
            this.txtMATT.Location = new System.Drawing.Point(79, 25);
            this.txtMATT.Name = "txtMATT";
            this.txtMATT.Size = new System.Drawing.Size(100, 23);
            this.txtMATT.TabIndex = 50;
            // 
            // txtChiSoNuoc
            // 
            this.txtChiSoNuoc.Location = new System.Drawing.Point(79, 63);
            this.txtChiSoNuoc.Name = "txtChiSoNuoc";
            this.txtChiSoNuoc.Size = new System.Drawing.Size(100, 23);
            this.txtChiSoNuoc.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mã";
            // 
            // btnLuuChiSo
            // 
            this.btnLuuChiSo.FlatAppearance.BorderSize = 0;
            this.btnLuuChiSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuChiSo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuChiSo.Location = new System.Drawing.Point(11, 92);
            this.btnLuuChiSo.Name = "btnLuuChiSo";
            this.btnLuuChiSo.Size = new System.Drawing.Size(168, 28);
            this.btnLuuChiSo.TabIndex = 49;
            this.btnLuuChiSo.Text = "Lưu";
            this.btnLuuChiSo.UseVisualStyleBackColor = true;
            this.btnLuuChiSo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(625, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnThemExcel
            // 
            this.btnThemExcel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemExcel.Location = new System.Drawing.Point(513, 3);
            this.btnThemExcel.Name = "btnThemExcel";
            this.btnThemExcel.Size = new System.Drawing.Size(106, 28);
            this.btnThemExcel.TabIndex = 44;
            this.btnThemExcel.Text = "Thêm tệp excel";
            this.btnThemExcel.UseVisualStyleBackColor = true;
            this.btnThemExcel.Click += new System.EventHandler(this.btnThemExcel_Click);
            // 
            // btnGhiNuoc
            // 
            this.btnGhiNuoc.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiNuoc.Location = new System.Drawing.Point(56, 3);
            this.btnGhiNuoc.Name = "btnGhiNuoc";
            this.btnGhiNuoc.Size = new System.Drawing.Size(75, 28);
            this.btnGhiNuoc.TabIndex = 43;
            this.btnGhiNuoc.Text = "Ghi nước";
            this.btnGhiNuoc.UseVisualStyleBackColor = true;
            this.btnGhiNuoc.Click += new System.EventHandler(this.btnGhiNuoc_Click);
            // 
            // panelGhiNuoc
            // 
            this.panelGhiNuoc.Controls.Add(this.dgvGhiNuoc);
            this.panelGhiNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGhiNuoc.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelGhiNuoc.Location = new System.Drawing.Point(0, 168);
            this.panelGhiNuoc.Name = "panelGhiNuoc";
            this.panelGhiNuoc.Size = new System.Drawing.Size(984, 282);
            this.panelGhiNuoc.TabIndex = 2;
            // 
            // dgvGhiNuoc
            // 
            this.dgvGhiNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGhiNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGhiNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGhiNuoc.Location = new System.Drawing.Point(0, 0);
            this.dgvGhiNuoc.Name = "dgvGhiNuoc";
            this.dgvGhiNuoc.ReadOnly = true;
            this.dgvGhiNuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGhiNuoc.Size = new System.Drawing.Size(984, 282);
            this.dgvGhiNuoc.TabIndex = 0;
            this.dgvGhiNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGhiNuoc_CellClick);
            this.dgvGhiNuoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGhiNuoc_CellDoubleClick);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // diaChiTableAdapter
            // 
            this.diaChiTableAdapter.ClearBeforeFill = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(313, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 28);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmTieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.panelGhiNuoc);
            this.Controls.Add(this.panelTool);
            this.Name = "frmTieuThu";
            this.Text = "frmTieuThu";
            this.Load += new System.EventHandler(this.frmGhiNuoc_Load);
            this.panelTool.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCungCapNuocSachDataSet4)).EndInit();
            this.grpChiSoNuoc.ResumeLayout(false);
            this.grpChiSoNuoc.PerformLayout();
            this.panelGhiNuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiNuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Panel panelGhiNuoc;
        private System.Windows.Forms.Button btnGhiNuoc;
        private System.Windows.Forms.Button btnThemExcel;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvGhiNuoc;
        private System.Windows.Forms.Button btnLuuChiSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChiSoNuoc;
        private System.Windows.Forms.GroupBox grpChiSoNuoc;
        private System.Windows.Forms.TextBox txtMATT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnChiaPhuong;
        private System.Windows.Forms.ComboBox comboBoxPhuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMAtt;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLuongNuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCSMoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCSCu;
        private System.Windows.Forms.TextBox txtNamTGD;
        private System.Windows.Forms.TextBox txtDuong;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private QuanLyCungCapNuocSachDataSet4 quanLyCungCapNuocSachDataSet4;
        private System.Windows.Forms.BindingSource diaChiBindingSource;
        private QuanLyCungCapNuocSachDataSet4TableAdapters.diaChiTableAdapter diaChiTableAdapter;
        private System.Windows.Forms.TextBox txtNgayTGC;
        private System.Windows.Forms.TextBox txtNamTGC;
        private System.Windows.Forms.TextBox txtNgayTGD;
        private System.Windows.Forms.ComboBox cbThangTGD;
        private System.Windows.Forms.ComboBox cbThangTGC;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnXoa;
    }
}