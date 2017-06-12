CREATE TABLE [dbo].[Seller]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Имя] NVARCHAR(50) NOT NULL, 
    [Дата рождения] DATE NOT NULL, 
    [Телефон] NCHAR(10) NULL, 
    [№ кассы] INT NULL, 
    [Фото] IMAGE NULL
)
