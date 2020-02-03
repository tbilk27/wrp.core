using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("PRODUTOITEMIMAGEM")]
    public class ProdutoItemImagem : BaseEntity
    {
        [ForeignKey("IDProdutoItem")]
        public ProdutoItem ProdutoItem { get; set; }
        [Required]
        public string IDProdutoItem { get; set; }

        [ForeignKey("IDArquivo")]
        public Arquivo Arquivo { get; set; }
        public string IDArquivo { get; set; }

        public bool Principal { get; set; }
    }
}
