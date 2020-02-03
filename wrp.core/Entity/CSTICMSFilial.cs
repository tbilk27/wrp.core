using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;


namespace wrp.core.Entity
{
    [Table("CSTICMSFILIAL")]
    public class CSTICMSFilial : BaseFilial
    {        
        [ForeignKey("IDCSTICMS")]
        public CSTICMS CSTICMS { get; set; }
        [FilialIndex("UX_CSTICMSFilial1", IsUnique = true, Order = 2)]
        public string IDCSTICMS { get; set; }

        public bool Normal { get; set; }
        public bool Isento { get; set; }
        public bool Outras { get; set; }
    }
}
