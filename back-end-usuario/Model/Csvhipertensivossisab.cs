using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Csvhipertensivossisab
{
    public int Id { get; set; }

    public int? Nuano { get; set; }

    public int? Nuquadrimestre { get; set; }

    public string? Nuequipe { get; set; }

    public string? Nonome { get; set; }

    public string? Nucpfcidadao { get; set; }

    public string? Nucns { get; set; }

    public DateOnly? Dtnascimento { get; set; }

    public string? Dsavaliada { get; set; }

    public string? Dsautorreferido { get; set; }

    public DateOnly? Dtatendimento { get; set; }

    public DateOnly? Dtafericaopa { get; set; }

    public string? Dsnumerador { get; set; }
}
