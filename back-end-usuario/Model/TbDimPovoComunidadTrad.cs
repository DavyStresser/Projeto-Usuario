using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimPovoComunidadTrad
{
    /// <summary>
    /// Código sequencial da tabela.
    /// </summary>
    public long CoSeqDimPovoComunidadTrad { get; set; }

    /// <summary>
    /// Número identificador
    /// </summary>
    public string? NuIdentificador { get; set; }

    /// <summary>
    /// Nome do povo ou comunidade tradicional
    /// </summary>
    public string? DsPovoComunidadeTradicional { get; set; }

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();
}
