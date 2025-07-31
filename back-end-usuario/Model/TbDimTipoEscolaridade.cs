using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimTipoEscolaridade
{
    public long CoSeqDimTipoEscolaridade { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsDimTipoEscolaridade { get; set; }

    public int? CoOrdem { get; set; }

    public string? DsFiltro { get; set; }

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();
}
