CREATE PROCEDURE [dbo].[spRecepturySklady_DodajSurowiec]
	@Receptura int,
	@Surowiec int,
	@Ilosc decimal(9,6)
AS

BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[RecepturySklady](id_Receptury,id_Towaru,ilosc)
	VALUES(@Receptura,@Surowiec,@Ilosc);
		
END
