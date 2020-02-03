using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("XMLNFEITEM")]
    public class XMLNFEItem : BaseEntity
    {
        [ForeignKey("IDXMLNFE")]
        public XMLNFE XMLNFE { get; set; }
        [Required]
        public string IDXMLNFE { get; set; }
        
        /// <summary>
        /// Ordem que aparece na nota
        /// </summary>
        public int Numero { get; set; }

        [StringLength(14)]
        public string EAN { get; set; }

        [StringLength(60)]
        public string Codigo { get; set; }

        [StringLength(120)]
        public string Descricao { get; set; }

        public decimal Quantidade { get; set; }

        [StringLength(6)]
        public string Unidade { get; set; }

        public decimal ValorUnitario { get; set; }

        public decimal Frete { get; set; }

        public decimal Desconto { get; set; }

        [StringLength(15)]
        public string OC { get; set; } // OC informada no xml

        public int OCItem { get; set; } // Número do item da OC informado no xml
    }
}
