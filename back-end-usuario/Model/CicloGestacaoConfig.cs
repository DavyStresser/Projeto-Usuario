using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class CicloGestacaoConfig
{
    public int CicloGestacaoConfigId { get; set; }

    public int CicloGestacaoTemaId { get; set; }

    public int Inicio { get; set; }

    public int Fim { get; set; }

    public int Trimestre { get; set; }

    public int Puerperio { get; set; }

    public virtual CicloGestacaoTema CicloGestacaoTema { get; set; } = null!;
}
