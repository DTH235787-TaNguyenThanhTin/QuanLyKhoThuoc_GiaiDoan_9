using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmNhaCungCap : Form
    {
        private bool isAdding = false; // Biến cờ kiểm soát chế độ Thêm/Sửa

        public frmNhaCungCap() => InitializeComponent();

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            // Thiết kế DataGridView: KHÔNG tự sinh cột để giữ thiết kế tay của bạn
            dgvNhaCungCap.AutoGenerateColumns = false;

            LoadData();
            SetControlState(false); // Khóa các nút khi mới vào
        }

        // 1. Tải dữ liệu lên lưới
        private void LoadData()
        {
            string sql = "SELECT _maNhaCungCap, _tenNhaCungCap, _diaChi, _dienThoai FROM NhaCungCap";
            dgvNhaCungCap.DataSource = Functions.GetDataToTable(sql);
        }

        // 2. Thiết lập trạng thái các nút bấm và ô nhập liệu
        private void SetControlState(bool editing)
        {
            txtMaNhaCungCap.Enabled = false; // Mã luôn khóa vì tự sinh
            txtTenNhaCungCap.Enabled = editing;
            txtDiaChi.Enabled = editing;
            txtSDT.Enabled = editing;

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
            txtMaNhaCungCap.Text = "";
            txtTenNhaCungCap.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        // 4. Sự kiện khi Click vào một dòng trên lưới
        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu đang ở chế độ Thêm mới thì không cho phép Click chọn dòng
            if (isAdding || e.RowIndex < 0) return;

            if (dgvNhaCungCap.CurrentRow != null)
            {
                // Lấy dữ liệu từ các cột của dòng hiện tại đổ lên TextBox
                // Lưu ý: Tên cột trong ngoặc [ ] phải khớp với DataPropertyName bạn đặt ở Design
                txtMaNhaCungCap.Text = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();
                txtTenNhaCungCap.Text = dgvNhaCungCap.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNhaCungCap.CurrentRow.Cells[2].Value.ToString();
                txtSDT.Text = dgvNhaCungCap.CurrentRow.Cells[3].Value.ToString();
            }
        }

        // 5. Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            SetControlState(true);
            ResetValues();

            // Tự động sinh mã NCCxxx
            string lastId = Functions.GetFieldValues("SELECT TOP 1 _maNhaCungCap FROM NhaCungCap ORDER BY _maNhaCungCap DESC");
            int nextNum = 1;
            if (!string.IsNullOrEmpty(lastId))
            {
                nextNum = int.Parse(lastId.Substring(3)) + 1;
            }
            txtMaNhaCungCap.Text = "NCC" + nextNum.ToString("D3");
            txtTenNhaCungCap.Focus();
        }

        // 6. Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhaCungCap.Text))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            isAdding = false;
            SetControlState(true);
            txtTenNhaCungCap.Focus();
        }

        // 7. Nút Lưu (Xử lý cả Thêm và Sửa)
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhaCungCap.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhaCungCap.Focus();
                return;
            }

            string sql;
            if (isAdding)
            {
                sql = $"INSERT INTO NhaCungCap (_maNhaCungCap, _tenNhaCungCap, _diaChi, _dienThoai) VALUES ('{txtMaNhaCungCap.Text}', N'{txtTenNhaCungCap.Text}', N'{txtDiaChi.Text}', '{txtSDT.Text}')" +
                     $"SELECT * FROM NhaCungCap WHERE _maNhaCungCap = '{txtMaNhaCungCap.Text}'"; // Trả về bản ghi vừa thêm
            }
            else
            {
                sql = $"UPDATE NhaCungCap SET _tenNhaCungCap = N'{txtTenNhaCungCap.Text}', _diaChi = N'{txtDiaChi.Text}', _dienThoai = '{txtSDT.Text}' WHERE _maNhaCungCap = '{txtMaNhaCungCap.Text}'";
            }

            Functions.RunSQL(sql);
            LoadData();
            SetControlState(false);
            isAdding = false;
        }

        // 8. Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhaCungCap.Text)) return;

            if (MessageBox.Show("Bạn có muốn xóa nhà cung cấp này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM NhaCungCap WHERE _maNhaCungCap = '{txtMaNhaCungCap.Text}'";
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

        private void frmNhaCungCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Kiểm tra nếu control hiện tại không phải là TextBox đa dòng (Multiline)
                if (this.ActiveControl is TextBox txt && txt.Multiline)
                {
                    return; // Nếu là ô ghi chú nhiều dòng thì cho phép Enter xuống dòng bình thường
                }

                // Di chuyển đến Control tiếp theo theo thứ tự TabIndex
                this.ProcessTabKey(true);

                // Quan trọng: Chặn tiếng "Bíp" của Windows
                e.SuppressKeyPress = true;
            }
        }
    }
}