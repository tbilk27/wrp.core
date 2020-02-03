using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    /// <summary>
    /// Acessos que um perfil de usuário tem
    /// </summary>
    [Table("PERFILACESSO")]
    public class PerfilAcesso : BaseEntity
    {
        [ForeignKey("IDPerfil")]
        public Perfil Perfil { get; set; }

        [Required]
        [Index("IX_PerfilAcesso", IsUnique = true, Order = 1)]
        public string IDPerfil { get; set; }

        [ForeignKey("IDAcesso")]
        public Acesso Acesso { get; set; }

        [Required]
        [Index("IX_PerfilAcesso", IsUnique = true, Order = 2)]
        public string IDAcesso { get; set; }
    }
}
