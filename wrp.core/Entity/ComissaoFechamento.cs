using System;
using System.Collections.Generic;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class ComissaoFechamento : BaseFilial
    {
        public DateTime Data { get; set; }

        public Pessoa Favorecido { get; set; }

        public string IDFavorecido { get; set; }

        public decimal TotalDebitos { get; set; }
        public decimal TotalCreditos { get; set; }
        public decimal TotalPago { get; set; }
        public decimal BaseIR { get; set; }
        public decimal ValorIR { get; set; }
        public decimal AliquotaIR { get; set; }
        public decimal TotalTransferir { get; set; }

        public Comissao RegistroIR { get; set; }

        public string IDRegistroIR { get; set; }

        public Comissao RegistroPagto { get; set; }

        public string IDRegistroPagto { get; set; }

        public Comissao RegistroTransferencia { get; set; }

        public string IDRegistroTransferencia { get; set; }

        public Titulo TituloImposto { get; set; }

        public string IDTituloImposto { get; set; }

        public Titulo TituloPagto { get; set; }

        public string IDTituloPagto { get; set; }

        public ICollection<Comissao> Comissoes { get; set; }
    }
}