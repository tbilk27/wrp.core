using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("FORMAPAGAMENTO")]
    public class FormaPagamento : BaseFilial
    {
        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }
    }
}
