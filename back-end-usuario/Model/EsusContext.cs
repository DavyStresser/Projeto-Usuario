using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GISA.Model;

public partial class EsusContext : DbContext
{
    public EsusContext()
    {
    }

    public EsusContext(DbContextOptions<EsusContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Acao> Acao { get; set; }

    public virtual DbSet<AcaoArquivo> AcaoArquivo { get; set; }

    public virtual DbSet<AcaoAtividade> AcaoAtividade { get; set; }

    public virtual DbSet<AcaoStatus> AcaoStatus { get; set; }

    public virtual DbSet<AcaoUsuario> AcaoUsuario { get; set; }

    public virtual DbSet<Appsettings> Appsettings { get; set; }

    public virtual DbSet<Arquivo> Arquivo { get; set; }

    public virtual DbSet<ArquivoFinanceiro> ArquivoFinanceiro { get; set; }

    public virtual DbSet<CicloGestacao> CicloGestacao { get; set; }

    public virtual DbSet<CicloGestacaoCategoria> CicloGestacaoCategoria { get; set; }

    public virtual DbSet<CicloGestacaoConfig> CicloGestacaoConfig { get; set; }

    public virtual DbSet<CicloGestacaoPlano> CicloGestacaoPlano { get; set; }

    public virtual DbSet<CicloGestacaoPlanoStatus> CicloGestacaoPlanoStatus { get; set; }

    public virtual DbSet<CicloGestacaoStatus> CicloGestacaoStatus { get; set; }

    public virtual DbSet<CicloGestacaoTema> CicloGestacaoTema { get; set; }

    public virtual DbSet<Csvcadastrosisab> Csvcadastrosisab { get; set; }

    public virtual DbSet<Csvhipertensivossisab> Csvhipertensivossisab { get; set; }

    public virtual DbSet<Gisalog> Gisalog { get; set; }

    public virtual DbSet<Municipio> Municipio { get; set; }

    public virtual DbSet<Notificacao> Notificacao { get; set; }

    public virtual DbSet<Paciente> Paciente { get; set; }

    public virtual DbSet<Perfil> Perfil { get; set; }

    public virtual DbSet<Sqlworker> Sqlworker { get; set; }

    public virtual DbSet<TbDimAleitamento> TbDimAleitamento { get; set; }

    public virtual DbSet<TbDimCatmat> TbDimCatmat { get; set; }

    public virtual DbSet<TbDimCbo> TbDimCbo { get; set; }

    public virtual DbSet<TbDimCiap> TbDimCiap { get; set; }

    public virtual DbSet<TbDimCid> TbDimCid { get; set; }

    public virtual DbSet<TbDimClassificacaoRiscEnc> TbDimClassificacaoRiscEnc { get; set; }

    public virtual DbSet<TbDimDoseFrequencia> TbDimDoseFrequencia { get; set; }

    public virtual DbSet<TbDimDoseFrequenciaMedida> TbDimDoseFrequenciaMedida { get; set; }

    public virtual DbSet<TbDimDuracaoTratamentoMed> TbDimDuracaoTratamentoMed { get; set; }

    public virtual DbSet<TbDimEquipe> TbDimEquipe { get; set; }

    public virtual DbSet<TbDimEspecialidade> TbDimEspecialidade { get; set; }

    public virtual DbSet<TbDimEtnia> TbDimEtnia { get; set; }

    public virtual DbSet<TbDimFaixaEtaria> TbDimFaixaEtaria { get; set; }

    public virtual DbSet<TbDimFrequenciaAlimentacao> TbDimFrequenciaAlimentacao { get; set; }

    public virtual DbSet<TbDimIdentidadeGenero> TbDimIdentidadeGenero { get; set; }

    public virtual DbSet<TbDimLocalAtendimento> TbDimLocalAtendimento { get; set; }

    public virtual DbSet<TbDimModalidadeAd> TbDimModalidadeAd { get; set; }

    public virtual DbSet<TbDimMunicipio> TbDimMunicipio { get; set; }

    public virtual DbSet<TbDimNacionalidade> TbDimNacionalidade { get; set; }

    public virtual DbSet<TbDimPais> TbDimPais { get; set; }

    public virtual DbSet<TbDimPovoComunidadTrad> TbDimPovoComunidadTrad { get; set; }

    public virtual DbSet<TbDimProcedimento> TbDimProcedimento { get; set; }

    public virtual DbSet<TbDimProfissional> TbDimProfissional { get; set; }

    public virtual DbSet<TbDimRacaCor> TbDimRacaCor { get; set; }

    public virtual DbSet<TbDimRacionalidadeSaude> TbDimRacionalidadeSaude { get; set; }

    public virtual DbSet<TbDimSexo> TbDimSexo { get; set; }

    public virtual DbSet<TbDimSituacaoTrabalho> TbDimSituacaoTrabalho { get; set; }

    public virtual DbSet<TbDimTempo> TbDimTempo { get; set; }

    public virtual DbSet<TbDimTempoMoradorRua> TbDimTempoMoradorRua { get; set; }

    public virtual DbSet<TbDimTipoAtendimento> TbDimTipoAtendimento { get; set; }

    public virtual DbSet<TbDimTipoCondicaoPeso> TbDimTipoCondicaoPeso { get; set; }

    public virtual DbSet<TbDimTipoEscolaridade> TbDimTipoEscolaridade { get; set; }

    public virtual DbSet<TbDimTipoFicha> TbDimTipoFicha { get; set; }

    public virtual DbSet<TbDimTipoOrientacaoSexual> TbDimTipoOrientacaoSexual { get; set; }

    public virtual DbSet<TbDimTipoOrigem> TbDimTipoOrigem { get; set; }

    public virtual DbSet<TbDimTipoOrigemDadoTransp> TbDimTipoOrigemDadoTransp { get; set; }

    public virtual DbSet<TbDimTipoParentesco> TbDimTipoParentesco { get; set; }

    public virtual DbSet<TbDimTipoSaidaCadastro> TbDimTipoSaidaCadastro { get; set; }

    public virtual DbSet<TbDimTurno> TbDimTurno { get; set; }

    public virtual DbSet<TbDimUnidadeSaude> TbDimUnidadeSaude { get; set; }

    public virtual DbSet<TbDimViaAdministracao> TbDimViaAdministracao { get; set; }

    public virtual DbSet<TbFatAtdIndEncaminhamentos> TbFatAtdIndEncaminhamentos { get; set; }

    public virtual DbSet<TbFatAtdIndExames> TbFatAtdIndExames { get; set; }

    public virtual DbSet<TbFatAtdIndMedicamentos> TbFatAtdIndMedicamentos { get; set; }

    public virtual DbSet<TbFatAtdIndProblemas> TbFatAtdIndProblemas { get; set; }

    public virtual DbSet<TbFatAtdIndProcedimentos> TbFatAtdIndProcedimentos { get; set; }

    public virtual DbSet<TbFatAtendimentoIndividual> TbFatAtendimentoIndividual { get; set; }

    public virtual DbSet<TbFatCadIndividual> TbFatCadIndividual { get; set; }

    public virtual DbSet<TbFatCidadao> TbFatCidadao { get; set; }

    public virtual DbSet<TbFatCidadaoPec> TbFatCidadaoPec { get; set; }

    public virtual DbSet<TbFatFichas> TbFatFichas { get; set; }

    public virtual DbSet<TbFatProcedAtend> TbFatProcedAtend { get; set; }

    public virtual DbSet<Unidadeequipe> Unidadeequipe { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    public virtual DbSet<UsuarioMunicipio> UsuarioMunicipio { get; set; }

    public virtual DbSet<GiCofinNomesKey> GiCofinNomesKey { get; set; }

    public virtual DbSet<GiCofinNomesCodf> GiCofinNomesCodf { get; set; }

    public virtual DbSet<Vwfichasappterritorio> Vwfichasappterritorio { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=45.232.30.24:5433;Database=esus;user id=postgres;password=-Zp7KcmKvKs_yEfc]tHa{}m65RlU[F;Timeout=120;CommandTimeout=14400");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresExtension("pg_trgm")
            .HasPostgresExtension("postgres_fdw");

        modelBuilder.Entity<Acao>(entity =>
        {
            entity.HasKey(e => e.AcaoId).HasName("Acao_pkey");

            entity.HasIndex(e => e.AcaoStatusId, "FK_Acao_AcaoStatus");

            entity.HasIndex(e => e.CriadoPor, "FK_Acao_Usuario");

            entity.HasIndex(e => e.AlteradoPor, "FK_Acao_Usuario1");

            entity.Property(e => e.AlteradoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Cidade).HasMaxLength(250);
            entity.Property(e => e.CriadoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DataInicio).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Nome).HasMaxLength(500);

            entity.HasOne(d => d.AcaoStatus).WithMany(p => p.Acao)
                .HasForeignKey(d => d.AcaoStatusId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Acao_AcaoStatus");

            entity.HasOne(d => d.AlteradoPorNavigation).WithMany(p => p.AcaoAlteradoPorNavigation)
                .HasForeignKey(d => d.AlteradoPor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Acao_Usuario1");

            entity.HasOne(d => d.CriadoPorNavigation).WithMany(p => p.AcaoCriadoPorNavigation)
                .HasForeignKey(d => d.CriadoPor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Acao_Usuario");
        });

        modelBuilder.Entity<AcaoArquivo>(entity =>
        {
            entity.HasKey(e => e.AcaoArquivoId).HasName("AcaoArquivo_pkey");

            entity.HasIndex(e => e.AcaoId, "FK_AcaoArquivo_Acao");

            entity.HasIndex(e => e.ArquivoId, "FK_AcaoArquivo_Arquivo");

            entity.HasIndex(e => e.CriadoPor, "FK_AcaoArquivo_Usuario");

            entity.HasIndex(e => e.AlteradoPor, "FK_AcaoArquivo_Usuario1");

            entity.Property(e => e.AlteradoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.CriadoEm).HasColumnType("timestamp without time zone");

            entity.HasOne(d => d.Acao).WithMany(p => p.AcaoArquivo)
                .HasForeignKey(d => d.AcaoId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AcaoArquivo_Acao");

            entity.HasOne(d => d.AlteradoPorNavigation).WithMany(p => p.AcaoArquivoAlteradoPorNavigation)
                .HasForeignKey(d => d.AlteradoPor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AcaoArquivo_Usuario1");

            entity.HasOne(d => d.Arquivo).WithMany(p => p.AcaoArquivo)
                .HasForeignKey(d => d.ArquivoId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AcaoArquivo_Arquivo");

            entity.HasOne(d => d.CriadoPorNavigation).WithMany(p => p.AcaoArquivoCriadoPorNavigation)
                .HasForeignKey(d => d.CriadoPor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AcaoArquivo_Usuario");
        });

        modelBuilder.Entity<AcaoAtividade>(entity =>
        {
            entity.HasKey(e => e.AcaoAtividadeId).HasName("AcaoAtividade_pkey");

            entity.HasIndex(e => e.AcaoId, "FK_AcaoAtividade_Acao");

            entity.HasIndex(e => e.CriadoPor, "FK_AcaoAtividade_Usuario");

            entity.HasIndex(e => e.AlteradoPor, "FK_AcaoAtividade_Usuario1");

            entity.Property(e => e.AlteradoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.CriadoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Nome).HasMaxLength(200);

            entity.HasOne(d => d.Acao).WithMany(p => p.AcaoAtividade)
                .HasForeignKey(d => d.AcaoId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AcaoAtividade_Acao");

            entity.HasOne(d => d.AlteradoPorNavigation).WithMany(p => p.AcaoAtividadeAlteradoPorNavigation)
                .HasForeignKey(d => d.AlteradoPor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AcaoAtividade_Usuario1");

            entity.HasOne(d => d.CriadoPorNavigation).WithMany(p => p.AcaoAtividadeCriadoPorNavigation)
                .HasForeignKey(d => d.CriadoPor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AcaoAtividade_Usuario");
        });

        modelBuilder.Entity<AcaoStatus>(entity =>
        {
            entity.HasKey(e => e.AcaoStatusId).HasName("AcaoStatus_pkey");

            entity.HasIndex(e => e.CriadoPor, "FK_AcaoStatus_Usuario");

            entity.HasIndex(e => e.AlteradoPor, "FK_AcaoStatus_Usuario1");

            entity.Property(e => e.AlteradoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.CriadoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Nome).HasMaxLength(500);

            entity.HasOne(d => d.AlteradoPorNavigation).WithMany(p => p.AcaoStatusAlteradoPorNavigation)
                .HasForeignKey(d => d.AlteradoPor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AcaoStatus_Usuario1");

            entity.HasOne(d => d.CriadoPorNavigation).WithMany(p => p.AcaoStatusCriadoPorNavigation)
                .HasForeignKey(d => d.CriadoPor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AcaoStatus_Usuario");
        });

        modelBuilder.Entity<AcaoUsuario>(entity =>
        {
            entity.HasKey(e => e.AcaoUsuarioId).HasName("AcaoUsuario_pkey");

            entity.HasIndex(e => e.AcaoId, "FK_AcaoUsuario_Acao");

            entity.HasIndex(e => e.CriadoPor, "FK_AcaoUsuario_Usuario");

            entity.HasIndex(e => e.AlteradoPor, "FK_AcaoUsuario_Usuario1");

            entity.HasIndex(e => e.UsuarioId, "FK_AcaoUsuario_Usuario2");

            entity.Property(e => e.AlteradoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.CriadoEm).HasColumnType("timestamp without time zone");

            entity.HasOne(d => d.Acao).WithMany(p => p.AcaoUsuario)
                .HasForeignKey(d => d.AcaoId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AcaoUsuario_Acao");

            entity.HasOne(d => d.AlteradoPorNavigation).WithMany(p => p.AcaoUsuarioAlteradoPorNavigation)
                .HasForeignKey(d => d.AlteradoPor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AcaoUsuario_Usuario1");

            entity.HasOne(d => d.CriadoPorNavigation).WithMany(p => p.AcaoUsuarioCriadoPorNavigation)
                .HasForeignKey(d => d.CriadoPor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AcaoUsuario_Usuario");

            entity.HasOne(d => d.Usuario).WithMany(p => p.AcaoUsuarioUsuario)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AcaoUsuario_Usuario2");
        });

        modelBuilder.Entity<Appsettings>(entity =>
        {
            entity.HasKey(e => e.Appsettingsid).HasName("appsettings_pkey");

            entity.ToTable("appsettings");

            entity.Property(e => e.Appsettingsid).HasColumnName("appsettingsid");
            entity.Property(e => e.Descricao)
                .HasMaxLength(1000)
                .HasColumnName("descricao");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
        });

        modelBuilder.Entity<Arquivo>(entity =>
        {
            entity.HasKey(e => e.ArquivoId).HasName("Arquivo_pkey");

            entity.HasIndex(e => e.CriadoPor, "FK_Arquivo_Usuario");

            entity.HasIndex(e => e.AlteradoPor, "FK_Arquivo_Usuario1");

            entity.Property(e => e.AlteradoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.CriadoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Nome).HasMaxLength(300);
            entity.Property(e => e.Url).HasMaxLength(1000);

            entity.HasOne(d => d.AlteradoPorNavigation).WithMany(p => p.ArquivoAlteradoPorNavigation)
                .HasForeignKey(d => d.AlteradoPor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Arquivo_Usuario1");

            entity.HasOne(d => d.CriadoPorNavigation).WithMany(p => p.ArquivoCriadoPorNavigation)
                .HasForeignKey(d => d.CriadoPor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Arquivo_Usuario");
        });

        modelBuilder.Entity<ArquivoFinanceiro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ArquivoFinanceiro_pkey");

            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .HasDefaultValueSql("NULL::character varying");
            entity.Property(e => e.Parcela)
                .HasMaxLength(100)
                .HasDefaultValueSql("NULL::character varying");
        });

        modelBuilder.Entity<CicloGestacao>(entity =>
        {
            entity.HasKey(e => e.CicloGestacaoId).HasName("CicloGestacao_pkey");

            entity.HasIndex(e => e.CicloGestacaoPlanoId, "FK_CicloGestacao_CicloGestacaoPlano");

            entity.HasIndex(e => e.CicloGestacaoStatusId, "FK_CicloGestacao_CicloGestacaoStatus");

            entity.HasIndex(e => e.CicloGestacaoTemaId, "FK_CicloGestacao_CicloGestacaoTema");

            entity.HasIndex(e => e.AlteradoPor, "FK_CicloGestacao_Usuario");

            entity.HasIndex(e => e.CriadoPor, "FK_CicloGestacao_Usuario1");

            entity.Property(e => e.AlteradoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.CriadoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DataFinal).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DataInicio).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Observacao)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying");

            entity.HasOne(d => d.AlteradoPorNavigation).WithMany(p => p.CicloGestacaoAlteradoPorNavigation)
                .HasForeignKey(d => d.AlteradoPor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CicloGestacao_Usuario");

            entity.HasOne(d => d.CicloGestacaoPlano).WithMany(p => p.CicloGestacao)
                .HasForeignKey(d => d.CicloGestacaoPlanoId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CicloGestacao_CicloGestacaoPlano");

            entity.HasOne(d => d.CicloGestacaoStatus).WithMany(p => p.CicloGestacao)
                .HasForeignKey(d => d.CicloGestacaoStatusId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CicloGestacao_CicloGestacaoStatus");

            entity.HasOne(d => d.CicloGestacaoTema).WithMany(p => p.CicloGestacao)
                .HasForeignKey(d => d.CicloGestacaoTemaId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CicloGestacao_CicloGestacaoTema");

            entity.HasOne(d => d.CriadoPorNavigation).WithMany(p => p.CicloGestacaoCriadoPorNavigation)
                .HasForeignKey(d => d.CriadoPor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CicloGestacao_Usuario1");
        });

        modelBuilder.Entity<CicloGestacaoCategoria>(entity =>
        {
            entity.HasKey(e => e.CicloGestacaoCategoriaId).HasName("CicloGestacaoCategoria_pkey");

            entity.Property(e => e.Nome).HasMaxLength(50);
        });

        modelBuilder.Entity<CicloGestacaoConfig>(entity =>
        {
            entity.HasKey(e => e.CicloGestacaoConfigId).HasName("CicloGestacaoConfig_pkey");

            entity.HasIndex(e => e.CicloGestacaoTemaId, "FK_CicloGestacaoConfig_CicloGestacaoTema");

            entity.HasOne(d => d.CicloGestacaoTema).WithMany(p => p.CicloGestacaoConfig)
                .HasForeignKey(d => d.CicloGestacaoTemaId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CicloGestacaoConfig_CicloGestacaoTema");
        });

        modelBuilder.Entity<CicloGestacaoPlano>(entity =>
        {
            entity.HasKey(e => e.CicloGestacaoPlanoId).HasName("CicloGestacaoPlano_pkey");

            entity.HasIndex(e => e.CicloGestacaoPlanoStatusId, "FK_CicloGestacaoPlano_CicloGestacaoPlanoStatus");

            entity.HasIndex(e => e.PacienteId, "FK_CicloGestacaoPlano_Paciente");

            entity.Property(e => e.AlteradoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.CriadoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DataInicio).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DataTermino).HasColumnType("timestamp without time zone");

            entity.HasOne(d => d.CicloGestacaoPlanoStatus).WithMany(p => p.CicloGestacaoPlano)
                .HasForeignKey(d => d.CicloGestacaoPlanoStatusId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CicloGestacaoPlano_CicloGestacaoPlanoStatus");

            entity.HasOne(d => d.Paciente).WithMany(p => p.CicloGestacaoPlano)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CicloGestacaoPlano_Paciente");
        });

        modelBuilder.Entity<CicloGestacaoPlanoStatus>(entity =>
        {
            entity.HasKey(e => e.CicloGestacaoPlanoStatusId).HasName("CicloGestacaoPlanoStatus_pkey");

            entity.Property(e => e.Nome).HasMaxLength(50);
        });

        modelBuilder.Entity<CicloGestacaoStatus>(entity =>
        {
            entity.HasKey(e => e.CicloGestacaoStatusId).HasName("CicloGestacaoStatus_pkey");

            entity.Property(e => e.Nome).HasMaxLength(50);
        });

        modelBuilder.Entity<CicloGestacaoTema>(entity =>
        {
            entity.HasKey(e => e.CicloGestacaoTemaId).HasName("CicloGestacaoTema_pkey");

            entity.HasIndex(e => e.CicloGestacaoCategoriaId, "FK_CicloGestacaoTema_CicloGestacaoCategoria");

            entity.Property(e => e.Codigo).HasMaxLength(20);
            entity.Property(e => e.Nome).HasMaxLength(200);

            entity.HasOne(d => d.CicloGestacaoCategoria).WithMany(p => p.CicloGestacaoTema)
                .HasForeignKey(d => d.CicloGestacaoCategoriaId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CicloGestacaoTema_CicloGestacaoCategoria");
        });

        modelBuilder.Entity<Csvcadastrosisab>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("csvcadastrosisab_pkey");

            entity.ToTable("csvcadastrosisab");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dsponderacao)
                .HasMaxLength(50)
                .HasColumnName("dsponderacao");
            entity.Property(e => e.Dssexo)
                .HasMaxLength(1)
                .HasColumnName("dssexo");
            entity.Property(e => e.Dtnascimento).HasColumnName("dtnascimento");
            entity.Property(e => e.Dtrecente).HasColumnName("dtrecente");
            entity.Property(e => e.Nonome)
                .HasMaxLength(255)
                .HasColumnName("nonome");
            entity.Property(e => e.Nuano).HasColumnName("nuano");
            entity.Property(e => e.Nucns)
                .HasMaxLength(15)
                .HasColumnName("nucns");
            entity.Property(e => e.Nucpfcidadao)
                .HasMaxLength(11)
                .HasColumnName("nucpfcidadao");
            entity.Property(e => e.Nuequipe)
                .HasMaxLength(20)
                .HasColumnName("nuequipe");
            entity.Property(e => e.Nuidade).HasColumnName("nuidade");
            entity.Property(e => e.Nuquadrimestre).HasColumnName("nuquadrimestre");
            entity.Property(e => e.Qtatendimentos).HasColumnName("qtatendimentos");
            entity.Property(e => e.Tpidentificacao)
                .HasMaxLength(50)
                .HasColumnName("tpidentificacao");
        });

        modelBuilder.Entity<Csvhipertensivossisab>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("csvhipertensivossisab_pkey");

            entity.ToTable("csvhipertensivossisab");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dsautorreferido)
                .HasMaxLength(50)
                .HasColumnName("dsautorreferido");
            entity.Property(e => e.Dsavaliada)
                .HasMaxLength(50)
                .HasColumnName("dsavaliada");
            entity.Property(e => e.Dsnumerador)
                .HasMaxLength(50)
                .HasColumnName("dsnumerador");
            entity.Property(e => e.Dtafericaopa).HasColumnName("dtafericaopa");
            entity.Property(e => e.Dtatendimento).HasColumnName("dtatendimento");
            entity.Property(e => e.Dtnascimento).HasColumnName("dtnascimento");
            entity.Property(e => e.Nonome)
                .HasMaxLength(255)
                .HasColumnName("nonome");
            entity.Property(e => e.Nuano).HasColumnName("nuano");
            entity.Property(e => e.Nucns)
                .HasMaxLength(15)
                .HasColumnName("nucns");
            entity.Property(e => e.Nucpfcidadao)
                .HasMaxLength(11)
                .HasColumnName("nucpfcidadao");
            entity.Property(e => e.Nuequipe)
                .HasMaxLength(20)
                .HasColumnName("nuequipe");
            entity.Property(e => e.Nuquadrimestre).HasColumnName("nuquadrimestre");
        });

        modelBuilder.Entity<Gisalog>(entity =>
        {
            entity.HasKey(e => e.Eventoid).HasName("gisalog_pkey");

            entity.ToTable("gisalog");

            entity.Property(e => e.Eventoid).HasColumnName("eventoid");
            entity.Property(e => e.Dataevento)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataevento");
            entity.Property(e => e.Descricaoevento).HasColumnName("descricaoevento");
            entity.Property(e => e.Nomeevento)
                .HasMaxLength(255)
                .HasColumnName("nomeevento");
            entity.Property(e => e.Tipoevento)
                .HasMaxLength(255)
                .HasColumnName("tipoevento");
            entity.Property(e => e.Usuarioid).HasColumnName("usuarioid");
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.MunicipioId).HasName("Municipio_pkey");

            entity.Property(e => e.Codigo).HasMaxLength(100);
            entity.Property(e => e.Nome).HasMaxLength(100);
        });

        modelBuilder.Entity<Notificacao>(entity =>
        {
            entity.HasKey(e => e.NotificacaoId).HasName("Notificacao_pkey");

            entity.HasIndex(e => e.UsuarioId, "FK_Notificacao_Usuario");

            entity.Property(e => e.CriadoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Descricao).HasMaxLength(500);
            entity.Property(e => e.Nome).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Url).HasMaxLength(500);

            entity.HasOne(d => d.Usuario).WithMany(p => p.Notificacao)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Notificacao_Usuario");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.PacienteId).HasName("Paciente_pkey");

            entity.Property(e => e.DataNascimento).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Gender).HasMaxLength(256);
            entity.Property(e => e.NomeCompleto).HasMaxLength(256);
            entity.Property(e => e.NomeEquipe).HasMaxLength(256);
            entity.Property(e => e.NomeUnidade).HasMaxLength(256);
            entity.Property(e => e.NumeroCpf).HasMaxLength(30);
            entity.Property(e => e.Uuid).HasMaxLength(130);
        });

        modelBuilder.Entity<Perfil>(entity =>
        {
            entity.HasKey(e => e.PerfilId).HasName("Perfil_pkey");

            entity.Property(e => e.Nome).HasMaxLength(100);
        });

        modelBuilder.Entity<Sqlworker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sqlworker_pkey");

            entity.ToTable("sqlworker");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comandosql)
                .HasMaxLength(2000)
                .HasColumnName("comandosql");
            entity.Property(e => e.Ordem).HasColumnName("ordem");
            entity.Property(e => e.Periododeexec).HasColumnName("periododeexec");
        });

        modelBuilder.Entity<TbDimAleitamento>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimAleitamento).HasName("pk_dimaleitamento");

            entity.ToTable("tb_dim_aleitamento");

            entity.Property(e => e.CoSeqDimAleitamento)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_aleitamento");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsAleitamento)
                .HasMaxLength(500)
                .HasColumnName("ds_aleitamento");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimCatmat>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimCatmat).HasName("tb_dim_catmat_pkey");

            entity.ToTable("tb_dim_catmat", tb => tb.HasComment("Armazena as dimensões usadas pelo DW da TB_CATMAT"));

            entity.Property(e => e.CoSeqDimCatmat)
                .ValueGeneratedNever()
                .HasComment("Sequence da tabela TB_DIM_CATMAT")
                .HasColumnName("co_seq_dim_catmat");
            entity.Property(e => e.CoCatmat)
                .HasMaxLength(20)
                .HasColumnName("co_catmat");
            entity.Property(e => e.CoDimFormaFarmaceutica).HasColumnName("co_dim_forma_farmaceutica");
            entity.Property(e => e.DsConcentracao)
                .HasMaxLength(200)
                .HasComment("Descrição da concentração que o medicamento é distribuido")
                .HasColumnName("ds_concentracao");
            entity.Property(e => e.DsUnidadeFornecimento)
                .HasMaxLength(200)
                .HasComment("Descrição da forma como o medicamento é fornecido")
                .HasColumnName("ds_unidade_fornecimento");
            entity.Property(e => e.NoPrincipioAtivo)
                .HasMaxLength(400)
                .HasComment("Nome do princípio ativo")
                .HasColumnName("no_principio_ativo");
            entity.Property(e => e.StRegistroValido)
                .HasComment("Indica se o registro é valido ou não")
                .HasColumnName("st_registro_valido");
        });

        modelBuilder.Entity<TbDimCbo>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimCbo).HasName("pk_dimcbo");

            entity.ToTable("tb_dim_cbo");

            entity.Property(e => e.CoSeqDimCbo)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_cbo");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.NoCbo)
                .HasMaxLength(500)
                .HasColumnName("no_cbo");
            entity.Property(e => e.NuCbo)
                .HasMaxLength(20)
                .HasColumnName("nu_cbo");
            entity.Property(e => e.StRegistroValido).HasColumnName("st_registro_valido");
        });

        modelBuilder.Entity<TbDimCiap>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimCiap).HasName("pk_dimciap");

            entity.ToTable("tb_dim_ciap");

            entity.HasIndex(e => e.NuCiap, "in_dimciap_nucip");

            entity.Property(e => e.CoSeqDimCiap)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_ciap");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.NoCiap)
                .HasMaxLength(500)
                .HasColumnName("no_ciap");
            entity.Property(e => e.NuCiap)
                .HasMaxLength(10)
                .HasColumnName("nu_ciap");
            entity.Property(e => e.StRegistroValido).HasColumnName("st_registro_valido");
        });

