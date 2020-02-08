using System;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class FaturamentoParaImpostoSimplesNacional : BaseFilial
    {
        public DateTime AnoMes { get; set; }

        public decimal ValorFaturadoServico { get; set; }
    }
}