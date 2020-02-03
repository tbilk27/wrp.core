using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("CONTAFINANCEIRA")]
    public class ContaFinanceira : BaseFilial
    {
        [StringLength(100)]
        [Required]
        public string Descricao { get; set; }
        
        [Required]
        public TipoContaFinanceira TipoContaFinanceira { get; set; }

        [ForeignKey("IDPlanoContas")]
        public PlanoContas PlanoContas { get; set; }

        [Required]
        public string IDPlanoContas { get; set; }

        [ForeignKey("IDContaFinanceiraAnalitica")]
        public ContaFinanceira ContaFinanceiraAnalitica { get; set; }

        public string IDContaFinanceiraAnalitica { get; set; }

        [ForeignKey("IDContaFinanceiraAnalitica")]
        public virtual ICollection<ContaFinanceira> ListaContasFilhas { get; set; }


    }
}
