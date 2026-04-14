using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // 1. Áp dụng giao diện (Màu sắc, Font chữ)
            Functions.ApplyTheme(this);

            // 2. Chạy hàm phân quyền để ẩn/hiện các nút bấm theo tài khoản
            PhanQuyen();
        }

        // VỊ TRÍ DÁN HÀM PHANQUYEN CỦA BẠN:
        private void PhanQuyen()
        {
            if (Functions.QuyenHanDangNhap == 1) // LÀ QUẢN LÝ
            {
                btnBanThuoc.Visible = false;
                btnHoaDon.Visible = true;
                btnThuoc.Visible = true;
                btnLoaiThuoc.Visible = true;
                btnNhaCunhCap.Visible = true;
                btnKhachHang.Visible = true;
                btnPhieuNhap.Visible = true;
                btnNhanVien.Visible = true;
                btnNhatKy.Visible = true;
                btnGiaoDien.Visible = true;

                lblTitle.Text = $"QUẢN LÝ - XIN CHÀO: {Functions.TenNhanVienDangNhap.ToUpper()}";
            }
            else // LÀ NHÂN VIÊN
            {
                btnBanThuoc.Visible = true;
                btnHoaDon.Visible = true;
                btnKhachHang.Visible = true;
                btnGiaoDien.Visible = true; // Cho phép nhân viên chỉnh giao diện theo ý bạn muốn
                btnNhatKy.Visible = true;   // Cho phép xem nhật ký

                btnThuoc.Visible = false;
                btnLoaiThuoc.Visible = false;
                btnNhaCunhCap.Visible = false;
                btnPhieuNhap.Visible = false;
                btnNhanVien.Visible = false;

                lblTitle.Text = $"NHÂN VIÊN - XIN CHÀO: {Functions.TenNhanVienDangNhap.ToUpper()}";
            }
        }

        // =========================================================
        // HÀM XỬ LÝ MỞ FORM CON (ĐÃ NÂNG CẤP ĐỒNG BỘ GIAO DIỆN)
        // =========================================================
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            // Nếu có form đang mở thì đóng nó lại để giải phóng bộ nhớ
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false; // Bắt buộc: Để form không bay ra ngoài windows
            childForm.FormBorderStyle = FormBorderStyle.None; // Bỏ viền form con
            childForm.Dock = DockStyle.Fill; // Lấp đầy panel chính

            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();

            // BẮT BUỘC: Ép Form con phải tự đổi màu theo cài đặt hiện tại của hệ thống
            Functions.ApplyTheme(childForm);

            childForm.Show();
        }

        // =========================================================
        // DANH SÁCH CÁC NÚT CHỨC NĂNG BÊN MENU TRÁI
        // =========================================================

        private void btnBanThuoc_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmBanThuoc());
            lblTitle.Text = "QUẢN LÝ BÁN THUỐC";
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmHoaDon());
            lblTitle.Text = "QUẢN LÝ HÓA ĐƠN";
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmThuoc());
            lblTitle.Text = "QUẢN LÝ THUỐC";
        }

        private void btnLoaiThuoc_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmLoaiThuoc());
            lblTitle.Text = "QUẢN LÝ LOẠI THUỐC";
        }

        private void btnNhaCunhCap_Click(object sender, EventArgs e)
        {
            // Lưu ý: Tên nút của bạn đang viết là btnNhaCunhCap (sai chính tả chữ Cung), bạn nhớ giữ nguyên để khớp với Designer nhé
            openChildForm(new Forms.frmNhaCungCap());
            lblTitle.Text = "QUẢN LÝ NHÀ CUNG CẤP";
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmKhachHang());
            lblTitle.Text = "QUẢN LÝ KHÁCH HÀNG";
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmNhanVien());
            lblTitle.Text = "QUẢN LÝ NHÂN VIÊN";
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmPhieuNhap());
            lblTitle.Text = "QUẢN LÝ PHIẾU NHẬP";
        }

        private void btnNhatKy_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmNhatKy());
            lblTitle.Text = "NHẬT KÝ HOẠT ĐỘNG";
        }

        private void btnGiaoDien_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmGiaodien());
            lblTitle.Text = "CÀI ĐẶT GIAO DIỆN";
        }

        // =========================================================
        // CHỨC NĂNG ĐĂNG XUẤT (AN TOÀN TUYỆT ĐỐI)
        // =========================================================

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất và quay lại màn hình đăng nhập?",
                                              "Xác nhận thoát",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // 1. Xóa sạch phiên đăng nhập hiện tại (Nâng cao bảo mật)
                Functions.MaNhanVienDangNhap = "";
                Functions.TenNhanVienDangNhap = "";
                Functions.QuyenHanDangNhap = 0;
                // 2. Ẩn Main đi
                this.Hide();

                // 3. Khởi tạo và hiển thị lại màn hình Đăng Nhập
                frmDangNhap login = new frmDangNhap();
                login.ShowDialog();

                // 4. Nếu màn hình đăng nhập bị đóng (Tắt hẳn app), thì Đóng luôn Main để dọn rác bộ nhớ
                this.Close();
            }
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmTienVon());
            lblTitle.Text = "QUẢN LÝ TIỀN VỐN";
        }
    }
}
