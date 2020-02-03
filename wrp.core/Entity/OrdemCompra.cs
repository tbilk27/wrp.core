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
    [Table("ORDEMCOMPRA")]
    public class OrdemCompra : BaseFilial
    {
        [Required]
        [Range(0,9999999999)]
        [FilialIndex("UX_ORDEMCOMPRA1", IsUnique = true, Order = 2)]
        public int Numero { get; set; }

        [ForeignKey("IDFornecedor")]
        public Pessoa Fornecedor { get; set; }
        [Required]
        public string IDFornecedor { get; set; }

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

        public DateTime Entrega { get; set; }

        public StatusOrdemCompra StatusOrdemCompra { get; set; }

        [ForeignKey("IDOrdemCompra")]
        public virtual ICollection<OrdemCompraItem> Itens { get; set; }

    }
}
