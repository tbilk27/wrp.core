using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("NOTAFISCALITEMORDEMCOMPRA")]
    public class NotaFiscalItemOrdemCompra  : BaseEntity
    {
        //NotaFiscal 
        [ForeignKey("IDNotaFiscalItem")]
        public NotaFiscalItem NotaFiscalItem { get; set; }
        [Required]
        public string IDNotaFiscalItem { get; set; }

        [ForeignKey("IDOrdemCompraItem")]
        public OrdemCompraItem OrdemCompraItem { get; set; }
        [Required]
        public string IDOrdemCompraItem { get; set; }

        public decimal Quantidade { get; set; }
    }
}
