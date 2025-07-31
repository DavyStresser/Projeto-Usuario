using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Poccadastrosgeralhipertensaodiabete
{
    public string Uuid { get; set; } = null!;

    public string Nomecompleto { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Datanascimento { get; set; } = null!;

    public string Numerocpf { get; set; } = null!;

    public string Nomeunidade { get; set; } = null!;

    public string Nomeequipe { get; set; } = null!;

    public int Localidade { get; set; }

    public int Consultasemestre { get; set; }

    public string Hipertensao { get; set; } = null!;

    public string Diabetes { get; set; } = null!;

    public string Pressaoaferida { get; set; } = null!;

    public string Hemoglobinaglicada { get; set; } = null!;
}
