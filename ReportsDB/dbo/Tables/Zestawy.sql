CREATE TABLE [dbo].[Zestawy]
(
	[id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[DataPrzygotowania] DATE NOT NULL,
	[id_Receptury] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Receptury](id),
	[ZrobioneZestawy] SMALLINT NOT NULL
)
