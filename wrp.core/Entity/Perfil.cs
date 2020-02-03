using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    /// <summary>
    /// Perfil de acesso dos usuários aos recursos do sistema
    /// </summary>
    [Table("PERFIL")]
    public class Perfil : BaseFilial
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }

        public bool ApenasLeitura { get; set; }

        [ForeignKey("IDPerfil")]
        public virtual ICollection<UsuarioPerfil> Usuarios { get; set; }
    }
}
