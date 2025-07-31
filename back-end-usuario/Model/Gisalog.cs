using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Gisalog
{
    public int Eventoid { get; set; }

    public string Tipoevento { get; set; } = null!;

    public int Usuarioid { get; set; }

    public string Nomeevento { get; set; } = null!;

    public string? Descricaoevento { get; set; }

    public DateTime Dataevento { get; set; }
}
