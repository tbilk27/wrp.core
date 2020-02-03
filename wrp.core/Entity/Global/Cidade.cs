using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity.Global
{
    [Table("CIDADE")]
    public class Cidade : BaseEntity
    {
        [ForeignKey("IDUF")]
        public UF UF { get; set; }
        [Required]
        public string IDUF { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        public int Codigo { get; set; }

        [StringLength(4)]
        public string CodigoTOM { get; set; }

    }
}
