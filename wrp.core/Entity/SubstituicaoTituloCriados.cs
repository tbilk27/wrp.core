using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("SUBSTITUICAOTITULOCRIADOS")]
    public class SubstituicaoTituloCriados : BaseEntity
    {
        [ForeignKey("IDSubstituicaoTitulo")]
        public SubstituicaoTitulo SubstituicaoTitulo { get; set; }
        public string IDSubstituicaoTitulo { get; set; }

        [ForeignKey("IDTitulo")]
        public Titulo Titulo { get; set; }
        public string IDTitulo { get; set; }
    }
}
