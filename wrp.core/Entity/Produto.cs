using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("PRODUTO")]
    public class Produto : BaseFilial
    {
        [Required]
        public TipoProduto TipoProduto { get; set; }

        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }

        [StringLength(100)]
        public string DescricaoNota { get; set; }

        [FilialIndex("UX_Produto_Referencia", IsUnique = true)]
        [StringLength(100)]
        public string Referencia { get; set; }

        //[ForeignKey("IDCategoriaProduto")]
        [ForeignKeyMsg("IDCategoriaProduto", ErrorMessage = "Mensagem de Teste")]
        public CategoriaProduto CategoriaProduto { get; set; }
        public string IDCategoriaProduto { get; set; }

        [ForeignKey("IDUnidadeMedida")]
        public UnidadeMedida UnidadeMedida { get; set; }
        public string IDUnidadeMedida { get; set; }

        [ForeignKey("IDModeloComissao")]
        public ModeloComissao ModeloComissao { get; set; }
        public string IDModeloComissao { get; set; }

        [ForeignKey("IDMarcaProduto")]
        public MarcaProduto MarcaProduto { get; set; }
        public string IDMarcaProduto { get; set; }

        [ForeignKey("IDNCM")]
        public NCM NCM { get; set; }
        public string IDNCM { get; set; }

        public OrigemMercadoria OrigemMercadoria { get; set; }

        [StringLength(500)]
        public string Especificacao { get; set; }

        [DataTypeDecimal(4, 2)]
        public decimal MVA { get; set; }
    }
}
