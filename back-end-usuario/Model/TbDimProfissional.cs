using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimProfissional
{
    public long CoSeqDimProfissional { get; set; }

    public string? NuCns { get; set; }

    public string? NoProfissional { get; set; }

    public int? StRegistroValido { get; set; }

    public string? DsFiltro { get; set; }

    public virtual ICollection<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentosCoDimProfissional1Navigation { get; } = new List<TbFatAtdIndEncaminhamentos>();

    public virtual ICollection<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentosCoDimProfissional2Navigation { get; } = new List<TbFatAtdIndEncaminhamentos>();

    public virtual ICollection<TbFatAtdIndExames> TbFatAtdIndExamesCoDimProfissional1Navigation { get; } = new List<TbFatAtdIndExames>();

    public virtual ICollection<TbFatAtdIndExames> TbFatAtdIndExamesCoDimProfissional2Navigation { get; } = new List<TbFatAtdIndExames>();

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentosCoDimProfissional1Navigation { get; } = new List<TbFatAtdIndMedicamentos>();

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentosCoDimProfissional2Navigation { get; } = new List<TbFatAtdIndMedicamentos>();

    public virtual ICollection<TbFatAtdIndProblemas> TbFatAtdIndProblemasCoDimProfissional1Navigation { get; } = new List<TbFatAtdIndProblemas>();

    public virtual ICollection<TbFatAtdIndProblemas> TbFatAtdIndProblemasCoDimProfissional2Navigation { get; } = new List<TbFatAtdIndProblemas>();

    public virtual ICollection<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentosCoDimProfissional1Navigation { get; } = new List<TbFatAtdIndProcedimentos>();

    public virtual ICollection<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentosCoDimProfissional2Navigation { get; } = new List<TbFatAtdIndProcedimentos>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividualCoDimProfFinalizadorObsNavigation { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividualCoDimProfissional1Navigation { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividualCoDimProfissional2Navigation { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatProcedAtend> TbFatProcedAtend { get; } = new List<TbFatProcedAtend>();
}
