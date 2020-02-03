using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity.Global
{
    [Table("CSTISS")]
    public class CSTISS : BaseEntity
    {
        [StringLength(2)]
        public string CST { get; set; }

        public string Descricao { get; set; }
    }
}
