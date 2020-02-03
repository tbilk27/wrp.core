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
    [Table("TITULOCOMISSAO")]
    public class TituloComissao : BaseFilial
    {
        [ForeignKey("IDTitulo")]
        public Titulo Titulo { get; set; }
        [Required]
        public string IDTitulo { get; set; }

        [ForeignKey("IDPessoa")]
        public Pessoa Pessoa { get; set; }
        [Required]
        public string IDPessoa { get; set; }

        public decimal Percentual { get; set; }
    }
}
