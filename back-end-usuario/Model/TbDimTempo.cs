using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimTempo
{
    public long CoSeqDimTempo { get; set; }

    public DateOnly? DtRegistro { get; set; }

    public short? NuDia { get; set; }

    public short? NuMes { get; set; }

    public int? NuAno { get; set; }

    public string? DsDiaSemana { get; set; }

    public virtual ICollection<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentos { get; } = new List<TbFatAtdIndEncaminhamentos>();

    public virtual ICollection<TbFatAtdIndExames> TbFatAtdIndExames { get; } = new List<TbFatAtdIndExames>();

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentos { get; } = new List<TbFatAtdIndMedicamentos>();

    public virtual ICollection<TbFatAtdIndProblemas> TbFatAtdIndProblemas { get; } = new List<TbFatAtdIndProblemas>();

    public virtual ICollection<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentos { get; } = new List<TbFatAtdIndProcedimentos>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividualCoDimTempoDumNavigation { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividualCoDimTempoNavigation { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividualCoDimTempoNavigation { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividualCoDimTempoValidadeNavigation { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividualCoDimTempoValidadeRecusaNavigation { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatCidadao> TbFatCidadaoCoDimLinhaTempoValddEqupNavigation { get; } = new List<TbFatCidadao>();

    public virtual ICollection<TbFatCidadao> TbFatCidadaoCoDimLinhaTempoValidadeNavigation { get; } = new List<TbFatCidadao>();

    public virtual ICollection<TbFatCidadao> TbFatCidadaoCoDimLinhaValddMunicipioNavigation { get; } = new List<TbFatCidadao>();

    public virtual ICollection<TbFatCidadao> TbFatCidadaoCoDimLnhVlddUniddSadNavigation { get; } = new List<TbFatCidadao>();

    public virtual ICollection<TbFatCidadao> TbFatCidadaoCoDimTempoNavigation { get; } = new List<TbFatCidadao>();

    public virtual ICollection<TbFatCidadao> TbFatCidadaoCoDimTempoValddEquipeNavigation { get; } = new List<TbFatCidadao>();

    public virtual ICollection<TbFatCidadao> TbFatCidadaoCoDimTempoValddMunicipioNavigation { get; } = new List<TbFatCidadao>();

    public virtual ICollection<TbFatCidadao> TbFatCidadaoCoDimTempoValddUniddSaudNavigation { get; } = new List<TbFatCidadao>();

    public virtual ICollection<TbFatCidadao> TbFatCidadaoCoDimTempoValidadeNavigation { get; } = new List<TbFatCidadao>();

    public virtual ICollection<TbFatFichas> TbFatFichas { get; } = new List<TbFatFichas>();

    public virtual ICollection<TbFatProcedAtend> TbFatProcedAtend { get; } = new List<TbFatProcedAtend>();
}
