using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class NotaFiscal : BaseFilial
    {
        //nota fiscal
        [Range(1, 999999999, ErrorMessage = "Número de nota fiscal inválido.")]
        public int NumeroNotaFiscal { get; set; }

        //emissão
        public DateTime DataEmissao { get; set; }

        //data de movimento
        public DateTime DataMovimento { get; set; }

        //Tipo de Emissão
        public TipoEmissaoNotaFiscal TipoEmissaoNotaFiscal { get; set; }

        //operação
        public OperacaoTransacaoFaturamento Operacao { get; set; }

        //Destinatário
        public Pessoa Pessoa { get; set; }

        public string IDPessoa { get; set; }

        //Série
        public SerieDocumentoFiscal Serie { get; set; }

        public string IDSerie { get; set; }

        //chave NFe
        public string ChaveNFe { get; set; }

        //modalidade de frete
        public ModalidadeFrete ModalidadeFrete { get; set; }

        //transportadora
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

        public CondicaoPagamento CondicaoPagamento { get; set; }
        public string IDCondicaoPagamento { get; set; }

        public ContaFinanceira ContaFinanceira { get; set; }
        public string IDContaFinanceira { get; set; }

        public ContaBanco ContaBanco { get; set; }
        public string IDContaBanco { get; set; }

        public SituacaoNotaFiscal Situacao { get; set; }

        public bool Rascunho { get; set; }

        public OperacaoFiscal OperacaoFiscal { get; set; }
        public string IDOperacaoFiscal { get; set; }

        public virtual ICollection<NotaFiscalItem> Itens { get; set; }

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