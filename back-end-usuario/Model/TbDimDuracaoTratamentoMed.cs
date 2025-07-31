using System;
using System.Collections.Generic;

namespace GISA.Model;

/// <summary>
/// Armazena as dimensões usadas pelo DW de medidas da duração de tratamento
/// </summary>
public partial class TbDimDuracaoTratamentoMed
{
    /// <summary>
    /// Sequence da tabela TB_DIM_DURACAO_TRATAMENTO_MED
    /// </summary>
    public long CoSeqDimDuracaoTratMed { get; set; }

    public string? NuIdentificador { get; set; }

    public long? NuDuracaoTratamentoMed { get; set; }

    /// <summary>
    /// Nome da forma farmaceutica
    /// </summary>
    public string? NoDuracaoTratamentoMed { get; set; }

    public string? NoDuracaoTratamentoMedFilt { get; set; }

    /// <summary>
    /// Indica a ordem que o registro irá aparece nas listagens
    /// </summary>
    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentos { get; } = new List<TbFatAtdIndMedicamentos>();
}
