CREATE PROCEDURE [dbo].[spUwagiDT_DodajUwage]
	@Data DATE,
	@Dotyczy NVARCHAR(30),
	@Opis TEXT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[UwagiDT]([Data],CzegoDotyczy,Opis)
	VALUES(@Data,@Dotyczy,@Opis);
END
