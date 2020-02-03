using System;
using System.Collections.Generic;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class Comissao : BaseFilial
    {
        public DateTime Data { get; set; }

        public Pessoa Favorecido { get; set; }

        public string IDFavorecido { get; set; }

        public Titulo Titulo { get; set; }

        public string IDTitulo { get; set; }

        public MovimentoTitulo MovimentoTitulo { get; set; }

        public string IDMovimentoTitulo { get; set; }

        public TipoMovimentoComissao TipoMovimentoComissao { get; set; }

        public decimal Base { get; set; }

        public decimal Percentual { get; set; }

        public decimal Valor { get; set; }

        public string Observacao { get; set; }

        public bool IncideIR { get; set; }

        public bool MovimentoManual { get; set; }

        public ComissaoFechamento ComissaoFechamento { get; set; }

        public string IDComissaoFechamento { get; set; }

        public ICollection<ComissaoFechamento> ComissoesFechamentosRegistrosIR { get; set; }

        public ICollection<ComissaoFechamento> ComissoesFechamentosRegistrosTransferencia { get; set; }

        public ICollection<ComissaoFechamento> ComissoesFechamentosRegistrosPagamentos { get; set; }


    }
}