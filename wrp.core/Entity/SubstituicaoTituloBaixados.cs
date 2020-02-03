using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("SUBSTITUICAOTITULOBAIXADOS")]
    public class SubstituicaoTituloBaixados : BaseEntity
    {
        [ForeignKey("IDSubstituicaoTitulo")]
        public SubstituicaoTitulo SubstituicaoTitulo { get; set; }
        public string IDSubstituicaoTitulo { get; set; }

        [ForeignKey("IDMovimentoTitulo")]
        public MovimentoTitulo MovimentoTitulo { get; set; }
        public string IDMovimentoTitulo { get; set; }
    }
}
