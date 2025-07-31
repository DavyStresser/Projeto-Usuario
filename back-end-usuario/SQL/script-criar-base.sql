--
-- PostgreSQL database dump
--

-- Dumped from database version 9.6.13
-- Dumped by pg_dump version 10.1

-- Started on 2024-05-24 20:18:44

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 186 (class 1259 OID 84271)
-- Name: Acao; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "Acao" (
    "AcaoId" integer NOT NULL,
    "Nome" character varying(500) NOT NULL,
    "Plano" text NOT NULL,
    "Custo" numeric NOT NULL,
    "Prazo" integer NOT NULL,
    "DataInicio" timestamp without time zone NOT NULL,
    "Gravidade" integer NOT NULL,
    "Urgencia" integer NOT NULL,
    "Tendencia" integer NOT NULL,
    "AcaoStatusId" integer NOT NULL,
    "Deletado" boolean NOT NULL,
    "CriadoEm" timestamp without time zone NOT NULL,
    "AlteradoEm" timestamp without time zone,
    "CriadoPor" integer NOT NULL,
    "AlteradoPor" integer,
    "Cidade" character varying(250)
);


ALTER TABLE "Acao" OWNER TO postgres;

--
-- TOC entry 187 (class 1259 OID 84277)
-- Name: AcaoArquivo; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "AcaoArquivo" (
    "AcaoArquivoId" integer NOT NULL,
    "AcaoId" integer NOT NULL,
    "CriadoEm" timestamp without time zone NOT NULL,
    "AlteradoEm" timestamp without time zone,
    "CriadoPor" integer NOT NULL,
    "AlteradoPor" integer,
    "ArquivoId" integer NOT NULL,
    "Deletado" boolean NOT NULL
);


ALTER TABLE "AcaoArquivo" OWNER TO postgres;

--
-- TOC entry 188 (class 1259 OID 84280)
-- Name: AcaoArquivo_AcaoArquivoId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "AcaoArquivo_AcaoArquivoId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "AcaoArquivo_AcaoArquivoId_seq" OWNER TO postgres;

--
-- TOC entry 6921 (class 0 OID 0)
-- Dependencies: 188
-- Name: AcaoArquivo_AcaoArquivoId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "AcaoArquivo_AcaoArquivoId_seq" OWNED BY "AcaoArquivo"."AcaoArquivoId";


--
-- TOC entry 189 (class 1259 OID 84282)
-- Name: AcaoAtividade; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "AcaoAtividade" (
    "AcaoAtividadeId" integer NOT NULL,
    "Nome" character varying(200) NOT NULL,
    "Descricao" text NOT NULL,
    "Prazo" integer NOT NULL,
    "Status" integer NOT NULL,
    "AcaoId" integer NOT NULL,
    "CriadoEm" timestamp without time zone NOT NULL,
    "AlteradoEm" timestamp without time zone,
    "CriadoPor" integer NOT NULL,
    "AlteradoPor" integer,
    "Deletado" boolean NOT NULL
);


ALTER TABLE "AcaoAtividade" OWNER TO postgres;

--
-- TOC entry 190 (class 1259 OID 84288)
-- Name: AcaoAtividade_AcaoAtividadeId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "AcaoAtividade_AcaoAtividadeId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "AcaoAtividade_AcaoAtividadeId_seq" OWNER TO postgres;

--
-- TOC entry 6924 (class 0 OID 0)
-- Dependencies: 190
-- Name: AcaoAtividade_AcaoAtividadeId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "AcaoAtividade_AcaoAtividadeId_seq" OWNED BY "AcaoAtividade"."AcaoAtividadeId";


--
-- TOC entry 191 (class 1259 OID 84290)
-- Name: AcaoStatus; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "AcaoStatus" (
    "AcaoStatusId" integer NOT NULL,
    "Nome" character varying(500) NOT NULL,
    "CriadoEm" timestamp without time zone NOT NULL,
    "AlteradoEm" timestamp without time zone,
    "CriadoPor" integer NOT NULL,
    "AlteradoPor" integer,
    "Deletado" boolean NOT NULL
);


ALTER TABLE "AcaoStatus" OWNER TO postgres;

--
-- TOC entry 192 (class 1259 OID 84296)
-- Name: AcaoStatus_AcaoStatusId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "AcaoStatus_AcaoStatusId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "AcaoStatus_AcaoStatusId_seq" OWNER TO postgres;

--
-- TOC entry 6927 (class 0 OID 0)
-- Dependencies: 192
-- Name: AcaoStatus_AcaoStatusId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "AcaoStatus_AcaoStatusId_seq" OWNED BY "AcaoStatus"."AcaoStatusId";


--
-- TOC entry 193 (class 1259 OID 84298)
-- Name: AcaoUsuario; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "AcaoUsuario" (
    "AcaoUsuarioId" integer NOT NULL,
    "AcaoId" integer NOT NULL,
    "UsuarioId" integer NOT NULL,
    "CriadoEm" timestamp without time zone NOT NULL,
    "AlteradoEm" timestamp without time zone,
    "CriadoPor" integer NOT NULL,
    "AlteradoPor" integer,
    "Deletado" boolean NOT NULL
);


ALTER TABLE "AcaoUsuario" OWNER TO postgres;

--
-- TOC entry 194 (class 1259 OID 84301)
-- Name: AcaoUsuario_AcaoUsuarioId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "AcaoUsuario_AcaoUsuarioId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "AcaoUsuario_AcaoUsuarioId_seq" OWNER TO postgres;

--
-- TOC entry 6930 (class 0 OID 0)
-- Dependencies: 194
-- Name: AcaoUsuario_AcaoUsuarioId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "AcaoUsuario_AcaoUsuarioId_seq" OWNED BY "AcaoUsuario"."AcaoUsuarioId";


--
-- TOC entry 195 (class 1259 OID 84303)
-- Name: Acao_AcaoId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "Acao_AcaoId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "Acao_AcaoId_seq" OWNER TO postgres;

--
-- TOC entry 6932 (class 0 OID 0)
-- Dependencies: 195
-- Name: Acao_AcaoId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "Acao_AcaoId_seq" OWNED BY "Acao"."AcaoId";


--
-- TOC entry 196 (class 1259 OID 84305)
-- Name: Arquivo; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "Arquivo" (
    "ArquivoId" integer NOT NULL,
    "Nome" character varying(300) NOT NULL,
    "Url" character varying(1000) NOT NULL,
    "CriadoEm" timestamp without time zone NOT NULL,
    "CriadoPor" integer NOT NULL,
    "AlteradoEm" timestamp without time zone,
    "AlteradoPor" integer,
    "Deletado" boolean NOT NULL
);


ALTER TABLE "Arquivo" OWNER TO postgres;

--
-- TOC entry 197 (class 1259 OID 84311)
-- Name: ArquivoFinanceiro; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "ArquivoFinanceiro" (
    "Id" integer NOT NULL,
    "Parcela" character varying(100) DEFAULT NULL::character varying,
    "Modelo" character varying(100) DEFAULT NULL::character varying,
    "ArquivoJson" text
);


ALTER TABLE "ArquivoFinanceiro" OWNER TO postgres;

--
-- TOC entry 198 (class 1259 OID 84319)
-- Name: ArquivoFinanceiro_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "ArquivoFinanceiro_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "ArquivoFinanceiro_Id_seq" OWNER TO postgres;

--
-- TOC entry 6936 (class 0 OID 0)
-- Dependencies: 198
-- Name: ArquivoFinanceiro_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "ArquivoFinanceiro_Id_seq" OWNED BY "ArquivoFinanceiro"."Id";


