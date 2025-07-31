using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Poccadastrosgeralasmadpoc
{
    public string Uuid { get; set; } = null!;

    public string Nomecompleto { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Datanascimento { get; set; } = null!;

    public string Numerocpf { get; set; } = null!;

    public string Nomeunidade { get; set; } = null!;

    public string Nomeequipe { get; set; } = null!;

    public int Localidade { get; set; }

    public string Hipertensao { get; set; } = null!;

    public string Diabetes { get; set; } = null!;

    public string Tipohipertensao { get; set; } = null!;

    public string Tipodiabetes { get; set; } = null!;

    public string Asma { get; set; } = null!;

    public string Tipoasma { get; set; } = null!;

    public string Dpoc { get; set; } = null!;

    public string Tipodpoc { get; set; } = null!;
}
