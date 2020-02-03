using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("LOCAL")]
    public class Local : BaseFilial
    {
        [ForeignKey("IDArmazem")]
        public Armazem Armazem { get; set; }

        [Required]
        [FilialIndex("UX_Local_Descricao", 1, IsUnique = true)]
        public string IDArmazem { get; set; }

        [StringLength(100)]
        [FilialIndex("UX_Local_Descricao", 2, IsUnique = true)]
        public string Descricao { get; set; }

        public bool PadraoEntradaNotaFiscal { get; set; }

        public int Sequencia { get; set; }
    }
}
