using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("CSTPIS")]
    public class CSTPIS : BaseEntity
    {
        [Required]
        [StringLength(3)]
        [EmpresaIndex("UX_CSTPIS1", IsUnique = true, Order = 2)]
        public string CST { get; set; }

        [Required]
        [StringLength(160)]
        public string Descricao { get; set; }

        public virtual ICollection<CSTPISFilial> Definicoes { get; set; }
    }
}
