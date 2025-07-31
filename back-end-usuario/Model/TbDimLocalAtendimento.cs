using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimLocalAtendimento
{
    public long CoSeqDimLocalAtendimento { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsLocalAtendimento { get; set; }

    public int? CoOrdem { get; set; }

    public string? DsFiltro { get; set; }

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividual { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatProcedAtend> TbFatProcedAtend { get; } = new List<TbFatProcedAtend>();
}
