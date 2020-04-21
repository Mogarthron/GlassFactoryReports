create procedure dbo.spZestawy_PokazWszystko
as
begin
	set nocount on;

	select z.id, z.DataPrzygotowania, r.NazwaReceptury, z.ZrobioneZestawy 
	from dbo.Zestawy z
	inner join dbo.Receptury r on z.id_Receptury = r.id;

end
