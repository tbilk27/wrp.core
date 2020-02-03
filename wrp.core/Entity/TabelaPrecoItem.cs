using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("TABELAPRECOITEM")]
    public class TabelaPrecoItem : BaseFilial
    {
        [ForeignKey("IDTabelaPreco")]
        public TabelaPreco TabelaPreco { get; set; }
        [Required]
        public string IDTabelaPreco { get; set; }

        [ForeignKey("IDProdutoItem")]
        public ProdutoItem ProdutoItem { get; set; }
        [Required]
        public string IDProdutoItem { get; set; }

        public decimal PrecoBase { get; set; }

        [Range(0,100,ErrorMessage ="Percentual de desconto inválido!")]
        public decimal ToleranciaMinima { get; set; }

        [Range(0, 100, ErrorMessage = "Percentual de desconto inválido!")]
        public decimal ToleranciaMaxima { get; set; }

        [Range(0, 100, ErrorMessage = "Margem Dinâmica inválida!")]
        public decimal MargemDinamica { get; set; }

        [ForeignKey("IDModeloComissao")]
        public ModeloComissao ModeloComissao { get; set; }
        public string IDModeloComissao { get; set; }
    }
}
