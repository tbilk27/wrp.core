using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("CSTCOFINS")]
    public class CSTCOFINS : BaseEntity
    {
        [Required]
        [StringLength(2)]
        [EmpresaIndex("UX_CSTCOFINS1", IsUnique = true, Order = 2)]
        public string CST { get; set; }

        [Required]
        [StringLength(160)]
        public string Descricao { get; set; }

        public virtual ICollection<CSTCOFINSFilial> Definicoes { get; set; }
    }
}
