using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimRacionalidadeSaude
{
    public long CoSeqDimRacionalidadeSaude { get; set; }

    public string? NuIdentificador { get; set; }

    public string? NoRacionalidadeSaude { get; set; }

    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividual { get; } = new List<TbFatAtendimentoIndividual>();
}
