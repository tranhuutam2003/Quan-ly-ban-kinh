-- Tạo database quanlybankinh
CREATE DATABASE quanlybankinh;
USE quanlybankinh;

-- Tạo các bảng không có khóa ngoại
CREATE TABLE KhoiLuong (
    MaKhoiLuong INT PRIMARY KEY,
    TenKhoiLuong NVARCHAR(50)
);

CREATE TABLE LoaiKinh (
    MaLoai INT PRIMARY KEY,
    TenLoai NVARCHAR(100)
);

CREATE TABLE HinhDangMat (
    MaDangMat INT PRIMARY KEY,
    TenDangMat NVARCHAR(50)
);

CREATE TABLE ChatLieu (
    MaChatLieu INT PRIMARY KEY,
    TenChatLieu NVARCHAR(100)
);

CREATE TABLE NuocSanXuat (
    MaNuocSX INT PRIMARY KEY,
    TenNuocSX NVARCHAR(100)
);

CREATE TABLE MauSac (
    MaMau INT PRIMARY KEY,
    TenMau NVARCHAR(50)
);

CREATE TABLE Diop (
    MaDiop INT PRIMARY KEY,
    TenDiop NVARCHAR(50)
);

CREATE TABLE CongViec (
    MaCV INT PRIMARY KEY,
    TenCV NVARCHAR(100),
    MucLuong DECIMAL(10, 2)
);

CREATE TABLE CongDung (
    MaCongDung INT PRIMARY KEY,
    TenCongDung NVARCHAR(100)
);

CREATE TABLE KhachHang (
    MaKhach INT PRIMARY KEY,
    TenKhach NVARCHAR(100),
    DiaChi NVARCHAR(200),
    DienThoai NVARCHAR(15),

);

CREATE TABLE NhaCungCap (
    MaNCC INT PRIMARY KEY,
    TenNCC NVARCHAR(100),
    DiaChi NVARCHAR(200),
    DienThoai NVARCHAR(15)
);

CREATE TABLE DacDiem (
    MaDacDiem INT PRIMARY KEY,
    TenDacDiem NVARCHAR(100)
);

CREATE TABLE GongMat (
    MaLoaiGong INT PRIMARY KEY,
    TenLoaiGong NVARCHAR(100)
);

-- Tạo các bảng có khóa ngoại
CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY,
    TenNV NVARCHAR(100),
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    DienThoai NVARCHAR(15),
    DiaChi NVARCHAR(200),
    MaCV INT,

    FOREIGN KEY (MaCV) REFERENCES CongViec(MaCV)
);

CREATE TABLE DanhMucHangHoa (
    MaHang INT PRIMARY KEY,
    TenHang NVARCHAR(100),
    MaLoai INT,
    MaLoaiGong INT,
    MaDangMat INT,
    MaChatLieu INT,
    MaDiop INT,
    CongDung NVARCHAR(100),
    MaDacDiem INT,
    MaMau INT,
    MaNuocSX INT,
    SoLuong INT,
    DonGiaNhap DECIMAL(10, 2),
    DonGiaBan DECIMAL(10, 2),
    ThoiGianBaoHanh INT,
    GhiChu NVARCHAR(200),
    FOREIGN KEY (MaLoai) REFERENCES LoaiKinh(MaLoai),
    FOREIGN KEY (MaLoaiGong) REFERENCES GongMat(MaLoaiGong),
    FOREIGN KEY (MaDangMat) REFERENCES HinhDangMat(MaDangMat),
    FOREIGN KEY (MaChatLieu) REFERENCES ChatLieu(MaChatLieu),
    FOREIGN KEY (MaDiop) REFERENCES Diop(MaDiop),
    FOREIGN KEY (MaDacDiem) REFERENCES DacDiem(MaDacDiem),
    FOREIGN KEY (MaMau) REFERENCES MauSac(MaMau),
    FOREIGN KEY (MaNuocSX) REFERENCES NuocSanXuat(MaNuocSX)
);

CREATE TABLE HoaDonBan (
    SoHDB INT PRIMARY KEY,
    MaNV INT,
    NgayBan DATE,
    MaKhach INT,
    TongTien DECIMAL(15, 2),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaKhach) REFERENCES KhachHang(MaKhach)
);

CREATE TABLE HoaDonNhap (
    SoHDN INT PRIMARY KEY,
    MaNV INT,
    NgayNhap DATE,
    MaNCC INT,
    TongTien DECIMAL(15, 2),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
);

CREATE TABLE ChiTietHoaDonBan (
    SoHDB INT,
    MaHang INT,
    SoLuong INT,
    GiamGia DECIMAL(5, 2),
    ThanhTien DECIMAL(15, 2),
    PRIMARY KEY (SoHDB, MaHang),
    FOREIGN KEY (SoHDB) REFERENCES HoaDonBan(SoHDB),
    FOREIGN KEY (MaHang) REFERENCES DanhMucHangHoa(MaHang)
);

