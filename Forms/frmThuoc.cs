using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmThuoc : Form
    {
        private bool isAdding = false;

        public frmThuoc()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {
            dgvThuoc.AutoGenerateColumns = false;

            // 1. Nạp danh mục Loại thuốc vào ComboBox
            FillComboLoai();

            // 2. Nạp cứng đơn vị tính (Nếu ComboBox chưa có Items)
            if (cboDonVi.Items.Count == 0)
            {
                cboDonVi.Items.AddRange(new string[] { "Viên", "Vỉ", "Hộp", "Chai", "Tuýp" });
            }

            LoadData();
            SetControlState(false);
        }

        private void FillComboLoai()
        {
            string sql = "SELECT _maLoaiThuoc, _tenLoaiThuoc FROM LoaiThuoc";
            Functions.FillCombo(sql, cboMaLoaiThuoc, "_maLoaiThuoc", "_tenLoaiThuoc");
            cboMaLoaiThuoc.SelectedIndex = -1; // Để trống lúc mới load
        }

        private void LoadData()
        {
            // Join với bảng LoaiThuoc để lấy tên loại hiển thị lên lưới nếu cần
            string sql = "SELECT _maThuoc, _loaiThuocMa, _tenThuoc, _donVi, _moTa, _hinhAnh FROM Thuoc";
            dgvThuoc.DataSource = Functions.GetDataToTable(sql);
        }

        private void SetControlState(bool editing)
        {
            txtMaThuoc.Enabled = false;
            txtTenThuoc.Enabled = editing;
            cboDonVi.Enabled = editing;
            cboMaLoaiThuoc.Enabled = editing;
            txtMoTa.Enabled = editing;
            btnDoiAnh.Enabled = editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;
            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
            btnThoat.Enabled = !editing;
        }

        private void ResetValues()
        {
            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            cboDonVi.SelectedIndex = -1;
            cboMaLoaiThuoc.SelectedIndex = -1;
            txtMoTa.Text = "";
            picAnhThuoc.Image = null;
            picAnhThuoc.Tag = ""; // Xóa đường dẫn ảnh cũ
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isAdding || e.RowIndex < 0) return;

            if (dgvThuoc.CurrentRow != null)
            {
                txtMaThuoc.Text = dgvThuoc.CurrentRow.Cells[0].Value?.ToString();

                // Quan trọng: Gán theo SelectedValue để khớp mã loại
                cboMaLoaiThuoc.SelectedValue = dgvThuoc.CurrentRow.Cells[1].Value?.ToString();

                txtTenThuoc.Text = dgvThuoc.CurrentRow.Cells[2].Value?.ToString();
                cboDonVi.Text = dgvThuoc.CurrentRow.Cells[3].Value?.ToString();
                txtMoTa.Text = dgvThuoc.CurrentRow.Cells[4].Value?.ToString();

                // Hiển thị ảnh
                string path = dgvThuoc.CurrentRow.Cells[5].Value?.ToString();
                picAnhThuoc.Tag = path; // Lưu đường dẫn vào Tag
                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    picAnhThuoc.Image = Image.FromFile(path);
                }
                else { picAnhThuoc.Image = null; }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            SetControlState(true);
            ResetValues();

            string lastId = Functions.GetFieldValues("SELECT TOP 1 _maThuoc FROM Thuoc ORDER BY _maThuoc DESC");
            int nextNum = 1;
            if (!string.IsNullOrEmpty(lastId) && lastId.Length > 2)
            {
                nextNum = int.Parse(lastId.Substring(2)) + 1;
            }
            txtMaThuoc.Text = "MT" + nextNum.ToString("D3");
            txtTenThuoc.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThuoc.Text)) return;
            isAdding = false;
            SetControlState(true);
            txtTenThuoc.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenThuoc.Text) || cboMaLoaiThuoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập tên thuốc và chọn loại thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLoai = cboMaLoaiThuoc.SelectedValue.ToString();
            string pathAnh = picAnhThuoc.Tag?.ToString() ?? "";
            string sql;

            if (isAdding)
            {
                sql = $"INSERT INTO Thuoc (_maThuoc, _loaiThuocMa, _tenThuoc, _donVi, _moTa, _hinhAnh) " +
                      $"VALUES ('{txtMaThuoc.Text}', '{maLoai}', N'{txtTenThuoc.Text}', N'{cboDonVi.Text}', N'{txtMoTa.Text}', N'{pathAnh}')";
            }
            else
            {
                sql = $"UPDATE Thuoc SET _loaiThuocMa='{maLoai}', _tenThuoc=N'{txtTenThuoc.Text}', " +
                      $"_donVi=N'{cboDonVi.Text}', _moTa=N'{txtMoTa.Text}', _hinhAnh=N'{pathAnh}' " +
                      $"WHERE _maThuoc='{txtMaThuoc.Text}'";
            }

            Functions.RunSQL(sql);
            LoadData();
            SetControlState(false);
            isAdding = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThuoc.Text)) return;

            if (MessageBox.Show("Bạn có muốn xóa thuốc này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Sửa lại đúng bảng Thuoc
                string sql = $"DELETE FROM Thuoc WHERE _maThuoc = '{txtMaThuoc.Text}'";
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

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picAnhThuoc.Image = Image.FromFile(ofd.FileName);
                    picAnhThuoc.Tag = ofd.FileName; // Lưu đường dẫn thực tế vào Tag
                }
            }
        }

        private void frmThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.ActiveControl is TextBox txt && txt.Multiline) return;
                this.ProcessTabKey(true);
                e.SuppressKeyPress = true;
            }
        }
    }
}