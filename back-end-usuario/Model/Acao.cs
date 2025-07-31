using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Acao
{
    public int AcaoId { get; set; }

    public string Nome { get; set; } = null!;

    public string Plano { get; set; } = null!;

    public decimal Custo { get; set; }

    public int Prazo { get; set; }

    public DateTime DataInicio { get; set; }

    public int Gravidade { get; set; }

    public int Urgencia { get; set; }

    public int Tendencia { get; set; }

    public int AcaoStatusId { get; set; }

    public bool Deletado { get; set; }

    public DateTime CriadoEm { get; set; }

    public DateTime? AlteradoEm { get; set; }

    public int CriadoPor { get; set; }

    public int? AlteradoPor { get; set; }

    public string? Cidade { get; set; }

    public virtual ICollection<AcaoArquivo> AcaoArquivo { get; } = new List<AcaoArquivo>();

    public virtual ICollection<AcaoAtividade> AcaoAtividade { get; } = new List<AcaoAtividade>();

    public virtual AcaoStatus AcaoStatus { get; set; } = null!;

    public virtual ICollection<AcaoUsuario> AcaoUsuario { get; } = new List<AcaoUsuario>();

    public virtual Usuario? AlteradoPorNavigation { get; set; }

    public virtual Usuario CriadoPorNavigation { get; set; } = null!;
}
