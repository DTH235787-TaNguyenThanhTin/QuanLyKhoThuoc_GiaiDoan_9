namespace QuanLyKhoThuoc.Forms
{
    partial class frmLoaiThuoc
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
            txtMaLoaiThuoc = new TextBox();
            label2 = new Label();
            btnLuu = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            btnThem = new Button();
            txtLoaiThuoc = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dgvLoaiThuoc = new DataGridView();
            MaLoaiThuoc = new DataGridViewTextBoxColumn();
            TenLoaiThuoc = new DataGridViewTextBoxColumn();
            btnTiemKiem = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiThuoc).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 232);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTiemKiem);
            groupBox1.Controls.Add(txtMaLoaiThuoc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtLoaiThuoc);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1018, 232);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại thuốc";
            // 
            // txtMaLoaiThuoc
            // 
            txtMaLoaiThuoc.Location = new Point(213, 44);
            txtMaLoaiThuoc.Name = "txtMaLoaiThuoc";
            txtMaLoaiThuoc.Size = new Size(360, 31);
            txtMaLoaiThuoc.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 50);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 14;
            label2.Text = "Mã loại thuốc (*) :";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(852, 41);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(852, 101);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(726, 41);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(600, 101);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(726, 101);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(600, 41);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtLoaiThuoc
            // 
            txtLoaiThuoc.Location = new Point(214, 95);
            txtLoaiThuoc.Name = "txtLoaiThuoc";
            txtLoaiThuoc.Size = new Size(359, 31);
            txtLoaiThuoc.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 101);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên loại thuốc (*) :";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(1018, 407);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvLoaiThuoc);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1018, 407);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin danh sách loại thuốc";
            // 
            // dgvLoaiThuoc
            // 
            dgvLoaiThuoc.AllowUserToAddRows = false;
            dgvLoaiThuoc.AllowUserToDeleteRows = false;
            dgvLoaiThuoc.AllowUserToResizeColumns = false;
            dgvLoaiThuoc.AllowUserToResizeRows = false;
            dgvLoaiThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLoaiThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLoaiThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiThuoc.Columns.AddRange(new DataGridViewColumn[] { MaLoaiThuoc, TenLoaiThuoc });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLoaiThuoc.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLoaiThuoc.Dock = DockStyle.Fill;
            dgvLoaiThuoc.Location = new Point(3, 27);
            dgvLoaiThuoc.MultiSelect = false;
            dgvLoaiThuoc.Name = "dgvLoaiThuoc";
            dgvLoaiThuoc.RowHeadersWidth = 62;
            dgvLoaiThuoc.Size = new Size(1012, 377);
            dgvLoaiThuoc.TabIndex = 0;
            dgvLoaiThuoc.CellClick += dgvLoaiThuoc_CellClick;
            // 
            // MaLoaiThuoc
            // 
            MaLoaiThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaLoaiThuoc.DataPropertyName = "_maLoaiThuoc";
            MaLoaiThuoc.HeaderText = "Mã Loại Thuốc";
            MaLoaiThuoc.MinimumWidth = 8;
            MaLoaiThuoc.Name = "MaLoaiThuoc";
            MaLoaiThuoc.Width = 163;
            // 
            // TenLoaiThuoc
            // 
            TenLoaiThuoc.DataPropertyName = "_tenLoaiThuoc";
            TenLoaiThuoc.HeaderText = "Tên Loại Thuốc";
            TenLoaiThuoc.MinimumWidth = 8;
            TenLoaiThuoc.Name = "TenLoaiThuoc";
            // 
            // btnTiemKiem
            // 
            btnTiemKiem.Location = new Point(315, 157);
            btnTiemKiem.Name = "btnTiemKiem";
            btnTiemKiem.Size = new Size(112, 34);
            btnTiemKiem.TabIndex = 16;
            btnTiemKiem.Text = "Tìm kiếm";
            btnTiemKiem.UseVisualStyleBackColor = true;
            // 
            // frmLoaiThuoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 639);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmLoaiThuoc";
            Text = "Loại Thuốc";
            Load += frmLoaiThuoc_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoaiThuoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txtLoaiThuoc;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox2;
        private DataGridView dgvLoaiThuoc;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnThem;
        private TextBox txtMaLoaiThuoc;
        private Label label2;
        private DataGridViewTextBoxColumn MaLoaiThuoc;
        private DataGridViewTextBoxColumn TenLoaiThuoc;
        private Button btnTiemKiem;
    }
}