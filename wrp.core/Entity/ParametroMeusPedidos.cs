using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("PARAMETROMEUSPEDIDOS")]
    public class ParametroMeusPedidos : BaseEmpresa
    {
        [Required]
        [StringLength(40)]
        public string TokenDaAplicacao { get; set; }

        [Required]
        [StringLength(40)]
        public string TokenDaEmpresa { get; set; }

        [Required]
        [StringLength(200)]
        public string URLdoAmbiente { get; set; }
    }
}
