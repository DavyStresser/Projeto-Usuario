using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbDimProcedimento
{
    public long CoSeqDimProcedimento { get; set; }

    public string? CoProced { get; set; }

    public string? DsProced { get; set; }

    public long? CoSeqDimProcedRefAb { get; set; }

    public long? CoPai { get; set; }

    public int? StRegistroValido { get; set; }

    public string? DsFiltro { get; set; }

    public virtual TbDimProcedimento? CoPaiNavigation { get; set; }

    public virtual ICollection<TbDimProcedimento> InverseCoPaiNavigation { get; } = new List<TbDimProcedimento>();

    public virtual ICollection<TbFatAtdIndExames> TbFatAtdIndExames { get; } = new List<TbFatAtdIndExames>();

    public virtual ICollection<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentosCoDimProcedimentoAvaliadoNavigation { get; } = new List<TbFatAtdIndProcedimentos>();

    public virtual ICollection<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentosCoDimProcedimentoSolicitadoNavigation { get; } = new List<TbFatAtdIndProcedimentos>();
}
