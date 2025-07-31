using System;
using System.Collections.Generic;

namespace GISA.Model;

/// <summary>
/// Armazena as dimensões usadas pelo DW da TB_VIA_ADM_VACINA
/// </summary>
public partial class TbDimViaAdministracao
{
    /// <summary>
    /// Sequence da tabela TB_DIM_VIA_ADMINISTRACAO
    /// </summary>
    public long CoSeqDimViaAdministracao { get; set; }

    public string? NuIdentificador { get; set; }

    /// <summary>
    /// Nome da forma farmaceutica
    /// </summary>
    public string? NoViaAdministracao { get; set; }

    public string? NoViaAdministracaoFiltro { get; set; }

    /// <summary>
    /// Indica a ordem que o registro irá aparece nas listagens
    /// </summary>
    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentos { get; } = new List<TbFatAtdIndMedicamentos>();
}
