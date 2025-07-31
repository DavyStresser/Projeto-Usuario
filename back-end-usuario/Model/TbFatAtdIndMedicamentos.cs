using System;
using System.Collections.Generic;

namespace GISA.Model;

/// <summary>
/// Armazena os fatos relacionados às receitas de um atendimento
/// </summary>
public partial class TbFatAtdIndMedicamentos
{
    /// <summary>
    /// Sequence da tabela TB_FAT_ATD_IND_MEDICAMENTOS
    /// </summary>
    public long CoSeqFatAtdIndMedicam { get; set; }

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

    public long? CoDimCatmat { get; set; }

    /// <summary>
    /// Unidade de medida da quantidade da dose
    /// </summary>
    public long? CoDimDoseFrequenciaMedida { get; set; }

    /// <summary>
    /// Unidade de medida da duração do tratamento
    /// </summary>
    public long? CoDimDuracaoTratamentoMed { get; set; }

    /// <summary>
    /// Tipo da frequência usada na dose
    /// </summary>
    public long? CoDimDoseFrequencia { get; set; }

    /// <summary>
    /// Tipo da via de administração do medicamento
    /// </summary>
    public long? CoDimViaAdministracao { get; set; }

    /// <summary>
    /// Descrição da dose
    /// </summary>
    public string? DsDose { get; set; }

    /// <summary>
    /// Indicação se a dose é unica ou não
    /// </summary>
    public int? StDoseUnica { get; set; }

    /// <summary>
    /// Indicação se o medicamento é de uso contínuo ou não
    /// </summary>
    public int? StUsoContinuo { get; set; }

    /// <summary>
    /// Descrição da frequência da dose
    /// </summary>
    public string? DsDoseFrequencia { get; set; }

    /// <summary>
    /// Quantidade da frequencia da dose
    /// </summary>
    public int? QtDoseFrequencia { get; set; }

    /// <summary>
    /// Quantidade do tratamento
    /// </summary>
    public int? QtDuracaoTratamento { get; set; }

    /// <summary>
    /// Quantidade receitada
    /// </summary>
    public int? QtReceitada { get; set; }

    /// <summary>
    /// Data de início do tratamento
    /// </summary>
    public DateOnly? DtInicioTratamento { get; set; }

    public virtual TbDimCatmat? CoDimCatmatNavigation { get; set; }

    public virtual TbDimCbo? CoDimCbo1Navigation { get; set; }

    public virtual TbDimCbo? CoDimCbo2Navigation { get; set; }

    public virtual TbDimTipoOrigem? CoDimCdsTipoOrigemNavigation { get; set; }

    public virtual TbDimDoseFrequenciaMedida? CoDimDoseFrequenciaMedidaNavigation { get; set; }

    public virtual TbDimDoseFrequencia? CoDimDoseFrequenciaNavigation { get; set; }

    public virtual TbDimDuracaoTratamentoMed? CoDimDuracaoTratamentoMedNavigation { get; set; }

    public virtual TbDimEquipe? CoDimEquipe1Navigation { get; set; }

    public virtual TbDimEquipe? CoDimEquipe2Navigation { get; set; }

    public virtual TbDimMunicipio? CoDimMunicipioNavigation { get; set; }

    public virtual TbDimProfissional? CoDimProfissional1Navigation { get; set; }

    public virtual TbDimProfissional? CoDimProfissional2Navigation { get; set; }

    public virtual TbDimTempo? CoDimTempoNavigation { get; set; }

    public virtual TbDimTipoFicha? CoDimTipoFichaNavigation { get; set; }

    public virtual TbDimTipoOrigemDadoTransp? CoDimTipoOrigemDadoTranspNavigation { get; set; }

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaude1Navigation { get; set; }

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaude2Navigation { get; set; }

    public virtual TbDimViaAdministracao? CoDimViaAdministracaoNavigation { get; set; }

    public virtual TbFatCidadaoPec? CoFatCidadaoPecNavigation { get; set; }
}
