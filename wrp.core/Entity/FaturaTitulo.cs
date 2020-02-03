using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("FATURATITULO")]
    public class FaturaTitulo : BaseEntity
    {
        [ForeignKey("IDFatura")]
        public Fatura Fatura { get; set; }
        [Required]
        public string IDFatura { get; set; }

        [ForeignKey("IDTitulo")]
        public Titulo Titulo { get; set; }
        [Required]
        public string IDTitulo { get; set; }
    }
}
