using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity.Global
{
    [Table("PAIS")]
    public class Pais : BaseEntity
    {
        public int Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
    }
}
