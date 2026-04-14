namespace QuanLyKhoThuoc.Forms
{
    partial class frmGiaodien
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
            cboTheme = new ComboBox();
            colorDialog = new ColorDialog();
            label1 = new Label();
            pnlMau = new Panel();
            btnChonFont = new Button();
            fontDialog = new FontDialog();
            label2 = new Label();
            btnChonMau = new Button();
            btnLuu = new Button();
            btnMacDinh = new Button();
            SuspendLayout();
            // 
            // cboTheme
            // 
            cboTheme.FormattingEnabled = true;
            cboTheme.Items.AddRange(new object[] { "Sáng, Tối" });
            cboTheme.Location = new Point(141, 39);
            cboTheme.Name = "cboTheme";
            cboTheme.Size = new Size(166, 33);
            cboTheme.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 47);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 1;
            label1.Text = "Theme";
            // 
            // pnlMau
            // 
            pnlMau.Location = new Point(347, 12);
            pnlMau.Name = "pnlMau";
            pnlMau.Size = new Size(75, 67);
            pnlMau.TabIndex = 2;
            // 
            // btnChonFont
            // 
            btnChonFont.Location = new Point(327, 94);
            btnChonFont.Name = "btnChonFont";
            btnChonFont.Size = new Size(111, 59);
            btnChonFont.TabIndex = 3;
            btnChonFont.Text = "Chọn font chủ đạo";
            btnChonFont.UseVisualStyleBackColor = true;
            btnChonFont.Click += btnChonFont_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 99);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 4;
            label2.Text = "Font chữ";
            // 
            // btnChonMau
            // 
            btnChonMau.Location = new Point(170, 94);
            btnChonMau.Name = "btnChonMau";
            btnChonMau.Size = new Size(116, 59);
            btnChonMau.TabIndex = 5;
            btnChonMau.Text = "Chọn màu chủ đạo";
            btnChonMau.UseVisualStyleBackColor = true;
            btnChonMau.Click += btnChonMau_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(170, 159);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(116, 59);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnMacDinh
            // 
            btnMacDinh.Location = new Point(322, 159);
            btnMacDinh.Name = "btnMacDinh";
            btnMacDinh.Size = new Size(116, 59);
            btnMacDinh.TabIndex = 7;
            btnMacDinh.Text = "Khôi phục mặc định";
            btnMacDinh.UseVisualStyleBackColor = true;
            btnMacDinh.Click += btnMacDinh_Click;
            // 
            // frmGiaodien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 275);
            Controls.Add(btnMacDinh);
            Controls.Add(btnLuu);
            Controls.Add(btnChonMau);
            Controls.Add(label2);
            Controls.Add(btnChonFont);
            Controls.Add(pnlMau);
            Controls.Add(label1);
            Controls.Add(cboTheme);
            Name = "frmGiaodien";
            Text = "frmGiaodien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboTheme;
        private ColorDialog colorDialog;
        private Label label1;
        private Panel pnlMau;
        private Button btnChonFont;
        private FontDialog fontDialog;
        private Label label2;
        private Button btnChonMau;
        private Button btnLuu;
        private Button btnMacDinh;
    }
}