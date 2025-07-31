using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimModalidadeAd
{
    public long CoSeqDimModalidadeAd { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsModalidadeAd { get; set; }

    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividual { get; } = new List<TbFatAtendimentoIndividual>();
}
