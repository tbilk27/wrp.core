using System.Collections.Generic;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class Empresa : BaseEntity
    {
        public string Nome { get; set; }

        public string CodigoArroba { get; set; }

        public ICollection<Filial> Filials { get; set; }
    }
}