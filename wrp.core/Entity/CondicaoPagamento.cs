using System.Collections.Generic;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class CondicaoPagamento : BaseFilial
    {
        public string Descricao { get; set; }

        public decimal Desconto { get; set; }

        public decimal Acrescimo { get; set; }

        public decimal ValorMinimo { get; set; }

        public virtual ICollection<CondicaoPagamentoItem> Itens { get; set; }
    }
}