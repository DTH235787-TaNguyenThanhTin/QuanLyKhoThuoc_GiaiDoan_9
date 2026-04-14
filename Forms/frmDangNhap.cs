using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();

            // Cài đặt để Form nhận được sự kiện gõ phím (Bắt phím Enter)
            this.KeyPreview = true;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // Mặc định che mật khẩu lại
            txtMatKhau.UseSystemPasswordChar = true;
        }

        // ==========================================
        // 1. NÚT ĐĂNG NHẬP
        // ==========================================
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtTenDangNhap.Text.Trim();
            string pass = txtMatKhau.Text.Trim();

            string sql = $"SELECT _maNhanVien, _hoTen, _quyenHan FROM NhanVien WHERE _tenDangNhap = '{user}' AND _matKhau = '{pass}'";
            DataTable dt = Functions.GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                // GHI NHỚ VÀO "NHÀ KHO DÙNG CHUNG" (Functions)
                // Lưu Mã nhân viên
                Functions.MaNhanVienDangNhap = dt.Rows[0]["_maNhanVien"].ToString();
                // Lưu Tên nhân viên
                Functions.TenNhanVienDangNhap = dt.Rows[0]["_hoTen"].ToString();
                // Lưu Quyền hạn: Ép kiểu bit/int sang int (1=Admin, 0=Nhân viên)
                Functions.QuyenHanDangNhap = Convert.ToInt32(dt.Rows[0]["_quyenHan"]);

                // Ghi nhật ký vào CSDL
                Functions.LuuNhatKy(Functions.MaNhanVienDangNhap, Functions.TenNhanVienDangNhap, "Đăng nhập");

                // Mở Form Main
                this.Hide();
                frmMain main = new frmMain();
                main.ShowDialog();
                this.Close();
            }
        }


        // ==========================================
        // 2. NÚT THOÁT
        // ==========================================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit(); // Đóng hoàn toàn chương trình
            }
        }

        // ==========================================
        // 3. TIỆN ÍCH: BẤM PHÍM ENTER ĐỂ ĐĂNG NHẬP
        // ==========================================
        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            // Nếu người dùng ấn phím Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi sự kiện Click của nút Đăng Nhập
                btnDangNhap_Click(sender, e);
                e.SuppressKeyPress = true; // Tắt tiếng "Bíp" của Windows
            }
        }

        

        // ==========================================
        // 4. TIỆN ÍCH: CHECKBOX HIỆN MẬT KHẨU
        // ==========================================

    }
}