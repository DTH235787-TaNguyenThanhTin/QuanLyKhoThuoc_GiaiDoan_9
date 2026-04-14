namespace QuanLyKhoThuoc.Forms
{
    partial class frmDangNhap
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
            pnLoginLeft = new Panel();
            lblLogo = new Label();
            pnLoginRight = new Panel();
            lblHint = new Label();
            btnDangNhap = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            lblMatKhau = new Label();
            lblTenDangNhap = new Label();
            lblTitle = new Label();
            pnLoginLeft.SuspendLayout();
            pnLoginRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnLoginLeft
            // 
            pnLoginLeft.BackColor = Color.FromArgb(71, 51, 255);
            pnLoginLeft.Controls.Add(lblLogo);
            pnLoginLeft.Dock = DockStyle.Left;
            pnLoginLeft.Location = new Point(0, 0);
            pnLoginLeft.Margin = new Padding(4);
            pnLoginLeft.Name = "pnLoginLeft";
            pnLoginLeft.Size = new Size(350, 656);
            pnLoginLeft.TabIndex = 3;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 200);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(350, 109);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Quản lý Kho Thuốc";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnLoginRight
            // 
            pnLoginRight.BackColor = Color.White;
            pnLoginRight.Controls.Add(lblHint);
            pnLoginRight.Controls.Add(btnDangNhap);
            pnLoginRight.Controls.Add(txtMatKhau);
            pnLoginRight.Controls.Add(txtTenDangNhap);
            pnLoginRight.Controls.Add(lblMatKhau);
            pnLoginRight.Controls.Add(lblTenDangNhap);
            pnLoginRight.Controls.Add(lblTitle);
            pnLoginRight.Dock = DockStyle.Fill;
            pnLoginRight.Location = new Point(350, 0);
            pnLoginRight.Margin = new Padding(4);
            pnLoginRight.Name = "pnLoginRight";
            pnLoginRight.Size = new Size(581, 656);
            pnLoginRight.TabIndex = 4;
            // 
            // lblHint
            // 
            lblHint.Font = new Font("Segoe UI", 9F);
            lblHint.ForeColor = Color.FromArgb(68, 68, 68);
            lblHint.Location = new Point(75, 581);
            lblHint.Margin = new Padding(4, 0, 4, 0);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(475, 31);
            lblHint.TabIndex = 9;
            lblHint.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(71, 51, 255);
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(76, 394);
            btnDangNhap.Margin = new Padding(4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(475, 55);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "ÐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.White;
            txtMatKhau.Font = new Font("Segoe UI", 11F);
            txtMatKhau.ForeColor = Color.Black;
            txtMatKhau.Location = new Point(76, 317);
            txtMatKhau.Margin = new Padding(4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '?';
            txtMatKhau.Size = new Size(474, 37);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.White;
            txtTenDangNhap.Font = new Font("Segoe UI", 11F);
            txtTenDangNhap.ForeColor = Color.Black;
            txtTenDangNhap.Location = new Point(75, 231);
            txtTenDangNhap.Margin = new Padding(4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(474, 37);
            txtTenDangNhap.TabIndex = 0;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 11F);
            lblMatKhau.ForeColor = Color.Black;
            lblMatKhau.Location = new Point(76, 279);
            lblMatKhau.Margin = new Padding(4, 0, 4, 0);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(103, 30);
            lblMatKhau.TabIndex = 4;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 11F);
            lblTenDangNhap.ForeColor = Color.Black;
            lblTenDangNhap.Location = new Point(75, 194);
            lblTenDangNhap.Margin = new Padding(4, 0, 4, 0);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(156, 30);
            lblTenDangNhap.TabIndex = 2;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(71, 51, 255);
            lblTitle.Location = new Point(164, 113);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(285, 56);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "ÐĂNG NHẬP";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 656);
            Controls.Add(pnLoginRight);
            Controls.Add(pnLoginLeft);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangNhap";
            WindowState = FormWindowState.Minimized;
            Load += frmDangNhap_Load;
            pnLoginLeft.ResumeLayout(false);
            pnLoginRight.ResumeLayout(false);
            pnLoginRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLoginLeft;
        private Label lblLogo;
        private Panel pnLoginRight;
        private Label lblHint;
        private Button btnDangNhap;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label lblMatKhau;
        private Label lblTenDangNhap;
        private Label lblTitle;
    }
}