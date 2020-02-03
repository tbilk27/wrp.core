using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Global;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("PESSOAENDERECO")]
    public class PessoaEndereco : BaseEntity
    {
        [ForeignKey("IDPessoa")]
        public Pessoa Pessoa { get; set; }
        [Required]
        [Index("IX_PessoaEndereco", IsUnique = true, Order = 1)]
        public string IDPessoa { get; set; }

        [ForeignKey("IDCidade")]
        public Cidade Cidade { get; set; }
        public string IDCidade { get; set; }

        public TipoEndereco TipoEndereco { get; set; }

        public TipoLogradouro TipoLogradouro { get; set; }

        [StringLength(200)]
        public string Logradouro { get; set; }

        [StringLength(20)]
        public string Numero { get; set; }

        [StringLength(100)]
        public string Complemento { get; set; }

        [StringLength(200)]
        public string Bairro { get; set; }

        [StringLength(9)]
        public string CEP { get; set; }

        [StringLength(200)]
        public string PontoReferencia { get; set; }
    }
}
