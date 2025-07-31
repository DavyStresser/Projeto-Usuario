using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbFatCidadaoPec
{
    public long CoSeqFatCidadaoPec { get; set; }

    public long? CoCidadao { get; set; }

    public string? NuCns { get; set; }

    public string? NoCidadao { get; set; }

    public string? NoSocialCidadao { get; set; }

    public long? CoDimTempoNascimento { get; set; }

    public long? CoDimSexo { get; set; }

    public long? CoDimIdentidadeGenero { get; set; }

    public string? NuTelefoneCelular { get; set; }

    public int? StFaleceu { get; set; }

    public int? StLookupEtl { get; set; }

    public int? StDeletar { get; set; }

    public string? NuCpfCidadao { get; set; }

    public long? CoDimUnidadeSaudeVinc { get; set; }

    public long? CoDimEquipeVinc { get; set; }

    public virtual TbDimEquipe? CoDimEquipeVincNavigation { get; set; }

    public virtual TbDimIdentidadeGenero? CoDimIdentidadeGeneroNavigation { get; set; }

    public virtual TbDimSexo? CoDimSexoNavigation { get; set; }

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaudeVincNavigation { get; set; }

    public virtual ICollection<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentos { get; } = new List<TbFatAtdIndEncaminhamentos>();

    public virtual ICollection<TbFatAtdIndExames> TbFatAtdIndExames { get; } = new List<TbFatAtdIndExames>();

    public virtual ICollection<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentos { get; } = new List<TbFatAtdIndMedicamentos>();

    public virtual ICollection<TbFatAtdIndProblemas> TbFatAtdIndProblemas { get; } = new List<TbFatAtdIndProblemas>();

    public virtual ICollection<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentos { get; } = new List<TbFatAtdIndProcedimentos>();

    public virtual ICollection<TbFatAtendimentoIndividual> TbFatAtendimentoIndividual { get; } = new List<TbFatAtendimentoIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividualCoFatCidadaoPecNavigation { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatCadIndividual> TbFatCadIndividualCoFatCidadaoPecResponsvlNavigation { get; } = new List<TbFatCadIndividual>();

    public virtual ICollection<TbFatProcedAtend> TbFatProcedAtend { get; } = new List<TbFatProcedAtend>();
}
