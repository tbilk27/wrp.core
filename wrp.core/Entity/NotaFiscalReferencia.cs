using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Global;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("NOTAFISCALREFERENCIA")]
    public class NotaFiscalReferencia : BaseEntity
    {
        //NotaFiscal 
        [ForeignKey("IDNotaFiscal")]
        public NotaFiscal NotaFiscal { get; set; }
        [Required]
        public string IDNotaFiscal { get; set; }

        [ForeignKey("IDModeloDocumentoFiscal")]
        public ModeloDocumentoFiscal ModeloDocumentoFiscal { get; set; }
        [Required]
        public string IDModeloDocumentoFiscal { get; set; }

        [StringLength(44)]
        public string ChaveNFeCTe { get; set; }

        [ForeignKey("IDPessoa")]
        public Pessoa Pessoa { get; set; }
        public string IDPessoa { get; set; }

        //emissão
        public DateTime? DataEmissao { get; set; }

        public string Serie { get; set; }

        public int? NumeroNotaFiscal { get; set; }

        public int? NumeroSequencialECF { get; set; }

        public int? NumeroContadorOrdemOperacao { get; set; }
    }
}
