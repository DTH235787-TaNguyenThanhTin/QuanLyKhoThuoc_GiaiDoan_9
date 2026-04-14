namespace QuanLyKhoThuoc.Forms
{
    partial class frmPhieuNhap
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            cboTimKiemPhieuNhap = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            btnThem = new Button();
            btnXuat = new Button();
            btnHuy = new Button();
            panel3 = new Panel();
            btnLuu = new Button();
            btnInHD = new Button();
            btnXoa = new Button();
            btnTaoPhieu = new Button();
            groupBox4 = new GroupBox();
            numSoLuongNhap = new NumericUpDown();
            dtpHSD = new DateTimePicker();
            txtSoLo = new TextBox();
            cboTenThuoc = new ComboBox();
            label12 = new Label();
            txtMaPhieuNhapCT = new TextBox();
            label11 = new Label();
            label7 = new Label();
            txtDonGiaNhap = new TextBox();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            cboNhaCungCap = new ComboBox();
            cboNhanVien = new ComboBox();
            dtpNgayLap = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTongTien = new TextBox();
            label1 = new Label();
            txtMaHD = new TextBox();
            groupBox3 = new GroupBox();
            dgvChiTietPhieuNhap = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            MaPhieuNhapCT = new DataGridViewTextBoxColumn();
            TenThuoc = new DataGridViewTextBoxColumn();
            SoLo = new DataGridViewTextBoxColumn();
            HSD = new DataGridViewTextBoxColumn();
            SoLuongNhap = new DataGridViewTextBoxColumn();
            DonGiaNhap = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            dgvPhieuNhap = new DataGridView();
            MaPhieuNhap = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            MaNhaCungCap = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongNhap).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuNhap).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cboTimKiemPhieuNhap);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1451, 81);
            panel1.TabIndex = 0;
            // 
            // cboTimKiemPhieuNhap
            // 
            cboTimKiemPhieuNhap.FormattingEnabled = true;
            cboTimKiemPhieuNhap.Location = new Point(548, 24);
            cboTimKiemPhieuNhap.Name = "cboTimKiemPhieuNhap";
            cboTimKiemPhieuNhap.Size = new Size(462, 33);
            cboTimKiemPhieuNhap.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 24);
            label4.Name = "label4";
            label4.Size = new Size(178, 25);
            label4.TabIndex = 15;
            label4.Text = "Tìm kiếm phiếu nhập";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(1451, 876);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnThem);
            panel4.Controls.Add(btnXuat);
            panel4.Controls.Add(btnHuy);
            panel4.Location = new Point(1207, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 298);
            panel4.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(52, 50);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(140, 55);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(52, 211);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(140, 55);
            btnXuat.TabIndex = 16;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(52, 124);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(140, 55);
            btnHuy.TabIndex = 15;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLuu);
            panel3.Controls.Add(btnInHD);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnTaoPhieu);
            panel3.Location = new Point(12, 318);
            panel3.Name = "panel3";
            panel3.Size = new Size(1421, 82);
            panel3.TabIndex = 5;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(578, 18);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(140, 55);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnInHD
            // 
            btnInHD.Location = new Point(1049, 18);
            btnInHD.Name = "btnInHD";
            btnInHD.Size = new Size(140, 55);
            btnInHD.TabIndex = 15;
            btnInHD.Text = "In hoá đơn";
            btnInHD.UseVisualStyleBackColor = true;
            btnInHD.Click += btnInHD_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(830, 18);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(140, 55);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTaoPhieu
            // 
            btnTaoPhieu.Location = new Point(354, 18);
            btnTaoPhieu.Name = "btnTaoPhieu";
            btnTaoPhieu.Size = new Size(140, 55);
            btnTaoPhieu.TabIndex = 13;
            btnTaoPhieu.Text = "Tạo phiếu";
            btnTaoPhieu.UseVisualStyleBackColor = true;
            btnTaoPhieu.Click += btnTaoPhieu_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(numSoLuongNhap);
            groupBox4.Controls.Add(dtpHSD);
            groupBox4.Controls.Add(txtSoLo);
            groupBox4.Controls.Add(cboTenThuoc);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(txtMaPhieuNhapCT);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(txtDonGiaNhap);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(691, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(510, 306);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin thuốc";
            // 
            // numSoLuongNhap
            // 
            numSoLuongNhap.Location = new Point(17, 236);
            numSoLuongNhap.Name = "numSoLuongNhap";
            numSoLuongNhap.Size = new Size(218, 31);
            numSoLuongNhap.TabIndex = 50;
            // 
            // dtpHSD
            // 
            dtpHSD.Format = DateTimePickerFormat.Short;
            dtpHSD.Location = new Point(265, 159);
            dtpHSD.Name = "dtpHSD";
            dtpHSD.Size = new Size(228, 31);
            dtpHSD.TabIndex = 49;
            // 
            // txtSoLo
            // 
            txtSoLo.Location = new Point(19, 162);
            txtSoLo.Name = "txtSoLo";
            txtSoLo.Size = new Size(218, 31);
            txtSoLo.TabIndex = 48;
            // 
            // cboTenThuoc
            // 
            cboTenThuoc.FormattingEnabled = true;
            cboTenThuoc.Location = new Point(265, 89);
            cboTenThuoc.Name = "cboTenThuoc";
            cboTenThuoc.Size = new Size(228, 33);
            cboTenThuoc.TabIndex = 47;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 207);
            label12.Name = "label12";
            label12.Size = new Size(130, 25);
            label12.TabIndex = 46;
            label12.Text = "Số lượng nhập";
            // 
            // txtMaPhieuNhapCT
            // 
            txtMaPhieuNhapCT.Location = new Point(17, 86);
            txtMaPhieuNhapCT.Name = "txtMaPhieuNhapCT";
            txtMaPhieuNhapCT.Size = new Size(218, 31);
            txtMaPhieuNhapCT.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 58);
            label11.Name = "label11";
            label11.Size = new Size(188, 25);
            label11.TabIndex = 37;
            label11.Text = "Mã phiếu nhập chi tiết";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(265, 59);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 42;
            label7.Text = "Tên thuốc";
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new Point(265, 236);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(228, 31);
            txtDonGiaNhap.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(265, 133);
            label8.Name = "label8";
            label8.Size = new Size(48, 25);
            label8.TabIndex = 41;
            label8.Text = "HSD";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(265, 208);
            label10.Name = "label10";
            label10.Size = new Size(120, 25);
            label10.TabIndex = 39;
            label10.Text = "Đơn giá nhập";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 132);
            label9.Name = "label9";
            label9.Size = new Size(53, 25);
            label9.TabIndex = 40;
            label9.Text = "Số lô";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(dtpNgayLap);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaHD);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(662, 306);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(348, 160);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(300, 33);
            cboNhaCungCap.TabIndex = 34;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(6, 160);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(300, 33);
            cboNhanVien.TabIndex = 25;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Short;
            dtpNgayLap.Location = new Point(348, 86);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(300, 31);
            dtpNgayLap.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 58);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 32;
            label6.Text = "Ngày lập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 132);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 31;
            label5.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 132);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 30;
            label3.Text = "Nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 219);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 28;
            label2.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(247, 222);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(246, 31);
            txtTongTien.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 58);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 26;
            label1.Text = "Mã phiếu nhập";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(6, 86);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(300, 31);
            txtMaHD.TabIndex = 24;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvChiTietPhieuNhap);
            groupBox3.Location = new Point(686, 406);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(753, 458);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách phiếu nhập";
            // 
            // dgvChiTietPhieuNhap
            // 
            dgvChiTietPhieuNhap.AllowUserToDeleteRows = false;
            dgvChiTietPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChiTietPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { STT, MaPhieuNhapCT, TenThuoc, SoLo, HSD, SoLuongNhap, DonGiaNhap });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvChiTietPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            dgvChiTietPhieuNhap.Dock = DockStyle.Fill;
            dgvChiTietPhieuNhap.Location = new Point(3, 27);
            dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            dgvChiTietPhieuNhap.ReadOnly = true;
            dgvChiTietPhieuNhap.RowHeadersVisible = false;
            dgvChiTietPhieuNhap.RowHeadersWidth = 62;
            dgvChiTietPhieuNhap.Size = new Size(747, 428);
            dgvChiTietPhieuNhap.TabIndex = 1;
            dgvChiTietPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            // 
            // STT
            // 
            STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            STT.HeaderText = "STT";
            STT.MinimumWidth = 8;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 76;
            // 
            // MaPhieuNhapCT
            // 
            MaPhieuNhapCT.DataPropertyName = "_maPhieuNhapChiTiet";
            MaPhieuNhapCT.HeaderText = "Mã phiếu chi tiết";
            MaPhieuNhapCT.MinimumWidth = 8;
            MaPhieuNhapCT.Name = "MaPhieuNhapCT";
            MaPhieuNhapCT.ReadOnly = true;
            // 
            // TenThuoc
            // 
            TenThuoc.DataPropertyName = "_tenThuoc";
            TenThuoc.HeaderText = "Tên thuốc";
            TenThuoc.MinimumWidth = 8;
            TenThuoc.Name = "TenThuoc";
            TenThuoc.ReadOnly = true;
            // 
            // SoLo
            // 
            SoLo.DataPropertyName = "_soLo";
            SoLo.HeaderText = "Số lô";
            SoLo.MinimumWidth = 8;
            SoLo.Name = "SoLo";
            SoLo.ReadOnly = true;
            // 
            // HSD
            // 
            HSD.DataPropertyName = "_hanSuDung";
            HSD.HeaderText = "HSD";
            HSD.MinimumWidth = 8;
            HSD.Name = "HSD";
            HSD.ReadOnly = true;
            // 
            // SoLuongNhap
            // 
            SoLuongNhap.DataPropertyName = "_soLuongNhap";
            SoLuongNhap.HeaderText = "Số lượng nhập";
            SoLuongNhap.MinimumWidth = 8;
            SoLuongNhap.Name = "SoLuongNhap";
            SoLuongNhap.ReadOnly = true;
            // 
            // DonGiaNhap
            // 
            DonGiaNhap.DataPropertyName = "_donGiaNhap";
            DonGiaNhap.HeaderText = "Đơn giá nhập";
            DonGiaNhap.MinimumWidth = 8;
            DonGiaNhap.Name = "DonGiaNhap";
            DonGiaNhap.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvPhieuNhap);
            groupBox2.Location = new Point(3, 406);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(677, 458);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phiếu nhập";
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToDeleteRows = false;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { MaPhieuNhap, MaNhanVien, MaNhaCungCap, NgayNhap, TongTien });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPhieuNhap.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPhieuNhap.Dock = DockStyle.Fill;
            dgvPhieuNhap.Location = new Point(3, 27);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.ReadOnly = true;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidth = 62;
            dgvPhieuNhap.Size = new Size(671, 428);
            dgvPhieuNhap.TabIndex = 1;
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            // 
            // MaPhieuNhap
            // 
            MaPhieuNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaPhieuNhap.DataPropertyName = "_maPhieuNhap";
            MaPhieuNhap.HeaderText = "Mã phiếu nhập";
            MaPhieuNhap.MinimumWidth = 8;
            MaPhieuNhap.Name = "MaPhieuNhap";
            MaPhieuNhap.ReadOnly = true;
            MaPhieuNhap.Width = 167;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "_maNhanVien";
            MaNhanVien.HeaderText = "Nhân viên";
            MaNhanVien.MinimumWidth = 8;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // MaNhaCungCap
            // 
            MaNhaCungCap.DataPropertyName = "_maNhaCungCap";
            MaNhaCungCap.HeaderText = "Nhà cung cấp";
            MaNhaCungCap.MinimumWidth = 8;
            MaNhaCungCap.Name = "MaNhaCungCap";
            MaNhaCungCap.ReadOnly = true;
            // 
            // NgayNhap
            // 
            NgayNhap.DataPropertyName = "_ngayNhap";
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 8;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "_tongTien";
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 8;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 957);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            MinimizeBox = false;
            Name = "frmPhieuNhap";
            Text = "Phiếu nhập";
            Load += frmPhieuNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongNhap).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuNhap).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox2;
        private DataGridView dgvPhieuNhap;
        private GroupBox groupBox3;
        private DataGridView dgvChiTietPhieuNhap;
        private ComboBox cboTimKiemPhieuNhap;
        private Label label4;
        private GroupBox groupBox4;
        private GroupBox groupBox1;
       
        private TextBox txtMaPhieuNhapCT;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private Label label7;
        private TextBox txtDonGiaNhap;
        private Label label8;
        private Label label10;
        private Label label9;
        private ComboBox cboNhaCungCap;
        private ComboBox cboNhanVien;
        private DateTimePicker dtpNgayLap;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtTongTien;
        private Label label1;
        private TextBox txtMaHD;
        private NumericUpDown numSoLuongNhap;
        private DateTimePicker dtpHSD;
        private TextBox txtSoLo;
        private ComboBox cboTenThuoc;
        private Label label12;
        private Panel panel3;
        private Button btnLuu;
        private Button btnInHD;
        private Button btnXoa;
        private Button btnTaoPhieu;
        private Panel panel4;
        private Button btnThem;
        private Button btnXuat;
        private Button btnHuy;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MaPhieuNhapCT;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn SoLo;
        private DataGridViewTextBoxColumn HSD;
        private DataGridViewTextBoxColumn SoLuongNhap;
        private DataGridViewTextBoxColumn DonGiaNhap;
        private DataGridViewTextBoxColumn MaPhieuNhap;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn MaNhaCungCap;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn TongTien;
    }
}