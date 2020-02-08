using System.Collections.Generic;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class Armazem : BaseFilial
    {
        public string Descricao { get; set; }

        public ICollection<Local> Locais { get; set; }
    }
}