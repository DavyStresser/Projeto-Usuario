using System;
using System.Collections.Generic;

namespace GISA.Model;

/// <summary>
/// Armazena as dimensões usadas pelo DW da TB_CLASSIFICACAO_RISCO
/// </summary>
public partial class TbDimClassificacaoRiscEnc
{
    /// <summary>
    /// Sequence da tabela TB_DIM_CLASSIFICAO_RISCO
    /// </summary>
    public long CoSeqDimClassificRiscEnc { get; set; }

    public string? NuIdentificador { get; set; }

    public long? CoClassificacaoRisco { get; set; }

    /// <summary>
    /// Nome da forma farmaceutica
    /// </summary>
    public string? NoClassificacaoRisco { get; set; }

    public string? NoClassificacaoRiscoFiltro { get; set; }

    /// <summary>
    /// Indica a ordem que o registro irá aparece nas listagens
    /// </summary>
    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentos { get; } = new List<TbFatAtdIndEncaminhamentos>();
}
