using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("TIPOTITULO")]
    public class TipoTitulo : BaseFilial
    {
        [Required]
        [StringLength(60)]
        [FilialIndex("UX_TIPOTITULO_DESCRICAO")]
        public string Descricao { get; set; }

        [ForeignKey("IDFavorecidoPadrao")]
        public Pessoa FavorecidoPadrao { get; set; }
        public string IDFavorecidoPadrao { get; set; }

        [StringLength(3)]
        public string Prefixo { get; set; }

        [DataTypeDecimal(4, 2)]
        public decimal PercentualJuros { get; set; }

        [DataTypeDecimal(4, 2)]
        public decimal PercentualMulta { get; set; }

        public int DiasProtesto { get; set; }
    }
}
