create procedure dbo.spZestawy_DodajZestaw

	@DataPrzygotowania date,
	@id_Receptury int,
	@ZrobioneZestawy smallint

as
begin
	set nocount on;

	insert into dbo.Zestawy(DataPrzygotowania,id_Receptury,ZrobioneZestawy)
	values (@DataPrzygotowania,@id_Receptury,@ZrobioneZestawy);

end
