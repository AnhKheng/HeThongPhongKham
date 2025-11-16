-- ==========================================
--   CLINIC AI SYSTEM DATABASE - FULL SQL
--   Dermatology Clinic Management + AI
--   Created for: NGUYỄN NGỌC BÍCH ĐAN
-- ==========================================

CREATE DATABASE IF NOT EXISTS ClinicAI;
USE ClinicAI;

-- ============================
-- 1. BỆNH NHÂN
-- ============================

CREATE TABLE BenhNhan (
    MaBN INT AUTO_INCREMENT PRIMARY KEY,
    HoTen VARCHAR(255) NOT NULL,
    NgaySinh DATE,
    SDT VARCHAR(15),
    DiaChi VARCHAR(255),
    GioiTinh VARCHAR(20),
    NgayTao DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- ============================
-- 2. LỊCH KHÁM
-- ============================

CREATE TABLE LichKham (
    MaLK INT AUTO_INCREMENT PRIMARY KEY,
    MaBN INT NOT NULL,
    NgayGio DATETIME NOT NULL,
    TrangThai VARCHAR(50) DEFAULT 'Chưa khám',
    FOREIGN KEY (MaBN) REFERENCES BenhNhan(MaBN) ON DELETE CASCADE
);

-- ============================
-- 3. PHIÊN KHÁM
-- ============================

CREATE TABLE PhienKham (
    MaPK INT AUTO_INCREMENT PRIMARY KEY,
    MaLK INT NOT NULL,
    MaBN INT NOT NULL,
    TrieuChung TEXT,
    TinhTrangDa TEXT,
    DiUng TEXT,
    HinhAnh TEXT,
    AI_KetQuaJSON JSON,
    ChuanDoanCuoi VARCHAR(255),
    NgayKham DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (MaLK) REFERENCES LichKham(MaLK) ON DELETE CASCADE,
    FOREIGN KEY (MaBN) REFERENCES BenhNhan(MaBN) ON DELETE CASCADE
);

-- ============================
-- 4. THUỐC
-- ============================

CREATE TABLE Thuoc (
    MaThuoc INT AUTO_INCREMENT PRIMARY KEY,
    TenThuoc VARCHAR(255) NOT NULL,
    ThanhPhan TEXT,
    HamLuong VARCHAR(255),
    CachDung VARCHAR(255),
    HanSuDung DATE,
    DonVi VARCHAR(50),
    GhiChu TEXT
);

-- ============================
-- 5. TOA THUỐC
-- ============================

CREATE TABLE ToaThuoc (
    MaToa INT AUTO_INCREMENT PRIMARY KEY,
    MaPK INT NOT NULL,
    NgayLap DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (MaPK) REFERENCES PhienKham(MaPK) ON DELETE CASCADE
);

-- ============================
-- 6. CHI TIẾT TOA THUỐC
-- ============================

CREATE TABLE ChiTietToaThuoc (
    MaCT INT AUTO_INCREMENT PRIMARY KEY,
    MaToa INT NOT NULL,
    MaThuoc INT NULL,
    TenThuoc VARCHAR(255),
    LieuDung VARCHAR(255),
    SoLuong INT DEFAULT 1,
    FOREIGN KEY (MaToa) REFERENCES ToaThuoc(MaToa) ON DELETE CASCADE,
    FOREIGN KEY (MaThuoc) REFERENCES Thuoc(MaThuoc)
);


-- ============================
-- 7. AI TRAINING FEEDBACK
-- ============================

CREATE TABLE AI_TrainingFeedback (
    FeedbackID INT AUTO_INCREMENT PRIMARY KEY,
    MaPK INT NOT NULL,
    ImagePath TEXT,
    AI_Predictions JSON,
    Doctor_FinalDiagnosis VARCHAR(255),
    ErrorType VARCHAR(50),
    ErrorScore DECIMAL(5,4),
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (MaPK) REFERENCES PhienKham(MaPK) ON DELETE CASCADE
);

DELIMITER //
CREATE TRIGGER trg_calc_error_score
BEFORE INSERT ON AI_TrainingFeedback
FOR EACH ROW
BEGIN
    IF NEW.ErrorScore IS NULL THEN
        SET NEW.ErrorScore = 1.0;
    END IF;
END//
DELIMITER ;

-- ============================
-- 8. HỒ SƠ BỆNH ÁN
-- ============================

CREATE TABLE HoSoBenhAn (
    MaHS INT AUTO_INCREMENT PRIMARY KEY,
    MaPK INT NOT NULL,
    TomTatChanDoan TEXT,
    TinhTrangDa TEXT,
    DiUng TEXT,
    LichSuBenh TEXT,
    HuongDieuTri TEXT,
    GhiChuBacSi TEXT,
    NgayTao DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (MaPK) REFERENCES PhienKham(MaPK) ON DELETE CASCADE
);

-- ============================
-- 9. TIỀN SỬ BỆNH
-- ============================

CREATE TABLE TienSuBenh (
    MaTS INT AUTO_INCREMENT PRIMARY KEY,
    MaBN INT NOT NULL,
    TenBenh VARCHAR(255),
    MoTa TEXT,
    FOREIGN KEY (MaBN) REFERENCES BenhNhan(MaBN) ON DELETE CASCADE
);

-- ============================
-- 10. DỊ ỨNG BỆNH NHÂN
-- ============================

CREATE TABLE DiUngBenhNhan (
    MaDU INT AUTO_INCREMENT PRIMARY KEY,
    MaBN INT NOT NULL,
    TacNhan VARCHAR(255),
    MucDo VARCHAR(50),
    GhiChu TEXT,
    FOREIGN KEY (MaBN) REFERENCES BenhNhan(MaBN) ON DELETE CASCADE
);

-- ============================
-- 11. HÌNH ẢNH DA
-- ============================

CREATE TABLE HinhAnhDa (
    MaHA INT AUTO_INCREMENT PRIMARY KEY,
    MaPK INT NOT NULL,
    ImagePath TEXT,
    AI_TienXuLy JSON,
    AI_PhanTich JSON,
    NgayTao DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (MaPK) REFERENCES PhienKham(MaPK) ON DELETE CASCADE
);

-- ============================
-- 12. DỊCH VỤ KHÁM
-- ============================

CREATE TABLE DichVu (
    MaDV INT AUTO_INCREMENT PRIMARY KEY,
    TenDV VARCHAR(255),
    DonGia DECIMAL(12,2),
    MoTa TEXT
);

-- ============================
-- 13. CHI PHÍ KHÁM
-- ============================

CREATE TABLE ChiPhiKham (
    MaCP INT AUTO_INCREMENT PRIMARY KEY,
    MaPK INT NOT NULL,
    MaDV INT,
    SoTien DECIMAL(12,2),
    FOREIGN KEY (MaPK) REFERENCES PhienKham(MaPK) ON DELETE CASCADE,
    FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV)
);

