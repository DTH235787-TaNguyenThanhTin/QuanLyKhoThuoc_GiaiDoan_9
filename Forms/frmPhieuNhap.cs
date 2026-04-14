using ClosedXML.Excel;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmPhieuNhap : Form
    {
        private bool isAdding = false;
        public frmPhieuNhap() { InitializeComponent(); }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            // Thiết lập DataGridView
            dgvPhieuNhap.AutoGenerateColumns = false;
            dgvChiTietPhieuNhap.AutoGenerateColumns = false;

            // Nạp dữ liệu vào các ComboBox
            Functions.FillCombo("SELECT _maNhanVien, _hoTen FROM NhanVien", cboNhanVien, "_maNhanVien", "_hoTen");
            Functions.FillCombo("SELECT _maNhaCungCap, _tenNhaCungCap FROM NhaCungCap", cboNhaCungCap, "_maNhaCungCap", "_tenNhaCungCap");
            Functions.FillCombo("SELECT _maThuoc, _tenThuoc FROM Thuoc", cboTenThuoc, "_maThuoc", "_tenThuoc");

            // Mặc định nhân viên là người đang đăng nhập
            cboNhanVien.SelectedValue = Functions.MaNhanVienDangNhap;

            LoadDataMaster();
            TrangThaiPhieu(false);
            Functions.ApplyTheme(this);
        }

        private void TrangThaiPhieu(bool editing)
        {
            btnTaoPhieu.Enabled = !editing;
            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;
            btnXoa.Enabled = !editing;

            txtMaHD.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            cboNhanVien.Enabled = false;
            cboNhaCungCap.Enabled = editing;
            dtpNgayLap.Enabled = editing;

            // Chỉ cho phép nhập thuốc khi đã có mã phiếu hiển thị ở txtMaHD
            bool daCoMa = !string.IsNullOrEmpty(txtMaHD.Text) && !editing;
            groupBox4.Enabled = daCoMa;
            btnThem.Enabled = daCoMa;
            btnXuat.Enabled = daCoMa;
        }

        private void LoadDataMaster()
        {
            // Các bí danh (AS) phải khớp với DataPropertyName trong Designer của bạn
            string sql = @"SELECT P._maPhieuNhap, NV._hoTen AS _maNhanVien, 
                                  NCC._tenNhaCungCap AS _maNhaCungCap, P._ngayNhap, P._tongTien 
                           FROM PhieuNhap P 
                           JOIN NhanVien NV ON P._nhanVienMa = NV._maNhanVien 
                           JOIN NhaCungCap NCC ON P._nhaCungCapMa = NCC._maNhaCungCap";
            DataTable dt = Functions.GetDataToTable(sql);
            dgvPhieuNhap.DataSource = dt;

            

        }

        private void LoadDataDetail(string ma)
        {
            // Các bí danh (AS) phải khớp với DataPropertyName trong Designer của bạn
            string sql = $@"SELECT CT._maPhieuNhapChiTiet, T._tenThuoc, CT._soLo, 
                                   CT._hanSuDung, CT._soLuongNhap, CT._donGiaNhap 
                            FROM PhieuNhapChiTiet CT 
                            JOIN Thuoc T ON CT._thuocMa = T._maThuoc 
                            WHERE CT._phieuNhapMa = '{ma}'";
            DataTable dt = Functions.GetDataToTable(sql);
            dgvChiTietPhieuNhap.DataSource = dt;

            

            // Cập nhật tổng tiền
            decimal tong = 0;
            foreach (DataRow row in dt.Rows)
                tong += Convert.ToDecimal(row["_soLuongNhap"]) * Convert.ToDecimal(row["_donGiaNhap"]);

            txtTongTien.Text = tong.ToString("N0");
            Functions.RunSQL($"UPDATE PhieuNhap SET _tongTien = {tong} WHERE _maPhieuNhap = '{ma}'");
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            isAdding = true;
            txtMaHD.Text = Functions.SinhMaTuDong("PhieuNhap", "_maPhieuNhap", "PN");
            cboNhaCungCap.SelectedIndex = -1;
            txtTongTien.Text = "0";
            dgvChiTietPhieuNhap.DataSource = null;
            TrangThaiPhieu(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!");
                return;
            }

            string sql = $"INSERT INTO PhieuNhap (_maPhieuNhap, _nhanVienMa, _nhaCungCapMa, _ngayNhap, _tongTien) " +
                         $"VALUES('{txtMaHD.Text}', '{cboNhanVien.SelectedValue}', '{cboNhaCungCap.SelectedValue}', '{dtpNgayLap.Value:yyyy-MM-dd}', 0)";
            Functions.RunSQL(sql);

            isAdding = false;
            TrangThaiPhieu(false);
            LoadDataMaster();
            MessageBox.Show("Đã tạo phiếu. Mời nhập chi tiết thuốc ở bên phải.");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboTenThuoc.SelectedValue == null || numSoLuongNhap.Value <= 0 || string.IsNullOrEmpty(txtDonGiaNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin thuốc!");
                return;
            }

            string maPN = txtMaHD.Text;
            string maThuoc = cboTenThuoc.SelectedValue.ToString();
            string soLo = txtSoLo.Text.Trim();
            string maCT = Functions.SinhMaTuDong("PhieuNhapChiTiet", "_maPhieuNhapChiTiet", "CTPN");
            string hsd = dtpHSD.Value.ToString("yyyy-MM-dd");

            // 1. Lưu chi tiết phiếu
            string sqlInsert = $"INSERT INTO PhieuNhapChiTiet VALUES('{maCT}', '{maPN}', '{maThuoc}', '{soLo}', '{hsd}', {numSoLuongNhap.Value}, {txtDonGiaNhap.Text})";
            Functions.RunSQL(sqlInsert);

            // 2. Cập nhật kho (LoThuoc)
            string maLo = maThuoc + "_" + soLo;
            if (Functions.CheckKey($"SELECT _maLoThuoc FROM LoThuoc WHERE _maLoThuoc = '{maLo}'"))
                Functions.RunSQL($"UPDATE LoThuoc SET _soLuongTon = _soLuongTon + {numSoLuongNhap.Value} WHERE _maLoThuoc = '{maLo}'");
            else
                Functions.RunSQL($"INSERT INTO LoThuoc VALUES('{maLo}', '{maThuoc}', '{soLo}', '{hsd}', {numSoLuongNhap.Value}, {txtDonGiaNhap.Text})");

            LoadDataDetail(maPN);
            LoadDataMaster();
            ResetInputDetail();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem đã chọn phiếu nhập nào trên lưới dgvPhieuNhap chưa
            if (dgvPhieuNhap.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy thông tin Header (Thông tin chung) từ dòng đang chọn
            string maPN = dgvPhieuNhap.CurrentRow.Cells["MaPhieuNhap"].Value.ToString();
            string ncc = dgvPhieuNhap.CurrentRow.Cells["MaNhaCungCap"].Value.ToString();
            string ngayNhap = Convert.ToDateTime(dgvPhieuNhap.CurrentRow.Cells["NgayNhap"].Value).ToString("dd/MM/yyyy");
            string nhanVien = dgvPhieuNhap.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            string tongTienPN = dgvPhieuNhap.CurrentRow.Cells["TongTien"].Value.ToString();

            // 3. Truy vấn dữ liệu Chi tiết phiếu nhập từ CSDL
            string sqlChiTiet = $@"
        SELECT 
            T._tenThuoc AS TenThuoc,
            CT._soLo AS SoLo,
            CT._hanSuDung AS HSD,
            CT._soLuongNhap AS SL,
            CT._donGiaNhap AS DonGia,
            (CT._soLuongNhap * CT._donGiaNhap) AS ThanhTien
        FROM PhieuNhapChiTiet CT
        JOIN Thuoc T ON CT._thuocMa = T._maThuoc
        WHERE CT._phieuNhapMa = '{maPN}'";

            DataTable dtChiTiet = Functions.GetDataToTable(sqlChiTiet);

            // 4. Mở hộp thoại lưu file
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx", FileName = $"PhieuNhap_{maPN}.xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var ws = workbook.Worksheets.Add("ChiTietPhieuNhap");

                        // --- PHẦN TIÊU ĐỀ CHÍNH ---
                        ws.Cell("A1").Value = "PHIẾU NHẬP KHO THUỐC";
                        ws.Range("A1:F1").Merge().Style.Font.SetBold().Font.FontSize = 20;
                        ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        // --- PHẦN THÔNG TIN CHUNG (HEADER) ---
                        ws.Cell("A3").Value = "Mã phiếu nhập:"; ws.Cell("B3").Value = maPN;
                        ws.Cell("A4").Value = "Nhà cung cấp:"; ws.Cell("B4").Value = ncc;
                        ws.Cell("D3").Value = "Ngày nhập:"; ws.Cell("E3").Value = ngayNhap;
                        ws.Cell("D4").Value = "Người lập:"; ws.Cell("E4").Value = nhanVien;
                        ws.Range("A3:E4").Style.Font.SetBold();

                        // --- TIÊU ĐỀ BẢNG DỮ LIỆU ---
                        string[] headers = { "Tên Thuốc", "Số Lô", "Hạn Sử Dụng", "Số Lượng", "Đơn Giá", "Thành Tiền" };
                        for (int i = 0; i < headers.Length; i++)
                        {
                            var cell = ws.Cell(6, i + 1);
                            cell.Value = headers[i];
                            cell.Style.Fill.BackgroundColor = XLColor.FromHtml("#366092"); // Màu xanh đậm
                            cell.Style.Font.FontColor = XLColor.White;
                            cell.Style.Font.SetBold();
                            cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        }

                        // --- ĐỔ DỮ LIỆU TỪ DATATABLE VÀO EXCEL ---
                        int rowStart = 7;
                        for (int i = 0; i < dtChiTiet.Rows.Count; i++)
                        {
                            ws.Cell(rowStart + i, 1).Value = dtChiTiet.Rows[i]["TenThuoc"].ToString();
                            ws.Cell(rowStart + i, 2).Value = dtChiTiet.Rows[i]["SoLo"].ToString();
                            ws.Cell(rowStart + i, 3).Value = Convert.ToDateTime(dtChiTiet.Rows[i]["HSD"]).ToString("dd/MM/yyyy");
                            ws.Cell(rowStart + i, 4).Value = dtChiTiet.Rows[i]["SL"].ToString();
                            ws.Cell(rowStart + i, 5).Value = Convert.ToDecimal(dtChiTiet.Rows[i]["DonGia"]).ToString("N0");
                            ws.Cell(rowStart + i, 6).Value = Convert.ToDecimal(dtChiTiet.Rows[i]["ThanhTien"]).ToString("N0");
                        }

                        int lastRow = rowStart + dtChiTiet.Rows.Count - 1;

                        // --- TỔNG CỘNG ---
                        ws.Cell(lastRow + 2, 5).Value = "TỔNG TIỀN PHIẾU:";
                        ws.Cell(lastRow + 2, 6).Value = Convert.ToDecimal(tongTienPN).ToString("N0") + " VNĐ";
                        ws.Range(lastRow + 2, 5, lastRow + 2, 6).Style.Font.SetBold().Font.FontColor = XLColor.Red;

                        // Kẻ khung (Borders) và căn chỉnh tự động
                        var rangeTable = ws.Range(6, 1, lastRow, 6);
                        rangeTable.Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Border.SetInsideBorder(XLBorderStyleValues.Thin);
                        ws.Columns().AdjustToContents();

                        // 5. Lưu và mở file
                        workbook.SaveAs(sfd.FileName);
                        Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Lấy mã từ cột có tên "MaPhieuNhap" (tên Name trong Designer)
            string ma = dgvPhieuNhap.Rows[e.RowIndex].Cells["MaPhieuNhap"].Value.ToString();
            txtMaHD.Text = ma;

            // Hiển thị lại nhà cung cấp
            string sql = $"SELECT _nhaCungCapMa FROM PhieuNhap WHERE _maPhieuNhap = '{ma}'";
            cboNhaCungCap.SelectedValue = Functions.GetFieldValues(sql);

            LoadDataDetail(ma);
            TrangThaiPhieu(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text)) return;

            string check = Functions.GetFieldValues($"SELECT COUNT(*) FROM PhieuNhapChiTiet WHERE _phieuNhapMa = '{txtMaHD.Text}'");
            if (check != "0")
            {
                MessageBox.Show("Phải xóa hết chi tiết thuốc trước khi xóa phiếu!");
                return;
            }

            if (MessageBox.Show("Xóa phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Functions.RunSQL($"DELETE FROM PhieuNhap WHERE _maPhieuNhap = '{txtMaHD.Text}'");
                txtMaHD.Text = "";
                LoadDataMaster();
                dgvChiTietPhieuNhap.DataSource = null;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            TrangThaiPhieu(false);
            LoadDataMaster();
        }

        private void ResetInputDetail()
        {
            cboTenThuoc.SelectedIndex = -1;
            txtSoLo.Text = "";
            numSoLuongNhap.Value = 0;
            txtDonGiaNhap.Text = "0";
            txtMaPhieuNhapCT.Text = Functions.SinhMaTuDong("PhieuNhapChiTiet", "_maPhieuNhapChiTiet", "CTPN");
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            // Giả sử txtMaPhieu là ô hiển thị mã phiếu trên màn hình
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập trong danh sách để in!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmInPhieuNhap frmIn = new frmInPhieuNhap();

            // Truyền mã phiếu nhập sang form in
            frmIn.MaPhieuCanIn = txtMaHD.Text;

            // Bật form in lên
            frmIn.ShowDialog();
        }
    }
}