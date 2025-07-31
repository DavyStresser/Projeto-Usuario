using System;
using System.Collections.Generic;

namespace GISA.Model;

/// <summary>
/// Armazena os fatos relacionados aos encaminhamentos dos atendimento
/// </summary>
public partial class TbFatAtdIndEncaminhamentos
{
    /// <summary>
    /// Sequence da tabela TB_FAT_ATD_IND_ENCAMINHAMENTOS
    /// </summary>
    public long CoSeqFatAtdIndEncaminham { get; set; }

    public long? CoFatAtdInd { get; set; }

    public long? CoDimTipoFicha { get; set; }

    public long? CoDimMunicipio { get; set; }

    public long? CoDimProfissional1 { get; set; }

    public long? CoDimProfissional2 { get; set; }

    public long? CoDimCbo1 { get; set; }

    public long? CoDimCbo2 { get; set; }

    public long? CoDimUnidadeSaude1 { get; set; }

    public long? CoDimUnidadeSaude2 { get; set; }

    public long? CoDimEquipe1 { get; set; }

    public long? CoDimEquipe2 { get; set; }

    public long? CoDimTempo { get; set; }

    public string? NuUuidFicha { get; set; }

    public int? NuAtendimento { get; set; }

    public string? NuCnsCidadao { get; set; }

    public string? NuUuidDadoTransp { get; set; }

    public long? CoDimTipoOrigemDadoTransp { get; set; }

    public long? CoDimCdsTipoOrigem { get; set; }

    public long? CoFatCidadaoPec { get; set; }

    public string? NuCpfCidadao { get; set; }

    /// <summary>
    /// Código da especialidade do encaminhamento
    /// </summary>
    public long? CoDimEspecialidade { get; set; }

    /// <summary>
    /// Código CID10 da hipótese diagnóstica
    /// </summary>
    public long? CoDimCid10 { get; set; }

    /// <summary>
    /// Tipo da classificação de risco
    /// </summary>
    public long? CoDimClassificacaoRiscEnc { get; set; }

    /// <summary>
    /// Código Ciap2 da hipótese diagnóstica
    /// </summary>
    public long? CoDimCiap2 { get; set; }

    public virtual TbDimCbo? CoDimCbo1Navigation { get; set; }

    public virtual TbDimCbo? CoDimCbo2Navigation { get; set; }

    public virtual TbDimTipoOrigem? CoDimCdsTipoOrigemNavigation { get; set; }

    public virtual TbDimClassificacaoRiscEnc? CoDimClassificacaoRiscEncNavigation { get; set; }

    public virtual TbDimEquipe? CoDimEquipe1Navigation { get; set; }

    public virtual TbDimEquipe? CoDimEquipe2Navigation { get; set; }

    public virtual TbDimEspecialidade? CoDimEspecialidadeNavigation { get; set; }

    public virtual TbDimMunicipio? CoDimMunicipioNavigation { get; set; }

    public virtual TbDimProfissional? CoDimProfissional1Navigation { get; set; }

    public virtual TbDimProfissional? CoDimProfissional2Navigation { get; set; }

    public virtual TbDimTempo? CoDimTempoNavigation { get; set; }

    public virtual TbDimTipoFicha? CoDimTipoFichaNavigation { get; set; }

    public virtual TbDimTipoOrigemDadoTransp? CoDimTipoOrigemDadoTranspNavigation { get; set; }

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaude1Navigation { get; set; }

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaude2Navigation { get; set; }

    public virtual TbFatCidadaoPec? CoFatCidadaoPecNavigation { get; set; }
}
