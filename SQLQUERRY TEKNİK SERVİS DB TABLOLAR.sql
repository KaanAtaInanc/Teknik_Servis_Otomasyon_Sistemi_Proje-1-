--DATABASE ADI Teknik_Servis_DB

-- 1. TABLO: ROLLER
CREATE TABLE Roller (
    Rol_ID INT PRIMARY KEY IDENTITY(1,1),
    Rol_Ad VARCHAR(25) NOT NULL 
);
INSERT INTO Roller (Rol_Ad) VALUES ('Admin'),('Teknisyen'),('Danisma');

-- 2. TABLO: PERSONELLER
CREATE TABLE Personeller(
    Personel_ID INT PRIMARY KEY IDENTITY(1,1),
    Rol_ID INT FOREIGN KEY REFERENCES Roller(Rol_ID),
    Ad VARCHAR(50) NOT NULL,
    Soyad VARCHAR(50) NOT NULL,
    Kullanici_Ad VARCHAR(70) NOT NULL UNIQUE,
    SifreHash VARCHAR(256) NOT NULL, 
    
    -- Durum Kontrolleri
    AktifMi BIT DEFAULT 1, 
    IlkGirisMi BIT DEFAULT 1, 
    MesgulMu BIT DEFAULT 0 
);

-- 3. TABLO: MÜŞTERİLER
CREATE TABLE Musteriler(
    Musteri_ID INT PRIMARY KEY IDENTITY(1,1),
    Ad VARCHAR(50) NOT NULL,
    Soyad VARCHAR(50) NOT NULL, 
    Telefon_No VARCHAR(15) NOT NULL,
    Email VARCHAR(100), 
    Il VARCHAR(100),
    Ilce VARCHAR(100),
    Acik_Adres VARCHAR(1000), 
    Kayit_Tarih DATETIME DEFAULT GETDATE() 
);

-- 4. TABLO: PARÇALAR (Fiyat YOK, Kategori VAR)
CREATE TABLE Parcalar(
    Parca_ID INT PRIMARY KEY IDENTITY(1,1),
    Kategori VARCHAR(50) NOT NULL, 
    Parca_Ad VARCHAR(200) NOT NULL,
    MarkaModel VARCHAR(200), 
    Mevcut_Stok INT DEFAULT 0,
    Kritik_Seviye INT DEFAULT 15,
    AktifMi BIT DEFAULT 1
);

-- 5. TABLO: ARIZA DURUMLARI
CREATE TABLE Ariza_Durumlari(
    Durum_ID INT PRIMARY KEY IDENTITY(1,1),
    Durum_Ad VARCHAR(50) NOT NULL
);
INSERT INTO Ariza_Durumlari (Durum_Ad) VALUES ('Bekliyor'),('Inceleniyor'),('Parca Bekleniyor'),('Tamamlandi'),('Teslim Edildi'),('Iptal');

-- 6. TABLO: ARIZALAR (ANA TABLO)
CREATE TABLE Arizalar(
    Ariza_ID INT PRIMARY KEY IDENTITY(1,1),
    Musteri_ID INT FOREIGN KEY REFERENCES Musteriler(Musteri_ID),
    Teknisyen_ID INT FOREIGN KEY REFERENCES Personeller(Personel_ID),
    Durum_ID INT FOREIGN KEY REFERENCES Ariza_Durumlari(Durum_ID), 

    -- Cihaz Bilgileri
    Cihaz_Ad VARCHAR(100) NOT NULL,
    Cihaz_Marka_Model VARCHAR(300) NOT NULL,
    Seri_No VARCHAR(100) NOT NULL, 
    Musteri_Sikayet VARCHAR(1500) NOT NULL, 

    -- İşlem Tarihleri
    Gelis_Tarihi DATETIME DEFAULT GETDATE(),
    Atama_Tarihi DATETIME,
    Bitis_Tarihi DATETIME,
    
    Teknisyen_Aciklama VARCHAR(1500)
)

-- 7. TABLO: KULLANILAN PARÇALAR İşlem Detayları için Gerekli
CREATE TABLE KullanilanParcalar (
    Islem_ID INT PRIMARY KEY IDENTITY(1,1),
    Ariza_ID INT FOREIGN KEY REFERENCES Arizalar(Ariza_ID),
    Parca_ID INT FOREIGN KEY REFERENCES Parcalar(Parca_ID),
    Adet INT NOT NULL,
    Kullanim_Tarihi DATETIME DEFAULT GETDATE()
)

-- 8. TABLO: SİSTEM LOGLARI Admin Takibi İçin
CREATE TABLE SistemLoglari (
    LogID INT PRIMARY KEY IDENTITY(1,1),
    PersonelID INT, -- İşlemi kim yaptı kısmı için gerekli 
    IslemTarihi DATETIME DEFAULT GETDATE(),
    IslemTuru VARCHAR(50), -- 'Giris', 'ParcaEkleme', 'StokDusme' vb. gibi alanlar için 
    Aciklama VARCHAR(MAX) -- 'Ahmet, iPhone 11 Ekran stoğunu güncelledi.' gibi detaylar
)

	
    --Kritik Stok Kontrolü İçin Gerekli Prosedürün Yazılması

-- Önceki kodlardan ayırmak için sihirli komut:
GO

CREATE PROCEDURE sp_ParcaKullan
    @ArizaID INT,
    @ParcaID INT,
    @Adet INT
AS
BEGIN
    -- Değişkenleri Tanımla
    DECLARE @MevcutStok INT;
    DECLARE @KritikSeviye INT;
    DECLARE @ParcaAd VARCHAR(200);

    -- Parçanın o anki bilgilerini çek
    SELECT 
        @MevcutStok = Mevcut_Stok, 
        @KritikSeviye = Kritik_Seviye,
        @ParcaAd = Parca_Ad
    FROM Parcalar 
    WHERE Parca_ID = @ParcaID;

    -- KURAL 1: Depoda o kadar mal var mı?
    IF (@MevcutStok < @Adet)
    BEGIN
        RAISERROR('HATA: Yetersiz Stok! Depoda istediğiniz miktarda parça yok.', 16, 1);
        RETURN;
    END

    -- KURAL 2: Kritik Seviye Engeli (Senin istediğin katı kural)
    IF ((@MevcutStok - @Adet) < @KritikSeviye)
    BEGIN
        RAISERROR('KRİTİK STOK ENGELİ! Bu işlem yapılırsa stok kritik seviyenin altına düşecek. Lütfen önce stok girişi yapın.', 16, 1);
        RETURN;
    END

    -- Her şey yolundaysa işlemi yap
    BEGIN TRANSACTION
        INSERT INTO KullanilanParcalar (Ariza_ID, Parca_ID, Adet) 
        VALUES (@ArizaID, @ParcaID, @Adet);
        
        UPDATE Parcalar 
        SET Mevcut_Stok = Mevcut_Stok - @Adet 
        WHERE Parca_ID = @ParcaID;
    COMMIT TRANSACTION
END;
-- İşlem bittiğini belirtmek için tekrar:
GO