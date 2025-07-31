using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GISA.Model.Indicador;

public class Indicador1
{
    [Column("Nu_Cpf_Cidadao")]
    public string? NuCpfCidadao { get; set; } = null!;

    [Column("Nu_Cns")]
    public string? NuCns { get; set; } = null!;

    [Column("co_dim_tempo")]
    public int CoDimTempo { get; set; }

    [Column("Co_Dim_Tempo_Dum")]
    public int CoDimTempoDum { get; set; }

    [Column("Nu_Idade_Gestacional_Semanas")]
    public int NuIdadeGestacionalSemanas { get; set; }

    [Column("nome")]
    public string? NoCidadao { get; set; }

}
