using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbFatProcedAtend
{
    public long CoSeqFatProcedAtend { get; set; }

    public long? CoFatProcedimento { get; set; }

    public long? CoDimTipoFicha { get; set; }

    public long? CoDimMunicipio { get; set; }

    public long? CoDimUnidadeSaude { get; set; }

    public long? CoDimEquipe { get; set; }

    public long? CoDimProfissional { get; set; }

    public long? CoDimCbo { get; set; }

    public long? CoDimTempo { get; set; }

    public long? CoDimSexo { get; set; }

    public long? CoDimTurno { get; set; }

    public long? CoDimLocalAtendimento { get; set; }

    public long? CoDimFaixaEtaria { get; set; }

    public int? StEscutaInicial { get; set; }

    public string? NuUuidFicha { get; set; }

    public int? NuAtendimento { get; set; }

    public string? NuCns { get; set; }

    public DateOnly? DtNascimento { get; set; }

    public string? DsFiltroProcedimento { get; set; }

    public string? NuUuidDadoTransp { get; set; }

    public string? NuProntuario { get; set; }

    public long? CoDimTipoOrigemDadoTransp { get; set; }

    public long? CoDimCdsTipoOrigem { get; set; }

    public long? CoFatCidadaoPec { get; set; }

    public DateTime? DtInicialAtendimento { get; set; }

    public DateTime? DtFinalAtendimento { get; set; }

    public string? NuCpfCidadao { get; set; }

    public double? NuPeso { get; set; }

    public double? NuAltura { get; set; }

    public virtual TbDimCbo? CoDimCboNavigation { get; set; }

    public virtual TbDimTipoOrigem? CoDimCdsTipoOrigemNavigation { get; set; }

    public virtual TbDimEquipe? CoDimEquipeNavigation { get; set; }

    public virtual TbDimFaixaEtaria? CoDimFaixaEtariaNavigation { get; set; }

    public virtual TbDimLocalAtendimento? CoDimLocalAtendimentoNavigation { get; set; }

    public virtual TbDimMunicipio? CoDimMunicipioNavigation { get; set; }

    public virtual TbDimProfissional? CoDimProfissionalNavigation { get; set; }

    public virtual TbDimSexo? CoDimSexoNavigation { get; set; }

    public virtual TbDimTempo? CoDimTempoNavigation { get; set; }

    public virtual TbDimTipoFicha? CoDimTipoFichaNavigation { get; set; }

    public virtual TbDimTipoOrigemDadoTransp? CoDimTipoOrigemDadoTranspNavigation { get; set; }

    public virtual TbDimTurno? CoDimTurnoNavigation { get; set; }

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaudeNavigation { get; set; }

    public virtual TbFatCidadaoPec? CoFatCidadaoPecNavigation { get; set; }
}
