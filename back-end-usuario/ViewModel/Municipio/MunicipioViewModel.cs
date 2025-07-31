using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class MunicipioViewModel
{
    public int MunicipioId { get; set; }

    public string Nome { get; set; } = null!;

    public string Codigo { get; set; } = null!;
}
