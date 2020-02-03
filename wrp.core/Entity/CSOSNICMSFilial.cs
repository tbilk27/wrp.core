using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;


namespace wrp.core.Entity
{

    [Table("CSOSNICMSFILIAL")]
    public class CSOSNICMSFilial : BaseFilial
    {
        [ForeignKey("IDCSOSNICMS")]
        public CSOSNICMS CSOSNICMS { get; set; }
        [FilialIndex("UX_CSOSNICMSFilial1", IsUnique = true, Order = 2)]
        public string IDCSOSNICMS { get; set; }

        public bool Normal { get; set; }
        public bool Isento { get; set; }
        public bool Outras { get; set; }
    }
}
