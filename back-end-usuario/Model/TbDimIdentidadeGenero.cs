using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimIdentidadeGenero
{
    public long CoSeqDimIdentidadeGenero { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsIdentidadeGenero { get; set; }

    public int? CoOrdem { get; set; }

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatCidadaoPec> TbFatCidadaoPec { get; } = new List<TbFatCidadaoPec>();
}
