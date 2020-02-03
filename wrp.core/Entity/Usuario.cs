using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    /// <summary>
    /// Usuários do sistema
    /// </summary>
    [Table("USUARIO")]
    public class Usuario : BaseEntity
    {
        [Required]
        [StringLength(100)]
        [Index("UX_UsuarioLogin", Order = 1, IsUnique = true)]
        public string Login { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public Pessoa Pessoa { get; set; }

        [StringLength(36)]
        public string IDPessoa { get; set; }

        [Index("UX_UsuarioLogin", Order = 2, IsUnique = true)]
        public DateTime? DataExclusao { get; set; }

        public virtual ICollection<TokenAPI> Tokens { get; set; }
    }
}
