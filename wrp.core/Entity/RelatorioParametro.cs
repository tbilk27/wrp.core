using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("RELATORIOPARAMETRO")]
    public class RelatorioParametro : BaseEntity
    {
        [ForeignKey("IDRelatorio")]
        public Relatorio Relatorio { get; set; }
        [Required]
        public string IDRelatorio { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }

        [StringLength(100)]
        public string Classe { get; set; }

        public RelatorioParametroOrigem Origem { get; set; }

        public string ValorPadrao { get; set; }

    }
}
