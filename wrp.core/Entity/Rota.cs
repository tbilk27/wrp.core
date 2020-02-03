using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("ROTA")]
    public class Rota : BaseFilial
    {
        [Required]
        [StringLength(200)]
        [Index("UX_Rota", Order = 1, IsUnique = true)]
        public string Descricao { get; set; }
    }
}
