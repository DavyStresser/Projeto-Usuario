using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimNacionalidade
{
    public long CoSeqDimNacionalidade { get; set; }

    public string? CoNacionalidade { get; set; }

    public string? NoIdentificador { get; set; }

    public string? DsNacionalidade { get; set; }

    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();
}
