using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Arquivo
{
    public int ArquivoId { get; set; }

    public string Nome { get; set; } = null!;

    public string Url { get; set; } = null!;

    public DateTime CriadoEm { get; set; }

    public int CriadoPor { get; set; }

    public DateTime? AlteradoEm { get; set; }

    public int? AlteradoPor { get; set; }

    public bool Deletado { get; set; }

    public virtual ICollection<AcaoArquivo> AcaoArquivo { get; } = new List<AcaoArquivo>();

    public virtual Usuario? AlteradoPorNavigation { get; set; }

    public virtual Usuario CriadoPorNavigation { get; set; } = null!;
}
