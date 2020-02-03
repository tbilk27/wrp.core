using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("PEDIDOITEM")]
    public class PedidoItem : BaseFilial
    {
        [ForeignKey("IDPedido")]
        public Pedido Pedido { get; set; }
        [Required]
        public string IDPedido { get; set; }

        [ForeignKey("IDProdutoItem")]
        public ProdutoItem ProdutoItem { get; set; }
        [Required]
        public string IDProdutoItem { get; set; }

        [ForeignKey("IDTabelaPrecoItem")]
        public TabelaPrecoItem TabelaPrecoItem { get; set; }
        public string IDTabelaPrecoItem { get; set; }

        /// <summary>
        /// Quandidade que foi digitada para o pedido
        /// </summary>
        public decimal QuantidadeDigitada { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal QuantidadePendente { get; set; }

        /// <summary>
        /// Quantidade reservada no estoque (quando o pedido é liberado)
        /// </summary>
        public decimal QuantidadeReservada { get; set; }

        /// <summary>
        /// Quandidade que foi separada (colocada em volumes)
        /// </summary>
        public decimal QuantidadeSeparada { get; set; }

        /// <summary>
        /// Quantidade que foi Cancelada
        /// </summary>
        public decimal QuantidadeCancelada { get; set; }

        /// <summary>
        /// Quantidade que foi faturada
        /// </summary>
        public decimal QuantidadeFaturada { get; set; }

        public decimal ValorUnitario { get; set; }

        public decimal PrecoCusto { get; set; }

        [StringLength(500)]
        public string Observacao { get; set; }

    }
}
