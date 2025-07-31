using System.ComponentModel.DataAnnotations;

namespace GISA.ViewModel
{
    public class UsuarioAtualizarViewModel
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "O UsuarioId precisa ser maior que 0")]
        public int UsuarioId { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Cns { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; } 
        public int? PerfilId { get; set; }
    }
}