--
-- TOC entry 199 (class 1259 OID 84321)
-- Name: Arquivo_ArquivoId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "Arquivo_ArquivoId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "Arquivo_ArquivoId_seq" OWNER TO postgres;

--
-- TOC entry 6938 (class 0 OID 0)
-- Dependencies: 199
-- Name: Arquivo_ArquivoId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "Arquivo_ArquivoId_seq" OWNED BY "Arquivo"."ArquivoId";


--
-- TOC entry 200 (class 1259 OID 84323)
-- Name: CicloGestacao; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "CicloGestacao" (
    "CicloGestacaoId" integer NOT NULL,
    "DataInicio" timestamp without time zone NOT NULL,
    "DataFinal" timestamp without time zone NOT NULL,
    "Trimestre" integer NOT NULL,
    "CicloGestacaoPlanoId" integer NOT NULL,
    "CicloGestacaoStatusId" integer NOT NULL,
    "CicloGestacaoTemaId" integer NOT NULL,
    "Observacao" character varying(255) DEFAULT NULL::character varying,
    "AlteradoEm" timestamp without time zone,
    "AlteradoPor" integer,
    "CriadoPor" integer NOT NULL,
    "CriadoEm" timestamp without time zone NOT NULL,
    "Deletado" integer NOT NULL,
    "SemanaInicio" integer NOT NULL,
    "SemanaFim" integer NOT NULL
);


ALTER TABLE "CicloGestacao" OWNER TO postgres;

--
-- TOC entry 201 (class 1259 OID 84327)
-- Name: CicloGestacaoCategoria; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "CicloGestacaoCategoria" (
    "CicloGestacaoCategoriaId" integer NOT NULL,
    "Nome" character varying(50) NOT NULL
);


ALTER TABLE "CicloGestacaoCategoria" OWNER TO postgres;

--
-- TOC entry 202 (class 1259 OID 84330)
-- Name: CicloGestacaoCategoria_CicloGestacaoCategoriaId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "CicloGestacaoCategoria_CicloGestacaoCategoriaId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "CicloGestacaoCategoria_CicloGestacaoCategoriaId_seq" OWNER TO postgres;

--
-- TOC entry 6942 (class 0 OID 0)
-- Dependencies: 202
-- Name: CicloGestacaoCategoria_CicloGestacaoCategoriaId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "CicloGestacaoCategoria_CicloGestacaoCategoriaId_seq" OWNED BY "CicloGestacaoCategoria"."CicloGestacaoCategoriaId";


--
-- TOC entry 203 (class 1259 OID 84332)
-- Name: CicloGestacaoConfig; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "CicloGestacaoConfig" (
    "CicloGestacaoConfigId" integer NOT NULL,
    "CicloGestacaoTemaId" integer NOT NULL,
    "Inicio" integer NOT NULL,
    "Fim" integer NOT NULL,
    "Trimestre" integer NOT NULL,
    "Puerperio" integer NOT NULL
);


ALTER TABLE "CicloGestacaoConfig" OWNER TO postgres;

--
-- TOC entry 204 (class 1259 OID 84335)
-- Name: CicloGestacaoConfig_CicloGestacaoConfigId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "CicloGestacaoConfig_CicloGestacaoConfigId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "CicloGestacaoConfig_CicloGestacaoConfigId_seq" OWNER TO postgres;

--
-- TOC entry 6945 (class 0 OID 0)
-- Dependencies: 204
-- Name: CicloGestacaoConfig_CicloGestacaoConfigId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "CicloGestacaoConfig_CicloGestacaoConfigId_seq" OWNED BY "CicloGestacaoConfig"."CicloGestacaoConfigId";


--
-- TOC entry 205 (class 1259 OID 84337)
-- Name: CicloGestacaoPlano; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "CicloGestacaoPlano" (
    "CicloGestacaoPlanoId" integer NOT NULL,
    "DataInicio" timestamp without time zone NOT NULL,
    "DataTermino" timestamp without time zone,
    "Observacao" text,
    "PacienteId" integer NOT NULL,
    "CriadoEm" timestamp without time zone NOT NULL,
    "CriadoPor" integer NOT NULL,
    "AlteradoEm" timestamp without time zone,
    "AlteradoPor" integer,
    "CicloGestacaoPlanoStatusId" integer NOT NULL,
    "Deletado" boolean NOT NULL
);


ALTER TABLE "CicloGestacaoPlano" OWNER TO postgres;

--
-- TOC entry 206 (class 1259 OID 84343)
-- Name: CicloGestacaoPlanoStatus; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "CicloGestacaoPlanoStatus" (
    "CicloGestacaoPlanoStatusId" integer NOT NULL,
    "Nome" character varying(50) NOT NULL
);


ALTER TABLE "CicloGestacaoPlanoStatus" OWNER TO postgres;

--
-- TOC entry 207 (class 1259 OID 84346)
-- Name: CicloGestacaoPlanoStatus_CicloGestacaoPlanoStatusId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "CicloGestacaoPlanoStatus_CicloGestacaoPlanoStatusId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "CicloGestacaoPlanoStatus_CicloGestacaoPlanoStatusId_seq" OWNER TO postgres;

--
-- TOC entry 6949 (class 0 OID 0)
-- Dependencies: 207
-- Name: CicloGestacaoPlanoStatus_CicloGestacaoPlanoStatusId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "CicloGestacaoPlanoStatus_CicloGestacaoPlanoStatusId_seq" OWNED BY "CicloGestacaoPlanoStatus"."CicloGestacaoPlanoStatusId";


--
-- TOC entry 208 (class 1259 OID 84348)
-- Name: CicloGestacaoPlano_CicloGestacaoPlanoId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "CicloGestacaoPlano_CicloGestacaoPlanoId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "CicloGestacaoPlano_CicloGestacaoPlanoId_seq" OWNER TO postgres;

--
-- TOC entry 6951 (class 0 OID 0)
-- Dependencies: 208
-- Name: CicloGestacaoPlano_CicloGestacaoPlanoId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "CicloGestacaoPlano_CicloGestacaoPlanoId_seq" OWNED BY "CicloGestacaoPlano"."CicloGestacaoPlanoId";


--
-- TOC entry 209 (class 1259 OID 84350)
-- Name: CicloGestacaoStatus; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "CicloGestacaoStatus" (
    "CicloGestacaoStatusId" integer NOT NULL,
    "Nome" character varying(50) NOT NULL
);


ALTER TABLE "CicloGestacaoStatus" OWNER TO postgres;

--
-- TOC entry 210 (class 1259 OID 84353)
-- Name: CicloGestacaoStatus_CicloGestacaoStatusId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "CicloGestacaoStatus_CicloGestacaoStatusId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "CicloGestacaoStatus_CicloGestacaoStatusId_seq" OWNER TO postgres;

--
-- TOC entry 6954 (class 0 OID 0)
-- Dependencies: 210
-- Name: CicloGestacaoStatus_CicloGestacaoStatusId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "CicloGestacaoStatus_CicloGestacaoStatusId_seq" OWNED BY "CicloGestacaoStatus"."CicloGestacaoStatusId";


--
-- TOC entry 211 (class 1259 OID 84355)
-- Name: CicloGestacaoTema; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "CicloGestacaoTema" (
    "CicloGestacaoTemaId" integer NOT NULL,
    "Nome" character varying(200) NOT NULL,
    "Codigo" character varying(20) NOT NULL,
    "CicloGestacaoCategoriaId" integer NOT NULL
);


