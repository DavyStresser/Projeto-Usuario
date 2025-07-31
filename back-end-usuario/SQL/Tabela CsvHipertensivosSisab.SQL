CREATE TABLE CsvHipertensivosSisab (
    ID SERIAL PRIMARY KEY,
    nuAno INT,
    nuQuadrimestre INT,
    nuEquipe VARCHAR(20),
    noNome VARCHAR(255),
    nuCpfCidadao VARCHAR(11),
    nuCns VARCHAR(15),
    dtNascimento DATE,
    dsAvaliada VARCHAR(50),
    dsAutorreferido VARCHAR(50),
    dtAtendimento DATE,
    dtAfericaoPa DATE,
    dsNumerador VARCHAR(50)
);