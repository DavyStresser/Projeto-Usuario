using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class AcaoUsuario
{
    public int AcaoUsuarioId { get; set; }

    public int AcaoId { get; set; }

    public int UsuarioId { get; set; }

    public DateTime CriadoEm { get; set; }

    public DateTime? AlteradoEm { get; set; }

    public int CriadoPor { get; set; }

    public int? AlteradoPor { get; set; }

    public bool Deletado { get; set; }

    public virtual Acao Acao { get; set; } = null!;

    public virtual Usuario? AlteradoPorNavigation { get; set; }

    public virtual Usuario CriadoPorNavigation { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
