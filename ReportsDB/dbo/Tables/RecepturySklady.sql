CREATE TABLE [dbo].[RecepturySklady]
(
	[id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[id_Receptury] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Receptury](id),
	[id_Towaru] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Towary](id), 
    [ilosc] DECIMAL(9, 6) NOT NULL	
)
