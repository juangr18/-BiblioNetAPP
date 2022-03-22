USE master
GO
CREATE DATABASE BiblioNet
GO
USE BiblioNet
Go
CREATE TABLE Books(
Id int IDENTITY NOT NULL,
BookName nvarchar(50) NOT NULL UNIQUE,
Author nvarchar(100) NOT NULL,
Price float(2) NOT NULL,
PRIMARY KEY (Id)
);

SELECT Price FROM Books
