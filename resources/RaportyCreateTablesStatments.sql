----Create Database
--create Database Raporty;

----Create Table statments


--Create table Receptury(
--	id int not null identity(1,1) primary key,
--	DataWprowadzenia date,
--	NazwaReceptury nvarchar(30) not null,
--	Aktywna bit not null default(1),
--	Uwagi nvarchar(150)
--);

--Create table Zestawy(
--	id int not null identity(1,1) primary key,
--	DataPrzygotowania date not null,
--	id_Receptury int not null foreign key references Receptury(id),
--	ZrobioneZestawy smallint not null
--);

--Create table Towary(
--	id int not null identity(1,1) primary key,
--	NazwaTowaru nvarchar(30) not null,
--	KodTowaru nvarchar(30),
--	Uwagi nvarchar(120)
--);

--create table RecepturySklady(
--	id int not null identity(1,1) primary key,
--	id_Receptury int not null foreign key references Receptury(id),
--	id_Towary int not null foreign key references Towary(id),
--	Ilosc dec(9,6) not null
--);

--create table Kontrachenci(
--	id int not null identity(1,1) primary key,
--	Nazwa nvarchar(50) not null,
--	PelnaNazwa nvarchar(150),
--	NIP nchar(20),
--	REGON nchar(15),
--	Ulica nvarchar(50),
--	KodPocztowy nchar(10),
--	Miasto nvarchar(20)
--);

--create table Tlenki(
--	id int not null identity(1,1) primary key,
--	Nazwa nvarchar(15) not null,
--	MasaMolowa decimal(7,4)
--);

--create table Jednostki(
--	id int not null identity(1,1) primary key,
--	Jednostka nvarchar(50) not null,
--	Skrot nvarchar(10) not null,
--	Uwagi nvarchar(50)	
--);

--create table PZ(
--	id int not null identity(1,1) primary key,
--	id_Kontrachenta int not null foreign key references Kontrachenci(id),
--	DataDostawy date not null,
--	NrDostawy nvarchar(50),
--	Uwagi nvarchar(30)
--);

--create table PZ_PozycjeDodatkowe(
--	id int not null identity(1,1) primary key,
--	id_PZ int not null foreign key references PZ(id),
--	id_Towary int not null foreign key references Towary(id),
--	NrPartii nvarchar(20),
--	id_Jednostki int not null foreign key references Jednostki(id),
--	Ilosc decimal(8,3) not null
--);



----Tabela przechowuj¹ca dane z raportera
----Create table RaportProdukcji(
----id int not null identity(1,1) primary key,
----Dzm date,
----Zmiana tinyint,
----Warsztat tinyint,
----Nr_karty_formowania nchar(15),
----K nchar(3),
----Forma nchar(20),
----Odbiorca nchar(25),
----Brutto smallint,
----Braki smallint,
----WAGA_BRUTTO int,
----WAGA_NETTO int,
----czas_pracy_zesp dec(3,2)
----);





