namespace GUI
{
    partial class FormMain2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeThong = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnCapNhatTaiKhoan = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.panelDanhMuc = new System.Windows.Forms.Panel();
            this.btnGhiNuoc = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnXuPhat = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.pitureDanhMuc = new System.Windows.Forms.PictureBox();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.panelHopDong = new System.Windows.Forms.Panel();
            this.btnDanhSachHopDong = new System.Windows.Forms.Button();
            this.btnThemHopDong = new System.Windows.Forms.Button();
            this.btnHopDong1 = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.homeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel_body = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timerHopDong = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelHeThong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pitureDanhMuc)).BeginInit();
            this.panelHopDong.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.labelWelcome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 38);
            this.panel1.TabIndex = 0;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.Control;
            this.labelWelcome.Location = new System.Drawing.Point(879, 7);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(112, 23);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Chào mừng ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(217, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Trang chủ";
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(5, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(41, 25);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.panelMain.Controls.Add(this.panelHeThong);
            this.panelMain.Controls.Add(this.panelDanhMuc);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 38);
            this.panelMain.MaximumSize = new System.Drawing.Size(200, 720);
            this.panelMain.MinimumSize = new System.Drawing.Size(53, 668);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(53, 711);
            this.panelMain.TabIndex = 1;
            // 
            // panelHeThong
            // 
            this.panelHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.panelHeThong.Controls.Add(this.pictureBox2);
            this.panelHeThong.Controls.Add(this.button12);
            this.panelHeThong.Controls.Add(this.button11);
            this.panelHeThong.Controls.Add(this.btnCapNhatTaiKhoan);
            this.panelHeThong.Controls.Add(this.button6);
            this.panelHeThong.Controls.Add(this.button7);
            this.panelHeThong.Controls.Add(this.btnHeThong);
            this.panelHeThong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeThong.Location = new System.Drawing.Point(0, 50);
            this.panelHeThong.MaximumSize = new System.Drawing.Size(200, 250);
            this.panelHeThong.MinimumSize = new System.Drawing.Size(200, 50);
            this.panelHeThong.Name = "panelHeThong";
            this.panelHeThong.Size = new System.Drawing.Size(200, 50);
            this.panelHeThong.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.Control;
            this.button12.Location = new System.Drawing.Point(0, 210);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(200, 40);
            this.button12.TabIndex = 5;
            this.button12.Text = "...";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.Control;
            this.button11.Location = new System.Drawing.Point(0, 170);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(200, 40);
            this.button11.TabIndex = 4;
            this.button11.Text = "Đăng xuất";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // btnCapNhatTaiKhoan
            // 
            this.btnCapNhatTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnCapNhatTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCapNhatTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnCapNhatTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatTaiKhoan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatTaiKhoan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCapNhatTaiKhoan.Location = new System.Drawing.Point(0, 130);
            this.btnCapNhatTaiKhoan.Name = "btnCapNhatTaiKhoan";
            this.btnCapNhatTaiKhoan.Size = new System.Drawing.Size(200, 40);
            this.btnCapNhatTaiKhoan.TabIndex = 3;
            this.btnCapNhatTaiKhoan.Text = "Cập nhật tài khoản";
            this.btnCapNhatTaiKhoan.UseVisualStyleBackColor = false;
            this.btnCapNhatTaiKhoan.Click += new System.EventHandler(this.btnCapNhatTaiKhoan_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(0, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 40);
            this.button6.TabIndex = 2;
            this.button6.Text = "Khôi phục dữ liệu";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(0, 50);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 40);
            this.button7.TabIndex = 1;
            this.button7.Text = "Sao lưu dữ liệu";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnHeThong
            // 
            this.btnHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHeThong.Location = new System.Drawing.Point(0, 0);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(200, 50);
            this.btnHeThong.TabIndex = 0;
            this.btnHeThong.Text = "Hệ thống";
            this.btnHeThong.UseVisualStyleBackColor = true;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.panelDanhMuc.Controls.Add(this.btnNhanVien);
            this.panelDanhMuc.Controls.Add(this.btnKho);
            this.panelDanhMuc.Controls.Add(this.btnXuPhat);
            this.panelDanhMuc.Controls.Add(this.btnHoaDon);
            this.panelDanhMuc.Controls.Add(this.btnGhiNuoc);
            this.panelDanhMuc.Controls.Add(this.pitureDanhMuc);
            this.panelDanhMuc.Controls.Add(this.btnKhachHang);
            this.panelDanhMuc.Controls.Add(this.panelHopDong);
            this.panelDanhMuc.Controls.Add(this.btnDanhMuc);
            this.panelDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.panelDanhMuc.MaximumSize = new System.Drawing.Size(200, 380);
            this.panelDanhMuc.MinimumSize = new System.Drawing.Size(200, 50);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(200, 50);
            this.panelDanhMuc.TabIndex = 2;
            // 
            // btnGhiNuoc
            // 
            this.btnGhiNuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnGhiNuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGhiNuoc.FlatAppearance.BorderSize = 0;
            this.btnGhiNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhiNuoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiNuoc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGhiNuoc.Location = new System.Drawing.Point(0, 130);
            this.btnGhiNuoc.Name = "btnGhiNuoc";
            this.btnGhiNuoc.Size = new System.Drawing.Size(200, 40);
            this.btnGhiNuoc.TabIndex = 9;
            this.btnGhiNuoc.Text = "Tiêu thụ";
            this.btnGhiNuoc.UseVisualStyleBackColor = false;
            this.btnGhiNuoc.Click += new System.EventHandler(this.btnGhiNuoc_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 170);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(200, 40);
            this.btnHoaDon.TabIndex = 6;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnXuPhat
            // 
            this.btnXuPhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnXuPhat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXuPhat.FlatAppearance.BorderSize = 0;
            this.btnXuPhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuPhat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuPhat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXuPhat.Location = new System.Drawing.Point(0, 210);
            this.btnXuPhat.Name = "btnXuPhat";
            this.btnXuPhat.Size = new System.Drawing.Size(200, 40);
            this.btnXuPhat.TabIndex = 7;
            this.btnXuPhat.Text = "Xử phạt";
            this.btnXuPhat.UseVisualStyleBackColor = false;
            this.btnXuPhat.Click += new System.EventHandler(this.btnXuPhat_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 290);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(200, 40);
            this.btnNhanVien.TabIndex = 8;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKho
            // 
            this.btnKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKho.FlatAppearance.BorderSize = 0;
            this.btnKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKho.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKho.Location = new System.Drawing.Point(0, 250);
            this.btnKho.MaximumSize = new System.Drawing.Size(200, 100);
            this.btnKho.MinimumSize = new System.Drawing.Size(200, 40);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(200, 40);
            this.btnKho.TabIndex = 1;
            this.btnKho.Text = "Kho";
            this.btnKho.UseVisualStyleBackColor = false;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click_1);
            // 
            // pitureDanhMuc
            // 
            this.pitureDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pitureDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("pitureDanhMuc.Image")));
            this.pitureDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.pitureDanhMuc.Name = "pitureDanhMuc";
            this.pitureDanhMuc.Size = new System.Drawing.Size(50, 50);
            this.pitureDanhMuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pitureDanhMuc.TabIndex = 10;
            this.pitureDanhMuc.TabStop = false;
            this.pitureDanhMuc.Click += new System.EventHandler(this.pitureDanhMuc_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 90);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(200, 40);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // panelHopDong
            // 
            this.panelHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.panelHopDong.Controls.Add(this.btnDanhSachHopDong);
            this.panelHopDong.Controls.Add(this.btnThemHopDong);
            this.panelHopDong.Controls.Add(this.btnHopDong1);
            this.panelHopDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHopDong.Location = new System.Drawing.Point(0, 50);
            this.panelHopDong.MaximumSize = new System.Drawing.Size(200, 100);
            this.panelHopDong.MinimumSize = new System.Drawing.Size(200, 40);
            this.panelHopDong.Name = "panelHopDong";
            this.panelHopDong.Size = new System.Drawing.Size(200, 40);
            this.panelHopDong.TabIndex = 3;
            // 
            // btnDanhSachHopDong
            // 
            this.btnDanhSachHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(145)))), ((int)(((byte)(151)))));
            this.btnDanhSachHopDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhSachHopDong.FlatAppearance.BorderSize = 0;
            this.btnDanhSachHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachHopDong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachHopDong.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDanhSachHopDong.Location = new System.Drawing.Point(0, 70);
            this.btnDanhSachHopDong.Name = "btnDanhSachHopDong";
            this.btnDanhSachHopDong.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDanhSachHopDong.Size = new System.Drawing.Size(200, 30);
            this.btnDanhSachHopDong.TabIndex = 3;
            this.btnDanhSachHopDong.Text = "Danh sách";
            this.btnDanhSachHopDong.UseVisualStyleBackColor = false;
            this.btnDanhSachHopDong.Click += new System.EventHandler(this.btnDanhSachHopDong_Click);
            // 
            // btnThemHopDong
            // 
            this.btnThemHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(145)))), ((int)(((byte)(151)))));
            this.btnThemHopDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemHopDong.FlatAppearance.BorderSize = 0;
            this.btnThemHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHopDong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHopDong.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThemHopDong.Location = new System.Drawing.Point(0, 40);
            this.btnThemHopDong.Name = "btnThemHopDong";
            this.btnThemHopDong.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnThemHopDong.Size = new System.Drawing.Size(200, 30);
            this.btnThemHopDong.TabIndex = 2;
            this.btnThemHopDong.Text = "Thêm hợp đồng";
            this.btnThemHopDong.UseVisualStyleBackColor = false;
            this.btnThemHopDong.Click += new System.EventHandler(this.btnThemHopDong_Click);
            // 
            // btnHopDong1
            // 
            this.btnHopDong1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnHopDong1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHopDong1.FlatAppearance.BorderSize = 0;
            this.btnHopDong1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopDong1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDong1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHopDong1.Location = new System.Drawing.Point(0, 0);
            this.btnHopDong1.MaximumSize = new System.Drawing.Size(200, 100);
            this.btnHopDong1.MinimumSize = new System.Drawing.Size(200, 40);
            this.btnHopDong1.Name = "btnHopDong1";
            this.btnHopDong1.Size = new System.Drawing.Size(200, 40);
            this.btnHopDong1.TabIndex = 1;
            this.btnHopDong1.Text = "Hợp đồng";
            this.btnHopDong1.UseVisualStyleBackColor = false;
            this.btnHopDong1.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnDanhMuc.Size = new System.Drawing.Size(200, 50);
            this.btnDanhMuc.TabIndex = 0;
            this.btnDanhMuc.Text = "Danh mục quản lý";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // homeTimer
            // 
            this.homeTimer.Interval = 15;
            this.homeTimer.Tick += new System.EventHandler(this.homeTimer_Tick);
            // 
            // panel_body
            // 
            this.panel_body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_body.BackgroundImage")));
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_body.Controls.Add(this.button14);
            this.panel_body.Controls.Add(this.button13);
            this.panel_body.Controls.Add(this.label1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(53, 38);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1102, 711);
            this.panel_body.TabIndex = 2;
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(102)))), ((int)(((byte)(219)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(582, 454);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(165, 50);
            this.button14.TabIndex = 2;
            this.button14.Text = "Hướng dẫn sử dụng";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(102)))), ((int)(((byte)(219)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.Control;
            this.button13.Location = new System.Drawing.Point(365, 454);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(165, 50);
            this.button13.TabIndex = 1;
            this.button13.Text = "Thông tin phần mềm";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(39)))), ((int)(((byte)(19)))));
            this.label1.Location = new System.Drawing.Point(315, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ CUNG CẤP NƯỚC";
            // 
            // timerHopDong
            // 
            this.timerHopDong.Interval = 15;
            this.timerHopDong.Tick += new System.EventHandler(this.timerHopDong_Tick);
            // 
            // FormMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 749);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(965, 561);
            this.Name = "FormMain2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ CUNG CẤP NƯỚC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain2_FormClosed);
            this.Load += new System.EventHandler(this.FormMain2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelHeThong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelDanhMuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pitureDanhMuc)).EndInit();
            this.panelHopDong.ResumeLayout(false);
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelDanhMuc;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnHopDong1;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Panel panelHeThong;
        private System.Windows.Forms.Button btnCapNhatTaiKhoan;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Timer homeTimer;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btnGhiNuoc;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnXuPhat;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panelHopDong;
        private System.Windows.Forms.Button btnDanhSachHopDong;
        private System.Windows.Forms.Button btnThemHopDong;
        private System.Windows.Forms.Timer timerHopDong;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pitureDanhMuc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btnKho;
    }
}