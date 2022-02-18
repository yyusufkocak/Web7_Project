CREATE DATABASE aHastane
GO
USE aHastane
GO
CREATE TABLE tblHastalar
(
	ID INT IDENTITY(1,1) NOT NULL,
	TcNo CHAR(11) UNIQUE NOT NULL,
	Ad VARCHAR(20) NOT NULL,
	Soyad VARCHAR(20) NOT NULL,
	Cinsiyet CHAR(1) NOT NULL,
	Adres VARCHAR(30) NULL,
	Telefon CHAR(11) NULL,
	Mail VARCHAR(30) NULL,
	PRIMARY KEY(ID)
)
GO
INSERT INTO tblHastalar
(TcNO,Ad,Soyad,Cinsiyet)
VALUES
('11111111111','Erencan','Germirli','E'),
('22222222222','Selin','Fergenç','K'),
('33333333333','Sadullah','Kullar','E'),
('44444444444','Neşe','Libalık','K')
GO