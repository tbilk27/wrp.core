using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("MARCAPRODUTO")]
    public class MarcaProduto : BaseFilial
    {
        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }
    }
}
