using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimTipoCondicaoPeso
{
    public long CoSeqDimTipoCondicaoPeso { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsDimTipoCondicaoPeso { get; set; }

    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();
}
