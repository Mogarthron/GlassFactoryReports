create procedure dbo.spReceptury_WybierzAktywne
as
begin
	set nocount on;
	
	select * from dbo.Receptury 
	where Aktywna = 1;
end