ALTER TABLE "CicloGestacaoTema" OWNER TO postgres;

--
-- TOC entry 212 (class 1259 OID 84358)
-- Name: CicloGestacaoTema_CicloGestacaoTemaId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "CicloGestacaoTema_CicloGestacaoTemaId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "CicloGestacaoTema_CicloGestacaoTemaId_seq" OWNER TO postgres;

--
-- TOC entry 6957 (class 0 OID 0)
-- Dependencies: 212
-- Name: CicloGestacaoTema_CicloGestacaoTemaId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "CicloGestacaoTema_CicloGestacaoTemaId_seq" OWNED BY "CicloGestacaoTema"."CicloGestacaoTemaId";


--
-- TOC entry 213 (class 1259 OID 84360)
-- Name: CicloGestacao_CicloGestacaoId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "CicloGestacao_CicloGestacaoId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "CicloGestacao_CicloGestacaoId_seq" OWNER TO postgres;

--
-- TOC entry 6959 (class 0 OID 0)
-- Dependencies: 213
-- Name: CicloGestacao_CicloGestacaoId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "CicloGestacao_CicloGestacaoId_seq" OWNED BY "CicloGestacao"."CicloGestacaoId";


--
-- TOC entry 214 (class 1259 OID 84362)
-- Name: Municipio; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "Municipio" (
    "MunicipioId" integer NOT NULL,
    "Nome" character varying(100) NOT NULL,
    "Codigo" character varying(100) NOT NULL
);


ALTER TABLE "Municipio" OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 84365)
-- Name: Municipio_MunicipioId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "Municipio_MunicipioId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "Municipio_MunicipioId_seq" OWNER TO postgres;

--
-- TOC entry 6962 (class 0 OID 0)
-- Dependencies: 215
-- Name: Municipio_MunicipioId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "Municipio_MunicipioId_seq" OWNED BY "Municipio"."MunicipioId";


--
-- TOC entry 216 (class 1259 OID 84367)
-- Name: Notificacao; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "Notificacao" (
    "NotificacaoId" integer NOT NULL,
    "Nome" character varying(200) NOT NULL,
    "Descricao" character varying(500) NOT NULL,
    "Tipo" integer NOT NULL,
    "Url" character varying(500) NOT NULL,
    "UsuarioId" integer NOT NULL,
    "CriadoEm" timestamp without time zone NOT NULL,
    "Status" character varying(50) NOT NULL
);


ALTER TABLE "Notificacao" OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 84373)
-- Name: Notificacao_NotificacaoId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "Notificacao_NotificacaoId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "Notificacao_NotificacaoId_seq" OWNER TO postgres;

--
-- TOC entry 6965 (class 0 OID 0)
-- Dependencies: 217
-- Name: Notificacao_NotificacaoId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "Notificacao_NotificacaoId_seq" OWNED BY "Notificacao"."NotificacaoId";


--
-- TOC entry 218 (class 1259 OID 84375)
-- Name: Paciente; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "Paciente" (
    "PacienteId" integer NOT NULL,
    "Uuid" character varying(130),
    "NomeCompleto" character varying(256),
    "Gender" character varying(256),
    "DataNascimento" timestamp without time zone,
    "NumeroCpf" character varying(30),
    "NomeUnidade" character varying(256),
    "NomeEquipe" character varying(256),
    "Localidade" integer
);


ALTER TABLE "Paciente" OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 84381)
-- Name: Paciente_PacienteId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "Paciente_PacienteId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "Paciente_PacienteId_seq" OWNER TO postgres;

--
-- TOC entry 6968 (class 0 OID 0)
-- Dependencies: 219
-- Name: Paciente_PacienteId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "Paciente_PacienteId_seq" OWNED BY "Paciente"."PacienteId";


--
-- TOC entry 220 (class 1259 OID 84383)
-- Name: Perfil; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "Perfil" (
    "PerfilId" integer NOT NULL,
    "Nome" character varying(100) NOT NULL,
    "Tipo" integer NOT NULL,
    "Deletado" boolean NOT NULL
);


ALTER TABLE "Perfil" OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 84386)
-- Name: Perfil_PerfilId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "Perfil_PerfilId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "Perfil_PerfilId_seq" OWNER TO postgres;

--
-- TOC entry 6971 (class 0 OID 0)
-- Dependencies: 221
-- Name: Perfil_PerfilId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "Perfil_PerfilId_seq" OWNED BY "Perfil"."PerfilId";


--
-- TOC entry 222 (class 1259 OID 84388)
-- Name: Teste; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "Teste" (
    "ID" integer NOT NULL
);


ALTER TABLE "Teste" OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 84391)
-- Name: Usuario; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "Usuario" (
    "UsuarioId" integer NOT NULL,
    "Nome" character varying(300) NOT NULL,
    "Email" character varying(300) NOT NULL,
    "Cns" character varying(300) NOT NULL,
    "CriadoEm" timestamp without time zone NOT NULL,
    "AlteradoEm" timestamp without time zone,
    "CriadoPor" integer NOT NULL,
    "AlteradoPor" integer,
    "Deletado" boolean NOT NULL,
    "Senha" character varying(100) NOT NULL,
    "PerfilId" integer NOT NULL,
    "Login" character varying(100) NOT NULL
);


ALTER TABLE "Usuario" OWNER TO postgres;

--
-- TOC entry 224 (class 1259 OID 84397)
-- Name: UsuarioMunicipio; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE "UsuarioMunicipio" (
    "UsuarioMunicipioId" integer NOT NULL,
    "UsuarioId" integer NOT NULL,
    "MunicipioId" integer NOT NULL,
    "Deletado" boolean NOT NULL
);


ALTER TABLE "UsuarioMunicipio" OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 84400)
-- Name: UsuarioMunicipio_UsuarioMunicipioId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "UsuarioMunicipio_UsuarioMunicipioId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "UsuarioMunicipio_UsuarioMunicipioId_seq" OWNER TO postgres;

--
-- TOC entry 6976 (class 0 OID 0)
-- Dependencies: 225
-- Name: UsuarioMunicipio_UsuarioMunicipioId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "UsuarioMunicipio_UsuarioMunicipioId_seq" OWNED BY "UsuarioMunicipio"."UsuarioMunicipioId";


--
-- TOC entry 226 (class 1259 OID 84402)
-- Name: Usuario_UsuarioId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "Usuario_UsuarioId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "Usuario_UsuarioId_seq" OWNER TO postgres;

--
-- TOC entry 6978 (class 0 OID 0)
-- Dependencies: 226
-- Name: Usuario_UsuarioId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "Usuario_UsuarioId_seq" OWNED BY "Usuario"."UsuarioId";


--
-- TOC entry 227 (class 1259 OID 84404)
-- Name: appsettings; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE appsettings (
    appsettingsid integer NOT NULL,
    tipo integer NOT NULL,
    descricao character varying(1000) NOT NULL
);


ALTER TABLE appsettings OWNER TO postgres;

--
-- TOC entry 228 (class 1259 OID 84410)
-- Name: appsettings_appsettingsid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE appsettings_appsettingsid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE appsettings_appsettingsid_seq OWNER TO postgres;

--
-- TOC entry 6981 (class 0 OID 0)
-- Dependencies: 228
-- Name: appsettings_appsettingsid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE appsettings_appsettingsid_seq OWNED BY appsettings.appsettingsid;


