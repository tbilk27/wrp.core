using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("OPERACAOFISCALITEM")]
    public class OperacaoFiscalItem :BaseEntity
    {
        [ForeignKey("IDOperacaoFiscal")]
        public OperacaoFiscal OperacaoFiscal { get; set; }
        [Required]
        public string IDOperacaoFiscal { get; set; }

        public DestinoOperacaoFaturamento? DestinoOperacaoFaturamento { get; set; }

        public TipoProduto? TipoProduto { get; set; }

        public TipoPessoa? TipoPessoa { get; set; }

        public TipoInscricaoEstadual? TipoInscricaoEstadual { get; set; }

        public bool? TributarIPI { get; set; }

        public OrigemMercadoria? OrigemMercadoria { get; set; }

        [ForeignKey("IDTransacaoFaturamento")]
        public TransacaoFaturamento TransacaoFaturamento { get; set; }
        [Required]
        public string IDTransacaoFaturamento { get; set; }

        public decimal AliquotaICMS { get; set; }

        [ForeignKey("IDFormulaBaseCalculoICMS")]
        public FormulaBaseCalculo FormulaBaseCalculoICMS { get; set; }
        public string IDFormulaBaseCalculoICMS { get; set; }

        [ForeignKey("IDFormulaBaseCalculoIPI")]
        public FormulaBaseCalculo FormulaBaseCalculoIPI { get; set; }
        public string IDFormulaBaseCalculoIPI { get; set; }

        [ForeignKey("IDFormulaBaseCalculoPIS")]
        public FormulaBaseCalculo FormulaBaseCalculoPIS { get; set; }
        public string IDFormulaBaseCalculoPIS { get; set; }

        [ForeignKey("IDFormulaBaseCalculoCOFINS")]
        public FormulaBaseCalculo FormulaBaseCalculoCOFINS { get; set; }
        public string IDFormulaBaseCalculoCOFINS { get; set; }

        public bool? SubstituicaoTributaria { get; set; }

        public bool? ConsumidorFinal { get; set; }
    }
}
