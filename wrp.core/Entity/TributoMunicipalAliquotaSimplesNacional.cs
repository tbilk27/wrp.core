using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrp.core.Entity.Global;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    /// <summary>
    /// Esta tabela deve ser usada apenas se Filal for do Regime "Simples Nacional"
    /// Para encontrar a faixa correta, verificar volume faturado no último mês, para isso, consutar tabela FaturamentoParaImpostoSimplesNacional 
    /// </summary>
    [Table("TRIBUTOMUNICIPALALIQUOTASIMPLESNACIONAL")]
    public class TributoMunicipalAliquotaSimplesNacional : BaseFilial
    {
        [ForeignKey("IDCidade")]
        public Cidade Cidade { get; set; }
        public string IDCidade { get; set; }

        public decimal ValorMinimoFaturamento { get; set; }

        public decimal ValorMaximoFaturamento { get; set; }

        [Range(0, 5, ErrorMessage = "Percentual fora do mínimo e máximo estabelecido na  Lei Complementar 116/2003.")]
        [DataTypeDecimal(4, 2)]
        public decimal AliquotaISS { get; set; }
    }
}
