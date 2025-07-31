using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimCid
{
    public long CoSeqDimCid { get; set; }

    public string? NuCid { get; set; }

    public string? NoCid { get; set; }

    public int? StAtivo { get; set; }

    public int? StRegistroValido { get; set; }

    public string? DsFiltro { get; set; }

    public virtual ICollection<TbFatAtdIndProblemas> TbFatAtdIndProblemas { get; } = new List<TbFatAtdIndProblemas>();
}
