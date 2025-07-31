using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimTipoSaidaCadastro
{
    public long CoSeqDimTipoSaidaCadastro { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsDimTipoSaidaCadastro { get; set; }

    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();
}
