using System;
using System.Collections.Generic;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class MovimentoConta : BaseFilial
    {
        public ContaBanco ContaBanco { get; set; }
        public string IDContaBanco { get; set; }

        public MovimentoTitulo MovimentoTitulo { get; set; }
        public string IDMovimentoTitulo { get; set; }

        public TipoMovimentoConta TipoMovimentoConta { get; set; }

        public string Referencia { get; set; }

        public decimal ValorMovimento { get; set; }

        public string Historico { get; set; }

        public DateTime DataMovimento { get; set; }

        public ContaFinanceira ContaFinanceira { get; set; }
        public string IDContaFinanceira { get; set; }

        public MovimentoConta MovimentoContaTransferencia { get; set; }

        public string IDMovimentoContaTransferencia { get; set; }

        public bool Transferencia { get; set; }

        public Cheque Cheque { get; set; }
        public string IDCheque { get; set; }

        public ICollection<MovimentoConta> MovimentosTransferencias { get; set; }
    }
}