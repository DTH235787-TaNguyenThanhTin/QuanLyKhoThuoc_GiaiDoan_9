using System;
using System.Data;
using System.Drawing; // Thêm thư viện này để dùng chức năng đổi màu
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmNhatKy : Form
    {
        public frmNhatKy()
        {
            InitializeComponent();
        }

        private void frmNhatKy_Load(object sender, EventArgs e)
        {
            // Mặc định lọc từ đầu tháng đến hiện tại
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;

            LoadData();
        }

        // Hàm nạp dữ liệu có điều kiện lọc
        private void LoadData()
        {
            try
            {
                string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd 00:00:00");
                string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd 23:59:59");

                // Câu lệnh SQL lấy đúng 5 cột
                string sql = $@"SELECT _maNhanVien, _tenNhanVien, _thoiGianDangNhap, _tenMayTinh, _trangThai 
                                FROM NhatKyDangNhap 
                                WHERE _thoiGianDangNhap BETWEEN '{tuNgay}' AND '{denNgay}'
                                ORDER BY _thoiGianDangNhap DESC";

                DataTable dt = Functions.GetDataToTable(sql);

                // BƯỚC QUAN TRỌNG: Xóa sạch các cột bị dư trên giao diện trước khi nạp
                dgvNhatKy.DataSource = null;
                dgvNhatKy.Columns.Clear();

                // Nạp dữ liệu mới
                dgvNhatKy.DataSource = dt;

                // Định dạng lại lưới sau khi nạp xong
                DinhDangLuoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void DinhDangLuoi()
        {
            if (dgvNhatKy.Columns.Count > 0)
            {
                // Gọi ĐÚNG tên cột trong SQL để đổi tên hiển thị (Không dùng số 0, 1, 2 nữa để tránh lệch)
                dgvNhatKy.Columns["_maNhanVien"].HeaderText = "Mã NV";
                dgvNhatKy.Columns["_tenNhanVien"].HeaderText = "Tên Nhân Viên";
                dgvNhatKy.Columns["_thoiGianDangNhap"].HeaderText = "Thời Gian";
                dgvNhatKy.Columns["_tenMayTinh"].HeaderText = "Tên Máy Tính";
                dgvNhatKy.Columns["_trangThai"].HeaderText = "Trạng Thái";

                // Định dạng ngày giờ
                dgvNhatKy.Columns["_thoiGianDangNhap"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

                // Căn chỉnh tự động cho đẹp
                dgvNhatKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // TIỆN TAY FIX LUÔN TÍNH NĂNG ĐỔI MÀU CHO BẠN
        // Sự kiện này tự động chạy khi DataGridView vẽ dữ liệu lên màn hình
        private void dgvNhatKy_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem có đang vẽ ở cột Trạng Thái không
            if (dgvNhatKy.Columns[e.ColumnIndex].Name == "_trangThai" && e.Value != null)
            {
                string trangThai = e.Value.ToString();

                // Nếu trạng thái là Thất bại (hoặc chữ khác tùy CSDL của bạn), đổi màu nền dòng đó thành màu Đỏ nhạt
                if (trangThai.ToLower().Contains("thất bại") || trangThai.ToLower().Contains("lỗi"))
                {
                    dgvNhatKy.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                    dgvNhatKy.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                // Nếu đăng nhập thành công thì tô màu xanh lá nhạt cho đẹp
                else if (trangThai.ToLower().Contains("đăng nhập") || trangThai.ToLower().Contains("thành công"))
                {
                    dgvNhatKy.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dgvNhatKy.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
                }
            }
        }
    }
}