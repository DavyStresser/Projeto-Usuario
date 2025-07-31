using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class CicloGestacaoPlano
{
    public int CicloGestacaoPlanoId { get; set; }

    public DateTime DataInicio { get; set; }

    public DateTime? DataTermino { get; set; }

    public string? Observacao { get; set; }

    public int PacienteId { get; set; }

    public DateTime CriadoEm { get; set; }

    public int CriadoPor { get; set; }

    public DateTime? AlteradoEm { get; set; }

    public int? AlteradoPor { get; set; }

    public int CicloGestacaoPlanoStatusId { get; set; }

    public bool Deletado { get; set; }

    public virtual ICollection<CicloGestacao> CicloGestacao { get; } = new List<CicloGestacao>();

    public virtual CicloGestacaoPlanoStatus CicloGestacaoPlanoStatus { get; set; } = null!;

    public virtual Paciente Paciente { get; set; } = null!;
}
