CREATE PROCEDURE [dbo].[spRecepturySklady_PokazWybrana]
	@Nazwa_Receptury nvarchar(30)

AS
BEGIN
	SET NOCOUNT ON;

	SELECT r.NazwaReceptury, t.NazwaTowaru, s.ilosc FROM [dbo].[RecepturySklady] s
	INNER JOIN [dbo].[Receptury] r ON r.id = s.id_Receptury
	INNER JOIN [dbo].[Towary] t ON t.id = s.id_Towaru
	WHERE r.NazwaReceptury = @Nazwa_Receptury
END
