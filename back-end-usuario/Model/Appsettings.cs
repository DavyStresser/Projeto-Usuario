using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Appsettings
{
    public int Appsettingsid { get; set; }

    public int Tipo { get; set; }

    public string Descricao { get; set; } = null!;
}
