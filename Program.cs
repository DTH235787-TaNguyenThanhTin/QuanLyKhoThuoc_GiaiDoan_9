using QuanLyKhoThuoc.Forms;

namespace QuanLyKhoThuoc
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Khởi tạo kết nối tới CSDL ngay khi mở app
            Functions.Connect();

            Application.Run(new frmDangNhap());

            // Ngắt kết nối khi tắt app
                if (Functions.Con != null && Functions.Con.State == System.Data.ConnectionState.Open)
                {
                    Functions.Con.Close();
            }
        }
    }
}