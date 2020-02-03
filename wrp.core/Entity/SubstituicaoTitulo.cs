using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("SUBSTITUICAOTITULO")]
    public class SubstituicaoTitulo : BaseFilial
    {
        public DateTime Emissao { get; set; }

        [ForeignKey("IDPessoa")]
        public Pessoa Pessoa { get; set; }
        public string IDPessoa { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required]
        public ModuloTitulo ModuloTitulo { get; set; }
    }
}
