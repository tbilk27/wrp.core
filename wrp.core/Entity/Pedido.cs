using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("PEDIDO")]
    public class Pedido : BaseFilial
    {
        [Required]
        [FilialIndex("UX_Codigo_Pedido", IsUnique = true)]
        public double Codigo { get; set; }

        [ForeignKey("IDCliente")]
        public Pessoa Cliente { get; set; }
        [Required]
        public string IDCliente { get; set; }

        [ForeignKey("IDTransportadora")]
        public Pessoa Transportadora { get; set; }
        public string IDTransportadora { get; set; }

        [ForeignKey("IDFormaPagamento")]
        public FormaPagamento FormaPagamento { get; set; }
        public string IDFormaPagamento { get; set; }

        [ForeignKey("IDCondicaoPagamento")]
        public CondicaoPagamento CondicaoPagamento { get; set; }
        public string IDCondicaoPagamento { get; set; }

        public DateTime Emissao { get; set; }

        public DateTime? Entrega { get; set; }

        public StatusPedido StatusPedido { get; set; }

        [ForeignKey("IDPedido")]
        public virtual ICollection<PedidoItem> Itens { get; set; }

        [ForeignKey("IDFatura")]
        public Fatura Fatura { get; set; }
        public string IDFatura { get; set; }

        [ForeignKey("IDCarteira")]
        public ContaBanco Carteira { get; set; }
        public string IDCarteira { get; set; }

        public decimal? ValorFrete { get; set; }

        [StringLength(500)]
        public string InformacoesAdicionais { get; set; }

        public  ModalidadeFrete ModalidadeFrete { get; set; }
    }
}
