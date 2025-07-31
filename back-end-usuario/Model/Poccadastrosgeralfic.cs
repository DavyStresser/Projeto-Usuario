using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Poccadastrosgeralfic
{
    public string Uuid { get; set; } = null!;

    public string Nomecompleto { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public DateOnly Datanascimento { get; set; }

    public string Numerocpf { get; set; } = null!;

    public string Nomeunidade { get; set; } = null!;

    public string Nomeequipe { get; set; } = null!;

    public int? Localidade { get; set; }
}
