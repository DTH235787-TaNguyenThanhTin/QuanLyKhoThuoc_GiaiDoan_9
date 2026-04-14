using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms; // Bắt buộc phải có để chạy Báo cáo

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmInPhieuNhap : Form
    {
        // Khai báo công cụ ReportViewer
        public ReportViewer rpvPhieuNhap;

        // Biến để hứng Mã phiếu nhập truyền từ form Danh sách sang
        public string MaPhieuCanIn { get; set; }

        public frmInPhieuNhap()
        {
            InitializeComponent();

            // Tự động vẽ Report Viewer lấp đầy màn hình (Không cần kéo thả)
            rpvPhieuNhap = new ReportViewer();
            rpvPhieuNhap.Dock = DockStyle.Fill;
            this.Controls.Add(rpvPhieuNhap);
        }

        // SỰ KIỆN LOAD: Chạy khi form vừa mở lên
        private void frmInPhieuNhap_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaPhieuCanIn))
            {
                MessageBox.Show("Không có mã phiếu nhập để in!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 1. CÂU LỆNH SQL LẤY DỮ LIỆU TỪ 5 BẢNG (Như đã thống nhất)
                string sql = $@"
                    SELECT 
                        PN._maPhieuNhap AS MaPhieuNhap,
                        PN._ngayNhap AS NgayNhap,
                        NCC._tenNhaCungCap AS NhaCungCap,
                        NV._hoTen AS NhanVienLap,
                        T._tenThuoc AS TenThuoc,
                        T._donVi AS DonViTinh,
                        CT._soLo AS SoLo,
                        CT._hanSuDung AS HanSuDung,
                        CT._soLuongNhap AS SoLuong,
                        CT._donGiaNhap AS DonGia,
                        (CT._soLuongNhap * CT._donGiaNhap) AS ThanhTien
                    FROM PhieuNhap PN
                    JOIN PhieuNhapChiTiet CT ON PN._maPhieuNhap = CT._phieuNhapMa
                    JOIN Thuoc T ON CT._thuocMa = T._maThuoc
                    JOIN NhaCungCap NCC ON PN._nhaCungCapMa = NCC._maNhaCungCap
                    JOIN NhanVien NV ON PN._nhanVienMa = NV._maNhanVien
                    WHERE PN._maPhieuNhap = '{MaPhieuCanIn}'";

                DataTable dt = Functions.GetDataToTable(sql);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu chi tiết của phiếu nhập này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2. CẤU HÌNH VÀ ĐỔ DỮ LIỆU VÀO REPORT
                rpvPhieuNhap.ProcessingMode = ProcessingMode.Local;

                // Trỏ đường dẫn tới file thiết kế phiếu nhập của bạn
                rpvPhieuNhap.LocalReport.ReportPath = @"Reports\rpPhieuNhap.rdlc"; // Đảm bảo đường dẫn này đúng với vị trí file rdlc của bạn

                // Tên "DataSetPhieuNhap" BẮT BUỘC phải khớp với tên DataSet bạn tạo trong file rdlc
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSetPhieuNhap";
                rds.Value = dt;

                rpvPhieuNhap.LocalReport.DataSources.Clear();
                rpvPhieuNhap.LocalReport.DataSources.Add(rds);

                // 3. HIỂN THỊ
                rpvPhieuNhap.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message);
            }
        }
    }
}