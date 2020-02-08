using System.Collections.Generic;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class ModeloComissao : BaseFilial
    {
        public string Descricao { get; set; }

        public TipoComissao TipoComissao { get; set; }

        public ICollection<ModeloComissaoItem> Itens { get; set; }
    }
}