using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimTipoParentesco
{
    public long CoSeqDimTipoParentesco { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsTipoParentesco { get; set; }

    public int? CoOrdem { get; set; }

    public string? DsFiltro { get; set; }

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();
}
