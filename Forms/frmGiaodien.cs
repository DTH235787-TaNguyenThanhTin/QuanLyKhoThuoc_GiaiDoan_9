using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmGiaodien : Form
    {
        public frmGiaodien()
        {
            InitializeComponent();

            // Tự động kết nối sự kiện Load để đảm bảo giao diện luôn mở đúng
            this.Load += frmGiaodien_Load;
        }

        // ==========================================
        // 1. KHI MỞ FORM (Nạp cài đặt cũ lên màn hình)
        // ==========================================
        private void frmGiaodien_Load(object sender, EventArgs e)
        {
            // Sửa lỗi ComboBox hiển thị gộp "Sáng, Tối" thành 2 dòng riêng biệt
            cboTheme.Items.Clear();
            cboTheme.Items.Add("Sáng");
            cboTheme.Items.Add("Tối");

            // Load chế độ Sáng/Tối
            cboTheme.Text = Properties.Settings.Default.Theme == "Dark" ? "Tối" : "Sáng";

            // Load màu từ Settings vào Panel pnlMau
            string hexColor = Properties.Settings.Default.MainColor;
            if (string.IsNullOrEmpty(hexColor)) hexColor = "#1E90FF"; // Mặc định Xanh dương

            try { pnlMau.BackColor = ColorTranslator.FromHtml(hexColor); }
            catch { pnlMau.BackColor = Color.DodgerBlue; }

            // Load Font từ Settings vào label2
            string fontName = Properties.Settings.Default.AppFontName;
            float fontSize = Properties.Settings.Default.AppFontSize;
            if (string.IsNullOrEmpty(fontName)) fontName = "Segoe UI";
            if (fontSize <= 0) fontSize = 10f;

            label2.Font = new Font(fontName, fontSize);
            label2.Text = "Font chữ (Chữ mẫu)"; // Hiển thị thêm chữ mẫu cho dễ nhìn

            // Áp dụng màu cho chính Form Cài đặt này
            ApplyTheme(this);
        }

        // ==========================================
        // 2. NÚT CHỌN MÀU & CHỌN FONT
        // ==========================================
        private void btnChonMau_Click(object sender, EventArgs e)
        {
            colorDialog.Color = pnlMau.BackColor; // Chọn sẵn màu đang dùng
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pnlMau.BackColor = colorDialog.Color; // Gán màu mới vào Panel
            }
        }

        private void btnChonFont_Click(object sender, EventArgs e)
        {
            fontDialog.Font = label2.Font; // Chọn sẵn font đang dùng
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                label2.Font = fontDialog.Font; // Gán font mới vào Label2
            }
        }

        // ==========================================
        // 3. NÚT LƯU & MẶC ĐỊNH
        // ==========================================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lưu Theme
            Properties.Settings.Default.Theme = cboTheme.Text == "Tối" ? "Dark" : "Light";

            // Lưu Màu (Dịch ra mã Hex)
            Properties.Settings.Default.MainColor = ColorTranslator.ToHtml(pnlMau.BackColor);


            // Lưu Tên và Cỡ Font
            Properties.Settings.Default.AppFontName = label2.Font.Name;
            Properties.Settings.Default.AppFontSize = label2.Font.Size;

            // Bắt buộc gọi Save() để ghi nhớ vào bộ nhớ máy tính
            Properties.Settings.Default.Save();

            MessageBox.Show("Đã lưu cài đặt giao diện!\nMở lại các chức năng để thấy thay đổi.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ApplyTheme(this);
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn khôi phục giao diện về mặc định?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cboTheme.Text = "Sáng";
                pnlMau.BackColor = Color.DodgerBlue;
                label2.Font = new Font("Segoe UI", 10f);

                btnLuu.PerformClick(); // Tự động gọi nút Lưu
            }
        }

        // ==========================================
        // 4. HÀM ÁP DỤNG MÀU (Copy hàm này sang các Form khác)
        // ==========================================
        private void ApplyTheme(Form frm)
        {
            // --- XỬ LÝ FONT CHỮ ---
            string fontName = Properties.Settings.Default.AppFontName;
            float fontSize = Properties.Settings.Default.AppFontSize;
            if (string.IsNullOrEmpty(fontName)) fontName = "Segoe UI";
            if (fontSize <= 0) fontSize = 10f;
            frm.Font = new Font(fontName, fontSize);

            // --- XỬ LÝ NỀN SÁNG/TỐI ---
            string theme = Properties.Settings.Default.Theme;
            if (theme == "Dark")
            {
                frm.BackColor = Color.FromArgb(45, 45, 48); // Xám đen
                frm.ForeColor = Color.White;
            }
            else
            {
                frm.BackColor = SystemColors.Control; // Trắng xám mặc định
                frm.ForeColor = Color.Black;
            }

            // --- XỬ LÝ MÀU CHỦ ĐẠO CHO NÚT BẤM ---
            string hexColor = Properties.Settings.Default.MainColor;
            Color mauChuDao;
            try { mauChuDao = ColorTranslator.FromHtml(hexColor); }
            catch { mauChuDao = Color.DodgerBlue; }

            foreach (Control c in frm.Controls)
            {
                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.ForeColor = Color.White;
                    btn.BackColor = mauChuDao;
                }
            }
        }
    }
}