using System;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class MovimentoEstoque : BaseEntity
    {
        public ProdutoLoteItem ProdutoLoteItem { get; set; }
        public string IDProdutoLoteItem { get; set; }

        public TipoMovimentoEstoque Tipo { get; set; }

        public decimal Quantidade { get; set; }

        public string Historico { get; set; }

        public DateTime DataMovimento { get; set; }

        public decimal PrecoCusto { get; set; }
    }
}