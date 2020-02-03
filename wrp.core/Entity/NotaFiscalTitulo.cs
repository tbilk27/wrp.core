using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("NOTAFISCALTITULO")]
    public class NotaFiscalTitulo : BaseEntity
    {
        //NotaFiscal 
        [ForeignKey("IDNotaFiscal")]
        public NotaFiscal NotaFiscal { get; set; }
        [Required]
        public string IDNotaFiscal { get; set; }

        [Required]
        public DateTime Vencimento { get; set; }
        [Required]
        public decimal Valor { get; set; }

        [ForeignKey("IDTitulo")]
        public Titulo Titulo { get; set; }
        public string IDTitulo { get; set; }
    }
}
