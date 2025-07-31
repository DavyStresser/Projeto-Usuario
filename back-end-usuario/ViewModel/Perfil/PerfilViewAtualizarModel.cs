using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GISA.ViewModel.Perfil;

public class PerfilViewAtualizarModel
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "O PerfilId precisa ser maior que 0")]
    public int PerfilId { get; set; }

    [Required]
    [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Nome precisa ter no mínimo 3 caracteres e máximo de 300")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O Tipo de perfil precisa ser maior que 1")]
    [Range(1, int.MaxValue, ErrorMessage = "O Tipo de perfil precisa ser maior que 1")]
    public int Tipo { get; set; }
}
