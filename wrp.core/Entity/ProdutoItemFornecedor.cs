using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("PRODUTOITEMFORNECEDOR")]
    public class ProdutoItemFornecedor : BaseEntity
    {

        // Produto

        [ForeignKey("IDProdutoItem")]
        public ProdutoItem ProdutoItem { get; set; }

        [Required]
        [StringLength(36)]
        public string IDProdutoItem { get; set; }

        // Fornecedor

        [ForeignKey("IDPessoa")]
        public Pessoa Pessoa { get; set; }

        [Required]
        [StringLength(36)]
        public string IDPessoa { get; set; }
        
        // Tipo de etiqueta

        [ForeignKey("IDRelatorio")]
        public Relatorio Relatorio { get; set; }

        [StringLength(36)]
        public string IDRelatorio { get; set; }

        // Quantidade contida na embalagem
        public decimal Quantidade { get; set; }

        /// <summary>
        /// Código que o fornecedor usa para o item
        /// </summary>
        [Required]
        [StringLength(50)]
        public string CodigoFornecedor { get; set; }

        /// <summary>
        /// Unidade de medida informada pelo fornecedor na nota fiscal (vende em pacote, vende em kilo, etc)
        /// </summary>
        [StringLength(30)]
        public string UnidadeMedidaFornecedorNF { get; set; }

        [ForeignKey("IDUnidadeMedidaFornecedor")]
        public UnidadeMedida UnidadeMedidaFornecedor { get; set; }
        public string IDUnidadeMedidaFornecedor { get; set; }

        /// <summary>
        /// A unidade de medida do fornecedor multiplicada pelo faltor de conversão deve ser igual a unidade de armazenagem
        /// </summary>
        public decimal FatorConversao { get; set; }
    }
}
