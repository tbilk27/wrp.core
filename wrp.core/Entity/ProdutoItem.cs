using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Global;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("PRODUTOITEM")]
    public class ProdutoItem : BaseFilial
    {
        [ForeignKey("IDProduto")]
        public Produto Produto { get; set; }
        [Required]
        public string IDProduto { get; set; }
        
        [FilialIndex("UX_SKU", 1, IsUnique = true)]
        [StringLength(100)]
        [Required]
        public string Sku { get; set; }

        [StringLength(13)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Informe apenas números.")]
        public string CodigoEAN { get; set; }

        public decimal PrecoReposicao { get; set; }

        /// <summary>
        /// Quantidade padrão agrupada em uma etiqueta. Usado no momento que é criada a etiqueta.
        /// </summary>
        public decimal QuantidadePadraoEtiqueta { get; set; }

        /// <summary>
        /// Local padrão para armazenar o produto (serve apenas como sugestão)
        /// </summary>
        [ForeignKey("IDLocal")]
        public Local Local { get; set; }
        public string IDLocal { get; set; }

        [ForeignKey("IDProdutoItem")]
        public virtual ICollection<ProdutoItemImagem> Imagens { get; set; }

        public virtual ICollection<ProdutoLote> Lotes { get; set; }

        public virtual ICollection<ProdutoItemAtributo> Atributos { get; set; }

        /// <summary>
        /// Caso o produto seja "Serviço" (Produto.TipoProduto = 9) deve-se informar o código da Item Lista Serviço para uso na geração da NFS-e
        /// </summary>
        [ForeignKey("IDItemListaServico")]
        public ItemListaServico ItemListaServico { get; set; }
        public string IDItemListaServico { get; set; }

        public ICollection<Etiqueta> Etiquetas { get; set; }

    }
}
