using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmLoaiThuoc : Form
    {
        private bool isAdding = false; // Biến cờ kiểm soát chế độ Thêm/Sửa

        public frmLoaiThuoc() => InitializeComponent();

        private void frmLoaiThuoc_Load(object sender, EventArgs e)
        {
            // Thiết kế DataGridView: KHÔNG tự sinh cột để giữ thiết kế tay của bạn
            dgvLoaiThuoc.AutoGenerateColumns = false;

            LoadData();
            SetControlState(false); // Khóa các nút khi mới vào
        }

        // 1. Tải dữ liệu lên lưới
        private void LoadData()
        {
            // Truy vấn bảng LoaiThuoc
            string sql = "SELECT _maLoaiThuoc, _tenLoaiThuoc FROM LoaiThuoc";
            dgvLoaiThuoc.DataSource = Functions.GetDataToTable(sql);
        }

        // 2. Thiết lập trạng thái các nút bấm và ô nhập liệu
        private void SetControlState(bool editing)
        {
            txtMaLoaiThuoc.Enabled = false; // Mã luôn khóa vì tự sinh
            txtLoaiThuoc.Enabled = editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
            btnThoat.Enabled = !editing;
        }

        // 3. Xóa trắng các ô nhập liệu
        private void ResetValues()
        {
            txtMaLoaiThuoc.Text = "";
            txtLoaiThuoc.Text = "";
        }

        // 4. Sự kiện khi Click vào một dòng trên lưới
        private void dgvLoaiThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu đang ở chế độ Thêm mới thì không cho phép Click chọn dòng
            if (isAdding || e.RowIndex < 0) return;

            if (dgvLoaiThuoc.CurrentRow != null)
            {
                // Lấy dữ liệu từ các cột của dòng hiện tại (0: Mã, 1: Tên)
                txtMaLoaiThuoc.Text = dgvLoaiThuoc.CurrentRow.Cells[0].Value.ToString();
                txtLoaiThuoc.Text = dgvLoaiThuoc.CurrentRow.Cells[1].Value.ToString();
            }
        }

        // 5. Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            SetControlState(true);
            ResetValues();

            // Tự động sinh mã LTxxx (Loại Thuốc)
            // Lấy mã lớn nhất hiện có
            string lastId = Functions.GetFieldValues("SELECT TOP 1 _maLoaiThuoc FROM LoaiThuoc ORDER BY _maLoaiThuoc DESC");
            int nextNum = 1;

            if (!string.IsNullOrEmpty(lastId))
            {
                // Cắt chuỗi bỏ "LT" (2 ký tự đầu) và tăng số lên 1
                nextNum = int.Parse(lastId.Substring(2)) + 1;
            }

            // Định dạng LT + 3 chữ số (VD: LT001)
            txtMaLoaiThuoc.Text = "LT" + nextNum.ToString("D3");
            txtLoaiThuoc.Focus();
        }

        // 6. Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoaiThuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn loại thuốc cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            isAdding = false;
            SetControlState(true);
            txtLoaiThuoc.Focus();
        }

        // 7. Nút Lưu (Xử lý cả Thêm và Sửa)
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoaiThuoc.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên loại thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoaiThuoc.Focus();
                return;
            }

            string sql;
            if (isAdding)
            {
                sql = $"INSERT INTO LoaiThuoc (_maLoaiThuoc, _tenLoaiThuoc) VALUES ('{txtMaLoaiThuoc.Text}', N'{txtLoaiThuoc.Text}')";
            }
            else
            {
                sql = $"UPDATE LoaiThuoc SET _tenLoaiThuoc = N'{txtLoaiThuoc.Text}' WHERE _maLoaiThuoc = '{txtMaLoaiThuoc.Text}'";
            }

            Functions.RunSQL(sql);
            LoadData();
            SetControlState(false);
            isAdding = false;
        }

        // 8. Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoaiThuoc.Text)) return;

            if (MessageBox.Show("Bạn có muốn xóa loại thuốc này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Kiểm tra ràng buộc khóa ngoại trước khi xóa (Nếu mã này đã dùng trong bảng Thuoc thì SQL sẽ báo lỗi)
                string sql = $"DELETE FROM LoaiThuoc WHERE _maLoaiThuoc = '{txtMaLoaiThuoc.Text}'";
                Functions.RunSQL(sql);
                LoadData();
                ResetValues();
            }
        }

        // 9. Nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            ResetValues();
            SetControlState(false);
        }

        // 10. Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e) => this.Close();
    }
}