using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimUnidadeSaude
{
    public long CoSeqDimUnidadeSaude { get; set; }

    public string? NuCnes { get; set; }

    public string? NoUnidadeSaude { get; set; }

    public string? NoBairro { get; set; }

    public int? StRegistroValido { get; set; }

    public string? DsFiltro { get; set; }

    public virtual ICollection<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentosCoDimUnidadeSaude1Navigation { get; } = new List<TbFatAtdIndEncaminhamentos>();

    public virtual ICollection<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentosCoDimUnidadeSaude2Navigation { get; } = new List<TbFatAtdIndEncaminhamentos>();

    public virtual ICollection<TbFatAtdIndExames> TbFatAtdIndExamesCoDimUnidadeSaude1Navigation { get; } = new List<TbFatAtdIndExames>();

    public virtual ICollection<TbFatAtdIndExames> TbFatAtdIndExamesCoDimUnidadeSaude2Navigation { get; } = new List<TbFatAtdIndExames>();

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentosCoDimUnidadeSaude1Navigation { get; } = new List<TbFatAtdIndMedicamentos>();

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentosCoDimUnidadeSaude2Navigation { get; } = new List<TbFatAtdIndMedicamentos>();

    public virtual ICollection<TbFatAtdIndProblemas> TbFatAtdIndProblemasCoDimUnidadeSaude1Navigation { get; } = new List<TbFatAtdIndProblemas>();

    public virtual ICollection<TbFatAtdIndProblemas> TbFatAtdIndProblemasCoDimUnidadeSaude2Navigation { get; } = new List<TbFatAtdIndProblemas>();

    public virtual ICollection<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentosCoDimUnidadeSaude1Navigation { get; } = new List<TbFatAtdIndProcedimentos>();

    public virtual ICollection<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentosCoDimUnidadeSaude2Navigation { get; } = new List<TbFatAtdIndProcedimentos>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividualCoDimUbsFinalizadorObsNavigation { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividualCoDimUnidadeSaude1Navigation { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividualCoDimUnidadeSaude2Navigation { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatCidadao> TbFatCidadao { get; } = new List<TbFatCidadao>();

    public virtual ICollection<TbFatCidadaoPec> TbFatCidadaoPec { get; } = new List<TbFatCidadaoPec>();

    public virtual ICollection<TbFatFichas> TbFatFichas { get; } = new List<TbFatFichas>();

    public virtual ICollection<TbFatProcedAtend> TbFatProcedAtend { get; } = new List<TbFatProcedAtend>();
}
