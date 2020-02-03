using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("XMLNFE")]
    public class XMLNFE : BaseFilial
    {

        [Index]
        [StringLength(44)]
        public string ChNFe { get; set; }

        [Index]
        [StringLength(14)]
        public string EmitenteCPFCNPJ { get; set; }

        [Index]
        [StringLength(14)]
        public string DestinatarioCPFCNPJ { get; set; }

        public int ModalidadeFrete { get; set; }

        [Index]
        [StringLength(14)]
        public string TransportadoraCPFCNPJ { get; set; }

        [ForeignKey("IDSefazXML")]
        public SefazXML SefazXML { get; set; }
        [Required]
        public string IDSefazXML { get; set; }
        
        [StringLength(60)]
        public string EmitenteRazaoSocial { get; set; }

        public DateTime DataEmissao { get; set; }

        public int Numero { get; set; }

        public int Serie { get; set; }

        public decimal Valor { get; set; }

        public virtual ICollection<XMLNFEItem> Itens { get; set; }

        [ForeignKey("IDNotaFiscal")]
        public NotaFiscal NotaFiscal { get; set; }
        public string IDNotaFiscal { get; set; }
    }
}
