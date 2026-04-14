using ClosedXML.Excel;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // 1. Cấu hình bảng: Buộc dùng cột đã vẽ ở Designer
            dgvHoaDon.AutoGenerateColumns = false;
            dgvChiTietHoaDon.AutoGenerateColumns = false;

            // 2. Thiết lập giao diện
            txtMaHD.ReadOnly = true;
            txtNgayLap.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtKH.ReadOnly = true;
            cboNhanVien.Enabled = false;

            // 3. Load dữ liệu
            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            try
            {
                string sql = @"SELECT H._maHoaDon AS MaHD, 
                                      K._hoTen AS KhachHang, 
                                      N._hoTen AS NhanVien, 
                                      H._ngayLap AS NgayLap, 
                                      H._tongTien AS TongTien 
                               FROM HoaDon H
                               LEFT JOIN NhanVien N ON H._nhanVienMa = N._maNhanVien
                               LEFT JOIN KhachHang K ON H._khachHangMa = K._maKhachHang
                               ORDER BY H._ngayLap DESC";

                DataTable dt = Functions.GetDataToTable(sql);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvHoaDon.DataSource = dt;

                    // Đánh số thứ tự
                    for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
                    {
                        dgvHoaDon.Rows[i].Cells[0].Value = (i + 1).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Không có hóa đơn nào.", "Thông báo");
                }

                // Load chi tiết rỗng ban đầu
                LoadChiTietHoaDon("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI SQL: " + ex.Message, "Lỗi nghiêm trọng");
            }
        }

        private void LoadChiTietHoaDon(string maHD)
        {
            try
            {
                // 1. Dọn sạch rác trên bảng
                dgvChiTietHoaDon.DataSource = null;
                dgvChiTietHoaDon.Rows.Clear();

                string maCanTim = maHD.Trim();

                // 2. CÂU LỆNH SQL ĐÃ SỬA CHUẨN (Nối qua 3 bảng)
                string sql = $@"SELECT T._tenThuoc AS TenThuoc, 
                               CT._soLuongBan AS SoLuong, 
                               CT._donGiaBan AS DonGia, 
                               CT._thanhTien AS ThanhTien 
                        FROM HoaDonChiTiet CT
                        JOIN LoThuoc LT ON CT._maLoThuoc = LT._maLoThuoc
                        JOIN Thuoc T ON LT._thuocMa = T._maThuoc
                        WHERE CT._hoaDonMa = '{maHD}'";

                DataTable dt = Functions.GetDataToTable(sql);

                if (dt == null || dt.Rows.Count == 0) return;

                // 3. Ép nạp dữ liệu bằng tay (Cách bọc thép)
                int stt = 1;
                foreach (DataRow row in dt.Rows)
                {
                    dgvChiTietHoaDon.Rows.Add(
                        stt,
                        row["TenThuoc"].ToString(),
                        row["SoLuong"].ToString(),
                        Convert.ToDecimal(row["DonGia"]).ToString("N0"),
                        Convert.ToDecimal(row["ThanhTien"]).ToString("N0")
                    );
                    stt++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Code: " + ex.Message);
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tránh click vào vùng trống gây lỗi
            if (e.RowIndex < 0 || dgvHoaDon.CurrentRow == null) return;

            try
            {
                // 1. Lấy trực tiếp dòng mà chuột bạn vừa click vào
                DataGridViewRow row = dgvHoaDon.CurrentRow;

                // 2. Lấy giá trị trực tiếp từ các ô (Cells) trên màn hình. 
                // Dùng Convert.ToString() để chống lỗi văng app nếu ô đó bị null (trống)
                txtMaHD.Text = Convert.ToString(row.Cells["MaHD"].Value);
                txtKH.Text = Convert.ToString(row.Cells["KhachHang"].Value);
                cboNhanVien.Text = Convert.ToString(row.Cells["NhanVien"].Value);
                txtNgayLap.Text = Convert.ToString(row.Cells["NgayLap"].Value);

                // Định dạng tiền
                string tongTienRaw = Convert.ToString(row.Cells["TongTien"].Value);
                if (decimal.TryParse(tongTienRaw, out decimal tien))
                {
                    txtTongTien.Text = tien.ToString("N0");
                }

                // 3. Lấy mã Hóa Đơn và gọi hàm nạp chi tiết cho bảng bên phải
                string maHD = txtMaHD.Text;
                if (!string.IsNullOrEmpty(maHD))
                {

                    LoadChiTietHoaDon(maHD);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi click: " + ex.Message, "Thông báo");
            }
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

        private void btnXuat_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn hóa đơn nào chưa
            if (dgvHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy thông tin Header từ dòng đang chọn
            string maHD = dgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString();
            string tenKhach = dgvHoaDon.CurrentRow.Cells["KhachHang"].Value.ToString();
            string ngayLap = dgvHoaDon.CurrentRow.Cells["NgayLap"].Value.ToString();
            string tongTien = dgvHoaDon.CurrentRow.Cells["TongTien"].Value.ToString();

            // 3. Truy vấn dữ liệu Chi tiết hóa đơn
            string sqlChiTiet = $@"
        SELECT T._tenThuoc, T._donVi, CT._soLuongBan, CT._donGiaBan, CT._thanhTien
        FROM HoaDonChiTiet CT
        JOIN LoThuoc LT ON CT._maLoThuoc = LT._maLoThuoc
        JOIN Thuoc T ON LT._thuocMa = T._maThuoc
        WHERE CT._hoaDonMa = '{maHD}'";
            DataTable dtChiTiet = Functions.GetDataToTable(sqlChiTiet);

            // 4. Khởi tạo SaveFileDialog
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx", FileName = $"HoaDon_{maHD}.xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var workbook = new XLWorkbook())
                {
                    var ws = workbook.Worksheets.Add("ChiTietHoaDon");

                    // --- TRÌNH BÀY PHẦN HEADER ---
                    ws.Cell("A1").Value = "HÓA ĐƠN BÁN THUỐC";
                    ws.Range("A1:E1").Merge().Style.Font.SetBold().Font.FontSize = 18;
                    ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    ws.Cell("A3").Value = "Mã hóa đơn:"; ws.Cell("B3").Value = maHD;
                    ws.Cell("A4").Value = "Khách hàng:"; ws.Cell("B4").Value = tenKhach;
                    ws.Cell("D3").Value = "Ngày lập:"; ws.Cell("E3").Value = ngayLap;
                    ws.Range("A3:E4").Style.Font.SetBold();

                    // --- TIÊU ĐỀ BẢNG CHI TIẾT ---
                    string[] headers = { "Tên Thuốc", "Đơn Vị", "Số Lượng", "Đơn Giá", "Thành Tiền" };
                    for (int i = 0; i < headers.Length; i++)
                    {
                        var cell = ws.Cell(6, i + 1);
                        cell.Value = headers[i];
                        cell.Style.Fill.BackgroundColor = XLColor.FromHtml("#4F81BD");
                        cell.Style.Font.FontColor = XLColor.White;
                        cell.Style.Font.SetBold();
                    }

                    // --- ĐỔ DỮ LIỆU CHI TIẾT ---
                    int row = 7;
                    foreach (DataRow dr in dtChiTiet.Rows)
                    {
                        ws.Cell(row, 1).Value = dr["_tenThuoc"].ToString();
                        ws.Cell(row, 2).Value = dr["_donVi"].ToString();
                        ws.Cell(row, 3).Value = Convert.ToInt32(dr["_soLuongBan"]);
                        ws.Cell(row, 4).Value = Convert.ToDecimal(dr["_donGiaBan"]);
                        ws.Cell(row, 5).Value = Convert.ToDecimal(dr["_thanhTien"]);
                        row++;
                    }

                    // --- TỔNG CỘNG ---
                    ws.Cell(row + 1, 4).Value = "TỔNG TIỀN:";
                    ws.Cell(row + 1, 5).Value = tongTien + " VNĐ";
                    ws.Range(row + 1, 4, row + 1, 5).Style.Font.SetBold().Font.FontColor = XLColor.Red;

                    // Kẻ khung và căn chỉnh
                    ws.Range(6, 1, row - 1, 5).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Border.SetInsideBorder(XLBorderStyleValues.Thin);
                    ws.Columns().AdjustToContents();

                    workbook.SaveAs(sfd.FileName);
                    Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Để trống hàm này nếu không dùng
        }

        
      
    }
}