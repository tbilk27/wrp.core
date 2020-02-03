using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("PRODUTOLOTE")]
    public class ProdutoLote : BaseFilial
    {
        [ForeignKey("IDProdutoItem")]
        public ProdutoItem ProdutoItem { get; set; }
        public string IDProdutoItem { get; set; }

        public string Lote { get; set; }

        public DateTime DataFabricacao { get; set; }

        public DateTime DataValidade { get; set; }

        /// <summary>
        /// Indica que esse é o lote padrão do ProdutoItem quando ele não é controlado por lote.
        /// </summary>
        public bool LotePadrao { get; set; }

        [ForeignKey("IDProdutoLote")]
        public virtual ICollection<ProdutoLoteItem> ProdutoLoteItens { get; set; }
    }
}
