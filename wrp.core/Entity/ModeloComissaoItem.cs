using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("MODELOCOMISSAOITEM")]
    public class ModeloComissaoItem : BaseFilial
    {
        [ForeignKey("IDModeloComissao")]
        public ModeloComissao ModeloComissao { get; set; }
        public string IDModeloComissao { get; set; }

        public decimal QuantidadeMinima { get; set; }

        public decimal QuantidadeMaxima { get; set; }

        public decimal PercentualVendaExclusiva { get; set; }
        public decimal PercentualVendedor { get; set; }
        public decimal PercentualCallCenter { get; set; }
    }
}
