using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmInDoanhThu : Form
    {
        public ReportViewer rpvDoanhThu;

        // 1. Dùng để lọc dữ liệu SQL
        public string TuNgay { get; set; }
        public string DenNgay { get; set; }

        // 2. Dùng để in ra giấy (Parameter)
        public string In_TuNgay { get; set; }
        public string In_DenNgay { get; set; }
        public string In_TienVon { get; set; }
        public string In_TongDoanhThu { get; set; }
        public string In_TongTien { get; set; }

        public frmInDoanhThu()
        {
            InitializeComponent();
            rpvDoanhThu = new ReportViewer();
            rpvDoanhThu.Dock = DockStyle.Fill;
            this.Controls.Add(rpvDoanhThu);
        }

        private void frmInDoanhThu_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                // Câu lệnh SQL giữ nguyên, chỉ lấy dữ liệu Hóa Đơn
                string sql = $@"
                    SELECT
                        HD._maHoaDon AS MaHoaDon,
                        HD._ngayLap AS NgayLap,
                        NV._hoTen AS TenNhanVien,
                        HD._tongTien AS ThanhTien
                    FROM HoaDon HD
                    JOIN NhanVien NV ON HD._nhanVienMa = NV._maNhanVien
                    WHERE HD._ngayLap >= '{TuNgay}' AND HD._ngayLap <= '{DenNgay}'
                    ORDER BY HD._ngayLap DESC";

                DataTable dt = Functions.GetDataToTable(sql);

                if (dt != null && dt.Rows.Count > 0)
                {
                    rpvDoanhThu.LocalReport.ReportPath = "Reports/rpDoanhThu.rdlc";
                    rpvDoanhThu.LocalReport.DataSources.Clear();
                    rpvDoanhThu.LocalReport.DataSources.Add(new ReportDataSource("DataSetDoanhThu", dt));

                    // ==========================================
                    // ĐOẠN MỚI: TRUYỀN PARAMETER VÀO REPORT
                    // ==========================================
                    ReportParameter[] param = new ReportParameter[5];
                    param[0] = new ReportParameter("pTuNgay", In_TuNgay);
                    param[1] = new ReportParameter("pDenNgay", In_DenNgay);
                    param[2] = new ReportParameter("pTienVon", In_TienVon);
                    param[3] = new ReportParameter("pTongDoanhThu", In_TongDoanhThu);
                    param[4] = new ReportParameter("pTongTien", In_TongTien);

                    rpvDoanhThu.LocalReport.SetParameters(param);
                    // ==========================================

                    rpvDoanhThu.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu doanh thu để in.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi");
            }
        }
    }
}