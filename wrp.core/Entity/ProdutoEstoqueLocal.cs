using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("PRODUTOESTOQUELOCAL")]
    public class ProdutoEstoqueLocal : BaseEntity
    {
        [ForeignKey("IDLocal")]
        public Local Local { get; set; }
        [Required]
        [Index("UX_ProdutoEstoqueLocal1", IsUnique = true, Order = 1)]
        public string IDLocal { get; set; }

        [ForeignKey("IDProdutoEstoque")]
        public ProdutoEstoque ProdutoEstoque { get; set; }
        [Required]
        [Index("UX_ProdutoEstoqueLocal1", IsUnique = true, Order = 2)]
        public string IDProdutoEstoque { get; set; }
    }
}
