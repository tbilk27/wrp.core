using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("FORMULABASECALCULO")]
    public class FormulaBaseCalculo : BaseFilial
    {
        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }

        [StringLength(500)]
        public string Formula { get; set; }
    }
}
