using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Sqlworker
{
    public int Id { get; set; }

    public int Ordem { get; set; }

    public int Periododeexec { get; set; }

    public string Comandosql { get; set; } = null!;
}