CREATE TABLE ChiTietHoaDonNhap (
    SoHDN INT,
    MaHang INT,
    SoLuong INT,
    DonGia DECIMAL(10, 2),
    GiamGia DECIMAL(5, 2),
    ThanhTien DECIMAL(15, 2),
    PRIMARY KEY (SoHDN, MaHang),
    FOREIGN KEY (SoHDN) REFERENCES HoaDonNhap(SoHDN),
    FOREIGN KEY (MaHang) REFERENCES DanhMucHangHoa(MaHang)
);

-- Thêm dữ liệu vào bảng KhoiLuong
INSERT INTO KhoiLuong (MaKhoiLuong, TenKhoiLuong) VALUES
(1, 'Nhẹ'),
(2, 'Trung bình'),
(3, 'Nặng'),
(4, 'Siêu nhẹ'),
(5, 'Siêu nặng');

-- Thêm dữ liệu vào bảng LoaiKinh
INSERT INTO LoaiKinh (MaLoai, TenLoai) VALUES
(1, 'Kính cận'),
(2, 'Kính viễn'),
(3, 'Kính đa tròng'),
(4, 'Kính chống ánh sáng xanh'),
(5, 'Kính râm');

-- Thêm dữ liệu vào bảng HinhDangMat
INSERT INTO HinhDangMat (MaDangMat, TenDangMat) VALUES
(1, 'Oval'),
(2, 'Tròn'),
(3, 'Vuông'),
(4, 'Trái xoan'),
(5, 'Trái tim');

-- Thêm dữ liệu vào bảng ChatLieu
INSERT INTO ChatLieu (MaChatLieu, TenChatLieu) VALUES
(1, 'Nhựa'),
(2, 'Kim loại'),
(3, 'Titan'),
(4, 'Acetate'),
(5, 'Nhựa dẻo');

-- Thêm dữ liệu vào bảng NuocSanXuat
INSERT INTO NuocSanXuat (MaNuocSX, TenNuocSX) VALUES
(1, 'Việt Nam'),
(2, 'Nhật Bản'),
(3, 'Hàn Quốc'),
(4, 'Ý'),
(5, 'Mỹ');

-- Thêm dữ liệu vào bảng MauSac
INSERT INTO MauSac (MaMau, TenMau) VALUES
(1, 'Đen'),
(2, 'Trắng'),
(3, 'Nâu'),
(4, 'Xanh dương'),
(5, 'Đỏ');

-- Thêm dữ liệu vào bảng Diop
INSERT INTO Diop (MaDiop, TenDiop) VALUES
(1, '-1.00'),
(2, '-2.00'),
(3, '+1.50'),
(4, '+2.50'),
(5, '0.00');

-- Thêm dữ liệu vào bảng CongViec
INSERT INTO CongViec (MaCV, TenCV, MucLuong) VALUES
(1, 'Nhân viên bán hàng', 5000000),
(2, 'Kỹ thuật viên', 7000000),
(3, 'Quản lý cửa hàng', 10000000),
(4, 'Nhân viên kho', 5500000),
(5, 'Nhân viên chăm sóc khách hàng', 6000000);

-- Thêm dữ liệu vào bảng CongDung
INSERT INTO CongDung (MaCongDung, TenCongDung) VALUES
(1, 'Điều chỉnh thị lực'),
(2, 'Chống tia UV'),
(3, 'Chống chói'),
(4, 'Thời trang'),
(5, 'Bảo vệ mắt khi làm việc');

-- Thêm dữ liệu vào bảng KhachHang
INSERT INTO KhachHang (MaKhach, TenKhach, DiaChi, DienThoai) VALUES
(1, 'Nguyễn Văn A', 'Hà Nội', '0901234567'),
(2, 'Trần Thị B', 'Hồ Chí Minh', '0912345678'),
(3, 'Lê Văn C', 'Đà Nẵng', '0923456789'),
(4, 'Phạm Thị D', 'Hải Phòng', '0934567890'),
(5, 'Hoàng Văn E', 'Cần Thơ', '0945678901');

-- Thêm dữ liệu vào bảng NhaCungCap
INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi, DienThoai) VALUES
(1, 'Công ty TNHH Kính mắt ABC', 'Hà Nội', '0241234567'),
(2, 'Công ty CP Kính mắt XYZ', 'Hồ Chí Minh', '0282345678'),
(3, 'Công ty TNHH Kính mắt 123', 'Đà Nẵng', '0233456789'),
(4, 'Công ty CP Kính mắt 456', 'Hải Phòng', '0254567890'),
(5, 'Công ty TNHH Kính mắt 789', 'Cần Thơ', '0295678901');

