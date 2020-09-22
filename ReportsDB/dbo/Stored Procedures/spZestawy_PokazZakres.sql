CREATE PROCEDURE [dbo].[spZestawy_PokazZakres]
	@Date1 date,
	@Date2 date
AS
	SET NOCOUNT ON;	
BEGIN
	SELECT z.DataPrzygotowania, r.NazwaReceptury, z.ZrobioneZestawy FROM [dbo].[Zestawy] z
	INNER JOIN [dbo].[Receptury] r ON z.id_Receptury = r.id 
	WHERE z.DataPrzygotowania BETWEEN @Date1 AND @Date2;
END
