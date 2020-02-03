using System.Collections.Generic;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class Atributo : BaseFilial
    {
        public string Descricao { get; set; }

        public ICollection<AtributoValor> Valores { get; set; }
    }
}