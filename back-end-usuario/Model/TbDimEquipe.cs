using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimEquipe
{
    public long CoSeqDimEquipe { get; set; }

    public string? NuIne { get; set; }

    public string? NoEquipe { get; set; }

    public int? StRegistroValido { get; set; }

    public string? DsFiltro { get; set; }

    public virtual ICollection<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentosCoDimEquipe1Navigation { get; } = new List<TbFatAtdIndEncaminhamentos>();

    public virtual ICollection<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentosCoDimEquipe2Navigation { get; } = new List<TbFatAtdIndEncaminhamentos>();

    public virtual ICollection<TbFatAtdIndExames> TbFatAtdIndExamesCoDimEquipe1Navigation { get; } = new List<TbFatAtdIndExames>();

    public virtual ICollection<TbFatAtdIndExames> TbFatAtdIndExamesCoDimEquipe2Navigation { get; } = new List<TbFatAtdIndExames>();

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentosCoDimEquipe1Navigation { get; } = new List<TbFatAtdIndMedicamentos>();

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentosCoDimEquipe2Navigation { get; } = new List<TbFatAtdIndMedicamentos>();

    public virtual ICollection<TbFatAtdIndProblemas> TbFatAtdIndProblemasCoDimEquipe1Navigation { get; } = new List<TbFatAtdIndProblemas>();

    public virtual ICollection<TbFatAtdIndProblemas> TbFatAtdIndProblemasCoDimEquipe2Navigation { get; } = new List<TbFatAtdIndProblemas>();

    public virtual ICollection<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentosCoDimEquipe1Navigation { get; } = new List<TbFatAtdIndProcedimentos>();

    public virtual ICollection<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentosCoDimEquipe2Navigation { get; } = new List<TbFatAtdIndProcedimentos>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividualCoDimEquipe1Navigation { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividualCoDimEquipe2Navigation { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividualCoDimEquipeFinalizadorObsNavigation { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatCidadao> TbFatCidadao { get; } = new List<TbFatCidadao>();

    public virtual ICollection<TbFatCidadaoPec> TbFatCidadaoPec { get; } = new List<TbFatCidadaoPec>();

    public virtual ICollection<TbFatFichas> TbFatFichas { get; } = new List<TbFatFichas>();

    public virtual ICollection<TbFatProcedAtend> TbFatProcedAtend { get; } = new List<TbFatProcedAtend>();
}
