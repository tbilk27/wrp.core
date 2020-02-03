using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("PRODUTOITEMATRIBUTO")]
    public class ProdutoItemAtributo : BaseEntity
    {
        [ForeignKey("IDProdutoItem")]
        public ProdutoItem ProdutoItem { get; set; }
        [Required]
        public string IDProdutoItem { get; set; }

        [ForeignKey("IDProdutoAtributo")]
        public ProdutoAtributo ProdutoAtributo { get; set; }
        [Required]
        public string IDProdutoAtributo { get; set; }

        [ForeignKey("IDAtributoValor")]
        public AtributoValor AtributoValor { get; set; }
        [Required]
        public string IDAtributoValor { get; set; }
    }
}
