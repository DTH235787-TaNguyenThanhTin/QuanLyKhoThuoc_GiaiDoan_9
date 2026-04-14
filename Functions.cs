using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhoThuoc
{
    public class Functions
    {
        public static SqlConnection Con;
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhoThuoc;Integrated Security=True;TrustServerCertificate=True;";

        // Lưu thông tin phiên đăng nhập hiện tại
        public static string MaNhanVienDangNhap = "";
        public static string TenNhanVienDangNhap = "";

        // Phân quyền: 1 = Quản lý, 0 (hoặc khác 1) = Nhân viên
        public static int QuyenHanDangNhap = 0;
        
        public static void Connect()
        {
            try
            {
                if (Con == null) Con = new SqlConnection(connectionString);
                if (Con.State == ConnectionState.Closed) Con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến Cơ sở dữ liệu:\n" + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string GetTenNhanVienByUsername(string username)
        {
            // Truy vấn vào bảng NhanVien dựa trên cột _tenDangNhap
            string sql = $"SELECT _hoTen FROM NhanVien WHERE _tenDangNhap = '{username}'";
            DataTable dt = GetDataToTable(sql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["_hoTen"].ToString();
            }
            return "";
        }
        public static void Disconnect()
        {
            if (Con != null && Con.State == ConnectionState.Open)
            {
                Con.Close();
                Con.Dispose();
                Con = null;
            }
        }
        
        // Hàm lấy dữ liệu ra một Bảng (Dùng để đổ vào DataGridView)
        public static DataTable GetDataToTable(string sql)
        {
            Connect();
            DataTable table = new DataTable();
            try
            {
                using (SqlDataAdapter dap = new SqlDataAdapter(sql, Con))
                {
                    dap.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return table;
        }

        // Hàm thực thi các lệnh Thêm, Sửa, Xóa
        public static void RunSQL(string sql)
        {
            Connect();
            using (SqlCommand cmd = new SqlCommand(sql, Con))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thực thi lệnh SQL: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw; // Ném lỗi ra ngoài để các Form bắt được và ngưng tiến trình
                }
            }
        }

        // Hàm lấy ra một giá trị duy nhất (Ví dụ: Tính tổng doanh thu, đếm số lượng...)
        public static string GetFieldValues(string sql)
        {
            Connect();
            string result = "";
            using (SqlCommand cmd = new SqlCommand(sql, Con))
            {
                try
                {
                    object obj = cmd.ExecuteScalar();
                    if (obj != null && obj != DBNull.Value) result = obj.ToString();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi lấy dữ liệu: " + ex.Message); }
            }
            return result;
        }

        // Hàm kiểm tra trùng lặp (Ví dụ: Mã nhân viên này đã tồn tại chưa?)
        public static bool CheckKey(string sql)
        {
            Connect();
            using (SqlDataAdapter dap = new SqlDataAdapter(sql, Con))
            {
                DataTable table = new DataTable();
                dap.Fill(table);
                if (table.Rows.Count > 0) return true; // Đã tồn tại
                else return false; // Chưa tồn tại
            }
        }
        
        // Đổ dữ liệu vào ComboBox nhanh chóng
        public static void FillCombo(string sql, ComboBox cbo, string valueField, string displayField)
        {
            DataTable dt = GetDataToTable(sql);
            cbo.DataSource = dt;
            cbo.ValueMember = valueField;
            cbo.DisplayMember = displayField;
        }

        // Hàm sinh mã tự động (Ví dụ: HD001, HD002)
        public static string SinhMaTuDong(string bang, string cot, string tienTo)
        {
            string sql = $"SELECT TOP 1 {cot} FROM {bang} WHERE {cot} LIKE '{tienTo}%' ORDER BY {cot} DESC";
            string maCu = GetFieldValues(sql);
            if (string.IsNullOrEmpty(maCu)) return tienTo + "001";

            string soPhan = maCu.Substring(tienTo.Length);
            if (int.TryParse(soPhan, out int so))
            {
                return tienTo + (so + 1).ToString("D3");
            }
            return tienTo + "001";
        }

        // Hàm ghi lại lịch sử đăng nhập/đăng xuất
        public static void LuuNhatKy(string maNV, string tenNV, string trangThai)
        {
            string tenMay = Environment.MachineName;
            string sql = $"INSERT INTO NhatKyDangNhap(_maNhanVien, _tenNhanVien, _thoiGianDangNhap, _tenMayTinh, _trangThai) " +
                         $"VALUES('{maNV}', N'{tenNV}', GETDATE(), N'{tenMay}', N'{trangThai}')";
            try
            {
                RunSQL(sql);
            }
            catch { /* Ngậm lỗi để không làm treo App nếu SQL NhatKy lỗi */ }
        }
       
        public static void ApplyTheme(Form frm)
        {
            // 1. ÁP DỤNG FONT CHỮ
            string fontName = Properties.Settings.Default.AppFontName;
            float fontSize = Properties.Settings.Default.AppFontSize;
            if (string.IsNullOrEmpty(fontName)) fontName = "Segoe UI";
            if (fontSize <= 0) fontSize = 10f;
            frm.Font = new Font(fontName, fontSize);

            // 2. ÁP DỤNG NỀN TỐI/SÁNG
            string theme = Properties.Settings.Default.Theme;
            if (theme == "Dark")
            {
                frm.BackColor = Color.FromArgb(45, 45, 48);
                frm.ForeColor = Color.White;
            }
            else
            {
                frm.BackColor = SystemColors.Control;
                frm.ForeColor = Color.Black;
            }

            // 3. ÁP DỤNG MÀU CHỦ ĐẠO
            string hexColor = Properties.Settings.Default.MainColor;
            Color mauChuDao;
            try { mauChuDao = ColorTranslator.FromHtml(hexColor); }
            catch { mauChuDao = Color.DodgerBlue; }

            // 4. ĐỔI MÀU NÚT BẤM
            DoiMauCacControl(frm.Controls, mauChuDao);
        }

        private static void DoiMauCacControl(Control.ControlCollection controls, Color mauChuDao)
        {
            foreach (Control c in controls)
            {
                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.ForeColor = Color.White;
                    btn.BackColor = mauChuDao;
                }

                // Đệ quy để tìm vào sâu bên trong Panel, GroupBox
                if (c.HasChildren)
                {
                    DoiMauCacControl(c.Controls, mauChuDao);
                }
            }
        }

    }
}