using System.Collections.Generic;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class ContaFinanceira : BaseFilial
    {
        public string Descricao { get; set; }

        public TipoContaFinanceira TipoContaFinanceira { get; set; }

        public PlanoContas PlanoContas { get; set; }

        public string IDPlanoContas { get; set; }

        public ContaFinanceira ContaFinanceiraAnalitica { get; set; }

        public string IDContaFinanceiraAnalitica { get; set; }

        public virtual ICollection<ContaFinanceira> ListaContasFilhas { get; set; }
    }
}