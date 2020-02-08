using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("PESSOA")]
    public class Pessoa : BaseEmpresa
    {
        [Required]
        [StringLength(100)]
        public string Apelido { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        public TipoPessoa TipoPessoa { get; set; }

        [StringLength(14)]
        public string CPFCNPJ { get; set; }

        public TipoInscricaoEstadual TipoInscricaoEstadual { get; set; }

        [StringLength(20)]
        public string RGIE { get; set; }

        [StringLength(20)]
        public string Suframa { get; set; }

        public string Observacao { get; set; }
        
        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(200)]
        public string EmailNFE { get; set; }

        [StringLength(200)]
        public string EmailOC { get; set; }

        [StringLength(200)]
        public string Telefone { get; set; }

        [Required]
        public bool Cliente { get; set; }

        [Required]
        public bool Fornecedor { get; set; }

        [Required]
        public bool Transportadora { get; set; }

        [Required]
        public bool Representante { get; set; }

        [Required]
        public bool Colaborador { get; set; }

        public bool Ativo { get; set; }

        public DateTime? DataExclusao { get; set; }

        public virtual ICollection<PessoaEndereco> Enderecos { get; set; }
        public virtual ICollection<PessoaContato> Contatos { get; set; }
        public virtual ICollection<PessoaDefinicao> Definicoes { get; set; }
        public virtual ICollection<PessoaImagem> Imagens { get; set; }
        public virtual ICollection<PessoaInfo> InformacoesAdicionais { get; set; }

        public ICollection<Comissao> Comissoes { get; set; }
        public ICollection<ComissaoFechamento> ComissoesFechamentos { get; set; }

        //[StringLength(36)]
        //public string CodigoReferencia { get; set; }

        public ICollection<Filial> Filials { get; set; }
    }
}
