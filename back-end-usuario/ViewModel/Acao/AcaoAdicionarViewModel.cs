using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GISA.ViewModel.Acao;

public class AcaoAdicionarViewModel
{
    [Required]
    [StringLength(maximumLength: 500, MinimumLength = 3, ErrorMessage = "Nome precisa ter no mínimo 3 caracteres e máximo de 500")]
    public string Nome { get; set; } = null!;

    [Required]
    [StringLength(maximumLength: 1000000, MinimumLength = 3, ErrorMessage = "Plano precisa ter no mínimo 3 caracteres.")]
    public string Plano { get; set; } = null!;

    [Required]
    [Range(1, long.MaxValue, ErrorMessage = "Informe um custo maior que 0")]
    public decimal Custo { get; set; }

    [Required]
    [Range(1, long.MaxValue, ErrorMessage = "Informe um Prazo maior que 0")]
    public int Prazo { get; set; }

    [Required]
    public DateTime DataInicio { get; set; }

    [Required]
    [Range(1, long.MaxValue, ErrorMessage = "Informe uma Gravidade maior que 0")]
    public int Gravidade { get; set; }

    [Required]
    [Range(1, long.MaxValue, ErrorMessage = "Informe uma Urgencia maior que 0")]
    public int Urgencia { get; set; }

    [Required]
    [Range(1, long.MaxValue, ErrorMessage = "Informe uma Tendencia maior que 0")]
    public int Tendencia { get; set; }

    [Required]
    [Range(1, long.MaxValue, ErrorMessage = "Informe uma status maior que 0")]
    public int AcaoStatusId { get; set; }

    public string? Cidade { get; set; }
}
