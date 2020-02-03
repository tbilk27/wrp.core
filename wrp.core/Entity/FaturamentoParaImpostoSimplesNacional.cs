using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("FATURAMENTOPARAIMPOSTOSIMPLESNACIONAL")]
    public class FaturamentoParaImpostoSimplesNacional : BaseFilial
    {
        public DateTime AnoMes { get; set; }

        public decimal ValorFaturadoServico { get; set; }
    }
}
