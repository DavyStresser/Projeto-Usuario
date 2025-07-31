using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class CicloGestacaoCategoria
{
    public int CicloGestacaoCategoriaId { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<CicloGestacaoTema> CicloGestacaoTema { get; } = new List<CicloGestacaoTema>();
}
