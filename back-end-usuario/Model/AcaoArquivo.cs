using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class AcaoArquivo
{
    public int AcaoArquivoId { get; set; }

    public int AcaoId { get; set; }

    public DateTime CriadoEm { get; set; }

    public DateTime? AlteradoEm { get; set; }

    public int CriadoPor { get; set; }

    public int? AlteradoPor { get; set; }

    public int ArquivoId { get; set; }

    public bool Deletado { get; set; }

    public virtual Acao Acao { get; set; } = null!;

    public virtual Usuario? AlteradoPorNavigation { get; set; }

    public virtual Arquivo Arquivo { get; set; } = null!;

    public virtual Usuario CriadoPorNavigation { get; set; } = null!;
}
