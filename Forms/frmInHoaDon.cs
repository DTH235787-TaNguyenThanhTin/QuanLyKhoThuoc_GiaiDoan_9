using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmInHoaDon : Form
    {
        // Khai báo biến ReportViewer
        public ReportViewer rpvHoaDon;
        public string MaHoaDonCanIn { get; set; }

        public frmInHoaDon()
        {
            InitializeComponent();

            // TỰ ĐỘNG VẼ REPORT VIEWER RA MÀN HÌNH MÀ KHÔNG CẦN KÉO THẢ
            rpvHoaDon = new ReportViewer();
            rpvHoaDon.Dock = DockStyle.Fill; // Phình to lấp đầy Form
            this.Controls.Add(rpvHoaDon);    // Gắn vào Form
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
                        LoadReport();
        }

        private void LoadReport()
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
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn để in.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi");
            }
        }
    }
}