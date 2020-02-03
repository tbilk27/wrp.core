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
    [Table("ROTATRANSPORTADORA")]
    public class RotaTransportadora : BaseFilial
    {
        [ForeignKey("IDRota")]
        public Rota Rota { get; set; }
        [Required]
        [Index("UX_RotaTransportadora", Order = 1, IsUnique = true)]
        public string IDRota { get; set; }


        [ForeignKey("IDTransportadora")]
        public Pessoa Transportadora { get; set; }
        [Required]
        [Index("UX_RotaTransportadora", Order = 2, IsUnique = true)]
        public string IDTransportadora { get; set; }

        [Required]
        public int OrdemPreferencia { get; set; }

    }
}
