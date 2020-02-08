using System.Collections.Generic;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class ContaBanco : BaseFilial
    {
        public Banco Banco { get; set; }
        public string IDBanco { get; set; }

        public string Descricao { get; set; }

        public string Agencia { get; set; }

        public string DvAgencia { get; set; }

        public string Conta { get; set; }

        public string DvConta { get; set; }

        public bool PadraoPagamento { get; set; }

        public virtual ICollection<MovimentoConta> Movimentos { get; set; }

        public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
    }
}