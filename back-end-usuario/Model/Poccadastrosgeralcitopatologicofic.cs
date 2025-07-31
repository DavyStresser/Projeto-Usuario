using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Poccadastrosgeralcitopatologicofic
{
    public string Uuid { get; set; } = null!;

    public string Nomecompleto { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Datanascimento { get; set; } = null!;

    public string Numerocpf { get; set; } = null!;

    public string Nomeunidade { get; set; } = null!;

    public string Nomeequipe { get; set; } = null!;

    public int Localidade { get; set; }

    public string Realizouexamecitopatologico { get; set; } = null!;
}
