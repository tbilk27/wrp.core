using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity.Global
{
    [Table("ITEMLISTASERVICO")]
    public class ItemListaServico : BaseEntity
    {
        [StringLength(5)]
        public string Codigo { get; set; }

        public string Descricao { get; set; }
    }
}
