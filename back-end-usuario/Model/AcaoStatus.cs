using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class AcaoStatus
{
    public int AcaoStatusId { get; set; }

    public string Nome { get; set; } = null!;

    public DateTime CriadoEm { get; set; }

    public DateTime? AlteradoEm { get; set; }

    public int CriadoPor { get; set; }

    public int? AlteradoPor { get; set; }

    public bool Deletado { get; set; }

    public virtual ICollection<Acao> Acao { get; } = new List<Acao>();

    public virtual Usuario? AlteradoPorNavigation { get; set; }

    public virtual Usuario CriadoPorNavigation { get; set; } = null!;
}
