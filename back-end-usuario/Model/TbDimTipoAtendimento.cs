using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimTipoAtendimento
{
    public long CoSeqDimTipoAtendimento { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsTipoAtendimento { get; set; }

    public long? CoDimTipoAtendimentoPai { get; set; }

    public int? CoOrdem { get; set; }

    public string? DsFiltro { get; set; }

    public virtual TbDimTipoAtendimento? CoDimTipoAtendimentoPaiNavigation { get; set; }

    public virtual ICollection<TbDimTipoAtendimento> InverseCoDimTipoAtendimentoPaiNavigation { get; } = new List<TbDimTipoAtendimento>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividual { get; } = new List<TbFatAtendimentoIndividual>();
}
