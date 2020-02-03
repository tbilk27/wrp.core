using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Global;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("TRIBUTOMUNICIPAL")]
    public class TributoMunicipal : BaseFilial
    {
        [ForeignKey("IDItemListaServico")]
        public ItemListaServico ItemListaServico { get; set; }
        public string IDItemListaServico { get; set; }

        public bool TributaMunicipioPrestador { get; set; }

        [ForeignKey("IDCSTISS")]
        public CSTISS CSTISS { get; set; }
        public string IDCSTISS { get; set; }

        [Range(0, 5, ErrorMessage = "Percentual fora do mínimo e máximo estabelecido na  Lei Complementar 116/2003.")]
        [DataTypeDecimal(4, 2)]
        // Campo utilizado apenas se empresa NÃO for do Simples Nacional, caso contrário usar alíquota da tabela TributoMunicipalAliquotaSimplesNacional
        public decimal AliquotaISS { get; set; }
    }
}
