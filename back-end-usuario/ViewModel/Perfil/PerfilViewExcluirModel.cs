using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GISA.ViewModel.Perfil;

public class PerfilViewExcluirModel
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "O PerfilId precisa ser maior que 0")]
    public int PerfilId { get; set; }
}
