using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimEtnia
{
    public long CoSeqDimEtnia { get; set; }

    public string? NuIdentificador { get; set; }

    public string? NoEtnia { get; set; }

    public string? DsFiltro { get; set; }

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();
}
