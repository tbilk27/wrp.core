using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    /// <summary>
    /// Menus do sistema
    /// </summary>
    [Table("MENU")]
    public class Menu : BaseEntity
    {
        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }

        [Required]
        [StringLength(200)]
        public string Caminho { get; set; }

        [Required]
        [StringLength(80)]
        [Index("UK_Menu_2", IsUnique = true)]
        public string CaminhoEstrutura { get; set; }

        [StringLength(200)]
        public string Icone { get; set; }

        [ForeignKey("IDAcesso")]
        public Acesso Acesso { get; set; }

        public string IDAcesso { get; set; }

    }
}
