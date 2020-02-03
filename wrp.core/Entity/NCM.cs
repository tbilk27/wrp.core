using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("NCM")]
    public class NCM : BaseEmpresa
    {
        [Required]
        [Range(0,99999999)]
        [EmpresaIndex("UX_NCM1", IsUnique = true, Order = 2)]
        public int CodigoNCM { get; set; }

        [Required]
        [StringLength(400)]
        public string Descricao { get; set; }

        public decimal AliquotaIPI { get; set; }

        public virtual ICollection<NCMCEST> NCMCEST { get; set; }
    }
}
