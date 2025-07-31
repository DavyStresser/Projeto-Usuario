using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GISA.ViewModel.Acao;

public class AcaoExcluirViewModel
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "O AcaoId precisa ser maior que 0")]
    public int AcaoId { get; set; }
}
