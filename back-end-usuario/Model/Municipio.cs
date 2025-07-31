using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Municipio
{
    public int MunicipioId { get; set; }

    public string Nome { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public virtual ICollection<UsuarioMunicipio> UsuarioMunicipio { get; } = new List<UsuarioMunicipio>();
}
