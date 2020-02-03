using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("RELATORIOPERFIL")]
    public class RelatorioPerfil : BaseEntity
    {
        [ForeignKey("IDRelatorio")]
        public Relatorio Relatorio { get; set; }
        [Required]
        public string IDRelatorio { get; set; }

        [ForeignKey("IDPerfil")]
        public Perfil Perfil { get; set; }

        [Required]
        public string IDPerfil { get; set; }
    }
}
