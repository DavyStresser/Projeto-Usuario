using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Vwfichasprocessadas
{
    public string? Recebimento { get; set; }

    public int? Localidade { get; set; }

    public string? NuUuidFicha { get; set; }

    public string? DsTipoFicha { get; set; }

    public string? NuCpfCidadao { get; set; }

    public string? DsSexo { get; set; }

    public DateOnly? DtNascimento { get; set; }

    public string? Cadsus { get; set; }
}
