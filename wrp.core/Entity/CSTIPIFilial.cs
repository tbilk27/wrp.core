using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("CSTIPIFILIAL")]
    public class CSTIPIFilial : BaseFilial
    {
        [ForeignKey("IDCSTIPI")]
        public CSTIPI CSTIPI { get; set; }
        [FilialIndex("UX_CSTIPIFilial1", IsUnique = true, Order = 2)]
        public string IDCSTIPI { get; set; }

        public bool Normal { get; set; }
        public bool Isento { get; set; }
        public bool Outras { get; set; }
    }
}
