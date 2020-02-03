using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("ORDEMCOMPRAITEM")]
    public class OrdemCompraItem : BaseEntity
    {
        [ForeignKey("IDOrdemCompra")]
        public OrdemCompra OrdemCompra { get; set; }
        [Required]
        public string IDOrdemCompra { get; set; }

        [ForeignKey("IDProdutoItem")]
        public ProdutoItem ProdutoItem { get; set; }
        [Required]
        public string IDProdutoItem { get; set; }

        public decimal QuantidadeDigitada { get; set; }

        public decimal QuantidadePendente { get; set; }

        public decimal QuantidadeBaixada { get; set; }

        public decimal QuantidadeCancelada { get; set; }

        public decimal ValorUnitario { get; set; }
    }
}
