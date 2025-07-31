using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GISA.Model;

public class UsuarioMunicipioAdicionarViewModel
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "O UsuarioId precisa ser válido")]
    public int UsuarioId { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "O MunicipioId precisa ser válido")]
    public int MunicipioId { get; set; }
}
