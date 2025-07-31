using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Paciente
{
    public int PacienteId { get; set; }

    public string? Uuid { get; set; }

    public string? NomeCompleto { get; set; }

    public string? Gender { get; set; }

    public DateTime? DataNascimento { get; set; }

    public string? NumeroCpf { get; set; }

    public string? NomeUnidade { get; set; }

    public string? NomeEquipe { get; set; }

    public int? Localidade { get; set; }

    public virtual ICollection<CicloGestacaoPlano> CicloGestacaoPlano { get; } = new List<CicloGestacaoPlano>();
}
