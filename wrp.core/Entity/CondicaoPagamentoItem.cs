using System.Collections.Generic;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class CondicaoPagamentoItem : BaseEntity
    {
        public CondicaoPagamento CondicaoPagamento { get; set; }
        public string IDCondicaoPagamento { get; set; }

        public int Dias { get; set; }

        public ICollection<CondicaoPagamento> CondicoesPagamentos { get; set; }
    }
}