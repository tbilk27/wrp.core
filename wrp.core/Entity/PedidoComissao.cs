using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{

    [Table("PEDIDOCOMISSAO")]
    public class PedidoComissao : BaseEntity
    {
        [ForeignKey("IDPedido")]
        public Pedido Pedido { get; set; }
        [Required]
        public string IDPedido { get; set; }

        [ForeignKey("IDRepresentante")]
        public Pessoa Representante { get; set; }
        [Required]
        public string IDRepresentante { get; set; }
    }

}