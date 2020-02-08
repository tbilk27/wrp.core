using System.Collections.Generic;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    /// <summary>
    /// Acessos a recursos do sistema
    /// </summary>
    public class Acesso : BaseEntity
    {
        public string Descricao { get; set; }

        public string CodigoOperacao { get; set; }

        public AcessoGrupo AcessoGrupo { get; set; }
        public string IDAcessoGrupo { get; set; }

        public ICollection<Menu> Menus { get; set; }
    }
}