using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Global;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("UFDEFINICAO")]
    public class UFDefinicao : BaseFilial
    {
        [ForeignKey("IDUF")]
        public UF UF { get; set; }

        [Required]
        [FilialIndex("UX_UFDefinicao1", IsUnique = true, Order = 2)]
        public string IDUF { get; set; }

        public decimal AliquotaIcmsInterestadual { get; set; }

        public decimal AliquotaIcmsInterna { get; set; }
    }
}
