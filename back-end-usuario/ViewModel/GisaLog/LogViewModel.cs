namespace GISA.ViewModel.GisaLog
{
    public class LogViewModel
    {
        public string TipoEvento { get; set; }
        public int UsuarioId { get; set; }
        public string NomeEvento { get; set; }
        public string DescricaoEvento { get; set; } = "-";
        public DateTime DataEvento { get; set; }
    }
}
