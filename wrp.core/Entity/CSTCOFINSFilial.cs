using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("CSTCOFINSFILIAL")]
    public class CSTCOFINSFilial : BaseFilial
    {
        [ForeignKey("IDCSTCOFINS")]
        public CSTCOFINS CSTCOFINS { get; set; }
        [FilialIndex("UX_CSTCOFINSFilial1", IsUnique = true, Order = 2)]
        public string IDCSTCOFINS { get; set; }

        public bool Base { get; set; }
    }
}
