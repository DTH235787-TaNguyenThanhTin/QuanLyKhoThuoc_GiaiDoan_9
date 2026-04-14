using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmLoThuoc : Form
    {
        private bool isAdding = false;

        public frmLoThuoc()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void frmLoThuoc_Load(object sender, EventArgs e)
        {
            dgvLoThuoc.AutoGenerateColumns = false;

            // Nạp danh sách Thuốc vào ComboBox
            DataTable dtThuoc = Functions.GetDataToTable("SELECT _maThuoc, _tenThuoc FROM Thuoc");
            cboMaThuocTiemKiem.DataSource = dtThuoc;
            cboMaThuocTiemKiem.ValueMember = "_maThuoc";
            cboMaThuocTiemKiem.DisplayMember = "_tenThuoc"; // Hiện tên thuốc cho dễ nhìn
            cboMaThuocTiemKiem.SelectedIndex = -1;

            // Cho phép người dùng vừa gõ vừa tìm kiếm
            cboMaThuocTiemKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMaThuocTiemKiem.AutoCompleteSource = AutoCompleteSource.ListItems;

            SetControlState(false);
            LoadData();
        }

        private void LoadData()
        {
            // Lấy dữ liệu lô thuốc
            string sql = @"SELECT _maLoThuoc, _thuocMa, _soLo, _hanSuDung, _soLuongTon, _donGiaBan FROM LoThuoc";
            dgvLoThuoc.DataSource = Functions.GetDataToTable(sql);
        }

        private void SetControlState(bool editing)
        {
            // Bật tắt các ô nhập liệu
            cboMaLoThuoc.Enabled = editing;
            cboMaThuocTiemKiem.Enabled = editing;
            txtSoLo.Enabled = editing;
            dtpHSD.Enabled = editing;
            txtDonGia.Enabled = editing;
            txtSoLuongTon.Enabled = editing;

            // Bật tắt các nút
            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;
            btnThem.Enabled = !editing;
            btnXoa.Enabled = !editing;
            btnSua.Enabled = !editing;
        }

        private void ResetValues()
        {
            cboMaLoThuoc.Text = "";
            cboMaThuocTiemKiem.SelectedIndex = -1;
            txtSoLo.Text = "";
            dtpHSD.Value = DateTime.Now;
            txtDonGia.Text = "0";
            txtSoLuongTon.Text = "0";
        }

        // ---------- CÁC NÚT CHỨC NĂNG CHÍNH ----------

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            SetControlState(true);
            ResetValues();

            // Tự sinh mã lô gợi ý
            cboMaLoThuoc.Text = "LT" + DateTime.Now.ToString("ddMMyyHHmm");
            cboMaThuocTiemKiem.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboMaLoThuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn lô thuốc cần sửa!", "Thông báo");
                return;
            }
            isAdding = false;
            SetControlState(true);
            cboMaLoThuoc.Enabled = false; // Mã thì không được phép sửa
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboMaLoThuoc.Text) || cboMaThuocTiemKiem.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtSoLo.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã lô, Thuốc và Số lô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLo = cboMaLoThuoc.Text.Trim();
            string maThuoc = cboMaThuocTiemKiem.SelectedValue.ToString();
            string hsd = dtpHSD.Value.ToString("yyyy-MM-dd");

            // Xử lý giá trị số (loại bỏ dấu phẩy nếu có)
            string donGia = txtDonGia.Text.Replace(",", "");
            if (string.IsNullOrEmpty(donGia)) donGia = "0";

            string slTon = txtSoLuongTon.Text;
            if (string.IsNullOrEmpty(slTon)) slTon = "0";

            string sql;
            if (isAdding)
            {
                // Kiểm tra trùng mã
                if (Functions.GetFieldValues($"SELECT _maLoThuoc FROM LoThuoc WHERE _maLoThuoc = '{maLo}'") != "")
                {
                    MessageBox.Show("Mã lô thuốc này đã tồn tại!", "Thông báo");
                    return;
                }

                sql = $@"INSERT INTO LoThuoc (_maLoThuoc, _thuocMa, _soLo, _hanSuDung, _soLuongTon, _donGiaBan) 
                         VALUES ('{maLo}', '{maThuoc}', '{txtSoLo.Text.Trim()}', '{hsd}', {slTon}, {donGia})";
            }
            else
            {
                sql = $@"UPDATE LoThuoc SET _thuocMa = '{maThuoc}', _soLo = '{txtSoLo.Text.Trim()}', 
                         _hanSuDung = '{hsd}', _soLuongTon = {slTon}, _donGiaBan = {donGia} 
                         WHERE _maLoThuoc = '{maLo}'";
            }

            Functions.RunSQL(sql);
            LoadData();
            SetControlState(false);
            isAdding = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboMaLoThuoc.Text)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa lô thuốc này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM LoThuoc WHERE _maLoThuoc = '{cboMaLoThuoc.Text}'";
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

        // ---------- SỰ KIỆN LƯỚI & TÌM KIẾM ----------

        private void dgvLoThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isAdding || e.RowIndex < 0) return;

            if (dgvLoThuoc.CurrentRow != null)
            {
                cboMaLoThuoc.Text = dgvLoThuoc.CurrentRow.Cells["MaLoThuoc"].Value.ToString();
                cboMaThuocTiemKiem.SelectedValue = dgvLoThuoc.CurrentRow.Cells["MaThuoc"].Value.ToString();
                txtSoLo.Text = dgvLoThuoc.CurrentRow.Cells["SoLo"].Value.ToString();
                dtpHSD.Value = Convert.ToDateTime(dgvLoThuoc.CurrentRow.Cells["HanSuDung"].Value);

                // Hiển thị số lượng và format đơn giá
                txtSoLuongTon.Text = dgvLoThuoc.CurrentRow.Cells["SoLuongTon"].Value.ToString();
                txtDonGia.Text = Convert.ToDecimal(dgvLoThuoc.CurrentRow.Cells["DonGia"].Value).ToString("N0");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Tìm kiếm kết hợp theo Mã thuốc (nếu có chọn) và Mã lô/Số lô (nếu có gõ)
            string sql = "SELECT _maLoThuoc, _thuocMa, _soLo, _hanSuDung, _soLuongTon, _donGiaBan FROM LoThuoc WHERE 1=1";

            if (cboMaThuocTiemKiem.SelectedIndex != -1)
            {
                sql += $" AND _thuocMa = '{cboMaThuocTiemKiem.SelectedValue}'";
            }
            if (!string.IsNullOrWhiteSpace(cboMaLoThuoc.Text))
            {
                sql += $" AND _maLoThuoc LIKE '%{cboMaLoThuoc.Text.Trim()}%'";
            }

            dgvLoThuoc.DataSource = Functions.GetDataToTable(sql);
        }

        // ---------- CÁC SỰ KIỆN KHÁC ----------

        private void frmLoThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ProcessTabKey(true);
                e.SuppressKeyPress = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}