using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Cns { get; set; } = null!;

    public DateTime CriadoEm { get; set; }

    public DateTime? AlteradoEm { get; set; }

    public int CriadoPor { get; set; }

    public int? AlteradoPor { get; set; }

    public bool Deletado { get; set; }

    public string Senha { get; set; } = null!;

    public int PerfilId { get; set; }

    public string Login { get; set; } = null!;

    public virtual ICollection<Acao> AcaoAlteradoPorNavigation { get; } = new List<Acao>();

    public virtual ICollection<AcaoArquivo> AcaoArquivoAlteradoPorNavigation { get; } = new List<AcaoArquivo>();

    public virtual ICollection<AcaoArquivo> AcaoArquivoCriadoPorNavigation { get; } = new List<AcaoArquivo>();

    public virtual ICollection<AcaoAtividade> AcaoAtividadeAlteradoPorNavigation { get; } = new List<AcaoAtividade>();

    public virtual ICollection<AcaoAtividade> AcaoAtividadeCriadoPorNavigation { get; } = new List<AcaoAtividade>();

    public virtual ICollection<Acao> AcaoCriadoPorNavigation { get; } = new List<Acao>();

    public virtual ICollection<AcaoStatus> AcaoStatusAlteradoPorNavigation { get; } = new List<AcaoStatus>();

    public virtual ICollection<AcaoStatus> AcaoStatusCriadoPorNavigation { get; } = new List<AcaoStatus>();

    public virtual ICollection<AcaoUsuario> AcaoUsuarioAlteradoPorNavigation { get; } = new List<AcaoUsuario>();

    public virtual ICollection<AcaoUsuario> AcaoUsuarioCriadoPorNavigation { get; } = new List<AcaoUsuario>();

    public virtual ICollection<AcaoUsuario> AcaoUsuarioUsuario { get; } = new List<AcaoUsuario>();

    public virtual ICollection<Arquivo> ArquivoAlteradoPorNavigation { get; } = new List<Arquivo>();

    public virtual ICollection<Arquivo> ArquivoCriadoPorNavigation { get; } = new List<Arquivo>();

    public virtual ICollection<CicloGestacao> CicloGestacaoAlteradoPorNavigation { get; } = new List<CicloGestacao>();

    public virtual ICollection<CicloGestacao> CicloGestacaoCriadoPorNavigation { get; } = new List<CicloGestacao>();

    public virtual ICollection<Notificacao> Notificacao { get; } = new List<Notificacao>();

    public virtual Perfil Perfil { get; set; } = null!;

    public virtual ICollection<UsuarioMunicipio> UsuarioMunicipio { get; } = new List<UsuarioMunicipio>();
}
