using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("PESSOACONTATO")]
    public class PessoaContato : BaseEntity
    {
        [ForeignKey("IDPessoa")]
        public Pessoa Pessoa { get; set; }
        [Required]
        public string IDPessoa { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(3)]
        public string DDD { get; set; }

        [StringLength(20)]
        public string Telefone { get; set; }

        public bool WhatsApp { get; set; }

        [StringLength(5)]
        public string Ramal { get; set; }

        [StringLength(3)]
        public string DDD2 { get; set; }

        [StringLength(20)]
        public string Telefone2 { get; set; }

        public bool WhatsApp2 { get; set; }

        [StringLength(5)]
        public string Ramal2 { get; set; }

        [StringLength(50)]
        public string FuncaoCargo { get; set; }
    }
}
