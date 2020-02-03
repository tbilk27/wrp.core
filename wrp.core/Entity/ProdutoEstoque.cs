using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("PRODUTOESTOQUE")]
    public class ProdutoEstoque : BaseEntity
    {

        [ForeignKey("IDProdutoItem")]
        public ProdutoItem ProdutoItem { get; set; }
        [Required]
        [Index(IsUnique = true)]
        public string IDProdutoItem { get; set; }

        /// <summary>
        /// Quantidade disponível no estoque, sem nenhum tipo de reserva (A quantidade total é a soma das quantidades não esse campo)
        /// </summary>
        public decimal QuantidadeDisponivel { get; set; }

        /// <summary>
        /// Quantidade reservada para pedidos
        /// </summary>
        public decimal QuantidadePedido { get; set; }

        public decimal QuantidadeSeparada { get; set; }

        public decimal PrecoMedio { get; set; }
    }
}
