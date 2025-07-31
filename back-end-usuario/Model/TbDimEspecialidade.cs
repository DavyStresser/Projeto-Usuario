using System;
using System.Collections.Generic;

namespace GISA.Model;

/// <summary>
/// Armazena as dimensões usadas pelo DW da TB_ESPECIALIDADE_SISREG
/// </summary>
public partial class TbDimEspecialidade
{
    /// <summary>
    /// Sequence da tabela TB_DIM_ESPECIALIDADE
    /// </summary>
    public long CoSeqDimEspecialidade { get; set; }

    public string? DsEspecialidade { get; set; }

    public string? DsEspecialidadeFiltro { get; set; }

    public string? CoEspecialidade { get; set; }

    /// <summary>
    /// Indica se o registro é valido ou não
    /// </summary>
    public int? StRegistroValido { get; set; }

    public virtual ICollection<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentos { get; } = new List<TbFatAtdIndEncaminhamentos>();
}
