CREATE TABLE [dbo].[RaportTopiarza]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[CzasWpisu] DATETIME2 NOT NULL,
	[ZasypWE] NVARCHAR(4),
	[PoziomWE] NVARCHAR(4),
	[Moc] DECIMAL(4,1),
	[BaniakWE] DECIMAL(2,1),
	[ZasypWG] NVARCHAR(4),
	[PoziomWG] NVARCHAR(4),
	[Gaz] TINYINT,
	[BaniakWG] DECIMAL(3,1)
)
