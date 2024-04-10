use ecommerce;

CREATE TABLE producator (
    id_producator INT PRIMARY KEY,
    nume VARCHAR(50),
    username VARCHAR(50),
    parola VARCHAR(50),
    adresa VARCHAR(500),
    telefon VARCHAR(20),
    email VARCHAR(100),
    CONSTRAINT CK_telefonP CHECK (
	telefon LIKE '03[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR
	telefon LIKE '02[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    CONSTRAINT CK_parolaP CHECK (
        parola LIKE '%[A-Z]%' AND 
        parola LIKE '%[a-z]%' AND 
        parola LIKE '%[0-9]%' AND 
        parola LIKE '%[^a-zA-Z0-9]%'
    )
);