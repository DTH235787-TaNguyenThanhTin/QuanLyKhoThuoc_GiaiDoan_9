namespace QuanLyKhoThuoc.Forms
{
    partial class frmNhatKy
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
            groupBox1 = new GroupBox();
            dtpTuNgay = new DateTimePicker();
            label2 = new Label();
            btnLoc = new Button();
            dtpDenNgay = new DateTimePicker();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvNhatKy = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            MaNV = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            ThoiGianDangNhap = new DataGridViewTextBoxColumn();
            MayTinh = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhatKy).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(dtpDenNgay);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1125, 201);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc thời gian";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(717, 30);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(197, 31);
            dtpTuNgay.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(626, 30);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 3;
            label2.Text = "Từ ngày";
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(749, 132);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(112, 34);
            btnLoc.TabIndex = 2;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(717, 78);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(197, 31);
            dtpDenNgay.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(626, 78);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "Đến ngày";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvNhatKy);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1125, 406);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhật ký đăng nhập";
            // 
            // dgvNhatKy
            // 
            dgvNhatKy.AllowUserToAddRows = false;
            dgvNhatKy.AllowUserToDeleteRows = false;
            dgvNhatKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhatKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhatKy.Columns.AddRange(new DataGridViewColumn[] { STT, MaNV, TenNV, ThoiGianDangNhap, MayTinh, TrangThai });
            dgvNhatKy.Dock = DockStyle.Fill;
            dgvNhatKy.Location = new Point(3, 27);
            dgvNhatKy.Name = "dgvNhatKy";
            dgvNhatKy.RowHeadersVisible = false;
            dgvNhatKy.RowHeadersWidth = 62;
            dgvNhatKy.Size = new Size(1119, 376);
            dgvNhatKy.TabIndex = 0;
            // 
            // STT
            // 
            STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            STT.DataPropertyName = "_id";
            STT.HeaderText = "STT";
            STT.MinimumWidth = 8;
            STT.Name = "STT";
            STT.Width = 76;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "_maNhanVien";
            MaNV.HeaderText = "Mã nhân viên";
            MaNV.MinimumWidth = 8;
            MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            TenNV.DataPropertyName = "_tenNhanVien";
            TenNV.HeaderText = "Tên nhân viên";
            TenNV.MinimumWidth = 8;
            TenNV.Name = "TenNV";
            // 
            // ThoiGianDangNhap
            // 
            ThoiGianDangNhap.DataPropertyName = "_thoiGianDangNhap";
            ThoiGianDangNhap.HeaderText = "Thời gian đăng nhập";
            ThoiGianDangNhap.MinimumWidth = 8;
            ThoiGianDangNhap.Name = "ThoiGianDangNhap";
            // 
            // MayTinh
            // 
            MayTinh.DataPropertyName = "_tenMayTinh";
            MayTinh.HeaderText = "Thiết bị đăng nhập";
            MayTinh.MinimumWidth = 8;
            MayTinh.Name = "MayTinh";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "(none)_trangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 8;
            TrangThai.Name = "TrangThai";
            // 
            // frmNhatKy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 607);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhatKy";
            Text = "frmNhatKy";
            Load += frmNhatKy_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhatKy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvNhatKy;
        private DateTimePicker dtpTuNgay;
        private Label label2;
        private Button btnLoc;
        private DateTimePicker dtpDenNgay;
        private Label label1;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn ThoiGianDangNhap;
        private DataGridViewTextBoxColumn MayTinh;
        private DataGridViewTextBoxColumn TrangThai;
    }
}