using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("OPERACAOFISCAL")]
    public class OperacaoFiscal : BaseFilial
    {
        [StringLength(60)]
        [FilialIndex("UX_OPERACAOFISCAL1", IsUnique = true, Order = 2)]
        [Required]
        public string Descricao { get; set; }

        [StringLength(200)]
        public string Observacao { get; set; }

        public decimal AliquotaPIS { get; set; }

        public decimal AliquotaCOFINS { get; set; }

        public bool TributarIPI { get; set; }

        public OperacaoTransacaoFaturamento Operacao { get; set; }

        public FinalidadeEmissaoNFe FinalidadeEmissao { get; set; }

        public bool Ativo { get; set; }

        public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
    }
}
