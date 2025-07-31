using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class CicloGestacao
{
    public int CicloGestacaoId { get; set; }

    public DateTime DataInicio { get; set; }

    public DateTime DataFinal { get; set; }

    public int Trimestre { get; set; }

    public int CicloGestacaoPlanoId { get; set; }

    public int CicloGestacaoStatusId { get; set; }

    public int CicloGestacaoTemaId { get; set; }

    public string? Observacao { get; set; }

    public DateTime? AlteradoEm { get; set; }

    public int? AlteradoPor { get; set; }

    public int CriadoPor { get; set; }

    public DateTime CriadoEm { get; set; }

    public int Deletado { get; set; }

    public int SemanaInicio { get; set; }

    public int SemanaFim { get; set; }

    public virtual Usuario? AlteradoPorNavigation { get; set; }

    public virtual CicloGestacaoPlano CicloGestacaoPlano { get; set; } = null!;

    public virtual CicloGestacaoStatus CicloGestacaoStatus { get; set; } = null!;

    public virtual CicloGestacaoTema CicloGestacaoTema { get; set; } = null!;

    public virtual Usuario CriadoPorNavigation { get; set; } = null!;
}
