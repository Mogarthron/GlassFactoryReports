CREATE TABLE [dbo].[Receptury]
(
	[id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[DataWprowadzenia] DATE,
	[NazwaReceptury] NVARCHAR(30) NOT NULL,
	[Aktywna] BIT NOT NULL DEFAULT(1),
	[Uwagi] NVARCHAR
)
