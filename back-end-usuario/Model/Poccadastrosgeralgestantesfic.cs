using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Poccadastrosgeralgestantesfic
{
    public string Uuid { get; set; } = null!;

    public string Nomecompleto { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Datanascimento { get; set; } = null!;

    public string Numerocpf { get; set; } = null!;

    public string Nomeunidade { get; set; } = null!;

    public string Nomeequipe { get; set; } = null!;

    public int Localidade { get; set; }

    public string Gestante { get; set; } = null!;

    public int Semanaprimeiraconsultaprenatal { get; set; }

    public int Quantidadeconsultasprenatal { get; set; }

    public string Realizouexamesifilis { get; set; } = null!;

    public string Realizouexamehiv { get; set; } = null!;

    public string Realizouatendimentoodonto { get; set; } = null!;
}
