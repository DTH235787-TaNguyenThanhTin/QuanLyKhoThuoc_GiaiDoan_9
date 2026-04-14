namespace QuanLyKhoThuoc.Forms
{
    partial class frmNhaCungCap
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
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            txtSDT = new TextBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label3 = new Label();
            txtTenNhaCungCap = new TextBox();
            label2 = new Label();
            btnLuu = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            btnThem = new Button();
            txtMaNhaCungCap = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            dgvNhaCungCap = new DataGridView();
            MaNhaCungCap = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1089, 222);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTenNhaCungCap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtMaNhaCungCap);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1089, 222);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(261, 185);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(359, 31);
            txtSDT.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 191);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 26;
            label4.Text = "Số điện thoại :";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(261, 134);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(359, 31);
            txtDiaChi.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 140);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 24;
            label3.Text = "Địa chỉ  :";
            // 
            // txtTenNhaCungCap
            // 
            txtTenNhaCungCap.Location = new Point(261, 84);
            txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            txtTenNhaCungCap.Size = new Size(359, 31);
            txtTenNhaCungCap.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 90);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 22;
            label2.Text = "Tên nhà cung cấp (*) :";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(898, 130);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(898, 182);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(772, 130);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(646, 182);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(772, 182);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 17;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(646, 130);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtMaNhaCungCap
            // 
            txtMaNhaCungCap.Location = new Point(261, 32);
            txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            txtMaNhaCungCap.Size = new Size(359, 31);
            txtMaNhaCungCap.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 38);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 14;
            label1.Text = "Mã nhà cung cấp (*) :";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 222);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 425);
            panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvNhaCungCap);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1089, 425);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.AllowUserToDeleteRows = false;
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.Columns.AddRange(new DataGridViewColumn[] { MaNhaCungCap, TenNhaCungCap, DiaChi, SDT });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNhaCungCap.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNhaCungCap.Dock = DockStyle.Fill;
            dgvNhaCungCap.Location = new Point(3, 27);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.ReadOnly = true;
            dgvNhaCungCap.RowHeadersWidth = 62;
            dgvNhaCungCap.Size = new Size(1083, 395);
            dgvNhaCungCap.TabIndex = 0;
            dgvNhaCungCap.CellClick += dgvNhaCungCap_CellClick;
            // 
            // MaNhaCungCap
            // 
            MaNhaCungCap.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaNhaCungCap.DataPropertyName = "_maNhaCungCap";
            MaNhaCungCap.HeaderText = "Mã nhà cung cấp";
            MaNhaCungCap.MinimumWidth = 8;
            MaNhaCungCap.Name = "MaNhaCungCap";
            MaNhaCungCap.ReadOnly = true;
            MaNhaCungCap.Width = 144;
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.DataPropertyName = "_tenNhaCungCap";
            TenNhaCungCap.HeaderText = "Tên Nhà Cung Cấp";
            TenNhaCungCap.MinimumWidth = 8;
            TenNhaCungCap.Name = "TenNhaCungCap";
            TenNhaCungCap.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "_diaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // SDT
            // 
            SDT.DataPropertyName = "_dienThoai";
            SDT.HeaderText = "Số điện thoại";
            SDT.MinimumWidth = 8;
            SDT.Name = "SDT";
            SDT.ReadOnly = true;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 647);
            Controls.Add(panel1);
            Controls.Add(panel2);
            KeyPreview = true;
            Name = "frmNhaCungCap";
            Text = "Nhà Cung Cấp";
            Load += frmNhaCungCap_Load;
            KeyDown += frmNhaCungCap_KeyDown;
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnThem;
        private TextBox txtMaNhaCungCap;
        private Label label1;
        private DataGridView dgvNhaCungCap;
        private TextBox txtTenNhaCungCap;
        private Label label2;
        private TextBox txtSDT;
        private Label label4;
        private TextBox txtDiaChi;
        private Label label3;
        private DataGridViewTextBoxColumn MaNhaCungCap;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SDT;
    }
}