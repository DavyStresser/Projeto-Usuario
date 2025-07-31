using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class CicloGestacaoPlanoStatus
{
    public int CicloGestacaoPlanoStatusId { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<CicloGestacaoPlano> CicloGestacaoPlano { get; } = new List<CicloGestacaoPlano>();
}
