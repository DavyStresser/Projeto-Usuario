using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimTipoFicha
{
    public long CoSeqDimTipoFicha { get; set; }

    public string? NuIdentificador { get; set; }

    public string? DsTipoFicha { get; set; }

    public int? CoOrdem { get; set; }

    public string? DsFiltro { get; set; }

    public virtual ICollection<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentos { get; } = new List<TbFatAtdIndEncaminhamentos>();

    public virtual ICollection<TbFatAtdIndExames> TbFatAtdIndExames { get; } = new List<TbFatAtdIndExames>();

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentos { get; } = new List<TbFatAtdIndMedicamentos>();

    public virtual ICollection<TbFatAtdIndProblemas> TbFatAtdIndProblemas { get; } = new List<TbFatAtdIndProblemas>();

    public virtual ICollection<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentos { get; } = new List<TbFatAtdIndProcedimentos>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividual { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividual { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatFichas> TbFatFichas { get; } = new List<TbFatFichas>();

    public virtual ICollection<TbFatProcedAtend> TbFatProcedAtend { get; } = new List<TbFatProcedAtend>();
}
