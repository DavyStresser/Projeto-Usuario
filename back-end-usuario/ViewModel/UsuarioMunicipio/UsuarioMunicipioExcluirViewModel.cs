using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GISA.Model;

public class UsuarioMunicipioExcluirViewModel
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "O UsuarioId UsuarioMunicipioId ser válido")]
    public int UsuarioMunicipioId { get; set; }
}