--
-- TOC entry 6662 (class 2604 OID 89703)
-- Name: Acao AcaoId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Acao" ALTER COLUMN "AcaoId" SET DEFAULT nextval('"Acao_AcaoId_seq"'::regclass);


--
-- TOC entry 6663 (class 2604 OID 89704)
-- Name: AcaoArquivo AcaoArquivoId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoArquivo" ALTER COLUMN "AcaoArquivoId" SET DEFAULT nextval('"AcaoArquivo_AcaoArquivoId_seq"'::regclass);


--
-- TOC entry 6664 (class 2604 OID 89705)
-- Name: AcaoAtividade AcaoAtividadeId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoAtividade" ALTER COLUMN "AcaoAtividadeId" SET DEFAULT nextval('"AcaoAtividade_AcaoAtividadeId_seq"'::regclass);


--
-- TOC entry 6665 (class 2604 OID 89706)
-- Name: AcaoStatus AcaoStatusId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoStatus" ALTER COLUMN "AcaoStatusId" SET DEFAULT nextval('"AcaoStatus_AcaoStatusId_seq"'::regclass);


--
-- TOC entry 6666 (class 2604 OID 89707)
-- Name: AcaoUsuario AcaoUsuarioId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoUsuario" ALTER COLUMN "AcaoUsuarioId" SET DEFAULT nextval('"AcaoUsuario_AcaoUsuarioId_seq"'::regclass);


--
-- TOC entry 6667 (class 2604 OID 89708)
-- Name: Arquivo ArquivoId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Arquivo" ALTER COLUMN "ArquivoId" SET DEFAULT nextval('"Arquivo_ArquivoId_seq"'::regclass);


--
-- TOC entry 6670 (class 2604 OID 89709)
-- Name: ArquivoFinanceiro Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "ArquivoFinanceiro" ALTER COLUMN "Id" SET DEFAULT nextval('"ArquivoFinanceiro_Id_seq"'::regclass);


--
-- TOC entry 6672 (class 2604 OID 89710)
-- Name: CicloGestacao CicloGestacaoId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacao" ALTER COLUMN "CicloGestacaoId" SET DEFAULT nextval('"CicloGestacao_CicloGestacaoId_seq"'::regclass);


--
-- TOC entry 6673 (class 2604 OID 89711)
-- Name: CicloGestacaoCategoria CicloGestacaoCategoriaId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoCategoria" ALTER COLUMN "CicloGestacaoCategoriaId" SET DEFAULT nextval('"CicloGestacaoCategoria_CicloGestacaoCategoriaId_seq"'::regclass);


--
-- TOC entry 6674 (class 2604 OID 89712)
-- Name: CicloGestacaoConfig CicloGestacaoConfigId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoConfig" ALTER COLUMN "CicloGestacaoConfigId" SET DEFAULT nextval('"CicloGestacaoConfig_CicloGestacaoConfigId_seq"'::regclass);


--
-- TOC entry 6675 (class 2604 OID 89713)
-- Name: CicloGestacaoPlano CicloGestacaoPlanoId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoPlano" ALTER COLUMN "CicloGestacaoPlanoId" SET DEFAULT nextval('"CicloGestacaoPlano_CicloGestacaoPlanoId_seq"'::regclass);


--
-- TOC entry 6676 (class 2604 OID 89714)
-- Name: CicloGestacaoPlanoStatus CicloGestacaoPlanoStatusId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoPlanoStatus" ALTER COLUMN "CicloGestacaoPlanoStatusId" SET DEFAULT nextval('"CicloGestacaoPlanoStatus_CicloGestacaoPlanoStatusId_seq"'::regclass);


--
-- TOC entry 6677 (class 2604 OID 89715)
-- Name: CicloGestacaoStatus CicloGestacaoStatusId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoStatus" ALTER COLUMN "CicloGestacaoStatusId" SET DEFAULT nextval('"CicloGestacaoStatus_CicloGestacaoStatusId_seq"'::regclass);


--
-- TOC entry 6678 (class 2604 OID 89716)
-- Name: CicloGestacaoTema CicloGestacaoTemaId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoTema" ALTER COLUMN "CicloGestacaoTemaId" SET DEFAULT nextval('"CicloGestacaoTema_CicloGestacaoTemaId_seq"'::regclass);


--
-- TOC entry 6679 (class 2604 OID 89717)
-- Name: Municipio MunicipioId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Municipio" ALTER COLUMN "MunicipioId" SET DEFAULT nextval('"Municipio_MunicipioId_seq"'::regclass);


--
-- TOC entry 6680 (class 2604 OID 89718)
-- Name: Notificacao NotificacaoId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Notificacao" ALTER COLUMN "NotificacaoId" SET DEFAULT nextval('"Notificacao_NotificacaoId_seq"'::regclass);


--
-- TOC entry 6681 (class 2604 OID 89719)
-- Name: Paciente PacienteId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Paciente" ALTER COLUMN "PacienteId" SET DEFAULT nextval('"Paciente_PacienteId_seq"'::regclass);


--
-- TOC entry 6682 (class 2604 OID 89720)
-- Name: Perfil PerfilId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Perfil" ALTER COLUMN "PerfilId" SET DEFAULT nextval('"Perfil_PerfilId_seq"'::regclass);


--
-- TOC entry 6683 (class 2604 OID 89721)
-- Name: Usuario UsuarioId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Usuario" ALTER COLUMN "UsuarioId" SET DEFAULT nextval('"Usuario_UsuarioId_seq"'::regclass);


--
-- TOC entry 6684 (class 2604 OID 89722)
-- Name: UsuarioMunicipio UsuarioMunicipioId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "UsuarioMunicipio" ALTER COLUMN "UsuarioMunicipioId" SET DEFAULT nextval('"UsuarioMunicipio_UsuarioMunicipioId_seq"'::regclass);


--
-- TOC entry 6685 (class 2604 OID 89723)
-- Name: appsettings appsettingsid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY appsettings ALTER COLUMN appsettingsid SET DEFAULT nextval('appsettings_appsettingsid_seq'::regclass);


--
-- TOC entry 6692 (class 2606 OID 89732)
-- Name: AcaoArquivo AcaoArquivo_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoArquivo"
    ADD CONSTRAINT "AcaoArquivo_pkey" PRIMARY KEY ("AcaoArquivoId");


--
-- TOC entry 6698 (class 2606 OID 89734)
-- Name: AcaoAtividade AcaoAtividade_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoAtividade"
    ADD CONSTRAINT "AcaoAtividade_pkey" PRIMARY KEY ("AcaoAtividadeId");


--
-- TOC entry 6703 (class 2606 OID 89736)
-- Name: AcaoStatus AcaoStatus_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoStatus"
    ADD CONSTRAINT "AcaoStatus_pkey" PRIMARY KEY ("AcaoStatusId");


--
-- TOC entry 6707 (class 2606 OID 89738)
-- Name: AcaoUsuario AcaoUsuario_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoUsuario"
    ADD CONSTRAINT "AcaoUsuario_pkey" PRIMARY KEY ("AcaoUsuarioId");


--
-- TOC entry 6687 (class 2606 OID 89740)
-- Name: Acao Acao_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Acao"
    ADD CONSTRAINT "Acao_pkey" PRIMARY KEY ("AcaoId");


--
-- TOC entry 6717 (class 2606 OID 89742)
-- Name: ArquivoFinanceiro ArquivoFinanceiro_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "ArquivoFinanceiro"
    ADD CONSTRAINT "ArquivoFinanceiro_pkey" PRIMARY KEY ("Id");


