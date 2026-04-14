namespace QuanLyKhoThuoc.Forms
{
    partial class frmMain
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
            panelSidebar = new Panel();
            btnDoanhThu = new Button();
            btnNhatKy = new Button();
            btnGiaoDien = new Button();
            btnDangXuat = new Button();
            btnNhaCunhCap = new Button();
            btnLoaiThuoc = new Button();
            btnThuoc = new Button();
            btnBanThuoc = new Button();
            btnHoaDon = new Button();
            btnNhanVien = new Button();
            btnKhachHang = new Button();
            btnPhieuNhap = new Button();
            panelHeader = new Panel();
            lblTitle = new Label();
            panelContent = new Panel();
            panelSidebar.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = SystemColors.Highlight;
            panelSidebar.Controls.Add(btnDoanhThu);
            panelSidebar.Controls.Add(btnNhatKy);
            panelSidebar.Controls.Add(btnGiaoDien);
            panelSidebar.Controls.Add(btnDangXuat);
            panelSidebar.Controls.Add(btnNhaCunhCap);
            panelSidebar.Controls.Add(btnLoaiThuoc);
            panelSidebar.Controls.Add(btnThuoc);
            panelSidebar.Controls.Add(btnBanThuoc);
            panelSidebar.Controls.Add(btnHoaDon);
            panelSidebar.Controls.Add(btnNhanVien);
            panelSidebar.Controls.Add(btnKhachHang);
            panelSidebar.Controls.Add(btnPhieuNhap);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(294, 702);
            panelSidebar.TabIndex = 0;
            // 
            // btnDoanhThu
            // 
            btnDoanhThu.Dock = DockStyle.Top;
            btnDoanhThu.FlatAppearance.BorderSize = 0;
            btnDoanhThu.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnDoanhThu.FlatStyle = FlatStyle.Flat;
            btnDoanhThu.Location = new Point(0, 560);
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.Size = new Size(294, 56);
            btnDoanhThu.TabIndex = 12;
            btnDoanhThu.Text = "Thống kê doanh thu";
            btnDoanhThu.UseVisualStyleBackColor = true;
            btnDoanhThu.Click += btnDoanhThu_Click;
            // 
            // btnNhatKy
            // 
            btnNhatKy.Dock = DockStyle.Top;
            btnNhatKy.FlatAppearance.BorderSize = 0;
            btnNhatKy.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnNhatKy.FlatStyle = FlatStyle.Flat;
            btnNhatKy.Location = new Point(0, 504);
            btnNhatKy.Name = "btnNhatKy";
            btnNhatKy.Size = new Size(294, 56);
            btnNhatKy.TabIndex = 11;
            btnNhatKy.Text = "Nhật ký đăng nhập";
            btnNhatKy.UseVisualStyleBackColor = true;
            btnNhatKy.Click += btnNhatKy_Click;
            // 
            // btnGiaoDien
            // 
            btnGiaoDien.Dock = DockStyle.Top;
            btnGiaoDien.FlatAppearance.BorderSize = 0;
            btnGiaoDien.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnGiaoDien.FlatStyle = FlatStyle.Flat;
            btnGiaoDien.Location = new Point(0, 448);
            btnGiaoDien.Name = "btnGiaoDien";
            btnGiaoDien.Size = new Size(294, 56);
            btnGiaoDien.TabIndex = 10;
            btnGiaoDien.Text = "Cài đặt giao diện";
            btnGiaoDien.UseVisualStyleBackColor = true;
            btnGiaoDien.Click += btnGiaoDien_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Location = new Point(0, 646);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(294, 56);
            btnDangXuat.TabIndex = 9;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnNhaCunhCap
            // 
            btnNhaCunhCap.Dock = DockStyle.Top;
            btnNhaCunhCap.FlatAppearance.BorderSize = 0;
            btnNhaCunhCap.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnNhaCunhCap.FlatStyle = FlatStyle.Flat;
            btnNhaCunhCap.Location = new Point(0, 392);
            btnNhaCunhCap.Name = "btnNhaCunhCap";
            btnNhaCunhCap.Size = new Size(294, 56);
            btnNhaCunhCap.TabIndex = 8;
            btnNhaCunhCap.Text = "Nhà cung cấp";
            btnNhaCunhCap.UseVisualStyleBackColor = true;
            btnNhaCunhCap.Click += btnNhaCunhCap_Click;
            // 
            // btnLoaiThuoc
            // 
            btnLoaiThuoc.Dock = DockStyle.Top;
            btnLoaiThuoc.FlatAppearance.BorderSize = 0;
            btnLoaiThuoc.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnLoaiThuoc.FlatStyle = FlatStyle.Flat;
            btnLoaiThuoc.Location = new Point(0, 336);
            btnLoaiThuoc.Name = "btnLoaiThuoc";
            btnLoaiThuoc.Size = new Size(294, 56);
            btnLoaiThuoc.TabIndex = 7;
            btnLoaiThuoc.Text = "Loại thuốc";
            btnLoaiThuoc.UseVisualStyleBackColor = true;
            btnLoaiThuoc.Click += btnLoaiThuoc_Click;
            // 
            // btnThuoc
            // 
            btnThuoc.Dock = DockStyle.Top;
            btnThuoc.FlatAppearance.BorderSize = 0;
            btnThuoc.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnThuoc.FlatStyle = FlatStyle.Flat;
            btnThuoc.Location = new Point(0, 280);
            btnThuoc.Name = "btnThuoc";
            btnThuoc.Size = new Size(294, 56);
            btnThuoc.TabIndex = 5;
            btnThuoc.Text = "Thuốc";
            btnThuoc.UseVisualStyleBackColor = true;
            btnThuoc.Click += btnThuoc_Click;
            // 
            // btnBanThuoc
            // 
            btnBanThuoc.Dock = DockStyle.Top;
            btnBanThuoc.FlatAppearance.BorderSize = 0;
            btnBanThuoc.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnBanThuoc.FlatStyle = FlatStyle.Flat;
            btnBanThuoc.Location = new Point(0, 224);
            btnBanThuoc.Name = "btnBanThuoc";
            btnBanThuoc.Size = new Size(294, 56);
            btnBanThuoc.TabIndex = 3;
            btnBanThuoc.Text = "Bán thuốc";
            btnBanThuoc.UseVisualStyleBackColor = true;
            btnBanThuoc.Click += btnBanThuoc_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Location = new Point(0, 168);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(294, 56);
            btnHoaDon.TabIndex = 2;
            btnHoaDon.Text = "Quản lý hoá đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(0, 112);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(294, 56);
            btnNhanVien.TabIndex = 1;
            btnNhanVien.Text = "Quản lý nhân viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Location = new Point(0, 56);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(294, 56);
            btnKhachHang.TabIndex = 0;
            btnKhachHang.Text = "Quản lý khách hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnPhieuNhap
            // 
            btnPhieuNhap.Dock = DockStyle.Top;
            btnPhieuNhap.FlatAppearance.BorderSize = 0;
            btnPhieuNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnPhieuNhap.FlatStyle = FlatStyle.Flat;
            btnPhieuNhap.Location = new Point(0, 0);
            btnPhieuNhap.Name = "btnPhieuNhap";
            btnPhieuNhap.Size = new Size(294, 56);
            btnPhieuNhap.TabIndex = 4;
            btnPhieuNhap.Text = "Quản lý phiếu nhập";
            btnPhieuNhap.UseVisualStyleBackColor = true;
            btnPhieuNhap.Click += btnPhieuNhap_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ActiveCaption;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(294, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(988, 106);
            panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(284, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ KHO THUỐC";
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.InactiveCaption;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(294, 106);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(988, 596);
            panelContent.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 702);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Name = "frmMain";
            Text = "frmMain";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            panelSidebar.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelHeader;
        private Panel panelContent;
        private Button btnKhachHang;
        private Button btnNhaCunhCap;
        private Button btnLoaiThuoc;
        private Button btnThuoc;
        private Button btnBanThuoc;
        private Button btnHoaDon;
        private Button btnNhanVien;
        private Button btnPhieuNhap;
        private Label lblTitle;
        private Button btnDangXuat;
        private Button btnGiaoDien;
        private Button btnNhatKy;
        private Button btnDoanhThu;
    }
}