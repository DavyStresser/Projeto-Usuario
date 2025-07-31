using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class CicloGestacaoTema
{
    public int CicloGestacaoTemaId { get; set; }

    public string Nome { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public int CicloGestacaoCategoriaId { get; set; }

    public virtual ICollection<CicloGestacao> CicloGestacao { get; } = new List<CicloGestacao>();

    public virtual CicloGestacaoCategoria CicloGestacaoCategoria { get; set; } = null!;

    public virtual ICollection<CicloGestacaoConfig> CicloGestacaoConfig { get; } = new List<CicloGestacaoConfig>();
}