-- ============================
-- 14. QUÁ TRÌNH ĐIỀU TRỊ
-- ============================

CREATE TABLE QuaTrinhDieuTri (
    MaQT INT AUTO_INCREMENT PRIMARY KEY,
    MaBN INT NOT NULL,
    NgayTheoDoi DATE,
    TinhTrangDa TEXT,
    AnhTheoDoi TEXT,
    HuongDanDieuTri TEXT,
    DanhGiaBacSi TEXT,
    FOREIGN KEY (MaBN) REFERENCES BenhNhan(MaBN) ON DELETE CASCADE
);

-- ============================
-- 15. AI DATASET
-- ============================

CREATE TABLE AI_Dataset (
    MaData INT AUTO_INCREMENT PRIMARY KEY,
    ImagePath TEXT,
    NhanDan VARCHAR(255),
    LoaiBenh VARCHAR(255),
    ChatLuong VARCHAR(50),
    Nguon VARCHAR(255),
    NgayTao DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- ============================
-- 16. AI REQUEST LOG
-- ============================

CREATE TABLE AI_RequestLog (
    LogID INT AUTO_INCREMENT PRIMARY KEY,
    MaPK INT,
    InputJSON JSON,
    OutputJSON JSON,
    ModelUsed VARCHAR(100),
    ThoiGian DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (MaPK) REFERENCES PhienKham(MaPK) ON DELETE SET NULL
);

-- ============================
-- 17. LOG HỒ SƠ
-- ============================

CREATE TABLE Log_HoSo (
    LogID INT AUTO_INCREMENT PRIMARY KEY,
    MaPK INT,
    HanhDong VARCHAR(255),
    ThoiGian DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (MaPK) REFERENCES PhienKham(MaPK) ON DELETE SET NULL
);

-- ============================
-- TỐI ƯU INDEX
-- ============================

CREATE INDEX idx_lk_mabn ON LichKham(MaBN);
CREATE INDEX idx_pk_mabn ON PhienKham(MaBN);
CREATE INDEX idx_tt_matoa ON ChiTietToaThuoc(MaToa);
CREATE INDEX idx_fb_mapk ON AI_TrainingFeedback(MaPK);
CREATE INDEX idx_hinhanh_mapk ON HinhAnhDa(MaPK);
CREATE INDEX idx_cp_mapk ON ChiPhiKham(MaPK);

-- ==========================================
--             DATABASE READY
-- ==========================================
