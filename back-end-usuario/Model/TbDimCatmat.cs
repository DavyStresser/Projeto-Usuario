using System;
using System.Collections.Generic;

namespace GISA.Model;

/// <summary>
/// Armazena as dimensões usadas pelo DW da TB_CATMAT
/// </summary>
public partial class TbDimCatmat
{
    /// <summary>
    /// Sequence da tabela TB_DIM_CATMAT
    /// </summary>
    public long CoSeqDimCatmat { get; set; }

    public string? CoCatmat { get; set; }

    /// <summary>
    /// Nome do princípio ativo
    /// </summary>
    public string? NoPrincipioAtivo { get; set; }

    /// <summary>
    /// Descrição da concentração que o medicamento é distribuido
    /// </summary>
    public string? DsConcentracao { get; set; }

    /// <summary>
    /// Descrição da forma como o medicamento é fornecido
    /// </summary>
    public string? DsUnidadeFornecimento { get; set; }

    public long? CoDimFormaFarmaceutica { get; set; }

    /// <summary>
    /// Indica se o registro é valido ou não
    /// </summary>
    public int? StRegistroValido { get; set; }

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentos { get; } = new List<TbFatAtdIndMedicamentos>();
}
