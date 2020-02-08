using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Global;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class FilialItemListaServico : BaseFilial
    {
        public ItemListaServico ItemListaServico { get; set; }
        public string IDItemListaServico { get; set; }

        public CSTISS CSTISS { get; set; }
        public string IDCSTISS { get; set; }
    }
}
