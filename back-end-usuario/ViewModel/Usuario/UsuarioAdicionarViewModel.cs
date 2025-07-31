using System.ComponentModel.DataAnnotations;

namespace GISA.ViewModel
{
    public class UsuarioAdicionarViewModel
    {
        [Required]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "Nome precisa ter no mínimo 3 caracteres e máximo de 300")]
        public string Nome { get; set; } = null!;

        [Required]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "Email precisa ter no mínimo 10 caracteres e máximo de 300")]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(300, MinimumLength = 2, ErrorMessage = "CNS precisa ter no mínimo 2 caracteres e máximo de 300")]
        public string Cns { get; set; } = null!;

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Login precisa ter no mínimo 3 caracteres e máximo de 100")]
        public string Login { get; set; } = null!;

        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Senha precisa ter no mínimo 4 caracteres e máximo de 100")]
        public string Senha { get; set; } = null!;

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "O perfil precisa ser maior que 0")]
        public int PerfilId { get; set; }
    }
}
