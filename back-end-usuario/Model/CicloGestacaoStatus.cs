using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class CicloGestacaoStatus
{
    public int CicloGestacaoStatusId { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<CicloGestacao> CicloGestacao { get; } = new List<CicloGestacao>();
}
