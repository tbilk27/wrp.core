using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("ETIQUETA")]
    public class Etiqueta : BaseFilial
    {
        /// <summary>
        /// Dados impressos da etiqueta
        /// </summary>
        [StringLength(500)]
        public string DadoImpresso { get; set; }
        
        [ForeignKey("IDProdutoItem")]
        public ProdutoItem ProdutoItem { get; set; }
        public string IDProdutoItem { get; set; }

        [ForeignKey("IDProdutoLote")]
        public ProdutoLote ProdutoLote { get; set; }
        public string IDProdutoLote { get; set; }

        [ForeignKey("IDLocal")]
        public Local Local { get; set; }
        public string IDLocal { get; set; }

        public decimal Quantidade { get; set; }

        //[FilialIndex("UX_Sequencial_Etiqueta", 1, IsUnique = true)]
        public long Sequencial { get; set; }
    }
}
