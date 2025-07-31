using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbFatAtendimentoIndividual
{
    public long CoSeqFatAtdInd { get; set; }

    public long? CoDimMunicipio { get; set; }

    public long? CoDimTipoFicha { get; set; }

    public long? CoDimProfissional1 { get; set; }

    public long? CoDimProfissional2 { get; set; }

    public long? CoDimCbo1 { get; set; }

    public long? CoDimCbo2 { get; set; }

    public long? CoDimUnidadeSaude1 { get; set; }

    public long? CoDimUnidadeSaude2 { get; set; }

    public long? CoDimEquipe1 { get; set; }

    public long? CoDimEquipe2 { get; set; }

    public long? CoDimTempo { get; set; }

    public long? CoDimRacionalidadeSaude { get; set; }

    public string? NuUuidFicha { get; set; }

    public int? NuAtendimento { get; set; }

    public string? NuCns { get; set; }

    public DateOnly? DtNascimento { get; set; }

    public long? CoDimFaixaEtaria { get; set; }

    public long? CoDimSexo { get; set; }

    public long? CoDimTurno { get; set; }

    public long? CoDimLocalAtendimento { get; set; }

    public long? CoDimTipoAtendimento { get; set; }

    public double? NuPeso { get; set; }

    public double? NuAltura { get; set; }

    public double? NuPerimetroCefalico { get; set; }

    public int? StVacinacaoEmDia { get; set; }

    public long? CoDimAleitamento { get; set; }

    public long? CoDimTempoDum { get; set; }

    public int? StGravidezPlanejada { get; set; }

    public int? NuIdadeGestacionalSemanas { get; set; }

    public int? NuGestasPrevias { get; set; }

    public int? NuPartos { get; set; }

    public long? CoDimModalidadeAd { get; set; }

    public int? StFicouEmObservacao { get; set; }

    /// <summary>
    /// Campo legado que indica se a Avaliação/Diagnóstico foi realizada por uma equipe Nasf durante o atendimento, substituído pelo ST_EMULTI_AVAL_DIAGNOSTICO a partir da versão 5.5.0 do LEDI.
    /// </summary>
    public int? StNasfAvaliacaoDiagnostico { get; set; }

    /// <summary>
    /// Campo legado que indica se Procedimentos Clínicos/Terapêuticos foram realizados por uma equipe Nasf durante o atendimento, substituído pelo ST_EMULTI_PROCE_CLIN_TERAP a partir da versão 5.5.0 do LEDI.
    /// </summary>
    public int? StNasfProceClinTerapeutico { get; set; }

    /// <summary>
    /// Campo legado que indica se a Prescrição Terapêutica foi realizada por uma equipe Nasf durante o atendimento, substituído pelo ST_EMULTI_PRESC_TERAPEUTICA a partir da versão 5.5.0 do LEDI.
    /// </summary>
    public int? StNasfPrescricaoTerapeutica { get; set; }

    public int? StCondutaConsultaAgendada { get; set; }

    public int? StCondutaCuiddContiProgram { get; set; }

    public int? StCondutaAgendamentoGrupos { get; set; }

    public int? StCondutaAgendamentoNasf { get; set; }

    public int? StCondutaAltaEpisodio { get; set; }

    public int? StEncaminhamentoInternoDia { get; set; }

    public int? StEncaminhamentoServSpecial { get; set; }

    public int? StEncaminhamentoCaps { get; set; }

    public int? StEncaminhamentoInternHospi { get; set; }

    public int? StEncaminhamentoUrgencia { get; set; }

    public int? StEncaminhamentoServicoAd { get; set; }

    public int? StEncaminhamentoIntersetoria { get; set; }

    public string? DsFiltroCids { get; set; }

    public string? DsFiltroCiaps { get; set; }

    public string? DsFiltroProcedAvaliados { get; set; }

    public string? DsFiltroProcedSolicitados { get; set; }

    public string? NuProntuario { get; set; }

    public string? NuUuidDadoTransp { get; set; }

    public long? CoDimTipoOrigemDadoTransp { get; set; }

    public long? CoDimCdsTipoOrigem { get; set; }

    public long? CoFatCidadaoPec { get; set; }

    public DateTime? DtInicialAtendimento { get; set; }

    public DateTime? DtFinalAtendimento { get; set; }

    public string? NuCpfCidadao { get; set; }

    public int StCondutaManterObservacao { get; set; }

    public long CoDimProfFinalizadorObs { get; set; }

    public long CoDimCboFinalizadorObs { get; set; }

    public long CoDimUbsFinalizadorObs { get; set; }

    public long CoDimEquipeFinalizadorObs { get; set; }

    public long CoDimTpParticipCidadao { get; set; }

    public long CoDimTpParticipProfConv { get; set; }

    /// <summary>
    /// Indica se o atendimento foi agendado para eMulti.
    /// </summary>
    public int? StCondutaAgendamentoEmulti { get; set; }

    /// <summary>
    /// Indica se o tipo de atendimento foi preenchido em uma versão que continha a antiga estrutura Núcleo de Apoio a Saúde da Família (NASF).
    /// </summary>
    public int StNasf { get; set; }

    public virtual TbDimAleitamento? CoDimAleitamentoNavigation { get; set; }

    public virtual TbDimCbo? CoDimCbo1Navigation { get; set; }

    public virtual TbDimCbo? CoDimCbo2Navigation { get; set; }

    public virtual TbDimCbo CoDimCboFinalizadorObsNavigation { get; set; } = null!;

    public virtual TbDimTipoOrigem? CoDimCdsTipoOrigemNavigation { get; set; }

    public virtual TbDimEquipe? CoDimEquipe1Navigation { get; set; }

    public virtual TbDimEquipe? CoDimEquipe2Navigation { get; set; }

    public virtual TbDimEquipe CoDimEquipeFinalizadorObsNavigation { get; set; } = null!;

    public virtual TbDimFaixaEtaria? CoDimFaixaEtariaNavigation { get; set; }

    public virtual TbDimLocalAtendimento? CoDimLocalAtendimentoNavigation { get; set; }

    public virtual TbDimModalidadeAd? CoDimModalidadeAdNavigation { get; set; }

    public virtual TbDimMunicipio? CoDimMunicipioNavigation { get; set; }

    public virtual TbDimProfissional CoDimProfFinalizadorObsNavigation { get; set; } = null!;

    public virtual TbDimProfissional? CoDimProfissional1Navigation { get; set; }

    public virtual TbDimProfissional? CoDimProfissional2Navigation { get; set; }

    public virtual TbDimRacionalidadeSaude? CoDimRacionalidadeSaudeNavigation { get; set; }

    public virtual TbDimSexo? CoDimSexoNavigation { get; set; }

    public virtual TbDimTempo? CoDimTempoDumNavigation { get; set; }

    public virtual TbDimTempo? CoDimTempoNavigation { get; set; }

    public virtual TbDimTipoAtendimento? CoDimTipoAtendimentoNavigation { get; set; }

    public virtual TbDimTipoFicha? CoDimTipoFichaNavigation { get; set; }

    public virtual TbDimTipoOrigemDadoTransp? CoDimTipoOrigemDadoTranspNavigation { get; set; }

    public virtual TbDimTurno? CoDimTurnoNavigation { get; set; }

    public virtual TbDimUnidadeSaude CoDimUbsFinalizadorObsNavigation { get; set; } = null!;

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaude1Navigation { get; set; }

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaude2Navigation { get; set; }

    public virtual TbFatCidadaoPec? CoFatCidadaoPecNavigation { get; set; }
}
