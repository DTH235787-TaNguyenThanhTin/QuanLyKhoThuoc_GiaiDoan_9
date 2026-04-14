namespace QuanLyKhoThuoc.Forms
{
    partial class frmBanThuoc
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
            groupBox3 = new GroupBox();
            dtpNgayLap = new DateTimePicker();
            label7 = new Label();
            txtTenNV = new TextBox();
            label6 = new Label();
            txtMaHD = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            txtTenKH = new TextBox();
            label2 = new Label();
            btnThemKH = new Button();
            groupBox1 = new GroupBox();
            label15 = new Label();
            txtMaKH = new TextBox();
            txtSDT = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btnHuy = new Button();
            btnThanhToan = new Button();
            btnInHD = new Button();
            btnTaoPhieu = new Button();
            groupBox6 = new GroupBox();
            txtTienThoi = new TextBox();
            label14 = new Label();
            txtTienKhachDua = new TextBox();
            label13 = new Label();
            txtTongTien = new TextBox();
            label12 = new Label();
            groupBox5 = new GroupBox();
            cboTenThuoc = new ComboBox();
            numSoLuong = new NumericUpDown();
            btnThem = new Button();
            txtDonGia = new TextBox();
            label11 = new Label();
            label10 = new Label();
            txtThanhTien = new TextBox();
            label9 = new Label();
            label8 = new Label();
            groupBox4 = new GroupBox();
            dgvDSThuoc = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            TenThuoc = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSThuoc).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpNgayLap);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtTenNV);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtMaHD);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(24, 330);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(787, 105);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin chung";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(521, 58);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(231, 31);
            dtpNgayLap.TabIndex = 15;
            dtpNgayLap.Value = new DateTime(2026, 4, 5, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(521, 30);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 14;
            label7.Text = "Ngày lập";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(253, 58);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(218, 31);
            txtTenNV.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 30);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 12;
            label6.Text = "Nhân viên";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(23, 58);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(179, 31);
            txtMaHD.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 30);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 10;
            label5.Text = "Mã hoá đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(txtTenKH);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnThemKH);
            groupBox2.Location = new Point(24, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(787, 205);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 27);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 9;
            label4.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(293, 59);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(303, 128);
            txtDiaChi.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 101);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 7;
            label3.Text = "Giới tính";
            // 
            // panel4
            // 
            panel4.Controls.Add(rdNu);
            panel4.Controls.Add(rdNam);
            panel4.Location = new Point(6, 129);
            panel4.Name = "panel4";
            panel4.Size = new Size(239, 58);
            panel4.TabIndex = 6;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(124, 14);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(61, 29);
            rdNu.TabIndex = 9;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(13, 14);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(75, 29);
            rdNam.TabIndex = 8;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(6, 59);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(239, 31);
            txtTenKH.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 31);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 4;
            label2.Text = "Tên khách hàng";
            // 
            // btnThemKH
            // 
            btnThemKH.Location = new Point(620, 59);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(132, 128);
            btnThemKH.TabIndex = 0;
            btnThemKH.Text = "Thêm khách hàng";
            btnThemKH.UseVisualStyleBackColor = true;
            btnThemKH.Click += btnThemKH_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(787, 97);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm khách hàng";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(477, 43);
            label15.Name = "label15";
            label15.Size = new Size(133, 25);
            label15.TabIndex = 4;
            label15.Text = "Mã khách hàng";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(620, 40);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(148, 31);
            txtMaKH.TabIndex = 3;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(130, 40);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(202, 31);
            txtSDT.TabIndex = 2;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "Số điện thoại";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(groupBox6);
            panel2.Controls.Add(groupBox5);
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 808);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnHuy);
            panel3.Controls.Add(btnThanhToan);
            panel3.Controls.Add(btnInHD);
            panel3.Controls.Add(btnTaoPhieu);
            panel3.Location = new Point(832, 663);
            panel3.Name = "panel3";
            panel3.Size = new Size(452, 141);
            panel3.TabIndex = 6;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(248, 75);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(130, 52);
            btnHuy.TabIndex = 15;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(248, 17);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(130, 52);
            btnThanhToan.TabIndex = 14;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnInHD
            // 
            btnInHD.Location = new Point(78, 75);
            btnInHD.Name = "btnInHD";
            btnInHD.Size = new Size(130, 52);
            btnInHD.TabIndex = 13;
            btnInHD.Text = "In hoá đơn";
            btnInHD.UseVisualStyleBackColor = true;
            btnInHD.Click += btnInHD_Click;
            // 
            // btnTaoPhieu
            // 
            btnTaoPhieu.Location = new Point(78, 17);
            btnTaoPhieu.Name = "btnTaoPhieu";
            btnTaoPhieu.Size = new Size(130, 52);
            btnTaoPhieu.TabIndex = 12;
            btnTaoPhieu.Text = "Tạo phiếu";
            btnTaoPhieu.UseVisualStyleBackColor = true;
            btnTaoPhieu.Click += btnTaoPhieu_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtTienThoi);
            groupBox6.Controls.Add(label14);
            groupBox6.Controls.Add(txtTienKhachDua);
            groupBox6.Controls.Add(label13);
            groupBox6.Controls.Add(txtTongTien);
            groupBox6.Controls.Add(label12);
            groupBox6.Location = new Point(832, 464);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(452, 187);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Thông tin thanh toán";
            // 
            // txtTienThoi
            // 
            txtTienThoi.Location = new Point(159, 142);
            txtTienThoi.Name = "txtTienThoi";
            txtTienThoi.Size = new Size(287, 31);
            txtTienThoi.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 145);
            label14.Name = "label14";
            label14.Size = new Size(119, 25);
            label14.TabIndex = 16;
            label14.Text = "Thối lại khách";
            // 
            // txtTienKhachDua
            // 
            txtTienKhachDua.Location = new Point(159, 89);
            txtTienKhachDua.Name = "txtTienKhachDua";
            txtTienKhachDua.Size = new Size(287, 31);
            txtTienKhachDua.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 92);
            label13.Name = "label13";
            label13.Size = new Size(131, 25);
            label13.TabIndex = 14;
            label13.Text = "Tiền khách đưa";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(159, 33);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(287, 31);
            txtTongTien.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 36);
            label12.Name = "label12";
            label12.Size = new Size(87, 25);
            label12.TabIndex = 12;
            label12.Text = "Tổng tiền";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cboTenThuoc);
            groupBox5.Controls.Add(numSoLuong);
            groupBox5.Controls.Add(btnThem);
            groupBox5.Controls.Add(txtDonGia);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(txtThanhTien);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label8);
            groupBox5.Location = new Point(832, 16);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(452, 419);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin sản phẩm";
            // 
            // cboTenThuoc
            // 
            cboTenThuoc.FormattingEnabled = true;
            cboTenThuoc.Location = new Point(166, 43);
            cboTenThuoc.Name = "cboTenThuoc";
            cboTenThuoc.Size = new Size(252, 33);
            cboTenThuoc.TabIndex = 12;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(166, 162);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(252, 31);
            numSoLuong.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(223, 274);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(155, 59);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(166, 103);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(252, 31);
            txtDonGia.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 103);
            label11.Name = "label11";
            label11.Size = new Size(75, 25);
            label11.TabIndex = 9;
            label11.Text = "Đơn giá";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 164);
            label10.Name = "label10";
            label10.Size = new Size(85, 25);
            label10.TabIndex = 7;
            label10.Text = "Số lượng";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(166, 223);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(252, 31);
            txtThanhTien.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 229);
            label9.Name = "label9";
            label9.Size = new Size(94, 25);
            label9.TabIndex = 5;
            label9.Text = "Thành tiền";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 43);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 3;
            label8.Text = "Tên thuốc";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvDSThuoc);
            groupBox4.Location = new Point(24, 455);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(787, 349);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách thuốc khách hàng chọn";
            // 
            // dgvDSThuoc
            // 
            dgvDSThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSThuoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDSThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSThuoc.Columns.AddRange(new DataGridViewColumn[] { STT, TenThuoc, SoLuong, DonGia, ThanhTien });
            dgvDSThuoc.Dock = DockStyle.Fill;
            dgvDSThuoc.Location = new Point(3, 27);
            dgvDSThuoc.Name = "dgvDSThuoc";
            dgvDSThuoc.RowHeadersVisible = false;
            dgvDSThuoc.RowHeadersWidth = 62;
            dgvDSThuoc.Size = new Size(781, 319);
            dgvDSThuoc.TabIndex = 0;
            dgvDSThuoc.CellContentClick += dgvDSThuoc_CellClick;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 8;
            STT.Name = "STT";
            // 
            // TenThuoc
            // 
            TenThuoc.DataPropertyName = "_thuocMa";
            TenThuoc.HeaderText = "Tên Thuốc";
            TenThuoc.MinimumWidth = 8;
            TenThuoc.Name = "TenThuoc";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "_soLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "_donGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 8;
            DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "_thanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            // 
            // frmBanThuoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 808);
            Controls.Add(panel2);
            Name = "frmBanThuoc";
            Text = "frmBanThuoc";
            Load += frmBanThuoc_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSThuoc).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn _thanhTien;
        private GroupBox groupBox3;
        private DateTimePicker dtpNgayLap;
        private Label label7;
        private TextBox txtTenNV;
        private Label label6;
        private TextBox txtMaHD;
        private Label label5;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtDiaChi;
        private Label label3;
        private Panel panel4;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private TextBox txtTenKH;
        private Label label2;
        private Button btnThemKH;
        private GroupBox groupBox1;
        private Label label15;
        private TextBox txtMaKH;
        private TextBox txtSDT;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button btnHuy;
        private Button btnThanhToan;
        private Button btnInHD;
        private Button btnTaoPhieu;
        private GroupBox groupBox6;
        private TextBox txtTienThoi;
        private Label label14;
        private TextBox txtTienKhachDua;
        private Label label13;
        private TextBox txtTongTien;
        private Label label12;
        private GroupBox groupBox5;
        private ComboBox cboTenThuoc;
        private NumericUpDown numSoLuong;
        private Button btnThem;
        private TextBox txtDonGia;
        private Label label11;
        private Label label10;
        private TextBox txtThanhTien;
        private Label label9;
        private Label label8;
        private GroupBox groupBox4;
        private DataGridView dgvDSThuoc;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn _soLuong;
        private DataGridViewTextBoxColumn _donGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
    }
}