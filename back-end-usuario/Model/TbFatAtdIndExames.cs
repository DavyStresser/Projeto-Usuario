using System;
using System.Collections.Generic;

namespace GISA.Model;

/// <summary>
/// Armazena os fatos relacionados aos exames específicos de um atendimento
/// </summary>
public partial class TbFatAtdIndExames
{
    /// <summary>
    /// Sequence da tabela TB_FAT_ATD_IND_EXAMES
    /// </summary>
    public long CoSeqFatAtdIndExames { get; set; }

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
    /// Código do exame da tabela TB_DIM_PROCEDIMENTO
    /// </summary>
    public long? CoDimProcedimento { get; set; }

    /// <summary>
    /// Data em que o exame foi solicitado
    /// </summary>
    public DateOnly? DtSolicitacao { get; set; }

    /// <summary>
    /// Data que o exame foi realizado
    /// </summary>
    public DateOnly? DtRealizacao { get; set; }

    /// <summary>
    /// Data que o resultado foi gerado
    /// </summary>
    public DateOnly? DtResultado { get; set; }

    /// <summary>
    /// Campo para armazenar o valor do resultado inteiro ou fracionado, caso código do exame for igual a 0211070149, ABEX020, 0211070270, 0205020178, 0206010079, 0207010064, ABPG013, ABEX022, o valor deste campo faz referência a tabela TB_DIM_ZIKA_TIPO_EXAME.CO_SEQ_DIM_ZIKA_TIPO_EXAME
    /// </summary>
    public double? NuResultadoValor { get; set; }

    /// <summary>
    /// Campo para armazerar o resultado de dias para exames que necessitarem
    /// </summary>
    public int? NuResultadoDia { get; set; }

    /// <summary>
    /// Campo para armazerar o resultado de semanas para exames que necessitarem
    /// </summary>
    public int? NuResultadoSemana { get; set; }

    /// <summary>
    /// Campo para armazerar uma data para os exames que necessitarem
    /// </summary>
    public DateOnly? DtResultadoData { get; set; }

    public virtual TbDimCbo? CoDimCbo1Navigation { get; set; }

    public virtual TbDimCbo? CoDimCbo2Navigation { get; set; }

    public virtual TbDimTipoOrigem? CoDimCdsTipoOrigemNavigation { get; set; }

    public virtual TbDimEquipe? CoDimEquipe1Navigation { get; set; }

    public virtual TbDimEquipe? CoDimEquipe2Navigation { get; set; }

    public virtual TbDimMunicipio? CoDimMunicipioNavigation { get; set; }

    public virtual TbDimProcedimento? CoDimProcedimentoNavigation { get; set; }

    public virtual TbDimProfissional? CoDimProfissional1Navigation { get; set; }

    public virtual TbDimProfissional? CoDimProfissional2Navigation { get; set; }

    public virtual TbDimTempo? CoDimTempoNavigation { get; set; }

    public virtual TbDimTipoFicha? CoDimTipoFichaNavigation { get; set; }

    public virtual TbDimTipoOrigemDadoTransp? CoDimTipoOrigemDadoTranspNavigation { get; set; }

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaude1Navigation { get; set; }

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaude2Navigation { get; set; }

    public virtual TbFatCidadaoPec? CoFatCidadaoPecNavigation { get; set; }
}
