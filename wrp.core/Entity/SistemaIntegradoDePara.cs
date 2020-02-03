using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("SISTEMAINTEGRADODEPARA")]
    public class SistemaIntegradoDePara : BaseEntity
    {
        [ForeignKey("IDSistemaIntegrado")]
        public SistemaIntegrado SistemaIntegrado { get; set; }
        [Required]
        public string IDSistemaIntegrado { get; set; }

        [StringLength(100)]
        [Required]
        public string Entidade { get; set; }
        
        /// <summary>
        /// ID no WRP
        /// </summary>
        [StringLength(40)]
        [Required]
        public string IDOrigem { get; set; }

        /// <summary>
        /// ID no sistema integrado
        /// </summary>
        [StringLength(10)]
        [Required]
        public string CodigoRemoto { get; set; }
    }
}
