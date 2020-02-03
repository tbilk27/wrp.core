using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("UNIDADEMEDIDA")]
    public class UnidadeMedida : BaseFilial
    {
        [StringLength(100)]
        public string Descricao { get; set; }

        [StringLength(3)]
        public string Sigla { get; set; }
    }
}
