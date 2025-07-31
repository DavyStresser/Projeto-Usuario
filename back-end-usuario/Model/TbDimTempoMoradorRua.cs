using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimTempoMoradorRua
{
    public long CoSeqDimTempoMoradorRua { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsDimTempoMoradorRua { get; set; }

    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();
}
