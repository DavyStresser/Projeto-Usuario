using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Poccadastrosgeralpreditor
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

    public short Hipertensao { get; set; }

    public short Diabetes { get; set; }

    public short Pressaoaferida { get; set; }

    public short Hemoglobinaglicada { get; set; }

    public int Idade { get; set; }

    public string Sexo { get; set; } = null!;

    public short Racacor { get; set; }

    public int Colesteroltotal { get; set; }

    public int Colesterolhdlc { get; set; }

    public int Pas { get; set; }

    public short Tratamentohipertensivo { get; set; }

    public short Asterosclerosesignificativa { get; set; }

    public short Asterosclerosesubclinica { get; set; }

    public short Aneurismaaortaabdominal { get; set; }

    public short Dcr { get; set; }

    public short Ldlcmaior190mgdl { get; set; }

    public short Diabetestipo1ou2 { get; set; }

    public short Diabetessemfatoreseroudasc { get; set; }

    public short Tabagismo { get; set; }
}