--
-- TOC entry 6713 (class 2606 OID 89744)
-- Name: Arquivo Arquivo_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Arquivo"
    ADD CONSTRAINT "Arquivo_pkey" PRIMARY KEY ("ArquivoId");


--
-- TOC entry 6726 (class 2606 OID 89746)
-- Name: CicloGestacaoCategoria CicloGestacaoCategoria_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoCategoria"
    ADD CONSTRAINT "CicloGestacaoCategoria_pkey" PRIMARY KEY ("CicloGestacaoCategoriaId");


--
-- TOC entry 6728 (class 2606 OID 89748)
-- Name: CicloGestacaoConfig CicloGestacaoConfig_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoConfig"
    ADD CONSTRAINT "CicloGestacaoConfig_pkey" PRIMARY KEY ("CicloGestacaoConfigId");


--
-- TOC entry 6735 (class 2606 OID 89750)
-- Name: CicloGestacaoPlanoStatus CicloGestacaoPlanoStatus_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoPlanoStatus"
    ADD CONSTRAINT "CicloGestacaoPlanoStatus_pkey" PRIMARY KEY ("CicloGestacaoPlanoStatusId");


--
-- TOC entry 6731 (class 2606 OID 89752)
-- Name: CicloGestacaoPlano CicloGestacaoPlano_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoPlano"
    ADD CONSTRAINT "CicloGestacaoPlano_pkey" PRIMARY KEY ("CicloGestacaoPlanoId");


--
-- TOC entry 6737 (class 2606 OID 89754)
-- Name: CicloGestacaoStatus CicloGestacaoStatus_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoStatus"
    ADD CONSTRAINT "CicloGestacaoStatus_pkey" PRIMARY KEY ("CicloGestacaoStatusId");


--
-- TOC entry 6739 (class 2606 OID 89756)
-- Name: CicloGestacaoTema CicloGestacaoTema_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoTema"
    ADD CONSTRAINT "CicloGestacaoTema_pkey" PRIMARY KEY ("CicloGestacaoTemaId");


--
-- TOC entry 6719 (class 2606 OID 89758)
-- Name: CicloGestacao CicloGestacao_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacao"
    ADD CONSTRAINT "CicloGestacao_pkey" PRIMARY KEY ("CicloGestacaoId");


--
-- TOC entry 6742 (class 2606 OID 89760)
-- Name: Municipio Municipio_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Municipio"
    ADD CONSTRAINT "Municipio_pkey" PRIMARY KEY ("MunicipioId");


--
-- TOC entry 6745 (class 2606 OID 89762)
-- Name: Notificacao Notificacao_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Notificacao"
    ADD CONSTRAINT "Notificacao_pkey" PRIMARY KEY ("NotificacaoId");


--
-- TOC entry 6747 (class 2606 OID 89764)
-- Name: Paciente Paciente_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Paciente"
    ADD CONSTRAINT "Paciente_pkey" PRIMARY KEY ("PacienteId");


--
-- TOC entry 6749 (class 2606 OID 89766)
-- Name: Perfil Perfil_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Perfil"
    ADD CONSTRAINT "Perfil_pkey" PRIMARY KEY ("PerfilId");


--
-- TOC entry 6751 (class 2606 OID 89768)
-- Name: Teste Teste_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Teste"
    ADD CONSTRAINT "Teste_pkey" PRIMARY KEY ("ID");


--
-- TOC entry 6758 (class 2606 OID 89770)
-- Name: UsuarioMunicipio UsuarioMunicipio_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "UsuarioMunicipio"
    ADD CONSTRAINT "UsuarioMunicipio_pkey" PRIMARY KEY ("UsuarioMunicipioId");


--
-- TOC entry 6754 (class 2606 OID 89772)
-- Name: Usuario Usuario_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Usuario"
    ADD CONSTRAINT "Usuario_pkey" PRIMARY KEY ("UsuarioId");


--
-- TOC entry 6760 (class 2606 OID 89774)
-- Name: appsettings appsettings_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY appsettings
    ADD CONSTRAINT appsettings_pkey PRIMARY KEY (appsettingsid);


--
-- TOC entry 6693 (class 1259 OID 91816)
-- Name: FK_AcaoArquivo_Acao; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_AcaoArquivo_Acao" ON public."AcaoArquivo" USING btree ("AcaoId");


--
-- TOC entry 6694 (class 1259 OID 91817)
-- Name: FK_AcaoArquivo_Arquivo; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_AcaoArquivo_Arquivo" ON public."AcaoArquivo" USING btree ("ArquivoId");


--
-- TOC entry 6695 (class 1259 OID 91818)
-- Name: FK_AcaoArquivo_Usuario; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_AcaoArquivo_Usuario" ON public."AcaoArquivo" USING btree ("CriadoPor");


--
-- TOC entry 6696 (class 1259 OID 91819)
-- Name: FK_AcaoArquivo_Usuario1; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_AcaoArquivo_Usuario1" ON public."AcaoArquivo" USING btree ("AlteradoPor");


--
-- TOC entry 6699 (class 1259 OID 91820)
-- Name: FK_AcaoAtividade_Acao; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_AcaoAtividade_Acao" ON public."AcaoAtividade" USING btree ("AcaoId");


--
-- TOC entry 6700 (class 1259 OID 91821)
-- Name: FK_AcaoAtividade_Usuario; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_AcaoAtividade_Usuario" ON public."AcaoAtividade" USING btree ("CriadoPor");


--
-- TOC entry 6701 (class 1259 OID 91822)
-- Name: FK_AcaoAtividade_Usuario1; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_AcaoAtividade_Usuario1" ON public."AcaoAtividade" USING btree ("AlteradoPor");


--
-- TOC entry 6704 (class 1259 OID 91823)
-- Name: FK_AcaoStatus_Usuario; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_AcaoStatus_Usuario" ON public."AcaoStatus" USING btree ("CriadoPor");


--
-- TOC entry 6705 (class 1259 OID 91824)
-- Name: FK_AcaoStatus_Usuario1; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_AcaoStatus_Usuario1" ON public."AcaoStatus" USING btree ("AlteradoPor");


--
-- TOC entry 6708 (class 1259 OID 91825)
-- Name: FK_AcaoUsuario_Acao; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_AcaoUsuario_Acao" ON public."AcaoUsuario" USING btree ("AcaoId");


--
-- TOC entry 6709 (class 1259 OID 91826)
-- Name: FK_AcaoUsuario_Usuario; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_AcaoUsuario_Usuario" ON public."AcaoUsuario" USING btree ("CriadoPor");


--
-- TOC entry 6710 (class 1259 OID 91827)
-- Name: FK_AcaoUsuario_Usuario1; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_AcaoUsuario_Usuario1" ON public."AcaoUsuario" USING btree ("AlteradoPor");


--
-- TOC entry 6711 (class 1259 OID 91828)
-- Name: FK_AcaoUsuario_Usuario2; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_AcaoUsuario_Usuario2" ON public."AcaoUsuario" USING btree ("UsuarioId");


--
-- TOC entry 6688 (class 1259 OID 91829)
-- Name: FK_Acao_AcaoStatus; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_Acao_AcaoStatus" ON public."Acao" USING btree ("AcaoStatusId");


--
-- TOC entry 6689 (class 1259 OID 91830)
-- Name: FK_Acao_Usuario; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_Acao_Usuario" ON public."Acao" USING btree ("CriadoPor");


