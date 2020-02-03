using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("PESSOAIMAGEM")]
    public class PessoaImagem : BaseEntity
    {
        [ForeignKey("IDPessoa")]
        public Pessoa Pessoa { get; set; }
        public string IDPessoa { get; set; }

        [StringLength(160)]
        [Required]
        public string Descricao { get; set; }

        //[StringLength(200)]
        //public string URL { get; set; }

        [Display(Name ="Tipo de Imagem")]
        [Required]
        public TipoImagemPessoa TipoImagemPessoa { get; set; }

        [ForeignKey("IDArquivo")]
        public Arquivo Arquivo { get; set; }
        public string IDArquivo { get; set; }
    }
}
