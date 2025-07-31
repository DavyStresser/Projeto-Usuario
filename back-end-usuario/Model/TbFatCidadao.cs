using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class TbFatCidadao
{
    public long CoSeqFatCidadao { get; set; }

    public string? NuUuidFicha { get; set; }

    public string? NuUuidFichaOrigem { get; set; }

    public string? NuCns { get; set; }

    public long? CoFatCadIndividual { get; set; }

    public long? CoFatFamilia { get; set; }

    public long? CoDimTempo { get; set; }

    /// <summary>
    /// Aponta para o fato mais recente sobre um cidadão, uma vez que as informações sobre um cidadão podem ser atualizadas.
    /// </summary>
    public long? CoFatCidadaoRaiz { get; set; }

    /// <summary>
    /// Aponta para o fato anterior que o originou e que possui o mesmo CPF ou CNS.
    /// </summary>
    public long? CoFatCidadaoPai1 { get; set; }

    /// <summary>
    /// Aponta para o fato anterior que o originou através da atualização da ficha de origem.
    /// </summary>
    public long? CoFatCidadaoPai2 { get; set; }

    public long? CoDimTempoValidade { get; set; }

    public long? CoDimLinhaTempoValidade { get; set; }

    public long? CoFatCidadaoRaizEquipe { get; set; }

    public long? CoFatCidadaoPai1Equipe { get; set; }

    public long? CoFatCidadaoPai2Equipe { get; set; }

    public long? CoDimTempoValddEquipe { get; set; }

    public long? CoDimLinhaTempoValddEqup { get; set; }

    public long? CoFatCidadaoRaizUnddeSade { get; set; }

    public long? CoFatCidadaoPai1UnddeSade { get; set; }

    public long? CoFatCidadaoPai2UnddeSade { get; set; }

    public long? CoDimTempoValddUniddSaud { get; set; }

    public long? CoDimLnhVlddUniddSad { get; set; }

    public long? CoFatCidadaoRaizMunicipio { get; set; }

    public long? CoFatCidadaoPai1Municipio { get; set; }

    public long? CoFatCidadaoPai2Municipio { get; set; }

    public long? CoDimTempoValddMunicipio { get; set; }

    public long? CoDimLinhaValddMunicipio { get; set; }

    public long? CoDimMunicipio { get; set; }

    public long? CoDimUnidadeSaude { get; set; }

    public long? CoDimEquipe { get; set; }

    public int? StResponsavelFamiliar { get; set; }

    public int? StMudou { get; set; }

    public int? StVivo { get; set; }

    public int? StAtivoTerritorio { get; set; }

    /// <summary>
    /// Representa o estágio do processamento da árvore de atualizações e da linha do tempo de um fato sobre um cidadão (2 - Cálculo da árvore; 1 - Cálculo da linha do tempo; 0 - Árvore e linha do tempo calculadas)
    /// </summary>
    public int? StProcessoLinhaTempo { get; set; }

    public int? StProcessoFamilia { get; set; }

    public int? StFichaInativa { get; set; }

    public string? NuCpfCidadao { get; set; }

    public virtual TbDimEquipe? CoDimEquipeNavigation { get; set; }

    public virtual TbDimTempo? CoDimLinhaTempoValddEqupNavigation { get; set; }

    public virtual TbDimTempo? CoDimLinhaTempoValidadeNavigation { get; set; }

    public virtual TbDimTempo? CoDimLinhaValddMunicipioNavigation { get; set; }

    public virtual TbDimTempo? CoDimLnhVlddUniddSadNavigation { get; set; }

    public virtual TbDimMunicipio? CoDimMunicipioNavigation { get; set; }

    public virtual TbDimTempo? CoDimTempoNavigation { get; set; }

    public virtual TbDimTempo? CoDimTempoValddEquipeNavigation { get; set; }

    public virtual TbDimTempo? CoDimTempoValddMunicipioNavigation { get; set; }

    public virtual TbDimTempo? CoDimTempoValddUniddSaudNavigation { get; set; }

    public virtual TbDimTempo? CoDimTempoValidadeNavigation { get; set; }

    public virtual TbDimUnidadeSaude? CoDimUnidadeSaudeNavigation { get; set; }
}