--
-- TOC entry 6690 (class 1259 OID 91831)
-- Name: FK_Acao_Usuario1; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_Acao_Usuario1" ON public."Acao" USING btree ("AlteradoPor");


--
-- TOC entry 6714 (class 1259 OID 91832)
-- Name: FK_Arquivo_Usuario; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_Arquivo_Usuario" ON public."Arquivo" USING btree ("CriadoPor");


--
-- TOC entry 6715 (class 1259 OID 91833)
-- Name: FK_Arquivo_Usuario1; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_Arquivo_Usuario1" ON public."Arquivo" USING btree ("AlteradoPor");


--
-- TOC entry 6729 (class 1259 OID 91834)
-- Name: FK_CicloGestacaoConfig_CicloGestacaoTema; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_CicloGestacaoConfig_CicloGestacaoTema" ON public."CicloGestacaoConfig" USING btree ("CicloGestacaoTemaId");


--
-- TOC entry 6732 (class 1259 OID 91835)
-- Name: FK_CicloGestacaoPlano_CicloGestacaoPlanoStatus; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_CicloGestacaoPlano_CicloGestacaoPlanoStatus" ON public."CicloGestacaoPlano" USING btree ("CicloGestacaoPlanoStatusId");


--
-- TOC entry 6733 (class 1259 OID 91836)
-- Name: FK_CicloGestacaoPlano_Paciente; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_CicloGestacaoPlano_Paciente" ON public."CicloGestacaoPlano" USING btree ("PacienteId");


--
-- TOC entry 6740 (class 1259 OID 91837)
-- Name: FK_CicloGestacaoTema_CicloGestacaoCategoria; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_CicloGestacaoTema_CicloGestacaoCategoria" ON public."CicloGestacaoTema" USING btree ("CicloGestacaoCategoriaId");


--
-- TOC entry 6720 (class 1259 OID 91838)
-- Name: FK_CicloGestacao_CicloGestacaoPlano; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_CicloGestacao_CicloGestacaoPlano" ON public."CicloGestacao" USING btree ("CicloGestacaoPlanoId");


--
-- TOC entry 6721 (class 1259 OID 91839)
-- Name: FK_CicloGestacao_CicloGestacaoStatus; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_CicloGestacao_CicloGestacaoStatus" ON public."CicloGestacao" USING btree ("CicloGestacaoStatusId");


--
-- TOC entry 6722 (class 1259 OID 91840)
-- Name: FK_CicloGestacao_CicloGestacaoTema; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_CicloGestacao_CicloGestacaoTema" ON public."CicloGestacao" USING btree ("CicloGestacaoTemaId");


--
-- TOC entry 6723 (class 1259 OID 91841)
-- Name: FK_CicloGestacao_Usuario; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_CicloGestacao_Usuario" ON public."CicloGestacao" USING btree ("AlteradoPor");


--
-- TOC entry 6724 (class 1259 OID 91842)
-- Name: FK_CicloGestacao_Usuario1; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_CicloGestacao_Usuario1" ON public."CicloGestacao" USING btree ("CriadoPor");


--
-- TOC entry 6743 (class 1259 OID 91843)
-- Name: FK_Notificacao_Usuario; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_Notificacao_Usuario" ON public."Notificacao" USING btree ("UsuarioId");


--
-- TOC entry 6755 (class 1259 OID 91844)
-- Name: FK_UsuarioMunicipio_Municipio; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_UsuarioMunicipio_Municipio" ON public."UsuarioMunicipio" USING btree ("MunicipioId");


--
-- TOC entry 6756 (class 1259 OID 91845)
-- Name: FK_UsuarioMunicipio_Usuario; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_UsuarioMunicipio_Usuario" ON public."UsuarioMunicipio" USING btree ("UsuarioId");


--
-- TOC entry 6752 (class 1259 OID 91846)
-- Name: FK_Usuario_Perfil; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "FK_Usuario_Perfil" ON public."Usuario" USING btree ("PerfilId");


--
-- TOC entry 6764 (class 2606 OID 92992)
-- Name: AcaoArquivo FK_AcaoArquivo_Acao; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoArquivo"
    ADD CONSTRAINT "FK_AcaoArquivo_Acao" FOREIGN KEY ("AcaoId") REFERENCES "Acao"("AcaoId") ON DELETE RESTRICT;


--
-- TOC entry 6765 (class 2606 OID 92997)
-- Name: AcaoArquivo FK_AcaoArquivo_Arquivo; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoArquivo"
    ADD CONSTRAINT "FK_AcaoArquivo_Arquivo" FOREIGN KEY ("ArquivoId") REFERENCES "Arquivo"("ArquivoId") ON DELETE RESTRICT;


--
-- TOC entry 6766 (class 2606 OID 93002)
-- Name: AcaoArquivo FK_AcaoArquivo_Usuario; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoArquivo"
    ADD CONSTRAINT "FK_AcaoArquivo_Usuario" FOREIGN KEY ("CriadoPor") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6767 (class 2606 OID 93007)
-- Name: AcaoArquivo FK_AcaoArquivo_Usuario1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoArquivo"
    ADD CONSTRAINT "FK_AcaoArquivo_Usuario1" FOREIGN KEY ("AlteradoPor") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6768 (class 2606 OID 93012)
-- Name: AcaoAtividade FK_AcaoAtividade_Acao; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoAtividade"
    ADD CONSTRAINT "FK_AcaoAtividade_Acao" FOREIGN KEY ("AcaoId") REFERENCES "Acao"("AcaoId") ON DELETE RESTRICT;


--
-- TOC entry 6769 (class 2606 OID 93017)
-- Name: AcaoAtividade FK_AcaoAtividade_Usuario; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoAtividade"
    ADD CONSTRAINT "FK_AcaoAtividade_Usuario" FOREIGN KEY ("CriadoPor") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6770 (class 2606 OID 93022)
-- Name: AcaoAtividade FK_AcaoAtividade_Usuario1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoAtividade"
    ADD CONSTRAINT "FK_AcaoAtividade_Usuario1" FOREIGN KEY ("AlteradoPor") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6771 (class 2606 OID 93027)
-- Name: AcaoStatus FK_AcaoStatus_Usuario; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoStatus"
    ADD CONSTRAINT "FK_AcaoStatus_Usuario" FOREIGN KEY ("CriadoPor") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6772 (class 2606 OID 93032)
-- Name: AcaoStatus FK_AcaoStatus_Usuario1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoStatus"
    ADD CONSTRAINT "FK_AcaoStatus_Usuario1" FOREIGN KEY ("AlteradoPor") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6773 (class 2606 OID 93037)
-- Name: AcaoUsuario FK_AcaoUsuario_Acao; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoUsuario"
    ADD CONSTRAINT "FK_AcaoUsuario_Acao" FOREIGN KEY ("AcaoId") REFERENCES "Acao"("AcaoId") ON DELETE RESTRICT;


--
-- TOC entry 6774 (class 2606 OID 93042)
-- Name: AcaoUsuario FK_AcaoUsuario_Usuario; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoUsuario"
    ADD CONSTRAINT "FK_AcaoUsuario_Usuario" FOREIGN KEY ("CriadoPor") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6775 (class 2606 OID 93047)
-- Name: AcaoUsuario FK_AcaoUsuario_Usuario1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoUsuario"
    ADD CONSTRAINT "FK_AcaoUsuario_Usuario1" FOREIGN KEY ("AlteradoPor") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6776 (class 2606 OID 93052)
