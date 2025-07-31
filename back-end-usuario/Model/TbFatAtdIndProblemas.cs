using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbFatAtdIndProblemas
{
    public long CoSeqFatAtendIndProblemas { get; set; }

    public long? CoFatAtdInd { get; set; }

    public long? CoDimTipoFicha { get; set; }

    public long? CoDimMunicipio { get; set; }

    public long? CoDimProfissional1 { get; set; }

    public long? CoDimProfissional2 { get; set; }

    public long? CoDimCbo1 { get; set; }

    public long? CoDimCbo2 { get; set; }

    public long? CoDimUnidadeSaude1 { get; set; }

    public long? CoDimUnidadeSaude2 { get; set; }

    public long? CoDimEquipe1 { get; set; }

    public long? CoDimEquipe2 { get; set; }

    public long? CoDimTempo { get; set; }

    public string? NuUuidFicha { get; set; }

    public int? NuAtendimento { get; set; }

    public string? NuCns { get; set; }

    public long? CoDimCid { get; set; }

    public long? CoDimCiap { get; set; }

    public string? NuUuidDadoTransp { get; set; }

    public long? CoDimTipoOrigemDadoTransp { get; set; }

    public long? CoDimCdsTipoOrigem { get; set; }

    public long? CoFatCidadaoPec { get; set; }

    public string? NuCpfCidadao { get; set; }

    public virtual TbDimCid? CoDimC { get; set; }

    public virtual TbDimCbo? CoDimCbo1Navigation { get; set; }

    public virtual TbDimCbo? CoDimCbo2Navigation { get; set; }

    public virtual TbDimTipoOrigem? CoDimCdsTipoOrigemNavigation { get; set; }

    public virtual TbDimCiap? CoDimCiapNavigation { get; set; }

    public virtual TbDimEquipe? CoDimEquipe1Navigation { get; set; }

    public virtual TbDimEquipe? CoDimEquipe2Navigation { get; set; }

    public virtual TbDimMunicipio? CoDimMunicipioNavigation { get; set; }

    public virtual TbDimProfissional? CoDimProfissional1Navigation { get; set; }

    public virtual TbDimProfissional? CoDimProfissional2Navigation { get; set; }

    public virtual TbDimTempo? CoDimTempoNavigation { get; set; }

    public virtual TbDimTipoFicha? CoDimTipoFichaNavigation { get; set; }

    public virtual TbDimTipoOrigemDadoTransp? CoDimTipoOrigemDadoTranspNavigation { get; set; }

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaude1Navigation { get; set; }

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaude2Navigation { get; set; }

    public virtual TbFatCidadaoPec? CoFatCidadaoPecNavigation { get; set; }
}
