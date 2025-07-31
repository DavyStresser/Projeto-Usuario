using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Poccadastrosgeralcriancasplanejamento
{
    public string Uuid { get; set; } = null!;

    public string Nomecompleto { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Datanascimento { get; set; } = null!;

    public string Numerocpf { get; set; } = null!;

    public string Nomeunidade { get; set; } = null!;

    public string Nomeequipe { get; set; } = null!;

    public int Localidade { get; set; }

    public int Idadenumero { get; set; }

    public string Idade { get; set; } = null!;

    public string Vacbcg { get; set; } = null!;

    public string Vachepatiteb { get; set; } = null!;

    public string Vacpoliovip { get; set; } = null!;

    public int Vacpoliovop { get; set; }

    public int Vacrotavirus { get; set; }

    public int Vacpenta { get; set; }

    public int Vacpeneumococica { get; set; }

    public int Vacmenigococica { get; set; }

    public int Vacfebreamarela { get; set; }

    public int Vactripliceviral { get; set; }

    public string Vactetraviral { get; set; } = null!;

    public string Vachepatitea { get; set; } = null!;

    public string Vacdifiteriadtp { get; set; } = null!;

    public string Vacdifiteriadt { get; set; } = null!;

    public string Vacpapiloma { get; set; } = null!;

    public string Vacpeneumococicavpp { get; set; } = null!;

    public string Vacvacirela { get; set; } = null!;

    public string Vachepatitebadolesc { get; set; } = null!;

    public string Vacdifiteriaadolesc { get; set; } = null!;

    public string Vacfebreamarelaadolesc { get; set; } = null!;

    public string Vacsarampoadolesc { get; set; } = null!;

    public string Vacpapilomaadolesc { get; set; } = null!;

    public string Vacpeneumococicaadolesc { get; set; } = null!;

    public string Vacmenigococicaadolesc { get; set; } = null!;

    public string Con1semana { get; set; } = null!;

    public string Con2mes { get; set; } = null!;

    public string Con4mes { get; set; } = null!;

    public string Con6mes { get; set; } = null!;

    public string Con9mes { get; set; } = null!;

    public string Con12mes { get; set; } = null!;

    public string Con18mes { get; set; } = null!;

    public string Con24mes { get; set; } = null!;

    public string Con36mes { get; set; } = null!;

    public int Pesoparaidade { get; set; }

    public int Imcparaidade { get; set; }

    public int Estaturaparaidade { get; set; }

    public int Pesoparaestatura { get; set; }

    public int Perimetrocefalico { get; set; }

    public int Tipoaleitamento { get; set; }
}
