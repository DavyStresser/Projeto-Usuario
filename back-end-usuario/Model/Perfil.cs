using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Perfil
{
    public int PerfilId { get; set; }

    public string Nome { get; set; } = null!;

    public int Tipo { get; set; }

    public bool Deletado { get; set; }

    public virtual ICollection<Usuario> Usuario { get; } = new List<Usuario>();
}
