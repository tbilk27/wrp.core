using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("PEDIDOCOMISSAOITEM")]
    public class PedidoComissaoItem : BaseEntity
    {
        [ForeignKey("IDPedidoComissao")]
        public PedidoComissao PedidoComissao { get; set; }
        [Required]
        public string IDPedidoComissao { get; set; }

        [ForeignKey("IDPedidoItem")]
        public PedidoItem PedidoItem { get; set; }
        [Required]
        public string IDPedidoItem { get; set; }

        public decimal Percentual { get; set; }
    }
}
