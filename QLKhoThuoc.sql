USE QLKhoThuoc;

-- 1. Loại thuốc (Kháng sinh, Thực phẩm chức năng...)
CREATE TABLE LoaiThuoc (
    _maLoaiThuoc VARCHAR(50) PRIMARY KEY,
    _tenLoaiThuoc NVARCHAR(255) NOT NULL
);

-- 2. Nhà cung cấp
CREATE TABLE NhaCungCap (
    _maNhaCungCap VARCHAR(50) PRIMARY KEY,
    _tenNhaCungCap NVARCHAR(255) NOT NULL,
    _dienThoai VARCHAR(20),
    _diaChi NVARCHAR(500)
);

-- 3. Khách hàng (Cần có để quản lý liều dùng & GPP)
CREATE TABLE KhachHang (
    _maKhachHang VARCHAR(50) PRIMARY KEY,
    _hoTen NVARCHAR(255) NOT NULL,
    _dienThoai VARCHAR(20),
    _diaChi NVARCHAR(500)
);

-- 4. Nhân viên (Phân quyền đăng nhập)
CREATE TABLE NhanVien (
    _maNhanVien VARCHAR(50) PRIMARY KEY,
    _hoTen NVARCHAR(255) NOT NULL,
    _tenDangNhap VARCHAR(50) UNIQUE NOT NULL,
    _matKhau VARCHAR(255) NOT NULL,
    _quyenHan BIT NOT NULL -- 1: Admin, 0: Nhân viên
);

-- 5. Danh mục Thuốc (Thông tin chung)
CREATE TABLE Thuoc (
    _maThuoc VARCHAR(50) PRIMARY KEY,
    _loaiThuocMa VARCHAR(50) NOT NULL,
    _tenThuoc NVARCHAR(255) NOT NULL,
    _donVi NVARCHAR(50) NOT NULL, -- Viên, Vỉ, Hộp
    _hinhAnh NVARCHAR(MAX),
    _moTa NVARCHAR(MAX),
    FOREIGN KEY (_loaiThuocMa) REFERENCES LoaiThuoc(_maLoaiThuoc)
);

-- 6. Danh mục Kho
CREATE TABLE Kho (
    _maKho VARCHAR(50) PRIMARY KEY,
    _tenKho NVARCHAR(255) NOT NULL,
    _ghiChu NVARCHAR(MAX)
);
-- 7. Phiếu nhập hàng
CREATE TABLE PhieuNhap (
    _maPhieuNhap VARCHAR(50) PRIMARY KEY,
    _nhanVienMa VARCHAR(50) NOT NULL,
    _nhaCungCapMa VARCHAR(50) NOT NULL,
    _ngayNhap DATETIME DEFAULT GETDATE(),
    _tongTien DECIMAL(18, 2),
    FOREIGN KEY (_nhanVienMa) REFERENCES NhanVien(_maNhanVien),
    FOREIGN KEY (_nhaCungCapMa) REFERENCES NhaCungCap(_maNhaCungCap)
);

-- 8. Chi tiết phiếu nhập (Lưu Lô & Hạn dùng lúc nhập)
CREATE TABLE PhieuNhapChiTiet (
    _maPhieuNhapChiTiet VARCHAR(50) PRIMARY KEY,
    _phieuNhapMa VARCHAR(50) NOT NULL,
    _thuocMa VARCHAR(50) NOT NULL,
    _soLo VARCHAR(50) NOT NULL,
    _hanSuDung DATE NOT NULL,
    _soLuongNhap INT NOT NULL,
    _donGiaNhap DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (_phieuNhapMa) REFERENCES PhieuNhap(_maPhieuNhap),
    FOREIGN KEY (_thuocMa) REFERENCES Thuoc(_maThuoc)
);

