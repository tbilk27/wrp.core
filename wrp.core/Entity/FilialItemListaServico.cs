using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Global;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("FILIALITEMLISTASERVICO")]
    public class FilialItemListaServico : BaseFilial
    {
        [ForeignKey("IDItemListaServico")]
        public ItemListaServico ItemListaServico { get; set; }
        public string IDItemListaServico { get; set; }

        [ForeignKey("IDCSTISS")]
        public CSTISS CSTISS { get; set; }
        public string IDCSTISS { get; set; }
    }
}
