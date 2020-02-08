using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    public class FilialTributosFederaisServicos : BaseFilial
    {
        public decimal AliquotaPIS { get; set; }

        public decimal ValorMinimoPIS { get; set; }

        public decimal AliquotaCofins { get; set; }

        public decimal ValorMinimoCofins { get; set; }

        public decimal AliquotaINSS { get; set; }

        public decimal ValorMinimoINSS { get; set; }

        public decimal AliquotaIR { get; set; }

        public decimal ValorMinimoIR { get; set; }

        public decimal AliquotaCSLL { get; set; }

        public decimal ValorMinimoCSLL { get; set; }

        public decimal AliquotaPS { get; set; }

        public decimal ValorMinimoPS { get; set; }
    }
}
