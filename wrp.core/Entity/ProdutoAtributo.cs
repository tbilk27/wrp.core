using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("PRODUTOATRIBUTO")]
    public class ProdutoAtributo : BaseEntity
    {
        [ForeignKey("IDProduto")]
        public Produto Produto { get; set; }
        [Required]
        public string IDProduto { get; set; }

        [ForeignKey("IDAtributo")]
        public Atributo Atributo { get; set; }
        [Required]
        public string IDAtributo { get; set; }

    }
}
