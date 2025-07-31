using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class ArquivoFinanceiro
{
    public int Id { get; set; }

    public string? Parcela { get; set; }

    public string? Modelo { get; set; }

    public string? ArquivoJson { get; set; }
}
