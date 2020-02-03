using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("VOLUME")]
    public class Volume : BaseFilial
    {
        [ForeignKey("IDPedido")]
        public Pedido Pedido { get; set; }
        [Index("UX_Volume1", 1, IsUnique = true)]
        [Required]
        public string IDPedido { get; set; }

        [Required]
        [Index("UX_Volume1", 2, IsUnique = true)]
        public int Sequencia { get; set; }

        [Required]
        public StatusVolume Status { get; set; }

        public DateTime? Expedicao { get; set; }
    }
}
