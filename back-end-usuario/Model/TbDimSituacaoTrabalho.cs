using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimSituacaoTrabalho
{
    public long CoSeqDimSituacaoTrabalho { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsDimSituacaoTrabalho { get; set; }

    public int? CoOrdem { get; set; }

    public string? DsFiltro { get; set; }

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();
}
