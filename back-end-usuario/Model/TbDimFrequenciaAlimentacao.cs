using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimFrequenciaAlimentacao
{
    public long CoSeqDimFrequenciaAliment { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsDimFrequenciaAlimentacao { get; set; }

    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();
}