-- 9. Quản lý Lô Thuốc (Bảng trung gian để bán hàng theo lô)
CREATE TABLE LoThuoc (
    _maLoThuoc VARCHAR(50) PRIMARY KEY, -- Gợi ý: MaThuoc + SoLo
    _thuocMa VARCHAR(50) NOT NULL,
    _soLo VARCHAR(50) NOT NULL,
    _hanSuDung DATE NOT NULL,
    _soLuongTon INT NOT NULL,
    _donGiaBan DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (_thuocMa) REFERENCES Thuoc(_maThuoc)
);
-- 10. Hóa đơn bán hàng
CREATE TABLE HoaDon (
    _maHoaDon VARCHAR(50) PRIMARY KEY,
    _nhanVienMa VARCHAR(50) NOT NULL,
    _khachHangMa VARCHAR(50) NOT NULL,
    _ngayLap DATETIME DEFAULT GETDATE(),
    _ghiChu NVARCHAR(MAX),
    FOREIGN KEY (_nhanVienMa) REFERENCES NhanVien(_maNhanVien),
    FOREIGN KEY (_khachHangMa) REFERENCES KhachHang(_maKhachHang)
);

-- 11. Chi tiết hóa đơn (Phải trừ từ Lô Thuốc cụ thể)
CREATE TABLE HoaDonChiTiet (
    _maHoaDonChiTiet VARCHAR(50) PRIMARY KEY,
    _hoaDonMa VARCHAR(50) NOT NULL,
    _maLoThuoc VARCHAR(50) NOT NULL, 
    _soLuongBan INT NOT NULL,
    _donGiaBan DECIMAL(18, 2) NOT NULL,
    _thanhTien AS (_soLuongBan * _donGiaBan),
    FOREIGN KEY (_hoaDonMa) REFERENCES HoaDon(_maHoaDon),
    FOREIGN KEY (_maLoThuoc) REFERENCES LoThuoc(_maLoThuoc)
);
-- 12. Phiếu kiểm kê
CREATE TABLE PhieuKiemKe (
    _maPhieuKiem VARCHAR(50) PRIMARY KEY,
    _nhanVienMa VARCHAR(50) NOT NULL,
    _ngayKiemKe DATETIME DEFAULT GETDATE(),
    _ghiChu NVARCHAR(MAX),
    FOREIGN KEY (_nhanVienMa) REFERENCES NhanVien(_maNhanVien)
);

-- 13. Chi tiết kiểm kê
CREATE TABLE ChiTietKiemKe (
    _maChiTietKiem VARCHAR(50) PRIMARY KEY,
    _maPhieuKiem VARCHAR(50) NOT NULL,
    _maLoThuoc VARCHAR(50) NOT NULL,
    _soLuongHeThong INT NOT NULL,
    _soLuongThucTe INT NOT NULL,
    FOREIGN KEY (_maPhieuKiem) REFERENCES PhieuKiemKe(_maPhieuKiem),
    FOREIGN KEY (_maLoThuoc) REFERENCES LoThuoc(_maLoThuoc)
);

-- Thêm cột Giới tính cho bảng Nhân Viên
ALTER TABLE NhanVien 
ADD _gioiTinh NVARCHAR(10);


-- Thêm cột Giới tính cho bảng Khách Hàng (Nếu bảng của bạn chưa có)
ALTER TABLE KhachHang 
ADD _gioiTinh NVARCHAR(10);


ALTER TABLE KhachHang 
ALTER COLUMN _dienThoai VARCHAR(10);
go

CREATE TABLE NhatKyDangNhap (
    _id INT IDENTITY(1,1) PRIMARY KEY,
    _maNhanVien NVARCHAR(50),      -- Ai đăng nhập
    _tenNhanVien NVARCHAR(100),    -- Tên hiển thị
    _thoiGianDangNhap DATETIME,    -- Lúc nào
    _tenMayTinh NVARCHAR(100),     -- Đăng nhập từ máy nào
    _trangThai NVARCHAR(50)        -- Thành công hoặc Thất bại
)