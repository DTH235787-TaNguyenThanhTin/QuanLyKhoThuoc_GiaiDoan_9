using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmNhanVien : Form
    {
        private bool isAdding = false; // Biến cờ kiểm soát chế độ Thêm/Sửa

        public frmNhanVien()
        {
            InitializeComponent();
            this.KeyPreview = true; // Cho phép Form bắt sự kiện bàn phím trước Control
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.AutoGenerateColumns = false;

            // 1. Thiết lập ComboBox Quyền hạn
            cboQuyenHan.Items.Clear();
            cboQuyenHan.Items.Add("Quản trị viên"); // Index 0
            cboQuyenHan.Items.Add("Nhân viên");     // Index 1
            cboQuyenHan.SelectedIndex = 1;         // Mặc định chọn Nhân viên

            LoadData();
            SetControlState(false); // Khóa các nút khi mới vào
        }

        // Tải dữ liệu lên lưới
        private void LoadData()
        {
            // CASE WHEN giúp hiển thị chữ trên lưới thay vì số 0/1
            string sql = "SELECT _maNhanVien, _hoTen, _tenDangNhap, _matKhau, " +
                         "CASE WHEN _quyenHan = 1 THEN N'Quản trị viên' ELSE N'Nhân viên' END AS TenQuyenHan " +
                         "FROM NhanVien";
            dgvNhanVien.DataSource = Functions.GetDataToTable(sql);
        }

        // Thiết lập trạng thái các nút bấm và ô nhập liệu
        private void SetControlState(bool editing)
        {
            txtMaNhanVien.Enabled = false; // Mã luôn khóa
            txtTenNhanVien.Enabled = editing;
            txtTenDangNhap.Enabled = editing;
            txtMatKhau.Enabled = editing;
            cboQuyenHan.Enabled = editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
            btnThoat.Enabled = !editing;
        }

        private void ResetValues()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            cboQuyenHan.SelectedIndex = 1;
        }

        // Sự kiện khi Click vào một dòng trên lưới
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isAdding || e.RowIndex < 0) return;

            if (dgvNhanVien.CurrentRow != null)
            {
                // Lấy dữ liệu theo đúng thứ tự cột trong câu lệnh SELECT ở hàm LoadData
                txtMaNhanVien.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                txtTenDangNhap.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                txtMatKhau.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();

                // Hiển thị quyền lên ComboBox dựa vào chữ trên lưới
                string quyenStr = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                cboQuyenHan.SelectedIndex = (quyenStr == "Quản trị viên") ? 0 : 1;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            SetControlState(true);
            ResetValues();

            // Tự động sinh mã NV001, NV002...
            string lastId = Functions.GetFieldValues("SELECT TOP 1 _maNhanVien FROM NhanVien ORDER BY _maNhanVien DESC");
            int nextNum = 1;
            if (!string.IsNullOrEmpty(lastId))
            {
                nextNum = int.Parse(lastId.Substring(2)) + 1;
            }
            txtMaNhanVien.Text = "NV" + nextNum.ToString("D3");
            txtTenNhanVien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhanVien.Text)) return;
            isAdding = false;
            SetControlState(true);
            txtTenNhanVien.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text) || string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên nhân viên và Tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuyển quyền từ ComboBox sang BIT (1/0)
            int quyenBit = (cboQuyenHan.SelectedIndex == 0) ? 1 : 0;

            string sql;
            if (isAdding)
            {
                sql = $"INSERT INTO NhanVien (_maNhanVien, _hoTen, _tenDangNhap, _matKhau, _quyenHan) " +
                      $"VALUES ('{txtMaNhanVien.Text}', N'{txtTenNhanVien.Text}', '{txtTenDangNhap.Text}', '{txtMatKhau.Text}', {quyenBit})";
            }
            else
            {
                sql = $"UPDATE NhanVien SET _hoTen = N'{txtTenNhanVien.Text}', _tenDangNhap = '{txtTenDangNhap.Text}', " +
                      $"_matKhau = '{txtMatKhau.Text}', _quyenHan = {quyenBit} WHERE _maNhanVien = '{txtMaNhanVien.Text}'";
            }

            Functions.RunSQL(sql);
            LoadData();
            SetControlState(false);
            isAdding = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhanVien.Text)) return;

            if (MessageBox.Show("Xác nhận xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM NhanVien WHERE _maNhanVien = '{txtMaNhanVien.Text}'";
                Functions.RunSQL(sql);
                LoadData();
                ResetValues();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            ResetValues();
            SetControlState(false);
        }

        private void btnThoat_Click(object sender, EventArgs e) => this.Close();

        // Xử lý phím Enter nhảy ô tiếp theo
        private void frmNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ProcessTabKey(true);
                e.SuppressKeyPress = true;
            }
        }

        
    }
}