using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    /// <summary>
    /// Relacionamento entre NCM e CEST
    /// </summary>
    [Table("NCMCEST")]
    public class NCMCEST : BaseEntity
    {
        [ForeignKey("IDNCM")]
        public NCM NCM { get; set; }

        [Required]
        [Index("IX_NCMCEST", IsUnique = true, Order = 1)]
        public string IDNCM { get; set; }

        [ForeignKey("IDCEST")]
        public CEST Cest { get; set; }

        [Required]
        [Index("IX_NCMCEST", IsUnique = true, Order = 2)]
        public string IDCEST { get; set; }
    }
}
