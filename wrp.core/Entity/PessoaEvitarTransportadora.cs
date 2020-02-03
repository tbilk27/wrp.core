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
    [Table("PESSOAEVITARTRANSPORTADORA")]
    public class PessoaEvitarTransportadora : BaseFilial
    {
        [ForeignKey("IDPessoa")]
        public Pessoa Pessoa { get; set; }
        [Required]
        [Index("UX_PessoaEvitarTransportadora", Order = 1, IsUnique = true)]
        public string IDPessoa { get; set; }


        [ForeignKey("IDTransportadora")]
        public Pessoa Transportadora { get; set; }
        [Required]
        [Index("UX_PessoaEvitarTransportadora", Order = 2, IsUnique = true)]
        public string IDTransportadora { get; set; }
    }


}
