using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("NOTAFISCALVOLUME")]
    public class NotaFiscalVolume : BaseEntity
    {
        //NotaFiscal 
        [ForeignKey("IDNotaFiscal")]
        public NotaFiscal NotaFiscal { get; set; }
        [Required]
        public string IDNotaFiscal { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        [StringLength(60)]
        public string Especie { get; set; }

        //peso bruto
        [Required]
        public double PesoBruto { get; set; }

        //peso líquido
        [Required]
        public double PesoLiquido { get; set; }
    }
}
