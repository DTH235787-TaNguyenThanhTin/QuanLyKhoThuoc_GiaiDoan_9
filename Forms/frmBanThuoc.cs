using Microsoft.Reporting.WinForms;
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
    public partial class frmBanThuoc : Form
    {
        public ReportViewer rpvHoaDon;
        public frmBanThuoc()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void LoadComboThuoc()
        {
            string sql = @"SELECT L._maLoThuoc, T._tenThuoc + ' (Tồn: ' + CAST(L._soLuongTon AS VARCHAR) + ')' AS _thongTin 
                           FROM LoThuoc L JOIN Thuoc T ON L._thuocMa = T._maThuoc WHERE L._soLuongTon > 0";
            Functions.FillCombo(sql, cboTenThuoc, "_maLoThuoc", "_thongTin");
            cboTenThuoc.SelectedIndex = -1;
        }

        private void ResetForm()
        {
            txtMaHD.Text = Functions.SinhMaTuDong("HoaDon", "_maHoaDon", "HD");
            txtSDT.Text = "";
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            dgvDSThuoc.Rows.Clear();
            txtTongTien.Text = "0";
            txtTienKhachDua.Text = "";
            txtTienThoi.Text = "0";
            btnThemKH.Enabled = false;
            ResetPhanChonThuoc();
        }
        private void LoadReport(string MaHoaDonCanIn)
        {
            try
            {
                // 1. Lấy dữ liệu hóa đơn cần in
                string sql = $@"
                SELECT
        HD._maHoaDon AS MaHoaDon,
        ISNULL(KH._hoTen, N'Khách lẻ') AS TenKhachHang,
        HD._ngayLap AS NgayLap,
        NV._hoTen AS TenNhanVien,
        HD._tongTien AS TongTien,
        N'Đã thanh toán' AS TongTienBangChu,


        --Phần đánh số thứ tự
        ROW_NUMBER() OVER(ORDER BY CT._maLoThuoc) AS STT,


        --Dữ liệu chi tiết thuốc nối qua bảng LoThuoc của bạn
        T._tenThuoc AS TenThuoc,
        T._donVi AS DonViTinh,
        CT._soLuongBan AS SoLuong,
        CT._donGiaBan AS DonGia,
        CT._thanhTien AS ThanhTien

        FROM HoaDon HD
        JOIN HoaDonChiTiet CT ON HD._maHoaDon = CT._hoaDonMa
        -- ĐIỂM MẤU CHỐT: Nối qua bảng LoThuoc theo đúng CSDL của bạn
        JOIN LoThuoc LT ON CT._maLoThuoc = LT._maLoThuoc
        JOIN Thuoc T ON LT._thuocMa = T._maThuoc

        -- Nối để lấy thông tin Header
        JOIN NhanVien NV ON HD._nhanVienMa = NV._maNhanVien
        LEFT JOIN KhachHang KH ON HD._khachHangMa = KH._maKhachHang


        WHERE HD._maHoaDon = '{MaHoaDonCanIn}'";
                DataTable dt = Functions.GetDataToTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    // 2. Thiết lập ReportViewer
                    rpvHoaDon.LocalReport.ReportPath = "Reports/rpHoaDon.rdlc"; // Đường dẫn đến file .rdlc
                    rpvHoaDon.LocalReport.DataSources.Clear();
                    rpvHoaDon.LocalReport.DataSources.Add(new ReportDataSource("DataSetHoaDon", dt)); // "DataSetHoaDon" phải trùng với tên DataSet trong .rdlc
                                                                                                      // 3. Refresh để hiển thị báo cáo
                    rpvHoaDon.RefreshReport();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi");
            }
        }
        private void ResetPhanChonThuoc()
        {
            cboTenThuoc.SelectedIndex = -1;
            numSoLuong.Value = 0;
            txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
        }
        private void cboTenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenThuoc.SelectedValue != null && cboTenThuoc.SelectedIndex != -1)
            {
                string gia = Functions.GetFieldValues($"SELECT _donGiaBan FROM LoThuoc WHERE _maLoThuoc = '{cboTenThuoc.SelectedValue}'");
                txtDonGia.Text = decimal.TryParse(gia, out decimal d) ? d.ToString("N0") : "0";
                numSoLuong.Value = 1;
            }
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            decimal gia = decimal.Parse(txtDonGia.Text.Replace(",", ""));
            txtThanhTien.Text = (gia * numSoLuong.Value).ToString("N0");
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tong = decimal.Parse(txtTongTien.Text.Replace(",", ""));
                decimal khachDua = string.IsNullOrEmpty(txtTienKhachDua.Text) ? 0 : decimal.Parse(txtTienKhachDua.Text);
                txtTienThoi.Text = (khachDua - tong).ToString("N0");
            }
            catch { }
        }

        private void TinhTongHoaDon()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvDSThuoc.Rows)
            {
                // Skip the new row at the bottom
                if (row.IsNewRow) continue;
                
                // Add to total instead of replacing it
                if (row.Cells[4].Value != null)
                {
                    tong += decimal.Parse(row.Cells[4].Value.ToString());
                }
            }
            txtTongTien.Text = tong.ToString("N0");
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSDT.Text)) return;
            string sql = $"SELECT _maKhachHang, _hoTen, _diaChi FROM KhachHang WHERE _dienThoai = '{txtSDT.Text}'";
            DataTable dt = Functions.GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                txtMaKH.Text = dt.Rows[0]["_maKhachHang"].ToString();
                txtTenKH.Text = dt.Rows[0]["_hoTen"].ToString();
                txtDiaChi.Text = dt.Rows[0]["_diaChi"].ToString();
                btnThemKH.Enabled = false;
            }
            else
            {
                SinhMaKhachHangTuDong();
                btnThemKH.Enabled = true;
            }

        }

        private void frmBanThuoc_Load(object sender, EventArgs e)
        {
            // Khóa các ô chỉ hiển thị
            txtMaHD.ReadOnly = true;
            txtMaKH.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtTienThoi.ReadOnly = true;

            // Gắn sự kiện tính toán tự động
            cboTenThuoc.SelectedIndexChanged += cboTenThuoc_SelectedIndexChanged;
            numSoLuong.ValueChanged += numSoLuong_ValueChanged;
            txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged;
            LoadReport("");
            LoadComboThuoc();
            ResetForm();

            if (!string.IsNullOrEmpty(Functions.TenNhanVienDangNhap))
            {
                txtTenNV.Text = Functions.TenNhanVienDangNhap;
            }
            else
            {
                txtTenNV.Text = "Chưa có nhân viên";
            }

            // Khóa ô này lại để người dùng không sửa tay được
            txtTenNV.ReadOnly = true;

            // Ẩn cột Mã Lô trong DataGridView
            DataGridViewTextBoxColumn colMaLo = new DataGridViewTextBoxColumn();
            colMaLo.Name = "MaLoThuoc";
            colMaLo.HeaderText = "Mã Lô";
            colMaLo.Visible = false; // Ẩn nó khỏi người dùng
            dgvDSThuoc.Columns.Add(colMaLo);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboTenThuoc.SelectedIndex == -1 || numSoLuong.Value <= 0) return;

            string maLo = cboTenThuoc.SelectedValue.ToString();
            string ten = cboTenThuoc.Text;
            int sl = (int)numSoLuong.Value;
            string gia = txtDonGia.Text;
            string tt = txtThanhTien.Text;

            // Kiểm tra tồn kho trước khi thêm vào lưới
            int ton = int.Parse(Functions.GetFieldValues($"SELECT _soLuongTon FROM LoThuoc WHERE _maLoThuoc = '{maLo}'"));
            if (sl > ton) { MessageBox.Show("Không đủ hàng!"); return; }

            // Thêm vào DataGridView (Cấu hình cột: STT, Tên, SL, Giá, Thành Tiền, Mã Lô ẩn)
            dgvDSThuoc.Rows.Add(dgvDSThuoc.Rows.Count, ten, sl, gia, tt, maLo);
            TinhTongHoaDon();
            ResetPhanChonThuoc();
        }
        private void SinhMaKhachHangTuDong()
        {
            // 1. Lấy mã khách hàng lớn nhất hiện có trong CSDL
            string sql = "SELECT TOP 1 _maKhachHang FROM KhachHang ORDER BY _maKhachHang DESC";
            string lastId = Functions.GetFieldValues(sql);

            int nextNum = 1;

            // 2. Kiểm tra nếu đã có dữ liệu
            if (!string.IsNullOrEmpty(lastId) && lastId.Length >= 3)
            {
                try
                {
                    // Cắt chuỗi từ vị trí thứ 2 (bỏ "KH") và chuyển sang kiểu số
                    string phanSo = lastId.Substring(2);
                    nextNum = int.Parse(phanSo) + 1;
                }
                catch
                {
                    // Phòng trường hợp mã trong DB bị sai định dạng (ví dụ: "ABC", "123")
                    nextNum = 1;
                }
            }

            // 3. Gán mã mới vào TextBox (D3 đảm bảo định dạng 001, 002...)
            txtMaKH.Text = "KH" + nextNum.ToString("D3");

            // 4. Đưa con trỏ vào ô tên khách hàng để nhập liệu ngay
            txtTenKH.Focus();
        }


        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKH.Text)) return;
            string gioiTinh = rdNam.Checked ? "Nam" : "Nữ";
            string sql = $"INSERT INTO KhachHang (_maKhachHang, _hoTen, _dienThoai, _diaChi,_gioiTinh) VALUES ('{txtMaKH.Text}', N'{txtTenKH.Text}', '{txtSDT.Text}', N'{txtDiaChi.Text}', N'{gioiTinh}')";
            Functions.RunSQL(sql);
            MessageBox.Show("Đã thêm khách hàng mới!");
            btnThemKH.Enabled = false;
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e) => ResetForm();





        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvDSThuoc.Rows.Count == 0 || string.IsNullOrEmpty(txtMaKH.Text)) return;

            string maHD = txtMaHD.Text;
            string maNV = string.IsNullOrEmpty(Functions.MaNhanVienDangNhap) ? "NV01" : Functions.MaNhanVienDangNhap;
            decimal tong = decimal.Parse(txtTongTien.Text.Replace(",", ""));

            // 1. Lưu Hóa Đơn
            string sql = $@"INSERT INTO HoaDon (_maHoaDon, _nhanVienMa, _khachHangMa, _ngayLap, _tongTien) 
                VALUES ('{maHD}', '{maNV}', '{txtMaKH.Text}', GETDATE(), {tong})";

            Functions.RunSQL(sql);
            
            // 2. Lưu Chi Tiết & Trừ Kho
            foreach (DataGridViewRow row in dgvDSThuoc.Rows)
            {
                // Skip the new row placeholder
                if (row.IsNewRow) continue;
                
                string maLo = row.Cells["MaLoThuoc"].Value.ToString();
                int sl = int.Parse(row.Cells["SoLuong"].Value.ToString());
                decimal gia = decimal.Parse(row.Cells["DonGia"].Value.ToString().Replace(",", ""));
                string maCT = "CTHD" + DateTime.Now.ToString("mmss") + row.Index;

                Functions.RunSQL($"INSERT INTO HoaDonChiTiet VALUES('{maCT}', '{maHD}', '{maLo}', {sl}, {gia})");
                Functions.RunSQL($"UPDATE LoThuoc SET _soLuongTon = _soLuongTon - {sl} WHERE _maLoThuoc = '{maLo}'");
            }

            MessageBox.Show("Thanh toán thành công!");
           
            LoadComboThuoc();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn hóa đơn nào trên màn hình chưa
            // Giả sử mã hóa đơn đang hiển thị ở ô txtMaHD
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn trong danh sách để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Gọi Form In hóa đơn lên
            frmInHoaDon frmIn = new frmInHoaDon();

            // 3. Truyền cái Mã hóa đơn từ Form này sang biến MaHoaDonCanIn của Form In
            frmIn.MaHoaDonCanIn = txtMaHD.Text;

            // 4. Mở màn hình In lên
            frmIn.ShowDialog();
        }

        private void btnHuy_Click(object sender, EventArgs e) => ResetForm();



        private void dgvDSThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && MessageBox.Show("Xóa món này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvDSThuoc.Rows.RemoveAt(e.RowIndex);
                TinhTongHoaDon();
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length == 10)
            {
                string sql = $"SELECT _maKhachHang, _hoTen, _diaChi FROM KhachHang WHERE _dienThoai = '{txtSDT.Text}'";
                DataTable dt = Functions.GetDataToTable(sql);

                if (dt.Rows.Count > 0)
                {
                    txtMaKH.Text = dt.Rows[0]["_maKhachHang"].ToString();
                    txtTenKH.Text = dt.Rows[0]["_hoTen"].ToString();
                    txtDiaChi.Text = dt.Rows[0]["_diaChi"].ToString();
                    btnThemKH.Enabled = false;
                }
                else
                {
                    SinhMaKhachHangTuDong();
                    btnThemKH.Enabled = true;
                }
            }
        }
    }
}
