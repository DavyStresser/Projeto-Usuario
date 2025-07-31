using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbFatCadIndividual
{
    public long CoSeqFatCadIndividual { get; set; }

    public string? NuUuidFicha { get; set; }

    public string? NuUuidFichaOrigem { get; set; }

    public int? StRecusaCadastro { get; set; }

    public string? NuCns { get; set; }

    public DateOnly? DtNascimento { get; set; }

    public int? StDesconheceMae { get; set; }

    public long? CoDimProfissional { get; set; }

    public long? CoDimTipoFicha { get; set; }

    public long? CoDimMunicipio { get; set; }

    public long? CoDimUnidadeSaude { get; set; }

    public long? CoDimEquipe { get; set; }

    public long? CoDimTempo { get; set; }

    public long? CoDimTempoValidade { get; set; }

    public long? CoDimTempoValidadeRecusa { get; set; }

    public long? CoDimSexo { get; set; }

    public long? CoDimRacaCor { get; set; }

    public long? CoDimNacionalidade { get; set; }

    public long? CoDimPaisNascimento { get; set; }

    public long? CoDimMunicipioCidadao { get; set; }

    public string? NuCnsResponsavel { get; set; }

    public int? StResponsavelFamiliar { get; set; }

    public int? StFrequentaCreche { get; set; }

    public int? StFrequentaCuidador { get; set; }

    public int? StParticipaGrupoComunitario { get; set; }

    public int? StPlanoSaudePrivado { get; set; }

    public int? StComunidadeTradicional { get; set; }

    public int? StDeficiencia { get; set; }

    public int? StDefiAuditiva { get; set; }

    public int? StDefiIntelectualCognitiva { get; set; }

    public int? StDefiOutra { get; set; }

    public int? StDefiVisual { get; set; }

    public int? StDefiFisica { get; set; }

    public int? StGestante { get; set; }

    public int? StDoencaRespiratoria { get; set; }

    public int? StDoencaRespiraAsma { get; set; }

    public int? StDoencaRespiraDpocEnfisem { get; set; }

    public int? StDoencaRespiraOutra { get; set; }

    public int? StDoencaRespiraNSabe { get; set; }

    public int? StFumante { get; set; }

    public int? StAlcool { get; set; }

    public int? StOutraDroga { get; set; }

    public int? StHipertensaoArterial { get; set; }

    public int? StDiabete { get; set; }

    public int? StAvc { get; set; }

    public int? StInfarto { get; set; }

    public int? StHanseniase { get; set; }

    public int? StTuberculose { get; set; }

    public int? StCancer { get; set; }

    public int? StInternacao12 { get; set; }

    public int? StTratamentoPsiquiatra { get; set; }

    public int? StAcamado { get; set; }

    public int? StDomiciliado { get; set; }

    public int? StUsaPlantaMedicinal { get; set; }

    public int? StDoencaCardiaca { get; set; }

    public int? StDoencaCardInsuficiencia { get; set; }

    public int? StDoencaCardOutro { get; set; }

    public int? StDoencaCardNSabe { get; set; }

    public int? StProblemaRins { get; set; }

    public int? StProblemaRinsInsuficiencia { get; set; }

    public int? StProblemaRinsOutro { get; set; }

    public int? StProblemaRinsNaoSabe { get; set; }

    public int? StPic { get; set; }

    public int? StMoradorRua { get; set; }

    public int? StRecebeBeneficio { get; set; }

    public int? StReferenciaFamiliar { get; set; }

    public long? CoDimFrequenciaAlimentacao { get; set; }

    public int? StOrigAlimenRestaurantePop { get; set; }

    public int? StOrigAlimenDoacaoReli { get; set; }

    public int? StOrigAlimenDoacaoRest { get; set; }

    public int? StOrigAlimenDoacaoPopular { get; set; }

    public int? StOrigAlimenOutros { get; set; }

    public int? StAcompanhadoInstituicao { get; set; }

    public int? StVisitaFamiliarFrequente { get; set; }

    public int? StHigienePessoalAcesso { get; set; }

    public int? StHigPessBanho { get; set; }

    public int? StHigPessSanitario { get; set; }

    public int? StHigPessHigieneBucal { get; set; }

    public int? StHigPessOutros { get; set; }

    public long? CoDimTipoParentesco { get; set; }

    public long? CoDimCbo { get; set; }

    public long? CoDimTipoEscolaridade { get; set; }

    public long? CoDimSituacaoTrabalho { get; set; }

    public long? CoDimTipoOrientacaoSexual { get; set; }

    public long? CoDimTipoSaidaCadastro { get; set; }

    public long? CoDimTipoCondicaoPeso { get; set; }

    public long? CoDimTempoMoradorRua { get; set; }

    public long? CoDimEtnia { get; set; }

    public long? CoDimCboCidadao { get; set; }

    public long? CoDimIdentidadeGenero { get; set; }

    public long? CoDimFaixaEtaria { get; set; }

    public int? StDesconhecePai { get; set; }

    public int? StInformarOrientacaoSexual { get; set; }

    public int? StInformarIdentidadeGenero { get; set; }

    public DateOnly? DtNaturalizacao { get; set; }

    public DateOnly? DtEntradaBrasil { get; set; }

    public DateOnly? DtObito { get; set; }

    public int? StResponsCriancaAdultoResp { get; set; }

    public int? StResponsCriancaOutraCrian { get; set; }

    public int? StResponsCriancaAdolescente { get; set; }

    public int? StResponsCriancaSozinha { get; set; }

    public int? StResponsCriancaCreche { get; set; }

    public int? StResponsCriancaOutro { get; set; }

    public string? NuMicroArea { get; set; }

    public int? StProcessoLinhaTempo { get; set; }

    public int? StProcessoCidadao { get; set; }

    public string? NoNome { get; set; }

    public string? NoNomeSocial { get; set; }

    public string? NoNomeMae { get; set; }

    public string? NoNomePai { get; set; }

    public string? NuNis { get; set; }

    public string? NuPortariaNaturalizacao { get; set; }

    public string? NuCelular { get; set; }

    public string? NoEmail { get; set; }

    public string? NuObitoDo { get; set; }

    public string? NoMaternidadeReferencia { get; set; }

    public string? NoCausaInternacao12 { get; set; }

    public string? NoPlantasMedicinais { get; set; }

    public string? NoOutraCondicao1 { get; set; }

    public string? NoOutraCondicao2 { get; set; }

    public string? NoOutraCondicao3 { get; set; }

    public string? NoAcompanhadoInstituicao { get; set; }

    public string? NoVisitaFamiliarParentesco { get; set; }

    public string? NuUuidDadoTransp { get; set; }

    public long? CoDimTipoOrigemDadoTransp { get; set; }

    public long? CoDimCdsTipoOrigem { get; set; }

    public int? StGeradoAutomaticamente { get; set; }

    public int? StFichaInativa { get; set; }

    public long? CoFatCidadaoPec { get; set; }

    public long? CoFatCidadaoPecResponsvl { get; set; }

    public int? StProcOperacionais { get; set; }

    public string? NuCpfCidadao { get; set; }

    public string? NuCpfResponsavel { get; set; }

    /// <summary>
    /// Código de dimensão do povo ou comunidade tradicional
    /// </summary>
    public long? CoDimPovoComunidadTrad { get; set; }

    /// <summary>
    /// Nos últimos três meses, você comeu apenas alguns alimentos que ainda tinha, porque o dinheiro acabou?
    /// </summary>
    public int? StComeuQueTinhaDnheirAcab { get; set; }

    /// <summary>
    /// Nos últimos três meses, os alimentos acabaram antes que você tivesse dinheiro para comprar mais comida?
    /// </summary>
    public int? StAlimentosAcabSemDinheiro { get; set; }

    public virtual TbDimCbo? CoDimCboCidadaoNavigation { get; set; }

    public virtual TbDimCbo? CoDimCboNavigation { get; set; }

    public virtual TbDimTipoOrigem? CoDimCdsTipoOrigemNavigation { get; set; }

    public virtual TbDimEquipe? CoDimEquipeNavigation { get; set; }

    public virtual TbDimEtnia? CoDimEtniaNavigation { get; set; }

    public virtual TbDimFaixaEtaria? CoDimFaixaEtariaNavigation { get; set; }

    public virtual TbDimFrequenciaAlimentacao? CoDimFrequenciaAlimentacaoNavigation { get; set; }

    public virtual TbDimIdentidadeGenero? CoDimIdentidadeGeneroNavigation { get; set; }

    public virtual TbDimMunicipio? CoDimMunicipioCidadaoNavigation { get; set; }

    public virtual TbDimMunicipio? CoDimMunicipioNavigation { get; set; }

    public virtual TbDimNacionalidade? CoDimNacionalidadeNavigation { get; set; }

    public virtual TbDimPais? CoDimPaisNascimentoNavigation { get; set; }

    public virtual TbDimPovoComunidadTrad? CoDimPovoComunidadTradNavigation { get; set; }

    public virtual TbDimProfissional? CoDimProfissionalNavigation { get; set; }

    public virtual TbDimRacaCor? CoDimRacaCorNavigation { get; set; }

    public virtual TbDimSexo? CoDimSexoNavigation { get; set; }

    public virtual TbDimSituacaoTrabalho? CoDimSituacaoTrabalhoNavigation { get; set; }

    public virtual TbDimTempoMoradorRua? CoDimTempoMoradorRuaNavigation { get; set; }

    public virtual TbDimTempo? CoDimTempoNavigation { get; set; }

    public virtual TbDimTempo? CoDimTempoValidadeNavigation { get; set; }

    public virtual TbDimTempo? CoDimTempoValidadeRecusaNavigation { get; set; }

    public virtual TbDimTipoCondicaoPeso? CoDimTipoCondicaoPesoNavigation { get; set; }

    public virtual TbDimTipoEscolaridade? CoDimTipoEscolaridadeNavigation { get; set; }

    public virtual TbDimTipoFicha? CoDimTipoFichaNavigation { get; set; }

    public virtual TbDimTipoOrientacaoSexual? CoDimTipoOrientacaoSexualNavigation { get; set; }

    public virtual TbDimTipoOrigemDadoTransp? CoDimTipoOrigemDadoTranspNavigation { get; set; }

    public virtual TbDimTipoParentesco? CoDimTipoParentescoNavigation { get; set; }

    public virtual TbDimTipoSaidaCadastro? CoDimTipoSaidaCadastroNavigation { get; set; }

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaudeNavigation { get; set; }

    public virtual TbFatCidadaoPec? CoFatCidadaoPecNavigation { get; set; }

    public virtual TbFatCidadaoPec? CoFatCidadaoPecResponsvlNavigation { get; set; }
}