-- Thêm dữ liệu vào bảng DacDiem
INSERT INTO DacDiem (MaDacDiem, TenDacDiem) VALUES
(1, 'Chống trầy xước'),
(2, 'Chống nước'),
(3, 'Chống va đập'),
(4, 'Siêu nhẹ'),
(5, 'Có thể gập');

-- Thêm dữ liệu vào bảng GongMat
INSERT INTO GongMat (MaLoaiGong, TenLoaiGong) VALUES
(1, 'Gọng kim loại'),
(2, 'Gọng nhựa'),
(3, 'Gọng titan'),
(4, 'Gọng không viền'),
(5, 'Gọng nửa viền');

-- Thêm dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (MaNV, TenNV, GioiTinh, NgaySinh, DienThoai, DiaChi, MaCV) VALUES
(1, 'Nguyễn Thị F', 'Nữ', '1990-01-01', '0956789012', 'Hà Nội', 1),
(2, 'Trần Văn G', 'Nam', '1992-02-02', '0967890123', 'Hồ Chí Minh', 2),
(3, 'Lê Thị H', 'Nữ', '1988-03-03', '0978901234', 'Đà Nẵng', 3),
(4, 'Phạm Văn I', 'Nam', '1995-04-04', '0989012345', 'Hải Phòng', 4),
(5, 'Hoàng Thị K', 'Nữ', '1993-05-05', '0990123456', 'Cần Thơ', 5);

-- Thêm dữ liệu vào bảng DanhMucHangHoa
INSERT INTO DanhMucHangHoa (MaHang, TenHang, MaLoai, MaLoaiGong, MaDangMat, MaChatLieu, MaDiop, CongDung, MaDacDiem, MaMau, MaNuocSX, SoLuong, DonGiaNhap, DonGiaBan, ThoiGianBaoHanh, GhiChu) VALUES
(1, 'Kính cận thời trang', 1, 1, 1, 1, 1, 'Điều chỉnh thị lực', 1, 1, 1, 100, 500000, 750000, 12, 'Kính cận thời trang cho giới trẻ'),
(2, 'Kính râm cao cấp', 5, 2, 2, 2, 5, 'Chống tia UV', 2, 2, 2, 50, 1000000, 1500000, 24, 'Kính râm cao cấp chống tia UV'),
(3, 'Kính đa tròng', 3, 3, 3, 3, 3, 'Điều chỉnh đa thị lực', 3, 3, 3, 75, 1500000, 2250000, 36, 'Kính đa tròng cho người trung niên'),
(4, 'Kính chống ánh sáng xanh', 4, 4, 4, 4, 5, 'Bảo vệ mắt khi làm việc', 4, 4, 4, 200, 800000, 1200000, 18, 'Kính chống ánh sáng xanh cho dân văn phòng'),
(5, 'Kính thể thao', 5, 5, 5, 5, 5, 'Bảo vệ mắt khi chơi thể thao', 5, 5, 5, 80, 1200000, 1800000, 24, 'Kính thể thao chống va đập');

-- Thêm dữ liệu vào bảng HoaDonBan
INSERT INTO HoaDonBan (SoHDB, MaNV, NgayBan, MaKhach, TongTien) VALUES
(1, 1, '2024-03-01', 1, 750000),
(2, 2, '2024-03-02', 2, 1500000),
(3, 3, '2024-03-03', 3, 2250000),
(4, 4, '2024-03-04', 4, 1200000),
(5, 5, '2024-03-05', 5, 1800000);

-- Thêm dữ liệu vào bảng HoaDonNhap
INSERT INTO HoaDonNhap (SoHDN, MaNV, NgayNhap, MaNCC, TongTien) VALUES
(1, 1, '2024-02-01', 1, 50000000),
(2, 2, '2024-02-02', 2, 75000000),
(3, 3, '2024-02-03', 3, 100000000),
(4, 4, '2024-02-04', 4, 80000000),
(5, 5, '2024-02-05', 5, 90000000);

-- Thêm dữ liệu vào bảng ChiTietHoaDonBan
INSERT INTO ChiTietHoaDonBan (SoHDB, MaHang, SoLuong, GiamGia, ThanhTien) VALUES
(1, 1, 1, 0, 750000),
(2, 2, 1, 0, 1500000),
(3, 3, 1, 0, 2250000),
(4, 4, 1, 0, 1200000),
(5, 5, 1, 0, 1800000);

-- Thêm dữ liệu vào bảng ChiTietHoaDonNhap
INSERT INTO ChiTietHoaDonNhap (SoHDN, MaHang, SoLuong, DonGia, GiamGia, ThanhTien) VALUES
(1, 1, 100, 500000, 0, 50000000),
(2, 2, 50, 1000000, 0, 50000000),
(3, 3, 75, 1500000, 0, 112500000),
(4, 4, 200, 800000, 0, 160000000),
(5, 5, 80, 1200000, 0, 96000000);