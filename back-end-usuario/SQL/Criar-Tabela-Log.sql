CREATE TABLE public.gisalog
(
    eventoid integer NOT NULL DEFAULT nextval('gisalog_eventoid_seq'::regclass),
    tipoevento character varying(255) COLLATE pg_catalog."default" NOT NULL,
    usuarioid integer NOT NULL,
    nomeevento character varying(255) COLLATE pg_catalog."default" NOT NULL,
    descricaoevento text COLLATE pg_catalog."default",
    dataevento timestamp without time zone NOT NULL DEFAULT now(),
    CONSTRAINT gisalog_pkey PRIMARY KEY (eventoid)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.gisalog
    OWNER to postgres;

GRANT SELECT ON TABLE public.gisalog TO esus_leitura;

GRANT ALL ON TABLE public.gisalog TO postgres;


CREATE SEQUENCE public.gisalog_eventoid_seq
    INCREMENT 1
    START 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1;

ALTER SEQUENCE public.gisalog_eventoid_seq
    OWNER TO postgres;

GRANT ALL ON SEQUENCE public.gisalog_eventoid_seq TO postgres;

GRANT SELECT ON SEQUENCE public.gisalog_eventoid_seq TO esus_leitura;