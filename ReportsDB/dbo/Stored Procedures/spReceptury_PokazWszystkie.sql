CREATE PROCEDURE [dbo].[spReceptury_PokazWszystkie]	
AS
BEGIN

	SET NOCOUNT ON;

	select * from [dbo].[Receptury];
	
END
