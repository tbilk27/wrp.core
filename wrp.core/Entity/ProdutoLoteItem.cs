using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("PRODUTOLOTEITEM")]
    public class ProdutoLoteItem : BaseFilial
    {
        [ForeignKey("IDProdutoLote")]
        public ProdutoLote ProdutoLote { get; set; }
        public string IDProdutoLote { get; set; }

        [ForeignKey("IDProdutoEstoqueLocal")]
        public ProdutoEstoqueLocal ProdutoEstoqueLocal { get; set; }
        public string IDProdutoEstoqueLocal { get; set; }

        public decimal Quantidade { get; set; }

        public decimal QuantidadeSeparada { get; set; }

        public virtual ICollection<MovimentoEstoque> MovimentoEstoque { get; set; }
    }
}
