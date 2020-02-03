using System.Collections.Generic;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class Banco : BaseFilial
    {
        public string Descricao { get; set; }

        public string Febraban { get; set; }

        public ICollection<ContaBanco> Contas { get; set; }
    }
}