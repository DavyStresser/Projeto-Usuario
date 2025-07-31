CREATE TABLE UnidadeEquipe (
    Id SERIAL PRIMARY KEY,
    UsuarioId INT NOT NULL,
    Equipe VARCHAR(20) NOT NULL,
    Unidade VARCHAR(20) NOT NULL,
    Cbo VARCHAR(20),
    Microarea VARCHAR(20),
    Deletado BOOLEAN NOT NULL
);