        modelBuilder.Entity<TbDimCid>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimCid).HasName("pk_dimcid");

            entity.ToTable("tb_dim_cid");

            entity.HasIndex(e => e.NuCid, "in_dimcid_nucid");

            entity.Property(e => e.CoSeqDimCid)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_cid");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.NoCid)
                .HasMaxLength(500)
                .HasColumnName("no_cid");
            entity.Property(e => e.NuCid)
                .HasMaxLength(10)
                .HasColumnName("nu_cid");
            entity.Property(e => e.StAtivo).HasColumnName("st_ativo");
            entity.Property(e => e.StRegistroValido).HasColumnName("st_registro_valido");
        });

        modelBuilder.Entity<TbDimClassificacaoRiscEnc>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimClassificRiscEnc).HasName("tb_dim_classificacao_risc_enc_pkey");

            entity.ToTable("tb_dim_classificacao_risc_enc", tb => tb.HasComment("Armazena as dimensões usadas pelo DW da TB_CLASSIFICACAO_RISCO"));

            entity.Property(e => e.CoSeqDimClassificRiscEnc)
                .ValueGeneratedNever()
                .HasComment("Sequence da tabela TB_DIM_CLASSIFICAO_RISCO")
                .HasColumnName("co_seq_dim_classific_risc_enc");
            entity.Property(e => e.CoClassificacaoRisco).HasColumnName("co_classificacao_risco");
            entity.Property(e => e.CoOrdem)
                .HasComment("Indica a ordem que o registro irá aparece nas listagens")
                .HasColumnName("co_ordem");
            entity.Property(e => e.NoClassificacaoRisco)
                .HasMaxLength(255)
                .HasComment("Nome da forma farmaceutica")
                .HasColumnName("no_classificacao_risco");
            entity.Property(e => e.NoClassificacaoRiscoFiltro)
                .HasMaxLength(255)
                .HasColumnName("no_classificacao_risco_filtro");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimDoseFrequencia>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimDoseFrequencia).HasName("tb_dim_dose_frequencia_pkey");

            entity.ToTable("tb_dim_dose_frequencia", tb => tb.HasComment("Armazena as dimensões usadas pelo DW da TB_VIA_ADM_VACINA"));

            entity.Property(e => e.CoSeqDimDoseFrequencia)
                .ValueGeneratedNever()
                .HasComment("Sequence da tabela TB_DIM_DOSE_FREQUENCIA")
                .HasColumnName("co_seq_dim_dose_frequencia");
            entity.Property(e => e.CoOrdem)
                .HasComment("Indica a ordem que o registro irá aparece nas listagens")
                .HasColumnName("co_ordem");
            entity.Property(e => e.NoDoseFrequencia)
                .HasMaxLength(255)
                .HasComment("Nome da forma farmaceutica")
                .HasColumnName("no_dose_frequencia");
            entity.Property(e => e.NoDoseFrequenciaFiltro)
                .HasMaxLength(255)
                .HasColumnName("no_dose_frequencia_filtro");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimDoseFrequenciaMedida>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimDoseFrequenciaMed).HasName("tb_dim_dose_frequencia_medida_pkey");

            entity.ToTable("tb_dim_dose_frequencia_medida", tb => tb.HasComment("Armazena as dimensões usadas pelo DW da TB_VIA_ADM_VACINA"));

            entity.Property(e => e.CoSeqDimDoseFrequenciaMed)
                .ValueGeneratedNever()
                .HasComment("Sequence da tabela TB_DIM_DOSE_FREQUENCIA_MEDIDA")
                .HasColumnName("co_seq_dim_dose_frequencia_med");
            entity.Property(e => e.CoOrdem)
                .HasComment("Indica a ordem que o registro irá aparece nas listagens")
                .HasColumnName("co_ordem");
            entity.Property(e => e.NoDoseFrequenciaMedida)
                .HasMaxLength(255)
                .HasComment("Nome da forma farmaceutica")
                .HasColumnName("no_dose_frequencia_medida");
            entity.Property(e => e.NoDoseFrequenciaMedidaFilt)
                .HasMaxLength(255)
                .HasColumnName("no_dose_frequencia_medida_filt");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimDuracaoTratamentoMed>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimDuracaoTratMed).HasName("tb_dim_duracao_tratamento_med_pkey");

            entity.ToTable("tb_dim_duracao_tratamento_med", tb => tb.HasComment("Armazena as dimensões usadas pelo DW de medidas da duração de tratamento"));

            entity.Property(e => e.CoSeqDimDuracaoTratMed)
                .ValueGeneratedNever()
                .HasComment("Sequence da tabela TB_DIM_DURACAO_TRATAMENTO_MED")
                .HasColumnName("co_seq_dim_duracao_trat_med");
            entity.Property(e => e.CoOrdem)
                .HasComment("Indica a ordem que o registro irá aparece nas listagens")
                .HasColumnName("co_ordem");
            entity.Property(e => e.NoDuracaoTratamentoMed)
                .HasMaxLength(255)
                .HasComment("Nome da forma farmaceutica")
                .HasColumnName("no_duracao_tratamento_med");
            entity.Property(e => e.NoDuracaoTratamentoMedFilt)
                .HasMaxLength(255)
                .HasColumnName("no_duracao_tratamento_med_filt");
            entity.Property(e => e.NuDuracaoTratamentoMed).HasColumnName("nu_duracao_tratamento_med");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimEquipe>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimEquipe).HasName("pk_dimequipe");

            entity.ToTable("tb_dim_equipe");

            entity.HasIndex(e => e.NuIne, "in_dim_equipe_ine");

            entity.Property(e => e.CoSeqDimEquipe)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_equipe");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.NoEquipe)
                .HasMaxLength(255)
                .HasColumnName("no_equipe");
            entity.Property(e => e.NuIne)
                .HasMaxLength(20)
                .HasColumnName("nu_ine");
            entity.Property(e => e.StRegistroValido).HasColumnName("st_registro_valido");
        });

        modelBuilder.Entity<TbDimEspecialidade>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimEspecialidade).HasName("tb_dim_especialidade_pkey");

            entity.ToTable("tb_dim_especialidade", tb => tb.HasComment("Armazena as dimensões usadas pelo DW da TB_ESPECIALIDADE_SISREG"));

            entity.Property(e => e.CoSeqDimEspecialidade)
                .ValueGeneratedNever()
                .HasComment("Sequence da tabela TB_DIM_ESPECIALIDADE")
                .HasColumnName("co_seq_dim_especialidade");
            entity.Property(e => e.CoEspecialidade)
                .HasMaxLength(100)
                .HasColumnName("co_especialidade");
            entity.Property(e => e.DsEspecialidade)
                .HasMaxLength(100)
                .HasColumnName("ds_especialidade");
            entity.Property(e => e.DsEspecialidadeFiltro)
                .HasMaxLength(100)
                .HasColumnName("ds_especialidade_filtro");
            entity.Property(e => e.StRegistroValido)
                .HasComment("Indica se o registro é valido ou não")
                .HasColumnName("st_registro_valido");
        });

        modelBuilder.Entity<TbDimEtnia>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimEtnia).HasName("pk_dimetnia");

            entity.ToTable("tb_dim_etnia");

            entity.Property(e => e.CoSeqDimEtnia)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_etnia");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.NoEtnia)
                .HasMaxLength(500)
                .HasColumnName("no_etnia");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimFaixaEtaria>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimFaixaEtaria).HasName("pk_dimfaixaetaria");

            entity.ToTable("tb_dim_faixa_etaria");

            entity.Property(e => e.CoSeqDimFaixaEtaria)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_faixa_etaria");
            entity.Property(e => e.DsFaixaEtaria)
                .HasMaxLength(500)
                .HasColumnName("ds_faixa_etaria");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.NuFaixaFinalAnos).HasColumnName("nu_faixa_final_anos");
            entity.Property(e => e.NuFaixaInicialAnos).HasColumnName("nu_faixa_inicial_anos");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimFrequenciaAlimentacao>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimFrequenciaAliment).HasName("pk_dimfrequenciaalimentacao");

            entity.ToTable("tb_dim_frequencia_alimentacao");

            entity.Property(e => e.CoSeqDimFrequenciaAliment)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_frequencia_aliment");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsDimFrequenciaAlimentacao)
                .HasMaxLength(500)
                .HasColumnName("ds_dim_frequencia_alimentacao");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimIdentidadeGenero>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimIdentidadeGenero).HasName("pk_dimidentidadegenerol");

            entity.ToTable("tb_dim_identidade_genero");

            entity.Property(e => e.CoSeqDimIdentidadeGenero)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_identidade_genero");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsIdentidadeGenero)
                .HasMaxLength(500)
                .HasColumnName("ds_identidade_genero");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimLocalAtendimento>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimLocalAtendimento).HasName("pk_dimlocalatendimento");

            entity.ToTable("tb_dim_local_atendimento");

            entity.Property(e => e.CoSeqDimLocalAtendimento)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_local_atendimento");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.DsLocalAtendimento)
                .HasMaxLength(500)
                .HasColumnName("ds_local_atendimento");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimModalidadeAd>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimModalidadeAd).HasName("pk_dimmodalidadead");

            entity.ToTable("tb_dim_modalidade_ad");

            entity.Property(e => e.CoSeqDimModalidadeAd)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_modalidade_ad");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsModalidadeAd)
                .HasMaxLength(500)
                .HasColumnName("ds_modalidade_ad");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimMunicipio>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimMunicipio).HasName("pk_dimmunicipio");

            entity.ToTable("tb_dim_municipio");

            entity.Property(e => e.CoSeqDimMunicipio)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_municipio");
            entity.Property(e => e.CoDimUf).HasColumnName("co_dim_uf");
            entity.Property(e => e.CoIbge)
                .HasMaxLength(10)
                .HasColumnName("co_ibge");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.NoMunicipio)
                .HasMaxLength(500)
                .HasColumnName("no_municipio");
            entity.Property(e => e.StRegistroValido).HasColumnName("st_registro_valido");
        });

        modelBuilder.Entity<TbDimNacionalidade>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimNacionalidade).HasName("pk_dimnacionalidade");

            entity.ToTable("tb_dim_nacionalidade");

            entity.Property(e => e.CoSeqDimNacionalidade)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_nacionalidade");
            entity.Property(e => e.CoNacionalidade)
                .HasMaxLength(2)
                .HasColumnName("co_nacionalidade");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsNacionalidade)
                .HasMaxLength(100)
                .HasColumnName("ds_nacionalidade");
            entity.Property(e => e.NoIdentificador)
                .HasMaxLength(100)
                .HasColumnName("no_identificador");
        });

        modelBuilder.Entity<TbDimPais>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimPais).HasName("pk_dimpais");

            entity.ToTable("tb_dim_pais");

            entity.Property(e => e.CoSeqDimPais)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_pais");
            entity.Property(e => e.CoCadsus)
                .HasMaxLength(6)
                .HasColumnName("co_cadsus");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.NoPais)
                .HasMaxLength(500)
                .HasColumnName("no_pais");
            entity.Property(e => e.StRegistroValido).HasColumnName("st_registro_valido");
        });

        modelBuilder.Entity<TbDimPovoComunidadTrad>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimPovoComunidadTrad).HasName("pk_dimPovoComunidadTrad");

            entity.ToTable("tb_dim_povo_comunidad_trad");

            entity.Property(e => e.CoSeqDimPovoComunidadTrad)
                .ValueGeneratedNever()
                .HasComment("Código sequencial da tabela.")
                .HasColumnName("co_seq_dim_povo_comunidad_trad");
            entity.Property(e => e.DsPovoComunidadeTradicional)
                .HasMaxLength(100)
                .HasComment("Nome do povo ou comunidade tradicional")
                .HasColumnName("ds_povo_comunidade_tradicional");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(10)
                .HasComment("Número identificador")
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimProcedimento>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimProcedimento).HasName("pk_dimproced");

            entity.ToTable("tb_dim_procedimento");

            entity.HasIndex(e => e.CoProced, "in_dimproced_coproced");

            entity.Property(e => e.CoSeqDimProcedimento)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_procedimento");
            entity.Property(e => e.CoPai).HasColumnName("co_pai");
            entity.Property(e => e.CoProced)
                .HasMaxLength(100)
                .HasColumnName("co_proced");
            entity.Property(e => e.CoSeqDimProcedRefAb).HasColumnName("co_seq_dim_proced_ref_ab");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(350)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.DsProced)
                .HasMaxLength(500)
                .HasColumnName("ds_proced");
            entity.Property(e => e.StRegistroValido).HasColumnName("st_registro_valido");

            entity.HasOne(d => d.CoPaiNavigation).WithMany(p => p.InverseCoPaiNavigation)
                .HasForeignKey(d => d.CoPai)
                .HasConstraintName("fk_dimproced_dimproced");
        });

        modelBuilder.Entity<TbDimProfissional>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimProfissional).HasName("pk_dimprofissional");

            entity.ToTable("tb_dim_profissional");

            entity.HasIndex(e => e.NuCns, "in_dimprof_nucns");

            entity.Property(e => e.CoSeqDimProfissional)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_profissional");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.NoProfissional)
                .HasMaxLength(255)
                .HasColumnName("no_profissional");
            entity.Property(e => e.NuCns)
                .HasMaxLength(15)
                .HasColumnName("nu_cns");
            entity.Property(e => e.StRegistroValido).HasColumnName("st_registro_valido");
        });

        modelBuilder.Entity<TbDimRacaCor>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimRacaCor).HasName("pk_dimracacor");

            entity.ToTable("tb_dim_raca_cor");

            entity.Property(e => e.CoSeqDimRacaCor)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_raca_cor");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsRacaCor)
                .HasMaxLength(500)
                .HasColumnName("ds_raca_cor");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(50)
                .HasColumnName("nu_identificador");
            entity.Property(e => e.NuMs)
                .HasMaxLength(50)
                .HasColumnName("nu_ms");
        });

        modelBuilder.Entity<TbDimRacionalidadeSaude>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimRacionalidadeSaude).HasName("pk_dimracionalidadesaude");

            entity.ToTable("tb_dim_racionalidade_saude");

            entity.Property(e => e.CoSeqDimRacionalidadeSaude)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_racionalidade_saude");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.NoRacionalidadeSaude)
                .HasMaxLength(500)
                .HasColumnName("no_racionalidade_saude");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimSexo>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimSexo).HasName("pk_dimsexo");

            entity.ToTable("tb_dim_sexo");

            entity.Property(e => e.CoSeqDimSexo)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_sexo");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsSexo)
                .HasMaxLength(100)
                .HasColumnName("ds_sexo");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
            entity.Property(e => e.SgSexo)
                .HasMaxLength(100)
                .HasColumnName("sg_sexo");
        });

        modelBuilder.Entity<TbDimSituacaoTrabalho>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimSituacaoTrabalho).HasName("pk_dimsituacaotrabalho");

            entity.ToTable("tb_dim_situacao_trabalho");

            entity.Property(e => e.CoSeqDimSituacaoTrabalho)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_situacao_trabalho");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsDimSituacaoTrabalho)
                .HasMaxLength(500)
                .HasColumnName("ds_dim_situacao_trabalho");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimTempo>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimTempo).HasName("pk_dimtempo");

            entity.ToTable("tb_dim_tempo");

            entity.Property(e => e.CoSeqDimTempo)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_tempo");
            entity.Property(e => e.DsDiaSemana)
                .HasMaxLength(100)
                .HasColumnName("ds_dia_semana");
            entity.Property(e => e.DtRegistro).HasColumnName("dt_registro");
            entity.Property(e => e.NuAno).HasColumnName("nu_ano");
            entity.Property(e => e.NuDia).HasColumnName("nu_dia");
            entity.Property(e => e.NuMes).HasColumnName("nu_mes");
        });

        modelBuilder.Entity<TbDimTempoMoradorRua>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimTempoMoradorRua).HasName("pk_dimtempomoradorrua");

            entity.ToTable("tb_dim_tempo_morador_rua");

            entity.Property(e => e.CoSeqDimTempoMoradorRua)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_tempo_morador_rua");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsDimTempoMoradorRua)
                .HasMaxLength(500)
                .HasColumnName("ds_dim_tempo_morador_rua");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimTipoAtendimento>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimTipoAtendimento).HasName("pk_dimtipoatendimento");

            entity.ToTable("tb_dim_tipo_atendimento");

            entity.Property(e => e.CoSeqDimTipoAtendimento)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_tipo_atendimento");
            entity.Property(e => e.CoDimTipoAtendimentoPai).HasColumnName("co_dim_tipo_atendimento_pai");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.DsTipoAtendimento)
                .HasMaxLength(500)
                .HasColumnName("ds_tipo_atendimento");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");

            entity.HasOne(d => d.CoDimTipoAtendimentoPaiNavigation).WithMany(p => p.InverseCoDimTipoAtendimentoPaiNavigation)
                .HasForeignKey(d => d.CoDimTipoAtendimentoPai)
                .HasConstraintName("fk_dimtipoatend_dimtipoatend");
        });

        modelBuilder.Entity<TbDimTipoCondicaoPeso>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimTipoCondicaoPeso).HasName("pk_dimtipocondicaopeso");

            entity.ToTable("tb_dim_tipo_condicao_peso");

            entity.Property(e => e.CoSeqDimTipoCondicaoPeso)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_tipo_condicao_peso");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsDimTipoCondicaoPeso)
                .HasMaxLength(500)
                .HasColumnName("ds_dim_tipo_condicao_peso");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimTipoEscolaridade>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimTipoEscolaridade).HasName("pk_dimtipoescolaridade");

            entity.ToTable("tb_dim_tipo_escolaridade");

            entity.Property(e => e.CoSeqDimTipoEscolaridade)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_tipo_escolaridade");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsDimTipoEscolaridade)
                .HasMaxLength(500)
                .HasColumnName("ds_dim_tipo_escolaridade");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimTipoFicha>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimTipoFicha).HasName("pk_dimtipoficha");

            entity.ToTable("tb_dim_tipo_ficha");

            entity.Property(e => e.CoSeqDimTipoFicha)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_tipo_ficha");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.DsTipoFicha)
                .HasMaxLength(500)
                .HasColumnName("ds_tipo_ficha");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimTipoOrientacaoSexual>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimTipoOrientacaoSxl).HasName("pk_dimtipoorientacaosexual");

            entity.ToTable("tb_dim_tipo_orientacao_sexual");

            entity.Property(e => e.CoSeqDimTipoOrientacaoSxl)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_tipo_orientacao_sxl");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsDimTipoOrientacaoSexual)
                .HasMaxLength(500)
                .HasColumnName("ds_dim_tipo_orientacao_sexual");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimTipoOrigem>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimTipoOrigem).HasName("pk_dimtporigem");

            entity.ToTable("tb_dim_tipo_origem");

            entity.Property(e => e.CoSeqDimTipoOrigem)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_tipo_origem");
            entity.Property(e => e.NoTipoOrigem)
                .HasMaxLength(255)
                .HasColumnName("no_tipo_origem");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(255)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimTipoOrigemDadoTransp>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimTpOrgmDadoTransp).HasName("pk_dimtporgmddtrnsp");

            entity.ToTable("tb_dim_tipo_origem_dado_transp");

            entity.Property(e => e.CoSeqDimTpOrgmDadoTransp)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_tp_orgm_dado_transp");
            entity.Property(e => e.NoTipoOrigemDadoTransp)
                .HasMaxLength(255)
                .HasColumnName("no_tipo_origem_dado_transp");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(255)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimTipoParentesco>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimTipoParentesco).HasName("pk_dimtipoparentesco");

            entity.ToTable("tb_dim_tipo_parentesco");

            entity.Property(e => e.CoSeqDimTipoParentesco)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_tipo_parentesco");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.DsTipoParentesco)
                .HasMaxLength(500)
                .HasColumnName("ds_tipo_parentesco");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimTipoSaidaCadastro>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimTipoSaidaCadastro).HasName("pk_dimtiposaidacadastro");

            entity.ToTable("tb_dim_tipo_saida_cadastro");

            entity.Property(e => e.CoSeqDimTipoSaidaCadastro)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_tipo_saida_cadastro");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsDimTipoSaidaCadastro)
                .HasMaxLength(500)
                .HasColumnName("ds_dim_tipo_saida_cadastro");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimTurno>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimTurno).HasName("pk_dimturno");

            entity.ToTable("tb_dim_turno");

            entity.Property(e => e.CoSeqDimTurno)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_turno");
            entity.Property(e => e.CoOrdem).HasColumnName("co_ordem");
            entity.Property(e => e.DsTurno)
                .HasMaxLength(500)
                .HasColumnName("ds_turno");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbDimUnidadeSaude>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimUnidadeSaude).HasName("pk_dimunidadesaude");

            entity.ToTable("tb_dim_unidade_saude");

            entity.HasIndex(e => e.NuCnes, "in_dim_unidadesaude_cnes");

            entity.Property(e => e.CoSeqDimUnidadeSaude)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_dim_unidade_saude");
            entity.Property(e => e.DsFiltro)
                .HasMaxLength(255)
                .HasColumnName("ds_filtro");
            entity.Property(e => e.NoBairro)
                .HasMaxLength(500)
                .HasColumnName("no_bairro");
            entity.Property(e => e.NoUnidadeSaude)
                .HasMaxLength(500)
                .HasColumnName("no_unidade_saude");
            entity.Property(e => e.NuCnes)
                .HasMaxLength(20)
                .HasColumnName("nu_cnes");
            entity.Property(e => e.StRegistroValido).HasColumnName("st_registro_valido");
        });

        modelBuilder.Entity<TbDimViaAdministracao>(entity =>
        {
            entity.HasKey(e => e.CoSeqDimViaAdministracao).HasName("tb_dim_via_administracao_pkey");

            entity.ToTable("tb_dim_via_administracao", tb => tb.HasComment("Armazena as dimensões usadas pelo DW da TB_VIA_ADM_VACINA"));

            entity.Property(e => e.CoSeqDimViaAdministracao)
                .ValueGeneratedNever()
                .HasComment("Sequence da tabela TB_DIM_VIA_ADMINISTRACAO")
                .HasColumnName("co_seq_dim_via_administracao");
            entity.Property(e => e.CoOrdem)
                .HasComment("Indica a ordem que o registro irá aparece nas listagens")
                .HasColumnName("co_ordem");
            entity.Property(e => e.NoViaAdministracao)
                .HasMaxLength(255)
                .HasComment("Nome da forma farmaceutica")
                .HasColumnName("no_via_administracao");
            entity.Property(e => e.NoViaAdministracaoFiltro)
                .HasMaxLength(255)
                .HasColumnName("no_via_administracao_filtro");
            entity.Property(e => e.NuIdentificador)
                .HasMaxLength(100)
                .HasColumnName("nu_identificador");
        });

        modelBuilder.Entity<TbFatAtdIndEncaminhamentos>(entity =>
        {
            entity.HasKey(e => e.CoSeqFatAtdIndEncaminham).HasName("tb_fat_atd_ind_encaminhamentos_pkey");

            entity.ToTable("tb_fat_atd_ind_encaminhamentos", tb => tb.HasComment("Armazena os fatos relacionados aos encaminhamentos dos atendimento"));

            entity.HasIndex(e => e.NuUuidFicha, "in_fatatdindencam_uuidficha");

            entity.HasIndex(e => e.CoFatAtdInd, "in_fatatdindesp_fatatdind");

            entity.HasIndex(e => e.CoFatCidadaoPec, "in_fatatdindesp_ftciddaopec");

            entity.HasIndex(e => new { e.NuUuidFicha, e.NuCnsCidadao }, "in_fatatdindespec_cns");

            entity.HasIndex(e => new { e.NuUuidFicha, e.NuCpfCidadao }, "in_fatatdindespec_cpf");

            entity.HasIndex(e => new { e.CoDimTempo, e.NuUuidFicha, e.NuAtendimento }, "in_fatatdindespec_ficha");

            entity.Property(e => e.CoSeqFatAtdIndEncaminham)
                .ValueGeneratedNever()
                .HasComment("Sequence da tabela TB_FAT_ATD_IND_ENCAMINHAMENTOS")
                .HasColumnName("co_seq_fat_atd_ind_encaminham");
            entity.Property(e => e.CoDimCbo1).HasColumnName("co_dim_cbo_1");
            entity.Property(e => e.CoDimCbo2).HasColumnName("co_dim_cbo_2");
            entity.Property(e => e.CoDimCdsTipoOrigem).HasColumnName("co_dim_cds_tipo_origem");
            entity.Property(e => e.CoDimCiap2)
                .HasComment("Código Ciap2 da hipótese diagnóstica")
                .HasColumnName("co_dim_ciap2");
            entity.Property(e => e.CoDimCid10)
                .HasComment("Código CID10 da hipótese diagnóstica")
                .HasColumnName("co_dim_cid10");
            entity.Property(e => e.CoDimClassificacaoRiscEnc)
                .HasComment("Tipo da classificação de risco")
                .HasColumnName("co_dim_classificacao_risc_enc");
            entity.Property(e => e.CoDimEquipe1).HasColumnName("co_dim_equipe_1");
            entity.Property(e => e.CoDimEquipe2).HasColumnName("co_dim_equipe_2");
            entity.Property(e => e.CoDimEspecialidade)
                .HasComment("Código da especialidade do encaminhamento")
                .HasColumnName("co_dim_especialidade");
            entity.Property(e => e.CoDimMunicipio).HasColumnName("co_dim_municipio");
            entity.Property(e => e.CoDimProfissional1).HasColumnName("co_dim_profissional_1");
            entity.Property(e => e.CoDimProfissional2).HasColumnName("co_dim_profissional_2");
            entity.Property(e => e.CoDimTempo).HasColumnName("co_dim_tempo");
            entity.Property(e => e.CoDimTipoFicha).HasColumnName("co_dim_tipo_ficha");
            entity.Property(e => e.CoDimTipoOrigemDadoTransp).HasColumnName("co_dim_tipo_origem_dado_transp");
            entity.Property(e => e.CoDimUnidadeSaude1).HasColumnName("co_dim_unidade_saude_1");
            entity.Property(e => e.CoDimUnidadeSaude2).HasColumnName("co_dim_unidade_saude_2");
            entity.Property(e => e.CoFatAtdInd).HasColumnName("co_fat_atd_ind");
            entity.Property(e => e.CoFatCidadaoPec).HasColumnName("co_fat_cidadao_pec");
            entity.Property(e => e.NuAtendimento).HasColumnName("nu_atendimento");
            entity.Property(e => e.NuCnsCidadao)
                .HasMaxLength(15)
                .HasColumnName("nu_cns_cidadao");
            entity.Property(e => e.NuCpfCidadao)
                .HasMaxLength(11)
                .HasColumnName("nu_cpf_cidadao");
            entity.Property(e => e.NuUuidDadoTransp)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_dado_transp");
            entity.Property(e => e.NuUuidFicha)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_ficha");

            entity.HasOne(d => d.CoDimCbo1Navigation).WithMany(p => p.TbFatAtdIndEncaminhamentosCoDimCbo1Navigation)
                .HasForeignKey(d => d.CoDimCbo1)
                .HasConstraintName("fk_dimcbo_fatatdindes1");

            entity.HasOne(d => d.CoDimCbo2Navigation).WithMany(p => p.TbFatAtdIndEncaminhamentosCoDimCbo2Navigation)
                .HasForeignKey(d => d.CoDimCbo2)
                .HasConstraintName("fk_dimcbo_fatatdindes2");

            entity.HasOne(d => d.CoDimCdsTipoOrigemNavigation).WithMany(p => p.TbFatAtdIndEncaminhamentos)
                .HasForeignKey(d => d.CoDimCdsTipoOrigem)
                .HasConstraintName("fk_dimtporigem_fatatdindes");

            entity.HasOne(d => d.CoDimClassificacaoRiscEncNavigation).WithMany(p => p.TbFatAtdIndEncaminhamentos)
                .HasForeignKey(d => d.CoDimClassificacaoRiscEnc)
                .HasConstraintName("fk_dimclrsce_fatatdindes");

            entity.HasOne(d => d.CoDimEquipe1Navigation).WithMany(p => p.TbFatAtdIndEncaminhamentosCoDimEquipe1Navigation)
                .HasForeignKey(d => d.CoDimEquipe1)
                .HasConstraintName("fk_dimequipe_fatatdindes1");

            entity.HasOne(d => d.CoDimEquipe2Navigation).WithMany(p => p.TbFatAtdIndEncaminhamentosCoDimEquipe2Navigation)
                .HasForeignKey(d => d.CoDimEquipe2)
                .HasConstraintName("fk_dimequipe_fatatdindes2");

            entity.HasOne(d => d.CoDimEspecialidadeNavigation).WithMany(p => p.TbFatAtdIndEncaminhamentos)
                .HasForeignKey(d => d.CoDimEspecialidade)
                .HasConstraintName("fk_dimespec_fatatdindes");

            entity.HasOne(d => d.CoDimMunicipioNavigation).WithMany(p => p.TbFatAtdIndEncaminhamentos)
                .HasForeignKey(d => d.CoDimMunicipio)
                .HasConstraintName("fk_dimmunicipio_fatatdindes1");

            entity.HasOne(d => d.CoDimProfissional1Navigation).WithMany(p => p.TbFatAtdIndEncaminhamentosCoDimProfissional1Navigation)
                .HasForeignKey(d => d.CoDimProfissional1)
                .HasConstraintName("fk_dimprofissionl_fatatdindes1");

            entity.HasOne(d => d.CoDimProfissional2Navigation).WithMany(p => p.TbFatAtdIndEncaminhamentosCoDimProfissional2Navigation)
                .HasForeignKey(d => d.CoDimProfissional2)
                .HasConstraintName("fk_dimprofissionl_fatatdindes2");

            entity.HasOne(d => d.CoDimTempoNavigation).WithMany(p => p.TbFatAtdIndEncaminhamentos)
                .HasForeignKey(d => d.CoDimTempo)
                .HasConstraintName("fk_dimtempo_fatatdindes");

            entity.HasOne(d => d.CoDimTipoFichaNavigation).WithMany(p => p.TbFatAtdIndEncaminhamentos)
                .HasForeignKey(d => d.CoDimTipoFicha)
                .HasConstraintName("fk_dimtipoficha_fatatdindes");

            entity.HasOne(d => d.CoDimTipoOrigemDadoTranspNavigation).WithMany(p => p.TbFatAtdIndEncaminhamentos)
                .HasForeignKey(d => d.CoDimTipoOrigemDadoTransp)
                .HasConstraintName("fk_dmtporgddt_fatatdindes");

            entity.HasOne(d => d.CoDimUnidadeSaude1Navigation).WithMany(p => p.TbFatAtdIndEncaminhamentosCoDimUnidadeSaude1Navigation)
                .HasForeignKey(d => d.CoDimUnidadeSaude1)
                .HasConstraintName("fk_dimunidadesade_fatatdindes1");

            entity.HasOne(d => d.CoDimUnidadeSaude2Navigation).WithMany(p => p.TbFatAtdIndEncaminhamentosCoDimUnidadeSaude2Navigation)
                .HasForeignKey(d => d.CoDimUnidadeSaude2)
                .HasConstraintName("fk_dimunidadesade_fatatdindes2");

            entity.HasOne(d => d.CoFatCidadaoPecNavigation).WithMany(p => p.TbFatAtdIndEncaminhamentos)
                .HasForeignKey(d => d.CoFatCidadaoPec)
                .HasConstraintName("fk_ftciddaopec_fatatdindes");
        });

        modelBuilder.Entity<TbFatAtdIndExames>(entity =>
        {
            entity.HasKey(e => e.CoSeqFatAtdIndExames).HasName("tb_fat_atd_ind_exames_pkey");

            entity.ToTable("tb_fat_atd_ind_exames", tb => tb.HasComment("Armazena os fatos relacionados aos exames específicos de um atendimento"));

            entity.HasIndex(e => e.CoFatAtdInd, "in_fatatdindexa_fatatdind");

            entity.HasIndex(e => e.CoFatCidadaoPec, "in_fatatdindexa_ftciddaopec");

            entity.HasIndex(e => new { e.NuUuidFicha, e.NuCnsCidadao }, "in_fatatdindexames_cns");

            entity.HasIndex(e => new { e.NuUuidFicha, e.NuCpfCidadao }, "in_fatatdindexames_cpf");

            entity.HasIndex(e => new { e.CoDimTempo, e.NuUuidFicha, e.NuAtendimento }, "in_fatatdindexames_ficha");

            entity.HasIndex(e => e.NuUuidFicha, "in_fatatdindexames_uuidficha");

            entity.Property(e => e.CoSeqFatAtdIndExames)
                .ValueGeneratedNever()
                .HasComment("Sequence da tabela TB_FAT_ATD_IND_EXAMES")
                .HasColumnName("co_seq_fat_atd_ind_exames");
            entity.Property(e => e.CoDimCbo1).HasColumnName("co_dim_cbo_1");
            entity.Property(e => e.CoDimCbo2).HasColumnName("co_dim_cbo_2");
            entity.Property(e => e.CoDimCdsTipoOrigem).HasColumnName("co_dim_cds_tipo_origem");
            entity.Property(e => e.CoDimEquipe1).HasColumnName("co_dim_equipe_1");
            entity.Property(e => e.CoDimEquipe2).HasColumnName("co_dim_equipe_2");
            entity.Property(e => e.CoDimMunicipio).HasColumnName("co_dim_municipio");
            entity.Property(e => e.CoDimProcedimento)
                .HasComment("Código do exame da tabela TB_DIM_PROCEDIMENTO")
                .HasColumnName("co_dim_procedimento");
            entity.Property(e => e.CoDimProfissional1).HasColumnName("co_dim_profissional_1");
            entity.Property(e => e.CoDimProfissional2).HasColumnName("co_dim_profissional_2");
            entity.Property(e => e.CoDimTempo).HasColumnName("co_dim_tempo");
            entity.Property(e => e.CoDimTipoFicha).HasColumnName("co_dim_tipo_ficha");
            entity.Property(e => e.CoDimTipoOrigemDadoTransp).HasColumnName("co_dim_tipo_origem_dado_transp");
            entity.Property(e => e.CoDimUnidadeSaude1).HasColumnName("co_dim_unidade_saude_1");
            entity.Property(e => e.CoDimUnidadeSaude2).HasColumnName("co_dim_unidade_saude_2");
            entity.Property(e => e.CoFatAtdInd).HasColumnName("co_fat_atd_ind");
            entity.Property(e => e.CoFatCidadaoPec).HasColumnName("co_fat_cidadao_pec");
            entity.Property(e => e.DtRealizacao)
                .HasComment("Data que o exame foi realizado")
                .HasColumnName("dt_realizacao");
            entity.Property(e => e.DtResultado)
                .HasComment("Data que o resultado foi gerado")
                .HasColumnName("dt_resultado");
            entity.Property(e => e.DtResultadoData)
                .HasComment("Campo para armazerar uma data para os exames que necessitarem")
                .HasColumnName("dt_resultado_data");
            entity.Property(e => e.DtSolicitacao)
                .HasComment("Data em que o exame foi solicitado")
                .HasColumnName("dt_solicitacao");
            entity.Property(e => e.NuAtendimento).HasColumnName("nu_atendimento");
            entity.Property(e => e.NuCnsCidadao)
                .HasMaxLength(15)
                .HasColumnName("nu_cns_cidadao");
            entity.Property(e => e.NuCpfCidadao)
                .HasMaxLength(11)
                .HasColumnName("nu_cpf_cidadao");
            entity.Property(e => e.NuResultadoDia)
                .HasComment("Campo para armazerar o resultado de dias para exames que necessitarem")
                .HasColumnName("nu_resultado_dia");
            entity.Property(e => e.NuResultadoSemana)
                .HasComment("Campo para armazerar o resultado de semanas para exames que necessitarem")
                .HasColumnName("nu_resultado_semana");
            entity.Property(e => e.NuResultadoValor)
                .HasComment("Campo para armazenar o valor do resultado inteiro ou fracionado, caso código do exame for igual a 0211070149, ABEX020, 0211070270, 0205020178, 0206010079, 0207010064, ABPG013, ABEX022, o valor deste campo faz referência a tabela TB_DIM_ZIKA_TIPO_EXAME.CO_SEQ_DIM_ZIKA_TIPO_EXAME")
                .HasColumnName("nu_resultado_valor");
            entity.Property(e => e.NuUuidDadoTransp)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_dado_transp");
            entity.Property(e => e.NuUuidFicha)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_ficha");

            entity.HasOne(d => d.CoDimCbo1Navigation).WithMany(p => p.TbFatAtdIndExamesCoDimCbo1Navigation)
                .HasForeignKey(d => d.CoDimCbo1)
                .HasConstraintName("fk_dimcbo_fatatdindex1");

            entity.HasOne(d => d.CoDimCbo2Navigation).WithMany(p => p.TbFatAtdIndExamesCoDimCbo2Navigation)
                .HasForeignKey(d => d.CoDimCbo2)
                .HasConstraintName("fk_dimcbo_fatatdindex2");

            entity.HasOne(d => d.CoDimCdsTipoOrigemNavigation).WithMany(p => p.TbFatAtdIndExames)
                .HasForeignKey(d => d.CoDimCdsTipoOrigem)
                .HasConstraintName("fk_dimtporigem_fatatdindex");

            entity.HasOne(d => d.CoDimEquipe1Navigation).WithMany(p => p.TbFatAtdIndExamesCoDimEquipe1Navigation)
                .HasForeignKey(d => d.CoDimEquipe1)
                .HasConstraintName("fk_dimequipe_fatatdindex1");

            entity.HasOne(d => d.CoDimEquipe2Navigation).WithMany(p => p.TbFatAtdIndExamesCoDimEquipe2Navigation)
                .HasForeignKey(d => d.CoDimEquipe2)
                .HasConstraintName("fk_dimequipe_fatatdindex2");

            entity.HasOne(d => d.CoDimMunicipioNavigation).WithMany(p => p.TbFatAtdIndExames)
                .HasForeignKey(d => d.CoDimMunicipio)
                .HasConstraintName("fk_dimmunicipio_fatatdindex1");

            entity.HasOne(d => d.CoDimProcedimentoNavigation).WithMany(p => p.TbFatAtdIndExames)
                .HasForeignKey(d => d.CoDimProcedimento)
                .HasConstraintName("fk_dimproced_fatatdindex");

            entity.HasOne(d => d.CoDimProfissional1Navigation).WithMany(p => p.TbFatAtdIndExamesCoDimProfissional1Navigation)
                .HasForeignKey(d => d.CoDimProfissional1)
                .HasConstraintName("fk_dimprofissionl_fatatdindex1");

            entity.HasOne(d => d.CoDimProfissional2Navigation).WithMany(p => p.TbFatAtdIndExamesCoDimProfissional2Navigation)
                .HasForeignKey(d => d.CoDimProfissional2)
                .HasConstraintName("fk_dimprofissionl_fatatdindex2");

            entity.HasOne(d => d.CoDimTempoNavigation).WithMany(p => p.TbFatAtdIndExames)
                .HasForeignKey(d => d.CoDimTempo)
                .HasConstraintName("fk_dimtempo_fatatdindex");

            entity.HasOne(d => d.CoDimTipoFichaNavigation).WithMany(p => p.TbFatAtdIndExames)
                .HasForeignKey(d => d.CoDimTipoFicha)
                .HasConstraintName("fk_dimtipoficha_fatatdindex");

            entity.HasOne(d => d.CoDimTipoOrigemDadoTranspNavigation).WithMany(p => p.TbFatAtdIndExames)
                .HasForeignKey(d => d.CoDimTipoOrigemDadoTransp)
                .HasConstraintName("fk_dmtporgddt_fatatdindex");

            entity.HasOne(d => d.CoDimUnidadeSaude1Navigation).WithMany(p => p.TbFatAtdIndExamesCoDimUnidadeSaude1Navigation)
                .HasForeignKey(d => d.CoDimUnidadeSaude1)
                .HasConstraintName("fk_dimunidadesade_fatatdindex1");

            entity.HasOne(d => d.CoDimUnidadeSaude2Navigation).WithMany(p => p.TbFatAtdIndExamesCoDimUnidadeSaude2Navigation)
                .HasForeignKey(d => d.CoDimUnidadeSaude2)
                .HasConstraintName("fk_dimunidadesade_fatatdindex2");

            entity.HasOne(d => d.CoFatCidadaoPecNavigation).WithMany(p => p.TbFatAtdIndExames)
                .HasForeignKey(d => d.CoFatCidadaoPec)
                .HasConstraintName("fk_ftciddaopec_fatatdindex");
        });

        modelBuilder.Entity<TbFatAtdIndMedicamentos>(entity =>
        {
            entity.HasKey(e => e.CoSeqFatAtdIndMedicam).HasName("tb_fat_atd_ind_medicamentos_pkey");

            entity.ToTable("tb_fat_atd_ind_medicamentos", tb => tb.HasComment("Armazena os fatos relacionados às receitas de um atendimento"));

            entity.HasIndex(e => e.CoFatAtdInd, "in_fatatdindmed_fatatdind");

            entity.HasIndex(e => e.CoFatCidadaoPec, "in_fatatdindmed_ftciddaopec");

            entity.HasIndex(e => e.NuUuidFicha, "in_fatatdindmedic_uuidficha");

            entity.HasIndex(e => new { e.NuUuidFicha, e.NuCnsCidadao }, "in_fatatdindmedicamentos_cns");

            entity.HasIndex(e => new { e.NuUuidFicha, e.NuCpfCidadao }, "in_fatatdindmedicamentos_cpf");

            entity.HasIndex(e => new { e.CoDimTempo, e.NuUuidFicha, e.NuAtendimento }, "in_fatatdindmedicamentos_ficha");

            entity.Property(e => e.CoSeqFatAtdIndMedicam)
                .ValueGeneratedNever()
                .HasComment("Sequence da tabela TB_FAT_ATD_IND_MEDICAMENTOS")
                .HasColumnName("co_seq_fat_atd_ind_medicam");
            entity.Property(e => e.CoDimCatmat).HasColumnName("co_dim_catmat");
            entity.Property(e => e.CoDimCbo1).HasColumnName("co_dim_cbo_1");
            entity.Property(e => e.CoDimCbo2).HasColumnName("co_dim_cbo_2");
            entity.Property(e => e.CoDimCdsTipoOrigem).HasColumnName("co_dim_cds_tipo_origem");
            entity.Property(e => e.CoDimDoseFrequencia)
                .HasComment("Tipo da frequência usada na dose")
                .HasColumnName("co_dim_dose_frequencia");
            entity.Property(e => e.CoDimDoseFrequenciaMedida)
                .HasComment("Unidade de medida da quantidade da dose")
                .HasColumnName("co_dim_dose_frequencia_medida");
            entity.Property(e => e.CoDimDuracaoTratamentoMed)
                .HasComment("Unidade de medida da duração do tratamento")
                .HasColumnName("co_dim_duracao_tratamento_med");
            entity.Property(e => e.CoDimEquipe1).HasColumnName("co_dim_equipe_1");
            entity.Property(e => e.CoDimEquipe2).HasColumnName("co_dim_equipe_2");
            entity.Property(e => e.CoDimMunicipio).HasColumnName("co_dim_municipio");
            entity.Property(e => e.CoDimProfissional1).HasColumnName("co_dim_profissional_1");
            entity.Property(e => e.CoDimProfissional2).HasColumnName("co_dim_profissional_2");
            entity.Property(e => e.CoDimTempo).HasColumnName("co_dim_tempo");
            entity.Property(e => e.CoDimTipoFicha).HasColumnName("co_dim_tipo_ficha");
            entity.Property(e => e.CoDimTipoOrigemDadoTransp).HasColumnName("co_dim_tipo_origem_dado_transp");
            entity.Property(e => e.CoDimUnidadeSaude1).HasColumnName("co_dim_unidade_saude_1");
            entity.Property(e => e.CoDimUnidadeSaude2).HasColumnName("co_dim_unidade_saude_2");
            entity.Property(e => e.CoDimViaAdministracao)
                .HasComment("Tipo da via de administração do medicamento")
                .HasColumnName("co_dim_via_administracao");
            entity.Property(e => e.CoFatAtdInd).HasColumnName("co_fat_atd_ind");
            entity.Property(e => e.CoFatCidadaoPec).HasColumnName("co_fat_cidadao_pec");
            entity.Property(e => e.DsDose)
                .HasMaxLength(255)
                .HasComment("Descrição da dose")
                .HasColumnName("ds_dose");
            entity.Property(e => e.DsDoseFrequencia)
                .HasMaxLength(255)
                .HasComment("Descrição da frequência da dose")
                .HasColumnName("ds_dose_frequencia");
            entity.Property(e => e.DtInicioTratamento)
                .HasComment("Data de início do tratamento")
                .HasColumnName("dt_inicio_tratamento");
            entity.Property(e => e.NuAtendimento).HasColumnName("nu_atendimento");
            entity.Property(e => e.NuCnsCidadao)
                .HasMaxLength(15)
                .HasColumnName("nu_cns_cidadao");
            entity.Property(e => e.NuCpfCidadao)
                .HasMaxLength(11)
                .HasColumnName("nu_cpf_cidadao");
            entity.Property(e => e.NuUuidDadoTransp)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_dado_transp");
            entity.Property(e => e.NuUuidFicha)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_ficha");
            entity.Property(e => e.QtDoseFrequencia)
                .HasComment("Quantidade da frequencia da dose")
                .HasColumnName("qt_dose_frequencia");
            entity.Property(e => e.QtDuracaoTratamento)
                .HasComment("Quantidade do tratamento")
                .HasColumnName("qt_duracao_tratamento");
            entity.Property(e => e.QtReceitada)
                .HasComment("Quantidade receitada")
                .HasColumnName("qt_receitada");
            entity.Property(e => e.StDoseUnica)
                .HasComment("Indicação se a dose é unica ou não")
                .HasColumnName("st_dose_unica");
            entity.Property(e => e.StUsoContinuo)
                .HasComment("Indicação se o medicamento é de uso contínuo ou não")
                .HasColumnName("st_uso_continuo");

            entity.HasOne(d => d.CoDimCatmatNavigation).WithMany(p => p.TbFatAtdIndMedicamentos)
                .HasForeignKey(d => d.CoDimCatmat)
                .HasConstraintName("fk_dimcatmat_fatatdindmd");

            entity.HasOne(d => d.CoDimCbo1Navigation).WithMany(p => p.TbFatAtdIndMedicamentosCoDimCbo1Navigation)
                .HasForeignKey(d => d.CoDimCbo1)
                .HasConstraintName("fk_dimcbo_fatatdindmd1");

            entity.HasOne(d => d.CoDimCbo2Navigation).WithMany(p => p.TbFatAtdIndMedicamentosCoDimCbo2Navigation)
                .HasForeignKey(d => d.CoDimCbo2)
                .HasConstraintName("fk_dimcbo_fatatdindmd2");

            entity.HasOne(d => d.CoDimCdsTipoOrigemNavigation).WithMany(p => p.TbFatAtdIndMedicamentos)
                .HasForeignKey(d => d.CoDimCdsTipoOrigem)
                .HasConstraintName("fk_dimtporigem_fatatdindmd");

            entity.HasOne(d => d.CoDimDoseFrequenciaNavigation).WithMany(p => p.TbFatAtdIndMedicamentos)
                .HasForeignKey(d => d.CoDimDoseFrequencia)
                .HasConstraintName("fk_dimdosfrq_fatatdindmd");

            entity.HasOne(d => d.CoDimDoseFrequenciaMedidaNavigation).WithMany(p => p.TbFatAtdIndMedicamentos)
                .HasForeignKey(d => d.CoDimDoseFrequenciaMedida)
                .HasConstraintName("fk_dimdsfrmd_fatatdindmd");

            entity.HasOne(d => d.CoDimDuracaoTratamentoMedNavigation).WithMany(p => p.TbFatAtdIndMedicamentos)
                .HasForeignKey(d => d.CoDimDuracaoTratamentoMed)
                .HasConstraintName("fk_dimdrtrmd_fatatdindmd");

            entity.HasOne(d => d.CoDimEquipe1Navigation).WithMany(p => p.TbFatAtdIndMedicamentosCoDimEquipe1Navigation)
                .HasForeignKey(d => d.CoDimEquipe1)
                .HasConstraintName("fk_dimequipe_fatatdindmd1");

            entity.HasOne(d => d.CoDimEquipe2Navigation).WithMany(p => p.TbFatAtdIndMedicamentosCoDimEquipe2Navigation)
                .HasForeignKey(d => d.CoDimEquipe2)
                .HasConstraintName("fk_dimequipe_fatatdindmd2");

            entity.HasOne(d => d.CoDimMunicipioNavigation).WithMany(p => p.TbFatAtdIndMedicamentos)
                .HasForeignKey(d => d.CoDimMunicipio)
                .HasConstraintName("fk_dimmunicipio_fatatdindmd1");

            entity.HasOne(d => d.CoDimProfissional1Navigation).WithMany(p => p.TbFatAtdIndMedicamentosCoDimProfissional1Navigation)
                .HasForeignKey(d => d.CoDimProfissional1)
                .HasConstraintName("fk_dimprofissionl_fatatdindmd1");

            entity.HasOne(d => d.CoDimProfissional2Navigation).WithMany(p => p.TbFatAtdIndMedicamentosCoDimProfissional2Navigation)
                .HasForeignKey(d => d.CoDimProfissional2)
                .HasConstraintName("fk_dimprofissionl_fatatdindmd2");

            entity.HasOne(d => d.CoDimTempoNavigation).WithMany(p => p.TbFatAtdIndMedicamentos)
                .HasForeignKey(d => d.CoDimTempo)
                .HasConstraintName("fk_dimtempo_fatatdindmd");

            entity.HasOne(d => d.CoDimTipoFichaNavigation).WithMany(p => p.TbFatAtdIndMedicamentos)
                .HasForeignKey(d => d.CoDimTipoFicha)
                .HasConstraintName("fk_dimtipoficha_fatatdindmd");

            entity.HasOne(d => d.CoDimTipoOrigemDadoTranspNavigation).WithMany(p => p.TbFatAtdIndMedicamentos)
                .HasForeignKey(d => d.CoDimTipoOrigemDadoTransp)
                .HasConstraintName("fk_dmtporgddt_fatatdindmd");

            entity.HasOne(d => d.CoDimUnidadeSaude1Navigation).WithMany(p => p.TbFatAtdIndMedicamentosCoDimUnidadeSaude1Navigation)
                .HasForeignKey(d => d.CoDimUnidadeSaude1)
                .HasConstraintName("fk_dimunidadesade_fatatdindmd1");

            entity.HasOne(d => d.CoDimUnidadeSaude2Navigation).WithMany(p => p.TbFatAtdIndMedicamentosCoDimUnidadeSaude2Navigation)
                .HasForeignKey(d => d.CoDimUnidadeSaude2)
                .HasConstraintName("fk_dimunidadesade_fatatdindmd2");

            entity.HasOne(d => d.CoDimViaAdministracaoNavigation).WithMany(p => p.TbFatAtdIndMedicamentos)
                .HasForeignKey(d => d.CoDimViaAdministracao)
                .HasConstraintName("fk_dimviaadm_fatatdindmd");

            entity.HasOne(d => d.CoFatCidadaoPecNavigation).WithMany(p => p.TbFatAtdIndMedicamentos)
                .HasForeignKey(d => d.CoFatCidadaoPec)
                .HasConstraintName("fk_ftciddaopec_fatatdindmd");
        });

        modelBuilder.Entity<TbFatAtdIndProblemas>(entity =>
        {
            entity.HasKey(e => e.CoSeqFatAtendIndProblemas).HasName("pk_fatatdindpr");

            entity.ToTable("tb_fat_atd_ind_problemas");

            entity.HasIndex(e => e.CoFatCidadaoPec, "idx_fatatdindpr_ftciddaopec");

            entity.HasIndex(e => e.CoFatAtdInd, "in_fatatdindpr_fatatdind");

            entity.HasIndex(e => new { e.CoDimTempo, e.NuUuidFicha, e.NuAtendimento }, "in_fatatdindpr_ficha");

            entity.HasIndex(e => new { e.CoDimTempo, e.CoDimMunicipio, e.CoDimUnidadeSaude1, e.CoDimEquipe1, e.CoDimProfissional1, e.CoDimCbo1 }, "in_fatatdindpr_header");

            entity.HasIndex(e => new { e.NuUuidFicha, e.NuCpfCidadao }, "in_fatatdindprob_hist_cpf");

            entity.HasIndex(e => new { e.NuUuidFicha, e.NuCns }, "in_fatatdindprob_historico");

            entity.HasIndex(e => e.NuUuidFicha, "in_fatatdindproblem_uuidficha");

            entity.Property(e => e.CoSeqFatAtendIndProblemas)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_fat_atend_ind_problemas");
            entity.Property(e => e.CoDimCbo1).HasColumnName("co_dim_cbo_1");
            entity.Property(e => e.CoDimCbo2).HasColumnName("co_dim_cbo_2");
            entity.Property(e => e.CoDimCdsTipoOrigem).HasColumnName("co_dim_cds_tipo_origem");
            entity.Property(e => e.CoDimCiap).HasColumnName("co_dim_ciap");
            entity.Property(e => e.CoDimCid).HasColumnName("co_dim_cid");
            entity.Property(e => e.CoDimEquipe1).HasColumnName("co_dim_equipe_1");
            entity.Property(e => e.CoDimEquipe2).HasColumnName("co_dim_equipe_2");
            entity.Property(e => e.CoDimMunicipio).HasColumnName("co_dim_municipio");
            entity.Property(e => e.CoDimProfissional1).HasColumnName("co_dim_profissional_1");
            entity.Property(e => e.CoDimProfissional2).HasColumnName("co_dim_profissional_2");
            entity.Property(e => e.CoDimTempo).HasColumnName("co_dim_tempo");
            entity.Property(e => e.CoDimTipoFicha).HasColumnName("co_dim_tipo_ficha");
            entity.Property(e => e.CoDimTipoOrigemDadoTransp).HasColumnName("co_dim_tipo_origem_dado_transp");
            entity.Property(e => e.CoDimUnidadeSaude1).HasColumnName("co_dim_unidade_saude_1");
            entity.Property(e => e.CoDimUnidadeSaude2).HasColumnName("co_dim_unidade_saude_2");
            entity.Property(e => e.CoFatAtdInd).HasColumnName("co_fat_atd_ind");
            entity.Property(e => e.CoFatCidadaoPec).HasColumnName("co_fat_cidadao_pec");
            entity.Property(e => e.NuAtendimento).HasColumnName("nu_atendimento");
            entity.Property(e => e.NuCns)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("nu_cns");
            entity.Property(e => e.NuCpfCidadao)
                .HasMaxLength(11)
                .HasColumnName("nu_cpf_cidadao");
            entity.Property(e => e.NuUuidDadoTransp)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_dado_transp");
            entity.Property(e => e.NuUuidFicha)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_ficha");

            entity.HasOne(d => d.CoDimCbo1Navigation).WithMany(p => p.TbFatAtdIndProblemasCoDimCbo1Navigation)
                .HasForeignKey(d => d.CoDimCbo1)
                .HasConstraintName("fk_dimcbo_fatatdindpr1");

            entity.HasOne(d => d.CoDimCbo2Navigation).WithMany(p => p.TbFatAtdIndProblemasCoDimCbo2Navigation)
                .HasForeignKey(d => d.CoDimCbo2)
                .HasConstraintName("fk_dimcbo_fatatdindpr2");

            entity.HasOne(d => d.CoDimCdsTipoOrigemNavigation).WithMany(p => p.TbFatAtdIndProblemas)
                .HasForeignKey(d => d.CoDimCdsTipoOrigem)
                .HasConstraintName("fk_dimtporigem_fatatdindpr");

            entity.HasOne(d => d.CoDimCiapNavigation).WithMany(p => p.TbFatAtdIndProblemas)
                .HasForeignKey(d => d.CoDimCiap)
                .HasConstraintName("fk_dimciap_fatatdindpr");

            entity.HasOne(d => d.CoDimC).WithMany(p => p.TbFatAtdIndProblemas)
                .HasForeignKey(d => d.CoDimCid)
                .HasConstraintName("fk_dimcid_fatatdindpr");

            entity.HasOne(d => d.CoDimEquipe1Navigation).WithMany(p => p.TbFatAtdIndProblemasCoDimEquipe1Navigation)
                .HasForeignKey(d => d.CoDimEquipe1)
                .HasConstraintName("fk_dimequipe_fatatdindpr1");

            entity.HasOne(d => d.CoDimEquipe2Navigation).WithMany(p => p.TbFatAtdIndProblemasCoDimEquipe2Navigation)
                .HasForeignKey(d => d.CoDimEquipe2)
                .HasConstraintName("fk_dimequipe_fatatdindpr2");

            entity.HasOne(d => d.CoDimMunicipioNavigation).WithMany(p => p.TbFatAtdIndProblemas)
                .HasForeignKey(d => d.CoDimMunicipio)
                .HasConstraintName("fk_dimmunicipio_fatatdindpr1");

            entity.HasOne(d => d.CoDimProfissional1Navigation).WithMany(p => p.TbFatAtdIndProblemasCoDimProfissional1Navigation)
                .HasForeignKey(d => d.CoDimProfissional1)
                .HasConstraintName("fk_dimprofissionl_fatatdindpr1");

            entity.HasOne(d => d.CoDimProfissional2Navigation).WithMany(p => p.TbFatAtdIndProblemasCoDimProfissional2Navigation)
                .HasForeignKey(d => d.CoDimProfissional2)
                .HasConstraintName("fk_dimprofissionl_fatatdindpr2");

            entity.HasOne(d => d.CoDimTempoNavigation).WithMany(p => p.TbFatAtdIndProblemas)
                .HasForeignKey(d => d.CoDimTempo)
                .HasConstraintName("fk_dimtempo_fatatdindpr");

            entity.HasOne(d => d.CoDimTipoFichaNavigation).WithMany(p => p.TbFatAtdIndProblemas)
                .HasForeignKey(d => d.CoDimTipoFicha)
                .HasConstraintName("fk_dimtipoficha_fatatdindpr");

            entity.HasOne(d => d.CoDimTipoOrigemDadoTranspNavigation).WithMany(p => p.TbFatAtdIndProblemas)
                .HasForeignKey(d => d.CoDimTipoOrigemDadoTransp)
                .HasConstraintName("fk_dmtporgddt_fatatdindpr");

            entity.HasOne(d => d.CoDimUnidadeSaude1Navigation).WithMany(p => p.TbFatAtdIndProblemasCoDimUnidadeSaude1Navigation)
                .HasForeignKey(d => d.CoDimUnidadeSaude1)
                .HasConstraintName("fk_dimunidadesade_fatatdindpr1");

            entity.HasOne(d => d.CoDimUnidadeSaude2Navigation).WithMany(p => p.TbFatAtdIndProblemasCoDimUnidadeSaude2Navigation)
                .HasForeignKey(d => d.CoDimUnidadeSaude2)
                .HasConstraintName("fk_dimunidadesade_fatatdindpr2");

            entity.HasOne(d => d.CoFatCidadaoPecNavigation).WithMany(p => p.TbFatAtdIndProblemas)
                .HasForeignKey(d => d.CoFatCidadaoPec)
                .HasConstraintName("fk_ftciddaopec_fatatdindpr");
        });

        modelBuilder.Entity<TbFatAtdIndProcedimentos>(entity =>
        {
            entity.HasKey(e => e.CoSeqFatAtendIndProced).HasName("pk_fatatdindprced");

            entity.ToTable("tb_fat_atd_ind_procedimentos");

            entity.HasIndex(e => e.CoFatCidadaoPec, "idx_fatatdindprced_cidddgrpo");

            entity.HasIndex(e => e.CoFatAtdInd, "in_fat_atdindproced_fatatdind");

            entity.HasIndex(e => new { e.CoDimTempo, e.NuUuidFicha, e.NuAtendimento }, "in_fatatdindprced_ficha");

            entity.HasIndex(e => new { e.CoDimTempo, e.CoDimMunicipio, e.CoDimUnidadeSaude1, e.CoDimEquipe1, e.CoDimProfissional1, e.CoDimCbo1 }, "in_fatatdindprced_header");

            entity.HasIndex(e => e.NuUuidFicha, "in_fatatdindproced_uuidficha");

            entity.HasIndex(e => new { e.NuUuidFicha, e.NuCpfCidadao }, "in_fatatdindproceds_hist_cpf");

            entity.HasIndex(e => new { e.NuUuidFicha, e.NuCns }, "in_fatatdindproceds_historico");

            entity.Property(e => e.CoSeqFatAtendIndProced)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_fat_atend_ind_proced");
            entity.Property(e => e.CoDimCbo1).HasColumnName("co_dim_cbo_1");
            entity.Property(e => e.CoDimCbo2).HasColumnName("co_dim_cbo_2");
            entity.Property(e => e.CoDimCdsTipoOrigem).HasColumnName("co_dim_cds_tipo_origem");
            entity.Property(e => e.CoDimEquipe1).HasColumnName("co_dim_equipe_1");
            entity.Property(e => e.CoDimEquipe2).HasColumnName("co_dim_equipe_2");
            entity.Property(e => e.CoDimMunicipio).HasColumnName("co_dim_municipio");
            entity.Property(e => e.CoDimProcedimentoAvaliado).HasColumnName("co_dim_procedimento_avaliado");
            entity.Property(e => e.CoDimProcedimentoSolicitado).HasColumnName("co_dim_procedimento_solicitado");
            entity.Property(e => e.CoDimProfissional1).HasColumnName("co_dim_profissional_1");
            entity.Property(e => e.CoDimProfissional2).HasColumnName("co_dim_profissional_2");
            entity.Property(e => e.CoDimTempo).HasColumnName("co_dim_tempo");
            entity.Property(e => e.CoDimTipoFicha).HasColumnName("co_dim_tipo_ficha");
            entity.Property(e => e.CoDimTipoOrigemDadoTransp).HasColumnName("co_dim_tipo_origem_dado_transp");
            entity.Property(e => e.CoDimUnidadeSaude1).HasColumnName("co_dim_unidade_saude_1");
            entity.Property(e => e.CoDimUnidadeSaude2).HasColumnName("co_dim_unidade_saude_2");
            entity.Property(e => e.CoFatAtdInd).HasColumnName("co_fat_atd_ind");
            entity.Property(e => e.CoFatCidadaoPec).HasColumnName("co_fat_cidadao_pec");
            entity.Property(e => e.NuAtendimento).HasColumnName("nu_atendimento");
            entity.Property(e => e.NuCns)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("nu_cns");
            entity.Property(e => e.NuCpfCidadao)
                .HasMaxLength(11)
                .HasColumnName("nu_cpf_cidadao");
            entity.Property(e => e.NuUuidDadoTransp)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_dado_transp");
            entity.Property(e => e.NuUuidFicha)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_ficha");

            entity.HasOne(d => d.CoDimCbo1Navigation).WithMany(p => p.TbFatAtdIndProcedimentosCoDimCbo1Navigation)
                .HasForeignKey(d => d.CoDimCbo1)
                .HasConstraintName("fk_dimcbo_fatatdindprced1");

            entity.HasOne(d => d.CoDimCbo2Navigation).WithMany(p => p.TbFatAtdIndProcedimentosCoDimCbo2Navigation)
                .HasForeignKey(d => d.CoDimCbo2)
                .HasConstraintName("fk_dimcbo_fatatdindprced2");

            entity.HasOne(d => d.CoDimCdsTipoOrigemNavigation).WithMany(p => p.TbFatAtdIndProcedimentos)
                .HasForeignKey(d => d.CoDimCdsTipoOrigem)
                .HasConstraintName("fk_dimtporigem_fatatdindprced");

            entity.HasOne(d => d.CoDimEquipe1Navigation).WithMany(p => p.TbFatAtdIndProcedimentosCoDimEquipe1Navigation)
                .HasForeignKey(d => d.CoDimEquipe1)
                .HasConstraintName("fk_dimequipe_fatatdindprced1");

            entity.HasOne(d => d.CoDimEquipe2Navigation).WithMany(p => p.TbFatAtdIndProcedimentosCoDimEquipe2Navigation)
                .HasForeignKey(d => d.CoDimEquipe2)
                .HasConstraintName("fk_dimequipe_fatatdindprced2");

            entity.HasOne(d => d.CoDimMunicipioNavigation).WithMany(p => p.TbFatAtdIndProcedimentos)
                .HasForeignKey(d => d.CoDimMunicipio)
                .HasConstraintName("fk_dimmunicipio_fatatdndprced1");

            entity.HasOne(d => d.CoDimProcedimentoAvaliadoNavigation).WithMany(p => p.TbFatAtdIndProcedimentosCoDimProcedimentoAvaliadoNavigation)
                .HasForeignKey(d => d.CoDimProcedimentoAvaliado)
                .HasConstraintName("fk_dimprocdmnt_fatatdindprceda");

            entity.HasOne(d => d.CoDimProcedimentoSolicitadoNavigation).WithMany(p => p.TbFatAtdIndProcedimentosCoDimProcedimentoSolicitadoNavigation)
                .HasForeignKey(d => d.CoDimProcedimentoSolicitado)
                .HasConstraintName("fk_dimprocdmnt_fatatdindprceds");

            entity.HasOne(d => d.CoDimProfissional1Navigation).WithMany(p => p.TbFatAtdIndProcedimentosCoDimProfissional1Navigation)
                .HasForeignKey(d => d.CoDimProfissional1)
                .HasConstraintName("fk_dimprofssnl_fatatdindprced1");

            entity.HasOne(d => d.CoDimProfissional2Navigation).WithMany(p => p.TbFatAtdIndProcedimentosCoDimProfissional2Navigation)
                .HasForeignKey(d => d.CoDimProfissional2)
                .HasConstraintName("fk_dimprofssnl_fatatdindprced2");

            entity.HasOne(d => d.CoDimTempoNavigation).WithMany(p => p.TbFatAtdIndProcedimentos)
                .HasForeignKey(d => d.CoDimTempo)
                .HasConstraintName("fk_dimtempo_fatatdindprced");

            entity.HasOne(d => d.CoDimTipoFichaNavigation).WithMany(p => p.TbFatAtdIndProcedimentos)
                .HasForeignKey(d => d.CoDimTipoFicha)
                .HasConstraintName("fk_dimtipoficha_fatatdindprced");

            entity.HasOne(d => d.CoDimTipoOrigemDadoTranspNavigation).WithMany(p => p.TbFatAtdIndProcedimentos)
                .HasForeignKey(d => d.CoDimTipoOrigemDadoTransp)
                .HasConstraintName("fk_dmtporgddt_fatatdindprced");

            entity.HasOne(d => d.CoDimUnidadeSaude1Navigation).WithMany(p => p.TbFatAtdIndProcedimentosCoDimUnidadeSaude1Navigation)
                .HasForeignKey(d => d.CoDimUnidadeSaude1)
                .HasConstraintName("fk_dimunddesde_fatatdindprced1");

            entity.HasOne(d => d.CoDimUnidadeSaude2Navigation).WithMany(p => p.TbFatAtdIndProcedimentosCoDimUnidadeSaude2Navigation)
                .HasForeignKey(d => d.CoDimUnidadeSaude2)
                .HasConstraintName("fk_dimunddesde_fatatdindprced2");

            entity.HasOne(d => d.CoFatCidadaoPecNavigation).WithMany(p => p.TbFatAtdIndProcedimentos)
                .HasForeignKey(d => d.CoFatCidadaoPec)
                .HasConstraintName("fk_ftciddaopec_fatatdindprced");
        });

        modelBuilder.Entity<TbFatAtendimentoIndividual>(entity =>
        {
            entity.HasKey(e => e.CoSeqFatAtdInd).HasName("pk_fatatdind");

            entity.ToTable("tb_fat_atendimento_individual");

            entity.HasIndex(e => e.CoFatCidadaoPec, "idx_fatatdind_ftciddaopec");

            entity.HasIndex(e => e.CoDimCboFinalizadorObs, "in_dimcbofinobs_fat_atend_ind");

            entity.HasIndex(e => e.CoDimEquipeFinalizadorObs, "in_dimeqfinobs_fat_atend_ind");

            entity.HasIndex(e => e.CoDimProfFinalizadorObs, "in_dimproffinobs_fat_atend_ind");

            entity.HasIndex(e => e.CoDimUbsFinalizadorObs, "in_dimubsfinobs_fat_atend_ind");

            entity.HasIndex(e => e.CoDimTempo, "in_fatatdind_codimtempo");

            entity.HasIndex(e => new { e.CoDimTempo, e.NuUuidFicha, e.NuAtendimento }, "in_fatatdind_ficha");

            entity.HasIndex(e => new { e.CoDimTempo, e.CoDimMunicipio, e.CoDimUnidadeSaude1, e.CoDimEquipe1, e.CoDimProfissional1, e.CoDimCbo1 }, "in_fatatdind_header");

            entity.HasIndex(e => new { e.NuUuidFicha, e.NuCns }, "in_fatatendindiv_historico");

            entity.HasIndex(e => new { e.NuCpfCidadao, e.NuUuidFicha }, "in_fatatendindiv_historicocpf");

            entity.HasIndex(e => e.NuUuidFicha, "in_fatatendindiv_uuidficha");

            entity.Property(e => e.CoSeqFatAtdInd)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_fat_atd_ind");
            entity.Property(e => e.CoDimAleitamento).HasColumnName("co_dim_aleitamento");
            entity.Property(e => e.CoDimCbo1).HasColumnName("co_dim_cbo_1");
            entity.Property(e => e.CoDimCbo2).HasColumnName("co_dim_cbo_2");
            entity.Property(e => e.CoDimCboFinalizadorObs)
                .HasDefaultValueSql("1")
                .HasColumnName("co_dim_cbo_finalizador_obs");
            entity.Property(e => e.CoDimCdsTipoOrigem).HasColumnName("co_dim_cds_tipo_origem");
            entity.Property(e => e.CoDimEquipe1).HasColumnName("co_dim_equipe_1");
            entity.Property(e => e.CoDimEquipe2).HasColumnName("co_dim_equipe_2");
            entity.Property(e => e.CoDimEquipeFinalizadorObs)
                .HasDefaultValueSql("1")
                .HasColumnName("co_dim_equipe_finalizador_obs");
            entity.Property(e => e.CoDimFaixaEtaria).HasColumnName("co_dim_faixa_etaria");
            entity.Property(e => e.CoDimLocalAtendimento).HasColumnName("co_dim_local_atendimento");
            entity.Property(e => e.CoDimModalidadeAd).HasColumnName("co_dim_modalidade_ad");
            entity.Property(e => e.CoDimMunicipio).HasColumnName("co_dim_municipio");
            entity.Property(e => e.CoDimProfFinalizadorObs)
                .HasDefaultValueSql("1")
                .HasColumnName("co_dim_prof_finalizador_obs");
            entity.Property(e => e.CoDimProfissional1).HasColumnName("co_dim_profissional_1");
            entity.Property(e => e.CoDimProfissional2).HasColumnName("co_dim_profissional_2");
            entity.Property(e => e.CoDimRacionalidadeSaude).HasColumnName("co_dim_racionalidade_saude");
            entity.Property(e => e.CoDimSexo).HasColumnName("co_dim_sexo");
            entity.Property(e => e.CoDimTempo).HasColumnName("co_dim_tempo");
            entity.Property(e => e.CoDimTempoDum).HasColumnName("co_dim_tempo_dum");
            entity.Property(e => e.CoDimTipoAtendimento).HasColumnName("co_dim_tipo_atendimento");
            entity.Property(e => e.CoDimTipoFicha).HasColumnName("co_dim_tipo_ficha");
            entity.Property(e => e.CoDimTipoOrigemDadoTransp).HasColumnName("co_dim_tipo_origem_dado_transp");
            entity.Property(e => e.CoDimTpParticipCidadao)
                .HasDefaultValueSql("1")
                .HasColumnName("co_dim_tp_particip_cidadao");
            entity.Property(e => e.CoDimTpParticipProfConv)
                .HasDefaultValueSql("1")
                .HasColumnName("co_dim_tp_particip_prof_conv");
            entity.Property(e => e.CoDimTurno).HasColumnName("co_dim_turno");
            entity.Property(e => e.CoDimUbsFinalizadorObs)
                .HasDefaultValueSql("1")
                .HasColumnName("co_dim_ubs_finalizador_obs");
            entity.Property(e => e.CoDimUnidadeSaude1).HasColumnName("co_dim_unidade_saude_1");
            entity.Property(e => e.CoDimUnidadeSaude2).HasColumnName("co_dim_unidade_saude_2");
            entity.Property(e => e.CoFatCidadaoPec).HasColumnName("co_fat_cidadao_pec");
            entity.Property(e => e.DsFiltroCiaps)
                .HasMaxLength(4000)
                .HasColumnName("ds_filtro_ciaps");
            entity.Property(e => e.DsFiltroCids)
                .HasMaxLength(4000)
                .HasColumnName("ds_filtro_cids");
            entity.Property(e => e.DsFiltroProcedAvaliados)
                .HasMaxLength(4000)
                .HasColumnName("ds_filtro_proced_avaliados");
            entity.Property(e => e.DsFiltroProcedSolicitados)
                .HasMaxLength(4000)
                .HasColumnName("ds_filtro_proced_solicitados");
            entity.Property(e => e.DtFinalAtendimento).HasColumnName("dt_final_atendimento");
            entity.Property(e => e.DtInicialAtendimento).HasColumnName("dt_inicial_atendimento");
            entity.Property(e => e.DtNascimento).HasColumnName("dt_nascimento");
            entity.Property(e => e.NuAltura).HasColumnName("nu_altura");
            entity.Property(e => e.NuAtendimento).HasColumnName("nu_atendimento");
            entity.Property(e => e.NuCns)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("nu_cns");
            entity.Property(e => e.NuCpfCidadao)
                .HasMaxLength(11)
                .HasColumnName("nu_cpf_cidadao");
            entity.Property(e => e.NuGestasPrevias).HasColumnName("nu_gestas_previas");
            entity.Property(e => e.NuIdadeGestacionalSemanas).HasColumnName("nu_idade_gestacional_semanas");
            entity.Property(e => e.NuPartos).HasColumnName("nu_partos");
            entity.Property(e => e.NuPerimetroCefalico).HasColumnName("nu_perimetro_cefalico");
            entity.Property(e => e.NuPeso).HasColumnName("nu_peso");
            entity.Property(e => e.NuProntuario)
                .HasMaxLength(65)
                .HasColumnName("nu_prontuario");
            entity.Property(e => e.NuUuidDadoTransp)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_dado_transp");
            entity.Property(e => e.NuUuidFicha)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_ficha");
            entity.Property(e => e.StCondutaAgendamentoEmulti)
                .HasComment("Indica se o atendimento foi agendado para eMulti.")
                .HasColumnName("st_conduta_agendamento_emulti");
            entity.Property(e => e.StCondutaAgendamentoGrupos).HasColumnName("st_conduta_agendamento_grupos");
            entity.Property(e => e.StCondutaAgendamentoNasf).HasColumnName("st_conduta_agendamento_nasf");
            entity.Property(e => e.StCondutaAltaEpisodio).HasColumnName("st_conduta_alta_episodio");
            entity.Property(e => e.StCondutaConsultaAgendada).HasColumnName("st_conduta_consulta_agendada");
            entity.Property(e => e.StCondutaCuiddContiProgram).HasColumnName("st_conduta_cuidd_conti_program");
            entity.Property(e => e.StCondutaManterObservacao).HasColumnName("st_conduta_manter_observacao");
            entity.Property(e => e.StEncaminhamentoCaps).HasColumnName("st_encaminhamento_caps");
            entity.Property(e => e.StEncaminhamentoInternHospi).HasColumnName("st_encaminhamento_intern_hospi");
            entity.Property(e => e.StEncaminhamentoInternoDia).HasColumnName("st_encaminhamento_interno_dia");
            entity.Property(e => e.StEncaminhamentoIntersetoria).HasColumnName("st_encaminhamento_intersetoria");
            entity.Property(e => e.StEncaminhamentoServSpecial).HasColumnName("st_encaminhamento_serv_special");
            entity.Property(e => e.StEncaminhamentoServicoAd).HasColumnName("st_encaminhamento_servico_ad");
            entity.Property(e => e.StEncaminhamentoUrgencia).HasColumnName("st_encaminhamento_urgencia");
            entity.Property(e => e.StFicouEmObservacao).HasColumnName("st_ficou_em_observacao");
            entity.Property(e => e.StGravidezPlanejada).HasColumnName("st_gravidez_planejada");
            entity.Property(e => e.StNasf)
                .HasComment("Indica se o tipo de atendimento foi preenchido em uma versão que continha a antiga estrutura Núcleo de Apoio a Saúde da Família (NASF).")
                .HasColumnName("st_nasf");
            entity.Property(e => e.StNasfAvaliacaoDiagnostico)
                .HasComment("Campo legado que indica se a Avaliação/Diagnóstico foi realizada por uma equipe Nasf durante o atendimento, substituído pelo ST_EMULTI_AVAL_DIAGNOSTICO a partir da versão 5.5.0 do LEDI.")
                .HasColumnName("st_nasf_avaliacao_diagnostico");
            entity.Property(e => e.StNasfPrescricaoTerapeutica)
                .HasComment("Campo legado que indica se a Prescrição Terapêutica foi realizada por uma equipe Nasf durante o atendimento, substituído pelo ST_EMULTI_PRESC_TERAPEUTICA a partir da versão 5.5.0 do LEDI.")
                .HasColumnName("st_nasf_prescricao_terapeutica");
            entity.Property(e => e.StNasfProceClinTerapeutico)
                .HasComment("Campo legado que indica se Procedimentos Clínicos/Terapêuticos foram realizados por uma equipe Nasf durante o atendimento, substituído pelo ST_EMULTI_PROCE_CLIN_TERAP a partir da versão 5.5.0 do LEDI.")
                .HasColumnName("st_nasf_proce_clin_terapeutico");
            entity.Property(e => e.StVacinacaoEmDia).HasColumnName("st_vacinacao_em_dia");

            entity.HasOne(d => d.CoDimAleitamentoNavigation).WithMany(p => p.TbFatAtendimentoIndividual)
                .HasForeignKey(d => d.CoDimAleitamento)
                .HasConstraintName("fk_dimaleitamento_fatatdind");

            entity.HasOne(d => d.CoDimCbo1Navigation).WithMany(p => p.TbFatAtendimentoIndividualCoDimCbo1Navigation)
                .HasForeignKey(d => d.CoDimCbo1)
                .HasConstraintName("fk_dimcbo_fatatdind1");

            entity.HasOne(d => d.CoDimCbo2Navigation).WithMany(p => p.TbFatAtendimentoIndividualCoDimCbo2Navigation)
                .HasForeignKey(d => d.CoDimCbo2)
                .HasConstraintName("fk_dimcbo_fatatdind2");

            entity.HasOne(d => d.CoDimCboFinalizadorObsNavigation).WithMany(p => p.TbFatAtendimentoIndividualCoDimCboFinalizadorObsNavigation)
                .HasForeignKey(d => d.CoDimCboFinalizadorObs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dimcbo_fatatendind_obs");

            entity.HasOne(d => d.CoDimCdsTipoOrigemNavigation).WithMany(p => p.TbFatAtendimentoIndividual)
                .HasForeignKey(d => d.CoDimCdsTipoOrigem)
                .HasConstraintName("fk_dimtporigem_fatatdind");

            entity.HasOne(d => d.CoDimEquipe1Navigation).WithMany(p => p.TbFatAtendimentoIndividualCoDimEquipe1Navigation)
                .HasForeignKey(d => d.CoDimEquipe1)
                .HasConstraintName("fk_dimequipe_fatatdind1");

            entity.HasOne(d => d.CoDimEquipe2Navigation).WithMany(p => p.TbFatAtendimentoIndividualCoDimEquipe2Navigation)
                .HasForeignKey(d => d.CoDimEquipe2)
                .HasConstraintName("fk_dimequipe_fatatdind2");

            entity.HasOne(d => d.CoDimEquipeFinalizadorObsNavigation).WithMany(p => p.TbFatAtendimentoIndividualCoDimEquipeFinalizadorObsNavigation)
                .HasForeignKey(d => d.CoDimEquipeFinalizadorObs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dimequipe_fatatendind_obs");

            entity.HasOne(d => d.CoDimFaixaEtariaNavigation).WithMany(p => p.TbFatAtendimentoIndividual)
                .HasForeignKey(d => d.CoDimFaixaEtaria)
                .HasConstraintName("fk_dimfaixaetaria_fatatendind");

            entity.HasOne(d => d.CoDimLocalAtendimentoNavigation).WithMany(p => p.TbFatAtendimentoIndividual)
                .HasForeignKey(d => d.CoDimLocalAtendimento)
                .HasConstraintName("fk_dimlocalatend_fatatdind");

            entity.HasOne(d => d.CoDimModalidadeAdNavigation).WithMany(p => p.TbFatAtendimentoIndividual)
                .HasForeignKey(d => d.CoDimModalidadeAd)
                .HasConstraintName("fk_dimmodalidadead_fatatdind");

            entity.HasOne(d => d.CoDimMunicipioNavigation).WithMany(p => p.TbFatAtendimentoIndividual)
                .HasForeignKey(d => d.CoDimMunicipio)
                .HasConstraintName("fk_dimmunicipio_fatatdind1");

            entity.HasOne(d => d.CoDimProfFinalizadorObsNavigation).WithMany(p => p.TbFatAtendimentoIndividualCoDimProfFinalizadorObsNavigation)
                .HasForeignKey(d => d.CoDimProfFinalizadorObs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dimprof_fatatendind_obs");

            entity.HasOne(d => d.CoDimProfissional1Navigation).WithMany(p => p.TbFatAtendimentoIndividualCoDimProfissional1Navigation)
                .HasForeignKey(d => d.CoDimProfissional1)
                .HasConstraintName("fk_dimprofissional_fatatdind1");

            entity.HasOne(d => d.CoDimProfissional2Navigation).WithMany(p => p.TbFatAtendimentoIndividualCoDimProfissional2Navigation)
                .HasForeignKey(d => d.CoDimProfissional2)
                .HasConstraintName("fk_dimprofissional_fatatdind2");

            entity.HasOne(d => d.CoDimRacionalidadeSaudeNavigation).WithMany(p => p.TbFatAtendimentoIndividual)
                .HasForeignKey(d => d.CoDimRacionalidadeSaude)
                .HasConstraintName("fk_dimracionlddsaude_fatatdind");

            entity.HasOne(d => d.CoDimSexoNavigation).WithMany(p => p.TbFatAtendimentoIndividual)
                .HasForeignKey(d => d.CoDimSexo)
                .HasConstraintName("fk_dimsexo_fatatdind");

            entity.HasOne(d => d.CoDimTempoNavigation).WithMany(p => p.TbFatAtendimentoIndividualCoDimTempoNavigation)
                .HasForeignKey(d => d.CoDimTempo)
                .HasConstraintName("fk_dimtempo_fatatdind");

            entity.HasOne(d => d.CoDimTempoDumNavigation).WithMany(p => p.TbFatAtendimentoIndividualCoDimTempoDumNavigation)
                .HasForeignKey(d => d.CoDimTempoDum)
                .HasConstraintName("fk_dimtempo_fatatdinddum");

            entity.HasOne(d => d.CoDimTipoAtendimentoNavigation).WithMany(p => p.TbFatAtendimentoIndividual)
                .HasForeignKey(d => d.CoDimTipoAtendimento)
                .HasConstraintName("fk_dimtipoatend_fatatdind");

            entity.HasOne(d => d.CoDimTipoFichaNavigation).WithMany(p => p.TbFatAtendimentoIndividual)
                .HasForeignKey(d => d.CoDimTipoFicha)
                .HasConstraintName("fk_dimtipoficha_fatatdind");

            entity.HasOne(d => d.CoDimTipoOrigemDadoTranspNavigation).WithMany(p => p.TbFatAtendimentoIndividual)
                .HasForeignKey(d => d.CoDimTipoOrigemDadoTransp)
                .HasConstraintName("fk_dmtporgddt_fatatdind");

            entity.HasOne(d => d.CoDimTurnoNavigation).WithMany(p => p.TbFatAtendimentoIndividual)
                .HasForeignKey(d => d.CoDimTurno)
                .HasConstraintName("fk_dimturno_fatatdind");

            entity.HasOne(d => d.CoDimUbsFinalizadorObsNavigation).WithMany(p => p.TbFatAtendimentoIndividualCoDimUbsFinalizadorObsNavigation)
                .HasForeignKey(d => d.CoDimUbsFinalizadorObs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dimubs_fatatendind_obs");

            entity.HasOne(d => d.CoDimUnidadeSaude1Navigation).WithMany(p => p.TbFatAtendimentoIndividualCoDimUnidadeSaude1Navigation)
                .HasForeignKey(d => d.CoDimUnidadeSaude1)
                .HasConstraintName("fk_dimunidadesaude_fatatdind1");

            entity.HasOne(d => d.CoDimUnidadeSaude2Navigation).WithMany(p => p.TbFatAtendimentoIndividualCoDimUnidadeSaude2Navigation)
                .HasForeignKey(d => d.CoDimUnidadeSaude2)
                .HasConstraintName("fk_dimunidadesaude_fatatdind2");

            entity.HasOne(d => d.CoFatCidadaoPecNavigation).WithMany(p => p.TbFatAtendimentoIndividual)
                .HasForeignKey(d => d.CoFatCidadaoPec)
                .HasConstraintName("fk_ftciddaopec_fatatdind");
        });

        modelBuilder.Entity<TbFatCadIndividual>(entity =>
        {
            entity.HasKey(e => e.CoSeqFatCadIndividual).HasName("pk_fatcadindividual");

            entity.ToTable("tb_fat_cad_individual");

            entity.HasIndex(e => new { e.CoFatCidadaoPec, e.CoDimTempoValidade, e.StFichaInativa, e.StGeradoAutomaticamente }, "idx_fatcadindivdual_cidaddgrpo");

            entity.HasIndex(e => e.CoFatCidadaoPecResponsvl, "idx_ftcdindvdl_cidaddgrpoesp");

            entity.HasIndex(e => new { e.CoDimMunicipio, e.CoDimUnidadeSaude, e.CoDimEquipe }, "in_fatcadindividual_header");

            entity.HasIndex(e => new { e.NuUuidFicha, e.CoDimTempo }, "in_fatcadindividual_nuuuidfich");

            entity.HasIndex(e => new { e.CoDimTempoValidade, e.CoDimTempo }, "in_fatcadindividual_periodo");

            entity.HasIndex(e => new { e.NuUuidFichaOrigem, e.CoDimTempo }, "in_fatcadindvdl_nuuuidfichorgm");

            entity.HasIndex(e => new { e.StProcOperacionais, e.NuUuidFichaOrigem }, "in_fatcadindvdl_stprcprcns");

            entity.Property(e => e.CoSeqFatCadIndividual)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_fat_cad_individual");
            entity.Property(e => e.CoDimCbo).HasColumnName("co_dim_cbo");
            entity.Property(e => e.CoDimCboCidadao).HasColumnName("co_dim_cbo_cidadao");
            entity.Property(e => e.CoDimCdsTipoOrigem).HasColumnName("co_dim_cds_tipo_origem");
            entity.Property(e => e.CoDimEquipe).HasColumnName("co_dim_equipe");
            entity.Property(e => e.CoDimEtnia).HasColumnName("co_dim_etnia");
            entity.Property(e => e.CoDimFaixaEtaria).HasColumnName("co_dim_faixa_etaria");
            entity.Property(e => e.CoDimFrequenciaAlimentacao).HasColumnName("co_dim_frequencia_alimentacao");
            entity.Property(e => e.CoDimIdentidadeGenero).HasColumnName("co_dim_identidade_genero");
            entity.Property(e => e.CoDimMunicipio).HasColumnName("co_dim_municipio");
            entity.Property(e => e.CoDimMunicipioCidadao).HasColumnName("co_dim_municipio_cidadao");
            entity.Property(e => e.CoDimNacionalidade).HasColumnName("co_dim_nacionalidade");
            entity.Property(e => e.CoDimPaisNascimento).HasColumnName("co_dim_pais_nascimento");
            entity.Property(e => e.CoDimPovoComunidadTrad)
                .HasComment("Código de dimensão do povo ou comunidade tradicional")
                .HasColumnName("co_dim_povo_comunidad_trad");
            entity.Property(e => e.CoDimProfissional).HasColumnName("co_dim_profissional");
            entity.Property(e => e.CoDimRacaCor).HasColumnName("co_dim_raca_cor");
            entity.Property(e => e.CoDimSexo).HasColumnName("co_dim_sexo");
            entity.Property(e => e.CoDimSituacaoTrabalho).HasColumnName("co_dim_situacao_trabalho");
            entity.Property(e => e.CoDimTempo).HasColumnName("co_dim_tempo");
            entity.Property(e => e.CoDimTempoMoradorRua).HasColumnName("co_dim_tempo_morador_rua");
            entity.Property(e => e.CoDimTempoValidade).HasColumnName("co_dim_tempo_validade");
            entity.Property(e => e.CoDimTempoValidadeRecusa).HasColumnName("co_dim_tempo_validade_recusa");
            entity.Property(e => e.CoDimTipoCondicaoPeso).HasColumnName("co_dim_tipo_condicao_peso");
            entity.Property(e => e.CoDimTipoEscolaridade).HasColumnName("co_dim_tipo_escolaridade");
            entity.Property(e => e.CoDimTipoFicha).HasColumnName("co_dim_tipo_ficha");
            entity.Property(e => e.CoDimTipoOrientacaoSexual).HasColumnName("co_dim_tipo_orientacao_sexual");
            entity.Property(e => e.CoDimTipoOrigemDadoTransp).HasColumnName("co_dim_tipo_origem_dado_transp");
            entity.Property(e => e.CoDimTipoParentesco).HasColumnName("co_dim_tipo_parentesco");
            entity.Property(e => e.CoDimTipoSaidaCadastro).HasColumnName("co_dim_tipo_saida_cadastro");
            entity.Property(e => e.CoDimUnidadeSaude).HasColumnName("co_dim_unidade_saude");
            entity.Property(e => e.CoFatCidadaoPec).HasColumnName("co_fat_cidadao_pec");
            entity.Property(e => e.CoFatCidadaoPecResponsvl).HasColumnName("co_fat_cidadao_pec_responsvl");
            entity.Property(e => e.DtEntradaBrasil).HasColumnName("dt_entrada_brasil");
            entity.Property(e => e.DtNascimento).HasColumnName("dt_nascimento");
            entity.Property(e => e.DtNaturalizacao).HasColumnName("dt_naturalizacao");
            entity.Property(e => e.DtObito).HasColumnName("dt_obito");
            entity.Property(e => e.NoAcompanhadoInstituicao)
                .HasMaxLength(500)
                .HasColumnName("no_acompanhado_instituicao");
            entity.Property(e => e.NoCausaInternacao12)
                .HasMaxLength(500)
                .HasColumnName("no_causa_internacao12");
            entity.Property(e => e.NoEmail)
                .HasMaxLength(500)
                .HasColumnName("no_email");
            entity.Property(e => e.NoMaternidadeReferencia)
                .HasMaxLength(500)
                .HasColumnName("no_maternidade_referencia");
            entity.Property(e => e.NoNome)
                .HasMaxLength(500)
                .HasColumnName("no_nome");
            entity.Property(e => e.NoNomeMae)
                .HasMaxLength(500)
                .HasColumnName("no_nome_mae");
            entity.Property(e => e.NoNomePai)
                .HasMaxLength(500)
                .HasColumnName("no_nome_pai");
            entity.Property(e => e.NoNomeSocial)
                .HasMaxLength(500)
                .HasColumnName("no_nome_social");
            entity.Property(e => e.NoOutraCondicao1)
                .HasMaxLength(500)
                .HasColumnName("no_outra_condicao1");
            entity.Property(e => e.NoOutraCondicao2)
                .HasMaxLength(500)
                .HasColumnName("no_outra_condicao2");
            entity.Property(e => e.NoOutraCondicao3)
                .HasMaxLength(500)
                .HasColumnName("no_outra_condicao3");
            entity.Property(e => e.NoPlantasMedicinais)
                .HasMaxLength(500)
                .HasColumnName("no_plantas_medicinais");
            entity.Property(e => e.NoVisitaFamiliarParentesco)
                .HasMaxLength(500)
                .HasColumnName("no_visita_familiar_parentesco");
            entity.Property(e => e.NuCelular)
                .HasMaxLength(33)
                .HasColumnName("nu_celular");
            entity.Property(e => e.NuCns)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("nu_cns");
            entity.Property(e => e.NuCnsResponsavel)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("nu_cns_responsavel");
            entity.Property(e => e.NuCpfCidadao)
                .HasMaxLength(11)
                .HasColumnName("nu_cpf_cidadao");
            entity.Property(e => e.NuCpfResponsavel)
                .HasMaxLength(11)
                .HasColumnName("nu_cpf_responsavel");
            entity.Property(e => e.NuMicroArea)
                .HasMaxLength(3)
                .HasColumnName("nu_micro_area");
            entity.Property(e => e.NuNis)
                .HasMaxLength(32)
                .HasColumnName("nu_nis");
            entity.Property(e => e.NuObitoDo)
                .HasMaxLength(32)
                .HasColumnName("nu_obito_do");
            entity.Property(e => e.NuPortariaNaturalizacao)
                .HasMaxLength(65)
                .HasColumnName("nu_portaria_naturalizacao");
            entity.Property(e => e.NuUuidDadoTransp)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_dado_transp");
            entity.Property(e => e.NuUuidFicha)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_ficha");
            entity.Property(e => e.NuUuidFichaOrigem)
                .HasMaxLength(96)
                .HasColumnName("nu_uuid_ficha_origem");
            entity.Property(e => e.StAcamado).HasColumnName("st_acamado");
            entity.Property(e => e.StAcompanhadoInstituicao).HasColumnName("st_acompanhado_instituicao");
            entity.Property(e => e.StAlcool).HasColumnName("st_alcool");
            entity.Property(e => e.StAlimentosAcabSemDinheiro)
                .HasComment("Nos últimos três meses, os alimentos acabaram antes que você tivesse dinheiro para comprar mais comida?")
                .HasColumnName("st_alimentos_acab_sem_dinheiro");
            entity.Property(e => e.StAvc).HasColumnName("st_avc");
            entity.Property(e => e.StCancer).HasColumnName("st_cancer");
            entity.Property(e => e.StComeuQueTinhaDnheirAcab)
                .HasComment("Nos últimos três meses, você comeu apenas alguns alimentos que ainda tinha, porque o dinheiro acabou?")
                .HasColumnName("st_comeu_que_tinha_dnheir_acab");
            entity.Property(e => e.StComunidadeTradicional).HasColumnName("st_comunidade_tradicional");
            entity.Property(e => e.StDefiAuditiva).HasColumnName("st_defi_auditiva");
            entity.Property(e => e.StDefiFisica).HasColumnName("st_defi_fisica");
            entity.Property(e => e.StDefiIntelectualCognitiva).HasColumnName("st_defi_intelectual_cognitiva");
            entity.Property(e => e.StDefiOutra).HasColumnName("st_defi_outra");
            entity.Property(e => e.StDefiVisual).HasColumnName("st_defi_visual");
            entity.Property(e => e.StDeficiencia).HasColumnName("st_deficiencia");
            entity.Property(e => e.StDesconheceMae).HasColumnName("st_desconhece_mae");
            entity.Property(e => e.StDesconhecePai).HasColumnName("st_desconhece_pai");
            entity.Property(e => e.StDiabete).HasColumnName("st_diabete");
            entity.Property(e => e.StDoencaCardInsuficiencia).HasColumnName("st_doenca_card_insuficiencia");
            entity.Property(e => e.StDoencaCardNSabe).HasColumnName("st_doenca_card_n_sabe");
            entity.Property(e => e.StDoencaCardOutro).HasColumnName("st_doenca_card_outro");
            entity.Property(e => e.StDoencaCardiaca).HasColumnName("st_doenca_cardiaca");
            entity.Property(e => e.StDoencaRespiraAsma).HasColumnName("st_doenca_respira_asma");
            entity.Property(e => e.StDoencaRespiraDpocEnfisem).HasColumnName("st_doenca_respira_dpoc_enfisem");
            entity.Property(e => e.StDoencaRespiraNSabe).HasColumnName("st_doenca_respira_n_sabe");
            entity.Property(e => e.StDoencaRespiraOutra).HasColumnName("st_doenca_respira_outra");
            entity.Property(e => e.StDoencaRespiratoria).HasColumnName("st_doenca_respiratoria");
            entity.Property(e => e.StDomiciliado).HasColumnName("st_domiciliado");
            entity.Property(e => e.StFichaInativa).HasColumnName("st_ficha_inativa");
            entity.Property(e => e.StFrequentaCreche).HasColumnName("st_frequenta_creche");
            entity.Property(e => e.StFrequentaCuidador).HasColumnName("st_frequenta_cuidador");
            entity.Property(e => e.StFumante).HasColumnName("st_fumante");
            entity.Property(e => e.StGeradoAutomaticamente).HasColumnName("st_gerado_automaticamente");
            entity.Property(e => e.StGestante).HasColumnName("st_gestante");
            entity.Property(e => e.StHanseniase).HasColumnName("st_hanseniase");
            entity.Property(e => e.StHigPessBanho).HasColumnName("st_hig_pess_banho");
            entity.Property(e => e.StHigPessHigieneBucal).HasColumnName("st_hig_pess_higiene_bucal");
            entity.Property(e => e.StHigPessOutros).HasColumnName("st_hig_pess_outros");
            entity.Property(e => e.StHigPessSanitario).HasColumnName("st_hig_pess_sanitario");
            entity.Property(e => e.StHigienePessoalAcesso).HasColumnName("st_higiene_pessoal_acesso");
            entity.Property(e => e.StHipertensaoArterial).HasColumnName("st_hipertensao_arterial");
            entity.Property(e => e.StInfarto).HasColumnName("st_infarto");
            entity.Property(e => e.StInformarIdentidadeGenero).HasColumnName("st_informar_identidade_genero");
            entity.Property(e => e.StInformarOrientacaoSexual).HasColumnName("st_informar_orientacao_sexual");
            entity.Property(e => e.StInternacao12).HasColumnName("st_internacao_12");
            entity.Property(e => e.StMoradorRua).HasColumnName("st_morador_rua");
            entity.Property(e => e.StOrigAlimenDoacaoPopular).HasColumnName("st_orig_alimen_doacao_popular");
            entity.Property(e => e.StOrigAlimenDoacaoReli).HasColumnName("st_orig_alimen_doacao_reli");
            entity.Property(e => e.StOrigAlimenDoacaoRest).HasColumnName("st_orig_alimen_doacao_rest");
            entity.Property(e => e.StOrigAlimenOutros).HasColumnName("st_orig_alimen_outros");
            entity.Property(e => e.StOrigAlimenRestaurantePop).HasColumnName("st_orig_alimen_restaurante_pop");
            entity.Property(e => e.StOutraDroga).HasColumnName("st_outra_droga");
            entity.Property(e => e.StParticipaGrupoComunitario).HasColumnName("st_participa_grupo_comunitario");
            entity.Property(e => e.StPic).HasColumnName("st_pic");
            entity.Property(e => e.StPlanoSaudePrivado).HasColumnName("st_plano_saude_privado");
            entity.Property(e => e.StProblemaRins).HasColumnName("st_problema_rins");
            entity.Property(e => e.StProblemaRinsInsuficiencia).HasColumnName("st_problema_rins_insuficiencia");
            entity.Property(e => e.StProblemaRinsNaoSabe).HasColumnName("st_problema_rins_nao_sabe");
            entity.Property(e => e.StProblemaRinsOutro).HasColumnName("st_problema_rins_outro");
            entity.Property(e => e.StProcOperacionais).HasColumnName("st_proc_operacionais");
            entity.Property(e => e.StProcessoCidadao).HasColumnName("st_processo_cidadao");
            entity.Property(e => e.StProcessoLinhaTempo).HasColumnName("st_processo_linha_tempo");
            entity.Property(e => e.StRecebeBeneficio).HasColumnName("st_recebe_beneficio");
            entity.Property(e => e.StRecusaCadastro).HasColumnName("st_recusa_cadastro");
            entity.Property(e => e.StReferenciaFamiliar).HasColumnName("st_referencia_familiar");
            entity.Property(e => e.StResponsCriancaAdolescente).HasColumnName("st_respons_crianca_adolescente");
            entity.Property(e => e.StResponsCriancaAdultoResp).HasColumnName("st_respons_crianca_adulto_resp");
            entity.Property(e => e.StResponsCriancaCreche).HasColumnName("st_respons_crianca_creche");
            entity.Property(e => e.StResponsCriancaOutraCrian).HasColumnName("st_respons_crianca_outra_crian");
            entity.Property(e => e.StResponsCriancaOutro).HasColumnName("st_respons_crianca_outro");
            entity.Property(e => e.StResponsCriancaSozinha).HasColumnName("st_respons_crianca_sozinha");
            entity.Property(e => e.StResponsavelFamiliar).HasColumnName("st_responsavel_familiar");
            entity.Property(e => e.StTratamentoPsiquiatra).HasColumnName("st_tratamento_psiquiatra");
            entity.Property(e => e.StTuberculose).HasColumnName("st_tuberculose");
            entity.Property(e => e.StUsaPlantaMedicinal).HasColumnName("st_usa_planta_medicinal");
            entity.Property(e => e.StVisitaFamiliarFrequente).HasColumnName("st_visita_familiar_frequente");

            entity.HasOne(d => d.CoDimCboNavigation).WithMany(p => p.TbFatCadIndividualCoDimCboNavigation)
                .HasForeignKey(d => d.CoDimCbo)
                .HasConstraintName("fk_dimcbo_fatcadindividual");

            entity.HasOne(d => d.CoDimCboCidadaoNavigation).WithMany(p => p.TbFatCadIndividualCoDimCboCidadaoNavigation)
                .HasForeignKey(d => d.CoDimCboCidadao)
                .HasConstraintName("fk_dimcbo_fatcadindvdciddo");

            entity.HasOne(d => d.CoDimCdsTipoOrigemNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimCdsTipoOrigem)
                .HasConstraintName("fk_dimtporigem_fatcadindividl");

            entity.HasOne(d => d.CoDimEquipeNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimEquipe)
                .HasConstraintName("fk_dimequipe_fatcadindividual");

            entity.HasOne(d => d.CoDimEtniaNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimEtnia)
                .HasConstraintName("fk_dimetnia_fatcadindvd");

            entity.HasOne(d => d.CoDimFaixaEtariaNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimFaixaEtaria)
                .HasConstraintName("fk_dimfaixaetaria_fatcadindvd");

            entity.HasOne(d => d.CoDimFrequenciaAlimentacaoNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimFrequenciaAlimentacao)
                .HasConstraintName("fk_dimfrequenciaalmn_fatcadind");

            entity.HasOne(d => d.CoDimIdentidadeGeneroNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimIdentidadeGenero)
                .HasConstraintName("fk_dmidntddgnro_fatcadindividu");

            entity.HasOne(d => d.CoDimMunicipioNavigation).WithMany(p => p.TbFatCadIndividualCoDimMunicipioNavigation)
                .HasForeignKey(d => d.CoDimMunicipio)
                .HasConstraintName("fk_dimmunicipio_fatcadindividl");

            entity.HasOne(d => d.CoDimMunicipioCidadaoNavigation).WithMany(p => p.TbFatCadIndividualCoDimMunicipioCidadaoNavigation)
                .HasForeignKey(d => d.CoDimMunicipioCidadao)
                .HasConstraintName("fk_dimmunicip_fatcadindivcidad");

            entity.HasOne(d => d.CoDimNacionalidadeNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimNacionalidade)
                .HasConstraintName("fk_dimnacionalidade_fatcadindv");

            entity.HasOne(d => d.CoDimPaisNascimentoNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimPaisNascimento)
                .HasConstraintName("fk_dimpaisnascimento_fatcadind");

            entity.HasOne(d => d.CoDimPovoComunidadTradNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimPovoComunidadTrad)
                .HasConstraintName("fk_dimpct_fatcadindividual");

            entity.HasOne(d => d.CoDimProfissionalNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimProfissional)
                .HasConstraintName("fk_dimprofissional_fatcadindvd");

            entity.HasOne(d => d.CoDimRacaCorNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimRacaCor)
                .HasConstraintName("fk_dimracacor_fatcadindividual");

            entity.HasOne(d => d.CoDimSexoNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimSexo)
                .HasConstraintName("fk_dimsexo_fatcadindividual");

            entity.HasOne(d => d.CoDimSituacaoTrabalhoNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimSituacaoTrabalho)
                .HasConstraintName("fk_dimsituacaotrablh_fatcadind");

            entity.HasOne(d => d.CoDimTempoNavigation).WithMany(p => p.TbFatCadIndividualCoDimTempoNavigation)
                .HasForeignKey(d => d.CoDimTempo)
                .HasConstraintName("fk_dimtempo_fatcadindividual");

            entity.HasOne(d => d.CoDimTempoMoradorRuaNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimTempoMoradorRua)
                .HasConstraintName("fk_dimtempomoradrrua_fatcadind");

            entity.HasOne(d => d.CoDimTempoValidadeNavigation).WithMany(p => p.TbFatCadIndividualCoDimTempoValidadeNavigation)
                .HasForeignKey(d => d.CoDimTempoValidade)
                .HasConstraintName("fk_dimtempo_fatcadindvalidade");

            entity.HasOne(d => d.CoDimTempoValidadeRecusaNavigation).WithMany(p => p.TbFatCadIndividualCoDimTempoValidadeRecusaNavigation)
                .HasForeignKey(d => d.CoDimTempoValidadeRecusa)
                .HasConstraintName("fk_dimtempo_fatcadindvalddrcsa");

            entity.HasOne(d => d.CoDimTipoCondicaoPesoNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimTipoCondicaoPeso)
                .HasConstraintName("fk_dimtipocondicapes_fatcadind");

            entity.HasOne(d => d.CoDimTipoEscolaridadeNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimTipoEscolaridade)
                .HasConstraintName("fk_dimtipoescolaridd_fatcadind");

            entity.HasOne(d => d.CoDimTipoFichaNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimTipoFicha)
                .HasConstraintName("fk_dimtipoficha_fatcadindvd");

            entity.HasOne(d => d.CoDimTipoOrientacaoSexualNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimTipoOrientacaoSexual)
                .HasConstraintName("fk_dimtipoorientcsxl_fatcadind");

            entity.HasOne(d => d.CoDimTipoOrigemDadoTranspNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimTipoOrigemDadoTransp)
                .HasConstraintName("fk_dmtporgddt_fatcadindividl");

            entity.HasOne(d => d.CoDimTipoParentescoNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimTipoParentesco)
                .HasConstraintName("fk_dimtipoparentesco_fatcadind");

            entity.HasOne(d => d.CoDimTipoSaidaCadastroNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimTipoSaidaCadastro)
                .HasConstraintName("fk_dimtiposaidacadst_fatcadind");

            entity.HasOne(d => d.CoDimUnidadeSaudeNavigation).WithMany(p => p.TbFatCadIndividual)
                .HasForeignKey(d => d.CoDimUnidadeSaude)
                .HasConstraintName("fk_dimunidadesaude_fatcadindvd");

            entity.HasOne(d => d.CoFatCidadaoPecNavigation).WithMany(p => p.TbFatCadIndividualCoFatCidadaoPecNavigation)
                .HasForeignKey(d => d.CoFatCidadaoPec)
                .HasConstraintName("fk_ftciddaopec_fatcadindvd");

            entity.HasOne(d => d.CoFatCidadaoPecResponsvlNavigation).WithMany(p => p.TbFatCadIndividualCoFatCidadaoPecResponsvlNavigation)
                .HasForeignKey(d => d.CoFatCidadaoPecResponsvl)
                .HasConstraintName("fk_ftciddpec_ftcdindvdrsponsvl");
        });

        modelBuilder.Entity<TbFatCidadao>(entity =>
        {
            entity.HasKey(e => e.CoSeqFatCidadao).HasName("pk_fatcadastrocidadao");

            entity.ToTable("tb_fat_cidadao");

            entity.HasIndex(e => e.CoFatCidadaoPai1, "in_fatcidadao_fatcidadaopai1");

            entity.HasIndex(e => e.CoFatCidadaoPai2, "in_fatcidadao_fatcidadaopai2");

            entity.HasIndex(e => e.CoFatCidadaoPai1Equipe, "in_fatcidadao_ftciddpai1equipe");

            entity.HasIndex(e => e.CoFatCidadaoPai1Municipio, "in_fatcidadao_ftciddpai1mncpo");

            entity.HasIndex(e => e.CoFatCidadaoPai1UnddeSade, "in_fatcidadao_ftciddpai1unddsd");

            entity.HasIndex(e => e.CoFatCidadaoPai2Equipe, "in_fatcidadao_ftciddpai2equipe");

            entity.HasIndex(e => e.CoFatCidadaoPai2Municipio, "in_fatcidadao_ftciddpai2mncpo");

            entity.HasIndex(e => e.CoFatCidadaoPai2UnddeSade, "in_fatcidadao_ftciddpai2unddsd");

            entity.HasIndex(e => new { e.NuCns, e.CoDimTempo, e.CoSeqFatCidadao }, "in_fatcidadao_nucns");

            entity.HasIndex(e => new { e.NuCns, e.CoDimMunicipio, e.CoDimUnidadeSaude, e.CoDimEquipe }, "in_fatcidadao_nucnslotacao");

            entity.HasIndex(e => new { e.NuCpfCidadao, e.CoDimTempo, e.CoSeqFatCidadao }, "in_fatcidadao_nucpf");

            entity.HasIndex(e => new { e.NuCpfCidadao, e.CoDimMunicipio, e.CoDimUnidadeSaude, e.CoDimEquipe }, "in_fatcidadao_nucpflotacao");

            entity.HasIndex(e => new { e.NuUuidFichaOrigem, e.CoDimTempo, e.CoSeqFatCidadao }, "in_fatcidadao_nuuuidfichorigem");

            entity.HasIndex(e => new { e.CoDimTempoValidade, e.CoDimTempo }, "in_fatcidadao_periodo");

            entity.HasIndex(e => new { e.CoDimTempoValddEquipe, e.CoDimTempo }, "in_fatcidadao_periodo_equipe");

            entity.HasIndex(e => new { e.CoDimTempoValddMunicipio, e.CoDimTempo }, "in_fatcidadao_periodo_municpo");

            entity.HasIndex(e => new { e.CoFatCadIndividual, e.CoDimTempo, e.CoDimTempoValddEquipe }, "in_fatcidadao_pervalequipe");

            entity.HasIndex(e => new { e.CoFatCadIndividual, e.CoDimTempo, e.CoDimTempoValddMunicipio }, "in_fatcidadao_pervalmunicipio");

            entity.HasIndex(e => new { e.CoFatCadIndividual, e.CoDimTempo, e.CoDimTempoValddUniddSaud }, "in_fatcidadao_prvvalduniddsaud");

            entity.HasIndex(e => new { e.StProcessoLinhaTempo, e.CoDimTempo, e.CoSeqFatCidadao }, "in_fatcidadao_stprcssolnhtempo");

            entity.HasIndex(e => new { e.CoDimTempoValddUniddSaud, e.CoDimTempo }, "in_fatciddo_periodo_undde_sade");

            entity.HasIndex(e => new { e.CoFatCidadaoRaiz, e.CoSeqFatCidadao }, "in_ftcidadao_coftcidrzcosqftcd");

            entity.HasIndex(e => new { e.CoSeqFatCidadao, e.NuCns }, "in_ftcidadao_sqfatcidadaonucns");

            entity.HasIndex(e => new { e.NuCpfCidadao, e.CoSeqFatCidadao }, "in_ftcidadao_sqfatcidadaonucpf");

            entity.Property(e => e.CoSeqFatCidadao)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_fat_cidadao");
            entity.Property(e => e.CoDimEquipe).HasColumnName("co_dim_equipe");
            entity.Property(e => e.CoDimLinhaTempoValddEqup).HasColumnName("co_dim_linha_tempo_valdd_equp");
            entity.Property(e => e.CoDimLinhaTempoValidade).HasColumnName("co_dim_linha_tempo_validade");
            entity.Property(e => e.CoDimLinhaValddMunicipio).HasColumnName("co_dim_linha_valdd_municipio");
            entity.Property(e => e.CoDimLnhVlddUniddSad).HasColumnName("co_dim_lnh_vldd_unidd_sad");
            entity.Property(e => e.CoDimMunicipio).HasColumnName("co_dim_municipio");
            entity.Property(e => e.CoDimTempo).HasColumnName("co_dim_tempo");
            entity.Property(e => e.CoDimTempoValddEquipe).HasColumnName("co_dim_tempo_valdd_equipe");
            entity.Property(e => e.CoDimTempoValddMunicipio).HasColumnName("co_dim_tempo_valdd_municipio");
            entity.Property(e => e.CoDimTempoValddUniddSaud).HasColumnName("co_dim_tempo_valdd_unidd_saud");
            entity.Property(e => e.CoDimTempoValidade).HasColumnName("co_dim_tempo_validade");
            entity.Property(e => e.CoDimUnidadeSaude).HasColumnName("co_dim_unidade_saude");
            entity.Property(e => e.CoFatCadIndividual).HasColumnName("co_fat_cad_individual");
            entity.Property(e => e.CoFatCidadaoPai1)
                .HasComment("Aponta para o fato anterior que o originou e que possui o mesmo CPF ou CNS.")
                .HasColumnName("co_fat_cidadao_pai1");
            entity.Property(e => e.CoFatCidadaoPai1Equipe).HasColumnName("co_fat_cidadao_pai1_equipe");
            entity.Property(e => e.CoFatCidadaoPai1Municipio).HasColumnName("co_fat_cidadao_pai1_municipio");
            entity.Property(e => e.CoFatCidadaoPai1UnddeSade).HasColumnName("co_fat_cidadao_pai1_undde_sade");
            entity.Property(e => e.CoFatCidadaoPai2)
                .HasComment("Aponta para o fato anterior que o originou através da atualização da ficha de origem.")
                .HasColumnName("co_fat_cidadao_pai2");
            entity.Property(e => e.CoFatCidadaoPai2Equipe).HasColumnName("co_fat_cidadao_pai2_equipe");
            entity.Property(e => e.CoFatCidadaoPai2Municipio).HasColumnName("co_fat_cidadao_pai2_municipio");
            entity.Property(e => e.CoFatCidadaoPai2UnddeSade).HasColumnName("co_fat_cidadao_pai2_undde_sade");
            entity.Property(e => e.CoFatCidadaoRaiz)
                .HasComment("Aponta para o fato mais recente sobre um cidadão, uma vez que as informações sobre um cidadão podem ser atualizadas.")
                .HasColumnName("co_fat_cidadao_raiz");
            entity.Property(e => e.CoFatCidadaoRaizEquipe).HasColumnName("co_fat_cidadao_raiz_equipe");
            entity.Property(e => e.CoFatCidadaoRaizMunicipio).HasColumnName("co_fat_cidadao_raiz_municipio");
            entity.Property(e => e.CoFatCidadaoRaizUnddeSade).HasColumnName("co_fat_cidadao_raiz_undde_sade");
            entity.Property(e => e.CoFatFamilia).HasColumnName("co_fat_familia");
            entity.Property(e => e.NuCns)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("nu_cns");
            entity.Property(e => e.NuCpfCidadao)
                .HasMaxLength(11)
                .HasColumnName("nu_cpf_cidadao");
            entity.Property(e => e.NuUuidFicha)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_ficha");
            entity.Property(e => e.NuUuidFichaOrigem)
                .HasMaxLength(96)
                .HasColumnName("nu_uuid_ficha_origem");
            entity.Property(e => e.StAtivoTerritorio).HasColumnName("st_ativo_territorio");
            entity.Property(e => e.StFichaInativa).HasColumnName("st_ficha_inativa");
            entity.Property(e => e.StMudou).HasColumnName("st_mudou");
            entity.Property(e => e.StProcessoFamilia).HasColumnName("st_processo_familia");
            entity.Property(e => e.StProcessoLinhaTempo)
                .HasComment("Representa o estágio do processamento da árvore de atualizações e da linha do tempo de um fato sobre um cidadão (2 - Cálculo da árvore; 1 - Cálculo da linha do tempo; 0 - Árvore e linha do tempo calculadas)")
                .HasColumnName("st_processo_linha_tempo");
            entity.Property(e => e.StResponsavelFamiliar).HasColumnName("st_responsavel_familiar");
            entity.Property(e => e.StVivo).HasColumnName("st_vivo");

            entity.HasOne(d => d.CoDimEquipeNavigation).WithMany(p => p.TbFatCidadao)
                .HasForeignKey(d => d.CoDimEquipe)
                .HasConstraintName("fk_dimequipe_fatcddtrrtr");

            entity.HasOne(d => d.CoDimLinhaTempoValddEqupNavigation).WithMany(p => p.TbFatCidadaoCoDimLinhaTempoValddEqupNavigation)
                .HasForeignKey(d => d.CoDimLinhaTempoValddEqup)
                .HasConstraintName("fk_dmtempo_fatcddalnhvlddequp");

            entity.HasOne(d => d.CoDimLinhaTempoValidadeNavigation).WithMany(p => p.TbFatCidadaoCoDimLinhaTempoValidadeNavigation)
                .HasForeignKey(d => d.CoDimLinhaTempoValidade)
                .HasConstraintName("fk_dmtempo_fatcddalinhavaldd");

            entity.HasOne(d => d.CoDimLinhaValddMunicipioNavigation).WithMany(p => p.TbFatCidadaoCoDimLinhaValddMunicipioNavigation)
                .HasForeignKey(d => d.CoDimLinhaValddMunicipio)
                .HasConstraintName("fk_dmtempo_fatcddalnhvlddmncpo");

            entity.HasOne(d => d.CoDimLnhVlddUniddSadNavigation).WithMany(p => p.TbFatCidadaoCoDimLnhVlddUniddSadNavigation)
                .HasForeignKey(d => d.CoDimLnhVlddUniddSad)
                .HasConstraintName("fk_dmtmp_fatcddalnhvlddunddsad");

            entity.HasOne(d => d.CoDimMunicipioNavigation).WithMany(p => p.TbFatCidadao)
                .HasForeignKey(d => d.CoDimMunicipio)
                .HasConstraintName("fk_dimmunicipio_fatcddtrrtr");

            entity.HasOne(d => d.CoDimTempoNavigation).WithMany(p => p.TbFatCidadaoCoDimTempoNavigation)
                .HasForeignKey(d => d.CoDimTempo)
                .HasConstraintName("fk_dmtempo_fatcidadao");

            entity.HasOne(d => d.CoDimTempoValddEquipeNavigation).WithMany(p => p.TbFatCidadaoCoDimTempoValddEquipeNavigation)
                .HasForeignKey(d => d.CoDimTempoValddEquipe)
                .HasConstraintName("fk_dmtempo_fatcddavalidadeequp");

            entity.HasOne(d => d.CoDimTempoValddMunicipioNavigation).WithMany(p => p.TbFatCidadaoCoDimTempoValddMunicipioNavigation)
                .HasForeignKey(d => d.CoDimTempoValddMunicipio)
                .HasConstraintName("fk_dmtempo_fatcddavlddmncpo");

            entity.HasOne(d => d.CoDimTempoValddUniddSaudNavigation).WithMany(p => p.TbFatCidadaoCoDimTempoValddUniddSaudNavigation)
                .HasForeignKey(d => d.CoDimTempoValddUniddSaud)
                .HasConstraintName("fk_dmtempo_fatcddavlddunddsaud");

            entity.HasOne(d => d.CoDimTempoValidadeNavigation).WithMany(p => p.TbFatCidadaoCoDimTempoValidadeNavigation)
                .HasForeignKey(d => d.CoDimTempoValidade)
                .HasConstraintName("fk_dmtempo_fatcidadao_validade");

            entity.HasOne(d => d.CoDimUnidadeSaudeNavigation).WithMany(p => p.TbFatCidadao)
                .HasForeignKey(d => d.CoDimUnidadeSaude)
                .HasConstraintName("fk_dimunidadesaude_fatcddtrrtr");
        });

        modelBuilder.Entity<TbFatCidadaoPec>(entity =>
        {
            entity.HasKey(e => e.CoSeqFatCidadaoPec).HasName("pk_ftciddaopec");

            entity.ToTable("tb_fat_cidadao_pec");

            entity.HasIndex(e => new { e.StLookupEtl, e.CoSeqFatCidadaoPec }, "in_fat_cidadaopec_lookup");

            entity.HasIndex(e => e.CoCidadao, "in_fatcidadaopec_cocidadao");

            entity.HasIndex(e => new { e.CoDimUnidadeSaudeVinc, e.CoDimEquipeVinc }, "in_fatcidadapec_cnesine");

            entity.HasIndex(e => new { e.CoCidadao, e.CoSeqFatCidadaoPec }, "in_fatcidpec_cocidcofatcidpec");

            entity.HasIndex(e => e.NuCns, "in_fatcidpec_nucns");

            entity.HasIndex(e => new { e.NuCns, e.CoSeqFatCidadaoPec }, "in_fatcidpec_nucns_coseqfatcidpec_cnsisnull").HasFilter("(nu_cns IS NULL)");

            entity.HasIndex(e => new { e.NuCns, e.CoSeqFatCidadaoPec }, "in_fatcidpec_nucns_coseqfatcidpec_cnsnotnull").HasFilter("(nu_cns IS NOT NULL)");

            entity.HasIndex(e => new { e.NuCns, e.CoSeqFatCidadaoPec }, "in_fatcidpec_nucns_coseqfatcidpec_cpfisnull").HasFilter("(nu_cpf_cidadao IS NULL)");

            entity.HasIndex(e => new { e.NuCns, e.CoSeqFatCidadaoPec }, "in_fatcidpec_nucns_coseqfatcidpec_cpfnotnull").HasFilter("(nu_cpf_cidadao IS NOT NULL)");

            entity.HasIndex(e => e.NuCpfCidadao, "in_fatcidpec_nucpf");

            entity.HasIndex(e => new { e.CoCidadao, e.NuCns }, "in_ftciddaopec_cidadaocns");

            entity.HasIndex(e => new { e.CoCidadao, e.NuCpfCidadao }, "in_ftciddaopec_cidadaocpf");

            entity.HasIndex(e => new { e.NuCns, e.CoSeqFatCidadaoPec }, "in_ftcidpec_cnscosqcpfisnull").HasFilter("(nu_cpf_cidadao IS NULL)");

            entity.HasIndex(e => new { e.NuCns, e.CoSeqFatCidadaoPec }, "in_ftcidpec_cnscosqcpfnotnull").HasFilter("(nu_cpf_cidadao IS NOT NULL)");

            entity.HasIndex(e => new { e.NuCpfCidadao, e.CoSeqFatCidadaoPec }, "in_ftcidpec_cpfcosqcnsisnull").HasFilter("(nu_cns IS NULL)");

            entity.HasIndex(e => new { e.NuCpfCidadao, e.CoSeqFatCidadaoPec }, "in_ftcidpec_cpfcosqcnsnotnull").HasFilter("(nu_cns IS NOT NULL)");

            entity.HasIndex(e => e.NuCns, "in_ftcidpec_nucns");

            entity.HasIndex(e => e.NuCpfCidadao, "in_ftcidpec_nucpf");

            entity.Property(e => e.CoSeqFatCidadaoPec)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_fat_cidadao_pec");
            entity.Property(e => e.CoCidadao).HasColumnName("co_cidadao");
            entity.Property(e => e.CoDimEquipeVinc).HasColumnName("co_dim_equipe_vinc");
            entity.Property(e => e.CoDimIdentidadeGenero).HasColumnName("co_dim_identidade_genero");
            entity.Property(e => e.CoDimSexo).HasColumnName("co_dim_sexo");
            entity.Property(e => e.CoDimTempoNascimento).HasColumnName("co_dim_tempo_nascimento");
            entity.Property(e => e.CoDimUnidadeSaudeVinc).HasColumnName("co_dim_unidade_saude_vinc");
            entity.Property(e => e.NoCidadao)
                .HasMaxLength(500)
                .HasColumnName("no_cidadao");
            entity.Property(e => e.NoSocialCidadao)
                .HasMaxLength(500)
                .HasColumnName("no_social_cidadao");
            entity.Property(e => e.NuCns)
                .HasMaxLength(15)
                .HasColumnName("nu_cns");
            entity.Property(e => e.NuCpfCidadao)
                .HasMaxLength(11)
                .HasColumnName("nu_cpf_cidadao");
            entity.Property(e => e.NuTelefoneCelular)
                .HasMaxLength(100)
                .HasColumnName("nu_telefone_celular");
            entity.Property(e => e.StDeletar).HasColumnName("st_deletar");
            entity.Property(e => e.StFaleceu).HasColumnName("st_faleceu");
            entity.Property(e => e.StLookupEtl).HasColumnName("st_lookup_etl");

            entity.HasOne(d => d.CoDimEquipeVincNavigation).WithMany(p => p.TbFatCidadaoPec)
                .HasForeignKey(d => d.CoDimEquipeVinc)
                .HasConstraintName("fk_dimequipvinc_fatcidpec");

            entity.HasOne(d => d.CoDimIdentidadeGeneroNavigation).WithMany(p => p.TbFatCidadaoPec)
                .HasForeignKey(d => d.CoDimIdentidadeGenero)
                .HasConstraintName("fk_dimidgenero_fatcidadaopec");

            entity.HasOne(d => d.CoDimSexoNavigation).WithMany(p => p.TbFatCidadaoPec)
                .HasForeignKey(d => d.CoDimSexo)
                .HasConstraintName("fk_dimsexo_ftrlociddao");

            entity.HasOne(d => d.CoDimUnidadeSaudeVincNavigation).WithMany(p => p.TbFatCidadaoPec)
                .HasForeignKey(d => d.CoDimUnidadeSaudeVinc)
                .HasConstraintName("fk_dimundsaudevinc_fatcidpec");
        });

        modelBuilder.Entity<TbFatFichas>(entity =>
        {
            entity.HasKey(e => e.CoSeqFatFichas).HasName("pk_fatfichas");

            entity.ToTable("tb_fat_fichas");

            entity.HasIndex(e => e.NuUuidDadoTransp, "in_fatfichas_uuiddadotransp");

            entity.HasIndex(e => e.NuUuidFicha, "in_fatfichas_uuidficha");

            entity.Property(e => e.CoSeqFatFichas)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_fat_fichas");
            entity.Property(e => e.CoDimCdsTipoOrigem).HasColumnName("co_dim_cds_tipo_origem");
            entity.Property(e => e.CoDimEquipe).HasColumnName("co_dim_equipe");
            entity.Property(e => e.CoDimMunicipio).HasColumnName("co_dim_municipio");
            entity.Property(e => e.CoDimTempo).HasColumnName("co_dim_tempo");
            entity.Property(e => e.CoDimTipoFicha).HasColumnName("co_dim_tipo_ficha");
            entity.Property(e => e.CoDimTipoOrigemDadoTransp).HasColumnName("co_dim_tipo_origem_dado_transp");
            entity.Property(e => e.CoDimUnidadeSaude).HasColumnName("co_dim_unidade_saude");
            entity.Property(e => e.NuUuidDadoTransp)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_dado_transp");
            entity.Property(e => e.NuUuidFicha)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_ficha");

            entity.HasOne(d => d.CoDimCdsTipoOrigemNavigation).WithMany(p => p.TbFatFichas)
                .HasForeignKey(d => d.CoDimCdsTipoOrigem)
                .HasConstraintName("fk_dimtporigem_atfichas");

            entity.HasOne(d => d.CoDimEquipeNavigation).WithMany(p => p.TbFatFichas)
                .HasForeignKey(d => d.CoDimEquipe)
                .HasConstraintName("fk_dimequipe_fatfichas");

            entity.HasOne(d => d.CoDimMunicipioNavigation).WithMany(p => p.TbFatFichas)
                .HasForeignKey(d => d.CoDimMunicipio)
                .HasConstraintName("fk_dimmunicipio_fatfichas");

            entity.HasOne(d => d.CoDimTempoNavigation).WithMany(p => p.TbFatFichas)
                .HasForeignKey(d => d.CoDimTempo)
                .HasConstraintName("fk_dimtempo_fatfichas");

            entity.HasOne(d => d.CoDimTipoFichaNavigation).WithMany(p => p.TbFatFichas)
                .HasForeignKey(d => d.CoDimTipoFicha)
                .HasConstraintName("fk_dimtipoficha_fatfichas");

            entity.HasOne(d => d.CoDimTipoOrigemDadoTranspNavigation).WithMany(p => p.TbFatFichas)
                .HasForeignKey(d => d.CoDimTipoOrigemDadoTransp)
                .HasConstraintName("fk_dmtporgddt_fatfichas");

            entity.HasOne(d => d.CoDimUnidadeSaudeNavigation).WithMany(p => p.TbFatFichas)
                .HasForeignKey(d => d.CoDimUnidadeSaude)
                .HasConstraintName("fk_dimunidadesaude_fatfichas");
        });

        modelBuilder.Entity<TbFatProcedAtend>(entity =>
        {
            entity.HasKey(e => e.CoSeqFatProcedAtend).HasName("pk_ftprocedatend");

            entity.ToTable("tb_fat_proced_atend");

            entity.HasIndex(e => e.CoFatCidadaoPec, "idx_ftprocedatend_cidaddgrpo");

            entity.HasIndex(e => new { e.CoFatCidadaoPec, e.CoSeqFatProcedAtend }, "in_fat_procedatd_cidadao_coseq");

            entity.HasIndex(e => new { e.NuUuidFicha, e.NuCpfCidadao }, "in_fatprocedatend_hist_cpf");

            entity.HasIndex(e => new { e.NuUuidFicha, e.NuCns }, "in_fatprocedatend_historico");

            entity.HasIndex(e => e.NuUuidFicha, "in_fatprocedatend_uuidficha");

            entity.HasIndex(e => new { e.CoDimTempo, e.NuUuidFicha, e.NuAtendimento }, "in_ftprocedatend_ficha");

            entity.HasIndex(e => new { e.CoDimTempo, e.CoDimMunicipio, e.CoDimUnidadeSaude, e.CoDimEquipe, e.CoDimProfissional, e.CoDimCbo }, "in_ftprocedatend_header");

            entity.Property(e => e.CoSeqFatProcedAtend)
                .ValueGeneratedNever()
                .HasColumnName("co_seq_fat_proced_atend");
            entity.Property(e => e.CoDimCbo).HasColumnName("co_dim_cbo");
            entity.Property(e => e.CoDimCdsTipoOrigem).HasColumnName("co_dim_cds_tipo_origem");
            entity.Property(e => e.CoDimEquipe).HasColumnName("co_dim_equipe");
            entity.Property(e => e.CoDimFaixaEtaria).HasColumnName("co_dim_faixa_etaria");
            entity.Property(e => e.CoDimLocalAtendimento).HasColumnName("co_dim_local_atendimento");
            entity.Property(e => e.CoDimMunicipio).HasColumnName("co_dim_municipio");
            entity.Property(e => e.CoDimProfissional).HasColumnName("co_dim_profissional");
            entity.Property(e => e.CoDimSexo).HasColumnName("co_dim_sexo");
            entity.Property(e => e.CoDimTempo).HasColumnName("co_dim_tempo");
            entity.Property(e => e.CoDimTipoFicha).HasColumnName("co_dim_tipo_ficha");
            entity.Property(e => e.CoDimTipoOrigemDadoTransp).HasColumnName("co_dim_tipo_origem_dado_transp");
            entity.Property(e => e.CoDimTurno).HasColumnName("co_dim_turno");
            entity.Property(e => e.CoDimUnidadeSaude).HasColumnName("co_dim_unidade_saude");
            entity.Property(e => e.CoFatCidadaoPec).HasColumnName("co_fat_cidadao_pec");
            entity.Property(e => e.CoFatProcedimento).HasColumnName("co_fat_procedimento");
            entity.Property(e => e.DsFiltroProcedimento)
                .HasMaxLength(4000)
                .HasColumnName("ds_filtro_procedimento");
            entity.Property(e => e.DtFinalAtendimento).HasColumnName("dt_final_atendimento");
            entity.Property(e => e.DtInicialAtendimento).HasColumnName("dt_inicial_atendimento");
            entity.Property(e => e.DtNascimento).HasColumnName("dt_nascimento");
            entity.Property(e => e.NuAltura).HasColumnName("nu_altura");
            entity.Property(e => e.NuAtendimento).HasColumnName("nu_atendimento");
            entity.Property(e => e.NuCns)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("nu_cns");
            entity.Property(e => e.NuCpfCidadao)
                .HasMaxLength(11)
                .HasColumnName("nu_cpf_cidadao");
            entity.Property(e => e.NuPeso).HasColumnName("nu_peso");
            entity.Property(e => e.NuProntuario)
                .HasMaxLength(65)
                .HasColumnName("nu_prontuario");
            entity.Property(e => e.NuUuidDadoTransp)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_dado_transp");
            entity.Property(e => e.NuUuidFicha)
                .HasMaxLength(92)
                .HasColumnName("nu_uuid_ficha");
            entity.Property(e => e.StEscutaInicial).HasColumnName("st_escuta_inicial");

            entity.HasOne(d => d.CoDimCboNavigation).WithMany(p => p.TbFatProcedAtend)
                .HasForeignKey(d => d.CoDimCbo)
                .HasConstraintName("fk_dimcbo_ftprocedatend");

            entity.HasOne(d => d.CoDimCdsTipoOrigemNavigation).WithMany(p => p.TbFatProcedAtend)
                .HasForeignKey(d => d.CoDimCdsTipoOrigem)
                .HasConstraintName("fk_dimtporigem_ftprocedatend");

            entity.HasOne(d => d.CoDimEquipeNavigation).WithMany(p => p.TbFatProcedAtend)
                .HasForeignKey(d => d.CoDimEquipe)
                .HasConstraintName("fk_dimequipe_ftprocedatend");

            entity.HasOne(d => d.CoDimFaixaEtariaNavigation).WithMany(p => p.TbFatProcedAtend)
                .HasForeignKey(d => d.CoDimFaixaEtaria)
                .HasConstraintName("fk_dimfxaetaria_ftprocedatend");

            entity.HasOne(d => d.CoDimLocalAtendimentoNavigation).WithMany(p => p.TbFatProcedAtend)
                .HasForeignKey(d => d.CoDimLocalAtendimento)
                .HasConstraintName("fk_dimlocalatend_ftprocedatend");

            entity.HasOne(d => d.CoDimMunicipioNavigation).WithMany(p => p.TbFatProcedAtend)
                .HasForeignKey(d => d.CoDimMunicipio)
                .HasConstraintName("fk_dimmunicipio_ftprocedatend");

            entity.HasOne(d => d.CoDimProfissionalNavigation).WithMany(p => p.TbFatProcedAtend)
                .HasForeignKey(d => d.CoDimProfissional)
                .HasConstraintName("fk_dimprofissinl_ftprocedatend");

            entity.HasOne(d => d.CoDimSexoNavigation).WithMany(p => p.TbFatProcedAtend)
                .HasForeignKey(d => d.CoDimSexo)
                .HasConstraintName("fk_dimsexo_ftprocedatend");

            entity.HasOne(d => d.CoDimTempoNavigation).WithMany(p => p.TbFatProcedAtend)
                .HasForeignKey(d => d.CoDimTempo)
                .HasConstraintName("fk_dimtempo_ftprocedatend");

            entity.HasOne(d => d.CoDimTipoFichaNavigation).WithMany(p => p.TbFatProcedAtend)
                .HasForeignKey(d => d.CoDimTipoFicha)
                .HasConstraintName("fk_dimtipoficha_ftprocedatend");

            entity.HasOne(d => d.CoDimTipoOrigemDadoTranspNavigation).WithMany(p => p.TbFatProcedAtend)
                .HasForeignKey(d => d.CoDimTipoOrigemDadoTransp)
                .HasConstraintName("fk_dmtporgddt_ftprocedatend");

            entity.HasOne(d => d.CoDimTurnoNavigation).WithMany(p => p.TbFatProcedAtend)
                .HasForeignKey(d => d.CoDimTurno)
                .HasConstraintName("fk_dimturno_ftprocedatend");

            entity.HasOne(d => d.CoDimUnidadeSaudeNavigation).WithMany(p => p.TbFatProcedAtend)
                .HasForeignKey(d => d.CoDimUnidadeSaude)
                .HasConstraintName("fk_dimuniddsade_ftprocedatend");

            entity.HasOne(d => d.CoFatCidadaoPecNavigation).WithMany(p => p.TbFatProcedAtend)
                .HasForeignKey(d => d.CoFatCidadaoPec)
                .HasConstraintName("fk_ftciddaopec_ftprocedatend");
        });

        modelBuilder.Entity<Unidadeequipe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("unidadeequipe_pkey");

            entity.ToTable("unidadeequipe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cbo)
                .HasMaxLength(20)
                .HasColumnName("cbo");
            entity.Property(e => e.Deletado).HasColumnName("deletado");
            entity.Property(e => e.Equipe)
                .HasMaxLength(20)
                .HasColumnName("equipe");
            entity.Property(e => e.Microarea)
                .HasMaxLength(20)
                .HasColumnName("microarea");
            entity.Property(e => e.Unidade)
                .HasMaxLength(20)
                .HasColumnName("unidade");
            entity.Property(e => e.Usuarioid).HasColumnName("usuarioid");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("Usuario_pkey");

            entity.HasIndex(e => e.PerfilId, "FK_Usuario_Perfil");

            entity.Property(e => e.AlteradoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Cns).HasMaxLength(300);
            entity.Property(e => e.CriadoEm).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Email).HasMaxLength(300);
            entity.Property(e => e.Login).HasMaxLength(100);
            entity.Property(e => e.Nome).HasMaxLength(300);
            entity.Property(e => e.Senha).HasMaxLength(100);

            entity.HasOne(d => d.Perfil).WithMany(p => p.Usuario)
                .HasForeignKey(d => d.PerfilId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Usuario_Perfil");
        });

        modelBuilder.Entity<UsuarioMunicipio>(entity =>
        {
            entity.HasKey(e => e.UsuarioMunicipioId).HasName("UsuarioMunicipio_pkey");

            entity.HasIndex(e => e.MunicipioId, "FK_UsuarioMunicipio_Municipio");

            entity.HasIndex(e => e.UsuarioId, "FK_UsuarioMunicipio_Usuario");

            entity.HasOne(d => d.Municipio).WithMany(p => p.UsuarioMunicipio)
                .HasForeignKey(d => d.MunicipioId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UsuarioMunicipio_Municipio");

            entity.HasOne(d => d.Usuario).WithMany(p => p.UsuarioMunicipio)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UsuarioMunicipio_Usuario");
        });

        modelBuilder.Entity<GiCofinNomesKey>(entity =>
        {
            entity.HasKey(e => e.IdCofinNomesKey).HasName("pk_gi_cofin_nomes_key");

            entity.ToTable("gi_cofin_nomes_key");

            entity.Property(e => e.IdCofinNomesKey)
                .ValueGeneratedNever()
                .HasColumnName("id_cofin_nomes_key");
            entity.Property(e => e.NoCidadao)
                .HasMaxLength(500)
                .HasColumnName("no_cidadao");
            entity.Property(e => e.NuCns)
                .HasMaxLength(15)
                .HasColumnName("nu_cns");
            entity.Property(e => e.NuCpfCidadao)
                .HasMaxLength(11)
                .HasColumnName("nu_cpf_cidadao");
            entity.Property(e => e.StOrigem).HasColumnName("st_origem");
        });

        modelBuilder.Entity<GiCofinNomesCodf>(entity =>
        {
            entity.HasKey(e => e.IdCofinNomesCodf).HasName("pk_gi_cofin_nomes_codf");

            entity.ToTable("gi_cofin_nomes_codf");

            entity.Property(e => e.IdCofinNomesCodf)
                .ValueGeneratedNever()
                .HasColumnName("id_cofin_nomes_codf");
            entity.Property(e => e.NoCidadao)
                .HasMaxLength(500)
                .HasColumnName("no_cidadao");
            entity.Property(e => e.NuCns)
                .HasMaxLength(15)
                .HasColumnName("nu_cns");
            entity.Property(e => e.NuCpfCidadao)
                .HasMaxLength(11)
                .HasColumnName("nu_cpf_cidadao");
            entity.Property(e => e.StOrigem).HasColumnName("st_origem");
        });


        modelBuilder.Entity<Vwfichasappterritorio>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwfichasappterritorio");

            entity.Property(e => e.CoSeqRecebLote).HasColumnName("co_seq_receb_lote");
            entity.Property(e => e.DtRecebimento).HasColumnName("dt_recebimento");
            entity.Property(e => e.NoResponsavelEnvio)
                .HasMaxLength(256)
                .HasColumnName("no_responsavel_envio");
            entity.Property(e => e.NuIdentificadorResponsavel)
                .HasMaxLength(20)
                .HasColumnName("nu_identificador_responsavel");
            entity.Property(e => e.NuLoteOriginadora).HasColumnName("nu_lote_originadora");
            entity.Property(e => e.QtFichas).HasColumnName("qt_fichas");
        });
        modelBuilder.HasSequence("CitoSisab_consultaId_seq");
        modelBuilder.HasSequence("DiabetesSisab_consultaId_seq");
        modelBuilder.HasSequence("gi_IndicadorGestantesConsultas_seq");
        modelBuilder.HasSequence("gisalog_eventoid_seq");
        modelBuilder.HasSequence("HiperSisab_consultaId_seq");
        modelBuilder.HasSequence("sq_acesso_coseqacesso");
        modelBuilder.HasSequence("sq_acmpcvncprc_csqacmpcvncprc");
        modelBuilder.HasSequence("sq_acompcvinc_coseqacompcvinc");
        modelBuilder.HasSequence("sq_adcidadao_coseqadcidadao");
        modelBuilder.HasSequence("sq_adcidadaohstr_coseqadcddhst");
        modelBuilder.HasSequence("sq_addestino_coseqaddestino").StartsAt(8L);
        modelBuilder.HasSequence("sq_admodalidade_coseqadmodaldd").StartsAt(4L);
        modelBuilder.HasSequence("sq_adorigem_coseqadorigem").StartsAt(16L);
        modelBuilder.HasSequence("sq_adquestao_coseqadquestao");
        modelBuilder.HasSequence("sq_adresposta_coseqadresposta");
        modelBuilder.HasSequence("sq_adsyncentity_coseqsyncentty");
        modelBuilder.HasSequence("sq_adtriaevnto_sqadtriaevnto");
        modelBuilder.HasSequence("sq_agendado_coseqagendado");
        modelBuilder.HasSequence("sq_agendcomp_coseqagendcomp");
        modelBuilder.HasSequence("sq_alergia_coseqalergia");
        modelBuilder.HasSequence("sq_alergiaevo_coseqalergiaevo");
        modelBuilder.HasSequence("sq_antecedentehstr_coseqanthst");
        modelBuilder.HasSequence("sq_antecedenteitem_coseqantitm");
        modelBuilder.HasSequence("sq_arquivo_coseqarquivo");
        modelBuilder.HasSequence("sq_atdprfadqst_coseqatdprfadqs");
        modelBuilder.HasSequence("sq_atdprftipencint_coseqatdprf");
        modelBuilder.HasSequence("sq_atend_coseqatend");
        modelBuilder.HasSequence("sq_atendobsresponsavel_coseq");
        modelBuilder.HasSequence("sq_atendproced_coseqatendprocd");
        modelBuilder.HasSequence("sq_atendprof_coseqatendprof");
        modelBuilder.HasSequence("sq_atestado_coseqatestado");
        modelBuilder.HasSequence("sq_ativcolgrpo_coseqatvcolgrpo");
        modelBuilder.HasSequence("sq_ator_coseqator");
        modelBuilder.HasSequence("sq_atorpapel_coseqatorpapel").IncrementsBy(50);
        modelBuilder.HasSequence("sq_atvcgndmntnln_csqtvcgndmntn");
        modelBuilder.HasSequence("sq_auditproc_coseqauditproc");
        modelBuilder.HasSequence("sq_bairro_cobairro").StartsAt(42966L);
        modelBuilder.HasSequence("sq_cboatend_coseqcboatend");
        modelBuilder.HasSequence("sq_cddnclfmlr_coseqciddnclfml");
        modelBuilder.HasSequence("sq_cdsatend_coseqcdsatend");
        modelBuilder.HasSequence("sq_cdsatendodonto_coseqatdodnt");
        modelBuilder.HasSequence("sq_cdsatendproced_coseqatdprcd");
        modelBuilder.HasSequence("sq_cdsatnddom_coseqcdsatddom");
        modelBuilder.HasSequence("sq_cdsavalelegbldd_coseqavlelg");
        modelBuilder.HasSequence("sq_cdscaddomcfaml_coseqcaddomc");
        modelBuilder.HasSequence("sq_cdscaddomicilr_coseqcaddomc");
        modelBuilder.HasSequence("sq_cdscadindividul_coseqcadind");
        modelBuilder.HasSequence("sq_cdscidadaresp_coseqciddresp");
        modelBuilder.HasSequence("sq_cdsdomclresp_coseqdomclresp");
        modelBuilder.HasSequence("sq_cdsfchatdodt_coseqfchatdodt");
        modelBuilder.HasSequence("sq_cdsfchatdom_coseqfchatddom");
        modelBuilder.HasSequence("sq_cdsfchativcol_coseqfchativc");
        modelBuilder.HasSequence("sq_cdsfchatvcolprt_coseqfchatv");
        modelBuilder.HasSequence("sq_cdsfchcnsalm_coseqfchcnsalm");
        modelBuilder.HasSequence("sq_cdsfchvstdomclr_coseqfchvst");
        modelBuilder.HasSequence("sq_cdsffichazika_coseqfichazik");
        modelBuilder.HasSequence("sq_cdsfichaatend_coseqfichaatd");
        modelBuilder.HasSequence("sq_cdsfichaproced_coseqfichprc");
        modelBuilder.HasSequence("sq_cdsfichavacinc_coseqfichvcn");
        modelBuilder.HasSequence("sq_cdsprof_coseqcdsprof");
        modelBuilder.HasSequence("sq_cdsvacina_coseqvacina");
        modelBuilder.HasSequence("sq_cdsvacinacao_coseqvacinacao");
        modelBuilder.HasSequence("sq_cdsvstdomclr_coseqvstdomclr");
        modelBuilder.HasSequence("sq_cfgagdfechmnt_coseqagdfchmt");
        modelBuilder.HasSequence("sq_cfgagenda_coseqcfgagenda").IncrementsBy(50);
        modelBuilder.HasSequence("sq_cfgagendamun_coseqcfgagndmn");
        modelBuilder.HasSequence("sq_cfgagnddtlh_coseqcfgagnddtl")
            .StartsAt(9847L)
            .IncrementsBy(50);
        modelBuilder.HasSequence("sq_cfgagondtl_coseqcfgagondtl");
        modelBuilder.HasSequence("sq_cfgcertificado_coseq");
        modelBuilder.HasSequence("sq_ciap_coseqciap").StartsAt(751L);
        modelBuilder.HasSequence("sq_cidadao_coseqcidadao").StartsAt(26452L);
        modelBuilder.HasSequence("sq_cidadgrupo_cosqcidadgrupo");
        modelBuilder.HasSequence("sq_cidgrupoac_coseqcidadaoac");
        modelBuilder.HasSequence("sq_cidvncleqp_coseqcidvnclceqp");
        modelBuilder.HasSequence("sq_cnes_coseqcnes");
        modelBuilder.HasSequence("sq_compartilhaprnt_coseqcmpprn");
        modelBuilder.HasSequence("sq_configagdubs_coseqcfgagdubs");
        modelBuilder.HasSequence("sq_configagenda_coseqconfigagn");
        modelBuilder.HasSequence("sq_configatcdmc_coseqcfgatcdmc");
        modelBuilder.HasSequence("sq_configatddom_coseqcfgatddom");
        modelBuilder.HasSequence("sq_confighorario_coseqcfghorar");
        modelBuilder.HasSequence("sq_contato_coseqcontato");
        modelBuilder.HasSequence("sq_crdnclrcbmnt_coseqcrdnclrcb");
        modelBuilder.HasSequence("sq_crrgsintrnc_cosqcrrgsintrnc");
        modelBuilder.HasSequence("sq_dadorecbdcmp_coseqdadrcbcmp");
        modelBuilder.HasSequence("sq_dadorecbonline_coseqdadorcb");
        modelBuilder.HasSequence("sq_dadotransp_coseqdadotransp");
        modelBuilder.HasSequence("sq_dadotrnreceb_coseqdadoreceb");
        modelBuilder.HasSequence("sq_dadrcberrvld_coseqdadrcberr");
        modelBuilder.HasSequence("sq_dadrcberrvldmsg_coseqdadrcb");
        modelBuilder.HasSequence("sq_dadrcbinfins_coseqddrcbnfns");
        modelBuilder.HasSequence("sq_dadrcbitmmet_coseqdadrcbitm");
        modelBuilder.HasSequence("sq_dadrcbmetinf_coseqdadrbcmet");
        modelBuilder.HasSequence("sq_dadrelprcs_cosqdadrelprcs");
        modelBuilder.HasSequence("sq_dadtrngrdlcl_coseqdadtrngrd");
        modelBuilder.HasSequence("sq_dcb_coseqdcb");
        modelBuilder.HasSequence("sq_dimagrupafi_coseqdimagrupaf").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimcatmat_coseqdimcatmat").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimcbo_coseqdimcbo").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimciap_coseqdimciap").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimcid_coseqdimcid").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimclasrsc_coseqdimclasrsc").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimdrctrmd_coseqdimdrctrmd").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimdsfrq_coseqdimdsfrq").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimdsfrqmd_coseqdimdsfrqmd").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimequipe_coseqdimequipe").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimespec_coseqdimespec").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimfrmfarm_coseqdimfrmfarm").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimgpatend_csqdimgpatend");
        modelBuilder.HasSequence("sq_dimimuno_csqdimunobiologico");
        modelBuilder.HasSequence("sq_diminep_cosqdiminep").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimmicroarea_coseqdimmicror").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimmunicipio_coseqdimmuncpo").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimpais_coseqdimpais").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimpct_csqdimpct");
        modelBuilder.HasSequence("sq_dimproced_coseqdimproced").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimprofissional_coseqdimprf").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimtpglic_coseqdimtpglic").StartsAt(5L);
        modelBuilder.HasSequence("sq_dimuf_coseqdimuf").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimunidadsad_coseqdimundsad").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimviaadm_coseqdimviaadm").StartsAt(2L);
        modelBuilder.HasSequence("sq_dimziktpex_coseqdimziktpex").StartsAt(2L);
        modelBuilder.HasSequence("sq_dmcddgrp_cosqdmcddgrp").StartsAt(2L);
        modelBuilder.HasSequence("sq_dmgrpcbo_csqdmgrpcbo").StartsAt(2L);
        modelBuilder.HasSequence("sq_dmvincequip_cosqdmvincequip");
        modelBuilder.HasSequence("sq_domicilio_coseqcdsdomicilio");
        modelBuilder.HasSequence("sq_encaminhamento_coseqencam");
        modelBuilder.HasSequence("sq_endereco_coseqendereco");
        modelBuilder.HasSequence("sq_endereco_coseqenderecoext");
        modelBuilder.HasSequence("sq_envio_coseqenvio");
        modelBuilder.HasSequence("sq_enviolog_coseqenviolog").StartsAt(2L);
        modelBuilder.HasSequence("sq_equipe_coseqequipe").IncrementsBy(50);
        modelBuilder.HasSequence("sq_evlavlciapcid_coseqevlavlci");
        modelBuilder.HasSequence("sq_evlcsbjciap_coseqevlsbjciap");
        modelBuilder.HasSequence("sq_evolplnciap_coseqevlplnciap");
        modelBuilder.HasSequence("sq_evolucaodente_coseqevolcdnt");
        modelBuilder.HasSequence("sq_evolucaoodonto_coseqevlcodt");
        modelBuilder.HasSequence("sq_exameclercret_coseqclercret");
        modelBuilder.HasSequence("sq_exameclstrlt_cosqxclstrlh");
        modelBuilder.HasSequence("sq_exameclstrlt_cosqxclstrll");
        modelBuilder.HasSequence("sq_exameclstrlt_cosqxclstrlt");
        modelBuilder.HasSequence("sq_examecreatserc_coseqcretsrc");
        modelBuilder.HasSequence("sq_examedetalhe_coseqexamedtlh").StartsAt(2L);
        modelBuilder.HasSequence("sq_examedtlhrsl_coseqexmdtlrsl");
        modelBuilder.HasSequence("sq_examehmglglc_coseqexmhmgglc");
        modelBuilder.HasSequence("sq_exameprenatl_coseqexmprentl");
        modelBuilder.HasSequence("sq_examerequisitad_coseqexmrqs");
        modelBuilder.HasSequence("sq_exametriglicr_coseqtriglic");
        modelBuilder.HasSequence("sq_exmpueric_coseqexmpueric");
        modelBuilder.HasSequence("sq_familia_coseqfamilia");
        modelBuilder.HasSequence("sq_fatatddomprb_sqfatenddomprb");
        modelBuilder.HasSequence("sq_fatatddomprc_coseqfatatddom");
        modelBuilder.HasSequence("sq_fatatdind_coseqfatatdind");
        modelBuilder.HasSequence("sq_fatatdindenc_coseqfatatdenc");
        modelBuilder.HasSequence("sq_fatatdindexa_coseqfatatdexa");
        modelBuilder.HasSequence("sq_fatatdindmed_coseqfatatdmed");
        modelBuilder.HasSequence("sq_fatatdindpr_cseqfatatdindpr");
        modelBuilder.HasSequence("sq_fatatdinprd_cseqfatatdinprd");
        modelBuilder.HasSequence("sq_fatatdinprd_csqftatendodpr");
        modelBuilder.HasSequence("sq_fatatdodoenc_coseqfatatdenc");
        modelBuilder.HasSequence("sq_fatatdodoexa_coseqfatatdexa");
        modelBuilder.HasSequence("sq_fatatdodomed_coseqfatatdmed");
        modelBuilder.HasSequence("sq_fatatenddom_coseqfatatddom");
        modelBuilder.HasSequence("sq_fatatendodnt_csqfatatdodnt");
        modelBuilder.HasSequence("sq_fatatvddcltv_sqfatatvddcltv");
        modelBuilder.HasSequence("sq_fatavlelg_coseqfatavlelg");
        modelBuilder.HasSequence("sq_fatcaddomclr_coseqfatcaddom");
        modelBuilder.HasSequence("sq_fatcaddomfml_coseqfatcaddom");
        modelBuilder.HasSequence("sq_fatcadindvdl_coseqfatcadind");
        modelBuilder.HasSequence("sq_fatcidadao_cosqfchacadcddo");
        modelBuilder.HasSequence("sq_fatcmpl_coseqfatcmpl");
        modelBuilder.HasSequence("sq_fatfamilia_coseqfatfamilia");
        modelBuilder.HasSequence("sq_fatfichas_coseqfatfichas");
        modelBuilder.HasSequence("sq_fatmrcconalm");
        modelBuilder.HasSequence("sq_fatvacinacao_csqfatvacnacao");
        modelBuilder.HasSequence("sq_fatvacncvcn_csqfatvacncvcn");
        modelBuilder.HasSequence("sq_fatvisitadom_coseqfatvstdom");
        modelBuilder.HasSequence("sq_ftatnodntprb_csqfatndodnprb");
        modelBuilder.HasSequence("sq_ftatvdcltvpart_sqftatvddclt");
        modelBuilder.HasSequence("sq_ftatvdcltvprprt_sqfatvddclt");
        modelBuilder.HasSequence("sq_ftatvddcltvext_sqftatvddclt");
        modelBuilder.HasSequence("sq_ftatvddcltvint_sqftatvddclt");
        modelBuilder.HasSequence("sq_ftciddaopec_cosqftciddaopec");
        modelBuilder.HasSequence("sq_ftciddotrtro_csqftcidotrtro");
        modelBuilder.HasSequence("sq_ftcoscidfai_cosqftcoscidfai");
        modelBuilder.HasSequence("sq_ftcoscidfao_cosqftcoscidfao");
        modelBuilder.HasSequence("sq_ftcoscidfci_cosqftcoscidfci");
        modelBuilder.HasSequence("sq_ftcoscidfp_cosqftcoscidfp");
        modelBuilder.HasSequence("sq_ftcoscidfvd_cosqftcoscidfvd");
        modelBuilder.HasSequence("sq_ftcscidfcid_cosqftcscidfcid");
        modelBuilder.HasSequence("sq_ftfamlatrtro_csqftfamlattro");
        modelBuilder.HasSequence("sq_ftprcdatndprcd_csqfpatndprd");
        modelBuilder.HasSequence("sq_ftprcdmento_csqftprocd");
        modelBuilder.HasSequence("sq_ftprcdmento_csqftprocdatend");
        modelBuilder.HasSequence("sq_ftrlopcrnca_cosqftrlopcrnca");
        modelBuilder.HasSequence("sq_ftrlopgstte_cosqftrlopgstte");
        modelBuilder.HasSequence("sq_ftrloprccdo_cosqftrloprccdo");
        modelBuilder.HasSequence("sq_grpativcolprof_coseqgrpprof");
        modelBuilder.HasSequence("sq_grpatvclcid_coseqgrpcidadao");
        modelBuilder.HasSequence("sq_grupoac_coseqgrupoac");
        modelBuilder.HasSequence("sq_grupocond_coseqgrupocond");
        modelBuilder.HasSequence("sq_grupoexame_coseqgrupoexame");
        modelBuilder.HasSequence("sq_histcabecal_coseqhistcabec");
        modelBuilder.HasSequence("sq_histunif_cosqhistunif");
        modelBuilder.HasSequence("sq_impcnes_coseqimpcnes");
        modelBuilder.HasSequence("sq_imunobiologicfbrcnt_csqmnfb").StartsAt(38L);
        modelBuilder.HasSequence("sq_imunobiologicolote_cosqmnlt");
        modelBuilder.HasSequence("sq_jstfctvgnd_csqjstfctvgndmnt");
        modelBuilder.HasSequence("sq_justfcstcdd_coseqjststcdd");
        modelBuilder.HasSequence("sq_justificativprt_coseqjstprt");
        modelBuilder.HasSequence("sq_lembrete_coseqlembrete");
        modelBuilder.HasSequence("sq_lembreteevoluca_coseqlbtevl");
        modelBuilder.HasSequence("sq_linkinst_coseqlinkinst");
        modelBuilder.HasSequence("sq_lotetransp_coseqlotetransp");
        modelBuilder.HasSequence("sq_lotetrnitem_coseqlotetrnitm");
        modelBuilder.HasSequence("sq_lotetrnnodo_coseqlotetrnnod");
        modelBuilder.HasSequence("sq_lottrnhisexp_coseqlottrnexp");
        modelBuilder.HasSequence("sq_lottrnitmnod_coseqlottrnitm");
        modelBuilder.HasSequence("sq_ltcrdnclrcbmt_coseqltcrdncl");
        modelBuilder.HasSequence("sq_marcadorconsumoalim_cosqmca");
        modelBuilder.HasSequence("sq_medicamento_coseqmedicament").StartsAt(3339L);
        modelBuilder.HasSequence("sq_medicao_coseqmedicao");
        modelBuilder.HasSequence("sq_medicatipmed_coseqmedtipmed");
        modelBuilder.HasSequence("sq_medusocntn_coseqmedusocntn");
        modelBuilder.HasSequence("sq_microarea_coseqmicroarea");
        modelBuilder.HasSequence("sq_neuroftrrsc_coseqneurftrrsc");
        modelBuilder.HasSequence("sq_neuroltrfnt_coseqneurltrfnt");
        modelBuilder.HasSequence("sq_neuromarco_coseqneuromarco");
        modelBuilder.HasSequence("sq_neuromrcevl_coseqneurmrcevl");
        modelBuilder.HasSequence("sq_nodo_coseqnodo");
        modelBuilder.HasSequence("sq_nrftrrscevl_coseqnrftrrscvl");
        modelBuilder.HasSequence("sq_nrltrfntevl_coseqnrltrfntvl");
        modelBuilder.HasSequence("sq_odontograma_coseqodontogram");
        modelBuilder.HasSequence("sq_orientacao_coseqorientacao");
        modelBuilder.HasSequence("sq_papel_coseqpapel");
        modelBuilder.HasSequence("sq_perfil_coseqperfil").StartsAt(24L);
        modelBuilder.HasSequence("sq_perfilrec_coseqperfilrec");
        modelBuilder.HasSequence("sq_pergunta_coseqpergunta").StartsAt(1002L);
        modelBuilder.HasSequence("sq_periogramacompleto_coseq");
        modelBuilder.HasSequence("sq_periogramasmplificado_coseq");
        modelBuilder.HasSequence("sq_pessoafscimg_coseqpssfscimg");
        modelBuilder.HasSequence("sq_prcdgrpexm_coseqprcdgrpexm");
        modelBuilder.HasSequence("sq_prenatal_coseqprenatal");
        modelBuilder.HasSequence("sq_prntrogruhst_csqprntrogrhst");
        modelBuilder.HasSequence("sq_prntundsaud_coseqprtundsaud");
        modelBuilder.HasSequence("sq_problema_coseqproblema");
        modelBuilder.HasSequence("sq_problemaevoluca_coseqprbevl");
        modelBuilder.HasSequence("sq_procdomcid_coseqprocdomcid");
        modelBuilder.HasSequence("sq_proced_coseqproced");
        modelBuilder.HasSequence("sq_procedautomatic_coseqprcaut").StartsAt(133L);
        modelBuilder.HasSequence("sq_procedexmdtl_coseqprcexmdtl");
        modelBuilder.HasSequence("sq_procedsolic_coseqprocedsolc");
        modelBuilder.HasSequence("sq_processo_coseqprocesso");
        modelBuilder.HasSequence("sq_prochistcds_cosqprochistcds");
        modelBuilder.HasSequence("sq_prof_coseqprof")
            .StartsAt(26776L)
            .IncrementsBy(50);
        modelBuilder.HasSequence("sq_profgrupoac_coseqprofgrpoac");
        modelBuilder.HasSequence("sq_profhiscns_coseqprofhistcns");
        modelBuilder.HasSequence("sq_prontuario_coseqprontuario");
        modelBuilder.HasSequence("sq_qstqstrspndd_coseqqstqstrsp");
        modelBuilder.HasSequence("sq_qstresposta_coseqqstrespost");
        modelBuilder.HasSequence("sq_recebitem_coseqrecebitem");
        modelBuilder.HasSequence("sq_receblote_coseqreclote");
        modelBuilder.HasSequence("sq_receita_coseqreceita");
        modelBuilder.HasSequence("sq_receitamedicmnt_coseqrctmdc");
        modelBuilder.HasSequence("sq_recurso_coseqrecurso");
        modelBuilder.HasSequence("sq_recvaliderr_coseqrecvalider");
        modelBuilder.HasSequence("sq_regvacinacao_coseqregvacinc");
        modelBuilder.HasSequence("sq_relatorioacs_coseqrelatracs");
        modelBuilder.HasSequence("sq_relatorioatend_coseqreltatd");
        modelBuilder.HasSequence("sq_relatoriocbo_coseqrelatrcbo");
        modelBuilder.HasSequence("sq_relatoriociap_coseqrelciap");
        modelBuilder.HasSequence("sq_relatorioequipe_coseqreleqp");
        modelBuilder.HasSequence("sq_relatorioexame_coseqreltexm");
        modelBuilder.HasSequence("sq_relatorioitem_coseqreltritm");
        modelBuilder.HasSequence("sq_relatoriolotaca_coseqrelltc");
        modelBuilder.HasSequence("sq_relatoriomunicp_coseqrelmnc");
        modelBuilder.HasSequence("sq_relatorioprof_coseqrelprof");
        modelBuilder.HasSequence("sq_relatorioreunia_coseqrelren");
        modelBuilder.HasSequence("sq_relatratdodt_coseqrelatdodt");
        modelBuilder.HasSequence("sq_relatratvcol_coseqrelatvcol");
        modelBuilder.HasSequence("sq_relatrcaddmc_coseqrelcaddmc");
        modelBuilder.HasSequence("sq_relatrcadfml_coseqrelcadfml");
        modelBuilder.HasSequence("sq_relatrcadind_coseqrelcadind");
        modelBuilder.HasSequence("sq_relatritmrel_coseqrelitmrel");
        modelBuilder.HasSequence("sq_relopcdgunccdd_coseqrelopcd");
        modelBuilder.HasSequence("sq_relopcidadao_coseqrelopcidd");
        modelBuilder.HasSequence("sq_relopcrianca_coseqrelopcrnc");
        modelBuilder.HasSequence("sq_relopcrncid10_coseqrelopcrn");
        modelBuilder.HasSequence("sq_relopfamilia_coseqrelopfaml");
        modelBuilder.HasSequence("sq_relopgestante_coseqrelopgst");
        modelBuilder.HasSequence("sq_relopimovel_coseqrelopimovl");
        modelBuilder.HasSequence("sq_relopnclfml_coseqrelopnclfm");
        modelBuilder.HasSequence("sq_reloprcv_coseqreloprcv");
        modelBuilder.HasSequence("sq_relproc_coseqrelproc");
        modelBuilder.HasSequence("sq_reltstcsaud_coseqrelstcsaud");
        modelBuilder.HasSequence("sq_reltundsaud_coseqrelundsaud");
        modelBuilder.HasSequence("sq_requisicaoexame_coseqreqexm");
        modelBuilder.HasSequence("sq_res_envio_coseqresenvio");
        modelBuilder.HasSequence("sq_respopcaomca_cosqrespopmca");
        modelBuilder.HasSequence("sq_respostamca_cosqrespostamca");
        modelBuilder.HasSequence("sq_retifatend_cosqretifatend");
        modelBuilder.HasSequence("sq_revisao_coseqrevisao");
        modelBuilder.HasSequence("sq_rlgrupocond_coseqrlgrucond");
        modelBuilder.HasSequence("sq_rlmanifestalergiaevo_coseq");
        modelBuilder.HasSequence("sq_rlstfaceevodente_coseq");
        modelBuilder.HasSequence("sq_rlstraizevodente_coseq");
        modelBuilder.HasSequence("sq_rltecidomolelesao_coseq");
        modelBuilder.HasSequence("sq_rltiposervicopadrao_coseq");
        modelBuilder.HasSequence("sq_rltrcid_coseqrltrcid");
        modelBuilder.HasSequence("sq_rltrmicroar_coseqrltrmcroar");
        modelBuilder.HasSequence("sq_servsmtp_coseqservsmtp");
        modelBuilder.HasSequence("sq_sinannotevl_coseqsinannotvl");
        modelBuilder.HasSequence("sq_taadcidadao");
        modelBuilder.HasSequence("sq_taadcidadaohistorico");
        modelBuilder.HasSequence("sq_taadmgeral");
        modelBuilder.HasSequence("sq_taadmmunicipal");
        modelBuilder.HasSequence("sq_taagendado");
        modelBuilder.HasSequence("sq_taagendcompartilhado");
        modelBuilder.HasSequence("sq_taalergia");
        modelBuilder.HasSequence("sq_taalergiaevolucao");
        modelBuilder.HasSequence("sq_taantecedente");
        modelBuilder.HasSequence("sq_taantecedenteciap");
        modelBuilder.HasSequence("sq_taantecedentehistorico");
        modelBuilder.HasSequence("sq_taantecedenteitem");
        modelBuilder.HasSequence("sq_taatend");
        modelBuilder.HasSequence("sq_taatendobs");
        modelBuilder.HasSequence("sq_taatendobsplanocuidado");
        modelBuilder.HasSequence("sq_taatendobsresponsavel");
        modelBuilder.HasSequence("sq_taatendproced");
        modelBuilder.HasSequence("sq_taatendprof");
        modelBuilder.HasSequence("sq_taatendprofconduta");
        modelBuilder.HasSequence("sq_taatendprofobs");
        modelBuilder.HasSequence("sq_taatendprofodonto");
        modelBuilder.HasSequence("sq_taatendprofodontotipoencm");
        modelBuilder.HasSequence("sq_taatendprofodontotipofrnc");
        modelBuilder.HasSequence("sq_taatendprofprenatal");
        modelBuilder.HasSequence("sq_taatendprofpuericultura");
        modelBuilder.HasSequence("sq_taatendproftipoencamintrn");
        modelBuilder.HasSequence("sq_taatendtiposervico");
        modelBuilder.HasSequence("sq_taatestado");
        modelBuilder.HasSequence("sq_taatestadomodelo");
        modelBuilder.HasSequence("sq_taativacaoagendamentoonline");
        modelBuilder.HasSequence("sq_taatorpapel");
        modelBuilder.HasSequence("sq_taatorpapelperfil");
        modelBuilder.HasSequence("sq_tacboatend");
        modelBuilder.HasSequence("sq_tacdsdomicilio");
        modelBuilder.HasSequence("sq_tacfgagenda");
        modelBuilder.HasSequence("sq_tacfgagendadetalhe");
        modelBuilder.HasSequence("sq_tacfgagendamunicipal");
        modelBuilder.HasSequence("sq_tacfgagendaonlinedetalhe");
        modelBuilder.HasSequence("sq_tacfgcertificado");
        modelBuilder.HasSequence("sq_tacidadao");
        modelBuilder.HasSequence("sq_tacidadaogrupo");
        modelBuilder.HasSequence("sq_tacidadaounificacaobase");
        modelBuilder.HasSequence("sq_tacidadaovinculacaoequipe");
        modelBuilder.HasSequence("sq_tacirurgiasinternacoes");
        modelBuilder.HasSequence("sq_tacompartilhamentoprontuari");
        modelBuilder.HasSequence("sq_taconfigagendafechamento");
        modelBuilder.HasSequence("sq_taconfigatencaodomiciliar");
        modelBuilder.HasSequence("sq_taconfigatenddomiciliar");
        modelBuilder.HasSequence("sq_taconfigsistema");
        modelBuilder.HasSequence("sq_tacuidadocompartilhado");
        modelBuilder.HasSequence("sq_tacuidadocompartilhadoevol");
        modelBuilder.HasSequence("sq_taencaminhamento");
        modelBuilder.HasSequence("sq_taenviornds");
        modelBuilder.HasSequence("sq_taequipe");
        modelBuilder.HasSequence("sq_taequipeunificacaobase");
        modelBuilder.HasSequence("sq_taestagio");
        modelBuilder.HasSequence("sq_taevolavaltpvigsaudebucl");
        modelBuilder.HasSequence("sq_taevolucaoavaliacao");
        modelBuilder.HasSequence("sq_taevolucaoavaliacaociapcid");
        modelBuilder.HasSequence("sq_taevolucaodente");
        modelBuilder.HasSequence("sq_taevolucaoobjetivo");
        modelBuilder.HasSequence("sq_taevolucaoodonto");
        modelBuilder.HasSequence("sq_taevolucaoodontopartebucal");
        modelBuilder.HasSequence("sq_taevolucaoodontoproced");
        modelBuilder.HasSequence("sq_taevolucaoplano");
        modelBuilder.HasSequence("sq_taevolucaoplanociap");
        modelBuilder.HasSequence("sq_taevolucaosubjetivo");
        modelBuilder.HasSequence("sq_taevolucaosubjetivociap");
        modelBuilder.HasSequence("sq_taexameclearancecreatina");
        modelBuilder.HasSequence("sq_taexamecolesterolhdl");
        modelBuilder.HasSequence("sq_taexamecolesterolldl");
        modelBuilder.HasSequence("sq_taexamecolesteroltotal");
        modelBuilder.HasSequence("sq_taexamecreatinaserica");
        modelBuilder.HasSequence("sq_taexamehemoglobinaglicada");
        modelBuilder.HasSequence("sq_taexameprenatal");
        modelBuilder.HasSequence("sq_taexamepuericultura");
        modelBuilder.HasSequence("sq_taexamerequisitado");
        modelBuilder.HasSequence("sq_taexametriglicerideos");
        modelBuilder.HasSequence("sq_tagestorestadual");
        modelBuilder.HasSequence("sq_tagestormunicipal");
        modelBuilder.HasSequence("sq_tagrupoexame");
        modelBuilder.HasSequence("sq_taimunobiologicolote");
        modelBuilder.HasSequence("sq_taintegracaohorus");
        modelBuilder.HasSequence("sq_tajustificativaagenda");
        modelBuilder.HasSequence("sq_tajustificativastatusciddao");
        modelBuilder.HasSequence("sq_talembrete");
        modelBuilder.HasSequence("sq_talembreteevolucao");
        modelBuilder.HasSequence("sq_talistaespera");
        modelBuilder.HasSequence("sq_talotacao");
        modelBuilder.HasSequence("sq_tamanifestalergiaevolucao");
        modelBuilder.HasSequence("sq_tamarcadorconsumoalimentar");
        modelBuilder.HasSequence("sq_tamedicamento");
        modelBuilder.HasSequence("sq_tamedicamentocatmat");
        modelBuilder.HasSequence("sq_tamedicamentousocontinuo");
        modelBuilder.HasSequence("sq_tamedicao");
        modelBuilder.HasSequence("sq_taneuroalterfenot");
        modelBuilder.HasSequence("sq_taneuroalterfenotevolucao");
        modelBuilder.HasSequence("sq_taneurofatorrisco");
        modelBuilder.HasSequence("sq_taneurofatorriscoevolucao");
        modelBuilder.HasSequence("sq_taneuromarco");
        modelBuilder.HasSequence("sq_taneuromarcoevolucao");
        modelBuilder.HasSequence("sq_tanodo");
        modelBuilder.HasSequence("sq_taodontograma");
        modelBuilder.HasSequence("sq_taorientacao");
        modelBuilder.HasSequence("sq_tapedidoenviobase");
        modelBuilder.HasSequence("sq_taperfil");
        modelBuilder.HasSequence("sq_taperfilrecurso");
        modelBuilder.HasSequence("sq_taperiogramacompleto");
        modelBuilder.HasSequence("sq_taperiogramasimplificado");
        modelBuilder.HasSequence("sq_taprenatal");
        modelBuilder.HasSequence("sq_taproblema");
        modelBuilder.HasSequence("sq_taproblemaevolucao");
        modelBuilder.HasSequence("sq_taprocedgrupoexame");
        modelBuilder.HasSequence("sq_taprof");
        modelBuilder.HasSequence("sq_taprofhistoricocns");
        modelBuilder.HasSequence("sq_taprofmunicipio");
        modelBuilder.HasSequence("sq_taprontuario");
        modelBuilder.HasSequence("sq_taprontuariogrupohistorico");
        modelBuilder.HasSequence("sq_taprontuariounidadesaude");
        modelBuilder.HasSequence("sq_tarascunhoatendprof");
        modelBuilder.HasSequence("sq_tareceitamedicamento");
        modelBuilder.HasSequence("sq_taregistrovacinacao");
        modelBuilder.HasSequence("sq_tarequisicaoexame");
        modelBuilder.HasSequence("sq_tarespostamca");
        modelBuilder.HasSequence("sq_tarespostamcaopcaomca");
        modelBuilder.HasSequence("sq_taretificacaoatend");
        modelBuilder.HasSequence("sq_taservidorsmtp");
        modelBuilder.HasSequence("sq_tasinannotificacaoevolucao");
        modelBuilder.HasSequence("sq_tasituacaofaceevolucaodente");
        modelBuilder.HasSequence("sq_tasituacaoraizevolucaodente");
        modelBuilder.HasSequence("sq_tasubstanciaespecalergia");
        modelBuilder.HasSequence("sq_tatecidomole");
        modelBuilder.HasSequence("sq_tatecidomolelesao");
        modelBuilder.HasSequence("sq_tatiposervico");
        modelBuilder.HasSequence("sq_taunidadesaude");
        modelBuilder.HasSequence("sq_taunidadesaudecomplexidade");
        modelBuilder.HasSequence("sq_taunidadesaudehorus");
        modelBuilder.HasSequence("sq_taunidadesaudetiposervico");
        modelBuilder.HasSequence("sq_taunidadesaudeunifbase");
        modelBuilder.HasSequence("sq_taunificacaobase");
        modelBuilder.HasSequence("sq_tausuario");
        modelBuilder.HasSequence("sq_tavacinacao");
        modelBuilder.HasSequence("sq_tavideochamada");
        modelBuilder.HasSequence("sq_tavinculacaoequipes");
        modelBuilder.HasSequence("sq_tbatendobs_coseqobs");
        modelBuilder.HasSequence("sq_tbatendobsplanocuidado_cosq");
        modelBuilder.HasSequence("sq_tbatestadomodelo_cosqtstmdl");
        modelBuilder.HasSequence("sq_tbcategsubstalergia_coseq");
        modelBuilder.HasSequence("sq_tbcidunifbase_cosqcidunibas");
        modelBuilder.HasSequence("sq_tbcrrsvunbas_cosqcrrsvunbas");
        modelBuilder.HasSequence("sq_tbcuidadocmprtlhdevol_coseq");
        modelBuilder.HasSequence("sq_tbcuidadocompartilhad_coseq");
        modelBuilder.HasSequence("sq_tbdimcondutacuidado_coseq");
        modelBuilder.HasSequence("sq_tbdimprrddcddcmprtlhd_coseq");
        modelBuilder.HasSequence("sq_tbenvio_rnds_coseq");
        modelBuilder.HasSequence("sq_tbeqpunifbase_cosqeqpunibas");
        modelBuilder.HasSequence("sq_tbestunifbase_cosqestunibas");
        modelBuilder.HasSequence("sq_tbfatcuidadocomprtlhd_coseq");
        modelBuilder.HasSequence("sq_tbgraucertezaalergia_coseq");
        modelBuilder.HasSequence("sq_tblistaespera_coseq");
        modelBuilder.HasSequence("sq_tbmanifestacaoalergia_coseq");
        modelBuilder.HasSequence("sq_tbpedidoenv_coseqpedidoenv");
        modelBuilder.HasSequence("sq_tbrascatendprof_coseqrap");
        modelBuilder.HasSequence("sq_tbsubst_especalergia_coseq");
        modelBuilder.HasSequence("sq_tbsubstespecalergia_coseq");
        modelBuilder.HasSequence("sq_tbsubtipounidadesaude_coseq").StartsAt(49L);
        modelBuilder.HasSequence("sq_tbtecidomole_coseq");
        modelBuilder.HasSequence("sq_tbtipoparto_cotipoparto");
        modelBuilder.HasSequence("sq_tbtiporeacaoalergia_coseq");
        modelBuilder.HasSequence("sq_tbubsunifbase_cosqubsunibas");
        modelBuilder.HasSequence("sq_tbunificaobase_cosequnibase");
        modelBuilder.HasSequence("sq_tbvstdomacs_coseqvstdomacs");
        modelBuilder.HasSequence("sq_tipoequipe_coseqtipoequipe");
        modelBuilder.HasSequence("sq_tipomaterial_coseqtipomatrl");
        modelBuilder.HasSequence("sq_tipomedicao_coseqtipomedica").StartsAt(11L);
        modelBuilder.HasSequence("sq_tiposervico_coseqtiposer").StartsAt(11L);
        modelBuilder.HasSequence("sq_tokredsen_coseqtokredsen");
        modelBuilder.HasSequence("sq_tpequipe_coseqtpequipe")
            .StartsAt(55L)
            .IncrementsBy(50);
        modelBuilder.HasSequence("sq_tpunidadesaude_coseqtpunsd").StartsAt(38L);
        modelBuilder.HasSequence("sq_unddesudhrs_csequnddsudhrs");
        modelBuilder.HasSequence("sq_unidademedidadose_coseq");
        modelBuilder.HasSequence("sq_unidadesaude_cosequndsaude")
            .StartsAt(19944L)
            .IncrementsBy(50);
        modelBuilder.HasSequence("sq_usuario_cosequsuario").IncrementsBy(50);
        modelBuilder.HasSequence("sq_vacinacao_coseqvacinacao");
        modelBuilder.HasSequence("sq_videochamada_coseqvidcham");
        modelBuilder.HasSequence("sq_vinequipes_coseqvinequipes");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
