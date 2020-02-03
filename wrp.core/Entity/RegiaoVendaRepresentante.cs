using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("REGIAOVENDAREPRESENTANTE")]
    public class RegiaoVendaRepresentante : BaseFilial
    {
        [ForeignKey("IDRepresentante")]
        public Pessoa Representante { get; set; }
        [Required]
        [FilialIndex("UX_Regiao_Representante", 1)]
        public string IDRepresentante { get; set; }

        [ForeignKey("IDRegiaoVenda")]
        public RegiaoVenda RegiaoVenda { get; set; }
        [Required]
        [FilialIndex("UX_Regiao_Representante", 2)]
        public string IDRegiaoVenda { get; set; }
    }
}
