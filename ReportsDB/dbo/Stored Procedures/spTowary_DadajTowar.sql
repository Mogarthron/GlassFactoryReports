CREATE PROCEDURE [dbo].[spTowary_DadajTowar]
	@Nazwa NVARCHAR(100),
	@Kod NVARCHAR(30),
	@Uwagi NVARCHAR(150)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[Towary](NazwaTowaru,KodTowaru,Uwagi)
	VALUES (@Nazwa, @Kod, @Uwagi);

END

