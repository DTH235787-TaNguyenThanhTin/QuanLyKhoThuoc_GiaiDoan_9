namespace QuanLyKhoThuoc.Forms
{
    partial class frmHoaDon
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
            label4 = new Label();
            btnInHD = new Button();
            panel3 = new Panel();
            btnXuat = new Button();
            groupBox4 = new GroupBox();
            dgvHoaDon = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            MaHD = new DataGridViewTextBoxColumn();
            KhachHang = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            txtNgayLap = new TextBox();
            dgvChiTietHoaDon = new DataGridView();
            STTCT = new DataGridViewTextBoxColumn();
            TenThuoc = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtKH = new TextBox();
            label2 = new Label();
            txtTongTien = new TextBox();
            cboNhanVien = new ComboBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            panel1 = new Panel();
            cboTimKiemHoaDon = new ComboBox();
            txtMaHD = new TextBox();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 12);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 13;
            label4.Text = "Tìm kiếm hoá đơn";
            // 
            // btnInHD
            // 
            btnInHD.Location = new Point(542, 14);
            btnInHD.Name = "btnInHD";
            btnInHD.Size = new Size(140, 55);
            btnInHD.TabIndex = 15;
            btnInHD.Text = "In hoá đơn";
            btnInHD.UseVisualStyleBackColor = true;
            btnInHD.Click += btnInHD_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnInHD);
            panel3.Controls.Add(btnXuat);
            panel3.Location = new Point(12, 383);
            panel3.Name = "panel3";
            panel3.Size = new Size(1363, 91);
            panel3.TabIndex = 4;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(733, 14);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(140, 55);
            btnXuat.TabIndex = 14;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvHoaDon);
            groupBox4.Location = new Point(12, 495);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(739, 380);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách hoá đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { STT, MaHD, KhachHang, NhanVien, NgayLap, TongTien });
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(3, 27);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 62;
            dgvHoaDon.Size = new Size(733, 350);
            dgvHoaDon.TabIndex = 1;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // STT
            // 
            STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            STT.DataPropertyName = "STT";
            STT.HeaderText = "STT";
            STT.MinimumWidth = 8;
            STT.Name = "STT";
            STT.Width = 76;
            // 
            // MaHD
            // 
            MaHD.DataPropertyName = "MaHD";
            MaHD.HeaderText = "Mã hoá đơn";
            MaHD.MinimumWidth = 8;
            MaHD.Name = "MaHD";
            // 
            // KhachHang
            // 
            KhachHang.DataPropertyName = "KhachHang";
            KhachHang.HeaderText = "Khách hàng";
            KhachHang.MinimumWidth = 8;
            KhachHang.Name = "KhachHang";
            // 
            // NhanVien
            // 
            NhanVien.DataPropertyName = "NhanVien";
            NhanVien.HeaderText = "Nhân viên";
            NhanVien.MinimumWidth = 8;
            NhanVien.Name = "NhanVien";
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 8;
            NgayLap.Name = "NgayLap";
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 8;
            TongTien.Name = "TongTien";
            // 
            // txtNgayLap
            // 
            txtNgayLap.Location = new Point(394, 69);
            txtNgayLap.Name = "txtNgayLap";
            txtNgayLap.Size = new Size(300, 31);
            txtNgayLap.TabIndex = 23;
            // 
            // dgvChiTietHoaDon
            // 
            dgvChiTietHoaDon.AllowUserToAddRows = false;
            dgvChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHoaDon.Columns.AddRange(new DataGridViewColumn[] { STTCT, TenThuoc, SoLuong, DonGia, ThanhTien });
            dgvChiTietHoaDon.Dock = DockStyle.Fill;
            dgvChiTietHoaDon.Location = new Point(3, 27);
            dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            dgvChiTietHoaDon.RowHeadersVisible = false;
            dgvChiTietHoaDon.RowHeadersWidth = 62;
            dgvChiTietHoaDon.Size = new Size(647, 350);
            dgvChiTietHoaDon.TabIndex = 1;
            // 
            // STTCT
            // 
            STTCT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            STTCT.HeaderText = "STT";
            STTCT.MinimumWidth = 8;
            STTCT.Name = "STTCT";
            STTCT.Width = 76;
            // 
            // TenThuoc
            // 
            TenThuoc.DataPropertyName = "TenThuoc";
            TenThuoc.HeaderText = "Tên thuốc";
            TenThuoc.MinimumWidth = 8;
            TenThuoc.Name = "TenThuoc";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 8;
            DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 41);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 22;
            label6.Text = "Ngày lập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(394, 115);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 21;
            label5.Text = "Nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 115);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 17;
            label3.Text = "Khách hàng";
            // 
            // txtKH
            // 
            txtKH.Location = new Point(52, 143);
            txtKH.Name = "txtKH";
            txtKH.Size = new Size(274, 31);
            txtKH.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 220);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 15;
            label2.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(308, 223);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(246, 31);
            txtTongTien.TabIndex = 14;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(394, 143);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(300, 33);
            cboNhanVien.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvChiTietHoaDon);
            groupBox3.Location = new Point(754, 495);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(653, 380);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách chi tiết hoá đơn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 41);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 13;
            label1.Text = "Mã hoá đơn";
            // 
            // panel1
            // 
            panel1.Controls.Add(cboTimKiemHoaDon);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1428, 67);
            panel1.TabIndex = 6;
            // 
            // cboTimKiemHoaDon
            // 
            cboTimKiemHoaDon.FormattingEnabled = true;
            cboTimKiemHoaDon.Location = new Point(454, 12);
            cboTimKiemHoaDon.Name = "cboTimKiemHoaDon";
            cboTimKiemHoaDon.Size = new Size(462, 33);
            cboTimKiemHoaDon.TabIndex = 14;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(52, 69);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(274, 31);
            txtMaHD.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNgayLap);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtKH);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaHD);
            groupBox1.Location = new Point(331, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 295);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1428, 891);
            panel2.TabIndex = 7;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 891);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmHoaDon";
            Text = "frmHoaDon";
            Load += frmHoaDon_Load;
            panel3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
            groupBox3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Button btnInHD;
        private Panel panel3;
        private Button btnXuat;
        private GroupBox groupBox4;
        private DataGridView dgvHoaDon;
        private TextBox txtNgayLap;
        private DataGridView dgvChiTietHoaDon;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txtKH;
        private Label label2;
        private TextBox txtTongTien;
        private ComboBox cboNhanVien;
        private GroupBox groupBox3;
        private Label label1;
        private Panel panel1;
        private ComboBox cboTimKiemHoaDon;
        private TextBox txtMaHD;
        private GroupBox groupBox1;
        private Panel panel2;
        private DataGridViewTextBoxColumn STTCT;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTien;
    }
}