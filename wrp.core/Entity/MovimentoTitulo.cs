using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("MOVIMENTOTITULO")]
    public class MovimentoTitulo : BaseFilial
    {
        [ForeignKey("IDTitulo")]
        public Titulo Titulo { get; set; }
        public string IDTitulo { get; set; }

        public DateTime DataMovimento { get; set; }

        public decimal ValorPago { get; set; }

        public decimal ValorDesconto { get; set; }

        public decimal ValorMulta { get; set; }

        public decimal ValorJuros { get; set; }

        public decimal ValorDespesas { get; set; }

        public decimal ValorDevolucao { get; set; }

        public decimal ValorPerdas { get; set; }

        [ForeignKey("IDContaBanco")]
        public ContaBanco ContaBanco { get; set; }
        public string IDContaBanco { get; set; }

        [ForeignKey("IDCheque")]
        public Cheque Cheque { get; set; }
        public string IDCheque { get; set; }

        public TipoBaixaMovimentoTitulo TipoBaixaMovimentoTitulo { get; set; }

        public ICollection<Comissao> Comissoes { get; set; }
    }
}
