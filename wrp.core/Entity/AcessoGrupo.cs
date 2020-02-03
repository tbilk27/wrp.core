using System.Collections.Generic;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class AcessoGrupo : BaseEntity
    {
        public string Descricao { get; set; }

        public ICollection<Acesso> Acessos { get; set; }
    }
}