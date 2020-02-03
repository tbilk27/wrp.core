using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("MOVIMENTOESTOQUE")]
    public class MovimentoEstoque : BaseEntity
    {
        [ForeignKey("IDProdutoLoteItem")]
        public ProdutoLoteItem ProdutoLoteItem { get; set; }
        [Required]
        public string IDProdutoLoteItem { get; set; }
        
        public TipoMovimentoEstoque Tipo { get; set; }

        public decimal Quantidade { get; set; }

        [StringLength(200)]
        public string Historico { get; set; }

        [Required]
        public DateTime DataMovimento { get; set; }

        public decimal PrecoCusto { get; set; }
    }
}
