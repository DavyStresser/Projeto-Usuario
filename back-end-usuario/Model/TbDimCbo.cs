using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimCbo
{
    public long CoSeqDimCbo { get; set; }

    public string? NuCbo { get; set; }

    public string? NoCbo { get; set; }

    public int? StRegistroValido { get; set; }

    public string? DsFiltro { get; set; }

    public virtual ICollection<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentosCoDimCbo1Navigation { get; } = new List<TbFatAtdIndEncaminhamentos>();

    public virtual ICollection<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentosCoDimCbo2Navigation { get; } = new List<TbFatAtdIndEncaminhamentos>();

    public virtual ICollection<TbFatAtdIndExames> TbFatAtdIndExamesCoDimCbo1Navigation { get; } = new List<TbFatAtdIndExames>();

    public virtual ICollection<TbFatAtdIndExames> TbFatAtdIndExamesCoDimCbo2Navigation { get; } = new List<TbFatAtdIndExames>();

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentosCoDimCbo1Navigation { get; } = new List<TbFatAtdIndMedicamentos>();

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentosCoDimCbo2Navigation { get; } = new List<TbFatAtdIndMedicamentos>();

    public virtual ICollection<TbFatAtdIndProblemas> TbFatAtdIndProblemasCoDimCbo1Navigation { get; } = new List<TbFatAtdIndProblemas>();

    public virtual ICollection<TbFatAtdIndProblemas> TbFatAtdIndProblemasCoDimCbo2Navigation { get; } = new List<TbFatAtdIndProblemas>();

    public virtual ICollection<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentosCoDimCbo1Navigation { get; } = new List<TbFatAtdIndProcedimentos>();

    public virtual ICollection<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentosCoDimCbo2Navigation { get; } = new List<TbFatAtdIndProcedimentos>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividualCoDimCbo1Navigation { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividualCoDimCbo2Navigation { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividualCoDimCboFinalizadorObsNavigation { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividualCoDimCboCidadaoNavigation { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividualCoDimCboNavigation { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatProcedAtend> TbFatProcedAtend { get; } = new List<TbFatProcedAtend>();
}
