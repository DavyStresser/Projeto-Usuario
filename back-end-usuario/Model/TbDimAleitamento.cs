using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimAleitamento
{
    public long CoSeqDimAleitamento { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsAleitamento { get; set; }

    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividual { get; } = new List<TbFatAtendimentoIndividual>();
}
