namespace QuanLyKhoThuoc.Forms
{
    partial class frmTienVon
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
            groupBox1 = new GroupBox();
            btnInTK = new Button();
            btnXuat = new Button();
            lblTongTienTrongKet = new Label();
            lblTongDoanhThu = new Label();
            label6 = new Label();
            txtNhanVien = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            label1 = new Label();
            txtTienVon = new TextBox();
            groupBox2 = new GroupBox();
            dgvHoaDon = new DataGridView();
            dgvPhieuNhap = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            MaHD = new DataGridViewTextBoxColumn();
            KhachHang = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnInTK);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(lblTongTienTrongKet);
            groupBox1.Controls.Add(lblTongDoanhThu);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNhanVien);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpDenNgay);
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTienVon);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1298, 296);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // btnInTK
            // 
            btnInTK.Location = new Point(1089, 196);
            btnInTK.Name = "btnInTK";
            btnInTK.Size = new Size(112, 34);
            btnInTK.TabIndex = 13;
            btnInTK.Text = "In thống kê";
            btnInTK.UseVisualStyleBackColor = true;
            btnInTK.Click += btnInTK_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1089, 253);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(112, 34);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // lblTongTienTrongKet
            // 
            lblTongTienTrongKet.AutoSize = true;
            lblTongTienTrongKet.Location = new Point(865, 254);
            lblTongTienTrongKet.Name = "lblTongTienTrongKet";
            lblTongTienTrongKet.Size = new Size(0, 25);
            lblTongTienTrongKet.TabIndex = 11;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Location = new Point(865, 214);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(0, 25);
            lblTongDoanhThu.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(715, 254);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 9;
            label6.Text = "Tổng tiền:";
            // 
            // txtNhanVien
            // 
            txtNhanVien.Location = new Point(447, 121);
            txtNhanVien.Name = "txtNhanVien";
            txtNhanVien.Size = new Size(224, 31);
            txtNhanVien.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(715, 214);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 7;
            label5.Text = "Tổng doanh thu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 127);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 6;
            label4.Text = "Nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 249);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 5;
            label3.Text = "Đến ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 187);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 4;
            label2.Text = "Từ ngày";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(447, 249);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(224, 31);
            dtpDenNgay.TabIndex = 3;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(447, 187);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(224, 31);
            dtpTuNgay.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 57);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 1;
            label1.Text = "Tiền vốn";
            // 
            // txtTienVon
            // 
            txtTienVon.Location = new Point(447, 57);
            txtTienVon.Name = "txtTienVon";
            txtTienVon.Size = new Size(224, 31);
            txtTienVon.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHoaDon);
            groupBox2.Controls.Add(dgvPhieuNhap);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 296);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1298, 404);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết";
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
            dgvHoaDon.Size = new Size(1292, 374);
            dgvHoaDon.TabIndex = 3;
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToDeleteRows = false;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPhieuNhap.Dock = DockStyle.Fill;
            dgvPhieuNhap.Location = new Point(3, 27);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.ReadOnly = true;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidth = 62;
            dgvPhieuNhap.Size = new Size(1292, 374);
            dgvPhieuNhap.TabIndex = 2;
            // 
            // STT
            // 
            STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            STT.HeaderText = "STT";
            STT.MinimumWidth = 8;
            STT.Name = "STT";
            STT.Width = 76;
            // 
            // MaHD
            // 
            MaHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaHD.DataPropertyName = "MaHD";
            MaHD.HeaderText = "Mã hoá đơn";
            MaHD.MinimumWidth = 8;
            MaHD.Name = "MaHD";
            MaHD.Width = 145;
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
            // frmTienVon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 700);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmTienVon";
            Text = "Thống kê doanh thu";
            Load += frmTienVon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvPhieuNhap;
        private TextBox txtTienVon;
        private Label label6;
        private TextBox txtNhanVien;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private Label label1;
        private Label lblTongTienTrongKet;
        private Label lblTongDoanhThu;
        private DataGridView dgvHoaDon;
        private Button btnInTK;
        private Button btnXuat;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTien;
    }
}