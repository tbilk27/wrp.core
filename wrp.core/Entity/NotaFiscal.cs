using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("NOTAFISCAL")]
    public class NotaFiscal : BaseFilial
    {
        //nota fiscal
        [Required]
        [Range(1, 999999999, ErrorMessage = "Número de nota fiscal inválido.")]
        [FilialIndex("UX_NOTAFISCAL1", IsUnique = true, Order = 2)]
        public int NumeroNotaFiscal { get; set; }

        //emissão
        [Required]
        public DateTime DataEmissao { get; set; }

        //data de movimento       
        [Required]
        public DateTime DataMovimento { get; set; }

        //Tipo de Emissão
        [Required]
        [FilialIndex("UX_NOTAFISCAL1", IsUnique = true, Order = 3)]
        public TipoEmissaoNotaFiscal TipoEmissaoNotaFiscal { get; set; }

        //operação
        [Required]
        public OperacaoTransacaoFaturamento Operacao { get; set; }

        //Destinatário
        [ForeignKey("IDPessoa")]
        public Pessoa Pessoa { get; set; }
        [Required]
        [FilialIndex("UX_NOTAFISCAL1", IsUnique = true, Order = 5)]
        public string IDPessoa { get; set; }

        //Série
        [ForeignKey("IDSerie")]
        public SerieDocumentoFiscal Serie { get; set; }
        [Required]
        [FilialIndex("UX_NOTAFISCAL1", IsUnique = true, Order = 4)]
        public string IDSerie { get; set; }

        //chave NFe
        [StringLength(44)]
        public string ChaveNFe { get; set; }

        //modalidade de frete
        [Required]
        public ModalidadeFrete ModalidadeFrete { get; set; }

        //transportadora
        [ForeignKey("IDTransportadora")]
        public Pessoa Transportadora { get; set; }
        public string IDTransportadora { get; set; }

        public decimal ValorMercadoria { get; set; }
        public decimal ValorNF { get; set; }
        public decimal ValorDuplicatas { get; set; }
        public decimal ValorICMS { get; set; }
        public decimal ValorIPI { get; set; }
        public decimal ValorPIS { get; set; }
        public decimal ValorCOFINS { get; set; }
        public decimal ValorFrete { get; set; }
        public decimal ValorDesconto { get; set; }

        [ForeignKey("IDCondicaoPagamento")]
        public CondicaoPagamento CondicaoPagamento { get; set; }
        public string IDCondicaoPagamento { get; set; }

        [ForeignKey("IDContaFinanceira")]
        public ContaFinanceira ContaFinanceira { get; set; }
        public string IDContaFinanceira { get; set; }

        [ForeignKey("IDContaBanco")]
        public ContaBanco ContaBanco { get; set; }
        public string IDContaBanco { get; set; }

        public SituacaoNotaFiscal Situacao { get; set; }

        public bool Rascunho { get; set; }

        [ForeignKey("IDOperacaoFiscal")]
        public OperacaoFiscal OperacaoFiscal { get; set; }
        public string IDOperacaoFiscal { get; set; }

        [ForeignKey("IDNotaFiscal")]
        public virtual ICollection<NotaFiscalItem> Itens { get; set; }

        [ForeignKey("IDNotaFiscal")]
        public virtual ICollection<NotaFiscalReferencia> NotasReferenciadas { get; set; }

        public string Observacao { get; set; }

        public decimal BaseCreditoSN { get; set; }
        public decimal ValorCreditoSN { get; set; }

        // Para NFS-e ---------------
        public decimal ValorIR { get; set; }
        public decimal ValorINSS { get; set; }
        public decimal ValorCSLL { get; set; }

    }
}
