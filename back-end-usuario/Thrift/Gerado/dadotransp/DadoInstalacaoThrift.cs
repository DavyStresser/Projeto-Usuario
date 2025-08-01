/**
 * Autogenerated by Thrift Compiler (0.9.3)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace br.gov.saude.esusab.dadotransp
{

  /// <summary>
  /// Dados para identificar a instalacao que cadastrou/gerou os dados e/ou enviou
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class DadoInstalacaoThrift : TBase
  {
    private string _uuidInstalacao;
    private string _fone;
    private string _email;
    private string _versaoSistema;
    private string _nomeBancoDados;

    /// <summary>
    /// Identifica o software que gerou o dado (pec/cds, cdsOff ou software de terceiros).
    /// </summary>
    public string ContraChave { get; set; }

    /// <summary>
    /// É um identificador da instalação do software que gerou o dado. Seja ele o e-SUS ou software de terceiro.
    /// </summary>
    public string UuidInstalacao
    {
      get
      {
        return _uuidInstalacao;
      }
      set
      {
        __isset.uuidInstalacao = true;
        this._uuidInstalacao = value;
      }
    }

    /// <summary>
    /// Cpf do responsável ou CNPJ da empresa responsável
    /// </summary>
    public string CpfOuCnpj { get; set; }

    /// <summary>
    /// Nome do responsável ou Razão Social da empresa responsável
    /// </summary>
    public string NomeOuRazaoSocial { get; set; }

    /// <summary>
    /// Telefone da pessoa ou empresa responsável
    /// </summary>
    public string Fone
    {
      get
      {
        return _fone;
      }
      set
      {
        __isset.fone = true;
        this._fone = value;
      }
    }

    /// <summary>
    /// Email da pessoa ou empresa responsável
    /// </summary>
    public string Email
    {
      get
      {
        return _email;
      }
      set
      {
        __isset.email = true;
        this._email = value;
      }
    }

    /// <summary>
    /// Versão do software
    /// </summary>
    public string VersaoSistema
    {
      get
      {
        return _versaoSistema;
      }
      set
      {
        __isset.versaoSistema = true;
        this._versaoSistema = value;
      }
    }

    /// <summary>
    /// Nome do banco de dados que o software utiliza
    /// </summary>
    public string NomeBancoDados
    {
      get
      {
        return _nomeBancoDados;
      }
      set
      {
        __isset.nomeBancoDados = true;
        this._nomeBancoDados = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool uuidInstalacao;
      public bool fone;
      public bool email;
      public bool versaoSistema;
      public bool nomeBancoDados;
    }

    public DadoInstalacaoThrift() {
    }

    public DadoInstalacaoThrift(string contraChave, string cpfOuCnpj, string nomeOuRazaoSocial) : this() {
      this.ContraChave = contraChave;
      this.CpfOuCnpj = cpfOuCnpj;
      this.NomeOuRazaoSocial = nomeOuRazaoSocial;
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_contraChave = false;
        bool isset_cpfOuCnpj = false;
        bool isset_nomeOuRazaoSocial = false;
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                ContraChave = iprot.ReadString();
                isset_contraChave = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                UuidInstalacao = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                CpfOuCnpj = iprot.ReadString();
                isset_cpfOuCnpj = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                NomeOuRazaoSocial = iprot.ReadString();
                isset_nomeOuRazaoSocial = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                Fone = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.String) {
                Email = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.String) {
                VersaoSistema = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.String) {
                NomeBancoDados = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
        if (!isset_contraChave)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_cpfOuCnpj)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_nomeOuRazaoSocial)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("DadoInstalacaoThrift");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        field.Name = "contraChave";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ContraChave);
        oprot.WriteFieldEnd();
        if (UuidInstalacao != null && __isset.uuidInstalacao) {
          field.Name = "uuidInstalacao";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(UuidInstalacao);
          oprot.WriteFieldEnd();
        }
        field.Name = "cpfOuCnpj";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(CpfOuCnpj);
        oprot.WriteFieldEnd();
        field.Name = "nomeOuRazaoSocial";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(NomeOuRazaoSocial);
        oprot.WriteFieldEnd();
        if (Fone != null && __isset.fone) {
          field.Name = "fone";
          field.Type = TType.String;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Fone);
          oprot.WriteFieldEnd();
        }
        if (Email != null && __isset.email) {
          field.Name = "email";
          field.Type = TType.String;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Email);
          oprot.WriteFieldEnd();
        }
        if (VersaoSistema != null && __isset.versaoSistema) {
          field.Name = "versaoSistema";
          field.Type = TType.String;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(VersaoSistema);
          oprot.WriteFieldEnd();
        }
        if (NomeBancoDados != null && __isset.nomeBancoDados) {
          field.Name = "nomeBancoDados";
          field.Type = TType.String;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(NomeBancoDados);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("DadoInstalacaoThrift(");
      __sb.Append(", ContraChave: ");
      __sb.Append(ContraChave);
      if (UuidInstalacao != null && __isset.uuidInstalacao) {
        __sb.Append(", UuidInstalacao: ");
        __sb.Append(UuidInstalacao);
      }
      __sb.Append(", CpfOuCnpj: ");
      __sb.Append(CpfOuCnpj);
      __sb.Append(", NomeOuRazaoSocial: ");
      __sb.Append(NomeOuRazaoSocial);
      if (Fone != null && __isset.fone) {
        __sb.Append(", Fone: ");
        __sb.Append(Fone);
      }
      if (Email != null && __isset.email) {
        __sb.Append(", Email: ");
        __sb.Append(Email);
      }
      if (VersaoSistema != null && __isset.versaoSistema) {
        __sb.Append(", VersaoSistema: ");
        __sb.Append(VersaoSistema);
      }
      if (NomeBancoDados != null && __isset.nomeBancoDados) {
        __sb.Append(", NomeBancoDados: ");
        __sb.Append(NomeBancoDados);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
