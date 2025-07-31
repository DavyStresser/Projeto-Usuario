using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimTurno
{
    public long CoSeqDimTurno { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsTurno { get; set; }

    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividual { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatProcedAtend> TbFatProcedAtend { get; } = new List<TbFatProcedAtend>();
}
