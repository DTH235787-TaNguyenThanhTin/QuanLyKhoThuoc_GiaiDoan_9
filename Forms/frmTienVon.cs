using ClosedXML.Excel;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmTienVon : Form
    {
        public frmTienVon()
        {
            InitializeComponent();
        }

        private void frmTienVon_Load(object sender, EventArgs e)
        {
            // Mặc định xem thống kê trong ngày hôm nay
            dtpTuNgay.Value = DateTime.Now;
            dtpDenNgay.Value = DateTime.Now;
            txtTienVon.Text = "0";

            // Đăng ký sự kiện thay đổi dữ liệu để tự cập nhật
            dtpTuNgay.ValueChanged += DuLieuThayDoi;
            dtpDenNgay.ValueChanged += DuLieuThayDoi;
            txtTienVon.TextChanged += DuLieuThayDoi;

            // Load dữ liệu lần đầu
            LoadThongKe();

            string usernameDangNhap = "admin"; // Thay bằng biến thực tế của bạn
            txtNhanVien.Text = Functions.GetTenNhanVienByUsername(usernameDangNhap);
            txtNhanVien.ReadOnly = true;
        }

        private void DuLieuThayDoi(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void LoadThongKe()
        {
            try
            {
                // 1. Lấy dữ liệu từ SQL
                string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd 00:00:00");
                string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd 23:59:59");
                string sql = $@"SELECT HD._maHoaDon AS MaHD, ISNULL(KH._hoTen, N'Khách lẻ') AS KhachHang, 
                        NV._hoTen AS NhanVien, HD._ngayLap AS NgayLap, HD._tongTien AS TongTien
                        FROM HoaDon HD
                        LEFT JOIN KhachHang KH ON HD._khachHangMa = KH._maKhachHang
                        JOIN NhanVien NV ON HD._nhanVienMa = NV._maNhanVien
                        WHERE HD._ngayLap >= '{tuNgay}' AND HD._ngayLap <= '{denNgay}'";

                DataTable dt = Functions.GetDataToTable(sql);
                dgvHoaDon.DataSource = dt;

                // 2. Tính Tổng Doanh Thu từ lưới
                decimal tongDoanhThu = 0;
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        tongDoanhThu += Convert.ToDecimal(row["TongTien"]);
                    }
                }

                // 3. XỬ LÝ TIỀN VỐN (Quan trọng)
                decimal tienVon = 50000000;
                // Loại bỏ các ký tự không phải số (như dấu phẩy, chữ VNĐ) trước khi Parse
                string rawTienVon = txtTienVon.Text.Replace(",", "").Replace(".", "").Replace("VNĐ", "").Trim();
                decimal.TryParse(rawTienVon, out tienVon);

                decimal tongTrongKet = tienVon + tongDoanhThu;

                // 4. Hiển thị lên Label
                lblTongDoanhThu.Text = tongDoanhThu.ToString("N0") + " VNĐ";
                lblTongTienTrongKet.Text = tongTrongKet.ToString("N0") + " VNĐ";
            }
            catch (Exception ex) { /* Tránh hiện lỗi khi đang gõ dở */ }
        }

        // Chỉ cho phép nhập số vào ô tiền vốn
        private void txtTienVon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Truyền dữ liệu sang Form In
        private void btnInTK_Click(object sender, EventArgs e)
        {
            frmInDoanhThu frmIn = new frmInDoanhThu();

            // Truyền ngày lọc SQL
            frmIn.TuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd 00:00:00");
            frmIn.DenNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd 23:59:59");

            // Truyền tham số hiển thị (Parameters)
            frmIn.In_TuNgay = dtpTuNgay.Value.ToString("dd/MM/yyyy");
            frmIn.In_DenNgay = dtpDenNgay.Value.ToString("dd/MM/yyyy");

            // Lấy giá trị tiền vốn từ TextBox, nếu trống thì để "0 VNĐ"
            decimal.TryParse(txtTienVon.Text.Replace("50000000", ""), out decimal von);
            frmIn.In_TienVon = von.ToString("N0") + " VNĐ";

            // Lấy trực tiếp từ Label đã tính ở bước trên
            frmIn.In_TongDoanhThu = lblTongDoanhThu.Text;
            frmIn.In_TongTien = lblTongTienTrongKet.Text;

            frmIn.ShowDialog();
        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dữ liệu để xuất không
            if (dgvHoaDon.Rows.Count == 0 || dgvHoaDon.DataSource == null)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại chọn nơi lưu file
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            sfd.FileName = "ThongKeDoanhThu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Bắt đầu tạo file Excel
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        // Tạo một Sheet tên là DoanhThu
                        var worksheet = workbook.Worksheets.Add("DoanhThu");

                        // =====================================
                        // 1. TẠO PHẦN HEADER (THÔNG TIN CHUNG)
                        // =====================================
                        worksheet.Cell(1, 1).Value = "BÁO CÁO THỐNG KÊ DOANH THU";
                        worksheet.Range("A1:E1").Merge().Style.Font.SetBold().Font.FontSize = 16;
                        worksheet.Range("A1:E1").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                        worksheet.Cell(3, 1).Value = "Từ ngày: " + dtpTuNgay.Value.ToString("dd/MM/yyyy");
                        worksheet.Cell(3, 3).Value = "Đến ngày: " + dtpDenNgay.Value.ToString("dd/MM/yyyy");

                        worksheet.Cell(4, 1).Value = "Tổng doanh thu: " + lblTongDoanhThu.Text;
                        worksheet.Cell(4, 3).Value = "Tổng tiền trong két: " + lblTongTienTrongKet.Text;
                        worksheet.Range("A3:E4").Style.Font.SetBold();

                        // =====================================
                        // 2. TẠO TIÊU ĐỀ CỘT CHO BẢNG
                        // =====================================
                        int headerRow = 6;
                        for (int i = 0; i < dgvHoaDon.Columns.Count; i++)
                        {
                            worksheet.Cell(headerRow, i + 1).Value = dgvHoaDon.Columns[i].HeaderText;
                            // Tô màu nền xanh, chữ trắng cho đẹp
                            worksheet.Cell(headerRow, i + 1).Style.Fill.BackgroundColor = XLColor.Teal;
                            worksheet.Cell(headerRow, i + 1).Style.Font.FontColor = XLColor.White;
                            worksheet.Cell(headerRow, i + 1).Style.Font.SetBold();
                        }

                        // =====================================
                        // 3. ĐỔ DỮ LIỆU TỪ DATAGRIDVIEW VÀO EXCEL
                        // =====================================
                        int currentRow = headerRow + 1;
                        for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvHoaDon.Columns.Count; j++)
                            {
                                var cellValue = dgvHoaDon.Rows[i].Cells[j].Value;
                                worksheet.Cell(currentRow, j + 1).Value = cellValue != null ? cellValue.ToString() : "";
                            }
                            currentRow++;
                        }

                        // Căn chỉnh độ rộng cột tự động cho vừa chữ
                        worksheet.Columns().AdjustToContents();

                        // Kẻ khung viền cho bảng
                        worksheet.Range(headerRow, 1, currentRow - 1, dgvHoaDon.Columns.Count).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                        worksheet.Range(headerRow, 1, currentRow - 1, dgvHoaDon.Columns.Count).Style.Border.SetInsideBorder(XLBorderStyleValues.Thin);

                        // =====================================
                        // 4. LƯU FILE VÀ MỞ LÊN
                        // =====================================
                        workbook.SaveAs(sfd.FileName);

                        DialogResult dr = MessageBox.Show("Xuất file Excel thành công! Bạn có muốn mở file lên xem không?", "Thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}