using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Global;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("PRODUTOUFDEFINICAO")]
    public class ProdutoUFDefinicao : BaseFilial
    {
        [ForeignKey("IDProduto")]
        public Produto Produto { get; set; }
        [Required]
        [FilialIndex("UX_PRODUTOUFDEFINICAO1", IsUnique = true, Order = 2)]
        public string IDProduto { get; set; }

        [ForeignKey("IDUF")]
        public UF UF { get; set; }
        [Required]
        [FilialIndex("UX_PRODUTOUFDEFINICAO1", IsUnique = true, Order = 3)]
        public string IDUF { get; set; }

        [DataTypeDecimal(4, 2)]
        public decimal MVA { get; set; }
    }
}
