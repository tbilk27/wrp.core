using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    public class Etiqueta : BaseFilial
    {
        /// <summary>
        /// Dados impressos da etiqueta
        /// </summary>
        public string DadoImpresso { get; set; }
        
        public ProdutoItem ProdutoItem { get; set; }
        public string IDProdutoItem { get; set; }

        public ProdutoLote ProdutoLote { get; set; }
        public string IDProdutoLote { get; set; }

        public Local Local { get; set; }
        public string IDLocal { get; set; }

        public decimal Quantidade { get; set; }

        public long Sequencial { get; set; }
    }
}
