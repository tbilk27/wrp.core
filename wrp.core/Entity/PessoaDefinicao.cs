using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("PESSOADEFINICAO")]
    public class PessoaDefinicao : BaseFilial
    {
        [ForeignKey("IDPessoa")]
        public Pessoa Pessoa { get; set; }
        [Required]
        [Index("IX_PessoaDefinicao", IsUnique = true, Order = 1)]
        public string IDPessoa { get; set; }

        [ForeignKey("IDCondicaoPagamento")]
        public CondicaoPagamento CondicaoPagamento { get; set; }
        public string IDCondicaoPagamento { get; set; }

        [ForeignKey("IDFormaPagamento")]
        public FormaPagamento FormaPagamento { get; set; }
        public string IDFormaPagamento { get; set; }

        [ForeignKey("IDTabelaPreco")]
        public TabelaPreco TabelaPreco { get; set; }
        public string IDTabelaPreco { get; set; }

        [ForeignKey("IDRota")]
        public Rota Rota { get; set; }
        public string IDRota { get; set; }

        [ForeignKey("IDContaFinanceiraDespesa")]
        public ContaFinanceira ContaFinanceiraDespesa { get; set; }
        public string IDContaFinanceiraDespesa { get; set; }

        [ForeignKey("IDContaFinanceiraReceita")]
        public ContaFinanceira ContaFinanceiraReceita { get; set; }
        public string IDContaFinanceiraReceita { get; set; }

        [ForeignKey("IDRegiaoVenda")]
        public RegiaoVenda RegiaoVenda { get; set; }
        public string IDRegiaoVenda { get; set; }

        public bool ConsumidorFinal { get; set; }

        public decimal? ValorMinimoFreteGratis { get; set; } // ATENÇÃO, Manter nullable!

        public decimal? ValorSugeridoFrete { get; set; }

        public ModalidadeFrete ModalidadeFrete { get; set; }
    }
}
