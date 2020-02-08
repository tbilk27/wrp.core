using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    /// <summary>
    /// Menus do sistema
    /// </summary>
    public class Menu : BaseEntity
    {
        public string Descricao { get; set; }

        public string Caminho { get; set; }

        public string CaminhoEstrutura { get; set; }

        public string Icone { get; set; }

        public Acesso Acesso { get; set; }

        public string IDAcesso { get; set; }

    }
}
