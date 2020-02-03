using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("MODELOCOMISSAO")]
    public class ModeloComissao : BaseFilial
    {
        [StringLength(200)]
        public string Descricao { get; set; }

        public TipoComissao TipoComissao { get; set; }
    }
}
