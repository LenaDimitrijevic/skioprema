create database skioprema

use skioprema

create table musterije(
id INT IDENTITY(1,1) PRIMARY KEY,
ime NVARCHAR(20),
prezime NVARCHAR(30),
adresa NVARCHAR(30),
jmbg VARCHAR(15),
email VARCHAR(30),
)

create table brend(
id INT IDENTITY(1,1) PRIMARY KEY,
naziv NVARCHAR(20),
kolicina INT
)

create table skije(
id INT IDENTITY(1,1) PRIMARY KEY,
tip NVARCHAR(20),
duzina INT,
kolicina INT,
brend_id INT FOREIGN KEY REFERENCES brend(id)
)

create table stapovi(
id INT IDENTITY(1,1) PRIMARY KEY,
tip NVARCHAR(20),
duzina INT,
kolicina INT,
brend_id INT FOREIGN KEY REFERENCES brend(id)
)

create table pancerice(
id INT IDENTITY(1,1) PRIMARY KEY,
tip NVARCHAR(20),
broj INT,
kolicina INT,
brend_id INT FOREIGN KEY REFERENCES brend(id)
)

create table kacige(
id INT IDENTITY(1,1) PRIMARY KEY,
tip NVARCHAR(20),
kolicina INT,
brend_id INT FOREIGN KEY REFERENCES brend(id)
)

create table iznajmljivanje(
id INT IDENTITY(1,1) PRIMARY KEY,
skije_id INT FOREIGN KEY REFERENCES skije(id),
stapovi_id INT FOREIGN KEY REFERENCES stapovi(id),
pancerice_id INT FOREIGN KEY REFERENCES pancerice(id),
kaciga_id INT FOREIGN KEY REFERENCES kacige(id),
datum_iznajmljivanja DATE
)