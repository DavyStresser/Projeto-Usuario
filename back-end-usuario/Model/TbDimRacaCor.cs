using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimRacaCor
{
    public long CoSeqDimRacaCor { get; set; }

    public string? NuIdentificador { get; set; }

    public string? NuMs { get; set; }

    public string? DsRacaCor { get; set; }

    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();
}
