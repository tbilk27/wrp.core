using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Global;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("NOTAFISCALITEM")]
    public class NotaFiscalItem : BaseEntity
    {
        //NotaFiscal 
        [ForeignKey("IDNotaFiscal")]
        public NotaFiscal NotaFiscal { get; set; }
        [Required]
        public string IDNotaFiscal { get; set; }

        [ForeignKey("IDProdutoItem")]
        public ProdutoItem ProdutoItem { get; set; }
        [Required]
        public string IDProdutoItem { get; set; }

        [ForeignKey("IDProdutoLote")]
        public ProdutoLote ProdutoLote { get; set; }
        public string IDProdutoLote { get; set; }

        public decimal Quantidade { get; set; }

        public decimal ValorUnitario { get; set; }

        public decimal ValorDesconto { get; set; }

        public decimal ValorMercadoria { get; set; }

        public decimal ValorFrete { get; set; }

        [ForeignKey("IDTransacaoFaturamento")]
        public TransacaoFaturamento TransacaoFaturamento { get; set; }
        [Required]
        public string IDTransacaoFaturamento { get; set; }

        public decimal BaseICMS { get; set; }
        public decimal BaseIPI { get; set; }
        public decimal BasePIS { get; set; }
        public decimal BaseCOFINS { get; set; }

        [DataTypeDecimal(4, 2)]
        public decimal AliquotaICMS { get; set; }
        [DataTypeDecimal(4, 2)]
        public decimal AliquotaIPI { get; set; }
        [DataTypeDecimal(4, 2)]
        public decimal AliquotaPIS { get; set; }
        [DataTypeDecimal(4, 2)]
        public decimal AliquotaCOFINS { get; set; }

        public decimal ValorICMS { get; set; }
        public decimal ValorIPI { get; set; }
        public decimal ValorPIS { get; set; }
        public decimal ValorCOFINS { get; set; }

        public decimal BaseCreditoSN { get; set; }
        [DataTypeDecimal(4, 2)]
        public decimal PercCreditoSN { get; set; }
        public decimal ValorCreditoSN { get; set; }

        [ForeignKey("IDMovimentoEstoque")]
        public MovimentoEstoque MovimentoEstoque { get; set; }
        public string IDMovimentoEstoque { get; set; }

        // Para NFS-e ----------------
        [ForeignKey("IDCidadePestacaoServico")]
        public Cidade CidadePestacaoServico { get; set; }
        public string IDCidadePestacaoServico { get; set; }

        public string DescricaoServico { get; set; }

        [ForeignKey("IDCSTISS")]
        public CSTISS CSTISS { get; set; }
        public string IDCSTISS { get; set; }

        [DataTypeDecimal(4, 2)]
        [Range(0, 5, ErrorMessage = "Percentual fora do mínimo e máximo estabelecido na  Lei Complementar 116/2003.")]
        public decimal AliquotaISS { get; set; }

        public decimal ValorISS { get; set; }

        public bool TributaMunicipioPrestador { get; set; }

        public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
    }
}
