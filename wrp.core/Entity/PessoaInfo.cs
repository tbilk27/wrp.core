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
    [Table("PESSOAINFO")]
    public class PessoaInfo : BaseEntity
    {
        [ForeignKey("IDPessoa")]
        public Pessoa Pessoa { get; set; }
        [Required]
        public string IDPessoa { get; set; }

        public TipoInfo Tipo { get; set; }

        [Required]
        [StringLength(400)]
        public string Descricao { get; set; }
        
        [ForeignKey("IDUsuarioExclusao")]
        public Usuario UsuarioExlusao { get; set; }
        public string IDUsuarioExclusao { get; set; }

        public DateTime? DataExclusao { get; set; }

        public bool BloqueioAutomaticoCredito { get; set; }

    }
}
