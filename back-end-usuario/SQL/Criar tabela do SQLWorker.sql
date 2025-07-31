CREATE TABLE SqlWorker (
    Id SERIAL PRIMARY KEY,
    Ordem INT NOT NULL,
    PeriodoDeExec INT NOT NULL,
    ComandoSQL VARCHAR(2000) NOT NULL    
);

--INSERT INTO public.sqlworker(ordem, periododeexec, comandosql)  VALUES (1, 1, 'SELECT public.gi_cidadaos_visitados();');
--INSERT INTO public.sqlworker(ordem, periododeexec, comandosql)  VALUES (2, 1, 'SELECT public.gi_ultima_visita();');