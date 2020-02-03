using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("VOLUMEITEM")]
    public class VolumeItem : BaseEntity
    {
        [ForeignKey("IDVolume")]
        public Volume Volume { get; set; }
        [Required]
        public string IDVolume { get; set; }

        [ForeignKey("IDProdutoLoteItem")]
        public ProdutoLoteItem ProdutoLoteItem { get; set; }
        [Required]
        public string IDProdutoLoteItem { get; set; }

        [ForeignKey("IDPedidoItem")]
        public PedidoItem PedidoItem { get; set; }
        [Required]
        public string IDPedidoItem { get; set; }

        public decimal Quantidade { get; set; }
    }
}
