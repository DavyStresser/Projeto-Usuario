using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimCiap
{
    public long CoSeqDimCiap { get; set; }

    public string? NuCiap { get; set; }

    public string? NoCiap { get; set; }

    public int? StRegistroValido { get; set; }

    public string? DsFiltro { get; set; }

    public virtual ICollection<TbFatAtdIndProblemas> TbFatAtdIndProblemas { get; } = new List<TbFatAtdIndProblemas>();
}
