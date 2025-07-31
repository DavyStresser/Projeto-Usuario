using System.ComponentModel.DataAnnotations;

namespace GISA.ViewModel.Usuario
{
    public class UsuarioViewModel
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Cns { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Senha { get; set; } = null!;
        public int PerfilId { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime? AlteradoEm { get; set; }
        public int CriadoPor { get; set; }
        public int? AlteradoPor { get; set; }
    }
}
