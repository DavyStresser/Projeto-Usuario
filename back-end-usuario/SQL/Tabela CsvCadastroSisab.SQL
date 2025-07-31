CREATE TABLE CsvCadastroSisab (
    ID SERIAL PRIMARY KEY,
    nuAno INT,
	nuQuadrimestre INT,
	nuEquipe VARCHAR(20),
	noNome VARCHAR(255),
    nuCpfCidadao VARCHAR(11),
    nuCns VARCHAR(15),
    dtNascimento DATE,
    dsSexo VARCHAR(1),
    nuIdade INT,
    dsPonderacao VARCHAR(50),
    tpIdentificacao VARCHAR(50),
    dtRecente DATE,
    qtAtendimentos INT
);