using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimMunicipio
{
    public long CoSeqDimMunicipio { get; set; }

    public string? NoMunicipio { get; set; }

    public string? CoIbge { get; set; }

    public long? CoDimUf { get; set; }

    public int? StRegistroValido { get; set; }

    public string? DsFiltro { get; set; }

    public virtual ICollection<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentos { get; } = new List<TbFatAtdIndEncaminhamentos>();

    public virtual ICollection<TbFatAtdIndExames> TbFatAtdIndExames { get; } = new List<TbFatAtdIndExames>();

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentos { get; } = new List<TbFatAtdIndMedicamentos>();

    public virtual ICollection<TbFatAtdIndProblemas> TbFatAtdIndProblemas { get; } = new List<TbFatAtdIndProblemas>();

    public virtual ICollection<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentos { get; } = new List<TbFatAtdIndProcedimentos>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividual { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividualCoDimMunicipioCidadaoNavigation { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividualCoDimMunicipioNavigation { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatCidadao> TbFatCidadao { get; } = new List<TbFatCidadao>();

    public virtual ICollection<TbFatFichas> TbFatFichas { get; } = new List<TbFatFichas>();

    public virtual ICollection<TbFatProcedAtend> TbFatProcedAtend { get; } = new List<TbFatProcedAtend>();
}
