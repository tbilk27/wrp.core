using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("MOVIMENTOCONTA")]
    public class MovimentoConta : BaseFilial
    {

        [ForeignKey("IDContaBanco")]
        public ContaBanco ContaBanco { get; set; }
        [Required]
        public string IDContaBanco { get; set; }

        [ForeignKey("IDMovimentoTitulo")]
        public MovimentoTitulo MovimentoTitulo { get; set; }
        public string IDMovimentoTitulo { get; set; }

        [Required]
        public TipoMovimentoConta TipoMovimentoConta { get; set; }

        [StringLength(100)]
        [Required]
        public string Referencia { get; set; }

        public decimal ValorMovimento { get; set; }

        [StringLength(200)]
        public string Historico { get; set; }

        [Required]
        public DateTime DataMovimento { get; set; }

        [ForeignKey("IDContaFinanceira")]
        public ContaFinanceira ContaFinanceira { get; set; }
        [Required]
        public string IDContaFinanceira { get; set; }

        [ForeignKey("IDMovimentoContaTransferencia")]
        public MovimentoConta MovimentoContaTransferencia { get; set; }

        public string IDMovimentoContaTransferencia { get; set; }

        public bool Transferencia { get; set; }

        [ForeignKey("IDCheque")]
        public Cheque Cheque { get; set; }
        public string IDCheque { get; set; }
    }
}