-- Name: AcaoUsuario FK_AcaoUsuario_Usuario2; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "AcaoUsuario"
    ADD CONSTRAINT "FK_AcaoUsuario_Usuario2" FOREIGN KEY ("UsuarioId") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6761 (class 2606 OID 93057)
-- Name: Acao FK_Acao_AcaoStatus; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Acao"
    ADD CONSTRAINT "FK_Acao_AcaoStatus" FOREIGN KEY ("AcaoStatusId") REFERENCES "AcaoStatus"("AcaoStatusId") ON DELETE RESTRICT;


--
-- TOC entry 6762 (class 2606 OID 93062)
-- Name: Acao FK_Acao_Usuario; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Acao"
    ADD CONSTRAINT "FK_Acao_Usuario" FOREIGN KEY ("CriadoPor") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6763 (class 2606 OID 93067)
-- Name: Acao FK_Acao_Usuario1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Acao"
    ADD CONSTRAINT "FK_Acao_Usuario1" FOREIGN KEY ("AlteradoPor") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6777 (class 2606 OID 93072)
-- Name: Arquivo FK_Arquivo_Usuario; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Arquivo"
    ADD CONSTRAINT "FK_Arquivo_Usuario" FOREIGN KEY ("CriadoPor") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6778 (class 2606 OID 93077)
-- Name: Arquivo FK_Arquivo_Usuario1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Arquivo"
    ADD CONSTRAINT "FK_Arquivo_Usuario1" FOREIGN KEY ("AlteradoPor") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6784 (class 2606 OID 93082)
-- Name: CicloGestacaoConfig FK_CicloGestacaoConfig_CicloGestacaoTema; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoConfig"
    ADD CONSTRAINT "FK_CicloGestacaoConfig_CicloGestacaoTema" FOREIGN KEY ("CicloGestacaoTemaId") REFERENCES "CicloGestacaoTema"("CicloGestacaoTemaId") ON DELETE RESTRICT;


--
-- TOC entry 6785 (class 2606 OID 93087)
-- Name: CicloGestacaoPlano FK_CicloGestacaoPlano_CicloGestacaoPlanoStatus; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoPlano"
    ADD CONSTRAINT "FK_CicloGestacaoPlano_CicloGestacaoPlanoStatus" FOREIGN KEY ("CicloGestacaoPlanoStatusId") REFERENCES "CicloGestacaoPlanoStatus"("CicloGestacaoPlanoStatusId") ON DELETE RESTRICT;


--
-- TOC entry 6786 (class 2606 OID 93092)
-- Name: CicloGestacaoPlano FK_CicloGestacaoPlano_Paciente; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoPlano"
    ADD CONSTRAINT "FK_CicloGestacaoPlano_Paciente" FOREIGN KEY ("PacienteId") REFERENCES "Paciente"("PacienteId") ON DELETE RESTRICT;


--
-- TOC entry 6787 (class 2606 OID 93097)
-- Name: CicloGestacaoTema FK_CicloGestacaoTema_CicloGestacaoCategoria; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacaoTema"
    ADD CONSTRAINT "FK_CicloGestacaoTema_CicloGestacaoCategoria" FOREIGN KEY ("CicloGestacaoCategoriaId") REFERENCES "CicloGestacaoCategoria"("CicloGestacaoCategoriaId") ON DELETE RESTRICT;


--
-- TOC entry 6779 (class 2606 OID 93102)
-- Name: CicloGestacao FK_CicloGestacao_CicloGestacaoPlano; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacao"
    ADD CONSTRAINT "FK_CicloGestacao_CicloGestacaoPlano" FOREIGN KEY ("CicloGestacaoPlanoId") REFERENCES "CicloGestacaoPlano"("CicloGestacaoPlanoId") ON DELETE RESTRICT;


--
-- TOC entry 6780 (class 2606 OID 93107)
-- Name: CicloGestacao FK_CicloGestacao_CicloGestacaoStatus; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacao"
    ADD CONSTRAINT "FK_CicloGestacao_CicloGestacaoStatus" FOREIGN KEY ("CicloGestacaoStatusId") REFERENCES "CicloGestacaoStatus"("CicloGestacaoStatusId") ON DELETE RESTRICT;


--
-- TOC entry 6781 (class 2606 OID 93112)
-- Name: CicloGestacao FK_CicloGestacao_CicloGestacaoTema; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacao"
    ADD CONSTRAINT "FK_CicloGestacao_CicloGestacaoTema" FOREIGN KEY ("CicloGestacaoTemaId") REFERENCES "CicloGestacaoTema"("CicloGestacaoTemaId") ON DELETE RESTRICT;


--
-- TOC entry 6782 (class 2606 OID 93117)
-- Name: CicloGestacao FK_CicloGestacao_Usuario; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacao"
    ADD CONSTRAINT "FK_CicloGestacao_Usuario" FOREIGN KEY ("AlteradoPor") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6783 (class 2606 OID 93122)
-- Name: CicloGestacao FK_CicloGestacao_Usuario1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "CicloGestacao"
    ADD CONSTRAINT "FK_CicloGestacao_Usuario1" FOREIGN KEY ("CriadoPor") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6788 (class 2606 OID 93127)
-- Name: Notificacao FK_Notificacao_Usuario; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Notificacao"
    ADD CONSTRAINT "FK_Notificacao_Usuario" FOREIGN KEY ("UsuarioId") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6790 (class 2606 OID 93132)
-- Name: UsuarioMunicipio FK_UsuarioMunicipio_Municipio; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "UsuarioMunicipio"
    ADD CONSTRAINT "FK_UsuarioMunicipio_Municipio" FOREIGN KEY ("MunicipioId") REFERENCES "Municipio"("MunicipioId") ON DELETE RESTRICT;


--
-- TOC entry 6791 (class 2606 OID 93137)
-- Name: UsuarioMunicipio FK_UsuarioMunicipio_Usuario; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "UsuarioMunicipio"
    ADD CONSTRAINT "FK_UsuarioMunicipio_Usuario" FOREIGN KEY ("UsuarioId") REFERENCES "Usuario"("UsuarioId") ON DELETE RESTRICT;


--
-- TOC entry 6789 (class 2606 OID 93142)
-- Name: Usuario FK_Usuario_Perfil; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "Usuario"
    ADD CONSTRAINT "FK_Usuario_Perfil" FOREIGN KEY ("PerfilId") REFERENCES "Perfil"("PerfilId") ON DELETE RESTRICT;


--
-- TOC entry 6919 (class 0 OID 0)
-- Dependencies: 186
-- Name: Acao; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "Acao" TO esus_leitura;


--
-- TOC entry 6920 (class 0 OID 0)
-- Dependencies: 187
-- Name: AcaoArquivo; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "AcaoArquivo" TO esus_leitura;


--
-- TOC entry 6922 (class 0 OID 0)
-- Dependencies: 188
-- Name: AcaoArquivo_AcaoArquivoId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "AcaoArquivo_AcaoArquivoId_seq" TO esus_leitura;


--
-- TOC entry 6923 (class 0 OID 0)
-- Dependencies: 189
-- Name: AcaoAtividade; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "AcaoAtividade" TO esus_leitura;


--
-- TOC entry 6925 (class 0 OID 0)
-- Dependencies: 190
-- Name: AcaoAtividade_AcaoAtividadeId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "AcaoAtividade_AcaoAtividadeId_seq" TO esus_leitura;


--
-- TOC entry 6926 (class 0 OID 0)
-- Dependencies: 191
-- Name: AcaoStatus; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "AcaoStatus" TO esus_leitura;


