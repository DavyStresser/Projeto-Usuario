using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Unidadeequipe
{
    public int Id { get; set; }

    public int Usuarioid { get; set; }

    public string Equipe { get; set; } = null!;

    public string Unidade { get; set; } = null!;

    public string? Cbo { get; set; }

    public string? Microarea { get; set; }

    public bool Deletado { get; set; }
}
