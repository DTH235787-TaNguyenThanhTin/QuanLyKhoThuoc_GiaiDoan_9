namespace QuanLyKhoThuoc.Forms
{
    partial class frmLoThuoc
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnTimKiem = new Button();
            cboMaLoThuoc = new ComboBox();
            txtSoLo = new TextBox();
            label6 = new Label();
            cboMaThuocTiemKiem = new ComboBox();
            dtpHSD = new DateTimePicker();
            txtDonGia = new TextBox();
            label5 = new Label();
            txtSoLuongTon = new TextBox();
            label1 = new Label();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            btnThem = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dgvLoThuoc = new DataGridView();
            MaLoThuoc = new DataGridViewTextBoxColumn();
            MaThuoc = new DataGridViewTextBoxColumn();
            SoLo = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HanSuDung = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoThuoc).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 288);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(cboMaLoThuoc);
            groupBox1.Controls.Add(txtSoLo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboMaThuocTiemKiem);
            groupBox1.Controls.Add(dtpHSD);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSoLuongTon);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1191, 288);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lô thuốc";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1059, 171);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 75;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(807, 72);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 34);
            btnTimKiem.TabIndex = 74;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cboMaLoThuoc
            // 
            cboMaLoThuoc.FormattingEnabled = true;
            cboMaLoThuoc.Location = new Point(172, 75);
            cboMaLoThuoc.Name = "cboMaLoThuoc";
            cboMaLoThuoc.Size = new Size(242, 33);
            cboMaLoThuoc.TabIndex = 73;
            // 
            // txtSoLo
            // 
            txtSoLo.Location = new Point(172, 124);
            txtSoLo.Name = "txtSoLo";
            txtSoLo.Size = new Size(242, 31);
            txtSoLo.TabIndex = 72;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(452, 83);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 71;
            label6.Text = "Mã thuốc";
            // 
            // cboMaThuocTiemKiem
            // 
            cboMaThuocTiemKiem.FormattingEnabled = true;
            cboMaThuocTiemKiem.Location = new Point(557, 75);
            cboMaThuocTiemKiem.Name = "cboMaThuocTiemKiem";
            cboMaThuocTiemKiem.Size = new Size(228, 33);
            cboMaThuocTiemKiem.TabIndex = 70;
            // 
            // dtpHSD
            // 
            dtpHSD.Format = DateTimePickerFormat.Short;
            dtpHSD.Location = new Point(172, 174);
            dtpHSD.Name = "dtpHSD";
            dtpHSD.Size = new Size(242, 31);
            dtpHSD.TabIndex = 69;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(557, 128);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(228, 31);
            txtDonGia.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(452, 131);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 68;
            label5.Text = "Đơn giá : ";
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.Location = new Point(557, 178);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.Size = new Size(228, 31);
            txtSoLuongTon.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 181);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 66;
            label1.Text = "Số lượng tồn : ";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(1059, 122);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 56;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(933, 122);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 63;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(807, 174);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 62;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(933, 174);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 61;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(807, 122);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 60;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 179);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 59;
            label4.Text = "Hạn sử dụng :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 128);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 58;
            label3.Text = "Số lô thuốc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 81);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 57;
            label2.Text = "Mã lô thuốc (*) :";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 288);
            panel2.Name = "panel2";
            panel2.Size = new Size(1191, 395);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvLoThuoc);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1191, 395);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách lô thuốc";
            // 
            // dgvLoThuoc
            // 
            dgvLoThuoc.AllowUserToAddRows = false;
            dgvLoThuoc.AllowUserToDeleteRows = false;
            dgvLoThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLoThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLoThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoThuoc.Columns.AddRange(new DataGridViewColumn[] { MaLoThuoc, MaThuoc, SoLo, DonGia, HanSuDung, SoLuongTon });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLoThuoc.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLoThuoc.Dock = DockStyle.Fill;
            dgvLoThuoc.Location = new Point(3, 27);
            dgvLoThuoc.Name = "dgvLoThuoc";
            dgvLoThuoc.RowHeadersWidth = 62;
            dgvLoThuoc.Size = new Size(1185, 365);
            dgvLoThuoc.TabIndex = 2;
            dgvLoThuoc.CellClick += dgvLoThuoc_CellClick;
            // 
            // MaLoThuoc
            // 
            MaLoThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaLoThuoc.DataPropertyName = "_maLoThuoc";
            MaLoThuoc.HeaderText = "Mã lô thuốc";
            MaLoThuoc.MinimumWidth = 8;
            MaLoThuoc.Name = "MaLoThuoc";
            MaLoThuoc.Width = 143;
            // 
            // MaThuoc
            // 
            MaThuoc.DataPropertyName = "_thuocMa";
            MaThuoc.HeaderText = "Mã thuốc";
            MaThuoc.MinimumWidth = 8;
            MaThuoc.Name = "MaThuoc";
            // 
            // SoLo
            // 
            SoLo.DataPropertyName = "_soLo";
            SoLo.HeaderText = "Số lô";
            SoLo.MinimumWidth = 8;
            SoLo.Name = "SoLo";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "_donGiaBan";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 8;
            DonGia.Name = "DonGia";
            // 
            // HanSuDung
            // 
            HanSuDung.DataPropertyName = "_hanSuDung";
            HanSuDung.HeaderText = "HSD";
            HanSuDung.MinimumWidth = 8;
            HanSuDung.Name = "HanSuDung";
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "_soLuongTon";
            SoLuongTon.HeaderText = "Số Lượng Tồn";
            SoLuongTon.MinimumWidth = 8;
            SoLuongTon.Name = "SoLuongTon";
            // 
            // frmLoThuoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 683);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "frmLoThuoc";
            Text = "Lô thuốc";
            Load += frmLoThuoc_Load;
            KeyDown += frmLoThuoc_KeyDown;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoThuoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvLoThuoc;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnThem;
        private TextBox txtGhiChu;
        private Label label4;
        private TextBox txtTenKho;
        private Label label3;
        private Label label2;
        private TextBox txtDonGia;
        private Label label5;
        private TextBox txtSoLuongTon;
        private Label label1;
        private Label label6;
        private ComboBox cboMaThuocTiemKiem;
        private DateTimePicker dtpHSD;
        private DataGridViewTextBoxColumn MaLoThuoc;
        private DataGridViewTextBoxColumn MaThuoc;
        private DataGridViewTextBoxColumn SoLo;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn HanSuDung;
        private DataGridViewTextBoxColumn SoLuongTon;
        private TextBox txtSoLo;
        private ComboBox cboMaLoThuoc;
        private Button btnTimKiem;
        private Button btnThoat;
    }
}