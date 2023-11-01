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
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeThong = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.panelDanhMuc = new System.Windows.Forms.Panel();
            this.btnQuanLyHopDong = new System.Windows.Forms.Button();
            this.btnQuanLyDongHo = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.homeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel_body = new System.Windows.Forms.Panel();
            this.btnQuanLyKhachHang = new System.Windows.Forms.Button();
            this.btnLoaiKhachHang = new System.Windows.Forms.Button();
            this.btnTieuThu = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnXuPhat = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelHeThong.SuspendLayout();
            this.panelDanhMuc.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(3, 6);
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
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(200, 668);
            this.panelMain.TabIndex = 1;
            // 
            // panelHeThong
            // 
            this.panelHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.panelHeThong.Controls.Add(this.button12);
            this.panelHeThong.Controls.Add(this.button11);
            this.panelHeThong.Controls.Add(this.button5);
            this.panelHeThong.Controls.Add(this.button6);
            this.panelHeThong.Controls.Add(this.button7);
            this.panelHeThong.Controls.Add(this.btnHeThong);
            this.panelHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeThong.Location = new System.Drawing.Point(0, 410);
            this.panelHeThong.MaximumSize = new System.Drawing.Size(200, 250);
            this.panelHeThong.MinimumSize = new System.Drawing.Size(200, 50);
            this.panelHeThong.Name = "panelHeThong";
            this.panelHeThong.Size = new System.Drawing.Size(200, 250);
            this.panelHeThong.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(0, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 40);
            this.button5.TabIndex = 3;
            this.button5.Text = "Thay đổi mật khẩu";
            this.button5.UseVisualStyleBackColor = false;
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
            this.panelDanhMuc.Controls.Add(this.button10);
            this.panelDanhMuc.Controls.Add(this.btnXuPhat);
            this.panelDanhMuc.Controls.Add(this.btnHoaDon);
            this.panelDanhMuc.Controls.Add(this.btnTieuThu);
            this.panelDanhMuc.Controls.Add(this.btnLoaiKhachHang);
            this.panelDanhMuc.Controls.Add(this.btnQuanLyKhachHang);
            this.panelDanhMuc.Controls.Add(this.btnQuanLyHopDong);
            this.panelDanhMuc.Controls.Add(this.btnQuanLyDongHo);
            this.panelDanhMuc.Controls.Add(this.btnQuanLyNhanVien);
            this.panelDanhMuc.Controls.Add(this.btnDanhMuc);
            this.panelDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.panelDanhMuc.MaximumSize = new System.Drawing.Size(200, 410);
            this.panelDanhMuc.MinimumSize = new System.Drawing.Size(200, 50);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(200, 410);
            this.panelDanhMuc.TabIndex = 2;
            // 
            // btnQuanLyHopDong
            // 
            this.btnQuanLyHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnQuanLyHopDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyHopDong.FlatAppearance.BorderSize = 0;
            this.btnQuanLyHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyHopDong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyHopDong.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuanLyHopDong.Location = new System.Drawing.Point(0, 130);
            this.btnQuanLyHopDong.Name = "btnQuanLyHopDong";
            this.btnQuanLyHopDong.Size = new System.Drawing.Size(200, 40);
            this.btnQuanLyHopDong.TabIndex = 3;
            this.btnQuanLyHopDong.Text = "Hợp đồng";
            this.btnQuanLyHopDong.UseVisualStyleBackColor = false;
            this.btnQuanLyHopDong.Click += new System.EventHandler(this.btnQuanLyHopDong_Click);
            // 
            // btnQuanLyDongHo
            // 
            this.btnQuanLyDongHo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnQuanLyDongHo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyDongHo.FlatAppearance.BorderSize = 0;
            this.btnQuanLyDongHo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyDongHo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDongHo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuanLyDongHo.Location = new System.Drawing.Point(0, 90);
            this.btnQuanLyDongHo.Name = "btnQuanLyDongHo";
            this.btnQuanLyDongHo.Size = new System.Drawing.Size(200, 40);
            this.btnQuanLyDongHo.TabIndex = 2;
            this.btnQuanLyDongHo.Text = "Đồng hồ";
            this.btnQuanLyDongHo.UseVisualStyleBackColor = false;
            this.btnQuanLyDongHo.Click += new System.EventHandler(this.btnQuanLyDongHo_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnQuanLyNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNhanVien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(0, 50);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(200, 40);
            this.btnQuanLyNhanVien.TabIndex = 1;
            this.btnQuanLyNhanVien.Text = "Nhân viên";
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
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
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // homeTimer
            // 
            this.homeTimer.Interval = 20;
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
            this.panel_body.Location = new System.Drawing.Point(200, 38);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(764, 668);
            this.panel_body.TabIndex = 2;
            // 
            // btnQuanLyKhachHang
            // 
            this.btnQuanLyKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnQuanLyKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyKhachHang.FlatAppearance.BorderSize = 0;
            this.btnQuanLyKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyKhachHang.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKhachHang.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuanLyKhachHang.Location = new System.Drawing.Point(0, 170);
            this.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            this.btnQuanLyKhachHang.Size = new System.Drawing.Size(200, 40);
            this.btnQuanLyKhachHang.TabIndex = 4;
            this.btnQuanLyKhachHang.Text = "Khách hàng";
            this.btnQuanLyKhachHang.UseVisualStyleBackColor = false;
            this.btnQuanLyKhachHang.Click += new System.EventHandler(this.btnQuanLyKhachHang_Click);
            // 
            // btnLoaiKhachHang
            // 
            this.btnLoaiKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnLoaiKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoaiKhachHang.FlatAppearance.BorderSize = 0;
            this.btnLoaiKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiKhachHang.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiKhachHang.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoaiKhachHang.Location = new System.Drawing.Point(0, 210);
            this.btnLoaiKhachHang.Name = "btnLoaiKhachHang";
            this.btnLoaiKhachHang.Size = new System.Drawing.Size(200, 40);
            this.btnLoaiKhachHang.TabIndex = 5;
            this.btnLoaiKhachHang.Text = "Loại khách hàng";
            this.btnLoaiKhachHang.UseVisualStyleBackColor = false;
            this.btnLoaiKhachHang.Click += new System.EventHandler(this.btnLoaiKhachHang_Click);
            // 
            // btnTieuThu
            // 
            this.btnTieuThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnTieuThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTieuThu.FlatAppearance.BorderSize = 0;
            this.btnTieuThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTieuThu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTieuThu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTieuThu.Location = new System.Drawing.Point(0, 250);
            this.btnTieuThu.Name = "btnTieuThu";
            this.btnTieuThu.Size = new System.Drawing.Size(200, 40);
            this.btnTieuThu.TabIndex = 6;
            this.btnTieuThu.Text = "Tiêu thụ";
            this.btnTieuThu.UseVisualStyleBackColor = false;
            this.btnTieuThu.Click += new System.EventHandler(this.btnTieuThu_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 290);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(200, 40);
            this.btnHoaDon.TabIndex = 7;
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
            this.btnXuPhat.Location = new System.Drawing.Point(0, 330);
            this.btnXuPhat.Name = "btnXuPhat";
            this.btnXuPhat.Size = new System.Drawing.Size(200, 40);
            this.btnXuPhat.TabIndex = 8;
            this.btnXuPhat.Text = "Xử phạt";
            this.btnXuPhat.UseVisualStyleBackColor = false;
            this.btnXuPhat.Click += new System.EventHandler(this.btnXuPhat_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.Control;
            this.button10.Location = new System.Drawing.Point(0, 370);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(200, 40);
            this.button10.TabIndex = 9;
            this.button10.Text = "...";
            this.button10.UseVisualStyleBackColor = false;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(39)))), ((int)(((byte)(19)))));
            this.label1.Location = new System.Drawing.Point(174, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ CUNG CẤP NƯỚC";
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(102)))), ((int)(((byte)(219)))));
            this.button13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.Control;
            this.button13.Location = new System.Drawing.Point(196, 433);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(165, 50);
            this.button13.TabIndex = 1;
            this.button13.Text = "Thông tin phần mềm";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(102)))), ((int)(((byte)(219)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(413, 433);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(165, 50);
            this.button14.TabIndex = 2;
            this.button14.Text = "Hướng dẫn sử dụng";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // FormMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 706);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(965, 561);
            this.Name = "FormMain2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain2_FormClosed);
            this.Load += new System.EventHandler(this.FormMain2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelHeThong.ResumeLayout(false);
            this.panelDanhMuc.ResumeLayout(false);
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelDanhMuc;
        private System.Windows.Forms.Button btnQuanLyHopDong;
        private System.Windows.Forms.Button btnQuanLyDongHo;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Panel panelHeThong;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Timer homeTimer;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnXuPhat;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnTieuThu;
        private System.Windows.Forms.Button btnLoaiKhachHang;
        private System.Windows.Forms.Button btnQuanLyKhachHang;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
    }
}