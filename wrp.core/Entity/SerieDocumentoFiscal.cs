using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("SERIEDOCUMENTOFISCAL")]
    public class SerieDocumentoFiscal : BaseFilial
    {
        [Required]
        [StringLength(60)]
        [FilialIndex("UX_SERIEDOCUMENTOFISCAL1", IsUnique = true, Order = 2)]
        public string Descricao { get; set; }

        [StringLength(3)]
        [Required]
        public string SerieLegal { get; set; }

        [ForeignKey("IDModeloDocumentoFiscal")]
        public ModeloDocumentoFiscal ModeloDocumentoFiscal { get; set; }
        public string IDModeloDocumentoFiscal { get; set; }

        [StringLength(3)]
        public string SeparadorTitulo { get; set; }

        public int Contador { get; set; }

        [ForeignKey("IDTipoTitulo")]
        public TipoTitulo TipoTitulo { get; set; }
        public string IDTipoTitulo { get; set; }

        public bool EmiteNFe { get; set; }

        public bool EmiteNFSe { get; set; }

        public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }

    }
}
