using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("CSTPISFILIAL")]
    public class CSTPISFilial : BaseFilial  
    {
        [ForeignKey("IDCSTPIS")]
        public CSTPIS CSTPIS { get; set; }
        [FilialIndex("UX_CSTPISFilial1", IsUnique = true, Order = 2)]
        public string IDCSTPIS { get; set; }

        public bool Base { get; set; }
    }
}
