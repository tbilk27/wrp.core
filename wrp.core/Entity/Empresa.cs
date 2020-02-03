using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("EMPRESA")]
    public class Empresa : BaseEntity
    {
        [Required]
        [StringLength(200)]
        [Index(IsUnique = true)]
        public string Nome { get; set; }
        
        [StringLength(200)]
        [Index(IsUnique = true)]
        public string CodigoArroba { get; set; }
        
    }
}
