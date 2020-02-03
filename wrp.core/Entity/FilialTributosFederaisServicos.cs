using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("FILIALTRIBUTOSFEDERAISSERVICOS")]
    public class FilialTributosFederaisServicos : BaseFilial
    {
        [DataTypeDecimal(4, 2)]
        public decimal AliquotaPIS { get; set; }

        public decimal ValorMinimoPIS { get; set; }

        [DataTypeDecimal(4, 2)]
        public decimal AliquotaCofins { get; set; }

        public decimal ValorMinimoCofins { get; set; }

        [DataTypeDecimal(4, 2)]
        public decimal AliquotaINSS { get; set; }

        public decimal ValorMinimoINSS { get; set; }

        [DataTypeDecimal(4, 2)]
        public decimal AliquotaIR { get; set; }

        public decimal ValorMinimoIR { get; set; }

        [DataTypeDecimal(4, 2)]
        public decimal AliquotaCSLL { get; set; }

        public decimal ValorMinimoCSLL { get; set; }

        [DataTypeDecimal(4, 2)]
        public decimal AliquotaPS { get; set; }

        public decimal ValorMinimoPS { get; set; }
    }
}
