USE aKutuphane
CREATE TABLE tblTurler
(
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
TurAd VARCHAR(30) NOT NULL UNIQUE,
)
GO

USE aKutuphane
INSERT INTO tblTurler Values
('Başvuru'),('Bilgisayar'),('Edebiyat'),('Ders Kitabı')
Go
     
USE aKutuphane
CREATE TABLE tblYazarlar
(
     ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
     AdSoyad VARCHAR(30),
     Cinsiyet VARCHAR(1),
     DogumTarihi DATE,
     Uyruk VARCHAR(5),
     OlumTarihi DATE,
     TurID INT FOREIGN KEY REFERENCES tblTUrler(ID) ON DELETE CASCADE
)

GO
USE aKutuphane
INSERT INTO tblYazarlar VALUES
('Orhan Pamuk','E','1950-1-1','TC','1999-3-3',1),
('Mehmet Şahin','E','1995-1-1','TC','2079-12-10',2),
('Orhaniye Pamuk','K','1960-1-1','KBR','',3),
('Osmaniye Pamuk','E','1975-1-1','TC','',4)

USE aKutuphane
CREATE TABLE tblYayinevleri
(
    ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Ad VARCHAR(50) UNIQUE,
    Adres VARCHAR(50),
    Tel VARCHAR(11)
)
GO

USE aKutuphane
INSERT INTO tblYayinevleri VALUES
('Kırmızı İnek Yayinevi','Beyoğlu','55555'),
('Mavi Portakal Basım Dağıtım','Bakırköy','11111'),
('Turuncu Gökyüzü Yayınları','Kadıköy','898989')

USE aKutuphane
CREATE TABLE tblUyeler
(
    ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    AdSoyad VARCHAR(30),
    Cinsiyet VARCHAR(1),
    DogumTarihi DATE,
    UyelikTarihi DATE,
    UyelikTipi INT,
    TcNo VARCHAR(11),
    Tel VARCHAR(11),
    Mail VARCHAR(40),
    Meslek VARCHAR(30),
    EgitimDurumu INT,
    CezaDurumu BIT
)
USE aKutuphane
INSERT INTO tblUyeler (AdSoyad,Cinsiyet,UyelikTipi,EgitimDurumu,CezaDurumu)
VALUES
('Ferhat Aldıverdi','E',1,3,0),
('Canan Günaçmaz','K',2,1,0),
('Ferdi Tayfır','E',2,4,0),
('Sezen Aksu','K',1,2,0)


USE aKutuphane
CREATE TABLE tblKitaplar
(
ISBN VARCHAR(13) NOT NULL PRIMARY KEY,
Ad VARCHAR(100),
SayfaSayisi INT,
Stok INT,
TurID INT FOREIGN KEY REFERENCES tblTurler(ID) ON DELETE CASCADE,
YazarID INT FOREIGN KEY REFERENCES tblYazarlar(ID),
YayinEviID INT FOREIGN KEY REFERENCES tblYayinevleri(ID) ON DELETE CASCADE,
BasimTarihi DATE,
KayitTarihi DATE
)
GO
USE aKutuphane
INSERT INTO tblKitaplar (ISBN,Ad,TurID,YazarID,YayinEviID)

VALUES
--TurID: 1-4
--YazarID: 1-4
--YayinEviID: 1-3
('44444','C# Programlamaya Giriş',2,3,2),
('55555','Kara Kitap',3,1,1),
('44444','Vegan Olma Rehberi',4,2,1),
('44444','Göğe Bakalım',1,2,3),
('44444','E-Ticaretin Kapıları',2,4,1)

GO
USE aKutuphane
CREATE TABLE tblOdunc
(
    ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    UyeID INT FOREIGN KEY REFERENCES tblUyeler(ID) ON DELETE CASCADE,
    KitapISBN VARCHAR(13) FOREIGN KEY REFERENCES tblKitaplar(ISBN) ON DELETE CASCADE,
    VerilisTarihi DATE,
    TeslimTarihi DATE,
    Durum BIT
)