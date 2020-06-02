CREATE TABLE [dbo].[Tlenki]
(
	[id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Nazwa] NVARCHAR(15) NOT NULL,
	[MasaMolowa] DECIMAL(7,4) NOT NULL,
	[Lotnosc] DECIMAL(4,2),
	[FazaWSzkle] NVARCHAR(3),
	[TempTopnienia] SMALLINT,
	[Gestosc] DECIMAL(6,4)
)
