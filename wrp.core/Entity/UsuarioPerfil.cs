using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    /// <summary>
    /// Acessos que um perfil de usuário tem
    /// </summary>
    [Table("USUARIOPERFIL")]
    public class UsuarioPerfil : BaseFilial
    {
        [ForeignKey("IDUsuario")]
        public Usuario Usuario { get; set; }

        [Required]
        [Index("IX_UsuarioPerfil", IsUnique = true, Order = 1)]
        public string IDUsuario { get; set; }

        [ForeignKey("IDPerfil")]
        public Perfil Perfil { get; set; }

        [Required]
        [Index("IX_UsuarioPerfil", IsUnique = true, Order = 2)]
        public string IDPerfil { get; set; }
    }
}
