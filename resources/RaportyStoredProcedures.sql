----Stored Procedures

----Show all recepes
--create procedure dbo.spReceptury_PokazWszystkie
--as
--begin
--	set nocount on;
	
--	select * from dbo.Receptury;	
--end

----Add recipe
--create procedure dbo.spReceptury_DodajRecepture

--	@DataDodania date,
--	@NazwaReceptury nvarchar(30),
--	@Uwagi nvarchar(150)
--as
--begin
--	set nocount on;

--	insert into dbo.Receptury(DataWprowadzenia, NazwaReceptury, Uwagi)
--	values(@DataDodania, @NazwaReceptury, @Uwagi);
--end

----Udate Recipe(Active or nonActive)
--create procedure dbo.spReceptury_AktualizujDodstepnosc

--	@id int,
--	@Aktywna bit
--as
--begin
--	set nocount on;

--	update dbo.Receptury set Aktywna = @Aktywna
--	where id = @id;
--end

----Select Active Recipes
--create procedure dbo.spReceptury_WybierzAktywne
--as
--begin
--	set nocount on;
	
--	select * from dbo.Receptury 
--	where Aktywna = 1;
--end

----Add new Batch
--create procedure dbo.spZestawy_DodajZestaw

--	@DataPrzygotowania date,
--	@id_Receptury int,
--	@ZrobioneZestawy smallint

--as
--begin
--	set nocount on;

--	insert into dbo.Zestawy(DataPrzygotowania,id_Receptury,ZrobioneZestawy)
--	values (@DataPrzygotowania,@id_Receptury,@ZrobioneZestawy);

--end

----Show all batches
--create procedure dbo.spZestawy_PokazWszystko
--as
--begin
--	set nocount on;

--	select z.id, z.DataPrzygotowania, r.NazwaReceptury, z.ZrobioneZestawy from dbo.Zestawy z
--	inner join dbo.Receptury r on z.id_Receptury = r.id;

--end
