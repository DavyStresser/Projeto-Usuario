using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimSexo
{
    public long CoSeqDimSexo { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsSexo { get; set; }

    public string? SgSexo { get; set; }

    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividual { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatCidadaoPec> TbFatCidadaoPec { get; } = new List<TbFatCidadaoPec>();

    public virtual ICollection<TbFatProcedAtend> TbFatProcedAtend { get; } = new List<TbFatProcedAtend>();
}
