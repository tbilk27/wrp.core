using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    /// <summary>
    /// Tabela de contadores
    /// </summary>
    [Table("CONTADOR")]
    public class Contador : BaseFilial
    {
        [Required]
        [StringLength(200)]
        [FilialIndex("UX_Contador", IsUnique = true)]
        public string Nome { get; set; }

        [Required]
        public long Valor { get; set; }
    }
}
