using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("PLANOCONTAS")]
    public class PlanoContas : BaseFilial
    {
        [StringLength(100)]
        [Required]
        [FilialIndex("UX_PLANOCONTAS1", IsUnique = true, Order = 2)]
        public string Descricao { get; set; }

        public bool Ativa { get; set; }

        public ICollection<ContaFinanceira> ContasFinanceiras { get; set; }

        public PlanoContas()
        {
            Ativa = false;
        }
    }
}
