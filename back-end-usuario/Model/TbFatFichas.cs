using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbFatFichas
{
    public long CoSeqFatFichas { get; set; }

    public long? CoDimTipoFicha { get; set; }

    public long? CoDimMunicipio { get; set; }

    public long? CoDimUnidadeSaude { get; set; }

    public long? CoDimEquipe { get; set; }

    public long? CoDimTempo { get; set; }

    public string? NuUuidFicha { get; set; }

    public string? NuUuidDadoTransp { get; set; }

    public long? CoDimTipoOrigemDadoTransp { get; set; }

    public long? CoDimCdsTipoOrigem { get; set; }

    public virtual TbDimTipoOrigem? CoDimCdsTipoOrigemNavigation { get; set; }

    public virtual TbDimEquipe? CoDimEquipeNavigation { get; set; }

    public virtual TbDimMunicipio? CoDimMunicipioNavigation { get; set; }

    public virtual TbDimTempo? CoDimTempoNavigation { get; set; }

    public virtual TbDimTipoFicha? CoDimTipoFichaNavigation { get; set; }

    public virtual TbDimTipoOrigemDadoTransp? CoDimTipoOrigemDadoTranspNavigation { get; set; }

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaudeNavigation { get; set; }
}
