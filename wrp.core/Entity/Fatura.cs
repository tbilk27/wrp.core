using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    /// <summary>
    /// Fatura. Por enquando com poucas propriedades.
    /// </summary>
    [Table("FATURA")]
    public class Fatura : BaseFilial
    {
        /// <summary>
        /// Número da fatura
        /// </summary>
        [Required]
        public int Numero { get; set; }

        /// <summary>
        /// Série da fatura
        /// </summary>
        [StringLength(3)]
        public string Serie { get; set; }

        /// <summary>
        /// Modelo da fatura
        /// </summary>
        [StringLength(2)]
        public string Modelo { get; set; }
    }
}
