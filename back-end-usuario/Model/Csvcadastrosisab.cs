using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Csvcadastrosisab
{
    public int Id { get; set; }

    public int? Nuano { get; set; }

    public int? Nuquadrimestre { get; set; }

    public string? Nuequipe { get; set; }

    public string? Nonome { get; set; }

    public string? Nucpfcidadao { get; set; }

    public string? Nucns { get; set; }

    public DateOnly? Dtnascimento { get; set; }

    public string? Dssexo { get; set; }

    public int? Nuidade { get; set; }

    public string? Dsponderacao { get; set; }

    public string? Tpidentificacao { get; set; }

    public DateOnly? Dtrecente { get; set; }

    public int? Qtatendimentos { get; set; }
}
