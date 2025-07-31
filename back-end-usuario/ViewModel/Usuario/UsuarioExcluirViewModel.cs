using System.ComponentModel.DataAnnotations;

namespace GISA.ViewModel.Usuario
{
    public class UsuarioExcluirViewModel
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "O UsuarioId precisa ser maior que 0")]
        public int UsuarioId { get; set; }
    }
}
