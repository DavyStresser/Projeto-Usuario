using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class UsuarioMunicipio
{
    public int UsuarioMunicipioId { get; set; }

    public int UsuarioId { get; set; }

    public int MunicipioId { get; set; }

    public bool Deletado { get; set; }

    public virtual Municipio Municipio { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
