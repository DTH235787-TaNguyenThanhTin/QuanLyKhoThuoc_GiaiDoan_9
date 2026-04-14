namespace QuanLyKhoThuoc.Forms
{
    partial class frmThuoc
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
            btnDoiAnh = new Button();
            label5 = new Label();
            txtMoTa = new TextBox();
            btnLuu = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            btnThem = new Button();
            cboDonVi = new ComboBox();
            txtTenThuoc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            picAnhThuoc = new PictureBox();
            txtMaThuoc = new TextBox();
            cboMaLoaiThuoc = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dgvThuoc = new DataGridView();
            MaThuoc = new DataGridViewTextBoxColumn();
            MaLoaiThuoc = new DataGridViewTextBoxColumn();
            TenThuoc = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhThuoc).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThuoc).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 308);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboDonVi);
            groupBox1.Controls.Add(txtTenThuoc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(picAnhThuoc);
            groupBox1.Controls.Add(txtMaThuoc);
            groupBox1.Controls.Add(cboMaLoaiThuoc);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1058, 308);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thuốc";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(871, 30);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(112, 34);
            btnDoiAnh.TabIndex = 5;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 227);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 45;
            label5.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(135, 224);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(506, 31);
            txtMoTa.TabIndex = 4;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(940, 192);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(940, 244);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 43;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(814, 192);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 42;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(688, 244);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 41;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(814, 244);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 40;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(688, 192);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 39;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboDonVi
            // 
            cboDonVi.FormattingEnabled = true;
            cboDonVi.Location = new Point(135, 168);
            cboDonVi.Name = "cboDonVi";
            cboDonVi.Size = new Size(506, 33);
            cboDonVi.TabIndex = 3;
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Location = new Point(135, 110);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.Size = new Size(506, 31);
            txtTenThuoc.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 113);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 6;
            label4.Text = "Tên thuốc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 173);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 5;
            label3.Text = "Đơn vị";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 59);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 4;
            label2.Text = "Mã loại thuốc";
            // 
            // picAnhThuoc
            // 
            picAnhThuoc.Location = new Point(688, 26);
            picAnhThuoc.Name = "picAnhThuoc";
            picAnhThuoc.Size = new Size(160, 160);
            picAnhThuoc.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhThuoc.TabIndex = 3;
            picAnhThuoc.TabStop = false;
            // 
            // txtMaThuoc
            // 
            txtMaThuoc.Location = new Point(135, 53);
            txtMaThuoc.Name = "txtMaThuoc";
            txtMaThuoc.Size = new Size(177, 31);
            txtMaThuoc.TabIndex = 2;
            // 
            // cboMaLoaiThuoc
            // 
            cboMaLoaiThuoc.FormattingEnabled = true;
            cboMaLoaiThuoc.Location = new Point(448, 53);
            cboMaLoaiThuoc.Name = "cboMaLoaiThuoc";
            cboMaLoaiThuoc.Size = new Size(193, 33);
            cboMaLoaiThuoc.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 56);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã thuốc";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 308);
            panel2.Name = "panel2";
            panel2.Size = new Size(1058, 354);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvThuoc);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1058, 354);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách thuốc";
            // 
            // dgvThuoc
            // 
            dgvThuoc.AllowUserToDeleteRows = false;
            dgvThuoc.AllowUserToResizeColumns = false;
            dgvThuoc.AllowUserToResizeRows = false;
            dgvThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThuoc.Columns.AddRange(new DataGridViewColumn[] { MaThuoc, MaLoaiThuoc, TenThuoc, DonVi, MoTa, HinhAnh });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvThuoc.DefaultCellStyle = dataGridViewCellStyle2;
            dgvThuoc.Dock = DockStyle.Fill;
            dgvThuoc.Location = new Point(3, 27);
            dgvThuoc.MultiSelect = false;
            dgvThuoc.Name = "dgvThuoc";
            dgvThuoc.RowHeadersWidth = 62;
            dgvThuoc.Size = new Size(1052, 324);
            dgvThuoc.TabIndex = 1;
            dgvThuoc.CellClick += dgvThuoc_CellClick;
            // 
            // MaThuoc
            // 
            MaThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaThuoc.DataPropertyName = "_maThuoc";
            MaThuoc.HeaderText = "Mã thuốc";
            MaThuoc.MinimumWidth = 8;
            MaThuoc.Name = "MaThuoc";
            MaThuoc.Width = 123;
            // 
            // MaLoaiThuoc
            // 
            MaLoaiThuoc.DataPropertyName = "_loaiThuocMa";
            MaLoaiThuoc.HeaderText = "Mã loại thuốc";
            MaLoaiThuoc.MinimumWidth = 8;
            MaLoaiThuoc.Name = "MaLoaiThuoc";
            // 
            // TenThuoc
            // 
            TenThuoc.DataPropertyName = "_tenThuoc";
            TenThuoc.HeaderText = "Tên thuốc";
            TenThuoc.MinimumWidth = 8;
            TenThuoc.Name = "TenThuoc";
            // 
            // DonVi
            // 
            DonVi.DataPropertyName = "_donVi";
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 8;
            DonVi.Name = "DonVi";
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "_moTa";
            MoTa.HeaderText = "Mô tả";
            MoTa.MinimumWidth = 8;
            MoTa.Name = "MoTa";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "_hinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 8;
            HinhAnh.Name = "HinhAnh";
            // 
            // frmThuoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 662);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "frmThuoc";
            Text = "Thuốc";
            Load += frmThuoc_Load;
            KeyDown += frmThuoc_KeyDown;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhThuoc).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThuoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private GroupBox groupBox2;
        private ComboBox cboDonVi;
        private TextBox txtTenThuoc;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox picAnhThuoc;
        private TextBox txtMaThuoc;
        private ComboBox cboMaLoaiThuoc;
        private Label label1;
        private DataGridView dgvThuoc;
        private TextBox txtMoTa;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnThem;
        private Label label5;
        private Button btnDoiAnh;
        private DataGridViewTextBoxColumn MaThuoc;
        private DataGridViewTextBoxColumn MaLoaiThuoc;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewTextBoxColumn HinhAnh;
    }
}