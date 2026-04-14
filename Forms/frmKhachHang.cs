using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmKhachHang : Form
    {
        private bool isAdding = false; // Biến cờ kiểm soát chế độ Thêm/Sửa

        public frmKhachHang() => InitializeComponent();

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // Thiết kế DataGridView: KHÔNG tự sinh cột để giữ thiết kế tay của bạn
            dgvKhachHang.AutoGenerateColumns = false;

            LoadData();
            SetControlState(false); // Khóa các nút khi mới vào
        }

        // 1. Tải dữ liệu lên lưới
        private void LoadData()
        {
            string sql = "SELECT _maKhachHang, _hoTen, _gioiTinh, _diaChi, _dienThoai FROM KhachHang";
            dgvKhachHang.DataSource = Functions.GetDataToTable(sql);
        }

        // 2. Thiết lập trạng thái các nút bấm và ô nhập liệu
        private void SetControlState(bool editing)
        {
            txtMaKhachHang.Enabled = false; // Mã luôn khóa vì tự sinh
            txtTenKhachHang.Enabled = editing;
            rdNam.Enabled = editing; // Sử dụng RadioButton cho Giới tính
            rdNu.Enabled = editing;  
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
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        // 4. Sự kiện khi Click vào một dòng trên lưới
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu đang ở chế độ Thêm mới thì không cho phép Click chọn dòng
            if (isAdding || e.RowIndex < 0) return;

            if (dgvKhachHang.CurrentRow != null)
            {
                // Lấy dữ liệu từ các cột của dòng hiện tại đổ lên TextBox
                // Lưu ý: Tên cột trong ngoặc [ ] phải khớp với DataPropertyName bạn đặt ở Design
                txtMaKhachHang.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtTenKhachHang.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                
                // Xử lý giới tính bằng RadioButton
                string gioiTinh = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                if (gioiTinh == "Nam")
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;

                txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
                txtSDT.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
            }
        }

        // 5. Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            SetControlState(true);
            ResetValues();

            // Tự động sinh mã KHxxx
            string lastId = Functions.GetFieldValues("SELECT TOP 1 _maKhachHang FROM KhachHang ORDER BY _maKhachHang DESC");
            int nextNum = 1;
            if (!string.IsNullOrEmpty(lastId))
            {
                // Giả sử mã có định dạng "KH001", "KH002", ... thì ta sẽ lấy phần số và tăng lên
                nextNum = int.Parse(lastId.Substring(2)) + 1;
            }
            txtMaKhachHang.Text = "KH" + nextNum.ToString("D3");
            txtTenKhachHang.Focus();
        }

        // 6. Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMaKhachHang.Text))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            isAdding = false;
            SetControlState(true);
            txtTenKhachHang.Focus();
        }

        // 7. Nút Lưu (Xử lý cả Thêm và Sửa)
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhachHang.Focus();
                return;
            }
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn lưu các thay đổi này không?",
                "Xác nhận lưu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ketQua == DialogResult.Yes)
            {
                
                string gioiTinh = rdNam.Checked ? "Nam" : "Nữ";
                string sql;
                if (isAdding)
                {
                    sql = $"INSERT INTO KhachHang (_maKhachHang, _hoTen, _gioiTinh, _diaChi, _dienThoai) VALUES ('{txtMaKhachHang.Text}', N'{txtTenKhachHang.Text}', N'{gioiTinh}', N'{txtDiaChi.Text}', '{txtSDT.Text}')" +
                         $"SELECT * FROM KhachHang WHERE _maKhachHang = '{txtMaKhachHang.Text}'"; // Trả về bản ghi vừa thêm
                }
                else
                {
                    sql = $"UPDATE KhachHang SET _hoTen = N'{txtTenKhachHang.Text}', _gioiTinh = N'{gioiTinh}', _diaChi = N'{txtDiaChi.Text}', _dienThoai = '{txtSDT.Text}' WHERE _maKhachHang = '{txtMaKhachHang.Text}'";
                }

                Functions.RunSQL(sql);
                LoadData();
                SetControlState(false);
                isAdding = false;

               
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }

        // 8. Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKhachHang.Text)) return;

            if (MessageBox.Show("Bạn có muốn xóa khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM KhachHang WHERE _maKhachHang = '{txtMaKhachHang.Text}'";
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

        private void frmKhachHang_KeyDown(object sender, KeyEventArgs e)
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