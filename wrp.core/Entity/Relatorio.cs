using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("RELATORIO")]
    public class Relatorio : BaseFilial
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }

        [StringLength(500)]
        public string Menu { get; set; }

        [StringLength(500)]
        public string Jasper { get; set; }

        public TipoRelatorio TipoRelatorio { get; set; }

        public virtual ICollection<RelatorioParametro> Parametros { get; set; }

        public virtual ICollection<RelatorioPerfil> Perfis { get; set; }
    }
}
