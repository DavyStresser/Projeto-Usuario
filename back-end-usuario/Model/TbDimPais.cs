using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimPais
{
    public long CoSeqDimPais { get; set; }

    public string? NoPais { get; set; }

    public string? CoCadsus { get; set; }

    public int? StRegistroValido { get; set; }

    public string? DsFiltro { get; set; }

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();
}
