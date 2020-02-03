using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("MODELODOCUMENTOFISCAL")]
    public class ModeloDocumentoFiscal : BaseEmpresa
    {
        [Required]
        [StringLength(2)]
        [EmpresaIndex("UX_MODELODOCUMENTOFISCAL1", IsUnique = true, Order = 2)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(60)]
        public string Descricao { get; set; }

        public bool Servico { get; set; }
    }
}
