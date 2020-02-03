using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("PARAMETROSEMISSAONFE")]
    public class ParametrosEmissaoNFe  : BaseEntity
    {
        [ForeignKey("IDFilial")]
        public Filial Filial { get; set; }
        [Index("UX_ParametrosEmissaoNFe_1", IsUnique = true)]
        public string IDFilial { get; set; }

        public FormaEmissaoNFe FormaEmissaoNFe { get; set; }

        public FormatoImpressaoDanfe FormatoImpressaoDanfe { get; set; }

        public TipoAmbienteNFe TipoAmbienteNFe { get; set; }

        public DateTime ? DataContingencia { get; set; }

        [StringLength(256)]
        public string JustificativaContingencia { get; set; }

        [DataTypeDecimal(4, 2)]
        public decimal PercCreditoSN { get; set; }
    }
}
