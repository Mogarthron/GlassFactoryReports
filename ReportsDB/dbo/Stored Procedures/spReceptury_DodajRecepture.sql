CREATE PROCEDURE dbo.spReceptury_DodajRecepture

	@DataDodania date,
	@NazwaReceptury nvarchar(30),
	@Uwagi nvarchar(150)

as
begin
	set nocount on;

	insert into dbo.Receptury(DataWprowadzenia, NazwaReceptury, Uwagi)
	values(@DataDodania, @NazwaReceptury, @Uwagi);
end
