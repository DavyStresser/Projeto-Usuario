using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimFaixaEtaria
{
    public long CoSeqDimFaixaEtaria { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsFaixaEtaria { get; set; }

    public string? DsFiltro { get; set; }

    public int? NuFaixaInicialAnos { get; set; }

    public int? NuFaixaFinalAnos { get; set; }

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividual { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatProcedAtend> TbFatProcedAtend { get; } = new List<TbFatProcedAtend>();
}