--
-- TOC entry 6928 (class 0 OID 0)
-- Dependencies: 192
-- Name: AcaoStatus_AcaoStatusId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "AcaoStatus_AcaoStatusId_seq" TO esus_leitura;


--
-- TOC entry 6929 (class 0 OID 0)
-- Dependencies: 193
-- Name: AcaoUsuario; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "AcaoUsuario" TO esus_leitura;


--
-- TOC entry 6931 (class 0 OID 0)
-- Dependencies: 194
-- Name: AcaoUsuario_AcaoUsuarioId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "AcaoUsuario_AcaoUsuarioId_seq" TO esus_leitura;


--
-- TOC entry 6933 (class 0 OID 0)
-- Dependencies: 195
-- Name: Acao_AcaoId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "Acao_AcaoId_seq" TO esus_leitura;


--
-- TOC entry 6934 (class 0 OID 0)
-- Dependencies: 196
-- Name: Arquivo; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "Arquivo" TO esus_leitura;


--
-- TOC entry 6935 (class 0 OID 0)
-- Dependencies: 197
-- Name: ArquivoFinanceiro; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "ArquivoFinanceiro" TO esus_leitura;


--
-- TOC entry 6937 (class 0 OID 0)
-- Dependencies: 198
-- Name: ArquivoFinanceiro_Id_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "ArquivoFinanceiro_Id_seq" TO esus_leitura;


--
-- TOC entry 6939 (class 0 OID 0)
-- Dependencies: 199
-- Name: Arquivo_ArquivoId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "Arquivo_ArquivoId_seq" TO esus_leitura;


--
-- TOC entry 6940 (class 0 OID 0)
-- Dependencies: 200
-- Name: CicloGestacao; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "CicloGestacao" TO esus_leitura;


--
-- TOC entry 6941 (class 0 OID 0)
-- Dependencies: 201
-- Name: CicloGestacaoCategoria; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "CicloGestacaoCategoria" TO esus_leitura;


--
-- TOC entry 6943 (class 0 OID 0)
-- Dependencies: 202
-- Name: CicloGestacaoCategoria_CicloGestacaoCategoriaId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "CicloGestacaoCategoria_CicloGestacaoCategoriaId_seq" TO esus_leitura;


--
-- TOC entry 6944 (class 0 OID 0)
-- Dependencies: 203
-- Name: CicloGestacaoConfig; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "CicloGestacaoConfig" TO esus_leitura;


--
-- TOC entry 6946 (class 0 OID 0)
-- Dependencies: 204
-- Name: CicloGestacaoConfig_CicloGestacaoConfigId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "CicloGestacaoConfig_CicloGestacaoConfigId_seq" TO esus_leitura;


--
-- TOC entry 6947 (class 0 OID 0)
-- Dependencies: 205
-- Name: CicloGestacaoPlano; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "CicloGestacaoPlano" TO esus_leitura;


--
-- TOC entry 6948 (class 0 OID 0)
-- Dependencies: 206
-- Name: CicloGestacaoPlanoStatus; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "CicloGestacaoPlanoStatus" TO esus_leitura;


--
-- TOC entry 6950 (class 0 OID 0)
-- Dependencies: 207
-- Name: CicloGestacaoPlanoStatus_CicloGestacaoPlanoStatusId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "CicloGestacaoPlanoStatus_CicloGestacaoPlanoStatusId_seq" TO esus_leitura;


--
-- TOC entry 6952 (class 0 OID 0)
-- Dependencies: 208
-- Name: CicloGestacaoPlano_CicloGestacaoPlanoId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "CicloGestacaoPlano_CicloGestacaoPlanoId_seq" TO esus_leitura;


--
-- TOC entry 6953 (class 0 OID 0)
-- Dependencies: 209
-- Name: CicloGestacaoStatus; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "CicloGestacaoStatus" TO esus_leitura;


--
-- TOC entry 6955 (class 0 OID 0)
-- Dependencies: 210
-- Name: CicloGestacaoStatus_CicloGestacaoStatusId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "CicloGestacaoStatus_CicloGestacaoStatusId_seq" TO esus_leitura;


--
-- TOC entry 6956 (class 0 OID 0)
-- Dependencies: 211
-- Name: CicloGestacaoTema; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "CicloGestacaoTema" TO esus_leitura;


--
-- TOC entry 6958 (class 0 OID 0)
-- Dependencies: 212
-- Name: CicloGestacaoTema_CicloGestacaoTemaId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "CicloGestacaoTema_CicloGestacaoTemaId_seq" TO esus_leitura;


--
-- TOC entry 6960 (class 0 OID 0)
-- Dependencies: 213
-- Name: CicloGestacao_CicloGestacaoId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "CicloGestacao_CicloGestacaoId_seq" TO esus_leitura;


--
-- TOC entry 6961 (class 0 OID 0)
-- Dependencies: 214
-- Name: Municipio; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "Municipio" TO esus_leitura;


--
-- TOC entry 6963 (class 0 OID 0)
-- Dependencies: 215
-- Name: Municipio_MunicipioId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "Municipio_MunicipioId_seq" TO esus_leitura;


--
-- TOC entry 6964 (class 0 OID 0)
-- Dependencies: 216
-- Name: Notificacao; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "Notificacao" TO esus_leitura;


--
-- TOC entry 6966 (class 0 OID 0)
-- Dependencies: 217
-- Name: Notificacao_NotificacaoId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "Notificacao_NotificacaoId_seq" TO esus_leitura;


--
-- TOC entry 6967 (class 0 OID 0)
-- Dependencies: 218
-- Name: Paciente; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "Paciente" TO esus_leitura;


--
-- TOC entry 6969 (class 0 OID 0)
-- Dependencies: 219
-- Name: Paciente_PacienteId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "Paciente_PacienteId_seq" TO esus_leitura;


--
-- TOC entry 6970 (class 0 OID 0)
-- Dependencies: 220
-- Name: Perfil; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "Perfil" TO esus_leitura;


--
-- TOC entry 6972 (class 0 OID 0)
-- Dependencies: 221
-- Name: Perfil_PerfilId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "Perfil_PerfilId_seq" TO esus_leitura;


--
-- TOC entry 6973 (class 0 OID 0)
-- Dependencies: 222
-- Name: Teste; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "Teste" TO esus_leitura;


--
-- TOC entry 6974 (class 0 OID 0)
-- Dependencies: 223
-- Name: Usuario; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "Usuario" TO esus_leitura;


--
-- TOC entry 6975 (class 0 OID 0)
-- Dependencies: 224
-- Name: UsuarioMunicipio; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE "UsuarioMunicipio" TO esus_leitura;


--
-- TOC entry 6977 (class 0 OID 0)
-- Dependencies: 225
-- Name: UsuarioMunicipio_UsuarioMunicipioId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "UsuarioMunicipio_UsuarioMunicipioId_seq" TO esus_leitura;


--
-- TOC entry 6979 (class 0 OID 0)
-- Dependencies: 226
-- Name: Usuario_UsuarioId_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE "Usuario_UsuarioId_seq" TO esus_leitura;


--
-- TOC entry 6980 (class 0 OID 0)
-- Dependencies: 227
-- Name: appsettings; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE appsettings TO esus_leitura;


--
-- TOC entry 6982 (class 0 OID 0)
-- Dependencies: 228
-- Name: appsettings_appsettingsid_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE appsettings_appsettingsid_seq TO esus_leitura;


-- Completed on 2024-05-24 20:19:01

--
-- PostgreSQL database dump complete
--

