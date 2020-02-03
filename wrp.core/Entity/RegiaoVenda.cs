using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("REGIAOVENDA")]
    public class RegiaoVenda : BaseFilial
    {
        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }

        public int DiasParaEntrega { get; set; }
    }
}
