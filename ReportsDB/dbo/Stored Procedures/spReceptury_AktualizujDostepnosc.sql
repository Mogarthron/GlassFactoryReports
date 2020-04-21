create procedure dbo.spReceptury_AktualizujDodstepnosc

	@id int,
	@Aktywna bit
as
begin
	set nocount on;

	update dbo.Receptury set Aktywna = @Aktywna
	where id = @id;
end
