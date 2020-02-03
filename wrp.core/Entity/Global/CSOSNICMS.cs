using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("CSOSNICMS")]
    public class CSOSNICMS : BaseEntity
    {
        [Required]
        [StringLength(3)]
        [EmpresaIndex("UX_CSOSNICMS1", IsUnique = true, Order = 2)]
        public string CSOSN { get; set; }

        [Required]
        [StringLength(160)]
        public string Descricao { get; set; }

        public virtual ICollection<CSOSNICMSFilial> Definicoes { get; set; }
    }
}
