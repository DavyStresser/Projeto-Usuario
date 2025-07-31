using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Notificacao
{
    public int NotificacaoId { get; set; }

    public string Nome { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int Tipo { get; set; }

    public string Url { get; set; } = null!;

    public int UsuarioId { get; set; }

    public DateTime CriadoEm { get; set; }

    public string Status { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
