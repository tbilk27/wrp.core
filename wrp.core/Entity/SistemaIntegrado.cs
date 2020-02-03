using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("SISTEMAINTEGRADO")]
    public class SistemaIntegrado : BaseFilial
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
    }
}
